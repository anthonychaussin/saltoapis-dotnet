using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace Saltoapis.Grpc
{
    internal static class GrpcRpcHelper
    {
        internal static async Task<T> HandleUnauthenticatedAsync<T>(Task<T> task, Action onUnauthenticated)
        {
            try
            {
                return await task.ConfigureAwait(false);
            }
            catch (RpcException ex) when (ex.StatusCode == StatusCode.Unauthenticated)
            {
                onUnauthenticated?.Invoke();
                throw;
            }
        }
    }
}
