using Grpc.Core;

namespace Saltoapis.Longrunning.V1
{
    /// <summary>
    /// Manages long-running operations with an API service.
    ///
    /// When an API method normally takes long time to complete, it can be designed
    /// to return [`Operation`][salto.longrunning.v1.Operation] to the client, and the
    /// client can use this interface to receive the real response asynchronously by
    /// polling the operation resource, or pass the operation resource to another API
    /// to receive the response. Any API service that returns long-running operations
    /// should implement the `OperationService` interface so developers can have a
    /// consistent client experience.
    /// </summary>
    public static partial class OperationService
    {
        static readonly string __ServiceName = "salto.longrunning.v1.OperationService";

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

        static readonly Marshaller<GetOperationRequest> __Marshaller_salto_longrunning_v1_GetOperationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetOperationRequest.Parser));

        static readonly Marshaller<Operation> __Marshaller_salto_longrunning_v1_Operation = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Operation.Parser));

        static readonly Marshaller<ListOperationsRequest> __Marshaller_salto_longrunning_v1_ListOperationsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListOperationsRequest.Parser));

        static readonly Marshaller<ListOperationsResponse> __Marshaller_salto_longrunning_v1_ListOperationsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListOperationsResponse.Parser));

        static readonly Marshaller<DeleteOperationRequest> __Marshaller_salto_longrunning_v1_DeleteOperationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteOperationRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<CancelOperationRequest> __Marshaller_salto_longrunning_v1_CancelOperationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CancelOperationRequest.Parser));

        static readonly Method<GetOperationRequest, Operation> __Method_GetOperation = new(
            MethodType.Unary,
            __ServiceName,
            "GetOperation",
            __Marshaller_salto_longrunning_v1_GetOperationRequest,
            __Marshaller_salto_longrunning_v1_Operation);

        static readonly Method<ListOperationsRequest, ListOperationsResponse> __Method_ListOperations = new(
            MethodType.Unary,
            __ServiceName,
            "ListOperations",
            __Marshaller_salto_longrunning_v1_ListOperationsRequest,
            __Marshaller_salto_longrunning_v1_ListOperationsResponse);

        static readonly Method<DeleteOperationRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteOperation = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteOperation",
            __Marshaller_salto_longrunning_v1_DeleteOperationRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<CancelOperationRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_CancelOperation = new(
            MethodType.Unary,
            __ServiceName,
            "CancelOperation",
            __Marshaller_salto_longrunning_v1_CancelOperationRequest,
            __Marshaller_google_protobuf_Empty);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return OperationReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for OperationService</summary>
        public partial class OperationServiceClient : ClientBase<OperationServiceClient>
        {
            /// <summary>Creates a new client for OperationService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public OperationServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for OperationService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public OperationServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected OperationServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected OperationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Get a operation
            ///
            /// Retrieves an existing long-running operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Operation GetOperation(GetOperationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetOperation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a operation
            ///
            /// Retrieves an existing long-running operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Operation GetOperation(GetOperationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetOperation, null, options, request);
            /// <summary>
            /// Get a operation
            ///
            /// Retrieves an existing long-running operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Operation> GetOperationAsync(GetOperationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetOperationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get a operation
            ///
            /// Retrieves an existing long-running operation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Operation> GetOperationAsync(GetOperationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetOperation, null, options, request);
            }

            /// <summary>
            /// List operations
            ///
            /// Returns a list of long-running operations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListOperationsResponse ListOperations(ListOperationsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListOperations(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List operations
            ///
            /// Returns a list of long-running operations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListOperationsResponse ListOperations(ListOperationsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListOperations, null, options, request);
            /// <summary>
            /// List operations
            ///
            /// Returns a list of long-running operations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListOperationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List operations
            ///
            /// Returns a list of long-running operations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListOperations, null, options, request);
            }

            /// <summary>
            /// Delete an operation
            ///
            /// Permanently deletes a long-running operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteOperation(DeleteOperationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteOperation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an operation
            ///
            /// Permanently deletes a long-running operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteOperation(DeleteOperationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteOperation, null, options, request);
            /// <summary>
            /// Delete an operation
            ///
            /// Permanently deletes a long-running operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteOperationAsync(DeleteOperationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteOperationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an operation
            ///
            /// Permanently deletes a long-running operation. This cannot be undone.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteOperationAsync(DeleteOperationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteOperation, null, options, request);
            }

            /// <summary>
            /// Cancel an operation
            ///
            /// Starts asynchronous cancellation on a long-running operation. The server
            /// makes a best effort to cancel the operation, but success is not
            /// guaranteed. Clients can use
            /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
            /// or other methods to check whether the cancellation succeeded or whether
            /// the operation completed despite cancellation. On successful cancellation,
            /// the operation is not deleted; instead, it becomes an operation with an
            /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
            /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
            /// `Code.CANCELLED`.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty CancelOperation(CancelOperationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CancelOperation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Cancel an operation
            ///
            /// Starts asynchronous cancellation on a long-running operation. The server
            /// makes a best effort to cancel the operation, but success is not
            /// guaranteed. Clients can use
            /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
            /// or other methods to check whether the cancellation succeeded or whether
            /// the operation completed despite cancellation. On successful cancellation,
            /// the operation is not deleted; instead, it becomes an operation with an
            /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
            /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
            /// `Code.CANCELLED`.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty CancelOperation(CancelOperationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CancelOperation, null, options, request);
            /// <summary>
            /// Cancel an operation
            ///
            /// Starts asynchronous cancellation on a long-running operation. The server
            /// makes a best effort to cancel the operation, but success is not
            /// guaranteed. Clients can use
            /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
            /// or other methods to check whether the cancellation succeeded or whether
            /// the operation completed despite cancellation. On successful cancellation,
            /// the operation is not deleted; instead, it becomes an operation with an
            /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
            /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
            /// `Code.CANCELLED`.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> CancelOperationAsync(CancelOperationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CancelOperationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Cancel an operation
            ///
            /// Starts asynchronous cancellation on a long-running operation. The server
            /// makes a best effort to cancel the operation, but success is not
            /// guaranteed. Clients can use
            /// [OperationService.GetOperation][salto.longrunning.v1.OperationService.GetOperation]
            /// or other methods to check whether the cancellation succeeded or whether
            /// the operation completed despite cancellation. On successful cancellation,
            /// the operation is not deleted; instead, it becomes an operation with an
            /// [Operation.error][salto.longrunning.v1.Operation.error] value with a
            /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
            /// `Code.CANCELLED`.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> CancelOperationAsync(CancelOperationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CancelOperation, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override OperationServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
