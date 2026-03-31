using Grpc.Core;
using Saltoapis.Nebula.Encoder.V1.Request;
using Saltoapis.Nebula.Encoder.V1.Response;

namespace Saltoapis.Nebula.Encoder.V1
{
    /// <summary>
    /// A card encoder is an external device that reads and updates physical card
    /// keys with access information. This service is responsible for managing
    /// encoder resources.
    /// </summary>
    public static partial class EncoderService
    {
        static readonly string __ServiceName = "salto.nebula.encoder.v1.EncoderService";

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

        static readonly Marshaller<CreateEncoderRequest> __Marshaller_salto_nebula_encoder_v1_CreateEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateEncoderRequest.Parser));

        static readonly Marshaller<Encoder> __Marshaller_salto_nebula_encoder_v1_Encoder = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Encoder.Parser));

        static readonly Marshaller<GetEncoderRequest> __Marshaller_salto_nebula_encoder_v1_GetEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetEncoderRequest.Parser));

        static readonly Marshaller<ListEncodersRequest> __Marshaller_salto_nebula_encoder_v1_ListEncodersRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEncodersRequest.Parser));

        static readonly Marshaller<ListEncodersResponse> __Marshaller_salto_nebula_encoder_v1_ListEncodersResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEncodersResponse.Parser));

        static readonly Marshaller<UpdateEncoderRequest> __Marshaller_salto_nebula_encoder_v1_UpdateEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateEncoderRequest.Parser));

        static readonly Marshaller<DeleteEncoderRequest> __Marshaller_salto_nebula_encoder_v1_DeleteEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteEncoderRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<InitializeEncoderRequest> __Marshaller_salto_nebula_encoder_v1_InitializeEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, InitializeEncoderRequest.Parser));

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Longrunning.V1.Operation.Parser));

        static readonly Marshaller<ConfigureEncoderRequest> __Marshaller_salto_nebula_encoder_v1_ConfigureEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ConfigureEncoderRequest.Parser));

        static readonly Marshaller<ResetEncoderRequest> __Marshaller_salto_nebula_encoder_v1_ResetEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ResetEncoderRequest.Parser));

        static readonly Marshaller<UpdateEncoderFirmwareRequest> __Marshaller_salto_nebula_encoder_v1_UpdateEncoderFirmwareRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateEncoderFirmwareRequest.Parser));

        static readonly Marshaller<BindEncoderRequest> __Marshaller_salto_nebula_encoder_v1_BindEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindEncoderRequest.Parser));

        static readonly Marshaller<BindEncoderResponse> __Marshaller_salto_nebula_encoder_v1_BindEncoderResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindEncoderResponse.Parser));

        static readonly Marshaller<UnbindEncoderRequest> __Marshaller_salto_nebula_encoder_v1_UnbindEncoderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindEncoderRequest.Parser));

        static readonly Marshaller<UnbindEncoderResponse> __Marshaller_salto_nebula_encoder_v1_UnbindEncoderResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindEncoderResponse.Parser));

        static readonly Marshaller<ReadKeyRequest> __Marshaller_salto_nebula_encoder_v1_ReadKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ReadKeyRequest.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenRequest> __Marshaller_salto_nebula_encoder_v1_GenerateAuthorizationTokenRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenRequest.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenResponse> __Marshaller_salto_nebula_encoder_v1_GenerateAuthorizationTokenResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenResponse.Parser));

        static readonly Marshaller<GenerateFirmwareDownloadUriRequest> __Marshaller_salto_nebula_encoder_v1_GenerateFirmwareDownloadUriRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateFirmwareDownloadUriRequest.Parser));

        static readonly Method<CreateEncoderRequest, Encoder> __Method_CreateEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "CreateEncoder",
            __Marshaller_salto_nebula_encoder_v1_CreateEncoderRequest,
            __Marshaller_salto_nebula_encoder_v1_Encoder);

        static readonly Method<GetEncoderRequest, Encoder> __Method_GetEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "GetEncoder",
            __Marshaller_salto_nebula_encoder_v1_GetEncoderRequest,
            __Marshaller_salto_nebula_encoder_v1_Encoder);

        static readonly Method<ListEncodersRequest, ListEncodersResponse> __Method_ListEncoders = new(
            MethodType.Unary,
            __ServiceName,
            "ListEncoders",
            __Marshaller_salto_nebula_encoder_v1_ListEncodersRequest,
            __Marshaller_salto_nebula_encoder_v1_ListEncodersResponse);

        static readonly Method<UpdateEncoderRequest, Encoder> __Method_UpdateEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateEncoder",
            __Marshaller_salto_nebula_encoder_v1_UpdateEncoderRequest,
            __Marshaller_salto_nebula_encoder_v1_Encoder);

        static readonly Method<DeleteEncoderRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteEncoder",
            __Marshaller_salto_nebula_encoder_v1_DeleteEncoderRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<InitializeEncoderRequest, Longrunning.V1.Operation> __Method_InitializeEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "InitializeEncoder",
            __Marshaller_salto_nebula_encoder_v1_InitializeEncoderRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ConfigureEncoderRequest, Longrunning.V1.Operation> __Method_ConfigureEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "ConfigureEncoder",
            __Marshaller_salto_nebula_encoder_v1_ConfigureEncoderRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ResetEncoderRequest, Longrunning.V1.Operation> __Method_ResetEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "ResetEncoder",
            __Marshaller_salto_nebula_encoder_v1_ResetEncoderRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<UpdateEncoderFirmwareRequest, Longrunning.V1.Operation> __Method_UpdateEncoderFirmware = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateEncoderFirmware",
            __Marshaller_salto_nebula_encoder_v1_UpdateEncoderFirmwareRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<BindEncoderRequest, BindEncoderResponse> __Method_BindEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "BindEncoder",
            __Marshaller_salto_nebula_encoder_v1_BindEncoderRequest,
            __Marshaller_salto_nebula_encoder_v1_BindEncoderResponse);

        static readonly Method<UnbindEncoderRequest, UnbindEncoderResponse> __Method_UnbindEncoder = new(
            MethodType.Unary,
            __ServiceName,
            "UnbindEncoder",
            __Marshaller_salto_nebula_encoder_v1_UnbindEncoderRequest,
            __Marshaller_salto_nebula_encoder_v1_UnbindEncoderResponse);

        static readonly Method<ReadKeyRequest, Longrunning.V1.Operation> __Method_ReadKey = new(
            MethodType.Unary,
            __ServiceName,
            "ReadKey",
            __Marshaller_salto_nebula_encoder_v1_ReadKeyRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<GenerateAuthorizationTokenRequest, GenerateAuthorizationTokenResponse> __Method_GenerateAuthorizationToken = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateAuthorizationToken",
            __Marshaller_salto_nebula_encoder_v1_GenerateAuthorizationTokenRequest,
            __Marshaller_salto_nebula_encoder_v1_GenerateAuthorizationTokenResponse);

        static readonly Method<GenerateFirmwareDownloadUriRequest, Longrunning.V1.Operation> __Method_GenerateFirmwareDownloadUri = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateFirmwareDownloadUri",
            __Marshaller_salto_nebula_encoder_v1_GenerateFirmwareDownloadUriRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for EncoderService</summary>
        public partial class EncoderServiceClient : ClientBase<EncoderServiceClient>
        {
            /// <summary>Creates a new client for EncoderService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public EncoderServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for EncoderService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public EncoderServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected EncoderServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected EncoderServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an encoder
            ///
            /// Creates a new encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Encoder CreateEncoder(CreateEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an encoder
            ///
            /// Creates a new encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Encoder CreateEncoder(CreateEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateEncoder, null, options, request);
            /// <summary>
            /// Create an encoder
            ///
            /// Creates a new encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Encoder> CreateEncoderAsync(CreateEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an encoder
            ///
            /// Creates a new encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Encoder> CreateEncoderAsync(CreateEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateEncoder, null, options, request);
            }

            /// <summary>
            /// Get an encoder
            ///
            /// Gets an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Encoder GetEncoder(GetEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an encoder
            ///
            /// Gets an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Encoder GetEncoder(GetEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetEncoder, null, options, request);
            /// <summary>
            /// Get an encoder
            ///
            /// Gets an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Encoder> GetEncoderAsync(GetEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an encoder
            ///
            /// Gets an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Encoder> GetEncoderAsync(GetEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetEncoder, null, options, request);
            }

            /// <summary>
            /// List encoders
            ///
            /// Returns a list of encoders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEncodersResponse ListEncoders(ListEncodersRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListEncoders(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List encoders
            ///
            /// Returns a list of encoders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEncodersResponse ListEncoders(ListEncodersRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListEncoders, null, options, request);
            /// <summary>
            /// List encoders
            ///
            /// Returns a list of encoders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEncodersResponse> ListEncodersAsync(ListEncodersRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListEncodersAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List encoders
            ///
            /// Returns a list of encoders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEncodersResponse> ListEncodersAsync(ListEncodersRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListEncoders, null, options, request);
            }

            /// <summary>
            /// Update an encoder
            ///
            /// Updates an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Encoder UpdateEncoder(UpdateEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an encoder
            ///
            /// Updates an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Encoder UpdateEncoder(UpdateEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateEncoder, null, options, request);
            /// <summary>
            /// Update an encoder
            ///
            /// Updates an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Encoder> UpdateEncoderAsync(UpdateEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an encoder
            ///
            /// Updates an existing encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Encoder> UpdateEncoderAsync(UpdateEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateEncoder, null, options, request);
            }

            /// <summary>
            /// Delete an encoder
            ///
            /// Permanently deletes an encoder. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteEncoder(DeleteEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an encoder
            ///
            /// Permanently deletes an encoder. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteEncoder(DeleteEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteEncoder, null, options, request);
            /// <summary>
            /// Delete an encoder
            ///
            /// Permanently deletes an encoder. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteEncoderAsync(DeleteEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an encoder
            ///
            /// Permanently deletes an encoder. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteEncoderAsync(DeleteEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteEncoder, null, options, request);
            }

            /// <summary>
            /// Initialize an encoder
            ///
            /// Initializes an encoder. Encoders need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeEncoder(InitializeEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => InitializeEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize an encoder
            ///
            /// Initializes an encoder. Encoders need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeEncoder(InitializeEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_InitializeEncoder, null, options, request);
            /// <summary>
            /// Initialize an encoder
            ///
            /// Initializes an encoder. Encoders need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeEncoderAsync(InitializeEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return InitializeEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Initialize an encoder
            ///
            /// Initializes an encoder. Encoders need to be initialized before
            /// you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeEncoderAsync(InitializeEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_InitializeEncoder, null, options, request);
            }

            /// <summary>
            /// Configure an encoder
            ///
            /// Configures an encoder. Configuring an encoder implies adding some
            /// information to the encoder based on the current settings.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureEncoder(ConfigureEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ConfigureEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure an encoder
            ///
            /// Configures an encoder. Configuring an encoder implies adding some
            /// information to the encoder based on the current settings.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureEncoder(ConfigureEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ConfigureEncoder, null, options, request);
            /// <summary>
            /// Configure an encoder
            ///
            /// Configures an encoder. Configuring an encoder implies adding some
            /// information to the encoder based on the current settings.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureEncoderAsync(ConfigureEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ConfigureEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Configure an encoder
            ///
            /// Configures an encoder. Configuring an encoder implies adding some
            /// information to the encoder based on the current settings.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureEncoderAsync(ConfigureEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ConfigureEncoder, null, options, request);
            }

            /// <summary>
            /// Reset an encoder
            ///
            /// Resetting a device such as an encoder means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetEncoder(ResetEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ResetEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset an encoder
            ///
            /// Resetting a device such as an encoder means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetEncoder(ResetEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ResetEncoder, null, options, request);
            /// <summary>
            /// Reset an encoder
            ///
            /// Resetting a device such as an encoder means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetEncoderAsync(ResetEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ResetEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Reset an encoder
            ///
            /// Resetting a device such as an encoder means returning it to its factory
            /// settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetEncoderAsync(ResetEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ResetEncoder, null, options, request);
            }

            /// <summary>
            /// Update encoder firmware
            ///
            /// Updates an encoder's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateEncoderFirmware(UpdateEncoderFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateEncoderFirmware(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update encoder firmware
            ///
            /// Updates an encoder's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateEncoderFirmware(UpdateEncoderFirmwareRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateEncoderFirmware, null, options, request);
            /// <summary>
            /// Update encoder firmware
            ///
            /// Updates an encoder's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateEncoderFirmwareAsync(UpdateEncoderFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateEncoderFirmwareAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update encoder firmware
            ///
            /// Updates an encoder's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateEncoderFirmwareAsync(UpdateEncoderFirmwareRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateEncoderFirmware, null, options, request);
            }

            /// <summary>
            /// Bind an encoder
            ///
            /// Binds an encoder. Binding an encoder assigns a device
            /// identifier to the encoder. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindEncoderResponse BindEncoder(BindEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => BindEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind an encoder
            ///
            /// Binds an encoder. Binding an encoder assigns a device
            /// identifier to the encoder. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindEncoderResponse BindEncoder(BindEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BindEncoder, null, options, request);
            /// <summary>
            /// Bind an encoder
            ///
            /// Binds an encoder. Binding an encoder assigns a device
            /// identifier to the encoder. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindEncoderResponse> BindEncoderAsync(BindEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return BindEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Bind an encoder
            ///
            /// Binds an encoder. Binding an encoder assigns a device
            /// identifier to the encoder. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindEncoderResponse> BindEncoderAsync(BindEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BindEncoder, null, options, request);
            }

            /// <summary>
            /// Unbind an encoder
            ///
            /// Unbinds an encoder. Unbinding an encoder removes the
            /// device identifier from the encoder. This may be required in some
            /// cases where the encoder is not available anymore because, for
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
            public virtual UnbindEncoderResponse UnbindEncoder(UnbindEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UnbindEncoder(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind an encoder
            ///
            /// Unbinds an encoder. Unbinding an encoder removes the
            /// device identifier from the encoder. This may be required in some
            /// cases where the encoder is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindEncoderResponse UnbindEncoder(UnbindEncoderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnbindEncoder, null, options, request);
            /// <summary>
            /// Unbind an encoder
            ///
            /// Unbinds an encoder. Unbinding an encoder removes the
            /// device identifier from the encoder. This may be required in some
            /// cases where the encoder is not available anymore because, for
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
            public virtual AsyncUnaryCall<UnbindEncoderResponse> UnbindEncoderAsync(UnbindEncoderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UnbindEncoderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Unbind an encoder
            ///
            /// Unbinds an encoder. Unbinding an encoder removes the
            /// device identifier from the encoder. This may be required in some
            /// cases where the encoder is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindEncoderResponse> UnbindEncoderAsync(UnbindEncoderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UnbindEncoder, null, options, request);
            }

            /// <summary>
            /// Read a key
            ///
            /// Reads a key presented on an encoder.
            /// (-- api-linter: core::0131::synonyms=disabled  --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ReadKey(ReadKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ReadKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Read a key
            ///
            /// Reads a key presented on an encoder.
            /// (-- api-linter: core::0131::synonyms=disabled  --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ReadKey(ReadKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ReadKey, null, options, request);
            /// <summary>
            /// Read a key
            ///
            /// Reads a key presented on an encoder.
            /// (-- api-linter: core::0131::synonyms=disabled  --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ReadKeyAsync(ReadKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ReadKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Read a key
            ///
            /// Reads a key presented on an encoder.
            /// (-- api-linter: core::0131::synonyms=disabled  --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ReadKeyAsync(ReadKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ReadKey, null, options, request);
            }

            /// <summary>
            /// Generates an authorization token for an encoder
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateAuthorizationToken(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generates an authorization token for an encoder
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generates an authorization token for an encoder
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an encoder.
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
            /// Generates an authorization token for an encoder
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an encoder.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            }

            /// <summary>
            /// Generate encoder firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// encoder. The returned URI can be used to bring the encoder
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUri(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate encoder firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// encoder. The returned URI can be used to bring the encoder
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Generate encoder firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// encoder. The returned URI can be used to bring the encoder
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
            /// Generate encoder firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// encoder. The returned URI can be used to bring the encoder
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
            protected override EncoderServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
