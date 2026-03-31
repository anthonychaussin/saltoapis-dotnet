using Saltoapis.Nebula.User.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.User.V1.Response;

namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// A user can refer to both a holder of keys and a user with permissions to
    /// manage other users. Users are eligible to access rights and may be assigned a
    /// key. This service is responsible for managing user resources as well as
    /// their associations with access rights.
    /// </summary>
    public static partial class UserService
    {
        static readonly string __ServiceName = "salto.nebula.user.v1.UserService";

        static readonly Marshaller<CreateUserRequest> __Marshaller_salto_nebula_user_v1_CreateUserRequest = GrpcMessageHelper.CreateMarshaller(CreateUserRequest.Parser);

        static readonly Marshaller<User> __Marshaller_salto_nebula_user_v1_User = GrpcMessageHelper.CreateMarshaller(User.Parser);

        static readonly Marshaller<GetUserRequest> __Marshaller_salto_nebula_user_v1_GetUserRequest = GrpcMessageHelper.CreateMarshaller(GetUserRequest.Parser);

        static readonly Marshaller<BatchGetUsersRequest> __Marshaller_salto_nebula_user_v1_BatchGetUsersRequest = GrpcMessageHelper.CreateMarshaller(BatchGetUsersRequest.Parser);

        static readonly Marshaller<BatchGetUsersResponse> __Marshaller_salto_nebula_user_v1_BatchGetUsersResponse = GrpcMessageHelper.CreateMarshaller(BatchGetUsersResponse.Parser);

        static readonly Marshaller<ListUsersRequest> __Marshaller_salto_nebula_user_v1_ListUsersRequest = GrpcMessageHelper.CreateMarshaller(ListUsersRequest.Parser);

        static readonly Marshaller<ListUsersResponse> __Marshaller_salto_nebula_user_v1_ListUsersResponse = GrpcMessageHelper.CreateMarshaller(ListUsersResponse.Parser);

        static readonly Marshaller<UpdateUserRequest> __Marshaller_salto_nebula_user_v1_UpdateUserRequest = GrpcMessageHelper.CreateMarshaller(UpdateUserRequest.Parser);

        static readonly Marshaller<DeleteUserRequest> __Marshaller_salto_nebula_user_v1_DeleteUserRequest = GrpcMessageHelper.CreateMarshaller(DeleteUserRequest.Parser);

        static readonly Marshaller<BlockUserRequest> __Marshaller_salto_nebula_user_v1_BlockUserRequest = GrpcMessageHelper.CreateMarshaller(BlockUserRequest.Parser);

        static readonly Marshaller<BlockUserResponse> __Marshaller_salto_nebula_user_v1_BlockUserResponse = GrpcMessageHelper.CreateMarshaller(BlockUserResponse.Parser);

        static readonly Marshaller<UnblockUserRequest> __Marshaller_salto_nebula_user_v1_UnblockUserRequest = GrpcMessageHelper.CreateMarshaller(UnblockUserRequest.Parser);

        static readonly Marshaller<UnblockUserResponse> __Marshaller_salto_nebula_user_v1_UnblockUserResponse = GrpcMessageHelper.CreateMarshaller(UnblockUserResponse.Parser);

        static readonly Marshaller<CreateUserAccessRightRequest> __Marshaller_salto_nebula_user_v1_CreateUserAccessRightRequest = GrpcMessageHelper.CreateMarshaller(CreateUserAccessRightRequest.Parser);

        static readonly Marshaller<UserAccessRight> __Marshaller_salto_nebula_user_v1_UserAccessRight = GrpcMessageHelper.CreateMarshaller(UserAccessRight.Parser);

        static readonly Marshaller<GetUserAccessRightRequest> __Marshaller_salto_nebula_user_v1_GetUserAccessRightRequest = GrpcMessageHelper.CreateMarshaller(GetUserAccessRightRequest.Parser);

        static readonly Marshaller<ListUserAccessRightsRequest> __Marshaller_salto_nebula_user_v1_ListUserAccessRightsRequest = GrpcMessageHelper.CreateMarshaller(ListUserAccessRightsRequest.Parser);

        static readonly Marshaller<ListUserAccessRightsResponse> __Marshaller_salto_nebula_user_v1_ListUserAccessRightsResponse = GrpcMessageHelper.CreateMarshaller(ListUserAccessRightsResponse.Parser);

        static readonly Marshaller<UpdateUserAccessRightRequest> __Marshaller_salto_nebula_user_v1_UpdateUserAccessRightRequest = GrpcMessageHelper.CreateMarshaller(UpdateUserAccessRightRequest.Parser);

        static readonly Marshaller<DeleteUserAccessRightRequest> __Marshaller_salto_nebula_user_v1_DeleteUserAccessRightRequest = GrpcMessageHelper.CreateMarshaller(DeleteUserAccessRightRequest.Parser);

        static readonly Marshaller<AssignCardKeyRequest> __Marshaller_salto_nebula_user_v1_AssignCardKeyRequest = GrpcMessageHelper.CreateMarshaller(AssignCardKeyRequest.Parser);

        static readonly Marshaller<CardKey> __Marshaller_salto_nebula_user_v1_CardKey = GrpcMessageHelper.CreateMarshaller(CardKey.Parser);

        static readonly Marshaller<CancelCardKeyRequest> __Marshaller_salto_nebula_user_v1_CancelCardKeyRequest = GrpcMessageHelper.CreateMarshaller(CancelCardKeyRequest.Parser);

        static readonly Marshaller<EncodeCardKeyRequest> __Marshaller_salto_nebula_user_v1_EncodeCardKeyRequest = GrpcMessageHelper.CreateMarshaller(EncodeCardKeyRequest.Parser);

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = GrpcMessageHelper.CreateMarshaller(Longrunning.V1.Operation.Parser);

        static readonly Marshaller<AssignAppKeyRequest> __Marshaller_salto_nebula_user_v1_AssignAppKeyRequest = GrpcMessageHelper.CreateMarshaller(AssignAppKeyRequest.Parser);

        static readonly Marshaller<AppKey> __Marshaller_salto_nebula_user_v1_AppKey = GrpcMessageHelper.CreateMarshaller(AppKey.Parser);

        static readonly Marshaller<CancelAppKeyRequest> __Marshaller_salto_nebula_user_v1_CancelAppKeyRequest = GrpcMessageHelper.CreateMarshaller(CancelAppKeyRequest.Parser);

        static readonly Marshaller<ComputeAppKeyDataRequest> __Marshaller_salto_nebula_user_v1_ComputeAppKeyDataRequest = GrpcMessageHelper.CreateMarshaller(ComputeAppKeyDataRequest.Parser);

        static readonly Marshaller<ComputeAppKeyDataResponse> __Marshaller_salto_nebula_user_v1_ComputeAppKeyDataResponse = GrpcMessageHelper.CreateMarshaller(ComputeAppKeyDataResponse.Parser);

        static readonly Marshaller<AssignWalletKeyRequest> __Marshaller_salto_nebula_user_v1_AssignWalletKeyRequest = GrpcMessageHelper.CreateMarshaller(AssignWalletKeyRequest.Parser);

        static readonly Marshaller<AssignWalletKeyResponse> __Marshaller_salto_nebula_user_v1_AssignWalletKeyResponse = GrpcMessageHelper.CreateMarshaller(AssignWalletKeyResponse.Parser);

        static readonly Marshaller<CancelWalletKeyRequest> __Marshaller_salto_nebula_user_v1_CancelWalletKeyRequest = GrpcMessageHelper.CreateMarshaller(CancelWalletKeyRequest.Parser);

        static readonly Marshaller<CancelWalletKeyResponse> __Marshaller_salto_nebula_user_v1_CancelWalletKeyResponse = GrpcMessageHelper.CreateMarshaller(CancelWalletKeyResponse.Parser);

        static readonly Marshaller<AssignPasscodeRequest> __Marshaller_salto_nebula_user_v1_AssignPasscodeRequest = GrpcMessageHelper.CreateMarshaller(AssignPasscodeRequest.Parser);

        static readonly Marshaller<AssignPasscodeResponse> __Marshaller_salto_nebula_user_v1_AssignPasscodeResponse = GrpcMessageHelper.CreateMarshaller(AssignPasscodeResponse.Parser);

        static readonly Marshaller<CancelPasscodeRequest> __Marshaller_salto_nebula_user_v1_CancelPasscodeRequest = GrpcMessageHelper.CreateMarshaller(CancelPasscodeRequest.Parser);

        static readonly Marshaller<CancelPasscodeResponse> __Marshaller_salto_nebula_user_v1_CancelPasscodeResponse = GrpcMessageHelper.CreateMarshaller(CancelPasscodeResponse.Parser);

        static readonly Marshaller<AssignElectronicKeyRequest> __Marshaller_salto_nebula_user_v1_AssignElectronicKeyRequest = GrpcMessageHelper.CreateMarshaller(AssignElectronicKeyRequest.Parser);

        static readonly Marshaller<AssignElectronicKeyResponse> __Marshaller_salto_nebula_user_v1_AssignElectronicKeyResponse = GrpcMessageHelper.CreateMarshaller(AssignElectronicKeyResponse.Parser);

        static readonly Marshaller<CancelElectronicKeyRequest> __Marshaller_salto_nebula_user_v1_CancelElectronicKeyRequest = GrpcMessageHelper.CreateMarshaller(CancelElectronicKeyRequest.Parser);

        static readonly Marshaller<CancelElectronicKeyResponse> __Marshaller_salto_nebula_user_v1_CancelElectronicKeyResponse = GrpcMessageHelper.CreateMarshaller(CancelElectronicKeyResponse.Parser);

        static readonly Marshaller<EncodeElectronicKeyRequest> __Marshaller_salto_nebula_user_v1_EncodeElectronicKeyRequest = GrpcMessageHelper.CreateMarshaller(EncodeElectronicKeyRequest.Parser);

        static readonly Method<CreateUserRequest, User> __Method_CreateUser = new(
            MethodType.Unary,
            __ServiceName,
            "CreateUser",
            __Marshaller_salto_nebula_user_v1_CreateUserRequest,
            __Marshaller_salto_nebula_user_v1_User);

        static readonly Method<GetUserRequest, User> __Method_GetUser = new(
            MethodType.Unary,
            __ServiceName,
            "GetUser",
            __Marshaller_salto_nebula_user_v1_GetUserRequest,
            __Marshaller_salto_nebula_user_v1_User);

        static readonly Method<BatchGetUsersRequest, BatchGetUsersResponse> __Method_BatchGetUsers = new(
            MethodType.Unary,
            __ServiceName,
            "BatchGetUsers",
            __Marshaller_salto_nebula_user_v1_BatchGetUsersRequest,
            __Marshaller_salto_nebula_user_v1_BatchGetUsersResponse);

        static readonly Method<ListUsersRequest, ListUsersResponse> __Method_ListUsers = new(
            MethodType.Unary,
            __ServiceName,
            "ListUsers",
            __Marshaller_salto_nebula_user_v1_ListUsersRequest,
            __Marshaller_salto_nebula_user_v1_ListUsersResponse);

        static readonly Method<UpdateUserRequest, User> __Method_UpdateUser = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateUser",
            __Marshaller_salto_nebula_user_v1_UpdateUserRequest,
            __Marshaller_salto_nebula_user_v1_User);

        static readonly Method<DeleteUserRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteUser = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteUser",
            __Marshaller_salto_nebula_user_v1_DeleteUserRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<BlockUserRequest, BlockUserResponse> __Method_BlockUser = new(
            MethodType.Unary,
            __ServiceName,
            "BlockUser",
            __Marshaller_salto_nebula_user_v1_BlockUserRequest,
            __Marshaller_salto_nebula_user_v1_BlockUserResponse);

        static readonly Method<UnblockUserRequest, UnblockUserResponse> __Method_UnblockUser = new(
            MethodType.Unary,
            __ServiceName,
            "UnblockUser",
            __Marshaller_salto_nebula_user_v1_UnblockUserRequest,
            __Marshaller_salto_nebula_user_v1_UnblockUserResponse);

        static readonly Method<CreateUserAccessRightRequest, UserAccessRight> __Method_CreateUserAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "CreateUserAccessRight",
            __Marshaller_salto_nebula_user_v1_CreateUserAccessRightRequest,
            __Marshaller_salto_nebula_user_v1_UserAccessRight);

        static readonly Method<GetUserAccessRightRequest, UserAccessRight> __Method_GetUserAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "GetUserAccessRight",
            __Marshaller_salto_nebula_user_v1_GetUserAccessRightRequest,
            __Marshaller_salto_nebula_user_v1_UserAccessRight);

        static readonly Method<ListUserAccessRightsRequest, ListUserAccessRightsResponse> __Method_ListUserAccessRights = new(
            MethodType.Unary,
            __ServiceName,
            "ListUserAccessRights",
            __Marshaller_salto_nebula_user_v1_ListUserAccessRightsRequest,
            __Marshaller_salto_nebula_user_v1_ListUserAccessRightsResponse);

        static readonly Method<UpdateUserAccessRightRequest, UserAccessRight> __Method_UpdateUserAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateUserAccessRight",
            __Marshaller_salto_nebula_user_v1_UpdateUserAccessRightRequest,
            __Marshaller_salto_nebula_user_v1_UserAccessRight);

        static readonly Method<DeleteUserAccessRightRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteUserAccessRight = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteUserAccessRight",
            __Marshaller_salto_nebula_user_v1_DeleteUserAccessRightRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<AssignCardKeyRequest, CardKey> __Method_AssignCardKey = new(
            MethodType.Unary,
            __ServiceName,
            "AssignCardKey",
            __Marshaller_salto_nebula_user_v1_AssignCardKeyRequest,
            __Marshaller_salto_nebula_user_v1_CardKey);

        static readonly Method<CancelCardKeyRequest, CardKey> __Method_CancelCardKey = new(
            MethodType.Unary,
            __ServiceName,
            "CancelCardKey",
            __Marshaller_salto_nebula_user_v1_CancelCardKeyRequest,
            __Marshaller_salto_nebula_user_v1_CardKey);

        static readonly Method<EncodeCardKeyRequest, Longrunning.V1.Operation> __Method_EncodeCardKey = new(
            MethodType.Unary,
            __ServiceName,
            "EncodeCardKey",
            __Marshaller_salto_nebula_user_v1_EncodeCardKeyRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<AssignAppKeyRequest, AppKey> __Method_AssignAppKey = new(
            MethodType.Unary,
            __ServiceName,
            "AssignAppKey",
            __Marshaller_salto_nebula_user_v1_AssignAppKeyRequest,
            __Marshaller_salto_nebula_user_v1_AppKey);

        static readonly Method<CancelAppKeyRequest, AppKey> __Method_CancelAppKey = new(
            MethodType.Unary,
            __ServiceName,
            "CancelAppKey",
            __Marshaller_salto_nebula_user_v1_CancelAppKeyRequest,
            __Marshaller_salto_nebula_user_v1_AppKey);

        static readonly Method<ComputeAppKeyDataRequest, ComputeAppKeyDataResponse> __Method_ComputeAppKeyData = new(
            MethodType.Unary,
            __ServiceName,
            "ComputeAppKeyData",
            __Marshaller_salto_nebula_user_v1_ComputeAppKeyDataRequest,
            __Marshaller_salto_nebula_user_v1_ComputeAppKeyDataResponse);

        static readonly Method<AssignWalletKeyRequest, AssignWalletKeyResponse> __Method_AssignWalletKey = new(
            MethodType.Unary,
            __ServiceName,
            "AssignWalletKey",
            __Marshaller_salto_nebula_user_v1_AssignWalletKeyRequest,
            __Marshaller_salto_nebula_user_v1_AssignWalletKeyResponse);

        static readonly Method<CancelWalletKeyRequest, CancelWalletKeyResponse> __Method_CancelWalletKey = new(
            MethodType.Unary,
            __ServiceName,
            "CancelWalletKey",
            __Marshaller_salto_nebula_user_v1_CancelWalletKeyRequest,
            __Marshaller_salto_nebula_user_v1_CancelWalletKeyResponse);

        static readonly Method<AssignPasscodeRequest, AssignPasscodeResponse> __Method_AssignPasscode = new(
            MethodType.Unary,
            __ServiceName,
            "AssignPasscode",
            __Marshaller_salto_nebula_user_v1_AssignPasscodeRequest,
            __Marshaller_salto_nebula_user_v1_AssignPasscodeResponse);

        static readonly Method<CancelPasscodeRequest, CancelPasscodeResponse> __Method_CancelPasscode = new(
            MethodType.Unary,
            __ServiceName,
            "CancelPasscode",
            __Marshaller_salto_nebula_user_v1_CancelPasscodeRequest,
            __Marshaller_salto_nebula_user_v1_CancelPasscodeResponse);

        static readonly Method<AssignElectronicKeyRequest, AssignElectronicKeyResponse> __Method_AssignElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "AssignElectronicKey",
            __Marshaller_salto_nebula_user_v1_AssignElectronicKeyRequest,
            __Marshaller_salto_nebula_user_v1_AssignElectronicKeyResponse);

        static readonly Method<CancelElectronicKeyRequest, CancelElectronicKeyResponse> __Method_CancelElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "CancelElectronicKey",
            __Marshaller_salto_nebula_user_v1_CancelElectronicKeyRequest,
            __Marshaller_salto_nebula_user_v1_CancelElectronicKeyResponse);

        static readonly Method<EncodeElectronicKeyRequest, Longrunning.V1.Operation> __Method_EncodeElectronicKey = new(
            MethodType.Unary,
            __ServiceName,
            "EncodeElectronicKey",
            __Marshaller_salto_nebula_user_v1_EncodeElectronicKeyRequest,
            __Marshaller_salto_longrunning_v1_Operation);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.Services[0]; }
        }
        /// <summary>Client for UserService</summary>
        public partial class UserServiceClient : ClientBase<UserServiceClient>
        {
            /// <summary>Creates a new client for UserService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public UserServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for UserService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public UserServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected UserServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected UserServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Create a user
            ///
            /// Creates a new user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual User CreateUser(CreateUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a user
            ///
            /// Creates a new user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual User CreateUser(CreateUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateUser, null, options, request);
            /// <summary>
            /// Create a user
            ///
            /// Creates a new user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<User> CreateUserAsync(CreateUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a user
            ///
            /// Creates a new user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<User> CreateUserAsync(CreateUserRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateUser, null, options, request);
            /// <summary>
            /// Get a user
            ///
            /// Retrieves an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual User GetUser(GetUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a user
            ///
            /// Retrieves an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual User GetUser(GetUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetUser, null, options, request);
            /// <summary>
            /// Get a user
            ///
            /// Retrieves an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<User> GetUserAsync(GetUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a user
            ///
            /// Retrieves an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<User> GetUserAsync(GetUserRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetUser, null, options, request);
            /// <summary>
            /// Get a batch of users
            ///
            /// Retrieves a batch of existing users.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchGetUsersResponse BatchGetUsers(BatchGetUsersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchGetUsers(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a batch of users
            ///
            /// Retrieves a batch of existing users.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchGetUsersResponse BatchGetUsers(BatchGetUsersRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchGetUsers, null, options, request);
            /// <summary>
            /// Get a batch of users
            ///
            /// Retrieves a batch of existing users.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchGetUsersResponse> BatchGetUsersAsync(BatchGetUsersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchGetUsersAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a batch of users
            ///
            /// Retrieves a batch of existing users.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchGetUsersResponse> BatchGetUsersAsync(BatchGetUsersRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchGetUsers, null, options, request);
            /// <summary>
            /// List users
            ///
            /// Returns a list of users that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListUsersResponse ListUsers(ListUsersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListUsers(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List users
            ///
            /// Returns a list of users that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListUsersResponse ListUsers(ListUsersRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListUsers, null, options, request);
            /// <summary>
            /// List users
            ///
            /// Returns a list of users that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListUsersResponse> ListUsersAsync(ListUsersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListUsersAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List users
            ///
            /// Returns a list of users that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListUsers, null, options, request);
            /// <summary>
            /// Update a user
            ///
            /// Updates an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual User UpdateUser(UpdateUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a user
            ///
            /// Updates an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual User UpdateUser(UpdateUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateUser, null, options, request);
            /// <summary>
            /// Update a user
            ///
            /// Updates an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<User> UpdateUserAsync(UpdateUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a user
            ///
            /// Updates an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<User> UpdateUserAsync(UpdateUserRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateUser, null, options, request);
            /// <summary>
            /// Delete a user
            ///
            /// Permanently deletes a user. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteUser(DeleteUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a user
            ///
            /// Permanently deletes a user. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteUser(DeleteUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteUser, null, options, request);
            /// <summary>
            /// Delete a user
            ///
            /// Permanently deletes a user. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteUserAsync(DeleteUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a user
            ///
            /// Permanently deletes a user. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteUserAsync(DeleteUserRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteUser, null, options, request);
            /// <summary>
            /// Block a user
            ///
            /// Temporarily blocks an existing user. While blocked, the user cannot
            /// perform any admin actions, that is, they have no management role.
            /// Neither can they unlock any access point with any type of key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BlockUserResponse BlockUser(BlockUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BlockUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Block a user
            ///
            /// Temporarily blocks an existing user. While blocked, the user cannot
            /// perform any admin actions, that is, they have no management role.
            /// Neither can they unlock any access point with any type of key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BlockUserResponse BlockUser(BlockUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BlockUser, null, options, request);
            /// <summary>
            /// Block a user
            ///
            /// Temporarily blocks an existing user. While blocked, the user cannot
            /// perform any admin actions, that is, they have no management role.
            /// Neither can they unlock any access point with any type of key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BlockUserResponse> BlockUserAsync(BlockUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BlockUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Block a user
            ///
            /// Temporarily blocks an existing user. While blocked, the user cannot
            /// perform any admin actions, that is, they have no management role.
            /// Neither can they unlock any access point with any type of key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BlockUserResponse> BlockUserAsync(BlockUserRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BlockUser, null, options, request);
            /// <summary>
            /// Unblock a user
            ///
            /// Unblocks an already blocked user. Once unblocked, the user can
            /// perform the admin actions they could previously, that is,
            /// they once again have a management role.
            /// They can also once again unlock the access points they previously
            /// had access to.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnblockUserResponse UnblockUser(UnblockUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UnblockUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unblock a user
            ///
            /// Unblocks an already blocked user. Once unblocked, the user can
            /// perform the admin actions they could previously, that is,
            /// they once again have a management role.
            /// They can also once again unlock the access points they previously
            /// had access to.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnblockUserResponse UnblockUser(UnblockUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnblockUser, null, options, request);
            /// <summary>
            /// Unblock a user
            ///
            /// Unblocks an already blocked user. Once unblocked, the user can
            /// perform the admin actions they could previously, that is,
            /// they once again have a management role.
            /// They can also once again unlock the access points they previously
            /// had access to.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnblockUserResponse> UnblockUserAsync(UnblockUserRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UnblockUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unblock a user
            ///
            /// Unblocks an already blocked user. Once unblocked, the user can
            /// perform the admin actions they could previously, that is,
            /// they once again have a management role.
            /// They can also once again unlock the access points they previously
            /// had access to.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnblockUserResponse> UnblockUserAsync(UnblockUserRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UnblockUser, null, options, request);
            /// <summary>
            /// Create a user access right
            ///
            /// Creates a user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UserAccessRight CreateUserAccessRight(CreateUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateUserAccessRight(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a user access right
            ///
            /// Creates a user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UserAccessRight CreateUserAccessRight(CreateUserAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateUserAccessRight, null, options, request);
            /// <summary>
            /// Create a user access right
            ///
            /// Creates a user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UserAccessRight> CreateUserAccessRightAsync(CreateUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateUserAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a user access right
            ///
            /// Creates a user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UserAccessRight> CreateUserAccessRightAsync(CreateUserAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateUserAccessRight, null, options, request);
            /// <summary>
            /// Get a user access right
            ///
            /// Gets an existing user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UserAccessRight GetUserAccessRight(GetUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetUserAccessRight(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a user access right
            ///
            /// Gets an existing user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UserAccessRight GetUserAccessRight(GetUserAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetUserAccessRight, null, options, request);
            /// <summary>
            /// Get a user access right
            ///
            /// Gets an existing user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UserAccessRight> GetUserAccessRightAsync(GetUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetUserAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a user access right
            ///
            /// Gets an existing user's access right association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UserAccessRight> GetUserAccessRightAsync(GetUserAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetUserAccessRight, null, options, request);
            /// <summary>
            /// List user access rights
            ///
            /// Lists an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListUserAccessRightsResponse ListUserAccessRights(ListUserAccessRightsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListUserAccessRights(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List user access rights
            ///
            /// Lists an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListUserAccessRightsResponse ListUserAccessRights(ListUserAccessRightsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListUserAccessRights, null, options, request);
            /// <summary>
            /// List user access rights
            ///
            /// Lists an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListUserAccessRightsResponse> ListUserAccessRightsAsync(ListUserAccessRightsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListUserAccessRightsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List user access rights
            ///
            /// Lists an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListUserAccessRightsResponse> ListUserAccessRightsAsync(ListUserAccessRightsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListUserAccessRights, null, options, request);
            /// <summary>
            /// Update a user access right
            ///
            /// Updates an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UserAccessRight UpdateUserAccessRight(UpdateUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateUserAccessRight(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a user access right
            ///
            /// Updates an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UserAccessRight UpdateUserAccessRight(UpdateUserAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateUserAccessRight, null, options, request);
            /// <summary>
            /// Update a user access right
            ///
            /// Updates an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UserAccessRight> UpdateUserAccessRightAsync(UpdateUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateUserAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a user access right
            ///
            /// Updates an existing user's access right associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UserAccessRight> UpdateUserAccessRightAsync(UpdateUserAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateUserAccessRight, null, options, request);
            /// <summary>
            /// Delete a user access right
            ///
            /// Deletes a user's access right association. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteUserAccessRight(DeleteUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteUserAccessRight(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a user access right
            ///
            /// Deletes a user's access right association. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteUserAccessRight(DeleteUserAccessRightRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteUserAccessRight, null, options, request);
            /// <summary>
            /// Delete a user access right
            ///
            /// Deletes a user's access right association. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteUserAccessRightAsync(DeleteUserAccessRightRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteUserAccessRightAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a user access right
            ///
            /// Deletes a user's access right association. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteUserAccessRightAsync(DeleteUserAccessRightRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteUserAccessRight, null, options, request);
            /// <summary>
            /// Assign a card key
            ///
            /// Assigns a card key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CardKey AssignCardKey(AssignCardKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignCardKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign a card key
            ///
            /// Assigns a card key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CardKey AssignCardKey(AssignCardKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_AssignCardKey, null, options, request);
            /// <summary>
            /// Assign a card key
            ///
            /// Assigns a card key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CardKey> AssignCardKeyAsync(AssignCardKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignCardKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign a card key
            ///
            /// Assigns a card key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CardKey> AssignCardKeyAsync(AssignCardKeyRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_AssignCardKey, null, options, request);
            /// <summary>
            /// Cancel a card key
            ///
            /// Cancels an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CardKey CancelCardKey(CancelCardKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelCardKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel a card key
            ///
            /// Cancels an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CardKey CancelCardKey(CancelCardKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CancelCardKey, null, options, request);
            /// <summary>
            /// Cancel a card key
            ///
            /// Cancels an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CardKey> CancelCardKeyAsync(CancelCardKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelCardKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel a card key
            ///
            /// Cancels an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CardKey> CancelCardKeyAsync(CancelCardKeyRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CancelCardKey, null, options, request);
            /// <summary>
            /// Encode a card key
            ///
            /// Encodes an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation EncodeCardKey(EncodeCardKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => EncodeCardKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Encode a card key
            ///
            /// Encodes an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation EncodeCardKey(EncodeCardKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_EncodeCardKey, null, options, request);
            /// <summary>
            /// Encode a card key
            ///
            /// Encodes an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> EncodeCardKeyAsync(EncodeCardKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => EncodeCardKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Encode a card key
            ///
            /// Encodes an existing user's card key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> EncodeCardKeyAsync(EncodeCardKeyRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_EncodeCardKey, null, options, request);
            /// <summary>
            /// Assign an app key
            ///
            /// Assigns an app key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AppKey AssignAppKey(AssignAppKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignAppKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign an app key
            ///
            /// Assigns an app key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AppKey AssignAppKey(AssignAppKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_AssignAppKey, null, options, request);
            /// <summary>
            /// Assign an app key
            ///
            /// Assigns an app key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AppKey> AssignAppKeyAsync(AssignAppKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignAppKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign an app key
            ///
            /// Assigns an app key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AppKey> AssignAppKeyAsync(AssignAppKeyRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_AssignAppKey, null, options, request);
            /// <summary>
            /// Cancel an app key
            ///
            /// Cancels an existing user's app key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AppKey CancelAppKey(CancelAppKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelAppKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel an app key
            ///
            /// Cancels an existing user's app key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AppKey CancelAppKey(CancelAppKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CancelAppKey, null, options, request);
            /// <summary>
            /// Cancel an app key
            ///
            /// Cancels an existing user's app key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AppKey> CancelAppKeyAsync(CancelAppKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelAppKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel an app key
            ///
            /// Cancels an existing user's app key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AppKey> CancelAppKeyAsync(CancelAppKeyRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_CancelAppKey, null, options, request);
            /// <summary>
            /// Compute data of an app key
            ///
            /// Compute an existing user's app key data. Data contains encoded access
            /// rights of the user.
            ///
            /// Note: There might be a delay for the key data to be updated after a user
            /// is created or their access rights are modified. It is recommended to wait
            /// for a moment (at least 60 seconds, for example) before calling this method to
            /// ensure the returned data is up-to-date.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ComputeAppKeyDataResponse ComputeAppKeyData(ComputeAppKeyDataRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ComputeAppKeyData(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Compute data of an app key
            ///
            /// Compute an existing user's app key data. Data contains encoded access
            /// rights of the user.
            ///
            /// Note: There might be a delay for the key data to be updated after a user
            /// is created or their access rights are modified. It is recommended to wait
            /// for a moment (at least 60 seconds, for example) before calling this method to
            /// ensure the returned data is up-to-date.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ComputeAppKeyDataResponse ComputeAppKeyData(ComputeAppKeyDataRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ComputeAppKeyData, null, options, request);
            /// <summary>
            /// Compute data of an app key
            ///
            /// Compute an existing user's app key data. Data contains encoded access
            /// rights of the user.
            ///
            /// Note: There might be a delay for the key data to be updated after a user
            /// is created or their access rights are modified. It is recommended to wait
            /// for a moment (at least 60 seconds, for example) before calling this method to
            /// ensure the returned data is up-to-date.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ComputeAppKeyDataResponse> ComputeAppKeyDataAsync(ComputeAppKeyDataRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            => ComputeAppKeyDataAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Compute data of an app key
            ///
            /// Compute an existing user's app key data. Data contains encoded access
            /// rights of the user.
            ///
            /// Note: There might be a delay for the key data to be updated after a user
            /// is created or their access rights are modified. It is recommended to wait
            /// for a moment (at least 60 seconds, for example) before calling this method to
            /// ensure the returned data is up-to-date.
            /// (-- api-linter: core::0136::http-name-variable=disabled --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ComputeAppKeyDataResponse> ComputeAppKeyDataAsync(ComputeAppKeyDataRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_ComputeAppKeyData, null, options, request);
            /// <summary>
            /// Assign a wallet key
            ///
            /// Assigns a wallet key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AssignWalletKeyResponse AssignWalletKey(AssignWalletKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignWalletKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign a wallet key
            ///
            /// Assigns a wallet key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AssignWalletKeyResponse AssignWalletKey(AssignWalletKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_AssignWalletKey, null, options, request);
            /// <summary>
            /// Assign a wallet key
            ///
            /// Assigns a wallet key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AssignWalletKeyResponse> AssignWalletKeyAsync(AssignWalletKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            => AssignWalletKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign a wallet key
            ///
            /// Assigns a wallet key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AssignWalletKeyResponse> AssignWalletKeyAsync(AssignWalletKeyRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_AssignWalletKey, null, options, request);
            /// <summary>
            /// Cancel a wallet key
            ///
            /// Cancels an existing user's wallet key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CancelWalletKeyResponse CancelWalletKey(CancelWalletKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelWalletKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel a wallet key
            ///
            /// Cancels an existing user's wallet key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CancelWalletKeyResponse CancelWalletKey(CancelWalletKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CancelWalletKey, null, options, request);
            /// <summary>
            /// Cancel a wallet key
            ///
            /// Cancels an existing user's wallet key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CancelWalletKeyResponse> CancelWalletKeyAsync(CancelWalletKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            => CancelWalletKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel a wallet key
            ///
            /// Cancels an existing user's wallet key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CancelWalletKeyResponse> CancelWalletKeyAsync(CancelWalletKeyRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_CancelWalletKey, null, options, request);
            /// <summary>
            /// Assign a passcode
            ///
            /// Assigns a passcode to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AssignPasscodeResponse AssignPasscode(AssignPasscodeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignPasscode(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign a passcode
            ///
            /// Assigns a passcode to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AssignPasscodeResponse AssignPasscode(AssignPasscodeRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_AssignPasscode, null, options, request);
            /// <summary>
            /// Assign a passcode
            ///
            /// Assigns a passcode to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AssignPasscodeResponse> AssignPasscodeAsync(AssignPasscodeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            => AssignPasscodeAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign a passcode
            ///
            /// Assigns a passcode to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AssignPasscodeResponse> AssignPasscodeAsync(AssignPasscodeRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_AssignPasscode, null, options, request);
            /// <summary>
            /// Cancel a passcode
            ///
            /// Cancels an existing user's passcode.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CancelPasscodeResponse CancelPasscode(CancelPasscodeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelPasscode(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel a passcode
            ///
            /// Cancels an existing user's passcode.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CancelPasscodeResponse CancelPasscode(CancelPasscodeRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CancelPasscode, null, options, request);
            /// <summary>
            /// Cancel a passcode
            ///
            /// Cancels an existing user's passcode.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CancelPasscodeResponse> CancelPasscodeAsync(CancelPasscodeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
            => CancelPasscodeAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel a passcode
            ///
            /// Cancels an existing user's passcode.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CancelPasscodeResponse> CancelPasscodeAsync(CancelPasscodeRequest request, CallOptions options)
            => CallInvoker.AsyncUnaryCall(__Method_CancelPasscode, null, options, request);
            /// <summary>
            /// Assign an electronic key
            ///
            /// Assigns an electronic key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AssignElectronicKeyResponse AssignElectronicKey(AssignElectronicKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign an electronic key
            ///
            /// Assigns an electronic key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AssignElectronicKeyResponse AssignElectronicKey(AssignElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_AssignElectronicKey, null, options, request);
            /// <summary>
            /// Assign an electronic key
            ///
            /// Assigns an electronic key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AssignElectronicKeyResponse> AssignElectronicKeyAsync(AssignElectronicKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => AssignElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Assign an electronic key
            ///
            /// Assigns an electronic key to an existing user.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AssignElectronicKeyResponse> AssignElectronicKeyAsync(AssignElectronicKeyRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_AssignElectronicKey, null, options, request);
            /// <summary>
            /// Cancel an electronic key
            ///
            /// Cancels an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CancelElectronicKeyResponse CancelElectronicKey(CancelElectronicKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel an electronic key
            ///
            /// Cancels an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CancelElectronicKeyResponse CancelElectronicKey(CancelElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CancelElectronicKey, null, options, request);
            /// <summary>
            /// Cancel an electronic key
            ///
            /// Cancels an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CancelElectronicKeyResponse> CancelElectronicKeyAsync(CancelElectronicKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CancelElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel an electronic key
            ///
            /// Cancels an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CancelElectronicKeyResponse> CancelElectronicKeyAsync(CancelElectronicKeyRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CancelElectronicKey, null, options, request);
            /// <summary>
            /// Encode an electronic key
            ///
            /// Encodes an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation EncodeElectronicKey(EncodeElectronicKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => EncodeElectronicKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Encode an electronic key
            ///
            /// Encodes an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation EncodeElectronicKey(EncodeElectronicKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_EncodeElectronicKey, null, options, request);
            /// <summary>
            /// Encode an electronic key
            ///
            /// Encodes an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> EncodeElectronicKeyAsync(EncodeElectronicKeyRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => EncodeElectronicKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Encode an electronic key
            ///
            /// Encodes an existing user's electronic key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> EncodeElectronicKeyAsync(EncodeElectronicKeyRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_EncodeElectronicKey, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override UserServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}