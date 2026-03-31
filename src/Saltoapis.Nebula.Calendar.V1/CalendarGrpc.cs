using Grpc.Core;

namespace Saltoapis.Nebula.Calendar.V1
{
    /// <summary>
    /// The calendar functionality defines your organization's working calendar.
    /// For example, you can define public holidays, company holidays and company
    /// shutdowns. This service is responsible for managing calendar resources.
    /// </summary>
    public static partial class CalendarService
    {
        static readonly string __ServiceName = "salto.nebula.calendar.v1.CalendarService";

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

        static readonly Marshaller<CreateCalendarRequest> __Marshaller_salto_nebula_calendar_v1_CreateCalendarRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateCalendarRequest.Parser));

        static readonly Marshaller<Calendar> __Marshaller_salto_nebula_calendar_v1_Calendar = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Calendar.Parser));

        static readonly Marshaller<GetCalendarRequest> __Marshaller_salto_nebula_calendar_v1_GetCalendarRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetCalendarRequest.Parser));

        static readonly Marshaller<ListCalendarsRequest> __Marshaller_salto_nebula_calendar_v1_ListCalendarsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListCalendarsRequest.Parser));

        static readonly Marshaller<ListCalendarsResponse> __Marshaller_salto_nebula_calendar_v1_ListCalendarsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListCalendarsResponse.Parser));

        static readonly Marshaller<UpdateCalendarRequest> __Marshaller_salto_nebula_calendar_v1_UpdateCalendarRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateCalendarRequest.Parser));

        static readonly Marshaller<DeleteCalendarRequest> __Marshaller_salto_nebula_calendar_v1_DeleteCalendarRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteCalendarRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<CreateEventRequest> __Marshaller_salto_nebula_calendar_v1_CreateEventRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateEventRequest.Parser));

        static readonly Marshaller<Event> __Marshaller_salto_nebula_calendar_v1_Event = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Event.Parser));

        static readonly Marshaller<GetEventRequest> __Marshaller_salto_nebula_calendar_v1_GetEventRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetEventRequest.Parser));

        static readonly Marshaller<ListEventsRequest> __Marshaller_salto_nebula_calendar_v1_ListEventsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEventsRequest.Parser));

        static readonly Marshaller<ListEventsResponse> __Marshaller_salto_nebula_calendar_v1_ListEventsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEventsResponse.Parser));

        static readonly Marshaller<UpdateEventRequest> __Marshaller_salto_nebula_calendar_v1_UpdateEventRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateEventRequest.Parser));

        static readonly Marshaller<DeleteEventRequest> __Marshaller_salto_nebula_calendar_v1_DeleteEventRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteEventRequest.Parser));

        static readonly Method<CreateCalendarRequest, Calendar> __Method_CreateCalendar = new(
            MethodType.Unary,
            __ServiceName,
            "CreateCalendar",
            __Marshaller_salto_nebula_calendar_v1_CreateCalendarRequest,
            __Marshaller_salto_nebula_calendar_v1_Calendar);

        static readonly Method<GetCalendarRequest, Calendar> __Method_GetCalendar = new(
            MethodType.Unary,
            __ServiceName,
            "GetCalendar",
            __Marshaller_salto_nebula_calendar_v1_GetCalendarRequest,
            __Marshaller_salto_nebula_calendar_v1_Calendar);

        static readonly Method<ListCalendarsRequest, ListCalendarsResponse> __Method_ListCalendars = new(
            MethodType.Unary,
            __ServiceName,
            "ListCalendars",
            __Marshaller_salto_nebula_calendar_v1_ListCalendarsRequest,
            __Marshaller_salto_nebula_calendar_v1_ListCalendarsResponse);

        static readonly Method<UpdateCalendarRequest, Calendar> __Method_UpdateCalendar = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateCalendar",
            __Marshaller_salto_nebula_calendar_v1_UpdateCalendarRequest,
            __Marshaller_salto_nebula_calendar_v1_Calendar);

        static readonly Method<DeleteCalendarRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCalendar = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteCalendar",
            __Marshaller_salto_nebula_calendar_v1_DeleteCalendarRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<CreateEventRequest, Event> __Method_CreateEvent = new(
            MethodType.Unary,
            __ServiceName,
            "CreateEvent",
            __Marshaller_salto_nebula_calendar_v1_CreateEventRequest,
            __Marshaller_salto_nebula_calendar_v1_Event);

        static readonly Method<GetEventRequest, Event> __Method_GetEvent = new(
            MethodType.Unary,
            __ServiceName,
            "GetEvent",
            __Marshaller_salto_nebula_calendar_v1_GetEventRequest,
            __Marshaller_salto_nebula_calendar_v1_Event);

        static readonly Method<ListEventsRequest, ListEventsResponse> __Method_ListEvents = new(
            MethodType.Unary,
            __ServiceName,
            "ListEvents",
            __Marshaller_salto_nebula_calendar_v1_ListEventsRequest,
            __Marshaller_salto_nebula_calendar_v1_ListEventsResponse);

        static readonly Method<UpdateEventRequest, Event> __Method_UpdateEvent = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateEvent",
            __Marshaller_salto_nebula_calendar_v1_UpdateEventRequest,
            __Marshaller_salto_nebula_calendar_v1_Event);

        static readonly Method<DeleteEventRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteEvent = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteEvent",
            __Marshaller_salto_nebula_calendar_v1_DeleteEventRequest,
            __Marshaller_google_protobuf_Empty);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for CalendarService</summary>
        public partial class CalendarServiceClient : ClientBase<CalendarServiceClient>
        {
            /// <summary>Creates a new client for CalendarService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public CalendarServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for CalendarService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public CalendarServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected CalendarServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected CalendarServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create a calendar
            ///
            /// Creates a calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Calendar CreateCalendar(CreateCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateCalendar(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a calendar
            ///
            /// Creates a calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Calendar CreateCalendar(CreateCalendarRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateCalendar, null, options, request);
            /// <summary>
            /// Create a calendar
            ///
            /// Creates a calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Calendar> CreateCalendarAsync(CreateCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateCalendarAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a calendar
            ///
            /// Creates a calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Calendar> CreateCalendarAsync(CreateCalendarRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateCalendar, null, options, request);
            }

            /// <summary>
            /// Get a calendar
            ///
            /// Gets an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Calendar GetCalendar(GetCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetCalendar(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a calendar
            ///
            /// Gets an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Calendar GetCalendar(GetCalendarRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetCalendar, null, options, request);
            /// <summary>
            /// Get a calendar
            ///
            /// Gets an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Calendar> GetCalendarAsync(GetCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetCalendarAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get a calendar
            ///
            /// Gets an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Calendar> GetCalendarAsync(GetCalendarRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetCalendar, null, options, request);
            }

            /// <summary>
            /// List calendars
            ///
            /// Returns a list of calendars that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListCalendarsResponse ListCalendars(ListCalendarsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListCalendars(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List calendars
            ///
            /// Returns a list of calendars that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListCalendarsResponse ListCalendars(ListCalendarsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListCalendars, null, options, request);
            /// <summary>
            /// List calendars
            ///
            /// Returns a list of calendars that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListCalendarsResponse> ListCalendarsAsync(ListCalendarsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListCalendarsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List calendars
            ///
            /// Returns a list of calendars that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListCalendarsResponse> ListCalendarsAsync(ListCalendarsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListCalendars, null, options, request);
            }

            /// <summary>
            /// Update a calendar
            ///
            /// Updates an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Calendar UpdateCalendar(UpdateCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateCalendar(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a calendar
            ///
            /// Updates an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Calendar UpdateCalendar(UpdateCalendarRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateCalendar, null, options, request);
            /// <summary>
            /// Update a calendar
            ///
            /// Updates an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Calendar> UpdateCalendarAsync(UpdateCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateCalendarAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update a calendar
            ///
            /// Updates an existing calendar.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Calendar> UpdateCalendarAsync(UpdateCalendarRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateCalendar, null, options, request);
            }

            /// <summary>
            /// Delete a calendar
            ///
            /// Permanently deletes a calendar. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteCalendar(DeleteCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteCalendar(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a calendar
            ///
            /// Permanently deletes a calendar. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteCalendar(DeleteCalendarRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteCalendar, null, options, request);
            /// <summary>
            /// Delete a calendar
            ///
            /// Permanently deletes a calendar. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteCalendarAsync(DeleteCalendarRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteCalendarAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a calendar
            ///
            /// Permanently deletes a calendar. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteCalendarAsync(DeleteCalendarRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteCalendar, null, options, request);
            }

            /// <summary>
            /// Create a calendar event
            ///
            /// Creates a calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event CreateEvent(CreateEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateEvent(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a calendar event
            ///
            /// Creates a calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event CreateEvent(CreateEventRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateEvent, null, options, request);
            /// <summary>
            /// Create a calendar event
            ///
            /// Creates a calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> CreateEventAsync(CreateEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateEventAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a calendar event
            ///
            /// Creates a calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> CreateEventAsync(CreateEventRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateEvent, null, options, request);
            }

            /// <summary>
            /// Get a calendar event
            ///
            /// Gets an existing calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event GetEvent(GetEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetEvent(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a calendar event
            ///
            /// Gets an existing calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event GetEvent(GetEventRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetEvent, null, options, request);
            /// <summary>
            /// Get a calendar event
            ///
            /// Gets an existing calendar event.
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
            /// Get a calendar event
            ///
            /// Gets an existing calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> GetEventAsync(GetEventRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetEvent, null, options, request);
            }

            /// <summary>
            /// List calendar events
            ///
            /// Lists existing calendar events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEventsResponse ListEvents(ListEventsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListEvents(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List calendar events
            ///
            /// Lists existing calendar events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEventsResponse ListEvents(ListEventsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListEvents, null, options, request);
            /// <summary>
            /// List calendar events
            ///
            /// Lists existing calendar events.
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
            /// List calendar events
            ///
            /// Lists existing calendar events.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEventsResponse> ListEventsAsync(ListEventsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListEvents, null, options, request);
            }

            /// <summary>
            /// Update a calendar event
            ///
            /// Updates an existing calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event UpdateEvent(UpdateEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateEvent(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a calendar event
            ///
            /// Updates an existing calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Event UpdateEvent(UpdateEventRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateEvent, null, options, request);
            /// <summary>
            /// Update a calendar event
            ///
            /// Updates an existing calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> UpdateEventAsync(UpdateEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateEventAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update a calendar event
            ///
            /// Updates an existing calendar event.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Event> UpdateEventAsync(UpdateEventRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateEvent, null, options, request);
            }

            /// <summary>
            /// Delete a calendar event
            ///
            /// Permanently deletes a calendar event. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteEvent(DeleteEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteEvent(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a calendar event
            ///
            /// Permanently deletes a calendar event. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteEvent(DeleteEventRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteEvent, null, options, request);
            /// <summary>
            /// Delete a calendar event
            ///
            /// Permanently deletes a calendar event. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteEventAsync(DeleteEventRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteEventAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a calendar event
            ///
            /// Permanently deletes a calendar event. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteEventAsync(DeleteEventRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteEvent, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override CalendarServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
