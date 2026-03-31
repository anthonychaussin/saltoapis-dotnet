using Saltoapis.Nebula.AccessRight.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.AccessRight.V1.Response;

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

        static readonly Marshaller<CreateAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightRequest = GrpcMessageHelper.CreateMarshaller(CreateAccessRightRequest.Parser);

        static readonly Marshaller<AccessRight> __Marshaller_salto_nebula_accessright_v1_AccessRight = GrpcMessageHelper.CreateMarshaller(AccessRight.Parser);

        static readonly Marshaller<GetAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightRequest = GrpcMessageHelper.CreateMarshaller(GetAccessRightRequest.Parser);

        static readonly Marshaller<ListAccessRightsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightsRequest = GrpcMessageHelper.CreateMarshaller(ListAccessRightsRequest.Parser);

        static readonly Marshaller<ListAccessRightsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightsResponse = GrpcMessageHelper.CreateMarshaller(ListAccessRightsResponse.Parser);

        static readonly Marshaller<UpdateAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightRequest = GrpcMessageHelper.CreateMarshaller(UpdateAccessRightRequest.Parser);

        static readonly Marshaller<DeleteAccessRightRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightRequest = GrpcMessageHelper.CreateMarshaller(DeleteAccessRightRequest.Parser);

        static readonly Marshaller<CreateAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightAccessPointRequest = GrpcMessageHelper.CreateMarshaller(CreateAccessRightAccessPointRequest.Parser);

        static readonly Marshaller<AccessRightAccessPoint> __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPoint = GrpcMessageHelper.CreateMarshaller(AccessRightAccessPoint.Parser);

        static readonly Marshaller<BatchCreateAccessRightAccessPointsRequest> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointsRequest = GrpcMessageHelper.CreateMarshaller(BatchCreateAccessRightAccessPointsRequest.Parser);

        static readonly Marshaller<BatchCreateAccessRightAccessPointsResponse> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointsResponse = GrpcMessageHelper.CreateMarshaller(BatchCreateAccessRightAccessPointsResponse.Parser);

        static readonly Marshaller<GetAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightAccessPointRequest = GrpcMessageHelper.CreateMarshaller(GetAccessRightAccessPointRequest.Parser);

        static readonly Marshaller<ListAccessRightAccessPointsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointsRequest = GrpcMessageHelper.CreateMarshaller(ListAccessRightAccessPointsRequest.Parser);

        static readonly Marshaller<ListAccessRightAccessPointsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointsResponse = GrpcMessageHelper.CreateMarshaller(ListAccessRightAccessPointsResponse.Parser);

        static readonly Marshaller<UpdateAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightAccessPointRequest = GrpcMessageHelper.CreateMarshaller(UpdateAccessRightAccessPointRequest.Parser);

        static readonly Marshaller<DeleteAccessRightAccessPointRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightAccessPointRequest = GrpcMessageHelper.CreateMarshaller(DeleteAccessRightAccessPointRequest.Parser);

        static readonly Marshaller<BatchDeleteAccessRightAccessPointsRequest> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointsRequest = GrpcMessageHelper.CreateMarshaller(BatchDeleteAccessRightAccessPointsRequest.Parser);

        static readonly Marshaller<BatchDeleteAccessRightAccessPointsResponse> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointsResponse = GrpcMessageHelper.CreateMarshaller(BatchDeleteAccessRightAccessPointsResponse.Parser);

        static readonly Marshaller<CreateAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(CreateAccessRightAccessPointGroupRequest.Parser);

        static readonly Marshaller<AccessRightAccessPointGroup> __Marshaller_salto_nebula_accessright_v1_AccessRightAccessPointGroup = GrpcMessageHelper.CreateMarshaller(AccessRightAccessPointGroup.Parser);

        static readonly Marshaller<BatchCreateAccessRightAccessPointGroupsRequest> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointGroupsRequest = GrpcMessageHelper.CreateMarshaller(BatchCreateAccessRightAccessPointGroupsRequest.Parser);

        static readonly Marshaller<BatchCreateAccessRightAccessPointGroupsResponse> __Marshaller_salto_nebula_accessright_v1_BatchCreateAccessRightAccessPointGroupsResponse = GrpcMessageHelper.CreateMarshaller(BatchCreateAccessRightAccessPointGroupsResponse.Parser);

        static readonly Marshaller<GetAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(GetAccessRightAccessPointGroupRequest.Parser);

        static readonly Marshaller<ListAccessRightAccessPointGroupsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointGroupsRequest = GrpcMessageHelper.CreateMarshaller(ListAccessRightAccessPointGroupsRequest.Parser);

        static readonly Marshaller<ListAccessRightAccessPointGroupsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightAccessPointGroupsResponse = GrpcMessageHelper.CreateMarshaller(ListAccessRightAccessPointGroupsResponse.Parser);

        static readonly Marshaller<UpdateAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(UpdateAccessRightAccessPointGroupRequest.Parser);

        static readonly Marshaller<DeleteAccessRightAccessPointGroupRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(DeleteAccessRightAccessPointGroupRequest.Parser);

        static readonly Marshaller<BatchDeleteAccessRightAccessPointGroupsRequest> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointGroupsRequest = GrpcMessageHelper.CreateMarshaller(BatchDeleteAccessRightAccessPointGroupsRequest.Parser);

        static readonly Marshaller<BatchDeleteAccessRightAccessPointGroupsResponse> __Marshaller_salto_nebula_accessright_v1_BatchDeleteAccessRightAccessPointGroupsResponse = GrpcMessageHelper.CreateMarshaller(BatchDeleteAccessRightAccessPointGroupsResponse.Parser);

        static readonly Marshaller<CreateAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_CreateAccessRightDestinationRequest = GrpcMessageHelper.CreateMarshaller(CreateAccessRightDestinationRequest.Parser);

        static readonly Marshaller<AccessRightDestination> __Marshaller_salto_nebula_accessright_v1_AccessRightDestination = GrpcMessageHelper.CreateMarshaller(AccessRightDestination.Parser);

        static readonly Marshaller<GetAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_GetAccessRightDestinationRequest = GrpcMessageHelper.CreateMarshaller(GetAccessRightDestinationRequest.Parser);

        static readonly Marshaller<ListAccessRightDestinationsRequest> __Marshaller_salto_nebula_accessright_v1_ListAccessRightDestinationsRequest = GrpcMessageHelper.CreateMarshaller(ListAccessRightDestinationsRequest.Parser);

        static readonly Marshaller<ListAccessRightDestinationsResponse> __Marshaller_salto_nebula_accessright_v1_ListAccessRightDestinationsResponse = GrpcMessageHelper.CreateMarshaller(ListAccessRightDestinationsResponse.Parser);

        static readonly Marshaller<UpdateAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_UpdateAccessRightDestinationRequest = GrpcMessageHelper.CreateMarshaller(UpdateAccessRightDestinationRequest.Parser);

        static readonly Marshaller<DeleteAccessRightDestinationRequest> __Marshaller_salto_nebula_accessright_v1_DeleteAccessRightDestinationRequest = GrpcMessageHelper.CreateMarshaller(DeleteAccessRightDestinationRequest.Parser);

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
            GrpcMessageHelper.EmptyMarshaller);

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
            GrpcMessageHelper.EmptyMarshaller);

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
            GrpcMessageHelper.EmptyMarshaller);

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
            GrpcMessageHelper.EmptyMarshaller);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.Services[0];}
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
            public virtual AsyncUnaryCall<AccessRight> CreateAccessRightAsync(CreateAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access right
            ///
            /// Creates a new access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> CreateAccessRightAsync(CreateAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateAccessRight, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRight> GetAccessRightAsync(GetAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access right
            ///
            /// Retrieves an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> GetAccessRightAsync(GetAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetAccessRight, null, options, request);
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
            public virtual AsyncUnaryCall<ListAccessRightsResponse> ListAccessRightsAsync(ListAccessRightsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRightsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access rights
            ///
            /// Returns a list of access rights that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightsResponse> ListAccessRightsAsync(ListAccessRightsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListAccessRights, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRight> UpdateAccessRightAsync(UpdateAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access right
            ///
            /// Updates an existing access right.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRight> UpdateAccessRightAsync(UpdateAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRight, null, options, request);
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
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAsync(DeleteAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access right
            ///
            /// Permanently deletes an access right. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAsync(DeleteAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRight, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightAccessPoint> CreateAccessRightAccessPointAsync(CreateAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access point
            ///
            /// Creates an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> CreateAccessRightAccessPointAsync(CreateAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateAccessRightAccessPoint, null, options, request);
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
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointsResponse> BatchCreateAccessRightAccessPointsAsync(BatchCreateAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchCreateAccessRightAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a batch of access rights access points
            ///
            /// Creates a batch of access rights access points associations.
            /// This method allows the creation of multiple access rights access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointsResponse> BatchCreateAccessRightAccessPointsAsync(BatchCreateAccessRightAccessPointsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchCreateAccessRightAccessPoints, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightAccessPoint> GetAccessRightAccessPointAsync(GetAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> GetAccessRightAccessPointAsync(GetAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetAccessRightAccessPoint, null, options, request);
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
            public virtual AsyncUnaryCall<ListAccessRightAccessPointsResponse> ListAccessRightAccessPointsAsync(ListAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRightAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access points
            ///
            /// Lists an existing access right's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightAccessPointsResponse> ListAccessRightAccessPointsAsync(ListAccessRightAccessPointsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListAccessRightAccessPoints, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightAccessPoint> UpdateAccessRightAccessPointAsync(UpdateAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPoint> UpdateAccessRightAccessPointAsync(UpdateAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRightAccessPoint, null, options, request);
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
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointAsync(DeleteAccessRightAccessPointRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRightAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access right's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointAsync(DeleteAccessRightAccessPointRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRightAccessPoint, null, options, request);
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
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointsResponse> BatchDeleteAccessRightAccessPointsAsync(BatchDeleteAccessRightAccessPointsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchDeleteAccessRightAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a batch of access points
            ///
            /// Permanently deletes a batch of access right's access point associations.
            /// This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointsResponse> BatchDeleteAccessRightAccessPointsAsync(BatchDeleteAccessRightAccessPointsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchDeleteAccessRightAccessPoints, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> CreateAccessRightAccessPointGroupAsync(CreateAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> CreateAccessRightAccessPointGroupAsync(CreateAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateAccessRightAccessPointGroup, null, options, request);
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
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointGroupsResponse> BatchCreateAccessRightAccessPointGroupsAsync(BatchCreateAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchCreateAccessRightAccessPointGroupsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a batch of access right's access point groups
            ///
            /// Creates a batch of access right's access point groups associations.
            /// This method allows the creation of multiple access right's access point groups in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessRightAccessPointGroupsResponse> BatchCreateAccessRightAccessPointGroupsAsync(BatchCreateAccessRightAccessPointGroupsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchCreateAccessRightAccessPointGroups, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> GetAccessRightAccessPointGroupAsync(GetAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access point group
            ///
            /// Retrieves an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> GetAccessRightAccessPointGroupAsync(GetAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetAccessRightAccessPointGroup, null, options, request);
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
            public virtual AsyncUnaryCall<ListAccessRightAccessPointGroupsResponse> ListAccessRightAccessPointGroupsAsync(ListAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRightAccessPointGroupsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access point groups
            ///
            /// Lists an existing access right's access point group associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightAccessPointGroupsResponse> ListAccessRightAccessPointGroupsAsync(ListAccessRightAccessPointGroupsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListAccessRightAccessPointGroups, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> UpdateAccessRightAccessPointGroupAsync(UpdateAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightAccessPointGroup> UpdateAccessRightAccessPointGroupAsync(UpdateAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRightAccessPointGroup, null, options, request);
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
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointGroupAsync(DeleteAccessRightAccessPointGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRightAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access point group
            ///
            /// Deletes an access right's access point group association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightAccessPointGroupAsync(DeleteAccessRightAccessPointGroupRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRightAccessPointGroup, null, options, request);
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
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointGroupsResponse> BatchDeleteAccessRightAccessPointGroupsAsync(BatchDeleteAccessRightAccessPointGroupsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchDeleteAccessRightAccessPointGroupsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a batch of access point groups
            ///
            /// Permanently deletes a batch access right's access point group associations. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessRightAccessPointGroupsResponse> BatchDeleteAccessRightAccessPointGroupsAsync(BatchDeleteAccessRightAccessPointGroupsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchDeleteAccessRightAccessPointGroups, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightDestination> CreateAccessRightDestinationAsync(CreateAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access right destination
            ///
            /// Creates an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> CreateAccessRightDestinationAsync(CreateAccessRightDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateAccessRightDestination, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightDestination> GetAccessRightDestinationAsync(GetAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access right destination
            ///
            /// Retrieves an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> GetAccessRightDestinationAsync(GetAccessRightDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetAccessRightDestination, null, options, request);
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
            public virtual AsyncUnaryCall<ListAccessRightDestinationsResponse> ListAccessRightDestinationsAsync(ListAccessRightDestinationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListAccessRightDestinationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access right destinations
            ///
            /// Lists an existing access right's destination associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessRightDestinationsResponse> ListAccessRightDestinationsAsync(ListAccessRightDestinationsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListAccessRightDestinations, null, options, request);
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
            public virtual AsyncUnaryCall<AccessRightDestination> UpdateAccessRightDestinationAsync(UpdateAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access right destination
            ///
            /// Updates an existing access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessRightDestination> UpdateAccessRightDestinationAsync(UpdateAccessRightDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateAccessRightDestination, null, options, request);
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
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightDestinationAsync(DeleteAccessRightDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteAccessRightDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access right destination
            ///
            /// Deletes an access right's destination association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessRightDestinationAsync(DeleteAccessRightDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteAccessRightDestination, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override AccessRightServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}