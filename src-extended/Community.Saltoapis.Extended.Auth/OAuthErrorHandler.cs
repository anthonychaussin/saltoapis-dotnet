namespace Saltoapis.Auth
{
    static class OAuthErrorHandler
    {
        internal static void InvalidateOnUnauthenticated(SaltoapisAuthInterceptor interceptor)
        {
            Console.WriteLine("Server responded with unauthenticated error. Invalidating current token.");
            interceptor.InvalidateToken();
        }
    }
}
