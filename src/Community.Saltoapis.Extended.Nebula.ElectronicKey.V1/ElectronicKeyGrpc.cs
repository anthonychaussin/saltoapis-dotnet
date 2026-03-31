using Saltoapis.Nebula.ElectronicKey.V1.Request;
using Saltoapis.Nebula.ElectronicKey.V1.Response;

namespace Saltoapis.Nebula.ElectronicKey.V1
{
    /// <summary>
    /// An electronic key is battery-powered device used to interact with electronic locks.
    /// </summary>
    public static partial class ElectronicKeyService
    {
        static readonly string __ServiceName = "salto.nebula.electronickey.v1.ElectronicKeyService";

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

        static readonly Marshaller<CreateElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_CreateElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateElectronicKeyRequest.Parser));

        static readonly Marshaller<ElectronicKey> __Marshaller_salto_nebula_electronickey_v1_ElectronicKey = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ElectronicKey.Parser));

        static readonly Marshaller<GetElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_GetElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetElectronicKeyRequest.Parser));

        static readonly Marshaller<ListElectronicKeysRequest> __Marshaller_salto_nebula_electronickey_v1_ListElectronicKeysRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListElectronicKeysRequest.Parser));

        static readonly Marshaller<ListElectronicKeysResponse> __Marshaller_salto_nebula_electronickey_v1_ListElectronicKeysResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListElectronicKeysResponse.Parser));

        static readonly Marshaller<UpdateElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_UpdateElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateElectronicKeyRequest.Parser));

        static readonly Marshaller<DeleteElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_DeleteElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteElectronicKeyRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<BindElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_BindElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindElectronicKeyRequest.Parser));

        static readonly Marshaller<BindElectronicKeyResponse> __Marshaller_salto_nebula_electronickey_v1_BindElectronicKeyResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindElectronicKeyResponse.Parser));

        static readonly Marshaller<UnbindElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_UnbindElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindElectronicKeyRequest.Parser));

        static readonly Marshaller<UnbindElectronicKeyResponse> __Marshaller_salto_nebula_electronickey_v1_UnbindElectronicKeyResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindElectronicKeyResponse.Parser));

        static readonly Marshaller<InitializeElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_InitializeElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, InitializeElectronicKeyRequest.Parser));

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Longrunning.V1.Operation.Parser));

        static readonly Marshaller<ConfigureElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_ConfigureElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ConfigureElectronicKeyRequest.Parser));

        static readonly Marshaller<ResetElectronicKeyRequest> __Marshaller_salto_nebula_electronickey_v1_ResetElectronicKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ResetElectronicKeyRequest.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenRequest> __Marshaller_salto_nebula_electronickey_v1_GenerateAuthorizationTokenRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenRequest.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenResponse> __Marshaller_salto_nebula_electronickey_v1_GenerateAuthorizationTokenResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenResponse.Parser));

        static readonly Marshaller<GenerateFirmwareDownloadUriRequest> __Marshaller_salto_nebula_electronickey_v1_GenerateFirmwareDownloadUriRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateFirmwareDownloadUriRequest.Parser));

        static readonly Method<CreateElectronicKeyRequest, ElectronicKey> __Method_CreateElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "CreateElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_CreateElectronicKeyRequest,
            __Marshaller_salto_nebula_electronickey_v1_ElectronicKey);

        static readonly Method<GetElectronicKeyRequest, ElectronicKey> __Method_GetElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "GetElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_GetElectronicKeyRequest,
            __Marshaller_salto_nebula_electronickey_v1_ElectronicKey);

        static readonly Method<ListElectronicKeysRequest, ListElectronicKeysResponse> __Method_ListElectronicKeys = new(
            MethodType.Unary,
            __ServiceName,
            "ListElectronicKeys",
            __Marshaller_salto_nebula_electronickey_v1_ListElectronicKeysRequest,
            __Marshaller_salto_nebula_electronickey_v1_ListElectronicKeysResponse);

        static readonly Method<UpdateElectronicKeyRequest, ElectronicKey> __Method_UpdateElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_UpdateElectronicKeyRequest,
            __Marshaller_salto_nebula_electronickey_v1_ElectronicKey);

        static readonly Method<DeleteElectronicKeyRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_DeleteElectronicKeyRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<BindElectronicKeyRequest, BindElectronicKeyResponse> __Method_BindElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "BindElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_BindElectronicKeyRequest,
            __Marshaller_salto_nebula_electronickey_v1_BindElectronicKeyResponse);

        static readonly Method<UnbindElectronicKeyRequest, UnbindElectronicKeyResponse> __Method_UnbindElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "UnbindElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_UnbindElectronicKeyRequest,
            __Marshaller_salto_nebula_electronickey_v1_UnbindElectronicKeyResponse);

        static readonly Method<InitializeElectronicKeyRequest, Longrunning.V1.Operation> __Method_InitializeElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "InitializeElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_InitializeElectronicKeyRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ConfigureElectronicKeyRequest, Longrunning.V1.Operation> __Method_ConfigureElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "ConfigureElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_ConfigureElectronicKeyRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ResetElectronicKeyRequest, Longrunning.V1.Operation> __Method_ResetElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "ResetElectronicKey",
            __Marshaller_salto_nebula_electronickey_v1_ResetElectronicKeyRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<GenerateAuthorizationTokenRequest, GenerateAuthorizationTokenResponse> __Method_GenerateAuthorizationToken = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateAuthorizationToken",
            __Marshaller_salto_nebula_electronickey_v1_GenerateAuthorizationTokenRequest,
            __Marshaller_salto_nebula_electronickey_v1_GenerateAuthorizationTokenResponse);

        static readonly Method<GenerateFirmwareDownloadUriRequest, Longrunning.V1.Operation> __Method_GenerateFirmwareDownloadUri = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateFirmwareDownloadUri",
            __Marshaller_salto_nebula_electronickey_v1_GenerateFirmwareDownloadUriRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for ElectronicKeyService</summary>
        public partial class ElectronicKeyServiceClient : ClientBase<ElectronicKeyServiceClient>
        {
            /// <summary>Creates a new client for ElectronicKeyService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public ElectronicKeyServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for ElectronicKeyService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public ElectronicKeyServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected ElectronicKeyServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected ElectronicKeyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create a new electronic key
            ///
            /// Creates a new electronic key
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicKey CreateElectronicKey(CreateElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a new electronic key
            ///
            /// Creates a new electronic key
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicKey CreateElectronicKey(CreateElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateElectronicKey, null, options, request);
            /// <summary>
            /// Create a new electronic key
            ///
            /// Creates a new electronic key
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicKey> CreateElectronicKeyAsync(CreateElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a new electronic key
            ///
            /// Creates a new electronic key
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicKey> CreateElectronicKeyAsync(CreateElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateElectronicKey, null, options, request);
            }

            /// <summary>
            /// Get an electronic key
            ///
            /// Gets an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicKey GetElectronicKey(GetElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an electronic key
            ///
            /// Gets an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicKey GetElectronicKey(GetElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetElectronicKey, null, options, request);
            /// <summary>
            /// Get an electronic key
            ///
            /// Gets an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicKey> GetElectronicKeyAsync(GetElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an electronic key
            ///
            /// Gets an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicKey> GetElectronicKeyAsync(GetElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetElectronicKey, null, options, request);
            }

            /// <summary>
            /// List electronic keys
            ///
            /// Returns a list of electronic keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListElectronicKeysResponse ListElectronicKeys(ListElectronicKeysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListElectronicKeys(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List electronic keys
            ///
            /// Returns a list of electronic keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListElectronicKeysResponse ListElectronicKeys(ListElectronicKeysRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListElectronicKeys, null, options, request);
            /// <summary>
            /// List electronic keys
            ///
            /// Returns a list of electronic keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListElectronicKeysResponse> ListElectronicKeysAsync(ListElectronicKeysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListElectronicKeysAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List electronic keys
            ///
            /// Returns a list of electronic keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListElectronicKeysResponse> ListElectronicKeysAsync(ListElectronicKeysRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListElectronicKeys, null, options, request);
            }

            /// <summary>
            /// Update an electronic key
            ///
            /// Updates an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicKey UpdateElectronicKey(UpdateElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an electronic key
            ///
            /// Updates an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicKey UpdateElectronicKey(UpdateElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateElectronicKey, null, options, request);
            /// <summary>
            /// Update an electronic key
            ///
            /// Updates an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicKey> UpdateElectronicKeyAsync(UpdateElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an electronic key
            ///
            /// Updates an existing electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicKey> UpdateElectronicKeyAsync(UpdateElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateElectronicKey, null, options, request);
            }

            /// <summary>
            /// Delete an electronic key
            ///
            /// Permanently deletes an electronic key. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteElectronicKey(DeleteElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an electronic key
            ///
            /// Permanently deletes an electronic key. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteElectronicKey(DeleteElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteElectronicKey, null, options, request);
            /// <summary>
            /// Delete an electronic key
            ///
            /// Permanently deletes an electronic key. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteElectronicKeyAsync(DeleteElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an electronic key
            ///
            /// Permanently deletes an electronic key. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteElectronicKeyAsync(DeleteElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteElectronicKey, null, options, request);
            }

            /// <summary>
            /// Bind an electronic key
            ///
            /// Binds an electronic key. Binding an electronic key assigns a device
            /// identifier to the electronic key. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindElectronicKeyResponse BindElectronicKey(BindElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => BindElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind an electronic key
            ///
            /// Binds an electronic key. Binding an electronic key assigns a device
            /// identifier to the electronic key. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindElectronicKeyResponse BindElectronicKey(BindElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BindElectronicKey, null, options, request);
            /// <summary>
            /// Bind an electronic key
            ///
            /// Binds an electronic key. Binding an electronic key assigns a device
            /// identifier to the electronic key. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindElectronicKeyResponse> BindElectronicKeyAsync(BindElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return BindElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Bind an electronic key
            ///
            /// Binds an electronic key. Binding an electronic key assigns a device
            /// identifier to the electronic key. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindElectronicKeyResponse> BindElectronicKeyAsync(BindElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BindElectronicKey, null, options, request);
            }

            /// <summary>
            /// Unbind an electronic key
            ///
            /// Unbinds an electronic key. Unbinding an electronic key removes the
            /// device identifier from the electronic key. This may be required in some
            /// cases where the electronic key is not available anymore because, for
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
            public virtual UnbindElectronicKeyResponse UnbindElectronicKey(UnbindElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UnbindElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind an electronic key
            ///
            /// Unbinds an electronic key. Unbinding an electronic key removes the
            /// device identifier from the electronic key. This may be required in some
            /// cases where the electronic key is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindElectronicKeyResponse UnbindElectronicKey(UnbindElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnbindElectronicKey, null, options, request);
            /// <summary>
            /// Unbind an electronic key
            ///
            /// Unbinds an electronic key. Unbinding an electronic key removes the
            /// device identifier from the electronic key. This may be required in some
            /// cases where the electronic key is not available anymore because, for
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
            public virtual AsyncUnaryCall<UnbindElectronicKeyResponse> UnbindElectronicKeyAsync(UnbindElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UnbindElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Unbind an electronic key
            ///
            /// Unbinds an electronic key. Unbinding an electronic key removes the
            /// device identifier from the electronic key. This may be required in some
            /// cases where the electronic key is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindElectronicKeyResponse> UnbindElectronicKeyAsync(UnbindElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UnbindElectronicKey, null, options, request);
            }

            /// <summary>
            /// Initialize an electronic key
            ///
            /// Initializes an electronic key. Electronic keys need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeElectronicKey(InitializeElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => InitializeElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize an electronic key
            ///
            /// Initializes an electronic key. Electronic keys need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeElectronicKey(InitializeElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_InitializeElectronicKey, null, options, request);
            /// <summary>
            /// Initialize an electronic key
            ///
            /// Initializes an electronic key. Electronic keys need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeElectronicKeyAsync(InitializeElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return InitializeElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Initialize an electronic key
            ///
            /// Initializes an electronic key. Electronic keys need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeElectronicKeyAsync(InitializeElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_InitializeElectronicKey, null, options, request);
            }

            /// <summary>
            /// Configure an electronic key
            ///
            /// Configures an electronic key. Configuring an electronic key implies
            /// adding some information to the electronic key such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureElectronicKey(ConfigureElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ConfigureElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure an electronic key
            ///
            /// Configures an electronic key. Configuring an electronic key implies
            /// adding some information to the electronic key such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureElectronicKey(ConfigureElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ConfigureElectronicKey, null, options, request);
            /// <summary>
            /// Configure an electronic key
            ///
            /// Configures an electronic key. Configuring an electronic key implies
            /// adding some information to the electronic key such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureElectronicKeyAsync(ConfigureElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ConfigureElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Configure an electronic key
            ///
            /// Configures an electronic key. Configuring an electronic key implies
            /// adding some information to the electronic key such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureElectronicKeyAsync(ConfigureElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ConfigureElectronicKey, null, options, request);
            }

            /// <summary>
            /// Reset an electronic key
            ///
            /// Resetting a device such as an electronic key means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetElectronicKey(ResetElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ResetElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset an electronic key
            ///
            /// Resetting a device such as an electronic key means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetElectronicKey(ResetElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ResetElectronicKey, null, options, request);
            /// <summary>
            /// Reset an electronic key
            ///
            /// Resetting a device such as an electronic key means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetElectronicKeyAsync(ResetElectronicKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ResetElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Reset an electronic key
            ///
            /// Resetting a device such as an electronic key means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetElectronicKeyAsync(ResetElectronicKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ResetElectronicKey, null, options, request);
            }

            /// <summary>
            /// Generate authorization token for an electronic key
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateAuthorizationToken(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate authorization token for an electronic key
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generate authorization token for an electronic key
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic key.
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
            /// Generate authorization token for an electronic key
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            }

            /// <summary>
            /// Generate electronic key firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic key. The returned URI can be used to bring the electronic key
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUri(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate electronic key firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic key. The returned URI can be used to bring the electronic key
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Generate electronic key firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic key. The returned URI can be used to bring the electronic key
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
            /// Generate electronic key firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic key. The returned URI can be used to bring the electronic key
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
            protected override ElectronicKeyServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
