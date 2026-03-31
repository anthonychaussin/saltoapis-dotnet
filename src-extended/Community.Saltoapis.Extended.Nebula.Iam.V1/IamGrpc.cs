using Saltoapis.Nebula.Iam.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.Iam.V1.Response;

namespace Saltoapis.Nebula.Iam.V1
{
    /// <summary>
    /// Identity and Access Management (IAM) is a service that allows you to securely
    /// control user access to specific resources. IAM gives you full control and
    /// visibility to manage resources centrally. You grant roles to users by
    /// creating an IAM policy which is a collection of permissions that define who
    /// has what type of access.
    /// </summary>
    public static partial class IAMService
    {
        static readonly string __ServiceName = "salto.nebula.iam.v1.IAMService";

        static readonly Marshaller<GetRoleRequest> __Marshaller_salto_nebula_iam_v1_GetRoleRequest = GrpcMessageHelper.CreateMarshaller(GetRoleRequest.Parser);

        static readonly Marshaller<Role> __Marshaller_salto_nebula_iam_v1_Role = GrpcMessageHelper.CreateMarshaller(Role.Parser);

        static readonly Marshaller<ListRolesRequest> __Marshaller_salto_nebula_iam_v1_ListRolesRequest = GrpcMessageHelper.CreateMarshaller(ListRolesRequest.Parser);

        static readonly Marshaller<ListRolesResponse> __Marshaller_salto_nebula_iam_v1_ListRolesResponse = GrpcMessageHelper.CreateMarshaller(ListRolesResponse.Parser);

        static readonly Method<GetRoleRequest, Role> __Method_GetRole = new(
            MethodType.Unary,
            __ServiceName,
            "GetRole",
            __Marshaller_salto_nebula_iam_v1_GetRoleRequest,
            __Marshaller_salto_nebula_iam_v1_Role);

        static readonly Method<ListRolesRequest, ListRolesResponse> __Method_ListRoles = new(
            MethodType.Unary,
            __ServiceName,
            "ListRoles",
            __Marshaller_salto_nebula_iam_v1_ListRolesRequest,
            __Marshaller_salto_nebula_iam_v1_ListRolesResponse);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => IamReflection.Descriptor.Services[0];}
        /// <summary>Client for IAMService</summary>
        public partial class IAMServiceClient : ClientBase<IAMServiceClient>
        {
            /// <summary>Creates a new client for IAMService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public IAMServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for IAMService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public IAMServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected IAMServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected IAMServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Get a role
            ///
            /// Gets an existing role.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Role GetRole(GetRoleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetRole(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a role
            ///
            /// Gets an existing role.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Role GetRole(GetRoleRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetRole, null, options, request);
            /// <summary>
            /// Get a role
            ///
            /// Gets an existing role.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Role> GetRoleAsync(GetRoleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetRoleAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a role
            ///
            /// Gets an existing role.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Role> GetRoleAsync(GetRoleRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetRole, null, options, request);
            /// <summary>
            /// List roles
            ///
            /// Returns a list of roles that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListRolesResponse ListRoles(ListRolesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListRoles(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List roles
            ///
            /// Returns a list of roles that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListRolesResponse ListRoles(ListRolesRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListRoles, null, options, request);
            /// <summary>
            /// List roles
            ///
            /// Returns a list of roles that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListRolesResponse> ListRolesAsync(ListRolesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListRolesAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List roles
            ///
            /// Returns a list of roles that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListRolesResponse> ListRolesAsync(ListRolesRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListRoles, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override IAMServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}