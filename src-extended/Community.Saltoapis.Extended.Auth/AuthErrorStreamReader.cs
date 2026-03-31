namespace Saltoapis.Auth
{
    internal class AuthErrorStreamReader<T> : IAsyncStreamReader<T>
    {
        IAsyncStreamReader<T> stream;
        SaltoapisAuthInterceptor interceptor;

        internal AuthErrorStreamReader(IAsyncStreamReader<T> stream, SaltoapisAuthInterceptor interceptor)
        {
            this.stream = stream;
            this.interceptor = interceptor;
        }

        public T Current => stream.Current;

        public async Task<bool> MoveNext(CancellationToken cancellationToken)
            => await Grpc.GrpcRpcHelper.HandleUnauthenticatedAsync(
                stream.MoveNext(cancellationToken),
                () => OAuthErrorHandler.InvalidateOnUnauthenticated(interceptor)
            );
    }
}
