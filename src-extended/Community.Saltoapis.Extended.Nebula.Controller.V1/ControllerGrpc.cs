using Saltoapis.Nebula.Controller.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.Controller.V1.Response;

namespace Saltoapis.Nebula.Controller.V1
{
    /// <summary>
    /// Controllers are mains-wired hardware devices that can be used to control access where
    /// a standalone lock cannot be fitted. For example, on car park barriers, turnstiles or
    /// sliding doors. They allow the management of multiple accesses from a single device.
    /// For example, one single controller could control access to both the entrance and exit
    /// of a building via a turnstile. This service is responsible for managing controllers
    /// resources.
    /// </summary>
    public static partial class ControllerService
    {
        static readonly string __ServiceName = "salto.nebula.controller.v1.ControllerService";

        static readonly Marshaller<CreateControllerRequest> __Marshaller_salto_nebula_controller_v1_CreateControllerRequest = GrpcMessageHelper.CreateMarshaller(CreateControllerRequest.Parser);

        static readonly Marshaller<Controller> __Marshaller_salto_nebula_controller_v1_Controller = GrpcMessageHelper.CreateMarshaller(Controller.Parser);

        static readonly Marshaller<GetControllerRequest> __Marshaller_salto_nebula_controller_v1_GetControllerRequest = GrpcMessageHelper.CreateMarshaller(GetControllerRequest.Parser);

        static readonly Marshaller<ListControllersRequest> __Marshaller_salto_nebula_controller_v1_ListControllersRequest = GrpcMessageHelper.CreateMarshaller(ListControllersRequest.Parser);

        static readonly Marshaller<ListControllersResponse> __Marshaller_salto_nebula_controller_v1_ListControllersResponse = GrpcMessageHelper.CreateMarshaller(ListControllersResponse.Parser);

        static readonly Marshaller<UpdateControllerRequest> __Marshaller_salto_nebula_controller_v1_UpdateControllerRequest = GrpcMessageHelper.CreateMarshaller(UpdateControllerRequest.Parser);

        static readonly Marshaller<DeleteControllerRequest> __Marshaller_salto_nebula_controller_v1_DeleteControllerRequest = GrpcMessageHelper.CreateMarshaller(DeleteControllerRequest.Parser);

        static readonly Marshaller<BindControllerRequest> __Marshaller_salto_nebula_controller_v1_BindControllerRequest = GrpcMessageHelper.CreateMarshaller(BindControllerRequest.Parser);

        static readonly Marshaller<BindControllerResponse> __Marshaller_salto_nebula_controller_v1_BindControllerResponse = GrpcMessageHelper.CreateMarshaller(BindControllerResponse.Parser);

        static readonly Marshaller<UnbindControllerRequest> __Marshaller_salto_nebula_controller_v1_UnbindControllerRequest = GrpcMessageHelper.CreateMarshaller(UnbindControllerRequest.Parser);

        static readonly Marshaller<UnbindControllerResponse> __Marshaller_salto_nebula_controller_v1_UnbindControllerResponse = GrpcMessageHelper.CreateMarshaller(UnbindControllerResponse.Parser);

        static readonly Marshaller<InitializeControllerRequest> __Marshaller_salto_nebula_controller_v1_InitializeControllerRequest = GrpcMessageHelper.CreateMarshaller(InitializeControllerRequest.Parser);

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = GrpcMessageHelper.CreateMarshaller(Longrunning.V1.Operation.Parser);

        static readonly Marshaller<ConfigureControllerRequest> __Marshaller_salto_nebula_controller_v1_ConfigureControllerRequest = GrpcMessageHelper.CreateMarshaller(ConfigureControllerRequest.Parser);

        static readonly Marshaller<ResetControllerRequest> __Marshaller_salto_nebula_controller_v1_ResetControllerRequest = GrpcMessageHelper.CreateMarshaller(ResetControllerRequest.Parser);

        static readonly Marshaller<UpdateControllerFirmwareRequest> __Marshaller_salto_nebula_controller_v1_UpdateControllerFirmwareRequest = GrpcMessageHelper.CreateMarshaller(UpdateControllerFirmwareRequest.Parser);

        static readonly Marshaller<GenerateAuthorizationTokenRequest> __Marshaller_salto_nebula_controller_v1_GenerateAuthorizationTokenRequest = GrpcMessageHelper.CreateMarshaller(GenerateAuthorizationTokenRequest.Parser);

        static readonly Marshaller<GenerateAuthorizationTokenResponse> __Marshaller_salto_nebula_controller_v1_GenerateAuthorizationTokenResponse = GrpcMessageHelper.CreateMarshaller(GenerateAuthorizationTokenResponse.Parser);

        static readonly Marshaller<GenerateFirmwareDownloadUriRequest> __Marshaller_salto_nebula_controller_v1_GenerateFirmwareDownloadUriRequest = GrpcMessageHelper.CreateMarshaller(GenerateFirmwareDownloadUriRequest.Parser);

        static readonly Marshaller<CreateControllerRelayRequest> __Marshaller_salto_nebula_controller_v1_CreateControllerRelayRequest = GrpcMessageHelper.CreateMarshaller(CreateControllerRelayRequest.Parser);

        static readonly Marshaller<ControllerRelay> __Marshaller_salto_nebula_controller_v1_ControllerRelay = GrpcMessageHelper.CreateMarshaller(ControllerRelay.Parser);

        static readonly Marshaller<BatchCreateControllerRelaysRequest> __Marshaller_salto_nebula_controller_v1_BatchCreateControllerRelaysRequest = GrpcMessageHelper.CreateMarshaller(BatchCreateControllerRelaysRequest.Parser);

        static readonly Marshaller<BatchCreateControllerRelaysResponse> __Marshaller_salto_nebula_controller_v1_BatchCreateControllerRelaysResponse = GrpcMessageHelper.CreateMarshaller(BatchCreateControllerRelaysResponse.Parser);

        static readonly Marshaller<GetControllerRelayRequest> __Marshaller_salto_nebula_controller_v1_GetControllerRelayRequest = GrpcMessageHelper.CreateMarshaller(GetControllerRelayRequest.Parser);

        static readonly Marshaller<ListControllerRelaysRequest> __Marshaller_salto_nebula_controller_v1_ListControllerRelaysRequest = GrpcMessageHelper.CreateMarshaller(ListControllerRelaysRequest.Parser);

        static readonly Marshaller<ListControllerRelaysResponse> __Marshaller_salto_nebula_controller_v1_ListControllerRelaysResponse = GrpcMessageHelper.CreateMarshaller(ListControllerRelaysResponse.Parser);

        static readonly Marshaller<UpdateControllerRelayRequest> __Marshaller_salto_nebula_controller_v1_UpdateControllerRelayRequest = GrpcMessageHelper.CreateMarshaller(UpdateControllerRelayRequest.Parser);

        static readonly Marshaller<BatchUpdateControllerRelaysRequest> __Marshaller_salto_nebula_controller_v1_BatchUpdateControllerRelaysRequest = GrpcMessageHelper.CreateMarshaller(BatchUpdateControllerRelaysRequest.Parser);

        static readonly Marshaller<BatchUpdateControllerRelaysResponse> __Marshaller_salto_nebula_controller_v1_BatchUpdateControllerRelaysResponse = GrpcMessageHelper.CreateMarshaller(BatchUpdateControllerRelaysResponse.Parser);

        static readonly Marshaller<DeleteControllerRelayRequest> __Marshaller_salto_nebula_controller_v1_DeleteControllerRelayRequest = GrpcMessageHelper.CreateMarshaller(DeleteControllerRelayRequest.Parser);

        static readonly Marshaller<BatchDeleteControllerRelaysRequest> __Marshaller_salto_nebula_controller_v1_BatchDeleteControllerRelaysRequest = GrpcMessageHelper.CreateMarshaller(BatchDeleteControllerRelaysRequest.Parser);

        static readonly Marshaller<BatchDeleteControllerRelaysResponse> __Marshaller_salto_nebula_controller_v1_BatchDeleteControllerRelaysResponse = GrpcMessageHelper.CreateMarshaller(BatchDeleteControllerRelaysResponse.Parser);

        static readonly Method<CreateControllerRequest, Controller> __Method_CreateController = new(
            MethodType.Unary,
            __ServiceName,
            "CreateController",
            __Marshaller_salto_nebula_controller_v1_CreateControllerRequest,
            __Marshaller_salto_nebula_controller_v1_Controller);

        static readonly Method<GetControllerRequest, Controller> __Method_GetController = new(
            MethodType.Unary,
            __ServiceName,
            "GetController",
            __Marshaller_salto_nebula_controller_v1_GetControllerRequest,
            __Marshaller_salto_nebula_controller_v1_Controller);

        static readonly Method<ListControllersRequest, ListControllersResponse> __Method_ListControllers = new(
            MethodType.Unary,
            __ServiceName,
            "ListControllers",
            __Marshaller_salto_nebula_controller_v1_ListControllersRequest,
            __Marshaller_salto_nebula_controller_v1_ListControllersResponse);

        static readonly Method<UpdateControllerRequest, Controller> __Method_UpdateController = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateController",
            __Marshaller_salto_nebula_controller_v1_UpdateControllerRequest,
            __Marshaller_salto_nebula_controller_v1_Controller);

        static readonly Method<DeleteControllerRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteController = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteController",
            __Marshaller_salto_nebula_controller_v1_DeleteControllerRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<BindControllerRequest, BindControllerResponse> __Method_BindController = new(
            MethodType.Unary,
            __ServiceName,
            "BindController",
            __Marshaller_salto_nebula_controller_v1_BindControllerRequest,
            __Marshaller_salto_nebula_controller_v1_BindControllerResponse);

        static readonly Method<UnbindControllerRequest, UnbindControllerResponse> __Method_UnbindController = new(
            MethodType.Unary,
            __ServiceName,
            "UnbindController",
            __Marshaller_salto_nebula_controller_v1_UnbindControllerRequest,
            __Marshaller_salto_nebula_controller_v1_UnbindControllerResponse);

        static readonly Method<InitializeControllerRequest, Longrunning.V1.Operation> __Method_InitializeController = new(
            MethodType.Unary,
            __ServiceName,
            "InitializeController",
            __Marshaller_salto_nebula_controller_v1_InitializeControllerRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ConfigureControllerRequest, Longrunning.V1.Operation> __Method_ConfigureController = new(
            MethodType.Unary,
            __ServiceName,
            "ConfigureController",
            __Marshaller_salto_nebula_controller_v1_ConfigureControllerRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ResetControllerRequest, Longrunning.V1.Operation> __Method_ResetController = new(
            MethodType.Unary,
            __ServiceName,
            "ResetController",
            __Marshaller_salto_nebula_controller_v1_ResetControllerRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<UpdateControllerFirmwareRequest, Longrunning.V1.Operation> __Method_UpdateControllerFirmware = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateControllerFirmware",
            __Marshaller_salto_nebula_controller_v1_UpdateControllerFirmwareRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<GenerateAuthorizationTokenRequest, GenerateAuthorizationTokenResponse> __Method_GenerateAuthorizationToken = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateAuthorizationToken",
            __Marshaller_salto_nebula_controller_v1_GenerateAuthorizationTokenRequest,
            __Marshaller_salto_nebula_controller_v1_GenerateAuthorizationTokenResponse);

        static readonly Method<GenerateFirmwareDownloadUriRequest, Longrunning.V1.Operation> __Method_GenerateFirmwareDownloadUri = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateFirmwareDownloadUri",
            __Marshaller_salto_nebula_controller_v1_GenerateFirmwareDownloadUriRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<CreateControllerRelayRequest, ControllerRelay> __Method_CreateControllerRelay = new(
            MethodType.Unary,
            __ServiceName,
            "CreateControllerRelay",
            __Marshaller_salto_nebula_controller_v1_CreateControllerRelayRequest,
            __Marshaller_salto_nebula_controller_v1_ControllerRelay);

        static readonly Method<BatchCreateControllerRelaysRequest, BatchCreateControllerRelaysResponse> __Method_BatchCreateControllerRelays = new(
            MethodType.Unary,
            __ServiceName,
            "BatchCreateControllerRelays",
            __Marshaller_salto_nebula_controller_v1_BatchCreateControllerRelaysRequest,
            __Marshaller_salto_nebula_controller_v1_BatchCreateControllerRelaysResponse);

        static readonly Method<GetControllerRelayRequest, ControllerRelay> __Method_GetControllerRelay = new(
            MethodType.Unary,
            __ServiceName,
            "GetControllerRelay",
            __Marshaller_salto_nebula_controller_v1_GetControllerRelayRequest,
            __Marshaller_salto_nebula_controller_v1_ControllerRelay);

        static readonly Method<ListControllerRelaysRequest, ListControllerRelaysResponse> __Method_ListControllerRelays = new(
            MethodType.Unary,
            __ServiceName,
            "ListControllerRelays",
            __Marshaller_salto_nebula_controller_v1_ListControllerRelaysRequest,
            __Marshaller_salto_nebula_controller_v1_ListControllerRelaysResponse);

        static readonly Method<UpdateControllerRelayRequest, ControllerRelay> __Method_UpdateControllerRelay = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateControllerRelay",
            __Marshaller_salto_nebula_controller_v1_UpdateControllerRelayRequest,
            __Marshaller_salto_nebula_controller_v1_ControllerRelay);

        static readonly Method<BatchUpdateControllerRelaysRequest, BatchUpdateControllerRelaysResponse> __Method_BatchUpdateControllerRelays = new(
            MethodType.Unary,
            __ServiceName,
            "BatchUpdateControllerRelays",
            __Marshaller_salto_nebula_controller_v1_BatchUpdateControllerRelaysRequest,
            __Marshaller_salto_nebula_controller_v1_BatchUpdateControllerRelaysResponse);

        static readonly Method<DeleteControllerRelayRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteControllerRelay = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteControllerRelay",
            __Marshaller_salto_nebula_controller_v1_DeleteControllerRelayRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<BatchDeleteControllerRelaysRequest, BatchDeleteControllerRelaysResponse> __Method_BatchDeleteControllerRelays = new(
            MethodType.Unary,
            __ServiceName,
            "BatchDeleteControllerRelays",
            __Marshaller_salto_nebula_controller_v1_BatchDeleteControllerRelaysRequest,
            __Marshaller_salto_nebula_controller_v1_BatchDeleteControllerRelaysResponse);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => ControllerReflection.Descriptor.Services[0];}
        /// <summary>Client for ControllerService</summary>
        public partial class ControllerServiceClient : ClientBase<ControllerServiceClient>
        {
            /// <summary>Creates a new client for ControllerService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public ControllerServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for ControllerService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public ControllerServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected ControllerServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected ControllerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Create a controller
            ///
            /// Creates a new controller
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Controller CreateController(CreateControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a controller
            ///
            /// Creates a new controller
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Controller CreateController(CreateControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateController, null, options, request);
            /// <summary>
            /// Create a controller
            ///
            /// Creates a new controller
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Controller> CreateControllerAsync(CreateControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a controller
            ///
            /// Creates a new controller
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Controller> CreateControllerAsync(CreateControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateController, null, options, request);
            /// <summary>
            /// Get a controller
            ///
            /// Gets an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Controller GetController(GetControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a controller
            ///
            /// Gets an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Controller GetController(GetControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetController, null, options, request);
            /// <summary>
            /// Get a controller
            ///
            /// Gets an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Controller> GetControllerAsync(GetControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a controller
            ///
            /// Gets an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Controller> GetControllerAsync(GetControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetController, null, options, request);
            /// <summary>
            /// List controllers
            ///
            /// Returns a list of controllers that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListControllersResponse ListControllers(ListControllersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListControllers(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List controllers
            ///
            /// Returns a list of controllers that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListControllersResponse ListControllers(ListControllersRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListControllers, null, options, request);
            /// <summary>
            /// List controllers
            ///
            /// Returns a list of controllers that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListControllersResponse> ListControllersAsync(ListControllersRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListControllersAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List controllers
            ///
            /// Returns a list of controllers that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListControllersResponse> ListControllersAsync(ListControllersRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListControllers, null, options, request);
            /// <summary>
            /// Update a controller
            ///
            /// Updates an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Controller UpdateController(UpdateControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a controller
            ///
            /// Updates an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Controller UpdateController(UpdateControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateController, null, options, request);
            /// <summary>
            /// Update a controller
            ///
            /// Updates an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Controller> UpdateControllerAsync(UpdateControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a controller
            ///
            /// Updates an existing controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Controller> UpdateControllerAsync(UpdateControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateController, null, options, request);
            /// <summary>
            /// Delete a controller
            ///
            /// Permanently deletes a controller. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteController(DeleteControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a controller
            ///
            /// Permanently deletes a controller. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteController(DeleteControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteController, null, options, request);
            /// <summary>
            /// Delete a controller
            ///
            /// Permanently deletes a controller. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteControllerAsync(DeleteControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a controller
            ///
            /// Permanently deletes a controller. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteControllerAsync(DeleteControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteController, null, options, request);
            /// <summary>
            /// Bind a controller
            ///
            /// Binds a controller. Binding a controller assigns a device
            /// identifier to the controller. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindControllerResponse BindController(BindControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BindController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind a controller
            ///
            /// Binds a controller. Binding a controller assigns a device
            /// identifier to the controller. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindControllerResponse BindController(BindControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BindController, null, options, request);
            /// <summary>
            /// Bind a controller
            ///
            /// Binds a controller. Binding a controller assigns a device
            /// identifier to the controller. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindControllerResponse> BindControllerAsync(BindControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BindControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind a controller
            ///
            /// Binds a controller. Binding a controller assigns a device
            /// identifier to the controller. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindControllerResponse> BindControllerAsync(BindControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BindController, null, options, request);
            /// <summary>
            /// Unbind a controller
            ///
            /// Unbinds a controller. Unbinding a controller removes the
            /// device identifier from the controller. This may be required in some
            /// cases where the controller is not available anymore because, for
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
            public virtual UnbindControllerResponse UnbindController(UnbindControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UnbindController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind a controller
            ///
            /// Unbinds a controller. Unbinding a controller removes the
            /// device identifier from the controller. This may be required in some
            /// cases where the controller is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindControllerResponse UnbindController(UnbindControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnbindController, null, options, request);
            /// <summary>
            /// Unbind a controller
            ///
            /// Unbinds a controller. Unbinding a controller removes the
            /// device identifier from the controller. This may be required in some
            /// cases where the controller is not available anymore because, for
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
            public virtual AsyncUnaryCall<UnbindControllerResponse> UnbindControllerAsync(UnbindControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UnbindControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind a controller
            ///
            /// Unbinds a controller. Unbinding a controller removes the
            /// device identifier from the controller. This may be required in some
            /// cases where the controller is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindControllerResponse> UnbindControllerAsync(UnbindControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UnbindController, null, options, request);
            /// <summary>
            /// Initialize a controller
            ///
            /// Initializes a controller. Controllers need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeController(InitializeControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => InitializeController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize a controller
            ///
            /// Initializes a controller. Controllers need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeController(InitializeControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_InitializeController, null, options, request);
            /// <summary>
            /// Initialize a controller
            ///
            /// Initializes a controller. Controllers need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeControllerAsync(InitializeControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => InitializeControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize a controller
            ///
            /// Initializes a controller. Controllers need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeControllerAsync(InitializeControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_InitializeController, null, options, request);
            /// <summary>
            /// Configure a controller
            ///
            /// Configures a controller. Configuring a controller implies
            /// adding some information to the controller such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureController(ConfigureControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ConfigureController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure a controller
            ///
            /// Configures a controller. Configuring a controller implies
            /// adding some information to the controller such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureController(ConfigureControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ConfigureController, null, options, request);
            /// <summary>
            /// Configure a controller
            ///
            /// Configures a controller. Configuring a controller implies
            /// adding some information to the controller such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureControllerAsync(ConfigureControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ConfigureControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure a controller
            ///
            /// Configures a controller. Configuring a controller implies
            /// adding some information to the controller such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureControllerAsync(ConfigureControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ConfigureController, null, options, request);
            /// <summary>
            /// Reset a controller
            ///
            /// Resetting a device such as a controller means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetController(ResetControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ResetController(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset a controller
            ///
            /// Resetting a device such as a controller means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetController(ResetControllerRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ResetController, null, options, request);
            /// <summary>
            /// Reset a controller
            ///
            /// Resetting a device such as a controller means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetControllerAsync(ResetControllerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ResetControllerAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset a controller
            ///
            /// Resetting a device such as a controller means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetControllerAsync(ResetControllerRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ResetController, null, options, request);
            /// <summary>
            /// Update controller firmware
            ///
            /// Updates a controller's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateControllerFirmware(UpdateControllerFirmwareRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateControllerFirmware(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update controller firmware
            ///
            /// Updates a controller's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateControllerFirmware(UpdateControllerFirmwareRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateControllerFirmware, null, options, request);
            /// <summary>
            /// Update controller firmware
            ///
            /// Updates a controller's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateControllerFirmwareAsync(UpdateControllerFirmwareRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateControllerFirmwareAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update controller firmware
            ///
            /// Updates a controller's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateControllerFirmwareAsync(UpdateControllerFirmwareRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateControllerFirmware, null, options, request);
            /// <summary>
            /// Generates an authorization token for a controller
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateAuthorizationToken(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generates an authorization token for a controller
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generates an authorization token for a controller
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateAuthorizationTokenAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generates an authorization token for a controller
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against a controller.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generate controller firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// controller. The returned URI can be used to bring the controller
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUri(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate controller firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// controller. The returned URI can be used to bring the controller
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Generate controller firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// controller. The returned URI can be used to bring the controller
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUriAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate controller firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// controller. The returned URI can be used to bring the controller
            /// firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Create a controller relay
            ///
            /// Creates a new controller relay
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ControllerRelay CreateControllerRelay(CreateControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateControllerRelay(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a controller relay
            ///
            /// Creates a new controller relay
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ControllerRelay CreateControllerRelay(CreateControllerRelayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateControllerRelay, null, options, request);
            /// <summary>
            /// Create a controller relay
            ///
            /// Creates a new controller relay
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ControllerRelay> CreateControllerRelayAsync(CreateControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateControllerRelayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a controller relay
            ///
            /// Creates a new controller relay
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ControllerRelay> CreateControllerRelayAsync(CreateControllerRelayRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateControllerRelay, null, options, request);
            /// <summary>
            /// Create a batch of controller relays
            ///
            /// Creates a batch of controller relays. This method allows the creation of multiple
            /// controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateControllerRelaysResponse BatchCreateControllerRelays(BatchCreateControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchCreateControllerRelays(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a batch of controller relays
            ///
            /// Creates a batch of controller relays. This method allows the creation of multiple
            /// controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchCreateControllerRelaysResponse BatchCreateControllerRelays(BatchCreateControllerRelaysRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchCreateControllerRelays, null, options, request);
            /// <summary>
            /// Create a batch of controller relays
            ///
            /// Creates a batch of controller relays. This method allows the creation of multiple
            /// controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateControllerRelaysResponse> BatchCreateControllerRelaysAsync(BatchCreateControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchCreateControllerRelaysAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a batch of controller relays
            ///
            /// Creates a batch of controller relays. This method allows the creation of multiple
            /// controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchCreateControllerRelaysResponse> BatchCreateControllerRelaysAsync(BatchCreateControllerRelaysRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchCreateControllerRelays, null, options, request);
            /// <summary>
            /// Get a controller relay
            ///
            /// Gets an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ControllerRelay GetControllerRelay(GetControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetControllerRelay(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a controller relay
            ///
            /// Gets an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ControllerRelay GetControllerRelay(GetControllerRelayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetControllerRelay, null, options, request);
            /// <summary>
            /// Get a controller relay
            ///
            /// Gets an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ControllerRelay> GetControllerRelayAsync(GetControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetControllerRelayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a controller relay
            ///
            /// Gets an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ControllerRelay> GetControllerRelayAsync(GetControllerRelayRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetControllerRelay, null, options, request);
            /// <summary>
            /// List controller relays
            ///
            /// Returns a list of controller relays that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListControllerRelaysResponse ListControllerRelays(ListControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListControllerRelays(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List controller relays
            ///
            /// Returns a list of controller relays that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListControllerRelaysResponse ListControllerRelays(ListControllerRelaysRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListControllerRelays, null, options, request);
            /// <summary>
            /// List controller relays
            ///
            /// Returns a list of controller relays that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListControllerRelaysResponse> ListControllerRelaysAsync(ListControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListControllerRelaysAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List controller relays
            ///
            /// Returns a list of controller relays that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListControllerRelaysResponse> ListControllerRelaysAsync(ListControllerRelaysRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListControllerRelays, null, options, request);
            /// <summary>
            /// Update a controller relay
            ///
            /// Updates an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ControllerRelay UpdateControllerRelay(UpdateControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateControllerRelay(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a controller relay
            ///
            /// Updates an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ControllerRelay UpdateControllerRelay(UpdateControllerRelayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateControllerRelay, null, options, request);
            /// <summary>
            /// Update a controller relay
            ///
            /// Updates an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ControllerRelay> UpdateControllerRelayAsync(UpdateControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateControllerRelayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a controller relay
            ///
            /// Updates an existing controller relay.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ControllerRelay> UpdateControllerRelayAsync(UpdateControllerRelayRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateControllerRelay, null, options, request);
            /// <summary>
            /// Update a batch of controller relays
            ///
            /// Updates a batch of controller relays. This method allows updating multiple controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchUpdateControllerRelaysResponse BatchUpdateControllerRelays(BatchUpdateControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchUpdateControllerRelays(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a batch of controller relays
            ///
            /// Updates a batch of controller relays. This method allows updating multiple controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchUpdateControllerRelaysResponse BatchUpdateControllerRelays(BatchUpdateControllerRelaysRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchUpdateControllerRelays, null, options, request);
            /// <summary>
            /// Update a batch of controller relays
            ///
            /// Updates a batch of controller relays. This method allows updating multiple controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchUpdateControllerRelaysResponse> BatchUpdateControllerRelaysAsync(BatchUpdateControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchUpdateControllerRelaysAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a batch of controller relays
            ///
            /// Updates a batch of controller relays. This method allows updating multiple controller relays in a single operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchUpdateControllerRelaysResponse> BatchUpdateControllerRelaysAsync(BatchUpdateControllerRelaysRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchUpdateControllerRelays, null, options, request);
            /// <summary>
            /// Delete a controller relay
            ///
            /// Permanently deletes a controller relay. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteControllerRelay(DeleteControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteControllerRelay(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a controller relay
            ///
            /// Permanently deletes a controller relay. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteControllerRelay(DeleteControllerRelayRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteControllerRelay, null, options, request);
            /// <summary>
            /// Delete a controller relay
            ///
            /// Permanently deletes a controller relay. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteControllerRelayAsync(DeleteControllerRelayRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteControllerRelayAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a controller relay
            ///
            /// Permanently deletes a controller relay. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteControllerRelayAsync(DeleteControllerRelayRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteControllerRelay, null, options, request);
            /// <summary>
            /// Delete a batch of controller relays
            ///
            /// Permanently deletes a batch of controller relays. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteControllerRelaysResponse BatchDeleteControllerRelays(BatchDeleteControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchDeleteControllerRelays(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a batch of controller relays
            ///
            /// Permanently deletes a batch of controller relays. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchDeleteControllerRelaysResponse BatchDeleteControllerRelays(BatchDeleteControllerRelaysRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchDeleteControllerRelays, null, options, request);
            /// <summary>
            /// Delete a batch of controller relays
            ///
            /// Permanently deletes a batch of controller relays. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteControllerRelaysResponse> BatchDeleteControllerRelaysAsync(BatchDeleteControllerRelaysRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchDeleteControllerRelaysAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a batch of controller relays
            ///
            /// Permanently deletes a batch of controller relays. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchDeleteControllerRelaysResponse> BatchDeleteControllerRelaysAsync(BatchDeleteControllerRelaysRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchDeleteControllerRelays, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override ControllerServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}