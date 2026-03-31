using Saltoapis.Nebula.ElectronicLock.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.ElectronicLock.V1.Response;

namespace Saltoapis.Nebula.ElectronicLock.V1
{
    /// <summary>
    /// An electronic lock is a physical electronic device such as an electronic
    /// escutcheon or cylinder, or a door controller with an electric strike. It
    /// differs from an access point in that, an electronic lock could be a
    /// particular model of a device such as a SALTO Neo cylinder, a door controller
    /// with an electric strike or a Danalock V3 smartlock, for example. An
    /// electronic lock is a single device whereas an access point could be made up
    /// of several devices. An access point could be composed of an electronic lock
    /// plus a door detector, a door controller and a keypad, or an intercom adaptor
    /// which is connected to multiple electronic locks. This service is responsible
    /// for managing electronic lock resources.
    /// </summary>
    public static partial class ElectronicLockService
    {
        static readonly string __ServiceName = "salto.nebula.electroniclock.v1.ElectronicLockService";

        static readonly Marshaller<CreateElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_CreateElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(CreateElectronicLockRequest.Parser);

        static readonly Marshaller<ElectronicLock> __Marshaller_salto_nebula_electroniclock_v1_ElectronicLock = GrpcMessageHelper.CreateMarshaller(ElectronicLock.Parser);

        static readonly Marshaller<GetElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_GetElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(GetElectronicLockRequest.Parser);

        static readonly Marshaller<ListElectronicLocksRequest> __Marshaller_salto_nebula_electroniclock_v1_ListElectronicLocksRequest = GrpcMessageHelper.CreateMarshaller(ListElectronicLocksRequest.Parser);

        static readonly Marshaller<ListElectronicLocksResponse> __Marshaller_salto_nebula_electroniclock_v1_ListElectronicLocksResponse = GrpcMessageHelper.CreateMarshaller(ListElectronicLocksResponse.Parser);

        static readonly Marshaller<UpdateElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_UpdateElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(UpdateElectronicLockRequest.Parser);

        static readonly Marshaller<DeleteElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_DeleteElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(DeleteElectronicLockRequest.Parser);

        static readonly Marshaller<BindElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_BindElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(BindElectronicLockRequest.Parser);

        static readonly Marshaller<BindElectronicLockResponse> __Marshaller_salto_nebula_electroniclock_v1_BindElectronicLockResponse = GrpcMessageHelper.CreateMarshaller(BindElectronicLockResponse.Parser);

        static readonly Marshaller<UnbindElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_UnbindElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(UnbindElectronicLockRequest.Parser);

        static readonly Marshaller<UnbindElectronicLockResponse> __Marshaller_salto_nebula_electroniclock_v1_UnbindElectronicLockResponse = GrpcMessageHelper.CreateMarshaller(UnbindElectronicLockResponse.Parser);

        static readonly Marshaller<InitializeElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_InitializeElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(InitializeElectronicLockRequest.Parser);

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = GrpcMessageHelper.CreateMarshaller(Longrunning.V1.Operation.Parser);

        static readonly Marshaller<ConfigureElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_ConfigureElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(ConfigureElectronicLockRequest.Parser);

        static readonly Marshaller<ResetElectronicLockRequest> __Marshaller_salto_nebula_electroniclock_v1_ResetElectronicLockRequest = GrpcMessageHelper.CreateMarshaller(ResetElectronicLockRequest.Parser);

        static readonly Marshaller<UpdateElectronicLockFirmwareRequest> __Marshaller_salto_nebula_electroniclock_v1_UpdateElectronicLockFirmwareRequest = GrpcMessageHelper.CreateMarshaller(UpdateElectronicLockFirmwareRequest.Parser);

        static readonly Marshaller<GenerateAuthorizationTokenRequest> __Marshaller_salto_nebula_electroniclock_v1_GenerateAuthorizationTokenRequest = GrpcMessageHelper.CreateMarshaller(GenerateAuthorizationTokenRequest.Parser);

        static readonly Marshaller<GenerateAuthorizationTokenResponse> __Marshaller_salto_nebula_electroniclock_v1_GenerateAuthorizationTokenResponse = GrpcMessageHelper.CreateMarshaller(GenerateAuthorizationTokenResponse.Parser);

        static readonly Marshaller<GenerateFirmwareDownloadUriRequest> __Marshaller_salto_nebula_electroniclock_v1_GenerateFirmwareDownloadUriRequest = GrpcMessageHelper.CreateMarshaller(GenerateFirmwareDownloadUriRequest.Parser);

        static readonly Method<CreateElectronicLockRequest, ElectronicLock> __Method_CreateElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "CreateElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_CreateElectronicLockRequest,
            __Marshaller_salto_nebula_electroniclock_v1_ElectronicLock);

        static readonly Method<GetElectronicLockRequest, ElectronicLock> __Method_GetElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "GetElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_GetElectronicLockRequest,
            __Marshaller_salto_nebula_electroniclock_v1_ElectronicLock);

        static readonly Method<ListElectronicLocksRequest, ListElectronicLocksResponse> __Method_ListElectronicLocks = new(
            MethodType.Unary,
            __ServiceName,
            "ListElectronicLocks",
            __Marshaller_salto_nebula_electroniclock_v1_ListElectronicLocksRequest,
            __Marshaller_salto_nebula_electroniclock_v1_ListElectronicLocksResponse);

        static readonly Method<UpdateElectronicLockRequest, ElectronicLock> __Method_UpdateElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_UpdateElectronicLockRequest,
            __Marshaller_salto_nebula_electroniclock_v1_ElectronicLock);

        static readonly Method<DeleteElectronicLockRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_DeleteElectronicLockRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<BindElectronicLockRequest, BindElectronicLockResponse> __Method_BindElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "BindElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_BindElectronicLockRequest,
            __Marshaller_salto_nebula_electroniclock_v1_BindElectronicLockResponse);

        static readonly Method<UnbindElectronicLockRequest, UnbindElectronicLockResponse> __Method_UnbindElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "UnbindElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_UnbindElectronicLockRequest,
            __Marshaller_salto_nebula_electroniclock_v1_UnbindElectronicLockResponse);

        static readonly Method<InitializeElectronicLockRequest, Longrunning.V1.Operation> __Method_InitializeElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "InitializeElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_InitializeElectronicLockRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ConfigureElectronicLockRequest, Longrunning.V1.Operation> __Method_ConfigureElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "ConfigureElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_ConfigureElectronicLockRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ResetElectronicLockRequest, Longrunning.V1.Operation> __Method_ResetElectronicLock = new(
            MethodType.Unary,
            __ServiceName,
            "ResetElectronicLock",
            __Marshaller_salto_nebula_electroniclock_v1_ResetElectronicLockRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<UpdateElectronicLockFirmwareRequest, Longrunning.V1.Operation> __Method_UpdateElectronicLockFirmware = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateElectronicLockFirmware",
            __Marshaller_salto_nebula_electroniclock_v1_UpdateElectronicLockFirmwareRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<GenerateAuthorizationTokenRequest, GenerateAuthorizationTokenResponse> __Method_GenerateAuthorizationToken = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateAuthorizationToken",
            __Marshaller_salto_nebula_electroniclock_v1_GenerateAuthorizationTokenRequest,
            __Marshaller_salto_nebula_electroniclock_v1_GenerateAuthorizationTokenResponse);

        static readonly Method<GenerateFirmwareDownloadUriRequest, Longrunning.V1.Operation> __Method_GenerateFirmwareDownloadUri = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateFirmwareDownloadUri",
            __Marshaller_salto_nebula_electroniclock_v1_GenerateFirmwareDownloadUriRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for ElectronicLockService</summary>
        public partial class ElectronicLockServiceClient : ClientBase<ElectronicLockServiceClient>
        {
            /// <summary>Creates a new client for ElectronicLockService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public ElectronicLockServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for ElectronicLockService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public ElectronicLockServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected ElectronicLockServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected ElectronicLockServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an electronic lock
            ///
            /// Creates a new electronic lock
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicLock CreateElectronicLock(CreateElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an electronic lock
            ///
            /// Creates a new electronic lock
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicLock CreateElectronicLock(CreateElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateElectronicLock, null, options, request);
            /// <summary>
            /// Create an electronic lock
            ///
            /// Creates a new electronic lock
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicLock> CreateElectronicLockAsync(CreateElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an electronic lock
            ///
            /// Creates a new electronic lock
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicLock> CreateElectronicLockAsync(CreateElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateElectronicLock, null, options, request);
            }

            /// <summary>
            /// Get an electronic lock
            ///
            /// Gets an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicLock GetElectronicLock(GetElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an electronic lock
            ///
            /// Gets an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicLock GetElectronicLock(GetElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetElectronicLock, null, options, request);
            /// <summary>
            /// Get an electronic lock
            ///
            /// Gets an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicLock> GetElectronicLockAsync(GetElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an electronic lock
            ///
            /// Gets an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicLock> GetElectronicLockAsync(GetElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetElectronicLock, null, options, request);
            }

            /// <summary>
            /// List electronic locks
            ///
            /// Returns a list of electronic locks that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListElectronicLocksResponse ListElectronicLocks(ListElectronicLocksRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListElectronicLocks(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List electronic locks
            ///
            /// Returns a list of electronic locks that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListElectronicLocksResponse ListElectronicLocks(ListElectronicLocksRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListElectronicLocks, null, options, request);
            /// <summary>
            /// List electronic locks
            ///
            /// Returns a list of electronic locks that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListElectronicLocksResponse> ListElectronicLocksAsync(ListElectronicLocksRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListElectronicLocksAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List electronic locks
            ///
            /// Returns a list of electronic locks that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListElectronicLocksResponse> ListElectronicLocksAsync(ListElectronicLocksRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListElectronicLocks, null, options, request);
            }

            /// <summary>
            /// Update an electronic lock
            ///
            /// Updates an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicLock UpdateElectronicLock(UpdateElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an electronic lock
            ///
            /// Updates an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ElectronicLock UpdateElectronicLock(UpdateElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateElectronicLock, null, options, request);
            /// <summary>
            /// Update an electronic lock
            ///
            /// Updates an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicLock> UpdateElectronicLockAsync(UpdateElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an electronic lock
            ///
            /// Updates an existing electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ElectronicLock> UpdateElectronicLockAsync(UpdateElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateElectronicLock, null, options, request);
            }

            /// <summary>
            /// Delete an electronic lock
            ///
            /// Permanently deletes an electronic lock. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteElectronicLock(DeleteElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an electronic lock
            ///
            /// Permanently deletes an electronic lock. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteElectronicLock(DeleteElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteElectronicLock, null, options, request);
            /// <summary>
            /// Delete an electronic lock
            ///
            /// Permanently deletes an electronic lock. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteElectronicLockAsync(DeleteElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an electronic lock
            ///
            /// Permanently deletes an electronic lock. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteElectronicLockAsync(DeleteElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteElectronicLock, null, options, request);
            }

            /// <summary>
            /// Bind an electronic lock
            ///
            /// Binds an electronic lock. Binding an electronic lock assigns a device
            /// identifier to the electronic lock. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindElectronicLockResponse BindElectronicLock(BindElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => BindElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind an electronic lock
            ///
            /// Binds an electronic lock. Binding an electronic lock assigns a device
            /// identifier to the electronic lock. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindElectronicLockResponse BindElectronicLock(BindElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BindElectronicLock, null, options, request);
            /// <summary>
            /// Bind an electronic lock
            ///
            /// Binds an electronic lock. Binding an electronic lock assigns a device
            /// identifier to the electronic lock. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindElectronicLockResponse> BindElectronicLockAsync(BindElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return BindElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Bind an electronic lock
            ///
            /// Binds an electronic lock. Binding an electronic lock assigns a device
            /// identifier to the electronic lock. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindElectronicLockResponse> BindElectronicLockAsync(BindElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_BindElectronicLock, null, options, request);
            }

            /// <summary>
            /// Unbind an electronic lock
            ///
            /// Unbinds an electronic lock. Unbinding an electronic lock removes the
            /// device identifier from the electronic lock. This may be required in some
            /// cases where the electronic lock is not available anymore because, for
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
            public virtual UnbindElectronicLockResponse UnbindElectronicLock(UnbindElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UnbindElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind an electronic lock
            ///
            /// Unbinds an electronic lock. Unbinding an electronic lock removes the
            /// device identifier from the electronic lock. This may be required in some
            /// cases where the electronic lock is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindElectronicLockResponse UnbindElectronicLock(UnbindElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnbindElectronicLock, null, options, request);
            /// <summary>
            /// Unbind an electronic lock
            ///
            /// Unbinds an electronic lock. Unbinding an electronic lock removes the
            /// device identifier from the electronic lock. This may be required in some
            /// cases where the electronic lock is not available anymore because, for
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
            public virtual AsyncUnaryCall<UnbindElectronicLockResponse> UnbindElectronicLockAsync(UnbindElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UnbindElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Unbind an electronic lock
            ///
            /// Unbinds an electronic lock. Unbinding an electronic lock removes the
            /// device identifier from the electronic lock. This may be required in some
            /// cases where the electronic lock is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindElectronicLockResponse> UnbindElectronicLockAsync(UnbindElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UnbindElectronicLock, null, options, request);
            }

            /// <summary>
            /// Initialize an electronic lock
            ///
            /// Initializes an electronic lock. Electronic locks need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeElectronicLock(InitializeElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => InitializeElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize an electronic lock
            ///
            /// Initializes an electronic lock. Electronic locks need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeElectronicLock(InitializeElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_InitializeElectronicLock, null, options, request);
            /// <summary>
            /// Initialize an electronic lock
            ///
            /// Initializes an electronic lock. Electronic locks need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeElectronicLockAsync(InitializeElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return InitializeElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Initialize an electronic lock
            ///
            /// Initializes an electronic lock. Electronic locks need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeElectronicLockAsync(InitializeElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_InitializeElectronicLock, null, options, request);
            }

            /// <summary>
            /// Configure an electronic lock
            ///
            /// Configures an electronic lock. Configuring an electronic lock implies
            /// adding some information to the electronic lock such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureElectronicLock(ConfigureElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ConfigureElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure an electronic lock
            ///
            /// Configures an electronic lock. Configuring an electronic lock implies
            /// adding some information to the electronic lock such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureElectronicLock(ConfigureElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ConfigureElectronicLock, null, options, request);
            /// <summary>
            /// Configure an electronic lock
            ///
            /// Configures an electronic lock. Configuring an electronic lock implies
            /// adding some information to the electronic lock such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureElectronicLockAsync(ConfigureElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ConfigureElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Configure an electronic lock
            ///
            /// Configures an electronic lock. Configuring an electronic lock implies
            /// adding some information to the electronic lock such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureElectronicLockAsync(ConfigureElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ConfigureElectronicLock, null, options, request);
            }

            /// <summary>
            /// Reset an electronic lock
            ///
            /// Resetting a device such as an electronic lock means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetElectronicLock(ResetElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ResetElectronicLock(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset an electronic lock
            ///
            /// Resetting a device such as an electronic lock means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetElectronicLock(ResetElectronicLockRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ResetElectronicLock, null, options, request);
            /// <summary>
            /// Reset an electronic lock
            ///
            /// Resetting a device such as an electronic lock means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetElectronicLockAsync(ResetElectronicLockRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ResetElectronicLockAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Reset an electronic lock
            ///
            /// Resetting a device such as an electronic lock means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetElectronicLockAsync(ResetElectronicLockRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ResetElectronicLock, null, options, request);
            }

            /// <summary>
            /// Update electronic lock firmware
            ///
            /// Updates an electronic lock's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateElectronicLockFirmware(UpdateElectronicLockFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateElectronicLockFirmware(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update electronic lock firmware
            ///
            /// Updates an electronic lock's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateElectronicLockFirmware(UpdateElectronicLockFirmwareRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateElectronicLockFirmware, null, options, request);
            /// <summary>
            /// Update electronic lock firmware
            ///
            /// Updates an electronic lock's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateElectronicLockFirmwareAsync(UpdateElectronicLockFirmwareRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateElectronicLockFirmwareAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update electronic lock firmware
            ///
            /// Updates an electronic lock's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateElectronicLockFirmwareAsync(UpdateElectronicLockFirmwareRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateElectronicLockFirmware, null, options, request);
            }

            /// <summary>
            /// Generate authorization token for an electronic lock
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateAuthorizationToken(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate authorization token for an electronic lock
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generate authorization token for an electronic lock
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic lock.
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
            /// Generate authorization token for an electronic lock
            ///
            /// Generates an authorization token that allows to connect to, authenticate and
            /// authorize an electronic lock.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            }

            /// <summary>
            /// Generate electronic lock firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic lock. The returned URI can be used to bring the electronic
            /// lock firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUri(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate electronic lock firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic lock. The returned URI can be used to bring the electronic
            /// lock firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Generate electronic lock firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic lock. The returned URI can be used to bring the electronic
            /// lock firmwares up to latest.
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
            /// Generate electronic lock firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// electronic lock. The returned URI can be used to bring the electronic
            /// lock firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override ElectronicLockServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}




