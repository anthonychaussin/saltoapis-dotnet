using Saltoapis.Nebula.AccessPoint.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.AccessPoint.V1.Response;

namespace Saltoapis.Nebula.AccessPoint.V1
{
    /// <summary>
    /// An access point is a smart electronic locking device capable of granting or
    /// denying access to a secured area. This service is responsible for managing
    /// access point resources.
    /// </summary>
    public static partial class AccessPointService
    {
        static readonly string __ServiceName = "salto.nebula.accesspoint.v1.AccessPointService";

        static readonly Marshaller<CreateAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_CreateAccessPointRequest = GrpcMessageHelper.CreateMarshaller(CreateAccessPointRequest.Parser);

        static readonly Marshaller<AccessPoint> __Marshaller_salto_nebula_accesspoint_v1_AccessPoint = GrpcMessageHelper.CreateMarshaller(AccessPoint.Parser);

        static readonly Marshaller<GetAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_GetAccessPointRequest = GrpcMessageHelper.CreateMarshaller(GetAccessPointRequest.Parser);

        static readonly Marshaller<ListAccessPointsRequest> __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsRequest = GrpcMessageHelper.CreateMarshaller(ListAccessPointsRequest.Parser);

        static readonly Marshaller<ListAccessPointsResponse> __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsResponse = GrpcMessageHelper.CreateMarshaller(ListAccessPointsResponse.Parser);

        static readonly Marshaller<UpdateAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_UpdateAccessPointRequest = GrpcMessageHelper.CreateMarshaller(UpdateAccessPointRequest.Parser);

        static readonly Marshaller<DeleteAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_DeleteAccessPointRequest = GrpcMessageHelper.CreateMarshaller(DeleteAccessPointRequest.Parser);

        static readonly Marshaller<UnlockAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_UnlockAccessPointRequest = GrpcMessageHelper.CreateMarshaller(UnlockAccessPointRequest.Parser);

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = GrpcMessageHelper.CreateMarshaller(Longrunning.V1.Operation.Parser);

        static readonly Marshaller<LockAccessPointRequest> __Marshaller_salto_nebula_accesspoint_v1_LockAccessPointRequest = GrpcMessageHelper.CreateMarshaller(LockAccessPointRequest.Parser);

        static readonly Method<CreateAccessPointRequest, AccessPoint> __Method_CreateAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "CreateAccessPoint",
            __Marshaller_salto_nebula_accesspoint_v1_CreateAccessPointRequest,
            __Marshaller_salto_nebula_accesspoint_v1_AccessPoint);

        static readonly Method<GetAccessPointRequest, AccessPoint> __Method_GetAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "GetAccessPoint",
            __Marshaller_salto_nebula_accesspoint_v1_GetAccessPointRequest,
            __Marshaller_salto_nebula_accesspoint_v1_AccessPoint);

        static readonly Method<ListAccessPointsRequest, ListAccessPointsResponse> __Method_ListAccessPoints = new(
            MethodType.Unary,
            __ServiceName,
            "ListAccessPoints",
            __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsRequest,
            __Marshaller_salto_nebula_accesspoint_v1_ListAccessPointsResponse);

        static readonly Method<UpdateAccessPointRequest, AccessPoint> __Method_UpdateAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateAccessPoint",
            __Marshaller_salto_nebula_accesspoint_v1_UpdateAccessPointRequest,
            __Marshaller_salto_nebula_accesspoint_v1_AccessPoint);

        static readonly Method<DeleteAccessPointRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteAccessPoint",
            __Marshaller_salto_nebula_accesspoint_v1_DeleteAccessPointRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<UnlockAccessPointRequest, Longrunning.V1.Operation> __Method_UnlockAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "UnlockAccessPoint",
            __Marshaller_salto_nebula_accesspoint_v1_UnlockAccessPointRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<LockAccessPointRequest, Longrunning.V1.Operation> __Method_LockAccessPoint = new(
            MethodType.Unary,
            __ServiceName,
            "LockAccessPoint",
            __Marshaller_salto_nebula_accesspoint_v1_LockAccessPointRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return AccessPointReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for AccessPointService</summary>
        public partial class AccessPointServiceClient : ClientBase<AccessPointServiceClient>
        {
            /// <summary>Creates a new client for AccessPointService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public AccessPointServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for AccessPointService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public AccessPointServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected AccessPointServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected AccessPointServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an access point
            ///
            /// Creates a new access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPoint CreateAccessPoint(CreateAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an access point
            ///
            /// Creates a new access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPoint CreateAccessPoint(CreateAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateAccessPoint, null, options, request);
            /// <summary>
            /// Create an access point
            ///
            /// Creates a new access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPoint> CreateAccessPointAsync(CreateAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an access point
            ///
            /// Creates a new access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPoint> CreateAccessPointAsync(CreateAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateAccessPoint, null, options, request);
            }

            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPoint GetAccessPoint(GetAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPoint GetAccessPoint(GetAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetAccessPoint, null, options, request);
            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPoint> GetAccessPointAsync(GetAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an access point
            ///
            /// Retrieves an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPoint> GetAccessPointAsync(GetAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetAccessPoint, null, options, request);
            }

            /// <summary>
            /// List access points
            ///
            /// Returns a list of access points that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessPointsResponse ListAccessPoints(ListAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListAccessPoints(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List access points
            ///
            /// Returns a list of access points that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListAccessPointsResponse ListAccessPoints(ListAccessPointsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListAccessPoints, null, options, request);
            /// <summary>
            /// List access points
            ///
            /// Returns a list of access points that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessPointsResponse> ListAccessPointsAsync(ListAccessPointsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListAccessPointsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List access points
            ///
            /// Returns a list of access points that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListAccessPointsResponse> ListAccessPointsAsync(ListAccessPointsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListAccessPoints, null, options, request);
            }

            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPoint UpdateAccessPoint(UpdateAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AccessPoint UpdateAccessPoint(UpdateAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateAccessPoint, null, options, request);
            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPoint> UpdateAccessPointAsync(UpdateAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an access point
            ///
            /// Updates an existing access point.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AccessPoint> UpdateAccessPointAsync(UpdateAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateAccessPoint, null, options, request);
            }

            /// <summary>
            /// Delete an access point
            ///
            /// Permanently deletes an access point. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessPoint(DeleteAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an access point
            ///
            /// Permanently deletes an access point. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteAccessPoint(DeleteAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteAccessPoint, null, options, request);
            /// <summary>
            /// Delete an access point
            ///
            /// Permanently deletes an access point. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessPointAsync(DeleteAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an access point
            ///
            /// Permanently deletes an access point. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteAccessPointAsync(DeleteAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteAccessPoint, null, options, request);
            }

            /// <summary>
            /// Unlock an access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UnlockAccessPoint(UnlockAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UnlockAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unlock an access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UnlockAccessPoint(UnlockAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnlockAccessPoint, null, options, request);
            /// <summary>
            /// Unlock an access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UnlockAccessPointAsync(UnlockAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UnlockAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Unlock an access point
            ///
            /// Remotely unlocks an access point. This can be run against those access
            /// points where their associated devices are online and connected.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UnlockAccessPointAsync(UnlockAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UnlockAccessPoint, null, options, request);
            }

            /// <summary>
            /// Lock an access point
            ///
            /// Remotely locks an access point. This can be run against those access
            /// points where their associated devices are online and connected. The lock
            /// device type can only be a motorized lock. Attempting to call this method
            /// on non-motorized locks will result in an INVALID_ARGUMENT error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation LockAccessPoint(LockAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => LockAccessPoint(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Lock an access point
            ///
            /// Remotely locks an access point. This can be run against those access
            /// points where their associated devices are online and connected. The lock
            /// device type can only be a motorized lock. Attempting to call this method
            /// on non-motorized locks will result in an INVALID_ARGUMENT error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation LockAccessPoint(LockAccessPointRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_LockAccessPoint, null, options, request);
            /// <summary>
            /// Lock an access point
            ///
            /// Remotely locks an access point. This can be run against those access
            /// points where their associated devices are online and connected. The lock
            /// device type can only be a motorized lock. Attempting to call this method
            /// on non-motorized locks will result in an INVALID_ARGUMENT error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> LockAccessPointAsync(LockAccessPointRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return LockAccessPointAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Lock an access point
            ///
            /// Remotely locks an access point. This can be run against those access
            /// points where their associated devices are online and connected. The lock
            /// device type can only be a motorized lock. Attempting to call this method
            /// on non-motorized locks will result in an INVALID_ARGUMENT error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> LockAccessPointAsync(LockAccessPointRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_LockAccessPoint, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override AccessPointServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}




