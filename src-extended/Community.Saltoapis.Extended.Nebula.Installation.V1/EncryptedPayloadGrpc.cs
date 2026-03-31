using Saltoapis.Nebula.Installation.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.Installation.V1.Response;

namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>
    /// This service is responsible for the ingestion of encrypted payloads.
    /// </summary>
    public static partial class EncryptedPayloadService
    {
        static readonly string __ServiceName = "salto.nebula.installation.v1.EncryptedPayloadService";

        static readonly Marshaller<IngestEncryptedPayloadsRequest> __Marshaller_salto_nebula_installation_v1_IngestEncryptedPayloadsRequest = GrpcMessageHelper.CreateMarshaller(IngestEncryptedPayloadsRequest.Parser);

        static readonly Marshaller<IngestEncryptedPayloadsResponse> __Marshaller_salto_nebula_installation_v1_IngestEncryptedPayloadsResponse = GrpcMessageHelper.CreateMarshaller(IngestEncryptedPayloadsResponse.Parser);

        static readonly Method<IngestEncryptedPayloadsRequest, IngestEncryptedPayloadsResponse> __Method_IngestEncryptedPayloads = new(
            MethodType.Unary,
            __ServiceName,
            "IngestEncryptedPayloads",
            __Marshaller_salto_nebula_installation_v1_IngestEncryptedPayloadsRequest,
            __Marshaller_salto_nebula_installation_v1_IngestEncryptedPayloadsResponse);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => EncryptedPayloadReflection.Descriptor.Services[0];}
        /// <summary>Client for EncryptedPayloadService</summary>
        public partial class EncryptedPayloadServiceClient : ClientBase<EncryptedPayloadServiceClient>
        {
            /// <summary>Creates a new client for EncryptedPayloadService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public EncryptedPayloadServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for EncryptedPayloadService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public EncryptedPayloadServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected EncryptedPayloadServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected EncryptedPayloadServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Ingest encrypted payloads
            ///
            /// Ingests encrypted payload for a given installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IngestEncryptedPayloadsResponse IngestEncryptedPayloads(IngestEncryptedPayloadsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => IngestEncryptedPayloads(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Ingest encrypted payloads
            ///
            /// Ingests encrypted payload for a given installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IngestEncryptedPayloadsResponse IngestEncryptedPayloads(IngestEncryptedPayloadsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_IngestEncryptedPayloads, null, options, request);
            /// <summary>
            /// Ingest encrypted payloads
            ///
            /// Ingests encrypted payload for a given installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IngestEncryptedPayloadsResponse> IngestEncryptedPayloadsAsync(IngestEncryptedPayloadsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => IngestEncryptedPayloadsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Ingest encrypted payloads
            ///
            /// Ingests encrypted payload for a given installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IngestEncryptedPayloadsResponse> IngestEncryptedPayloadsAsync(IngestEncryptedPayloadsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_IngestEncryptedPayloads, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override EncryptedPayloadServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}