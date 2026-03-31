using Saltoapis.Nebula.AccessPointGroup.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.AccessPointGroup.V1.Response;

namespace Saltoapis.Nebula.AccessPointGroup.V1
{
    /// <summary>
    /// Access point group is a collection of access points that can be managed as a
    /// single entity. It is used to simplify the management of multiple access
    /// points by grouping them together and applying settings to all of them at
    /// once. It's also used to optimize the amount of data being used to store all
    /// access point identifiers by using only an access point group identifier.
    /// </summary>
    public static partial class AccessPointGroupService
    {
        static readonly string __ServiceName = "salto.nebula.accesspointgroup.v1.AccessPointGroupService";

        static readonly Marshaller<CreateAccessPointGroupRequest> __Marshaller_salto_nebula_accesspointgroup_v1_CreateAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(CreateAccessPointGroupRequest.Parser);

        static readonly Marshaller<AccessPointGroup> __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroup = GrpcMessageHelper.CreateMarshaller(AccessPointGroup.Parser);

        static readonly Marshaller<GetAccessPointGroupRequest> __Marshaller_salto_nebula_accesspointgroup_v1_GetAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(GetAccessPointGroupRequest.Parser);

        static readonly Marshaller<ListAccessPointGroupsRequest> __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupsRequest = GrpcMessageHelper.CreateMarshaller(ListAccessPointGroupsRequest.Parser);

        static readonly Marshaller<ListAccessPointGroupsResponse> __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupsResponse = GrpcMessageHelper.CreateMarshaller(ListAccessPointGroupsResponse.Parser);

        static readonly Marshaller<UpdateAccessPointGroupRequest> __Marshaller_salto_nebula_accesspointgroup_v1_UpdateAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(UpdateAccessPointGroupRequest.Parser);

        static readonly Marshaller<DeleteAccessPointGroupRequest> __Marshaller_salto_nebula_accesspointgroup_v1_DeleteAccessPointGroupRequest = GrpcMessageHelper.CreateMarshaller(DeleteAccessPointGroupRequest.Parser);

        static readonly Marshaller<CreateAccessPointGroupAccessPointRequest> __Marshaller_salto_nebula_accesspointgroup_v1_CreateAccessPointGroupAccessPointRequest = GrpcMessageHelper.CreateMarshaller(CreateAccessPointGroupAccessPointRequest.Parser);

        static readonly Marshaller<AccessPointGroupAccessPoint> __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroupAccessPoint = GrpcMessageHelper.CreateMarshaller(AccessPointGroupAccessPoint.Parser);

        static readonly Marshaller<BatchCreateAccessPointGroupAccessPointsRequest> __Marshaller_salto_nebula_accesspointgroup_v1_BatchCreateAccessPointGroupAccessPointsRequest = GrpcMessageHelper.CreateMarshaller(BatchCreateAccessPointGroupAccessPointsRequest.Parser);

        static readonly Marshaller<BatchCreateAccessPointGroupAccessPointsResponse> __Marshaller_salto_nebula_accesspointgroup_v1_BatchCreateAccessPointGroupAccessPointsResponse = GrpcMessageHelper.CreateMarshaller(BatchCreateAccessPointGroupAccessPointsResponse.Parser);

        static readonly Marshaller<GetAccessPointGroupAccessPointRequest> __Marshaller_salto_nebula_accesspointgroup_v1_GetAccessPointGroupAccessPointRequest = GrpcMessageHelper.CreateMarshaller(GetAccessPointGroupAccessPointRequest.Parser);

        static readonly Marshaller<ListAccessPointGroupAccessPointsRequest> __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupAccessPointsRequest = GrpcMessageHelper.CreateMarshaller(ListAccessPointGroupAccessPointsRequest.Parser);

        static readonly Marshaller<ListAccessPointGroupAccessPointsResponse> __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupAccessPointsResponse = GrpcMessageHelper.CreateMarshaller(ListAccessPointGroupAccessPointsResponse.Parser);

        static readonly Marshaller<UpdateAccessPointGroupAccessPointRequest> __Marshaller_salto_nebula_accesspointgroup_v1_UpdateAccessPointGroupAccessPointRequest = GrpcMessageHelper.CreateMarshaller(UpdateAccessPointGroupAccessPointRequest.Parser);

        static readonly Marshaller<DeleteAccessPointGroupAccessPointRequest> __Marshaller_salto_nebula_accesspointgroup_v1_DeleteAccessPointGroupAccessPointRequest = GrpcMessageHelper.CreateMarshaller(DeleteAccessPointGroupAccessPointRequest.Parser);

        static readonly Marshaller<BatchDeleteAccessPointGroupAccessPointsRequest> __Marshaller_salto_nebula_accesspointgroup_v1_BatchDeleteAccessPointGroupAccessPointsRequest = GrpcMessageHelper.CreateMarshaller(BatchDeleteAccessPointGroupAccessPointsRequest.Parser);

        static readonly Marshaller<BatchDeleteAccessPointGroupAccessPointsResponse> __Marshaller_salto_nebula_accesspointgroup_v1_BatchDeleteAccessPointGroupAccessPointsResponse = GrpcMessageHelper.CreateMarshaller(BatchDeleteAccessPointGroupAccessPointsResponse.Parser);

        static readonly Method<CreateAccessPointGroupRequest, AccessPointGroup> __Method_CreateAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "CreateAccessPointGroup",
            __Marshaller_salto_nebula_accesspointgroup_v1_CreateAccessPointGroupRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroup);

        static readonly Method<GetAccessPointGroupRequest, AccessPointGroup> __Method_GetAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "GetAccessPointGroup",
            __Marshaller_salto_nebula_accesspointgroup_v1_GetAccessPointGroupRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroup);

        static readonly Method<ListAccessPointGroupsRequest, ListAccessPointGroupsResponse> __Method_ListAccessPointGroups = new(
            MethodType.Unary,
            __ServiceName,
            "ListAccessPointGroups",
            __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupsRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupsResponse);

        static readonly Method<UpdateAccessPointGroupRequest, AccessPointGroup> __Method_UpdateAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateAccessPointGroup",
            __Marshaller_salto_nebula_accesspointgroup_v1_UpdateAccessPointGroupRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroup);

        static readonly Method<DeleteAccessPointGroupRequest, AccessPointGroup> __Method_DeleteAccessPointGroup = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteAccessPointGroup",
            __Marshaller_salto_nebula_accesspointgroup_v1_DeleteAccessPointGroupRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroup);

        static readonly Method<CreateAccessPointGroupAccessPointRequest, AccessPointGroupAccessPoint> __Method_CreateAccessPointGroupAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "CreateAccessPointGroupAccessPoint",
            __Marshaller_salto_nebula_accesspointgroup_v1_CreateAccessPointGroupAccessPointRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroupAccessPoint);

        static readonly Method<BatchCreateAccessPointGroupAccessPointsRequest, BatchCreateAccessPointGroupAccessPointsResponse> __Method_BatchCreateAccessPointGroupAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "BatchCreateAccessPointGroupAccessPoints",
            __Marshaller_salto_nebula_accesspointgroup_v1_BatchCreateAccessPointGroupAccessPointsRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_BatchCreateAccessPointGroupAccessPointsResponse);

        static readonly Method<GetAccessPointGroupAccessPointRequest, AccessPointGroupAccessPoint> __Method_GetAccessPointGroupAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "GetAccessPointGroupAccessPoint",
            __Marshaller_salto_nebula_accesspointgroup_v1_GetAccessPointGroupAccessPointRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroupAccessPoint);

        static readonly Method<ListAccessPointGroupAccessPointsRequest, ListAccessPointGroupAccessPointsResponse> __Method_ListAccessPointGroupAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "ListAccessPointGroupAccessPoints",
            __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupAccessPointsRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_ListAccessPointGroupAccessPointsResponse);

        static readonly Method<UpdateAccessPointGroupAccessPointRequest, AccessPointGroupAccessPoint> __Method_UpdateAccessPointGroupAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateAccessPointGroupAccessPoint",
            __Marshaller_salto_nebula_accesspointgroup_v1_UpdateAccessPointGroupAccessPointRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_AccessPointGroupAccessPoint);

        static readonly Method<DeleteAccessPointGroupAccessPointRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAccessPointGroupAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteAccessPointGroupAccessPoint",
            __Marshaller_salto_nebula_accesspointgroup_v1_DeleteAccessPointGroupAccessPointRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<BatchDeleteAccessPointGroupAccessPointsRequest, BatchDeleteAccessPointGroupAccessPointsResponse> __Method_BatchDeleteAccessPointGroupAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "BatchDeleteAccessPointGroupAccessPoints",
            __Marshaller_salto_nebula_accesspointgroup_v1_BatchDeleteAccessPointGroupAccessPointsRequest,
            __Marshaller_salto_nebula_accesspointgroup_v1_BatchDeleteAccessPointGroupAccessPointsResponse);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for AccessPointGroupService</summary>
        public partial class AccessPointGroupServiceClient : ClientBase<AccessPointGroupServiceClient>
        {
            /// <summary>Creates a new client for AccessPointGroupService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public AccessPointGroupServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for AccessPointGroupService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public AccessPointGroupServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected AccessPointGroupServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected AccessPointGroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup CreateAccessPointGroup(CreateAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup CreateAccessPointGroup(CreateAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateAccessPointGroup, null, options, request);
            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> CreateAccessPointGroupAsync(CreateAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an access point group
            ///
            /// Creates an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> CreateAccessPointGroupAsync(CreateAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// Get an access point group
            ///
            /// Gets an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup GetAccessPointGroup(GetAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access point group
            ///
            /// Gets an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup GetAccessPointGroup(GetAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetAccessPointGroup, null, options, request);
            /// <summary>
            /// Get an access point group
            ///
            /// Gets an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> GetAccessPointGroupAsync(GetAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an access point group
            ///
            /// Gets an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> GetAccessPointGroupAsync(GetAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// List access point groups
            ///
            /// Returns a list of access point groups that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessPointGroupsResponse ListAccessPointGroups(ListAccessPointGroupsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListAccessPointGroups(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access point groups
            ///
            /// Returns a list of access point groups that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessPointGroupsResponse ListAccessPointGroups(ListAccessPointGroupsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListAccessPointGroups, null, options, request);
            /// <summary>
            /// List access point groups
            ///
            /// Returns a list of access point groups that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessPointGroupsResponse> ListAccessPointGroupsAsync(ListAccessPointGroupsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListAccessPointGroupsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List access point groups
            ///
            /// Returns a list of access point groups that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessPointGroupsResponse> ListAccessPointGroupsAsync(ListAccessPointGroupsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListAccessPointGroups, null, options, request);
            }

            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup UpdateAccessPointGroup(UpdateAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup UpdateAccessPointGroup(UpdateAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateAccessPointGroup, null, options, request);
            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> UpdateAccessPointGroupAsync(UpdateAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an access point group
            ///
            /// Updates an existing access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> UpdateAccessPointGroupAsync(UpdateAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// Delete an access point group
            ///
            /// Soft deletes an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup DeleteAccessPointGroup(DeleteAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteAccessPointGroup(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access point group
            ///
            /// Soft deletes an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroup DeleteAccessPointGroup(DeleteAccessPointGroupRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteAccessPointGroup, null, options, request);
            /// <summary>
            /// Delete an access point group
            ///
            /// Soft deletes an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> DeleteAccessPointGroupAsync(DeleteAccessPointGroupRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteAccessPointGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an access point group
            ///
            /// Soft deletes an access point group.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroup> DeleteAccessPointGroupAsync(DeleteAccessPointGroupRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessPointGroup, null, options, request);
            }

            /// <summary>
            /// Create an access point
            ///
            /// Creates an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroupAccessPoint CreateAccessPointGroupAccessPoint(CreateAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateAccessPointGroupAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access point
            ///
            /// Creates an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroupAccessPoint CreateAccessPointGroupAccessPoint(CreateAccessPointGroupAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateAccessPointGroupAccessPoint, null, options, request);
            /// <summary>
            /// Create an access point
            ///
            /// Creates an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroupAccessPoint> CreateAccessPointGroupAccessPointAsync(CreateAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateAccessPointGroupAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an access point
            ///
            /// Creates an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroupAccessPoint> CreateAccessPointGroupAccessPointAsync(CreateAccessPointGroupAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateAccessPointGroupAccessPoint, null, options, request);
            }

            /// <summary>
            /// Create a batch of access point group access points
            ///
            /// Creates a batch of access point group's access points association.
            /// This method allows the creation of multiple access point group's access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateAccessPointGroupAccessPointsResponse BatchCreateAccessPointGroupAccessPoints(BatchCreateAccessPointGroupAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => BatchCreateAccessPointGroupAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a batch of access point group access points
            ///
            /// Creates a batch of access point group's access points association.
            /// This method allows the creation of multiple access point group's access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateAccessPointGroupAccessPointsResponse BatchCreateAccessPointGroupAccessPoints(BatchCreateAccessPointGroupAccessPointsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchCreateAccessPointGroupAccessPoints, null, options, request);
            /// <summary>
            /// Create a batch of access point group access points
            ///
            /// Creates a batch of access point group's access points association.
            /// This method allows the creation of multiple access point group's access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessPointGroupAccessPointsResponse> BatchCreateAccessPointGroupAccessPointsAsync(BatchCreateAccessPointGroupAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return BatchCreateAccessPointGroupAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a batch of access point group access points
            ///
            /// Creates a batch of access point group's access points association.
            /// This method allows the creation of multiple access point group's access points in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateAccessPointGroupAccessPointsResponse> BatchCreateAccessPointGroupAccessPointsAsync(BatchCreateAccessPointGroupAccessPointsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BatchCreateAccessPointGroupAccessPoints, null, options, request);
            }

            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroupAccessPoint GetAccessPointGroupAccessPoint(GetAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetAccessPointGroupAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroupAccessPoint GetAccessPointGroupAccessPoint(GetAccessPointGroupAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetAccessPointGroupAccessPoint, null, options, request);
            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroupAccessPoint> GetAccessPointGroupAccessPointAsync(GetAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetAccessPointGroupAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroupAccessPoint> GetAccessPointGroupAccessPointAsync(GetAccessPointGroupAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetAccessPointGroupAccessPoint, null, options, request);
            }

            /// <summary>
            /// List access points
            ///
            /// Lists an existing access point group's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessPointGroupAccessPointsResponse ListAccessPointGroupAccessPoints(ListAccessPointGroupAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListAccessPointGroupAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access points
            ///
            /// Lists an existing access point group's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessPointGroupAccessPointsResponse ListAccessPointGroupAccessPoints(ListAccessPointGroupAccessPointsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListAccessPointGroupAccessPoints, null, options, request);
            /// <summary>
            /// List access points
            ///
            /// Lists an existing access point group's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessPointGroupAccessPointsResponse> ListAccessPointGroupAccessPointsAsync(ListAccessPointGroupAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListAccessPointGroupAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List access points
            ///
            /// Lists an existing access point group's access point associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessPointGroupAccessPointsResponse> ListAccessPointGroupAccessPointsAsync(ListAccessPointGroupAccessPointsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListAccessPointGroupAccessPoints, null, options, request);
            }

            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroupAccessPoint UpdateAccessPointGroupAccessPoint(UpdateAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateAccessPointGroupAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPointGroupAccessPoint UpdateAccessPointGroupAccessPoint(UpdateAccessPointGroupAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateAccessPointGroupAccessPoint, null, options, request);
            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroupAccessPoint> UpdateAccessPointGroupAccessPointAsync(UpdateAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateAccessPointGroupAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPointGroupAccessPoint> UpdateAccessPointGroupAccessPointAsync(UpdateAccessPointGroupAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessPointGroupAccessPoint, null, options, request);
            }

            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessPointGroupAccessPoint(DeleteAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteAccessPointGroupAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessPointGroupAccessPoint(DeleteAccessPointGroupAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteAccessPointGroupAccessPoint, null, options, request);
            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessPointGroupAccessPointAsync(DeleteAccessPointGroupAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteAccessPointGroupAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an access point
            ///
            /// Deletes an access point group's access point association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessPointGroupAccessPointAsync(DeleteAccessPointGroupAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessPointGroupAccessPoint, null, options, request);
            }

            /// <summary>
            /// Delete a batch of access point group access point associations
            ///
            /// Deletes a batch of access point group access point associations. This method allows the
            /// deletion of multiple access point group access points in a single operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteAccessPointGroupAccessPointsResponse BatchDeleteAccessPointGroupAccessPoints(BatchDeleteAccessPointGroupAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => BatchDeleteAccessPointGroupAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a batch of access point group access point associations
            ///
            /// Deletes a batch of access point group access point associations. This method allows the
            /// deletion of multiple access point group access points in a single operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteAccessPointGroupAccessPointsResponse BatchDeleteAccessPointGroupAccessPoints(BatchDeleteAccessPointGroupAccessPointsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchDeleteAccessPointGroupAccessPoints, null, options, request);
            /// <summary>
            /// Delete a batch of access point group access point associations
            ///
            /// Deletes a batch of access point group access point associations. This method allows the
            /// deletion of multiple access point group access points in a single operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessPointGroupAccessPointsResponse> BatchDeleteAccessPointGroupAccessPointsAsync(BatchDeleteAccessPointGroupAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return BatchDeleteAccessPointGroupAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a batch of access point group access point associations
            ///
            /// Deletes a batch of access point group access point associations. This method allows the
            /// deletion of multiple access point group access points in a single operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteAccessPointGroupAccessPointsResponse> BatchDeleteAccessPointGroupAccessPointsAsync(BatchDeleteAccessPointGroupAccessPointsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BatchDeleteAccessPointGroupAccessPoints, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override AccessPointGroupServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}




