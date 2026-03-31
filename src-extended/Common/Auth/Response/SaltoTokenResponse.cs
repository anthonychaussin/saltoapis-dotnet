namespace Saltoapis.Auth.Response
{
    class SaltoTokenResponse
    {
        internal const int TokenExpiryTimeWindowSeconds = 60 * 5;

        private double? _expiresIn;
        private DateTimeOffset? authenticationExpiration;

        [JsonPropertyName("access_token")]
        public string AccessToken
        { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType
        { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken
        { get; set; }

        [JsonPropertyName("scope")]
        public string Scope
        { get; set; }

        [JsonPropertyName("expires_in")]
        public double? ExpiresIn // expiration in seconds
        {
            get => _expiresIn;
            set
            {
                _expiresIn = value;
                UpdateExpiration();
            }
        }

        void UpdateExpiration()
        {
            // update expiration time
            if (ExpiresIn.HasValue)
            {
                authenticationExpiration = DateTimeOffset.Now.AddSeconds(ExpiresIn ?? 0);
            }
            else
            {
                authenticationExpiration = null;
            }
        }

        public bool IsExpired() => authenticationExpiration != null && DateTimeOffset.Now.AddSeconds(TokenExpiryTimeWindowSeconds) >= authenticationExpiration;
    }
}