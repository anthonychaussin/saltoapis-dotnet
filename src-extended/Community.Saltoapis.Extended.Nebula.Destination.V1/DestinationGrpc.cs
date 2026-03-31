using Saltoapis.Nebula.Destination.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.Destination.V1.Response;

namespace Saltoapis.Nebula.Destination.V1
{
    /// <summary>
    /// DestinationService is the service responsible for managing destination resources.
    /// Destinations refer to feature where a controller with multiple relays can activate
    /// different outputs based on keys and schedules. The primary use case is elevator control,
    /// where presenting a credential at a reader would activate only the buttons for floors
    /// the user has access to.
    /// </summary>
    public static partial class DestinationService
    {
        static readonly string __ServiceName = "salto.nebula.destination.v1.DestinationService";

        static readonly Marshaller<CreateDestinationRequest> __Marshaller_salto_nebula_destination_v1_CreateDestinationRequest = GrpcMessageHelper.CreateMarshaller(CreateDestinationRequest.Parser);

        static readonly Marshaller<Destination> __Marshaller_salto_nebula_destination_v1_Destination = GrpcMessageHelper.CreateMarshaller(Destination.Parser);

        static readonly Marshaller<GetDestinationRequest> __Marshaller_salto_nebula_destination_v1_GetDestinationRequest = GrpcMessageHelper.CreateMarshaller(GetDestinationRequest.Parser);

        static readonly Marshaller<BatchGetDestinationsRequest> __Marshaller_salto_nebula_destination_v1_BatchGetDestinationsRequest = GrpcMessageHelper.CreateMarshaller(BatchGetDestinationsRequest.Parser);

        static readonly Marshaller<BatchGetDestinationsResponse> __Marshaller_salto_nebula_destination_v1_BatchGetDestinationsResponse = GrpcMessageHelper.CreateMarshaller(BatchGetDestinationsResponse.Parser);

        static readonly Marshaller<UpdateDestinationRequest> __Marshaller_salto_nebula_destination_v1_UpdateDestinationRequest = GrpcMessageHelper.CreateMarshaller(UpdateDestinationRequest.Parser);

        static readonly Marshaller<ListDestinationsRequest> __Marshaller_salto_nebula_destination_v1_ListDestinationsRequest = GrpcMessageHelper.CreateMarshaller(ListDestinationsRequest.Parser);

        static readonly Marshaller<ListDestinationsResponse> __Marshaller_salto_nebula_destination_v1_ListDestinationsResponse = GrpcMessageHelper.CreateMarshaller(ListDestinationsResponse.Parser);

        static readonly Marshaller<DeleteDestinationRequest> __Marshaller_salto_nebula_destination_v1_DeleteDestinationRequest = GrpcMessageHelper.CreateMarshaller(DeleteDestinationRequest.Parser);

        static readonly Method<CreateDestinationRequest, Destination> __Method_CreateDestination = new(
            MethodType.Unary,
            __ServiceName,
            "CreateDestination",
            __Marshaller_salto_nebula_destination_v1_CreateDestinationRequest,
            __Marshaller_salto_nebula_destination_v1_Destination);

        static readonly Method<GetDestinationRequest, Destination> __Method_GetDestination = new(
            MethodType.Unary,
            __ServiceName,
            "GetDestination",
            __Marshaller_salto_nebula_destination_v1_GetDestinationRequest,
            __Marshaller_salto_nebula_destination_v1_Destination);

        static readonly Method<BatchGetDestinationsRequest, BatchGetDestinationsResponse> __Method_BatchGetDestinations = new(
            MethodType.Unary,
            __ServiceName,
            "BatchGetDestinations",
            __Marshaller_salto_nebula_destination_v1_BatchGetDestinationsRequest,
            __Marshaller_salto_nebula_destination_v1_BatchGetDestinationsResponse);

        static readonly Method<UpdateDestinationRequest, Destination> __Method_UpdateDestination = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateDestination",
            __Marshaller_salto_nebula_destination_v1_UpdateDestinationRequest,
            __Marshaller_salto_nebula_destination_v1_Destination);

        static readonly Method<ListDestinationsRequest, ListDestinationsResponse> __Method_ListDestinations = new(
            MethodType.Unary,
            __ServiceName,
            "ListDestinations",
            __Marshaller_salto_nebula_destination_v1_ListDestinationsRequest,
            __Marshaller_salto_nebula_destination_v1_ListDestinationsResponse);

        static readonly Method<DeleteDestinationRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteDestination = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteDestination",
            __Marshaller_salto_nebula_destination_v1_DeleteDestinationRequest,
            GrpcMessageHelper.EmptyMarshaller);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => DestinationReflection.Descriptor.Services[0];}
        /// <summary>Client for DestinationService</summary>
        public partial class DestinationServiceClient : ClientBase<DestinationServiceClient>
        {
            /// <summary>Creates a new client for DestinationService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public DestinationServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for DestinationService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public DestinationServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected DestinationServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected DestinationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Create a destination
            ///
            /// Creates a new destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Destination CreateDestination(CreateDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a destination
            ///
            /// Creates a new destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Destination CreateDestination(CreateDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateDestination, null, options, request);
            /// <summary>
            /// Create a destination
            ///
            /// Creates a new destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Destination> CreateDestinationAsync(CreateDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a destination
            ///
            /// Creates a new destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Destination> CreateDestinationAsync(CreateDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateDestination, null, options, request);
            /// <summary>
            /// Get an existing destination
            ///
            /// Retrieves an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Destination GetDestination(GetDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an existing destination
            ///
            /// Retrieves an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Destination GetDestination(GetDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetDestination, null, options, request);
            /// <summary>
            /// Get an existing destination
            ///
            /// Retrieves an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Destination> GetDestinationAsync(GetDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an existing destination
            ///
            /// Retrieves an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Destination> GetDestinationAsync(GetDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetDestination, null, options, request);
            /// <summary>
            /// Get a batch of destinations
            ///
            /// Retrieves a batch of existing destinations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchGetDestinationsResponse BatchGetDestinations(BatchGetDestinationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchGetDestinations(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a batch of destinations
            ///
            /// Retrieves a batch of existing destinations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BatchGetDestinationsResponse BatchGetDestinations(BatchGetDestinationsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_BatchGetDestinations, null, options, request);
            /// <summary>
            /// Get a batch of destinations
            ///
            /// Retrieves a batch of existing destinations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchGetDestinationsResponse> BatchGetDestinationsAsync(BatchGetDestinationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => BatchGetDestinationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a batch of destinations
            ///
            /// Retrieves a batch of existing destinations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BatchGetDestinationsResponse> BatchGetDestinationsAsync(BatchGetDestinationsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_BatchGetDestinations, null, options, request);
            /// <summary>
            /// Update an existing destination
            ///
            /// Updates an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Destination UpdateDestination(UpdateDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an existing destination
            ///
            /// Updates an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Destination UpdateDestination(UpdateDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateDestination, null, options, request);
            /// <summary>
            /// Update an existing destination
            ///
            /// Updates an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Destination> UpdateDestinationAsync(UpdateDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => UpdateDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an existing destination
            ///
            /// Updates an existing destination.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Destination> UpdateDestinationAsync(UpdateDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_UpdateDestination, null, options, request);
            /// <summary>
            /// List destinations
            ///
            /// Returns a list of destinations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDestinationsResponse ListDestinations(ListDestinationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListDestinations(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List destinations
            ///
            /// Returns a list of destinations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDestinationsResponse ListDestinations(ListDestinationsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListDestinations, null, options, request);
            /// <summary>
            /// List destinations
            ///
            /// Returns a list of destinations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListDestinationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List destinations
            ///
            /// Returns a list of destinations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListDestinations, null, options, request);
            /// <summary>
            /// Delete a destination
            ///
            /// Permanently deletes a destination. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteDestination(DeleteDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteDestination(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a destination
            ///
            /// Permanently deletes a destination. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteDestination(DeleteDestinationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteDestination, null, options, request);
            /// <summary>
            /// Delete a destination
            ///
            /// Permanently deletes a destination. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteDestinationAsync(DeleteDestinationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => DeleteDestinationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a destination
            ///
            /// Permanently deletes a destination. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteDestinationAsync(DeleteDestinationRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_DeleteDestination, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override DestinationServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}