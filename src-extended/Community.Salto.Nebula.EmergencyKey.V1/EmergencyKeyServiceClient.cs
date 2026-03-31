using Salto.Nebula.EmergencyKey.V1.Request;
using Salto.Nebula.EmergencyKey.V1.Response;

namespace Salto.Nebula.EmergencyKey.V1
{
    public static partial class EmergencyKeyService
    {
        /// <summary>Client for EmergencyKeyService</summary>
        public partial class EmergencyKeyServiceClient : ClientBase<EmergencyKeyServiceClient>
        {
            /// <summary>Creates a new client for EmergencyKeyService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public EmergencyKeyServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for EmergencyKeyService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public EmergencyKeyServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected EmergencyKeyServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected EmergencyKeyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an emergency key
            ///
            /// Creates a new emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual EmergencyKey CreateEmergencyKey(CreateEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateEmergencyKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an emergency key
            ///
            /// Creates a new emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual EmergencyKey CreateEmergencyKey(CreateEmergencyKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateEmergencyKey, null, options, request);
            /// <summary>
            /// Create an emergency key
            ///
            /// Creates a new emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<EmergencyKey> CreateEmergencyKeyAsync(CreateEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateEmergencyKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an emergency key
            ///
            /// Creates a new emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<EmergencyKey> CreateEmergencyKeyAsync(CreateEmergencyKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateEmergencyKey, null, options, request);
            }

            /// <summary>
            /// Get an emergency key
            ///
            /// Retrieves an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual EmergencyKey GetEmergencyKey(GetEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetEmergencyKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an emergency key
            ///
            /// Retrieves an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual EmergencyKey GetEmergencyKey(GetEmergencyKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetEmergencyKey, null, options, request);
            /// <summary>
            /// Get an emergency key
            ///
            /// Retrieves an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<EmergencyKey> GetEmergencyKeyAsync(GetEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetEmergencyKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an emergency key
            ///
            /// Retrieves an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<EmergencyKey> GetEmergencyKeyAsync(GetEmergencyKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetEmergencyKey, null, options, request);
            }

            /// <summary>
            /// List emergency keys
            ///
            /// Returns a list of emergency keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEmergencyKeysResponse ListEmergencyKeys(ListEmergencyKeysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListEmergencyKeys(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List emergency keys
            ///
            /// Returns a list of emergency keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListEmergencyKeysResponse ListEmergencyKeys(ListEmergencyKeysRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListEmergencyKeys, null, options, request);
            /// <summary>
            /// List emergency keys
            ///
            /// Returns a list of emergency keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEmergencyKeysResponse> ListEmergencyKeysAsync(ListEmergencyKeysRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListEmergencyKeysAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List emergency keys
            ///
            /// Returns a list of emergency keys that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListEmergencyKeysResponse> ListEmergencyKeysAsync(ListEmergencyKeysRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListEmergencyKeys, null, options, request);
            }

            /// <summary>
            /// Update an emergency key
            ///
            /// Updates an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual EmergencyKey UpdateEmergencyKey(UpdateEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateEmergencyKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an emergency key
            ///
            /// Updates an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual EmergencyKey UpdateEmergencyKey(UpdateEmergencyKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateEmergencyKey, null, options, request);
            /// <summary>
            /// Update an emergency key
            ///
            /// Updates an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<EmergencyKey> UpdateEmergencyKeyAsync(UpdateEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateEmergencyKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an emergency key
            ///
            /// Updates an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<EmergencyKey> UpdateEmergencyKeyAsync(UpdateEmergencyKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateEmergencyKey, null, options, request);
            }

            /// <summary>
            /// Delete an emergency key
            ///
            /// Deletes an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteEmergencyKey(DeleteEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteEmergencyKey(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an emergency key
            ///
            /// Deletes an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Google.Protobuf.WellKnownTypes.Empty DeleteEmergencyKey(DeleteEmergencyKeyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteEmergencyKey, null, options, request);
            /// <summary>
            /// Delete an emergency key
            ///
            /// Deletes an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteEmergencyKeyAsync(DeleteEmergencyKeyRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteEmergencyKeyAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an emergency key
            ///
            /// Deletes an existing emergency key.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Google.Protobuf.WellKnownTypes.Empty> DeleteEmergencyKeyAsync(DeleteEmergencyKeyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteEmergencyKey, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override EmergencyKeyServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
