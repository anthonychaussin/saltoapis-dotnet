using Grpc.Core;
using Saltoapis.Nebula.Booking.V1.Request;
using Saltoapis.Nebula.Booking.V1.Response;

namespace Saltoapis.Nebula.Booking.V1
{
    /// <summary>
    /// The BookingService manages bookings within an installation.
    ///
    /// A booking represents the contractual agreement for a stay, including
    /// reservation details, dates and guest information. This service handles
    /// the lifecycle of bookings independently from the physical access control
    /// systems, allowing reservations to be managed separately from device states
    /// and access permissions.
    ///
    /// Use this service to create, retrieve, update and delete bookings as part
    /// of property management operations.
    /// </summary>
    public static partial class BookingService
    {
        static readonly string __ServiceName = "salto.nebula.booking.v1.BookingService";

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

        static readonly Marshaller<CreateBookingRequest> __Marshaller_salto_nebula_booking_v1_CreateBookingRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateBookingRequest.Parser));

        static readonly Marshaller<Booking> __Marshaller_salto_nebula_booking_v1_Booking = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Booking.Parser));

        static readonly Marshaller<GetBookingRequest> __Marshaller_salto_nebula_booking_v1_GetBookingRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetBookingRequest.Parser));

        static readonly Marshaller<ListBookingsRequest> __Marshaller_salto_nebula_booking_v1_ListBookingsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListBookingsRequest.Parser));

        static readonly Marshaller<ListBookingsResponse> __Marshaller_salto_nebula_booking_v1_ListBookingsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListBookingsResponse.Parser));

        static readonly Marshaller<UpdateBookingRequest> __Marshaller_salto_nebula_booking_v1_UpdateBookingRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateBookingRequest.Parser));

        static readonly Marshaller<DeleteBookingRequest> __Marshaller_salto_nebula_booking_v1_DeleteBookingRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteBookingRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<CheckInBookingRequest> __Marshaller_salto_nebula_booking_v1_CheckInBookingRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CheckInBookingRequest.Parser));

        static readonly Marshaller<CheckOutBookingRequest> __Marshaller_salto_nebula_booking_v1_CheckOutBookingRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CheckOutBookingRequest.Parser));

        static readonly Marshaller<CreateBookingUserRequest> __Marshaller_salto_nebula_booking_v1_CreateBookingUserRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateBookingUserRequest.Parser));

        static readonly Marshaller<BookingUser> __Marshaller_salto_nebula_booking_v1_BookingUser = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BookingUser.Parser));

        static readonly Marshaller<GetBookingUserRequest> __Marshaller_salto_nebula_booking_v1_GetBookingUserRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetBookingUserRequest.Parser));

        static readonly Marshaller<ListBookingUsersRequest> __Marshaller_salto_nebula_booking_v1_ListBookingUsersRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListBookingUsersRequest.Parser));

        static readonly Marshaller<ListBookingUsersResponse> __Marshaller_salto_nebula_booking_v1_ListBookingUsersResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListBookingUsersResponse.Parser));

        static readonly Marshaller<DeleteBookingUserRequest> __Marshaller_salto_nebula_booking_v1_DeleteBookingUserRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteBookingUserRequest.Parser));

        static readonly Method<CreateBookingRequest, Booking> __Method_CreateBooking = new(
            MethodType.Unary,
            __ServiceName,
            "CreateBooking",
            __Marshaller_salto_nebula_booking_v1_CreateBookingRequest,
            __Marshaller_salto_nebula_booking_v1_Booking);

        static readonly Method<GetBookingRequest, Booking> __Method_GetBooking = new(
            MethodType.Unary,
            __ServiceName,
            "GetBooking",
            __Marshaller_salto_nebula_booking_v1_GetBookingRequest,
            __Marshaller_salto_nebula_booking_v1_Booking);

        static readonly Method<ListBookingsRequest, ListBookingsResponse> __Method_ListBookings = new(
            MethodType.Unary,
            __ServiceName,
            "ListBookings",
            __Marshaller_salto_nebula_booking_v1_ListBookingsRequest,
            __Marshaller_salto_nebula_booking_v1_ListBookingsResponse);

        static readonly Method<UpdateBookingRequest, Booking> __Method_UpdateBooking = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateBooking",
            __Marshaller_salto_nebula_booking_v1_UpdateBookingRequest,
            __Marshaller_salto_nebula_booking_v1_Booking);

        static readonly Method<DeleteBookingRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteBooking = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteBooking",
            __Marshaller_salto_nebula_booking_v1_DeleteBookingRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<CheckInBookingRequest, Booking> __Method_CheckInBooking = new(
            MethodType.Unary,
            __ServiceName,
            "CheckInBooking",
            __Marshaller_salto_nebula_booking_v1_CheckInBookingRequest,
            __Marshaller_salto_nebula_booking_v1_Booking);

        static readonly Method<CheckOutBookingRequest, Booking> __Method_CheckOutBooking = new(
            MethodType.Unary,
            __ServiceName,
            "CheckOutBooking",
            __Marshaller_salto_nebula_booking_v1_CheckOutBookingRequest,
            __Marshaller_salto_nebula_booking_v1_Booking);

        static readonly Method<CreateBookingUserRequest, BookingUser> __Method_CreateBookingUser = new(
            MethodType.Unary,
            __ServiceName,
            "CreateBookingUser",
            __Marshaller_salto_nebula_booking_v1_CreateBookingUserRequest,
            __Marshaller_salto_nebula_booking_v1_BookingUser);

        static readonly Method<GetBookingUserRequest, BookingUser> __Method_GetBookingUser = new(
            MethodType.Unary,
            __ServiceName,
            "GetBookingUser",
            __Marshaller_salto_nebula_booking_v1_GetBookingUserRequest,
            __Marshaller_salto_nebula_booking_v1_BookingUser);

        static readonly Method<ListBookingUsersRequest, ListBookingUsersResponse> __Method_ListBookingUsers = new(
            MethodType.Unary,
            __ServiceName,
            "ListBookingUsers",
            __Marshaller_salto_nebula_booking_v1_ListBookingUsersRequest,
            __Marshaller_salto_nebula_booking_v1_ListBookingUsersResponse);

        static readonly Method<DeleteBookingUserRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteBookingUser = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteBookingUser",
            __Marshaller_salto_nebula_booking_v1_DeleteBookingUserRequest,
            __Marshaller_google_protobuf_Empty);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for BookingService</summary>
        public partial class BookingServiceClient : ClientBase<BookingServiceClient>
        {
            /// <summary>Creates a new client for BookingService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public BookingServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for BookingService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public BookingServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected BookingServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected BookingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create a booking
            ///
            /// Creates a new booking in the specified installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking CreateBooking(CreateBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateBooking(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a booking
            ///
            /// Creates a new booking in the specified installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking CreateBooking(CreateBookingRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateBooking, null, options, request);
            /// <summary>
            /// Create a booking
            ///
            /// Creates a new booking in the specified installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> CreateBookingAsync(CreateBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateBookingAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a booking
            ///
            /// Creates a new booking in the specified installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> CreateBookingAsync(CreateBookingRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateBooking, null, options, request);
            }

            /// <summary>
            /// Get a booking
            ///
            /// Gets an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking GetBooking(GetBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetBooking(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a booking
            ///
            /// Gets an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking GetBooking(GetBookingRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetBooking, null, options, request);
            /// <summary>
            /// Get a booking
            ///
            /// Gets an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> GetBookingAsync(GetBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetBookingAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get a booking
            ///
            /// Gets an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> GetBookingAsync(GetBookingRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetBooking, null, options, request);
            }

            /// <summary>
            /// List bookings
            ///
            /// Returns a list of bookings that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListBookingsResponse ListBookings(ListBookingsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListBookings(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List bookings
            ///
            /// Returns a list of bookings that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListBookingsResponse ListBookings(ListBookingsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListBookings, null, options, request);
            /// <summary>
            /// List bookings
            ///
            /// Returns a list of bookings that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListBookingsResponse> ListBookingsAsync(ListBookingsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListBookingsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List bookings
            ///
            /// Returns a list of bookings that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListBookingsResponse> ListBookingsAsync(ListBookingsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListBookings, null, options, request);
            }

            /// <summary>
            /// Update a booking
            ///
            /// Updates an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking UpdateBooking(UpdateBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateBooking(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a booking
            ///
            /// Updates an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking UpdateBooking(UpdateBookingRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateBooking, null, options, request);
            /// <summary>
            /// Update a booking
            ///
            /// Updates an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> UpdateBookingAsync(UpdateBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateBookingAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update a booking
            ///
            /// Updates an existing booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> UpdateBookingAsync(UpdateBookingRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateBooking, null, options, request);
            }

            /// <summary>
            /// Delete a booking
            ///
            /// Permanently deletes a booking. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteBooking(DeleteBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteBooking(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a booking
            ///
            /// Permanently deletes a booking. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteBooking(DeleteBookingRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteBooking, null, options, request);
            /// <summary>
            /// Delete a booking
            ///
            /// Permanently deletes a booking. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteBookingAsync(DeleteBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteBookingAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a booking
            ///
            /// Permanently deletes a booking. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteBookingAsync(DeleteBookingRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteBooking, null, options, request);
            }

            /// <summary>
            /// Check in a booking
            ///
            /// Performs the check-in process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking CheckInBooking(CheckInBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CheckInBooking(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Check in a booking
            ///
            /// Performs the check-in process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking CheckInBooking(CheckInBookingRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CheckInBooking, null, options, request);
            /// <summary>
            /// Check in a booking
            ///
            /// Performs the check-in process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> CheckInBookingAsync(CheckInBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CheckInBookingAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Check in a booking
            ///
            /// Performs the check-in process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> CheckInBookingAsync(CheckInBookingRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CheckInBooking, null, options, request);
            }

            /// <summary>
            /// Check out a booking
            ///
            /// Performs the check-out process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking CheckOutBooking(CheckOutBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CheckOutBooking(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Check out a booking
            ///
            /// Performs the check-out process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Booking CheckOutBooking(CheckOutBookingRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CheckOutBooking, null, options, request);
            /// <summary>
            /// Check out a booking
            ///
            /// Performs the check-out process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> CheckOutBookingAsync(CheckOutBookingRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CheckOutBookingAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Check out a booking
            ///
            /// Performs the check-out process for a booking.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Booking> CheckOutBookingAsync(CheckOutBookingRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CheckOutBooking, null, options, request);
            }

            /// <summary>
            /// Create a booking user
            ///
            /// Creates a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BookingUser CreateBookingUser(CreateBookingUserRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateBookingUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a booking user
            ///
            /// Creates a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BookingUser CreateBookingUser(CreateBookingUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateBookingUser, null, options, request);
            /// <summary>
            /// Create a booking user
            ///
            /// Creates a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BookingUser> CreateBookingUserAsync(CreateBookingUserRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateBookingUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a booking user
            ///
            /// Creates a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BookingUser> CreateBookingUserAsync(CreateBookingUserRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateBookingUser, null, options, request);
            }

            /// <summary>
            /// Get a booking user
            ///
            /// Retrieves an existing booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BookingUser GetBookingUser(GetBookingUserRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetBookingUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a booking user
            ///
            /// Retrieves an existing booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BookingUser GetBookingUser(GetBookingUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetBookingUser, null, options, request);
            /// <summary>
            /// Get a booking user
            ///
            /// Retrieves an existing booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BookingUser> GetBookingUserAsync(GetBookingUserRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetBookingUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get a booking user
            ///
            /// Retrieves an existing booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BookingUser> GetBookingUserAsync(GetBookingUserRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetBookingUser, null, options, request);
            }

            /// <summary>
            /// List booking users
            ///
            /// Lists an existing booking's user associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListBookingUsersResponse ListBookingUsers(ListBookingUsersRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListBookingUsers(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List booking users
            ///
            /// Lists an existing booking's user associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListBookingUsersResponse ListBookingUsers(ListBookingUsersRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListBookingUsers, null, options, request);
            /// <summary>
            /// List booking users
            ///
            /// Lists an existing booking's user associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListBookingUsersResponse> ListBookingUsersAsync(ListBookingUsersRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListBookingUsersAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List booking users
            ///
            /// Lists an existing booking's user associations.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListBookingUsersResponse> ListBookingUsersAsync(ListBookingUsersRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListBookingUsers, null, options, request);
            }

            /// <summary>
            /// Delete a booking user
            ///
            /// Deletes a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteBookingUser(DeleteBookingUserRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteBookingUser(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a booking user
            ///
            /// Deletes a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteBookingUser(DeleteBookingUserRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteBookingUser, null, options, request);
            /// <summary>
            /// Delete a booking user
            ///
            /// Deletes a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteBookingUserAsync(DeleteBookingUserRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteBookingUserAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a booking user
            ///
            /// Deletes a booking's user association.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteBookingUserAsync(DeleteBookingUserRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteBookingUser, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override BookingServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
