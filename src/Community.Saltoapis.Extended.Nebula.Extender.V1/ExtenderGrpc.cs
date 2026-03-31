using Saltoapis.Nebula.Extender.V1.Request;
using Saltoapis.Nebula.Extender.V1.Response;

namespace Saltoapis.Nebula.Extender.V1
{
    /// <summary>
    /// An extender allows the distance between the a gateway and an electronic lock
    /// to be extended. It forwards signals between an access point (lock) and a
    /// gateway. This service is responsible for managing extender resources.
    /// </summary>
    public static partial class ExtenderService
    {
        static readonly string __ServiceName = "salto.nebula.extender.v1.ExtenderService";

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

        static readonly Marshaller<CreateExtenderRequest> __Marshaller_salto_nebula_extender_v1_CreateExtenderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateExtenderRequest.Parser));

        static readonly Marshaller<Extender> __Marshaller_salto_nebula_extender_v1_Extender = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Extender.Parser));

        static readonly Marshaller<GetExtenderRequest> __Marshaller_salto_nebula_extender_v1_GetExtenderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetExtenderRequest.Parser));

        static readonly Marshaller<ListExtendersRequest> __Marshaller_salto_nebula_extender_v1_ListExtendersRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListExtendersRequest.Parser));

        static readonly Marshaller<ListExtendersResponse> __Marshaller_salto_nebula_extender_v1_ListExtendersResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListExtendersResponse.Parser));

        static readonly Marshaller<UpdateExtenderRequest> __Marshaller_salto_nebula_extender_v1_UpdateExtenderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateExtenderRequest.Parser));

        static readonly Marshaller<DeleteExtenderRequest> __Marshaller_salto_nebula_extender_v1_DeleteExtenderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteExtenderRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<BindExtenderRequest> __Marshaller_salto_nebula_extender_v1_BindExtenderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindExtenderRequest.Parser));

        static readonly Marshaller<BindExtenderResponse> __Marshaller_salto_nebula_extender_v1_BindExtenderResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BindExtenderResponse.Parser));

        static readonly Marshaller<UnbindExtenderRequest> __Marshaller_salto_nebula_extender_v1_UnbindExtenderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindExtenderRequest.Parser));

        static readonly Marshaller<UnbindExtenderResponse> __Marshaller_salto_nebula_extender_v1_UnbindExtenderResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnbindExtenderResponse.Parser));

        static readonly Marshaller<UpdateExtenderFirmwareRequest> __Marshaller_salto_nebula_extender_v1_UpdateExtenderFirmwareRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateExtenderFirmwareRequest.Parser));

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Longrunning.V1.Operation.Parser));

        static readonly Marshaller<ResetExtenderRequest> __Marshaller_salto_nebula_extender_v1_ResetExtenderRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ResetExtenderRequest.Parser));

        static readonly Marshaller<GenerateFirmwareDownloadUriRequest> __Marshaller_salto_nebula_extender_v1_GenerateFirmwareDownloadUriRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateFirmwareDownloadUriRequest.Parser));

        static readonly Method<CreateExtenderRequest, Extender> __Method_CreateExtender = new(
            MethodType.Unary,
            __ServiceName,
            "CreateExtender",
            __Marshaller_salto_nebula_extender_v1_CreateExtenderRequest,
            __Marshaller_salto_nebula_extender_v1_Extender);

        static readonly Method<GetExtenderRequest, Extender> __Method_GetExtender = new(
            MethodType.Unary,
            __ServiceName,
            "GetExtender",
            __Marshaller_salto_nebula_extender_v1_GetExtenderRequest,
            __Marshaller_salto_nebula_extender_v1_Extender);

        static readonly Method<ListExtendersRequest, ListExtendersResponse> __Method_ListExtenders = new(
            MethodType.Unary,
            __ServiceName,
            "ListExtenders",
            __Marshaller_salto_nebula_extender_v1_ListExtendersRequest,
            __Marshaller_salto_nebula_extender_v1_ListExtendersResponse);

        static readonly Method<UpdateExtenderRequest, Extender> __Method_UpdateExtender = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateExtender",
            __Marshaller_salto_nebula_extender_v1_UpdateExtenderRequest,
            __Marshaller_salto_nebula_extender_v1_Extender);

        static readonly Method<DeleteExtenderRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteExtender = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteExtender",
            __Marshaller_salto_nebula_extender_v1_DeleteExtenderRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<BindExtenderRequest, BindExtenderResponse> __Method_BindExtender = new(
            MethodType.Unary,
            __ServiceName,
            "BindExtender",
            __Marshaller_salto_nebula_extender_v1_BindExtenderRequest,
            __Marshaller_salto_nebula_extender_v1_BindExtenderResponse);

        static readonly Method<UnbindExtenderRequest, UnbindExtenderResponse> __Method_UnbindExtender = new(
            MethodType.Unary,
            __ServiceName,
            "UnbindExtender",
            __Marshaller_salto_nebula_extender_v1_UnbindExtenderRequest,
            __Marshaller_salto_nebula_extender_v1_UnbindExtenderResponse);

        static readonly Method<UpdateExtenderFirmwareRequest, Longrunning.V1.Operation> __Method_UpdateExtenderFirmware = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateExtenderFirmware",
            __Marshaller_salto_nebula_extender_v1_UpdateExtenderFirmwareRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ResetExtenderRequest, Longrunning.V1.Operation> __Method_ResetExtender = new(
            MethodType.Unary,
            __ServiceName,
            "ResetExtender",
            __Marshaller_salto_nebula_extender_v1_ResetExtenderRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<GenerateFirmwareDownloadUriRequest, Longrunning.V1.Operation> __Method_GenerateFirmwareDownloadUri = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateFirmwareDownloadUri",
            __Marshaller_salto_nebula_extender_v1_GenerateFirmwareDownloadUriRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for ExtenderService</summary>
        public partial class ExtenderServiceClient : ClientBase<ExtenderServiceClient>
        {
            /// <summary>Creates a new client for ExtenderService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public ExtenderServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for ExtenderService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public ExtenderServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected ExtenderServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected ExtenderServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an extender
            ///
            /// Creates a new extender
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Extender CreateExtender(CreateExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateExtender(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an extender
            ///
            /// Creates a new extender
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Extender CreateExtender(CreateExtenderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateExtender, null, options, request);
            /// <summary>
            /// Create an extender
            ///
            /// Creates a new extender
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Extender> CreateExtenderAsync(CreateExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateExtenderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an extender
            ///
            /// Creates a new extender
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Extender> CreateExtenderAsync(CreateExtenderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateExtender, null, options, request);
            }

            /// <summary>
            /// Get an extender
            ///
            /// Gets an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Extender GetExtender(GetExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetExtender(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an extender
            ///
            /// Gets an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Extender GetExtender(GetExtenderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetExtender, null, options, request);
            /// <summary>
            /// Get an extender
            ///
            /// Gets an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Extender> GetExtenderAsync(GetExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetExtenderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an extender
            ///
            /// Gets an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Extender> GetExtenderAsync(GetExtenderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetExtender, null, options, request);
            }

            /// <summary>
            /// List extenders
            ///
            /// Returns a list of extenders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListExtendersResponse ListExtenders(ListExtendersRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListExtenders(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List extenders
            ///
            /// Returns a list of extenders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListExtendersResponse ListExtenders(ListExtendersRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListExtenders, null, options, request);
            /// <summary>
            /// List extenders
            ///
            /// Returns a list of extenders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListExtendersResponse> ListExtendersAsync(ListExtendersRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListExtendersAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List extenders
            ///
            /// Returns a list of extenders that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListExtendersResponse> ListExtendersAsync(ListExtendersRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListExtenders, null, options, request);
            }

            /// <summary>
            /// Update an extender
            ///
            /// Updates an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Extender UpdateExtender(UpdateExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateExtender(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an extender
            ///
            /// Updates an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Extender UpdateExtender(UpdateExtenderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateExtender, null, options, request);
            /// <summary>
            /// Update an extender
            ///
            /// Updates an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Extender> UpdateExtenderAsync(UpdateExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateExtenderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an extender
            ///
            /// Updates an existing extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Extender> UpdateExtenderAsync(UpdateExtenderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateExtender, null, options, request);
            }

            /// <summary>
            /// Delete an extender
            ///
            /// Permanently deletes an extender. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteExtender(DeleteExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteExtender(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an extender
            ///
            /// Permanently deletes an extender. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteExtender(DeleteExtenderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteExtender, null, options, request);
            /// <summary>
            /// Delete an extender
            ///
            /// Permanently deletes an extender. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteExtenderAsync(DeleteExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteExtenderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an extender
            ///
            /// Permanently deletes an extender. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteExtenderAsync(DeleteExtenderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteExtender, null, options, request);
            }

            /// <summary>
            /// Bind an extender
            ///
            /// Binds an extender. Binding an extender assigns a device
            /// identifier to the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindExtenderResponse BindExtender(BindExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => BindExtender(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind an extender
            ///
            /// Binds an extender. Binding an extender assigns a device
            /// identifier to the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindExtenderResponse BindExtender(BindExtenderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BindExtender, null, options, request);
            /// <summary>
            /// Bind an extender
            ///
            /// Binds an extender. Binding an extender assigns a device
            /// identifier to the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindExtenderResponse> BindExtenderAsync(BindExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return BindExtenderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Bind an extender
            ///
            /// Binds an extender. Binding an extender assigns a device
            /// identifier to the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindExtenderResponse> BindExtenderAsync(BindExtenderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BindExtender, null, options, request);
            }

            /// <summary>
            /// Unbind an extender
            ///
            /// Unbinds an extender. Unbinding an extender removes the
            /// device identifier from the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindExtenderResponse UnbindExtender(UnbindExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UnbindExtender(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind an extender
            ///
            /// Unbinds an extender. Unbinding an extender removes the
            /// device identifier from the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindExtenderResponse UnbindExtender(UnbindExtenderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnbindExtender, null, options, request);
            /// <summary>
            /// Unbind an extender
            ///
            /// Unbinds an extender. Unbinding an extender removes the
            /// device identifier from the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindExtenderResponse> UnbindExtenderAsync(UnbindExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UnbindExtenderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Unbind an extender
            ///
            /// Unbinds an extender. Unbinding an extender removes the
            /// device identifier from the extender.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindExtenderResponse> UnbindExtenderAsync(UnbindExtenderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UnbindExtender, null, options, request);
            }

            /// <summary>
            /// Update extender firmware
            ///
            /// Updates an extender's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateExtenderFirmware(UpdateExtenderFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateExtenderFirmware(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update extender firmware
            ///
            /// Updates an extender's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateExtenderFirmware(UpdateExtenderFirmwareRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateExtenderFirmware, null, options, request);
            /// <summary>
            /// Update extender firmware
            ///
            /// Updates an extender's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateExtenderFirmwareAsync(UpdateExtenderFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateExtenderFirmwareAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update extender firmware
            ///
            /// Updates an extender's firmware. SALTO provides firmware updates when
            /// new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateExtenderFirmwareAsync(UpdateExtenderFirmwareRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateExtenderFirmware, null, options, request);
            }

            /// <summary>
            /// Reset an extender
            ///
            /// Resetting a device such as an extender means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetExtender(ResetExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ResetExtender(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset an extender
            ///
            /// Resetting a device such as an extender means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetExtender(ResetExtenderRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ResetExtender, null, options, request);
            /// <summary>
            /// Reset an extender
            ///
            /// Resetting a device such as an extender means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetExtenderAsync(ResetExtenderRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ResetExtenderAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Reset an extender
            ///
            /// Resetting a device such as an extender means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetExtenderAsync(ResetExtenderRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ResetExtender, null, options, request);
            }

            /// <summary>
            /// Generate extender firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// extender. The returned URI can be used to bring the extender firmwares up
            /// to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUri(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate extender firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// extender. The returned URI can be used to bring the extender firmwares up
            /// to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Generate extender firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// extender. The returned URI can be used to bring the extender firmwares up
            /// to latest.
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
            /// Generate extender firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// extender. The returned URI can be used to bring the extender firmwares up
            /// to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override ExtenderServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
