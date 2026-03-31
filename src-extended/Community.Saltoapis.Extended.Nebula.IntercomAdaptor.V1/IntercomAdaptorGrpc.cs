using Saltoapis.Nebula.IntercomAdaptor.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.IntercomAdaptor.V1.Response;

namespace Saltoapis.Nebula.IntercomAdaptor.V1
{
    /// <summary>
    /// An intercom adaptor is a device that can be connected to an existing intercom
    /// system close to the telephone handset, without affecting its proper
    /// functioning. Its main function is to convert the intercom system to become
    /// part of the access control system.
    /// </summary>
    public static partial class IntercomAdaptorService
    {
        static readonly string __ServiceName = "salto.nebula.intercomadaptor.v1.IntercomAdaptorService";

        static readonly Marshaller<CreateIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_CreateIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(CreateIntercomAdaptorRequest.Parser);

        static readonly Marshaller<IntercomAdaptor> __Marshaller_salto_nebula_intercomadaptor_v1_IntercomAdaptor = GrpcMessageHelper.CreateMarshaller(IntercomAdaptor.Parser);

        static readonly Marshaller<GetIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_GetIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(GetIntercomAdaptorRequest.Parser);

        static readonly Marshaller<ListIntercomAdaptorsRequest> __Marshaller_salto_nebula_intercomadaptor_v1_ListIntercomAdaptorsRequest = GrpcMessageHelper.CreateMarshaller(ListIntercomAdaptorsRequest.Parser);

        static readonly Marshaller<ListIntercomAdaptorsResponse> __Marshaller_salto_nebula_intercomadaptor_v1_ListIntercomAdaptorsResponse = GrpcMessageHelper.CreateMarshaller(ListIntercomAdaptorsResponse.Parser);

        static readonly Marshaller<UpdateIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_UpdateIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(UpdateIntercomAdaptorRequest.Parser);

        static readonly Marshaller<DeleteIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_DeleteIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(DeleteIntercomAdaptorRequest.Parser);

        static readonly Marshaller<BindIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_BindIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(BindIntercomAdaptorRequest.Parser);

        static readonly Marshaller<BindIntercomAdaptorResponse> __Marshaller_salto_nebula_intercomadaptor_v1_BindIntercomAdaptorResponse = GrpcMessageHelper.CreateMarshaller(BindIntercomAdaptorResponse.Parser);

        static readonly Marshaller<UnbindIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_UnbindIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(UnbindIntercomAdaptorRequest.Parser);

        static readonly Marshaller<UnbindIntercomAdaptorResponse> __Marshaller_salto_nebula_intercomadaptor_v1_UnbindIntercomAdaptorResponse = GrpcMessageHelper.CreateMarshaller(UnbindIntercomAdaptorResponse.Parser);

        static readonly Marshaller<InitializeIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_InitializeIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(InitializeIntercomAdaptorRequest.Parser);

        static readonly Marshaller<Longrunning.V1.Operation> __Marshaller_salto_longrunning_v1_Operation = GrpcMessageHelper.CreateMarshaller(Longrunning.V1.Operation.Parser);

        static readonly Marshaller<ConfigureIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_ConfigureIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(ConfigureIntercomAdaptorRequest.Parser);

        static readonly Marshaller<ResetIntercomAdaptorRequest> __Marshaller_salto_nebula_intercomadaptor_v1_ResetIntercomAdaptorRequest = GrpcMessageHelper.CreateMarshaller(ResetIntercomAdaptorRequest.Parser);

        static readonly Marshaller<UpdateIntercomAdaptorFirmwareRequest> __Marshaller_salto_nebula_intercomadaptor_v1_UpdateIntercomAdaptorFirmwareRequest = GrpcMessageHelper.CreateMarshaller(UpdateIntercomAdaptorFirmwareRequest.Parser);

        static readonly Marshaller<GenerateAuthorizationTokenRequest> __Marshaller_salto_nebula_intercomadaptor_v1_GenerateAuthorizationTokenRequest = GrpcMessageHelper.CreateMarshaller(GenerateAuthorizationTokenRequest.Parser);

        static readonly Marshaller<GenerateAuthorizationTokenResponse> __Marshaller_salto_nebula_intercomadaptor_v1_GenerateAuthorizationTokenResponse = GrpcMessageHelper.CreateMarshaller(GenerateAuthorizationTokenResponse.Parser);

        static readonly Marshaller<GenerateFirmwareDownloadUriRequest> __Marshaller_salto_nebula_intercomadaptor_v1_GenerateFirmwareDownloadUriRequest = GrpcMessageHelper.CreateMarshaller(GenerateFirmwareDownloadUriRequest.Parser);

        static readonly Method<CreateIntercomAdaptorRequest, IntercomAdaptor> __Method_CreateIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "CreateIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_CreateIntercomAdaptorRequest,
            __Marshaller_salto_nebula_intercomadaptor_v1_IntercomAdaptor);

        static readonly Method<GetIntercomAdaptorRequest, IntercomAdaptor> __Method_GetIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "GetIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_GetIntercomAdaptorRequest,
            __Marshaller_salto_nebula_intercomadaptor_v1_IntercomAdaptor);

        static readonly Method<ListIntercomAdaptorsRequest, ListIntercomAdaptorsResponse> __Method_ListIntercomAdaptors = new(
            MethodType.Unary,
            __ServiceName,
            "ListIntercomAdaptors",
            __Marshaller_salto_nebula_intercomadaptor_v1_ListIntercomAdaptorsRequest,
            __Marshaller_salto_nebula_intercomadaptor_v1_ListIntercomAdaptorsResponse);

        static readonly Method<UpdateIntercomAdaptorRequest, IntercomAdaptor> __Method_UpdateIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_UpdateIntercomAdaptorRequest,
            __Marshaller_salto_nebula_intercomadaptor_v1_IntercomAdaptor);

        static readonly Method<DeleteIntercomAdaptorRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_DeleteIntercomAdaptorRequest,
            GrpcMessageHelper.EmptyMarshaller);

        static readonly Method<BindIntercomAdaptorRequest, BindIntercomAdaptorResponse> __Method_BindIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "BindIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_BindIntercomAdaptorRequest,
            __Marshaller_salto_nebula_intercomadaptor_v1_BindIntercomAdaptorResponse);

        static readonly Method<UnbindIntercomAdaptorRequest, UnbindIntercomAdaptorResponse> __Method_UnbindIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "UnbindIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_UnbindIntercomAdaptorRequest,
            __Marshaller_salto_nebula_intercomadaptor_v1_UnbindIntercomAdaptorResponse);

        static readonly Method<InitializeIntercomAdaptorRequest, Longrunning.V1.Operation> __Method_InitializeIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "InitializeIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_InitializeIntercomAdaptorRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ConfigureIntercomAdaptorRequest, Longrunning.V1.Operation> __Method_ConfigureIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "ConfigureIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_ConfigureIntercomAdaptorRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ResetIntercomAdaptorRequest, Longrunning.V1.Operation> __Method_ResetIntercomAdaptor = new(
            MethodType.Unary,
            __ServiceName,
            "ResetIntercomAdaptor",
            __Marshaller_salto_nebula_intercomadaptor_v1_ResetIntercomAdaptorRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<UpdateIntercomAdaptorFirmwareRequest, Longrunning.V1.Operation> __Method_UpdateIntercomAdaptorFirmware = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateIntercomAdaptorFirmware",
            __Marshaller_salto_nebula_intercomadaptor_v1_UpdateIntercomAdaptorFirmwareRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<GenerateAuthorizationTokenRequest, GenerateAuthorizationTokenResponse> __Method_GenerateAuthorizationToken = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateAuthorizationToken",
            __Marshaller_salto_nebula_intercomadaptor_v1_GenerateAuthorizationTokenRequest,
            __Marshaller_salto_nebula_intercomadaptor_v1_GenerateAuthorizationTokenResponse);

        static readonly Method<GenerateFirmwareDownloadUriRequest, Longrunning.V1.Operation> __Method_GenerateFirmwareDownloadUri = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateFirmwareDownloadUri",
            __Marshaller_salto_nebula_intercomadaptor_v1_GenerateFirmwareDownloadUriRequest,
            __Marshaller_salto_longrunning_v1_Operation);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => IntercomAdaptorReflection.Descriptor.Services[0];}
        /// <summary>Client for IntercomAdaptorService</summary>
        public partial class IntercomAdaptorServiceClient : ClientBase<IntercomAdaptorServiceClient>
        {
            /// <summary>Creates a new client for IntercomAdaptorService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public IntercomAdaptorServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for IntercomAdaptorService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public IntercomAdaptorServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected IntercomAdaptorServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected IntercomAdaptorServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Create an intercom adaptor
            ///
            /// Creates a new intercom adaptor
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IntercomAdaptor CreateIntercomAdaptor(CreateIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an intercom adaptor
            ///
            /// Creates a new intercom adaptor
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IntercomAdaptor CreateIntercomAdaptor(CreateIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateIntercomAdaptor, null, options, request);
            /// <summary>
            /// Create an intercom adaptor
            ///
            /// Creates a new intercom adaptor
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IntercomAdaptor> CreateIntercomAdaptorAsync(CreateIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an intercom adaptor
            ///
            /// Creates a new intercom adaptor
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IntercomAdaptor> CreateIntercomAdaptorAsync(CreateIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateIntercomAdaptor, null, options, request);
            /// <summary>
            /// Get an intercom adaptor
            ///
            /// Gets an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IntercomAdaptor GetIntercomAdaptor(GetIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an intercom adaptor
            ///
            /// Gets an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IntercomAdaptor GetIntercomAdaptor(GetIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetIntercomAdaptor, null, options, request);
            /// <summary>
            /// Get an intercom adaptor
            ///
            /// Gets an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IntercomAdaptor> GetIntercomAdaptorAsync(GetIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an intercom adaptor
            ///
            /// Gets an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IntercomAdaptor> GetIntercomAdaptorAsync(GetIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetIntercomAdaptor, null, options, request);
            /// <summary>
            /// List intercom adaptors
            ///
            /// Returns a list of intercom adaptors that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListIntercomAdaptorsResponse ListIntercomAdaptors(ListIntercomAdaptorsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListIntercomAdaptors(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List intercom adaptors
            ///
            /// Returns a list of intercom adaptors that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListIntercomAdaptorsResponse ListIntercomAdaptors(ListIntercomAdaptorsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListIntercomAdaptors, null, options, request);
            /// <summary>
            /// List intercom adaptors
            ///
            /// Returns a list of intercom adaptors that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListIntercomAdaptorsResponse> ListIntercomAdaptorsAsync(ListIntercomAdaptorsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListIntercomAdaptorsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List intercom adaptors
            ///
            /// Returns a list of intercom adaptors that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListIntercomAdaptorsResponse> ListIntercomAdaptorsAsync(ListIntercomAdaptorsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListIntercomAdaptors, null, options, request);
            /// <summary>
            /// Update an intercom adaptor
            ///
            /// Updates an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IntercomAdaptor UpdateIntercomAdaptor(UpdateIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an intercom adaptor
            ///
            /// Updates an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual IntercomAdaptor UpdateIntercomAdaptor(UpdateIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateIntercomAdaptor, null, options, request);
            /// <summary>
            /// Update an intercom adaptor
            ///
            /// Updates an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IntercomAdaptor> UpdateIntercomAdaptorAsync(UpdateIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an intercom adaptor
            ///
            /// Updates an existing intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<IntercomAdaptor> UpdateIntercomAdaptorAsync(UpdateIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateIntercomAdaptor, null, options, request);
            /// <summary>
            /// Delete an intercom adaptor
            ///
            /// Permanently deletes an intercom adaptor. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteIntercomAdaptor(DeleteIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an intercom adaptor
            ///
            /// Permanently deletes an intercom adaptor. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteIntercomAdaptor(DeleteIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteIntercomAdaptor, null, options, request);
            /// <summary>
            /// Delete an intercom adaptor
            ///
            /// Permanently deletes an intercom adaptor. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteIntercomAdaptorAsync(DeleteIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an intercom adaptor
            ///
            /// Permanently deletes an intercom adaptor. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteIntercomAdaptorAsync(DeleteIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteIntercomAdaptor, null, options, request);
            /// <summary>
            /// Bind an intercom adaptor
            ///
            /// Binds an intercom adaptor. Binding an intercom adaptor assigns a device
            /// identifier to the intercom adaptor. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindIntercomAdaptorResponse BindIntercomAdaptor(BindIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BindIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind an intercom adaptor
            ///
            /// Binds an intercom adaptor. Binding an intercom adaptor assigns a device
            /// identifier to the intercom adaptor. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BindIntercomAdaptorResponse BindIntercomAdaptor(BindIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BindIntercomAdaptor, null, options, request);
            /// <summary>
            /// Bind an intercom adaptor
            ///
            /// Binds an intercom adaptor. Binding an intercom adaptor assigns a device
            /// identifier to the intercom adaptor. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindIntercomAdaptorResponse> BindIntercomAdaptorAsync(BindIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BindIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Bind an intercom adaptor
            ///
            /// Binds an intercom adaptor. Binding an intercom adaptor assigns a device
            /// identifier to the intercom adaptor. After binding, the device can then be
            /// initialized or configured.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BindIntercomAdaptorResponse> BindIntercomAdaptorAsync(BindIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BindIntercomAdaptor, null, options, request);
            /// <summary>
            /// Unbind an intercom adaptor
            ///
            /// Unbinds an intercom adaptor. Unbinding an intercom adaptor removes the
            /// device identifier from the intercom adaptor. This may be required in some
            /// cases where the intercom adaptor is not available anymore because, for
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
            public virtual UnbindIntercomAdaptorResponse UnbindIntercomAdaptor(UnbindIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UnbindIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind an intercom adaptor
            ///
            /// Unbinds an intercom adaptor. Unbinding an intercom adaptor removes the
            /// device identifier from the intercom adaptor. This may be required in some
            /// cases where the intercom adaptor is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnbindIntercomAdaptorResponse UnbindIntercomAdaptor(UnbindIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnbindIntercomAdaptor, null, options, request);
            /// <summary>
            /// Unbind an intercom adaptor
            ///
            /// Unbinds an intercom adaptor. Unbinding an intercom adaptor removes the
            /// device identifier from the intercom adaptor. This may be required in some
            /// cases where the intercom adaptor is not available anymore because, for
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
            public virtual AsyncUnaryCall<UnbindIntercomAdaptorResponse> UnbindIntercomAdaptorAsync(UnbindIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UnbindIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unbind an intercom adaptor
            ///
            /// Unbinds an intercom adaptor. Unbinding an intercom adaptor removes the
            /// device identifier from the intercom adaptor. This may be required in some
            /// cases where the intercom adaptor is not available anymore because, for
            /// example, it's broken or damaged. Unbinding allows the initialization of
            /// the replacement device without removing it from the installation. It also
            /// means the device keeps all the information associated with it, such as
            /// events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnbindIntercomAdaptorResponse> UnbindIntercomAdaptorAsync(UnbindIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UnbindIntercomAdaptor, null, options, request);
            /// <summary>
            /// Initialize an intercom adaptor
            ///
            /// Initializes an intercom adaptor. Intercom adaptors need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeIntercomAdaptor(InitializeIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => InitializeIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize an intercom adaptor
            ///
            /// Initializes an intercom adaptor. Intercom adaptors need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation InitializeIntercomAdaptor(InitializeIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_InitializeIntercomAdaptor, null, options, request);
            /// <summary>
            /// Initialize an intercom adaptor
            ///
            /// Initializes an intercom adaptor. Intercom adaptors need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeIntercomAdaptorAsync(InitializeIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => InitializeIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Initialize an intercom adaptor
            ///
            /// Initializes an intercom adaptor. Intercom adaptors need to be initialized
            /// before you can start to use them.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> InitializeIntercomAdaptorAsync(InitializeIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_InitializeIntercomAdaptor, null, options, request);
            /// <summary>
            /// Configure an intercom adaptor
            ///
            /// Configures an intercom adaptor. Configuring an intercom adaptor implies
            /// adding some information to the intercom adaptor such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureIntercomAdaptor(ConfigureIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ConfigureIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure an intercom adaptor
            ///
            /// Configures an intercom adaptor. Configuring an intercom adaptor implies
            /// adding some information to the intercom adaptor such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ConfigureIntercomAdaptor(ConfigureIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ConfigureIntercomAdaptor, null, options, request);
            /// <summary>
            /// Configure an intercom adaptor
            ///
            /// Configures an intercom adaptor. Configuring an intercom adaptor implies
            /// adding some information to the intercom adaptor such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureIntercomAdaptorAsync(ConfigureIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ConfigureIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Configure an intercom adaptor
            ///
            /// Configures an intercom adaptor. Configuring an intercom adaptor implies
            /// adding some information to the intercom adaptor such as setting the time
            /// zone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ConfigureIntercomAdaptorAsync(ConfigureIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ConfigureIntercomAdaptor, null, options, request);
            /// <summary>
            /// Reset an intercom adaptor
            ///
            /// Resetting a device such as an intercom adaptor means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetIntercomAdaptor(ResetIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ResetIntercomAdaptor(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset an intercom adaptor
            ///
            /// Resetting a device such as an intercom adaptor means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation ResetIntercomAdaptor(ResetIntercomAdaptorRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ResetIntercomAdaptor, null, options, request);
            /// <summary>
            /// Reset an intercom adaptor
            ///
            /// Resetting a device such as an intercom adaptor means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetIntercomAdaptorAsync(ResetIntercomAdaptorRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ResetIntercomAdaptorAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Reset an intercom adaptor
            ///
            /// Resetting a device such as an intercom adaptor means returning it to its
            /// factory settings. Resetting is the process of removing the identity as
            /// well as all the associated information of an already configured device.
            /// Once a device has been reset, you need to reconfigure it.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> ResetIntercomAdaptorAsync(ResetIntercomAdaptorRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ResetIntercomAdaptor, null, options, request);
            /// <summary>
            /// Update intercom adaptor firmware
            ///
            /// Updates an intercom adaptor's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateIntercomAdaptorFirmware(UpdateIntercomAdaptorFirmwareRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateIntercomAdaptorFirmware(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update intercom adaptor firmware
            ///
            /// Updates an intercom adaptor's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation UpdateIntercomAdaptorFirmware(UpdateIntercomAdaptorFirmwareRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateIntercomAdaptorFirmware, null, options, request);
            /// <summary>
            /// Update intercom adaptor firmware
            ///
            /// Updates an intercom adaptor's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateIntercomAdaptorFirmwareAsync(UpdateIntercomAdaptorFirmwareRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateIntercomAdaptorFirmwareAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update intercom adaptor firmware
            ///
            /// Updates an intercom adaptor's firmware. SALTO provides firmware updates
            /// when new functionality is available or when we fix a bug.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> UpdateIntercomAdaptorFirmwareAsync(UpdateIntercomAdaptorFirmwareRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateIntercomAdaptorFirmware, null, options, request);
            /// <summary>
            /// Generates an authorization token for an intercom adaptor
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateAuthorizationToken(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generates an authorization token for an intercom adaptor
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generates an authorization token for an intercom adaptor
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateAuthorizationTokenAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generates an authorization token for an intercom adaptor
            ///
            /// Generates an authorization token that allows to connect, authenticate and
            /// authorize against an intercom adaptor.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generate intercom adaptor firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// intercom adaptor. The returned URI can be used to bring the intercom
            /// adaptor firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUri(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate intercom adaptor firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// intercom adaptor. The returned URI can be used to bring the intercom
            /// adaptor firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Longrunning.V1.Operation GenerateFirmwareDownloadUri(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>
            /// Generate intercom adaptor firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// intercom adaptor. The returned URI can be used to bring the intercom
            /// adaptor firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GenerateFirmwareDownloadUriAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate intercom adaptor firmware download URI
            ///
            /// Provides the download URI for the latest firmware bundle for the
            /// intercom adaptor. The returned URI can be used to bring the intercom
            /// adaptor firmwares up to latest.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Longrunning.V1.Operation> GenerateFirmwareDownloadUriAsync(GenerateFirmwareDownloadUriRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GenerateFirmwareDownloadUri, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override IntercomAdaptorServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}