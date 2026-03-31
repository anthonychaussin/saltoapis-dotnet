using Saltoapis.Nebula.OpeningModeSchedule.V1.Request;
using Saltoapis.Grpc;
using Saltoapis.Nebula.OpeningModeSchedule.V1.Response;

namespace Saltoapis.Nebula.OpeningModeSchedule.V1
{
    /// <summary>
    /// An opening mode is a type of behavior which can be applied to a specific
    /// access point or collection of access points. For example: Office or Toggle.
    /// This service allows you to make a number of different opening modes switch
    /// automatically and vary across different time periods.
    /// </summary>
    public static partial class OpeningModeScheduleService
    {
        static readonly string __ServiceName = "salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService";

        static readonly Marshaller<CreateOpeningModeScheduleRequest> __Marshaller_salto_nebula_openingmodeschedule_v1_CreateOpeningModeScheduleRequest = GrpcMessageHelper.CreateMarshaller(CreateOpeningModeScheduleRequest.Parser);

        static readonly Marshaller<OpeningModeSchedule> __Marshaller_salto_nebula_openingmodeschedule_v1_OpeningModeSchedule = GrpcMessageHelper.CreateMarshaller(OpeningModeSchedule.Parser);

        static readonly Marshaller<GetOpeningModeScheduleRequest> __Marshaller_salto_nebula_openingmodeschedule_v1_GetOpeningModeScheduleRequest = GrpcMessageHelper.CreateMarshaller(GetOpeningModeScheduleRequest.Parser);

        static readonly Marshaller<ListOpeningModeSchedulesRequest> __Marshaller_salto_nebula_openingmodeschedule_v1_ListOpeningModeSchedulesRequest = GrpcMessageHelper.CreateMarshaller(ListOpeningModeSchedulesRequest.Parser);

        static readonly Marshaller<ListOpeningModeSchedulesResponse> __Marshaller_salto_nebula_openingmodeschedule_v1_ListOpeningModeSchedulesResponse = GrpcMessageHelper.CreateMarshaller(ListOpeningModeSchedulesResponse.Parser);

        static readonly Marshaller<UpdateOpeningModeScheduleRequest> __Marshaller_salto_nebula_openingmodeschedule_v1_UpdateOpeningModeScheduleRequest = GrpcMessageHelper.CreateMarshaller(UpdateOpeningModeScheduleRequest.Parser);

        static readonly Marshaller<DeleteOpeningModeScheduleRequest> __Marshaller_salto_nebula_openingmodeschedule_v1_DeleteOpeningModeScheduleRequest = GrpcMessageHelper.CreateMarshaller(DeleteOpeningModeScheduleRequest.Parser);

        static readonly Method<CreateOpeningModeScheduleRequest, OpeningModeSchedule> __Method_CreateOpeningModeSchedule = new(
            MethodType.Unary,
            __ServiceName,
            "CreateOpeningModeSchedule",
            __Marshaller_salto_nebula_openingmodeschedule_v1_CreateOpeningModeScheduleRequest,
            __Marshaller_salto_nebula_openingmodeschedule_v1_OpeningModeSchedule);

        static readonly Method<GetOpeningModeScheduleRequest, OpeningModeSchedule> __Method_GetOpeningModeSchedule = new(
            MethodType.Unary,
            __ServiceName,
            "GetOpeningModeSchedule",
            __Marshaller_salto_nebula_openingmodeschedule_v1_GetOpeningModeScheduleRequest,
            __Marshaller_salto_nebula_openingmodeschedule_v1_OpeningModeSchedule);

        static readonly Method<ListOpeningModeSchedulesRequest, ListOpeningModeSchedulesResponse> __Method_ListOpeningModeSchedules = new(
            MethodType.Unary,
            __ServiceName,
            "ListOpeningModeSchedules",
            __Marshaller_salto_nebula_openingmodeschedule_v1_ListOpeningModeSchedulesRequest,
            __Marshaller_salto_nebula_openingmodeschedule_v1_ListOpeningModeSchedulesResponse);

        static readonly Method<UpdateOpeningModeScheduleRequest, OpeningModeSchedule> __Method_UpdateOpeningModeSchedule = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateOpeningModeSchedule",
            __Marshaller_salto_nebula_openingmodeschedule_v1_UpdateOpeningModeScheduleRequest,
            __Marshaller_salto_nebula_openingmodeschedule_v1_OpeningModeSchedule);

        static readonly Method<DeleteOpeningModeScheduleRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteOpeningModeSchedule = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteOpeningModeSchedule",
            __Marshaller_salto_nebula_openingmodeschedule_v1_DeleteOpeningModeScheduleRequest,
            GrpcMessageHelper.EmptyMarshaller);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for OpeningModeScheduleService</summary>
        public partial class OpeningModeScheduleServiceClient : ClientBase<OpeningModeScheduleServiceClient>
        {
            /// <summary>Creates a new client for OpeningModeScheduleService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public OpeningModeScheduleServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for OpeningModeScheduleService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public OpeningModeScheduleServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected OpeningModeScheduleServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected OpeningModeScheduleServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an opening mode schedule
            ///
            /// Creates an opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual OpeningModeSchedule CreateOpeningModeSchedule(CreateOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateOpeningModeSchedule(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an opening mode schedule
            ///
            /// Creates an opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual OpeningModeSchedule CreateOpeningModeSchedule(CreateOpeningModeScheduleRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateOpeningModeSchedule, null, options, request);
            /// <summary>
            /// Create an opening mode schedule
            ///
            /// Creates an opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<OpeningModeSchedule> CreateOpeningModeScheduleAsync(CreateOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateOpeningModeScheduleAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an opening mode schedule
            ///
            /// Creates an opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<OpeningModeSchedule> CreateOpeningModeScheduleAsync(CreateOpeningModeScheduleRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateOpeningModeSchedule, null, options, request);
            }

            /// <summary>
            /// Get an opening mode schedule
            ///
            /// Gets an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual OpeningModeSchedule GetOpeningModeSchedule(GetOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetOpeningModeSchedule(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an opening mode schedule
            ///
            /// Gets an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual OpeningModeSchedule GetOpeningModeSchedule(GetOpeningModeScheduleRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetOpeningModeSchedule, null, options, request);
            /// <summary>
            /// Get an opening mode schedule
            ///
            /// Gets an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<OpeningModeSchedule> GetOpeningModeScheduleAsync(GetOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetOpeningModeScheduleAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an opening mode schedule
            ///
            /// Gets an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<OpeningModeSchedule> GetOpeningModeScheduleAsync(GetOpeningModeScheduleRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetOpeningModeSchedule, null, options, request);
            }

            /// <summary>
            /// List opening mode schedules
            ///
            /// Returns a list of opening mode schedules that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListOpeningModeSchedulesResponse ListOpeningModeSchedules(ListOpeningModeSchedulesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListOpeningModeSchedules(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List opening mode schedules
            ///
            /// Returns a list of opening mode schedules that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListOpeningModeSchedulesResponse ListOpeningModeSchedules(ListOpeningModeSchedulesRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListOpeningModeSchedules, null, options, request);
            /// <summary>
            /// List opening mode schedules
            ///
            /// Returns a list of opening mode schedules that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListOpeningModeSchedulesResponse> ListOpeningModeSchedulesAsync(ListOpeningModeSchedulesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListOpeningModeSchedulesAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List opening mode schedules
            ///
            /// Returns a list of opening mode schedules that have been previously
            /// created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListOpeningModeSchedulesResponse> ListOpeningModeSchedulesAsync(ListOpeningModeSchedulesRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListOpeningModeSchedules, null, options, request);
            }

            /// <summary>
            /// Update an opening mode schedule
            ///
            /// Updates an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual OpeningModeSchedule UpdateOpeningModeSchedule(UpdateOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateOpeningModeSchedule(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an opening mode schedule
            ///
            /// Updates an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual OpeningModeSchedule UpdateOpeningModeSchedule(UpdateOpeningModeScheduleRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateOpeningModeSchedule, null, options, request);
            /// <summary>
            /// Update an opening mode schedule
            ///
            /// Updates an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<OpeningModeSchedule> UpdateOpeningModeScheduleAsync(UpdateOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateOpeningModeScheduleAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an opening mode schedule
            ///
            /// Updates an existing opening mode schedule.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<OpeningModeSchedule> UpdateOpeningModeScheduleAsync(UpdateOpeningModeScheduleRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateOpeningModeSchedule, null, options, request);
            }

            /// <summary>
            /// Delete an opening mode schedule
            ///
            /// Permanently deletes an opening mode schedule. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteOpeningModeSchedule(DeleteOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteOpeningModeSchedule(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an opening mode schedule
            ///
            /// Permanently deletes an opening mode schedule. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteOpeningModeSchedule(DeleteOpeningModeScheduleRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteOpeningModeSchedule, null, options, request);
            /// <summary>
            /// Delete an opening mode schedule
            ///
            /// Permanently deletes an opening mode schedule. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteOpeningModeScheduleAsync(DeleteOpeningModeScheduleRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteOpeningModeScheduleAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an opening mode schedule
            ///
            /// Permanently deletes an opening mode schedule. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteOpeningModeScheduleAsync(DeleteOpeningModeScheduleRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteOpeningModeSchedule, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override OpeningModeScheduleServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}




