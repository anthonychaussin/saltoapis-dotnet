namespace Saltoapis.Auth
{
    /// <summary>
    /// Represents an OAuth exception.
    /// </summary>
    public class SaltoOAuthException : Exception
    {
        internal SaltoOAuthException(string message) : base(message)
        {
        }
    }
}
