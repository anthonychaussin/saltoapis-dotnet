using Saltoapis.Nebula.Event.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.Event.V1.Response;

namespace Saltoapis.Nebula.Event.V1
{
    /// <summary>
    /// Events allow you to see activity, such as an access point opening, that is
    /// taking place within an installation. This service is responsible for managing
    /// event resources.
    /// </summary>
    public static partial class EventService
    {
        static readonly string __ServiceName = "salto.nebula.event.v1.EventService";

        static readonly Marshaller<GetEventRequest> __Marshaller_salto_nebula_event_v1_GetEventRequest = GrpcMessageHelper.CreateMarshaller(GetEventRequest.Parser);

        static readonly Marshaller<Event> __Marshaller_salto_nebula_event_v1_Event = GrpcMessageHelper.CreateMarshaller(Event.Parser);

        static readonly Marshaller<ListEventsRequest> __Marshaller_salto_nebula_event_v1_ListEventsRequest = GrpcMessageHelper.CreateMarshaller(ListEventsRequest.Parser);

        static readonly Marshaller<ListEventsResponse> __Marshaller_salto_nebula_event_v1_ListEventsResponse = GrpcMessageHelper.CreateMarshaller(ListEventsResponse.Parser);

        static readonly Method<GetEventRequest, Event> __Method_GetEvent = new(
            MethodType.Unary,
            __ServiceName,
            "GetEvent",
            __Marshaller_salto_nebula_event_v1_GetEventRequest,
            __Marshaller_salto_nebula_event_v1_Event);

        static readonly Method<ListEventsRequest, ListEventsResponse> __Method_ListEvents = new(
            MethodType.Unary,
            __ServiceName,
            "ListEvents",
            __Marshaller_salto_nebula_event_v1_ListEventsRequest,
            __Marshaller_salto_nebula_event_v1_ListEventsResponse);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => EventReflection.Descriptor.Services[0];}
        /// <summary>Client for EventService</summary>
        public partial class EventServiceClient : ClientBase<EventServiceClient>
        {
            /// <summary>Creates a new client for EventService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public EventServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for EventService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public EventServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected EventServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected EventServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Get an event
            ///
            /// Gets an existing event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event GetEvent(GetEventRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetEvent(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an event
            ///
            /// Gets an existing event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event GetEvent(GetEventRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetEvent, null, options, request);
            /// <summary>
            /// Get an event
            ///
            /// Gets an existing event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> GetEventAsync(GetEventRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => GetEventAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an event
            ///
            /// Gets an existing event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> GetEventAsync(GetEventRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_GetEvent, null, options, request);
            /// <summary>
            /// List events
            ///
            /// Returns a list of events that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEventsResponse ListEvents(ListEventsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListEvents(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List events
            ///
            /// Returns a list of events that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEventsResponse ListEvents(ListEventsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListEvents, null, options, request);
            /// <summary>
            /// List events
            ///
            /// Returns a list of events that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEventsResponse> ListEventsAsync(ListEventsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => ListEventsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List events
            ///
            /// Returns a list of events that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEventsResponse> ListEventsAsync(ListEventsRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_ListEvents, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override EventServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}