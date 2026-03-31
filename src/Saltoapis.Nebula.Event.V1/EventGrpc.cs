using Grpc.Core;
using Saltoapis.Nebula.Event.V1.Request;
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

        static void __Helper_SerializeMessage(Google.Protobuf.IMessage message, SerializationContext context)
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (message is Google.Protobuf.IBufferMessage)
            {
                context.SetPayloadLength(message.CalculateSize());
                Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
                context.Complete();
                return;
            }
#endif
            context.Complete(Google.Protobuf.MessageExtensions.ToByteArray(message));
        }

        static class __Helper_MessageCache<T>
        {
            public static readonly bool IsBufferMessage = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
        }

        static T __Helper_DeserializeMessage<T>(DeserializationContext context, Google.Protobuf.MessageParser<T> parser) where T : Google.Protobuf.IMessage<T>
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (__Helper_MessageCache<T>.IsBufferMessage) return parser.ParseFrom(context.PayloadAsReadOnlySequence());
#endif
            return parser.ParseFrom(context.PayloadAsNewBuffer());
        }

        static readonly Marshaller<GetEventRequest> __Marshaller_salto_nebula_event_v1_GetEventRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetEventRequest.Parser));

        static readonly Marshaller<Event> __Marshaller_salto_nebula_event_v1_Event = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Event.Parser));

        static readonly Marshaller<ListEventsRequest> __Marshaller_salto_nebula_event_v1_ListEventsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEventsRequest.Parser));

        static readonly Marshaller<ListEventsResponse> __Marshaller_salto_nebula_event_v1_ListEventsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEventsResponse.Parser));

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
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return EventReflection.Descriptor.Services[0]; }
        }

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
            public virtual Event GetEvent(GetEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetEvent(request, new CallOptions(headers, deadline, cancellationToken));
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
            public virtual AsyncUnaryCall<Event> GetEventAsync(GetEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetEventAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an event
            ///
            /// Gets an existing event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> GetEventAsync(GetEventRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetEvent, null, options, request);
            }

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
            public virtual ListEventsResponse ListEvents(ListEventsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListEvents(request, new CallOptions(headers, deadline, cancellationToken));
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
            public virtual AsyncUnaryCall<ListEventsResponse> ListEventsAsync(ListEventsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListEventsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List events
            ///
            /// Returns a list of events that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEventsResponse> ListEventsAsync(ListEventsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListEvents, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override EventServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
