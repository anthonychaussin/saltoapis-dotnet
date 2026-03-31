namespace Saltoapis.Nebula.AccessRight.V1
{
    /// <summary>
    /// Access rights simplify the management of access permissions for large
    /// sets of users with similar access profiles. An access right can contain
    /// multiple access points. Access rights determine who can enter where, and
    /// when. This service is responsible for managing access right resources as well
    /// as their association with access points.
    /// </summary>
    public static partial class AccessRightService
    {
        static readonly string __ServiceName = "salto.nebula.accessright.v1.AccessRightService";

        static void __Helper_SerializeMessage(IMessage message, SerializationContext context)
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (message is IBufferMessage)
            {
                context.SetPayloadLength(message.CalculateSize());
                MessageExtensions.WriteTo(message, context.GetBufferWriter());
                context.Complete();
                return;
            }
#endif
            context.Complete(MessageExtensions.ToByteArray(message));
        }

        static class __Helper_MessageCache<T>
        {
            public static readonly bool IsBufferMessage = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(IBufferMessage)).IsAssignableFrom(typeof(T));
        }

        static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (__Helper_MessageCache<T>.IsBufferMessage) return parser.ParseFrom(context.PayloadAsReadOnlySequence());
#endif
            return parser.ParseFrom(context.PayloadAsNewBuffer());
        }

        static readonly Marshaller<CreateAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateAccessRightRequest.Parser));

        static readonly Marshaller<AccessRight> __Marshaller_salto_nebula_accessright_v1_AccessRight = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, AccessRight.Parser));

        static readonly Marshaller<GetAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetAccessRightRequest.Parser));

        static readonly Marshaller<ListAccessRightsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightsRequest.Parser));

        static readonly Marshaller<ListAccessRightsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightsResponse.Parser));

        static readonly Marshaller<UpdateAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateAccessRightRequest.Parser));

        static readonly Marshaller<DeleteAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteAccessRightRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<CreateAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightAccessPointRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateAccessRightAccessPointRequest.Parser));

        static readonly Marshaller<AccessRightAccessPoint> __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPoint = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, AccessRightAccessPoint.Parser));

        static readonly Marshaller<BatchCreateAccessRightAccessPointsRequest> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchCreateAccessRightAccessPointsRequest.Parser));

        static readonly Marshaller<BatchCreateAccessRightAccessPointsResponse> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchCreateAccessRightAccessPointsResponse.Parser));

        static readonly Marshaller<GetAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightAccessPointRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetAccessRightAccessPointRequest.Parser));

        static readonly Marshaller<ListAccessRightAccessPointsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightAccessPointsRequest.Parser));

        static readonly Marshaller<ListAccessRightAccessPointsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightAccessPointsResponse.Parser));

        static readonly Marshaller<UpdateAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightAccessPointRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateAccessRightAccessPointRequest.Parser));

        static readonly Marshaller<DeleteAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightAccessPointRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteAccessRightAccessPointRequest.Parser));

        static readonly Marshaller<BatchDeleteAccessRightAccessPointsRequest> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchDeleteAccessRightAccessPointsRequest.Parser));

        static readonly Marshaller<BatchDeleteAccessRightAccessPointsResponse> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchDeleteAccessRightAccessPointsResponse.Parser));

        static readonly Marshaller<CreateAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightAccessPointGroupRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateAccessRightAccessPointGroupRequest.Parser));

        static readonly Marshaller<AccessRightAccessPointGroup> __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPointGroup = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, AccessRightAccessPointGroup.Parser));

        static readonly Marshaller<BatchCreateAccessRightAccessPointGroupsRequest> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointGroupsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchCreateAccessRightAccessPointGroupsRequest.Parser));

        static readonly Marshaller<BatchCreateAccessRightAccessPointGroupsResponse> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointGroupsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchCreateAccessRightAccessPointGroupsResponse.Parser));

        static readonly Marshaller<GetAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightAccessPointGroupRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetAccessRightAccessPointGroupRequest.Parser));

        static readonly Marshaller<ListAccessRightAccessPointGroupsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointGroupsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightAccessPointGroupsRequest.Parser));

        static readonly Marshaller<ListAccessRightAccessPointGroupsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointGroupsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightAccessPointGroupsResponse.Parser));

        static readonly Marshaller<UpdateAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightAccessPointGroupRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateAccessRightAccessPointGroupRequest.Parser));

        static readonly Marshaller<DeleteAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightAccessPointGroupRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteAccessRightAccessPointGroupRequest.Parser));

        static readonly Marshaller<BatchDeleteAccessRightAccessPointGroupsRequest> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointGroupsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchDeleteAccessRightAccessPointGroupsRequest.Parser));

        static readonly Marshaller<BatchDeleteAccessRightAccessPointGroupsResponse> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointGroupsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BatchDeleteAccessRightAccessPointGroupsResponse.Parser));

        static readonly Marshaller<CreateAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightDestinationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateAccessRightDestinationRequest.Parser));

        static readonly Marshaller<AccessRightDestination> __Marshaller_salto_nebula_accessright_v1_AccessRightDestination = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, AccessRightDestination.Parser));

        static readonly Marshaller<GetAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightDestinationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetAccessRightDestinationRequest.Parser));

        static readonly Marshaller<ListAccessRightDestinationsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightDestinationsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightDestinationsRequest.Parser));

        static readonly Marshaller<ListAccessRightDestinationsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightDestinationsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListAccessRightDestinationsResponse.Parser));

        static readonly Marshaller<UpdateAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightDestinationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateAccessRightDestinationRequest.Parser));

        static readonly Marshaller<DeleteAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightDestinationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteAccessRightDestinationRequest.Parser));

        static readonly Method<CreateAccessRightRequest, AccessRight> __Method_CreateAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "CreateAccessRight",
            __Marshaller_salto_nebula_accessright_v1_CreateAccessRightRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRight);

        static readonly Method<GetAccessRightRequest, AccessRight> __Method_GetAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "GetAccessRight",
            __Marshaller_salto_nebula_accessright_v1_GetAccessRightRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRight);

        static readonly Method<ListAccessRightsRequest, ListAccessRightsResponse> __Method_ListAccessRights = new(
            MethodType.Unary,
            __ServiceName,
            "ListAccessRights",
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightsRequest,
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightsResponse);

        static readonly Method<UpdateAccessRightRequest, AccessRight> __Method_UpdateAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateAccessRight",
            __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRight);

        static readonly Method<DeleteAccessRightRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteAccessRight",
            __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<CreateAccessRightAccessPointRequest, AccessRightAccessPoint> __Method_CreateAccessRightAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "CreateAccessRightAccessPoint",
            __Marshaller_salto_nebula_accessright_v1_CreateAccessRightAccessPointRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPoint);

        static readonly Method<BatchCreateAccessRightAccessPointsRequest, BatchCreateAccessRightAccessPointsResponse> __Method_BatchCreateAccessRightAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "BatchCreateAccessRightAccessPoints",
            __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointsRequest,
            __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointsResponse);

        static readonly Method<GetAccessRightAccessPointRequest, AccessRightAccessPoint> __Method_GetAccessRightAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "GetAccessRightAccessPoint",
            __Marshaller_salto_nebula_accessright_v1_GetAccessRightAccessPointRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPoint);

        static readonly Method<ListAccessRightAccessPointsRequest, ListAccessRightAccessPointsResponse> __Method_ListAccessRightAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "ListAccessRightAccessPoints",
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointsRequest,
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointsResponse);

        static readonly Method<UpdateAccessRightAccessPointRequest, AccessRightAccessPoint> __Method_UpdateAccessRightAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateAccessRightAccessPoint",
            __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightAccessPointRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPoint);

        static readonly Method<DeleteAccessRightAccessPointRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAccessRightAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteAccessRightAccessPoint",
            __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightAccessPointRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<BatchDeleteAccessRightAccessPointsRequest, BatchDeleteAccessRightAccessPointsResponse> __Method_BatchDeleteAccessRightAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "BatchDeleteAccessRightAccessPoints",
            __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointsRequest,
            __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointsResponse);

        static readonly Method<CreateAccessRightAccessPointGroupRequest, AccessRightAccessPointGroup> __Method_CreateAccessRightAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "CreateAccessRightAccessPointGroup",
            __Marshaller_salto_nebula_accessright_v1_CreateAccessRightAccessPointGroupRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPointGroup);

        static readonly Method<BatchCreateAccessRightAccessPointGroupsRequest, BatchCreateAccessRightAccessPointGroupsResponse> __Method_BatchCreateAccessRightAccessPointGroups = new(
            MethodType.Unary,
            __ServiceName,
            "BatchCreateAccessRightAccessPointGroups",
            __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointGroupsRequest,
            __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointGroupsResponse);

        static readonly Method<GetAccessRightAccessPointGroupRequest, AccessRightAccessPointGroup> __Method_GetAccessRightAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "GetAccessRightAccessPointGroup",
            __Marshaller_salto_nebula_accessright_v1_GetAccessRightAccessPointGroupRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPointGroup);

        static readonly Method<ListAccessRightAccessPointGroupsRequest, ListAccessRightAccessPointGroupsResponse> __Method_ListAccessRightAccessPointGroups = new(
            MethodType.Unary,
            __ServiceName,
            "ListAccessRightAccessPointGroups",
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointGroupsRequest,
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointGroupsResponse);

        static readonly Method<UpdateAccessRightAccessPointGroupRequest, AccessRightAccessPointGroup> __Method_UpdateAccessRightAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateAccessRightAccessPointGroup",
            __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightAccessPointGroupRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPointGroup);

        static readonly Method<DeleteAccessRightAccessPointGroupRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAccessRightAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteAccessRightAccessPointGroup",
            __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightAccessPointGroupRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<BatchDeleteAccessRightAccessPointGroupsRequest, BatchDeleteAccessRightAccessPointGroupsResponse> __Method_BatchDeleteAccessRightAccessPointGroups = new(
            MethodType.Unary,
            __ServiceName,
            "BatchDeleteAccessRightAccessPointGroups",
            __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointGroupsRequest,
            __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointGroupsResponse);

        static readonly Method<CreateAccessRightDestinationRequest, AccessRightDestination> __Method_CreateAccessRightDestination = new(
            MethodType.Unary,
            __ServiceName,
            "CreateAccessRightDestination",
            __Marshaller_salto_nebula_accessright_v1_CreateAccessRightDestinationRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightDestination);

        static readonly Method<GetAccessRightDestinationRequest, AccessRightDestination> __Method_GetAccessRightDestination = new(
            MethodType.Unary,
            __ServiceName,
            "GetAccessRightDestination",
            __Marshaller_salto_nebula_accessright_v1_GetAccessRightDestinationRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightDestination);

        static readonly Method<ListAccessRightDestinationsRequest, ListAccessRightDestinationsResponse> __Method_ListAccessRightDestinations = new(
            MethodType.Unary,
            __ServiceName,
            "ListAccessRightDestinations",
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightDestinationsRequest,
            __Marshaller_salto_nebula_accessright_v1_ListAccessRightDestinationsResponse);

        static readonly Method<UpdateAccessRightDestinationRequest, AccessRightDestination> __Method_UpdateAccessRightDestination = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateAccessRightDestination",
            __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightDestinationRequest,
            __Marshaller_salto_nebula_accessright_v1_AccessRightDestination);

        static readonly Method<DeleteAccessRightDestinationRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAccessRightDestination = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteAccessRightDestination",
            __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightDestinationRequest,
            __Marshaller_google_protobuf_Empty);

        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for AccessRightService</summary>
        public partial class AccessRightServiceClient : ClientBase<AccessRightServiceClient>
        {
            /// <summary>Creates a new client for AccessRightService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public AccessRightServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for AccessRightService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public AccessRightServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected AccessRightServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected AccessRightServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an access right
            ///
            /// Creates a new access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRight CreateAccessRight(CreateAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRight(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Create an access right
            ///
            /// Creates a new access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRight CreateAccessRight(CreateAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateAccessRight, null, options, request);

            /// <summary>
            /// Create an access right
            ///
            /// Creates a new access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> CreateAccessRightAsync(CreateAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return CreateAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an access right
            ///
            /// Creates a new access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> CreateAccessRightAsync(CreateAccessRightRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateAccessRight, null, options, request);
            }

            /// <summary>
            /// Get an access right
            ///
            /// Retrieves an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRight GetAccessRight(GetAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRight(request, new CallOptions(headers, deadline, cancellationToken));

            /// <summary>
            /// Get an access right
            ///
            /// Retrieves an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRight GetAccessRight(GetAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetAccessRight, null, options, request);

            /// <summary>
            /// Get an access right
            ///
            /// Retrieves an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> GetAccessRightAsync(GetAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return GetAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an access right
            ///
            /// Retrieves an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> GetAccessRightAsync(GetAccessRightRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetAccessRight, null, options, request);
            }

            /// <summary>
            /// List access rights
            ///
            /// Returns a list of access rights that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightsResponse ListAccessRights(ListAccessRightsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRights(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access rights
            ///
            /// Returns a list of access rights that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightsResponse ListAccessRights(ListAccessRightsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListAccessRights, null, options, request);
            /// <summary>
            /// List access rights
            ///
            /// Returns a list of access rights that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightsResponse> ListAccessRightsAsync(ListAccessRightsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return ListAccessRightsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List access rights
            ///
            /// Returns a list of access rights that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightsResponse> ListAccessRightsAsync(ListAccessRightsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListAccessRights, null, options, request);
            }

            /// <summary>
            /// Update an access right
            ///
            /// Updates an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRight UpdateAccessRight(UpdateAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRight(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access right
            ///
            /// Updates an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRight UpdateAccessRight(UpdateAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateAccessRight, null, options, request);
            /// <summary>
            /// Update an access right
            ///
            /// Updates an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> UpdateAccessRightAsync(UpdateAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return UpdateAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an access right
            ///
            /// Updates an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> UpdateAccessRightAsync(UpdateAccessRightRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRight, null, options, request);
            }

            /// <summary>
            /// Delete an access right
            ///
            /// Permanently deletes an access right. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRight(DeleteAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRight(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access right
            ///
            /// Permanently deletes an access right. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRight(DeleteAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteAccessRight, null, options, request);
            /// <summary>
            /// Delete an access right
            ///
            /// Permanently deletes an access right. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAsync(DeleteAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return DeleteAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an access right
            ///
            /// Permanently deletes an access right. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAsync(DeleteAccessRightRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRight, null, options, request);
            }

            /// <summary>
            /// Create an access point
            ///
            /// Creates an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPoint CreateAccessRightAccessPoint(CreateAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRightAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access point
            ///
            /// Creates an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPoint CreateAccessRightAccessPoint(CreateAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateAccessRightAccessPoint, null, options, request);
            /// <summary>
            /// Create an access point
            ///
            /// Creates an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> CreateAccessRightAccessPointAsync(CreateAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return CreateAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an access point
            ///
            /// Creates an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> CreateAccessRightAccessPointAsync(CreateAccessRightAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateAccessRightAccessPoint, null, options, request);
            }

            /// <summary>
            /// Create a batch of access rights access points
            ///
            /// Creates a batch of access rights access points associations.
            /// This method allows the creation of multiple access rights access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateAccessRightAccessPointsResponse BatchCreateAccessRightAccessPoints(BatchCreateAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchCreateAccessRightAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a batch of access rights access points
            ///
            /// Creates a batch of access rights access points associations.
            /// This method allows the creation of multiple access rights access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateAccessRightAccessPointsResponse BatchCreateAccessRightAccessPoints(BatchCreateAccessRightAccessPointsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchCreateAccessRightAccessPoints, null, options, request);
            /// <summary>
            /// Create a batch of access rights access points
            ///
            /// Creates a batch of access rights access points associations.
            /// This method allows the creation of multiple access rights access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointsResponse> BatchCreateAccessRightAccessPointsAsync(BatchCreateAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return BatchCreateAccessRightAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a batch of access rights access points
            ///
            /// Creates a batch of access rights access points associations.
            /// This method allows the creation of multiple access rights access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointsResponse> BatchCreateAccessRightAccessPointsAsync(BatchCreateAccessRightAccessPointsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BatchCreateAccessRightAccessPoints, null, options, request);
            }

            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPoint GetAccessRightAccessPoint(GetAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRightAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPoint GetAccessRightAccessPoint(GetAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetAccessRightAccessPoint, null, options, request);
            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> GetAccessRightAccessPointAsync(GetAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return GetAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> GetAccessRightAccessPointAsync(GetAccessRightAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetAccessRightAccessPoint, null, options, request);
            }

            /// <summary>
            /// List access points
            ///
            /// Lists an existing access right's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightAccessPointsResponse ListAccessRightAccessPoints(ListAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRightAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access points
            ///
            /// Lists an existing access right's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightAccessPointsResponse ListAccessRightAccessPoints(ListAccessRightAccessPointsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListAccessRightAccessPoints, null, options, request);
            /// <summary>
            /// List access points
            ///
            /// Lists an existing access right's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightAccessPointsResponse> ListAccessRightAccessPointsAsync(ListAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return ListAccessRightAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List access points
            ///
            /// Lists an existing access right's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightAccessPointsResponse> ListAccessRightAccessPointsAsync(ListAccessRightAccessPointsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListAccessRightAccessPoints, null, options, request);
            }

            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPoint UpdateAccessRightAccessPoint(UpdateAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRightAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPoint UpdateAccessRightAccessPoint(UpdateAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateAccessRightAccessPoint, null, options, request);
            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> UpdateAccessRightAccessPointAsync(UpdateAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return UpdateAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> UpdateAccessRightAccessPointAsync(UpdateAccessRightAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRightAccessPoint, null, options, request);
            }

            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRightAccessPoint(DeleteAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRightAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRightAccessPoint(DeleteAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteAccessRightAccessPoint, null, options, request);
            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointAsync(DeleteAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return DeleteAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointAsync(DeleteAccessRightAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRightAccessPoint, null, options, request);
            }

            /// <summary>
            /// Delete a batch of access points
            ///
            /// Permanently deletes a batch of access right's access point associations.
            /// This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteAccessRightAccessPointsResponse BatchDeleteAccessRightAccessPoints(BatchDeleteAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchDeleteAccessRightAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a batch of access points
            ///
            /// Permanently deletes a batch of access right's access point associations.
            /// This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteAccessRightAccessPointsResponse BatchDeleteAccessRightAccessPoints(BatchDeleteAccessRightAccessPointsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchDeleteAccessRightAccessPoints, null, options, request);
            /// <summary>
            /// Delete a batch of access points
            ///
            /// Permanently deletes a batch of access right's access point associations.
            /// This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointsResponse> BatchDeleteAccessRightAccessPointsAsync(BatchDeleteAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return BatchDeleteAccessRightAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a batch of access points
            ///
            /// Permanently deletes a batch of access right's access point associations.
            /// This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointsResponse> BatchDeleteAccessRightAccessPointsAsync(BatchDeleteAccessRightAccessPointsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BatchDeleteAccessRightAccessPoints, null, options, request);
            }

            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPointGroup CreateAccessRightAccessPointGroup(CreateAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRightAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPointGroup CreateAccessRightAccessPointGroup(CreateAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateAccessRightAccessPointGroup, null, options, request);
            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> CreateAccessRightAccessPointGroupAsync(CreateAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return CreateAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> CreateAccessRightAccessPointGroupAsync(CreateAccessRightAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateAccessRightAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// Create a batch of access right's access point groups
            ///
            /// Creates a batch of access right's access point groups associations.
            /// This method allows the creation of multiple access right's access point groups in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateAccessRightAccessPointGroupsResponse BatchCreateAccessRightAccessPointGroups(BatchCreateAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchCreateAccessRightAccessPointGroups(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a batch of access right's access point groups
            ///
            /// Creates a batch of access right's access point groups associations.
            /// This method allows the creation of multiple access right's access point groups in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateAccessRightAccessPointGroupsResponse BatchCreateAccessRightAccessPointGroups(BatchCreateAccessRightAccessPointGroupsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchCreateAccessRightAccessPointGroups, null, options, request);
            /// <summary>
            /// Create a batch of access right's access point groups
            ///
            /// Creates a batch of access right's access point groups associations.
            /// This method allows the creation of multiple access right's access point groups in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointGroupsResponse> BatchCreateAccessRightAccessPointGroupsAsync(BatchCreateAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return BatchCreateAccessRightAccessPointGroupsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a batch of access right's access point groups
            ///
            /// Creates a batch of access right's access point groups associations.
            /// This method allows the creation of multiple access right's access point groups in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointGroupsResponse> BatchCreateAccessRightAccessPointGroupsAsync(BatchCreateAccessRightAccessPointGroupsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BatchCreateAccessRightAccessPointGroups, null, options, request);
            }

            /// <summary>
            /// Get an access point group
            ///
            /// Retrieves an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPointGroup GetAccessRightAccessPointGroup(GetAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRightAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access point group
            ///
            /// Retrieves an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPointGroup GetAccessRightAccessPointGroup(GetAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetAccessRightAccessPointGroup, null, options, request);
            /// <summary>
            /// Get an access point group
            ///
            /// Retrieves an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> GetAccessRightAccessPointGroupAsync(GetAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return GetAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an access point group
            ///
            /// Retrieves an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> GetAccessRightAccessPointGroupAsync(GetAccessRightAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetAccessRightAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// List access point groups
            ///
            /// Lists an existing access right's access point group associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightAccessPointGroupsResponse ListAccessRightAccessPointGroups(ListAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRightAccessPointGroups(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access point groups
            ///
            /// Lists an existing access right's access point group associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightAccessPointGroupsResponse ListAccessRightAccessPointGroups(ListAccessRightAccessPointGroupsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListAccessRightAccessPointGroups, null, options, request);
            /// <summary>
            /// List access point groups
            ///
            /// Lists an existing access right's access point group associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightAccessPointGroupsResponse> ListAccessRightAccessPointGroupsAsync(ListAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return ListAccessRightAccessPointGroupsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List access point groups
            ///
            /// Lists an existing access right's access point group associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightAccessPointGroupsResponse> ListAccessRightAccessPointGroupsAsync(ListAccessRightAccessPointGroupsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListAccessRightAccessPointGroups, null, options, request);
            }

            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPointGroup UpdateAccessRightAccessPointGroup(UpdateAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRightAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightAccessPointGroup UpdateAccessRightAccessPointGroup(UpdateAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateAccessRightAccessPointGroup, null, options, request);
            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> UpdateAccessRightAccessPointGroupAsync(UpdateAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return UpdateAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> UpdateAccessRightAccessPointGroupAsync(UpdateAccessRightAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRightAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// Delete an access point group
            ///
            /// Deletes an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRightAccessPointGroup(DeleteAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRightAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access point group
            ///
            /// Deletes an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRightAccessPointGroup(DeleteAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteAccessRightAccessPointGroup, null, options, request);
            /// <summary>
            /// Delete an access point group
            ///
            /// Deletes an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointGroupAsync(DeleteAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return DeleteAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an access point group
            ///
            /// Deletes an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointGroupAsync(DeleteAccessRightAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRightAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// Delete a batch of access point groups
            ///
            /// Permanently deletes a batch access right's access point group associations. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteAccessRightAccessPointGroupsResponse BatchDeleteAccessRightAccessPointGroups(BatchDeleteAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchDeleteAccessRightAccessPointGroups(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a batch of access point groups
            ///
            /// Permanently deletes a batch access right's access point group associations. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteAccessRightAccessPointGroupsResponse BatchDeleteAccessRightAccessPointGroups(BatchDeleteAccessRightAccessPointGroupsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchDeleteAccessRightAccessPointGroups, null, options, request);
            /// <summary>
            /// Delete a batch of access point groups
            ///
            /// Permanently deletes a batch access right's access point group associations. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointGroupsResponse> BatchDeleteAccessRightAccessPointGroupsAsync(BatchDeleteAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return BatchDeleteAccessRightAccessPointGroupsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a batch of access point groups
            ///
            /// Permanently deletes a batch access right's access point group associations. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointGroupsResponse> BatchDeleteAccessRightAccessPointGroupsAsync(BatchDeleteAccessRightAccessPointGroupsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BatchDeleteAccessRightAccessPointGroups, null, options, request);
            }

            /// <summary>
            /// Create an access right destination
            ///
            /// Creates an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightDestination CreateAccessRightDestination(CreateAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRightDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access right destination
            ///
            /// Creates an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightDestination CreateAccessRightDestination(CreateAccessRightDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateAccessRightDestination, null, options, request);
            /// <summary>
            /// Create an access right destination
            ///
            /// Creates an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> CreateAccessRightDestinationAsync(CreateAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return CreateAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an access right destination
            ///
            /// Creates an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> CreateAccessRightDestinationAsync(CreateAccessRightDestinationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateAccessRightDestination, null, options, request);
            }

            /// <summary>
            /// Get an access right destination
            ///
            /// Retrieves an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightDestination GetAccessRightDestination(GetAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRightDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access right destination
            ///
            /// Retrieves an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightDestination GetAccessRightDestination(GetAccessRightDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetAccessRightDestination, null, options, request);
            /// <summary>
            /// Get an access right destination
            ///
            /// Retrieves an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> GetAccessRightDestinationAsync(GetAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return GetAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an access right destination
            ///
            /// Retrieves an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> GetAccessRightDestinationAsync(GetAccessRightDestinationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetAccessRightDestination, null, options, request);
            }

            /// <summary>
            /// List access right destinations
            ///
            /// Lists an existing access right's destination associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightDestinationsResponse ListAccessRightDestinations(ListAccessRightDestinationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRightDestinations(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access right destinations
            ///
            /// Lists an existing access right's destination associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessRightDestinationsResponse ListAccessRightDestinations(ListAccessRightDestinationsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListAccessRightDestinations, null, options, request);
            /// <summary>
            /// List access right destinations
            ///
            /// Lists an existing access right's destination associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightDestinationsResponse> ListAccessRightDestinationsAsync(ListAccessRightDestinationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return ListAccessRightDestinationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List access right destinations
            ///
            /// Lists an existing access right's destination associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightDestinationsResponse> ListAccessRightDestinationsAsync(ListAccessRightDestinationsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListAccessRightDestinations, null, options, request);
            }

            /// <summary>
            /// Update an access right destination
            ///
            /// Updates an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightDestination UpdateAccessRightDestination(UpdateAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRightDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access right destination
            ///
            /// Updates an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessRightDestination UpdateAccessRightDestination(UpdateAccessRightDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateAccessRightDestination, null, options, request);
            /// <summary>
            /// Update an access right destination
            ///
            /// Updates an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> UpdateAccessRightDestinationAsync(UpdateAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return UpdateAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an access right destination
            ///
            /// Updates an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> UpdateAccessRightDestinationAsync(UpdateAccessRightDestinationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRightDestination, null, options, request);
            }

            /// <summary>
            /// Delete an access right destination
            ///
            /// Deletes an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRightDestination(DeleteAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRightDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access right destination
            ///
            /// Deletes an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessRightDestination(DeleteAccessRightDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteAccessRightDestination, null, options, request);
            /// <summary>
            /// Delete an access right destination
            ///
            /// Deletes an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightDestinationAsync(DeleteAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            {
                return DeleteAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an access right destination
            ///
            /// Deletes an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightDestinationAsync(DeleteAccessRightDestinationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRightDestination, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override AccessRightServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
