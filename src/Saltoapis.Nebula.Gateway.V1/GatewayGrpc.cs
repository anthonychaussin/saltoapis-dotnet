using Grpc.Core;
using Saltoapis.Nebula.Gateway.V1.Request;
using Saltoapis.Nebula.Gateway.V1.Response;

namespace Saltoapis.Nebula.Gateway.V1
{
    /// <summary>
    /// Gateways are hardware devices intended to be used with access points where
    /// online connectivity is needed. This service is responsible for managing
    /// gateway resources.
    /// </summary>
    public static partial class GatewayService
    {
        static readonly string __ServiceName = "salto.nebula.gateway.v1.GatewayService";

        static void __Helper_SerializeMessage(Google.Protobuf.IMessage message, SerializationContext context)
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (message is Google.Protobuf.IBufferMessage)
            {
                context.SetPayloadLength(message.CalculateSize());
                Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
                context.Complete();
                return;
            }
#endif
            context.Complete(Google.Protobuf.MessageExtensions.ToByteArray(message));
        }

        static class __Helper_MessageCache<T>
        {
            public static readonly bool IsBufferMessage = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
        }

        static T __Helper_DeserializeMessage<T>(DeserializationContext context, Google.Protobuf.MessageParser<T> parser) where T : Google.Protobuf.IMessage<T>
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (__Helper_MessageCache<T>.IsBufferMessage) return parser.ParseFrom(context.PayloadAsReadOnlySequence());
#endif
            return parser.ParseFrom(context.PayloadAsNewBuffer());
        }

        static readonly Marshaller<CreateGatewayRequest> __Marshaller_salto_nebula_gateway_v1_CreateGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateGatewayRequest.Parser));

        static readonly Marshaller<Gateway> __Marshaller_salto_nebula_gateway_v1_Gateway = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Gateway.Parser));

        static readonly Marshaller<GetGatewayRequest> __Marshaller_salto_nebula_gateway_v1_GetGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetGatewayRequest.Parser));

        static readonly Marshaller<ListGatewaysRequest> __Marshaller_salto_nebula_gateway_v1_ListGatewaysRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListGatewaysRequest.Parser));

        static readonly Marshaller<ListGatewaysResponse> __Marshaller_salto_nebula_gateway_v1_ListGatewaysResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListGatewaysResponse.Parser));

        static readonly Marshaller<UpdateGatewayRequest> __Marshaller_salto_nebula_gateway_v1_UpdateGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateGatewayRequest.Parser));

        static readonly Marshaller<DeleteGatewayRequest> __Marshaller_salto_nebula_gateway_v1_DeleteGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteGatewayRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<BindGatewayRequest> __Marshaller_salto_nebula_gateway_v1_BindGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindGatewayRequest.Parser));

        static readonly Marshaller<BindGatewayResponse> __Marshaller_salto_nebula_gateway_v1_BindGatewayResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindGatewayResponse.Parser));

        static readonly Marshaller<UnbindGatewayRequest> __Marshaller_salto_nebula_gateway_v1_UnbindGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindGatewayRequest.Parser));

        static readonly Marshaller<UnbindGatewayResponse> __Marshaller_salto_nebula_gateway_v1_UnbindGatewayResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindGatewayResponse.Parser));

        static readonly Marshaller<InitializeGatewayRequest> __Marshaller_salto_nebula_gateway_v1_InitializeGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, InitializeGatewayRequest.Parser));

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Longrunning.V1.Operation.Parser));

        static readonly Marshaller<ConfigureGatewayRequest> __Marshaller_salto_nebula_gateway_v1_ConfigureGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ConfigureGatewayRequest.Parser));

        static readonly Marshaller<ResetGatewayRequest> __Marshaller_salto_nebula_gateway_v1_ResetGatewayRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ResetGatewayRequest.Parser));

        static readonly Marshaller<UpdateGatewayFirmwareRequest> __Marshaller_salto_nebula_gateway_v1_UpdateGatewayFirmwareRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateGatewayFirmwareRequest.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenRequest> __Marshaller_salto_nebula_gateway_v1_GenerateAuthorizationTokenRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenRequest.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenResponse> __Marshaller_salto_nebula_gateway_v1_GenerateAuthorizationTokenResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenResponse.Parser));

        static readonly Marshaller<GenerateFirmwareDownloadUriRequest> __Marshaller_salto_nebula_gateway_v1_GenerateFirmwareDownloadUriRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateFirmwareDownloadUriRequest.Parser));

        static readonly Method<CreateGatewayRequest, Gateway> __Method_CreateGateway = new(
            MethodType.Unary,
            __ServiceName,
            "CreateGateway",
            __Marshaller_salto_nebula_gateway_v1_CreateGatewayRequest,
            __Marshaller_salto_nebula_gateway_v1_Gateway);

        static readonly Method<GetGatewayRequest, Gateway> __Method_GetGateway = new(
            MethodType.Unary,
            __ServiceName,
            "GetGateway",
            __Marshaller_salto_nebula_gateway_v1_GetGatewayRequest,
            __Marshaller_salto_nebula_gateway_v1_Gateway);

        static readonly Method<ListGatewaysRequest, ListGatewaysResponse> __Method_ListGateways = new(
            MethodType.Unary,
            __ServiceName,
            "ListGateways",
            __Marshaller_salto_nebula_gateway_v1_ListGatewaysRequest,
            __Marshaller_salto_nebula_gateway_v1_ListGatewaysResponse);

        static readonly Method<UpdateGatewayRequest, Gateway> __Method_UpdateGateway = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateGateway",
            __Marshaller_salto_nebula_gateway_v1_UpdateGatewayRequest,
            __Marshaller_salto_nebula_gateway_v1_Gateway);

        static readonly Method<DeleteGatewayRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteGateway = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteGateway",
            __Marshaller_salto_nebula_gateway_v1_DeleteGatewayRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<BindGatewayRequest, BindGatewayResponse> __Method_BindGateway = new(
            MethodType.Unary,
            __ServiceName,
            "BindGateway",
            __Marshaller_salto_nebula_gateway_v1_BindGatewayRequest,
            __Marshaller_salto_nebula_gateway_v1_BindGatewayResponse);

        static readonly Method<UnbindGatewayRequest, UnbindGatewayResponse> __Method_UnbindGateway = new(
            MethodType.Unary,
            __ServiceName,
            "UnbindGateway",
            __Marshaller_salto_nebula_gateway_v1_UnbindGatewayRequest,
            __Marshaller_salto_nebula_gateway_v1_UnbindGatewayResponse);

        static readonly Method<InitializeGatewayRequest, Longrunning.V1.Operation> __Method_InitializeGateway = new(
            MethodType.Unary,
            __ServiceName,
            "InitializeGateway",
            __Marshaller_salto_nebula_gateway_v1_InitializeGatewayRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ConfigureGatewayRequest, Longrunning.V1.Operation> __Method_ConfigureGateway = new(
            MethodType.Unary,
            __ServiceName,
            "ConfigureGateway",
            __Marshaller_salto_nebula_gateway_v1_ConfigureGatewayRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ResetGatewayRequest, Longrunning.V1.Operation> __Method_ResetGateway = new(
            MethodType.Unary,
            __ServiceName,
            "ResetGateway",
            __Marshaller_salto_nebula_gateway_v1_ResetGatewayRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<UpdateGatewayFirmwareRequest, Longrunning.V1.Operation> __Method_UpdateGatewayFirmware = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateGatewayFirmware",
            __Marshaller_salto_nebula_gateway_v1_UpdateGatewayFirmwareRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<GenerateAuthorizationTokenRequest, GenerateAuthorizationTokenResponse> __Method_GenerateAuthorizationToken = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateAuthorizationToken",
            __Marshaller_salto_nebula_gateway_v1_GenerateAuthorizationTokenRequest,
            __Marshaller_salto_nebula_gateway_v1_GenerateAuthorizationTokenResponse);

        static readonly Method<GenerateFirmwareDownloadUriRequest, Longrunning.V1.Operation> __Method_GenerateFirmwareDownloadUri = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateFirmwareDownloadUri",
            __Marshaller_salto_nebula_gateway_v1_GenerateFirmwareDownloadUriRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for GatewayService</summary>
        public partial class GatewayServiceClient : ClientBase<GatewayServiceClient>
        {
            /// <summary>Creates a new client for GatewayService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public GatewayServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for GatewayService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public GatewayServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected GatewayServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected GatewayServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create a gateway
            ///
            /// Creates a new gateway
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Gateway CreateGateway(CreateGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a gateway
            ///
            /// Creates a new gateway
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Gateway CreateGateway(CreateGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateGateway, null, options, request);
            /// <summary>
            /// Create a gateway
            ///
            /// Creates a new gateway
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Gateway> CreateGatewayAsync(CreateGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a gateway
            ///
            /// Creates a new gateway
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Gateway> CreateGatewayAsync(CreateGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateGateway, null, options, request);
            }

            /// <summary>
            /// Get a gateway
            ///
            /// Gets an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Gateway GetGateway(GetGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a gateway
            ///
            /// Gets an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Gateway GetGateway(GetGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetGateway, null, options, request);
            /// <summary>
            /// Get a gateway
            ///
            /// Gets an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Gateway> GetGatewayAsync(GetGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get a gateway
            ///
            /// Gets an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Gateway> GetGatewayAsync(GetGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetGateway, null, options, request);
            }

            /// <summary>
            /// List gateways
            ///
            /// Returns a list of gateways that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListGateways(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List gateways
            ///
            /// Returns a list of gateways that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListGateways, null, options, request);
            /// <summary>
            /// List gateways
            ///
            /// Returns a list of gateways that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListGatewaysAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List gateways
            ///
            /// Returns a list of gateways that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListGateways, null, options, request);
            }

            /// <summary>
            /// Update a gateway
            ///
            /// Updates an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Gateway UpdateGateway(UpdateGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a gateway
            ///
            /// Updates an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Gateway UpdateGateway(UpdateGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateGateway, null, options, request);
            /// <summary>
            /// Update a gateway
            ///
            /// Updates an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Gateway> UpdateGatewayAsync(UpdateGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update a gateway
            ///
            /// Updates an existing gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Gateway> UpdateGatewayAsync(UpdateGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateGateway, null, options, request);
            }

            /// <summary>
            /// Delete a gateway
            ///
            /// Permanently deletes a gateway. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteGateway(DeleteGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a gateway
            ///
            /// Permanently deletes a gateway. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteGateway(DeleteGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteGateway, null, options, request);
            /// <summary>
            /// Delete a gateway
            ///
            /// Permanently deletes a gateway. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteGatewayAsync(DeleteGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a gateway
            ///
            /// Permanently deletes a gateway. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteGatewayAsync(DeleteGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteGateway, null, options, request);
            }

            /// <summary>
            /// Bind a gateway
            ///
            /// Binds a gateway. Binding a gateway assigns a device
            /// identifier to the gateway. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindGatewayResponse BindGateway(BindGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => BindGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind a gateway
            ///
            /// Binds a gateway. Binding a gateway assigns a device
            /// identifier to the gateway. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindGatewayResponse BindGateway(BindGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BindGateway, null, options, request);
            /// <summary>
            /// Bind a gateway
            ///
            /// Binds a gateway. Binding a gateway assigns a device
            /// identifier to the gateway. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindGatewayResponse> BindGatewayAsync(BindGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return BindGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Bind a gateway
            ///
            /// Binds a gateway. Binding a gateway assigns a device
            /// identifier to the gateway. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindGatewayResponse> BindGatewayAsync(BindGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BindGateway, null, options, request);
            }

            /// <summary>
            /// Unbind a gateway
            ///
            /// Unbinds a gateway. Unbinding a gateway removes the
            /// device identifier from the gateway. This may be required in some
            /// cases where the gateway is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindGatewayResponse UnbindGateway(UnbindGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UnbindGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind a gateway
            ///
            /// Unbinds a gateway. Unbinding a gateway removes the
            /// device identifier from the gateway. This may be required in some
            /// cases where the gateway is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindGatewayResponse UnbindGateway(UnbindGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnbindGateway, null, options, request);
            /// <summary>
            /// Unbind a gateway
            ///
            /// Unbinds a gateway. Unbinding a gateway removes the
            /// device identifier from the gateway. This may be required in some
            /// cases where the gateway is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindGatewayResponse> UnbindGatewayAsync(UnbindGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UnbindGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Unbind a gateway
            ///
            /// Unbinds a gateway. Unbinding a gateway removes the
            /// device identifier from the gateway. This may be required in some
            /// cases where the gateway is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindGatewayResponse> UnbindGatewayAsync(UnbindGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UnbindGateway, null, options, request);
            }

            /// <summary>
            /// Initialize a gateway
            ///
            /// Initializes a gateway. Gateways need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeGateway(InitializeGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => InitializeGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize a gateway
            ///
            /// Initializes a gateway. Gateways need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeGateway(InitializeGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_InitializeGateway, null, options, request);
            /// <summary>
            /// Initialize a gateway
            ///
            /// Initializes a gateway. Gateways need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeGatewayAsync(InitializeGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return InitializeGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Initialize a gateway
            ///
            /// Initializes a gateway. Gateways need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeGatewayAsync(InitializeGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_InitializeGateway, null, options, request);
            }

            /// <summary>
            /// Configure a gateway
            ///
            /// Configures a gateway. Configuring a gateway implies adding some
            /// information to the gateway such as setting the time zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureGateway(ConfigureGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ConfigureGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure a gateway
            ///
            /// Configures a gateway. Configuring a gateway implies adding some
            /// information to the gateway such as setting the time zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureGateway(ConfigureGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ConfigureGateway, null, options, request);
            /// <summary>
            /// Configure a gateway
            ///
            /// Configures a gateway. Configuring a gateway implies adding some
            /// information to the gateway such as setting the time zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureGatewayAsync(ConfigureGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ConfigureGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Configure a gateway
            ///
            /// Configures a gateway. Configuring a gateway implies adding some
            /// information to the gateway such as setting the time zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureGatewayAsync(ConfigureGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ConfigureGateway, null, options, request);
            }

            /// <summary>
            /// Reset a gateway
            ///
            /// Resetting a device such as a gateway means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetGateway(ResetGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ResetGateway(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset a gateway
            ///
            /// Resetting a device such as a gateway means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetGateway(ResetGatewayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ResetGateway, null, options, request);
            /// <summary>
            /// Reset a gateway
            ///
            /// Resetting a device such as a gateway means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetGatewayAsync(ResetGatewayRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ResetGatewayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Reset a gateway
            ///
            /// Resetting a device such as a gateway means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetGatewayAsync(ResetGatewayRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ResetGateway, null, options, request);
            }

            /// <summary>
            /// Update gateway firmware
            ///
            /// Updates a gateway's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateGatewayFirmware(UpdateGatewayFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateGatewayFirmware(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update gateway firmware
            ///
            /// Updates a gateway's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateGatewayFirmware(UpdateGatewayFirmwareRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateGatewayFirmware, null, options, request);
            /// <summary>
            /// Update gateway firmware
            ///
            /// Updates a gateway's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateGatewayFirmwareAsync(UpdateGatewayFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateGatewayFirmwareAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update gateway firmware
            ///
            /// Updates a gateway's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateGatewayFirmwareAsync(UpdateGatewayFirmwareRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateGatewayFirmware, null, options, request);
            }

            /// <summary>
            /// Generates an authorization token for a gateway
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateAuthorizationToken(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generates an authorization token for a gateway
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generates an authorization token for a gateway
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GenerateAuthorizationTokenAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Generates an authorization token for a gateway
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a gateway.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            }

            /// <summary>
            /// Generate gateway firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// gateway. The returned URI can be used to bring the gateway
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUri(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate gateway firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// gateway. The returned URI can be used to bring the gateway
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Generate gateway firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// gateway. The returned URI can be used to bring the gateway
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GenerateFirmwareDownloadUriAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Generate gateway firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// gateway. The returned URI can be used to bring the gateway
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override GatewayServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
