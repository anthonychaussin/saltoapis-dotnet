using Grpc.Core;

namespace Saltoapis.Nebula.Unit.V1
{
    /// <summary>
    /// UnitService is the service responsible for managing unit resources.
    /// </summary>
    public static partial class UnitService
    {
        static readonly string __ServiceName = "salto.nebula.unit.v1.UnitService";

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

        static readonly Marshaller<CreateUnitRequest> __Marshaller_salto_nebula_unit_v1_CreateUnitRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateUnitRequest.Parser));

        static readonly Marshaller<Unit> __Marshaller_salto_nebula_unit_v1_Unit = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Unit.Parser));

        static readonly Marshaller<GetUnitRequest> __Marshaller_salto_nebula_unit_v1_GetUnitRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetUnitRequest.Parser));

        static readonly Marshaller<ListUnitsRequest> __Marshaller_salto_nebula_unit_v1_ListUnitsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListUnitsRequest.Parser));

        static readonly Marshaller<ListUnitsResponse> __Marshaller_salto_nebula_unit_v1_ListUnitsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListUnitsResponse.Parser));

        static readonly Marshaller<UpdateUnitRequest> __Marshaller_salto_nebula_unit_v1_UpdateUnitRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateUnitRequest.Parser));

        static readonly Marshaller<DeleteUnitRequest> __Marshaller_salto_nebula_unit_v1_DeleteUnitRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteUnitRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<CleanOutUnitRequest> __Marshaller_salto_nebula_unit_v1_CleanOutUnitRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CleanOutUnitRequest.Parser));

        static readonly Marshaller<CleanOutUnitResponse> __Marshaller_salto_nebula_unit_v1_CleanOutUnitResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CleanOutUnitResponse.Parser));

        static readonly Marshaller<MoveInUnitRequest> __Marshaller_salto_nebula_unit_v1_MoveInUnitRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, MoveInUnitRequest.Parser));

        static readonly Marshaller<MoveInUnitResponse> __Marshaller_salto_nebula_unit_v1_MoveInUnitResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, MoveInUnitResponse.Parser));

        static readonly Marshaller<MoveOutUnitRequest> __Marshaller_salto_nebula_unit_v1_MoveOutUnitRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, MoveOutUnitRequest.Parser));

        static readonly Marshaller<MoveOutUnitResponse> __Marshaller_salto_nebula_unit_v1_MoveOutUnitResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, MoveOutUnitResponse.Parser));

        static readonly Marshaller<CreatePolicyRequest> __Marshaller_salto_nebula_unit_v1_CreatePolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreatePolicyRequest.Parser));

        static readonly Marshaller<Policy> __Marshaller_salto_nebula_unit_v1_Policy = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Policy.Parser));

        static readonly Marshaller<GetPolicyRequest> __Marshaller_salto_nebula_unit_v1_GetPolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetPolicyRequest.Parser));

        static readonly Marshaller<ListPoliciesRequest> __Marshaller_salto_nebula_unit_v1_ListPoliciesRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListPoliciesRequest.Parser));

        static readonly Marshaller<ListPoliciesResponse> __Marshaller_salto_nebula_unit_v1_ListPoliciesResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListPoliciesResponse.Parser));

        static readonly Marshaller<UpdatePolicyRequest> __Marshaller_salto_nebula_unit_v1_UpdatePolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdatePolicyRequest.Parser));

        static readonly Marshaller<DeletePolicyRequest> __Marshaller_salto_nebula_unit_v1_DeletePolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeletePolicyRequest.Parser));

        static readonly Marshaller<TestPermissionsRequest> __Marshaller_salto_nebula_unit_v1_TestPermissionsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, TestPermissionsRequest.Parser));

        static readonly Marshaller<TestPermissionsResponse> __Marshaller_salto_nebula_unit_v1_TestPermissionsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, TestPermissionsResponse.Parser));

        static readonly Method<CreateUnitRequest, Unit> __Method_CreateUnit = new(
            MethodType.Unary,
            __ServiceName,
            "CreateUnit",
            __Marshaller_salto_nebula_unit_v1_CreateUnitRequest,
            __Marshaller_salto_nebula_unit_v1_Unit);

        static readonly Method<GetUnitRequest, Unit> __Method_GetUnit = new(
            MethodType.Unary,
            __ServiceName,
            "GetUnit",
            __Marshaller_salto_nebula_unit_v1_GetUnitRequest,
            __Marshaller_salto_nebula_unit_v1_Unit);

        static readonly Method<ListUnitsRequest, ListUnitsResponse> __Method_ListUnits = new(
            MethodType.Unary,
            __ServiceName,
            "ListUnits",
            __Marshaller_salto_nebula_unit_v1_ListUnitsRequest,
            __Marshaller_salto_nebula_unit_v1_ListUnitsResponse);

        static readonly Method<UpdateUnitRequest, Unit> __Method_UpdateUnit = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateUnit",
            __Marshaller_salto_nebula_unit_v1_UpdateUnitRequest,
            __Marshaller_salto_nebula_unit_v1_Unit);

        static readonly Method<DeleteUnitRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteUnit = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteUnit",
            __Marshaller_salto_nebula_unit_v1_DeleteUnitRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<CleanOutUnitRequest, CleanOutUnitResponse> __Method_CleanOutUnit = new(
            MethodType.Unary,
            __ServiceName,
            "CleanOutUnit",
            __Marshaller_salto_nebula_unit_v1_CleanOutUnitRequest,
            __Marshaller_salto_nebula_unit_v1_CleanOutUnitResponse);

        static readonly Method<MoveInUnitRequest, MoveInUnitResponse> __Method_MoveInUnit = new(
            MethodType.Unary,
            __ServiceName,
            "MoveInUnit",
            __Marshaller_salto_nebula_unit_v1_MoveInUnitRequest,
            __Marshaller_salto_nebula_unit_v1_MoveInUnitResponse);

        static readonly Method<MoveOutUnitRequest, MoveOutUnitResponse> __Method_MoveOutUnit = new(
            MethodType.Unary,
            __ServiceName,
            "MoveOutUnit",
            __Marshaller_salto_nebula_unit_v1_MoveOutUnitRequest,
            __Marshaller_salto_nebula_unit_v1_MoveOutUnitResponse);

        static readonly Method<CreatePolicyRequest, Policy> __Method_CreatePolicy = new(
            MethodType.Unary,
            __ServiceName,
            "CreatePolicy",
            __Marshaller_salto_nebula_unit_v1_CreatePolicyRequest,
            __Marshaller_salto_nebula_unit_v1_Policy);

        static readonly Method<GetPolicyRequest, Policy> __Method_GetPolicy = new(
            MethodType.Unary,
            __ServiceName,
            "GetPolicy",
            __Marshaller_salto_nebula_unit_v1_GetPolicyRequest,
            __Marshaller_salto_nebula_unit_v1_Policy);

        static readonly Method<ListPoliciesRequest, ListPoliciesResponse> __Method_ListPolicies = new(
            MethodType.Unary,
            __ServiceName,
            "ListPolicies",
            __Marshaller_salto_nebula_unit_v1_ListPoliciesRequest,
            __Marshaller_salto_nebula_unit_v1_ListPoliciesResponse);

        static readonly Method<UpdatePolicyRequest, Policy> __Method_UpdatePolicy = new(
            MethodType.Unary,
            __ServiceName,
            "UpdatePolicy",
            __Marshaller_salto_nebula_unit_v1_UpdatePolicyRequest,
            __Marshaller_salto_nebula_unit_v1_Policy);

        static readonly Method<DeletePolicyRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeletePolicy = new(
            MethodType.Unary,
            __ServiceName,
            "DeletePolicy",
            __Marshaller_salto_nebula_unit_v1_DeletePolicyRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<TestPermissionsRequest, TestPermissionsResponse> __Method_TestPermissions = new(
            MethodType.Unary,
            __ServiceName,
            "TestPermissions",
            __Marshaller_salto_nebula_unit_v1_TestPermissionsRequest,
            __Marshaller_salto_nebula_unit_v1_TestPermissionsResponse);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for UnitService</summary>
        public partial class UnitServiceClient : ClientBase<UnitServiceClient>
        {
            /// <summary>Creates a new client for UnitService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public UnitServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for UnitService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public UnitServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected UnitServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected UnitServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create a unit
            ///
            /// Creates a new unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Unit CreateUnit(CreateUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateUnit(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a unit
            ///
            /// Creates a new unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Unit CreateUnit(CreateUnitRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateUnit, null, options, request);
            /// <summary>
            /// Create a unit
            ///
            /// Creates a new unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Unit> CreateUnitAsync(CreateUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateUnitAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a unit
            ///
            /// Creates a new unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Unit> CreateUnitAsync(CreateUnitRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateUnit, null, options, request);
            }

            /// <summary>
            /// Get an existing unit
            ///
            /// Retrieves an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Unit GetUnit(GetUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetUnit(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an existing unit
            ///
            /// Retrieves an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Unit GetUnit(GetUnitRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetUnit, null, options, request);
            /// <summary>
            /// Get an existing unit
            ///
            /// Retrieves an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Unit> GetUnitAsync(GetUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetUnitAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an existing unit
            ///
            /// Retrieves an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Unit> GetUnitAsync(GetUnitRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetUnit, null, options, request);
            }

            /// <summary>
            /// List units
            ///
            /// Returns a list of units that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListUnitsResponse ListUnits(ListUnitsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListUnits(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List units
            ///
            /// Returns a list of units that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListUnitsResponse ListUnits(ListUnitsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListUnits, null, options, request);
            /// <summary>
            /// List units
            ///
            /// Returns a list of units that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListUnitsResponse> ListUnitsAsync(ListUnitsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListUnitsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List units
            ///
            /// Returns a list of units that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListUnitsResponse> ListUnitsAsync(ListUnitsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListUnits, null, options, request);
            }

            /// <summary>
            /// Update an existing unit
            ///
            /// Updates an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Unit UpdateUnit(UpdateUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateUnit(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an existing unit
            ///
            /// Updates an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Unit UpdateUnit(UpdateUnitRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateUnit, null, options, request);
            /// <summary>
            /// Update an existing unit
            ///
            /// Updates an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Unit> UpdateUnitAsync(UpdateUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateUnitAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an existing unit
            ///
            /// Updates an existing unit.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Unit> UpdateUnitAsync(UpdateUnitRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateUnit, null, options, request);
            }

            /// <summary>
            /// Delete a unit
            ///
            /// Permanently deletes a unit. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteUnit(DeleteUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteUnit(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a unit
            ///
            /// Permanently deletes a unit. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteUnit(DeleteUnitRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteUnit, null, options, request);
            /// <summary>
            /// Delete a unit
            ///
            /// Permanently deletes a unit. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteUnitAsync(DeleteUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteUnitAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a unit
            ///
            /// Permanently deletes a unit. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteUnitAsync(DeleteUnitRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteUnit, null, options, request);
            }

            /// <summary>
            /// Clean out a unit
            ///
            /// Deprecated: Use [MoveOutUnit][salto.nebula.unit.v1.UnitService.MoveOutUnit]
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because clean out is a
            ///     phrasal verb and api-linter don't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CleanOutUnitResponse CleanOutUnit(CleanOutUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CleanOutUnit(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Clean out a unit
            ///
            /// Deprecated: Use [MoveOutUnit][salto.nebula.unit.v1.UnitService.MoveOutUnit]
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because clean out is a
            ///     phrasal verb and api-linter don't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual CleanOutUnitResponse CleanOutUnit(CleanOutUnitRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CleanOutUnit, null, options, request);
            /// <summary>
            /// Clean out a unit
            ///
            /// Deprecated: Use [MoveOutUnit][salto.nebula.unit.v1.UnitService.MoveOutUnit]
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because clean out is a
            ///     phrasal verb and api-linter don't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CleanOutUnitResponse> CleanOutUnitAsync(CleanOutUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CleanOutUnitAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Clean out a unit
            ///
            /// Deprecated: Use [MoveOutUnit][salto.nebula.unit.v1.UnitService.MoveOutUnit]
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because clean out is a
            ///     phrasal verb and api-linter don't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<CleanOutUnitResponse> CleanOutUnitAsync(CleanOutUnitRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CleanOutUnit, null, options, request);
            }

            /// <summary>
            /// Move in a unit
            ///
            /// Moves in a unit by creating new occupants and associating them with the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move in" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual MoveInUnitResponse MoveInUnit(MoveInUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => MoveInUnit(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Move in a unit
            ///
            /// Moves in a unit by creating new occupants and associating them with the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move in" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual MoveInUnitResponse MoveInUnit(MoveInUnitRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_MoveInUnit, null, options, request);
            /// <summary>
            /// Move in a unit
            ///
            /// Moves in a unit by creating new occupants and associating them with the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move in" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<MoveInUnitResponse> MoveInUnitAsync(MoveInUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return MoveInUnitAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Move in a unit
            ///
            /// Moves in a unit by creating new occupants and associating them with the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move in" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<MoveInUnitResponse> MoveInUnitAsync(MoveInUnitRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_MoveInUnit, null, options, request);
            }

            /// <summary>
            /// Move out a unit
            ///
            /// Moves out a unit by deleting all the occupants belonging to it. This process
            /// implicitly entails the blocking of the keys that were active within the
            /// unit. Moving out a unit will not delete the access rights and the
            /// associated access points that belong to the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move out" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual MoveOutUnitResponse MoveOutUnit(MoveOutUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => MoveOutUnit(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Move out a unit
            ///
            /// Moves out a unit by deleting all the occupants belonging to it. This process
            /// implicitly entails the blocking of the keys that were active within the
            /// unit. Moving out a unit will not delete the access rights and the
            /// associated access points that belong to the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move out" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual MoveOutUnitResponse MoveOutUnit(MoveOutUnitRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_MoveOutUnit, null, options, request);
            /// <summary>
            /// Move out a unit
            ///
            /// Moves out a unit by deleting all the occupants belonging to it. This process
            /// implicitly entails the blocking of the keys that were active within the
            /// unit. Moving out a unit will not delete the access rights and the
            /// associated access points that belong to the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move out" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<MoveOutUnitResponse> MoveOutUnitAsync(MoveOutUnitRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return MoveOutUnitAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Move out a unit
            ///
            /// Moves out a unit by deleting all the occupants belonging to it. This process
            /// implicitly entails the blocking of the keys that were active within the
            /// unit. Moving out a unit will not delete the access rights and the
            /// associated access points that belong to the unit.
            /// (-- api-linter: core::0136::http-uri-suffix=disabled
            ///     aip.dev/not-precedent: We need to do this because "move out" is a phrasal
            ///     verb and the api-linter doesn't support using them. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<MoveOutUnitResponse> MoveOutUnitAsync(MoveOutUnitRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_MoveOutUnit, null, options, request);
            }

            /// <summary>
            /// Create a policy
            ///
            /// Creates a new policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy CreatePolicy(CreatePolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreatePolicy(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a policy
            ///
            /// Creates a new policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy CreatePolicy(CreatePolicyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreatePolicy, null, options, request);
            /// <summary>
            /// Create a policy
            ///
            /// Creates a new policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Policy> CreatePolicyAsync(CreatePolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreatePolicyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a policy
            ///
            /// Creates a new policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Policy> CreatePolicyAsync(CreatePolicyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreatePolicy, null, options, request);
            }

            /// <summary>
            /// Get an existing policy
            ///
            /// Retrieves an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy GetPolicy(GetPolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetPolicy(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an existing policy
            ///
            /// Retrieves an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy GetPolicy(GetPolicyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetPolicy, null, options, request);
            /// <summary>
            /// Get an existing policy
            ///
            /// Retrieves an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Policy> GetPolicyAsync(GetPolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetPolicyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an existing policy
            ///
            /// Retrieves an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Policy> GetPolicyAsync(GetPolicyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetPolicy, null, options, request);
            }

            /// <summary>
            /// List policies
            ///
            /// Returns a list of policies that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListPolicies(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List policies
            ///
            /// Returns a list of policies that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListPolicies, null, options, request);
            /// <summary>
            /// List policies
            ///
            /// Returns a list of policies that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListPoliciesAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List policies
            ///
            /// Returns a list of policies that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListPolicies, null, options, request);
            }

            /// <summary>
            /// Update an existing policy
            ///
            /// Updates an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy UpdatePolicy(UpdatePolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdatePolicy(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an existing policy
            ///
            /// Updates an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy UpdatePolicy(UpdatePolicyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdatePolicy, null, options, request);
            /// <summary>
            /// Update an existing policy
            ///
            /// Updates an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdatePolicyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an existing policy
            ///
            /// Updates an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdatePolicy, null, options, request);
            }

            /// <summary>
            /// Delete a policy
            ///
            /// Permanently deletes a policy. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeletePolicy(DeletePolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeletePolicy(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete a policy
            ///
            /// Permanently deletes a policy. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeletePolicy(DeletePolicyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeletePolicy, null, options, request);
            /// <summary>
            /// Delete a policy
            ///
            /// Permanently deletes a policy. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeletePolicyAsync(DeletePolicyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeletePolicyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete a policy
            ///
            /// Permanently deletes a policy. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeletePolicyAsync(DeletePolicyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeletePolicy, null, options, request);
            }

            /// <summary>
            /// Test a permission
            ///
            /// Returns permissions that a caller has on the installation. If the
            /// installation does not exist, this will return an empty set of
            /// permissions, not a NOT_FOUND error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual TestPermissionsResponse TestPermissions(TestPermissionsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => TestPermissions(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Test a permission
            ///
            /// Returns permissions that a caller has on the installation. If the
            /// installation does not exist, this will return an empty set of
            /// permissions, not a NOT_FOUND error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual TestPermissionsResponse TestPermissions(TestPermissionsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_TestPermissions, null, options, request);
            /// <summary>
            /// Test a permission
            ///
            /// Returns permissions that a caller has on the installation. If the
            /// installation does not exist, this will return an empty set of
            /// permissions, not a NOT_FOUND error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<TestPermissionsResponse> TestPermissionsAsync(TestPermissionsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return TestPermissionsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Test a permission
            ///
            /// Returns permissions that a caller has on the installation. If the
            /// installation does not exist, this will return an empty set of
            /// permissions, not a NOT_FOUND error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<TestPermissionsResponse> TestPermissionsAsync(TestPermissionsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_TestPermissions, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override UnitServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
