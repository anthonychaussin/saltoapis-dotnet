using Saltoapis.Auth.Response;
using System.Text.Json;

namespace Saltoapis.Auth
{
    /// <summary>
    /// This class performs the OAuth2 client credentials flow. It gets a valid
    /// access token from the authorization server and stores it while it's still
    /// valid. When its close to expiration a new one will be automatically requested.
    /// </summary>
    public class SaltoOAuthClient(String id, String secret, String[] scopes, String discoveryHost = "account.saltosystems.com") : IOAuthClientCredentialsProvider
    {
        OIDCConfiguration cachedOidcConfiguration; // refeshed every 24 hours
        DateTimeOffset? oidcCacheExpiration;

        SaltoTokenResponse token;

        readonly String discoveryUri = string.Format("https://{0}/.well-known/openid-configuration", discoveryHost);
        readonly String clientId = id;
        readonly String clientSecret = secret;
        readonly String[] scopes = scopes;

        /**
         * Returns a client token. The token may be cached and return immediately.
         *
         * It may throw a SaltoOAuthException if authentication server is not accessible
         * or credentials are invalid.
         */
        public async Task<string> GetToken()
        {
            if (token != null && !token.IsExpired())
            {
                // token is still valid
            }
            else
            {
                // Token is expired or null. Getting a new one.
                // expired token => get a new one
                SaltoTokenResponse tokenResult = await GetNewToken();

                token = tokenResult;
            }

            return token.AccessToken;
        }

        async Task<SaltoTokenResponse> GetNewToken()
        {
            using HttpClient httpClient = new();
            // oidc discovery
            await EnsureOidcConfiguration(httpClient);
            // OAuth token
            return await ObtainOAuthToken(httpClient);
        }

        /**
         * Gets and keeps a 24 hour cache for the oidc configuration.
         * If it fails to access the configuration URI but a previous
         * configuration is accesible it will just log a warning.
         * Otherwise it will throw an error.
         */
        async Task EnsureOidcConfiguration(HttpClient httpClient)
        {
            if (cachedOidcConfiguration == null || IsOidcCacheExpired())
            {
                HttpResponseMessage responseMessage = await httpClient.GetAsync(discoveryUri);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string result = await responseMessage.Content.ReadAsStringAsync();

                    cachedOidcConfiguration = JsonSerializer.Deserialize<OIDCConfiguration>(result);
                    oidcCacheExpiration = DateTimeOffset.Now.AddHours(24);
                }
                else
                {
                    // we could not get the oidc config.
                    if (cachedOidcConfiguration != null)
                    {
                        // just continue with the previous value
                        Console.WriteLine("WARN: Could not get the oidc config. Trying with the previous value.");
                    }
                    else
                    {
                        throw new SaltoOAuthException("Could not get the oidc config. Is server accesible?");
                    }
                }
            }
        }

        async Task<SaltoTokenResponse> ObtainOAuthToken(HttpClient httpClient)
        {
            // build token request post data
            List<KeyValuePair<string, string>> postData =
            [
                new("grant_type", "client_credentials"),
                new("client_id", clientId),
                new("client_secret", clientSecret),
                new("scope", string.Join(" ", scopes))
            ];

            using FormUrlEncodedContent formBody = new(postData);
            HttpResponseMessage responseMessage = await httpClient.PostAsync(cachedOidcConfiguration.TokenEndpoint, formBody);
            string result = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.IsSuccessStatusCode)
            {
                token = JsonSerializer.Deserialize<SaltoTokenResponse>(result);
                return token;
            }
            else
            {
                // get error
                TokenError error = JsonSerializer.Deserialize<TokenError>(result);
                throw new SaltoOAuthException($"Error getting the access_token. Server returned {responseMessage.StatusCode} error ( error = '{error.Error}', error_hint = '{error.ErrorHint}', description = '{error.ErrorDescription}')");
            }
        }

        bool IsOidcCacheExpired() => oidcCacheExpiration != null && DateTimeOffset.Now >= oidcCacheExpiration.Value;
        public void InvalidateToken()
        {
            token = null;
        }
    }
}