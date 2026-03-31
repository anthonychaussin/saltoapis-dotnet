using Grpc.Core.Interceptors;
using Saltoapis.Grpc;

namespace Saltoapis.Auth
{
    /// <summary>
    /// Saltoapis authorization interceptor. This interceptor uses a OAuthClientCredentialsProvider
    /// to include a valid token in grpc requests.
    /// </summary>
    public class SaltoapisAuthInterceptor : Interceptor
    {
        IOAuthClientCredentialsProvider OAuthClient;

        public SaltoapisAuthInterceptor(String id, String secret, String[] scopes)
        {
            OAuthClient = new SaltoOAuthClient(id, secret, scopes);
        }

        public SaltoapisAuthInterceptor(IOAuthClientCredentialsProvider credentialsProvider)
        {
            OAuthClient = credentialsProvider;
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            AsyncUnaryCall<TResponse> call = continuation(request, context);

            // wrap response to capture errors
            return new AsyncUnaryCall<TResponse>(
                HandleRpcUnauthenticated(call.ResponseAsync),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            // call server using a task. This way we can use the same method to handle authentication exceptions.
            return HandleRpcUnauthenticated(Task.Run(() => continuation(request, context))).Result;
        }

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncClientStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            AsyncClientStreamingCall<TRequest, TResponse> call = continuation(context);

            // wrap response to capture errors
            return new AsyncClientStreamingCall<TRequest, TResponse>(
                call.RequestStream,
                HandleRpcUnauthenticated(call.ResponseAsync),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            AsyncServerStreamingCall<TResponse> call = continuation(request, context);

            return new AsyncServerStreamingCall<TResponse>(
                new AuthErrorStreamReader<TResponse>(call.ResponseStream, this),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncDuplexStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AddCallerMetadata(ref context);

            AsyncDuplexStreamingCall<TRequest, TResponse> call = continuation(context);

            return new AsyncDuplexStreamingCall<TRequest, TResponse>(
                call.RequestStream,
                new AuthErrorStreamReader<TResponse>(call.ResponseStream, this),
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }

        async Task<TResponse> HandleRpcUnauthenticated<TResponse>(Task<TResponse> t)
            => await GrpcRpcHelper.HandleUnauthenticatedAsync(
                t,
                () => OAuthErrorHandler.InvalidateOnUnauthenticated(this)
            );

        void AddCallerMetadata<TRequest, TResponse>(ref ClientInterceptorContext<TRequest, TResponse> context)
            where TRequest : class
            where TResponse : class
        {
            Metadata headers = context.Options.Headers;

            // Call doesn't have a headers collection to add to.
            // Need to create a new context with headers for the call.
            if (headers == null)
            {
                headers = [];
                CallOptions options = context.Options.WithHeaders(headers);
                context = new ClientInterceptorContext<TRequest, TResponse>(context.Method, context.Host, options);
            }

            // this call may take a while (depending if we have the token or not)
            string token = OAuthClient.GetToken().Result;
            headers.Add("Authorization", $"Bearer {token}");
        }

        public void InvalidateToken()
        {
            OAuthClient.InvalidateToken();
        }
    }
}
