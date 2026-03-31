using Grpc.Core;

namespace Saltoapis.Nebula.DigitalKey.V1
{
    /// <summary>
    /// DigitalKeyService is the service responsible for managing digital key
    /// resources. This service manages resources for the different types of keys
    /// that exist on mobile devices, such as app keys or wallet keys.
    /// </summary>
    public static partial class DigitalKeyService
    {
        static readonly string __ServiceName = "salto.nebula.digitalkey.v1.DigitalKeyService";

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
            if (__Helper_MessageCache<T>.IsBufferMessage)
                parser.ParseFrom(context.PayloadAsReadOnlySequence());
#endif
            return parser.ParseFrom(context.PayloadAsNewBuffer());
        }

        static readonly Marshaller<GetDigitalKeyRequest> __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetDigitalKeyRequest.Parser));

        static readonly Marshaller<DigitalKey> __Marshaller_salto_nebula_digitalkey_v1_DigitalKey = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DigitalKey.Parser));

        static readonly Marshaller<ListDigitalKeysRequest> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListDigitalKeysRequest.Parser));

        static readonly Marshaller<ListDigitalKeysResponse> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListDigitalKeysResponse.Parser));

        static readonly Marshaller<GetDigitalKeyAccessPointRequest> __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyAccessPointRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetDigitalKeyAccessPointRequest.Parser));

        static readonly Marshaller<DigitalKeyAccessPoint> __Marshaller_salto_nebula_digitalkey_v1_DigitalKeyAccessPoint = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DigitalKeyAccessPoint.Parser));

        static readonly Marshaller<ListDigitalKeyAccessPointsRequest> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListDigitalKeyAccessPointsRequest.Parser));

        static readonly Marshaller<ListDigitalKeyAccessPointsResponse> __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListDigitalKeyAccessPointsResponse.Parser));

        static readonly Marshaller<SyncDigitalKeyAccessPointsRequest> __Marshaller_salto_nebula_digitalkey_v1_SyncDigitalKeyAccessPointsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, SyncDigitalKeyAccessPointsRequest.Parser));

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Longrunning.V1.Operation.Parser));

        static readonly Marshaller<UnlockDigitalKeyAccessPointRequest> __Marshaller_salto_nebula_digitalkey_v1_UnlockDigitalKeyAccessPointRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnlockDigitalKeyAccessPointRequest.Parser));

        static readonly Method<GetDigitalKeyRequest, DigitalKey> __Method_GetDigitalKey = new(
            MethodType.Unary,
            __ServiceName,
            "GetDigitalKey",
            __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyRequest,
            __Marshaller_salto_nebula_digitalkey_v1_DigitalKey);

        static readonly Method<ListDigitalKeysRequest, ListDigitalKeysResponse> __Method_ListDigitalKeys = new(
            MethodType.Unary,
            __ServiceName,
            "ListDigitalKeys",
            __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysRequest,
            __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeysResponse);

        static readonly Method<GetDigitalKeyAccessPointRequest, DigitalKeyAccessPoint> __Method_GetDigitalKeyAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "GetDigitalKeyAccessPoint",
            __Marshaller_salto_nebula_digitalkey_v1_GetDigitalKeyAccessPointRequest,
            __Marshaller_salto_nebula_digitalkey_v1_DigitalKeyAccessPoint);

        static readonly Method<ListDigitalKeyAccessPointsRequest, ListDigitalKeyAccessPointsResponse> __Method_ListDigitalKeyAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "ListDigitalKeyAccessPoints",
            __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsRequest,
            __Marshaller_salto_nebula_digitalkey_v1_ListDigitalKeyAccessPointsResponse);

        static readonly Method<SyncDigitalKeyAccessPointsRequest, Longrunning.V1.Operation> __Method_SyncDigitalKeyAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "SyncDigitalKeyAccessPoints",
            __Marshaller_salto_nebula_digitalkey_v1_SyncDigitalKeyAccessPointsRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<UnlockDigitalKeyAccessPointRequest, Longrunning.V1.Operation> __Method_UnlockDigitalKeyAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "UnlockDigitalKeyAccessPoint",
            __Marshaller_salto_nebula_digitalkey_v1_UnlockDigitalKeyAccessPointRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for DigitalKeyService</summary>
        public partial class DigitalKeyServiceClient : ClientBase<DigitalKeyServiceClient>
        {

            /// <summary>Creates a new client for DigitalKeyService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public DigitalKeyServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for DigitalKeyService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public DigitalKeyServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected DigitalKeyServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected DigitalKeyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Get a digital key
            ///
            /// Gets an existing digital key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual DigitalKey GetDigitalKey(GetDigitalKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
                      => GetDigitalKey(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Get a digital key
            ///
            /// Gets an existing digital key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual DigitalKey GetDigitalKey(GetDigitalKeyRequest request, CallOptions options)
            => CallInvoker.BlockingUnaryCall(__Method_GetDigitalKey, null, options, request);

            /// <summary>
            /// Get a digital key
            ///
            /// Gets an existing digital key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<DigitalKey> GetDigitalKeyAsync(GetDigitalKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => GetDigitalKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Get a digital key
            ///
            /// Gets an existing digital key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<DigitalKey> GetDigitalKeyAsync(GetDigitalKeyRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_GetDigitalKey, null, options, request);

            /// <summary>
            /// List digital keys
            ///
            /// Returns a list of digital keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDigitalKeysResponse ListDigitalKeys(ListDigitalKeysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => ListDigitalKeys(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// List digital keys
            ///
            /// Returns a list of digital keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDigitalKeysResponse ListDigitalKeys(ListDigitalKeysRequest request, CallOptions options)
            => CallInvoker.BlockingUnaryCall(__Method_ListDigitalKeys, null, options, request);

            /// <summary>
            /// List digital keys
            ///
            /// Returns a list of digital keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDigitalKeysResponse> ListDigitalKeysAsync(ListDigitalKeysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => ListDigitalKeysAsync(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// List digital keys
            ///
            /// Returns a list of digital keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDigitalKeysResponse> ListDigitalKeysAsync(ListDigitalKeysRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_ListDigitalKeys, null, options, request);

            /// <summary>
            /// Get an access point
            ///
            /// Gets an existing digital key's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual DigitalKeyAccessPoint GetDigitalKeyAccessPoint(GetDigitalKeyAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => GetDigitalKeyAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Get an access point
            ///
            /// Gets an existing digital key's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual DigitalKeyAccessPoint GetDigitalKeyAccessPoint(GetDigitalKeyAccessPointRequest request, CallOptions options)
            => CallInvoker.BlockingUnaryCall(__Method_GetDigitalKeyAccessPoint, null, options, request);

            /// <summary>
            /// Get an access point
            ///
            /// Gets an existing digital key's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<DigitalKeyAccessPoint> GetDigitalKeyAccessPointAsync(GetDigitalKeyAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => GetDigitalKeyAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Get an access point
            ///
            /// Gets an existing digital key's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<DigitalKeyAccessPoint> GetDigitalKeyAccessPointAsync(GetDigitalKeyAccessPointRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_GetDigitalKeyAccessPoint, null, options, request);

            /// <summary>
            /// List access points
            ///
            /// Lists an existing digital key's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDigitalKeyAccessPointsResponse ListDigitalKeyAccessPoints(ListDigitalKeyAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => ListDigitalKeyAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// List access points
            ///
            /// Lists an existing digital key's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDigitalKeyAccessPointsResponse ListDigitalKeyAccessPoints(ListDigitalKeyAccessPointsRequest request, CallOptions options)
            => CallInvoker.BlockingUnaryCall(__Method_ListDigitalKeyAccessPoints, null, options, request);

            /// <summary>
            /// List access points
            ///
            /// Lists an existing digital key's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDigitalKeyAccessPointsResponse> ListDigitalKeyAccessPointsAsync(ListDigitalKeyAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => ListDigitalKeyAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// List access points
            ///
            /// Lists an existing digital key's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDigitalKeyAccessPointsResponse> ListDigitalKeyAccessPointsAsync(ListDigitalKeyAccessPointsRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_ListDigitalKeyAccessPoints, null, options, request);

            /// <summary>
            /// Synchronize access points
            ///
            /// Synchronize the digital key's access point associations.
            /// This methods asks the cloud to synchronize the access points for the given digital key.
            /// The cloud will trigger the synchronization of the digital key's access points if needed.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation SyncDigitalKeyAccessPoints(SyncDigitalKeyAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => SyncDigitalKeyAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Synchronize access points
            ///
            /// Synchronize the digital key's access point associations.
            /// This methods asks the cloud to synchronize the access points for the given digital key.
            /// The cloud will trigger the synchronization of the digital key's access points if needed.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation SyncDigitalKeyAccessPoints(SyncDigitalKeyAccessPointsRequest request, CallOptions options)
            => CallInvoker.BlockingUnaryCall(__Method_SyncDigitalKeyAccessPoints, null, options, request);

            /// <summary>
            /// Synchronize access points
            ///
            /// Synchronize the digital key's access point associations.
            /// This methods asks the cloud to synchronize the access points for the given digital key.
            /// The cloud will trigger the synchronization of the digital key's access points if needed.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> SyncDigitalKeyAccessPointsAsync(SyncDigitalKeyAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => SyncDigitalKeyAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Synchronize access points
            ///
            /// Synchronize the digital key's access point associations.
            /// This methods asks the cloud to synchronize the access points for the given digital key.
            /// The cloud will trigger the synchronization of the digital key's access points if needed.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> SyncDigitalKeyAccessPointsAsync(SyncDigitalKeyAccessPointsRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_SyncDigitalKeyAccessPoints, null, options, request);

            /// <summary>
            /// Unlock an user access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// The user related to the digital key must have the necessary access rights
            /// and the access point has to include a permitted schedule to perform a remote unlock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UnlockDigitalKeyAccessPoint(UnlockDigitalKeyAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => UnlockDigitalKeyAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Unlock an user access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// The user related to the digital key must have the necessary access rights
            /// and the access point has to include a permitted schedule to perform a remote unlock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UnlockDigitalKeyAccessPoint(UnlockDigitalKeyAccessPointRequest request, CallOptions options)
            => CallInvoker.BlockingUnaryCall(__Method_UnlockDigitalKeyAccessPoint, null, options, request);

            /// <summary>
            /// Unlock an user access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// The user related to the digital key must have the necessary access rights
            /// and the access point has to include a permitted schedule to perform a remote unlock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UnlockDigitalKeyAccessPointAsync(UnlockDigitalKeyAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            => UnlockDigitalKeyAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Unlock an user access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// The user related to the digital key must have the necessary access rights
            /// and the access point has to include a permitted schedule to perform a remote unlock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UnlockDigitalKeyAccessPointAsync(UnlockDigitalKeyAccessPointRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_UnlockDigitalKeyAccessPoint, null, options, request);

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override DigitalKeyServiceClient NewInstance(ClientBaseConfiguration configuration)
            => new(configuration);
        }

    }
}
