using Grpc.Core;
using System.Threading.Tasks; // Task
using System.Threading; // CancellationToken

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

        public T Current => this.stream.Current;

        public async Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            try
            {
                return await this.stream.MoveNext(cancellationToken);
            }
            catch (RpcException ex) when (ex.StatusCode == StatusCode.Unauthenticated)
            {
                OAuthErrorHandler.InvalidateOnUnauthenticated(interceptor);
                throw;
            }
        }
    }
}
