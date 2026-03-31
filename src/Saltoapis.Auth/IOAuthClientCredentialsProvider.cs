using System.Threading.Tasks; // Task

namespace Saltoapis.Auth
{
    /// <summary>
    /// Provides a valid access token for an OAuth server.
    ///
    /// The access token should be stored and cached by this class,
    /// requesting a new one to the server before previous token expiration.
    /// </summary>
    public interface IOAuthClientCredentialsProvider
    {
        /// <summary>
        /// Returns a valid access token. This call may request
        /// a new token or return a cached one.
        /// If it fails to retrieve a token it will throw a SaltoOAuthException.
        /// Callers should never store the given access token.
        /// </summary>
        /// <exception cref="SaltoOAuthException"></exception>
        Task<string> GetToken();

        /// <summary>
        /// Invalidates current token. This method should return immediately.
        /// So implementor may choose to not retrieve a new token until GetToken
        /// is called again.
        /// </summary>
        void InvalidateToken();
    }
}
