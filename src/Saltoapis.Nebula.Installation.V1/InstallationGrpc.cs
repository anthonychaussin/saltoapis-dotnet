using Grpc.Core;
using Saltoapis.Nebula.Installation.V1.Request;
using Saltoapis.Nebula.Installation.V1.Response;

namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>
    /// An installation represents any entity such as a company, office or building
    /// that contains all the access control objects (access points, access rights,
    /// users, etc.) that comprise the access control system within a facility.
    /// </summary>
    public static partial class InstallationService
    {
        static readonly string __ServiceName = "salto.nebula.installation.v1.InstallationService";

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

        static readonly Marshaller<CreateInstallationRequest> __Marshaller_salto_nebula_installation_v1_CreateInstallationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateInstallationRequest.Parser));

        static readonly Marshaller<Installation> __Marshaller_salto_nebula_installation_v1_Installation = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Installation.Parser));

        static readonly Marshaller<GetInstallationRequest> __Marshaller_salto_nebula_installation_v1_GetInstallationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetInstallationRequest.Parser));

        static readonly Marshaller<ListInstallationsRequest> __Marshaller_salto_nebula_installation_v1_ListInstallationsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListInstallationsRequest.Parser));

        static readonly Marshaller<ListInstallationsResponse> __Marshaller_salto_nebula_installation_v1_ListInstallationsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListInstallationsResponse.Parser));

        static readonly Marshaller<UpdateInstallationRequest> __Marshaller_salto_nebula_installation_v1_UpdateInstallationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateInstallationRequest.Parser));

        static readonly Marshaller<DeleteInstallationRequest> __Marshaller_salto_nebula_installation_v1_DeleteInstallationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteInstallationRequest.Parser));

        static readonly Marshaller<UndeleteInstallationRequest> __Marshaller_salto_nebula_installation_v1_UndeleteInstallationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UndeleteInstallationRequest.Parser));

        static readonly Marshaller<CreatePolicyRequest> __Marshaller_salto_nebula_installation_v1_CreatePolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreatePolicyRequest.Parser));

        static readonly Marshaller<Policy> __Marshaller_salto_nebula_installation_v1_Policy = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Policy.Parser));

        static readonly Marshaller<GetPolicyRequest> __Marshaller_salto_nebula_installation_v1_GetPolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetPolicyRequest.Parser));

        static readonly Marshaller<ListPoliciesRequest> __Marshaller_salto_nebula_installation_v1_ListPoliciesRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListPoliciesRequest.Parser));

        static readonly Marshaller<ListPoliciesResponse> __Marshaller_salto_nebula_installation_v1_ListPoliciesResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListPoliciesResponse.Parser));

        static readonly Marshaller<UpdatePolicyRequest> __Marshaller_salto_nebula_installation_v1_UpdatePolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdatePolicyRequest.Parser));

        static readonly Marshaller<DeletePolicyRequest> __Marshaller_salto_nebula_installation_v1_DeletePolicyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeletePolicyRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Marshaller<TestPermissionsRequest> __Marshaller_salto_nebula_installation_v1_TestPermissionsRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, TestPermissionsRequest.Parser));

        static readonly Marshaller<TestPermissionsResponse> __Marshaller_salto_nebula_installation_v1_TestPermissionsResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, TestPermissionsResponse.Parser));

        static readonly Marshaller<TransferInstallationOwnershipRequest> __Marshaller_salto_nebula_installation_v1_TransferInstallationOwnershipRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, TransferInstallationOwnershipRequest.Parser));

        static readonly Marshaller<TransferInstallationOwnershipResponse> __Marshaller_salto_nebula_installation_v1_TransferInstallationOwnershipResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, TransferInstallationOwnershipResponse.Parser));

        static readonly Marshaller<AcceptInstallationOwnershipRequest> __Marshaller_salto_nebula_installation_v1_AcceptInstallationOwnershipRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, AcceptInstallationOwnershipRequest.Parser));

        static readonly Marshaller<AcceptInstallationOwnershipResponse> __Marshaller_salto_nebula_installation_v1_AcceptInstallationOwnershipResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, AcceptInstallationOwnershipResponse.Parser));

        static readonly Marshaller<GetSubscriptionRequest> __Marshaller_salto_nebula_installation_v1_GetSubscriptionRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetSubscriptionRequest.Parser));

        static readonly Marshaller<Subscription> __Marshaller_salto_nebula_installation_v1_Subscription = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Subscription.Parser));

        static readonly Marshaller<UpdateBillingInfoRequest> __Marshaller_salto_nebula_installation_v1_UpdateBillingInfoRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateBillingInfoRequest.Parser));

        static readonly Marshaller<BillingInfo> __Marshaller_salto_nebula_installation_v1_BillingInfo = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, BillingInfo.Parser));

        static readonly Marshaller<UpdatePaymentMethodRequest> __Marshaller_salto_nebula_installation_v1_UpdatePaymentMethodRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdatePaymentMethodRequest.Parser));

        static readonly Marshaller<PaymentMethod> __Marshaller_salto_nebula_installation_v1_PaymentMethod = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, PaymentMethod.Parser));

        static readonly Marshaller<UpdateCardRequest> __Marshaller_salto_nebula_installation_v1_UpdateCardRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateCardRequest.Parser));

        static readonly Marshaller<UpdateCardResponse> __Marshaller_salto_nebula_installation_v1_UpdateCardResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateCardResponse.Parser));

        static readonly Marshaller<CreatePaymentAuthorizationRequest> __Marshaller_salto_nebula_installation_v1_CreatePaymentAuthorizationRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreatePaymentAuthorizationRequest.Parser));

        static readonly Marshaller<PaymentAuthorization> __Marshaller_salto_nebula_installation_v1_PaymentAuthorization = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, PaymentAuthorization.Parser));

        static readonly Marshaller<ListInvoicesRequest> __Marshaller_salto_nebula_installation_v1_ListInvoicesRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListInvoicesRequest.Parser));

        static readonly Marshaller<ListInvoicesResponse> __Marshaller_salto_nebula_installation_v1_ListInvoicesResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListInvoicesResponse.Parser));

        static readonly Marshaller<ApplyCouponRequest> __Marshaller_salto_nebula_installation_v1_ApplyCouponRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ApplyCouponRequest.Parser));

        static readonly Marshaller<ApplyCouponResponse> __Marshaller_salto_nebula_installation_v1_ApplyCouponResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ApplyCouponResponse.Parser));

        static readonly Marshaller<UnapplyCouponRequest> __Marshaller_salto_nebula_installation_v1_UnapplyCouponRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnapplyCouponRequest.Parser));

        static readonly Marshaller<UnapplyCouponResponse> __Marshaller_salto_nebula_installation_v1_UnapplyCouponResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UnapplyCouponResponse.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenRequest> __Marshaller_salto_nebula_installation_v1_GenerateAuthorizationTokenRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenRequest.Parser));

        static readonly Marshaller<GenerateAuthorizationTokenResponse> __Marshaller_salto_nebula_installation_v1_GenerateAuthorizationTokenResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GenerateAuthorizationTokenResponse.Parser));

        static readonly Method<CreateInstallationRequest, Installation> __Method_CreateInstallation = new(
            MethodType.Unary,
            __ServiceName,
            "CreateInstallation",
            __Marshaller_salto_nebula_installation_v1_CreateInstallationRequest,
            __Marshaller_salto_nebula_installation_v1_Installation);

        static readonly Method<GetInstallationRequest, Installation> __Method_GetInstallation = new(
            MethodType.Unary,
            __ServiceName,
            "GetInstallation",
            __Marshaller_salto_nebula_installation_v1_GetInstallationRequest,
            __Marshaller_salto_nebula_installation_v1_Installation);

        static readonly Method<ListInstallationsRequest, ListInstallationsResponse> __Method_ListInstallations = new(
            MethodType.Unary,
            __ServiceName,
            "ListInstallations",
            __Marshaller_salto_nebula_installation_v1_ListInstallationsRequest,
            __Marshaller_salto_nebula_installation_v1_ListInstallationsResponse);

        static readonly Method<UpdateInstallationRequest, Installation> __Method_UpdateInstallation = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateInstallation",
            __Marshaller_salto_nebula_installation_v1_UpdateInstallationRequest,
            __Marshaller_salto_nebula_installation_v1_Installation);

        static readonly Method<DeleteInstallationRequest, Installation> __Method_DeleteInstallation = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteInstallation",
            __Marshaller_salto_nebula_installation_v1_DeleteInstallationRequest,
            __Marshaller_salto_nebula_installation_v1_Installation);

        static readonly Method<UndeleteInstallationRequest, Installation> __Method_UndeleteInstallation = new(
            MethodType.Unary,
            __ServiceName,
            "UndeleteInstallation",
            __Marshaller_salto_nebula_installation_v1_UndeleteInstallationRequest,
            __Marshaller_salto_nebula_installation_v1_Installation);

        static readonly Method<CreatePolicyRequest, Policy> __Method_CreatePolicy = new(
            MethodType.Unary,
            __ServiceName,
            "CreatePolicy",
            __Marshaller_salto_nebula_installation_v1_CreatePolicyRequest,
            __Marshaller_salto_nebula_installation_v1_Policy);

        static readonly Method<GetPolicyRequest, Policy> __Method_GetPolicy = new(
            MethodType.Unary,
            __ServiceName,
            "GetPolicy",
            __Marshaller_salto_nebula_installation_v1_GetPolicyRequest,
            __Marshaller_salto_nebula_installation_v1_Policy);

        static readonly Method<ListPoliciesRequest, ListPoliciesResponse> __Method_ListPolicies = new(
            MethodType.Unary,
            __ServiceName,
            "ListPolicies",
            __Marshaller_salto_nebula_installation_v1_ListPoliciesRequest,
            __Marshaller_salto_nebula_installation_v1_ListPoliciesResponse);

        static readonly Method<UpdatePolicyRequest, Policy> __Method_UpdatePolicy = new(
            MethodType.Unary,
            __ServiceName,
            "UpdatePolicy",
            __Marshaller_salto_nebula_installation_v1_UpdatePolicyRequest,
            __Marshaller_salto_nebula_installation_v1_Policy);

        static readonly Method<DeletePolicyRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeletePolicy = new(
            MethodType.Unary,
            __ServiceName,
            "DeletePolicy",
            __Marshaller_salto_nebula_installation_v1_DeletePolicyRequest,
            __Marshaller_google_protobuf_Empty);

        static readonly Method<TestPermissionsRequest, TestPermissionsResponse> __Method_TestPermissions = new(
            MethodType.Unary,
            __ServiceName,
            "TestPermissions",
            __Marshaller_salto_nebula_installation_v1_TestPermissionsRequest,
            __Marshaller_salto_nebula_installation_v1_TestPermissionsResponse);

        static readonly Method<TransferInstallationOwnershipRequest, TransferInstallationOwnershipResponse> __Method_TransferInstallationOwnership = new(
            MethodType.Unary,
            __ServiceName,
            "TransferInstallationOwnership",
            __Marshaller_salto_nebula_installation_v1_TransferInstallationOwnershipRequest,
            __Marshaller_salto_nebula_installation_v1_TransferInstallationOwnershipResponse);

        static readonly Method<AcceptInstallationOwnershipRequest, AcceptInstallationOwnershipResponse> __Method_AcceptInstallationOwnership = new(
            MethodType.Unary,
            __ServiceName,
            "AcceptInstallationOwnership",
            __Marshaller_salto_nebula_installation_v1_AcceptInstallationOwnershipRequest,
            __Marshaller_salto_nebula_installation_v1_AcceptInstallationOwnershipResponse);

        static readonly Method<GetSubscriptionRequest, Subscription> __Method_GetSubscription = new(
            MethodType.Unary,
            __ServiceName,
            "GetSubscription",
            __Marshaller_salto_nebula_installation_v1_GetSubscriptionRequest,
            __Marshaller_salto_nebula_installation_v1_Subscription);

        static readonly Method<UpdateBillingInfoRequest, BillingInfo> __Method_UpdateBillingInfo = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateBillingInfo",
            __Marshaller_salto_nebula_installation_v1_UpdateBillingInfoRequest,
            __Marshaller_salto_nebula_installation_v1_BillingInfo);

        static readonly Method<UpdatePaymentMethodRequest, PaymentMethod> __Method_UpdatePaymentMethod = new(
            MethodType.Unary,
            __ServiceName,
            "UpdatePaymentMethod",
            __Marshaller_salto_nebula_installation_v1_UpdatePaymentMethodRequest,
            __Marshaller_salto_nebula_installation_v1_PaymentMethod);

        static readonly Method<UpdateCardRequest, UpdateCardResponse> __Method_UpdateCard = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateCard",
            __Marshaller_salto_nebula_installation_v1_UpdateCardRequest,
            __Marshaller_salto_nebula_installation_v1_UpdateCardResponse);

        static readonly Method<CreatePaymentAuthorizationRequest, PaymentAuthorization> __Method_CreatePaymentAuthorization = new(
            MethodType.Unary,
            __ServiceName,
            "CreatePaymentAuthorization",
            __Marshaller_salto_nebula_installation_v1_CreatePaymentAuthorizationRequest,
            __Marshaller_salto_nebula_installation_v1_PaymentAuthorization);

        static readonly Method<ListInvoicesRequest, ListInvoicesResponse> __Method_ListInvoices = new(
            MethodType.Unary,
            __ServiceName,
            "ListInvoices",
            __Marshaller_salto_nebula_installation_v1_ListInvoicesRequest,
            __Marshaller_salto_nebula_installation_v1_ListInvoicesResponse);

        static readonly Method<ApplyCouponRequest, ApplyCouponResponse> __Method_ApplyCoupon = new(
            MethodType.Unary,
            __ServiceName,
            "ApplyCoupon",
            __Marshaller_salto_nebula_installation_v1_ApplyCouponRequest,
            __Marshaller_salto_nebula_installation_v1_ApplyCouponResponse);

        static readonly Method<UnapplyCouponRequest, UnapplyCouponResponse> __Method_UnapplyCoupon = new(
            MethodType.Unary,
            __ServiceName,
            "UnapplyCoupon",
            __Marshaller_salto_nebula_installation_v1_UnapplyCouponRequest,
            __Marshaller_salto_nebula_installation_v1_UnapplyCouponResponse);

        static readonly Method<GenerateAuthorizationTokenRequest, GenerateAuthorizationTokenResponse> __Method_GenerateAuthorizationToken = new(
            MethodType.Unary,
            __ServiceName,
            "GenerateAuthorizationToken",
            __Marshaller_salto_nebula_installation_v1_GenerateAuthorizationTokenRequest,
            __Marshaller_salto_nebula_installation_v1_GenerateAuthorizationTokenResponse);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for InstallationService</summary>
        public partial class InstallationServiceClient : ClientBase<InstallationServiceClient>
        {
            /// <summary>Creates a new client for InstallationService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public InstallationServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for InstallationService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public InstallationServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected InstallationServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected InstallationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Create an installation
            ///
            /// Creates a new installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation CreateInstallation(CreateInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreateInstallation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create an installation
            ///
            /// Creates a new installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation CreateInstallation(CreateInstallationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateInstallation, null, options, request);
            /// <summary>
            /// Create an installation
            ///
            /// Creates a new installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> CreateInstallationAsync(CreateInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreateInstallationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create an installation
            ///
            /// Creates a new installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> CreateInstallationAsync(CreateInstallationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreateInstallation, null, options, request);
            }

            /// <summary>
            /// Get an installation
            ///
            /// Retrieves an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation GetInstallation(GetInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetInstallation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get an installation
            ///
            /// Retrieves an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation GetInstallation(GetInstallationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetInstallation, null, options, request);
            /// <summary>
            /// Get an installation
            ///
            /// Retrieves an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> GetInstallationAsync(GetInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetInstallationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get an installation
            ///
            /// Retrieves an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> GetInstallationAsync(GetInstallationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetInstallation, null, options, request);
            }

            /// <summary>
            /// List installations
            ///
            /// Returns a list of installations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListInstallationsResponse ListInstallations(ListInstallationsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListInstallations(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List installations
            ///
            /// Returns a list of installations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListInstallationsResponse ListInstallations(ListInstallationsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListInstallations, null, options, request);
            /// <summary>
            /// List installations
            ///
            /// Returns a list of installations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListInstallationsResponse> ListInstallationsAsync(ListInstallationsRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListInstallationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List installations
            ///
            /// Returns a list of installations that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListInstallationsResponse> ListInstallationsAsync(ListInstallationsRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListInstallations, null, options, request);
            }

            /// <summary>
            /// Update an installation
            ///
            /// Updates an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation UpdateInstallation(UpdateInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateInstallation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update an installation
            ///
            /// Updates an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation UpdateInstallation(UpdateInstallationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateInstallation, null, options, request);
            /// <summary>
            /// Update an installation
            ///
            /// Updates an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> UpdateInstallationAsync(UpdateInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateInstallationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update an installation
            ///
            /// Updates an existing installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> UpdateInstallationAsync(UpdateInstallationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateInstallation, null, options, request);
            }

            /// <summary>
            /// Delete an installation
            ///
            /// Soft deletes an installation. This action can be reversed if required.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation DeleteInstallation(DeleteInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => DeleteInstallation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Delete an installation
            ///
            /// Soft deletes an installation. This action can be reversed if required.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation DeleteInstallation(DeleteInstallationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_DeleteInstallation, null, options, request);
            /// <summary>
            /// Delete an installation
            ///
            /// Soft deletes an installation. This action can be reversed if required.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> DeleteInstallationAsync(DeleteInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return DeleteInstallationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Delete an installation
            ///
            /// Soft deletes an installation. This action can be reversed if required.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> DeleteInstallationAsync(DeleteInstallationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_DeleteInstallation, null, options, request);
            }

            /// <summary>
            /// Undelete an installation
            ///
            /// Undeletes an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation UndeleteInstallation(UndeleteInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UndeleteInstallation(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Undelete an installation
            ///
            /// Undeletes an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Installation UndeleteInstallation(UndeleteInstallationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UndeleteInstallation, null, options, request);
            /// <summary>
            /// Undelete an installation
            ///
            /// Undeletes an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> UndeleteInstallationAsync(UndeleteInstallationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UndeleteInstallationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Undelete an installation
            ///
            /// Undeletes an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Installation> UndeleteInstallationAsync(UndeleteInstallationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UndeleteInstallation, null, options, request);
            }

            /// <summary>
            /// Create a policy
            ///
            /// Creates a policy for the installation. An IAM policy is a collection of
            /// roles associated to users that define who has what type of access to manage
            /// access control objects within the installation.
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
            /// Creates a policy for the installation. An IAM policy is a collection of
            /// roles associated to users that define who has what type of access to manage
            /// access control objects within the installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy CreatePolicy(CreatePolicyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreatePolicy, null, options, request);
            /// <summary>
            /// Create a policy
            ///
            /// Creates a policy for the installation. An IAM policy is a collection of
            /// roles associated to users that define who has what type of access to manage
            /// access control objects within the installation.
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
            /// Creates a policy for the installation. An IAM policy is a collection of
            /// roles associated to users that define who has what type of access to manage
            /// access control objects within the installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Policy> CreatePolicyAsync(CreatePolicyRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreatePolicy, null, options, request);
            }

            /// <summary>
            /// Get a policy
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
            /// Get a policy
            ///
            /// Retrieves an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy GetPolicy(GetPolicyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetPolicy, null, options, request);
            /// <summary>
            /// Get a policy
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
            /// Get a policy
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
            /// Update a policy
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
            /// Update a policy
            ///
            /// Updates an existing policy.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Policy UpdatePolicy(UpdatePolicyRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdatePolicy, null, options, request);
            /// <summary>
            /// Update a policy
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
            /// Update a policy
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
            /// Tests permissions
            ///
            /// Returns permissions that a caller has within the installation. If the
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
            /// Tests permissions
            ///
            /// Returns permissions that a caller has within the installation. If the
            /// installation does not exist, this will return an empty set of
            /// permissions, not a NOT_FOUND error.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual TestPermissionsResponse TestPermissions(TestPermissionsRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_TestPermissions, null, options, request);
            /// <summary>
            /// Tests permissions
            ///
            /// Returns permissions that a caller has within the installation. If the
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
            /// Tests permissions
            ///
            /// Returns permissions that a caller has within the installation. If the
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

            /// <summary>
            /// Transfer installation ownership
            ///
            /// Transfers the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual TransferInstallationOwnershipResponse TransferInstallationOwnership(TransferInstallationOwnershipRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => TransferInstallationOwnership(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Transfer installation ownership
            ///
            /// Transfers the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual TransferInstallationOwnershipResponse TransferInstallationOwnership(TransferInstallationOwnershipRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_TransferInstallationOwnership, null, options, request);
            /// <summary>
            /// Transfer installation ownership
            ///
            /// Transfers the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<TransferInstallationOwnershipResponse> TransferInstallationOwnershipAsync(TransferInstallationOwnershipRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return TransferInstallationOwnershipAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Transfer installation ownership
            ///
            /// Transfers the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<TransferInstallationOwnershipResponse> TransferInstallationOwnershipAsync(TransferInstallationOwnershipRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_TransferInstallationOwnership, null, options, request);
            }

            /// <summary>
            /// Accept installation ownership
            ///
            /// Accepts the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AcceptInstallationOwnershipResponse AcceptInstallationOwnership(AcceptInstallationOwnershipRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => AcceptInstallationOwnership(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Accept installation ownership
            ///
            /// Accepts the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual AcceptInstallationOwnershipResponse AcceptInstallationOwnership(AcceptInstallationOwnershipRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_AcceptInstallationOwnership, null, options, request);
            /// <summary>
            /// Accept installation ownership
            ///
            /// Accepts the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AcceptInstallationOwnershipResponse> AcceptInstallationOwnershipAsync(AcceptInstallationOwnershipRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return AcceptInstallationOwnershipAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Accept installation ownership
            ///
            /// Accepts the ownership of an installation.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<AcceptInstallationOwnershipResponse> AcceptInstallationOwnershipAsync(AcceptInstallationOwnershipRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_AcceptInstallationOwnership, null, options, request);
            }

            /// <summary>
            /// Get a subscription
            ///
            /// Gets an existing subscription
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Subscription GetSubscription(GetSubscriptionRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetSubscription(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a subscription
            ///
            /// Gets an existing subscription
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Subscription GetSubscription(GetSubscriptionRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetSubscription, null, options, request);
            /// <summary>
            /// Get a subscription
            ///
            /// Gets an existing subscription
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetSubscriptionAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get a subscription
            ///
            /// Gets an existing subscription
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetSubscription, null, options, request);
            }

            /// <summary>
            /// Update a subscription's billing information
            ///
            /// Updates an existing subscription's billing information.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BillingInfo UpdateBillingInfo(UpdateBillingInfoRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateBillingInfo(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update a subscription's billing information
            ///
            /// Updates an existing subscription's billing information.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual BillingInfo UpdateBillingInfo(UpdateBillingInfoRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateBillingInfo, null, options, request);
            /// <summary>
            /// Update a subscription's billing information
            ///
            /// Updates an existing subscription's billing information.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BillingInfo> UpdateBillingInfoAsync(UpdateBillingInfoRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateBillingInfoAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update a subscription's billing information
            ///
            /// Updates an existing subscription's billing information.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<BillingInfo> UpdateBillingInfoAsync(UpdateBillingInfoRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateBillingInfo, null, options, request);
            }

            /// <summary>
            /// Update subscription payment method
            ///
            /// Updates an existing subscription payment method. If there is a payment
            /// method associated with the subscription, it will be deleted.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual PaymentMethod UpdatePaymentMethod(UpdatePaymentMethodRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdatePaymentMethod(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update subscription payment method
            ///
            /// Updates an existing subscription payment method. If there is a payment
            /// method associated with the subscription, it will be deleted.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual PaymentMethod UpdatePaymentMethod(UpdatePaymentMethodRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdatePaymentMethod, null, options, request);
            /// <summary>
            /// Update subscription payment method
            ///
            /// Updates an existing subscription payment method. If there is a payment
            /// method associated with the subscription, it will be deleted.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<PaymentMethod> UpdatePaymentMethodAsync(UpdatePaymentMethodRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdatePaymentMethodAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update subscription payment method
            ///
            /// Updates an existing subscription payment method. If there is a payment
            /// method associated with the subscription, it will be deleted.
            /// (-- api-linter: core::0134::method-signature=disabled
            ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<PaymentMethod> UpdatePaymentMethodAsync(UpdatePaymentMethodRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdatePaymentMethod, null, options, request);
            }

            /// <summary>
            /// Update subscription payment method's card
            ///
            /// Updates subscription payment method's card. If there is a payment method
            /// associated with the subscription, it will be deleted.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UpdateCardResponse UpdateCard(UpdateCardRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UpdateCard(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Update subscription payment method's card
            ///
            /// Updates subscription payment method's card. If there is a payment method
            /// associated with the subscription, it will be deleted.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UpdateCardResponse UpdateCard(UpdateCardRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UpdateCard, null, options, request);
            /// <summary>
            /// Update subscription payment method's card
            ///
            /// Updates subscription payment method's card. If there is a payment method
            /// associated with the subscription, it will be deleted.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UpdateCardAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Update subscription payment method's card
            ///
            /// Updates subscription payment method's card. If there is a payment method
            /// associated with the subscription, it will be deleted.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UpdateCard, null, options, request);
            }

            /// <summary>
            /// Create a payment authorization
            ///
            /// Creates a payment authorization for the subscription.
            /// The payment authorization is a process that allows the customer to
            /// authorize a payment card for future use. This is done by creating a payment
            /// authorization request. The result of the request is a payment authorization
            /// that must be authorized by the client in the client's UI.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual PaymentAuthorization CreatePaymentAuthorization(CreatePaymentAuthorizationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => CreatePaymentAuthorization(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a payment authorization
            ///
            /// Creates a payment authorization for the subscription.
            /// The payment authorization is a process that allows the customer to
            /// authorize a payment card for future use. This is done by creating a payment
            /// authorization request. The result of the request is a payment authorization
            /// that must be authorized by the client in the client's UI.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual PaymentAuthorization CreatePaymentAuthorization(CreatePaymentAuthorizationRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreatePaymentAuthorization, null, options, request);
            /// <summary>
            /// Create a payment authorization
            ///
            /// Creates a payment authorization for the subscription.
            /// The payment authorization is a process that allows the customer to
            /// authorize a payment card for future use. This is done by creating a payment
            /// authorization request. The result of the request is a payment authorization
            /// that must be authorized by the client in the client's UI.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<PaymentAuthorization> CreatePaymentAuthorizationAsync(CreatePaymentAuthorizationRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return CreatePaymentAuthorizationAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Create a payment authorization
            ///
            /// Creates a payment authorization for the subscription.
            /// The payment authorization is a process that allows the customer to
            /// authorize a payment card for future use. This is done by creating a payment
            /// authorization request. The result of the request is a payment authorization
            /// that must be authorized by the client in the client's UI.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<PaymentAuthorization> CreatePaymentAuthorizationAsync(CreatePaymentAuthorizationRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_CreatePaymentAuthorization, null, options, request);
            }

            /// <summary>
            /// List invoices
            ///
            /// Returns a list of invoices.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListInvoicesResponse ListInvoices(ListInvoicesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListInvoices(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List invoices
            ///
            /// Returns a list of invoices.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListInvoicesResponse ListInvoices(ListInvoicesRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListInvoices, null, options, request);
            /// <summary>
            /// List invoices
            ///
            /// Returns a list of invoices.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListInvoicesResponse> ListInvoicesAsync(ListInvoicesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListInvoicesAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List invoices
            ///
            /// Returns a list of invoices.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListInvoicesResponse> ListInvoicesAsync(ListInvoicesRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListInvoices, null, options, request);
            }

            /// <summary>
            /// Apply a coupon
            ///
            /// Applies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ApplyCouponResponse ApplyCoupon(ApplyCouponRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ApplyCoupon(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Apply a coupon
            ///
            /// Applies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ApplyCouponResponse ApplyCoupon(ApplyCouponRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ApplyCoupon, null, options, request);
            /// <summary>
            /// Apply a coupon
            ///
            /// Applies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ApplyCouponResponse> ApplyCouponAsync(ApplyCouponRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ApplyCouponAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Apply a coupon
            ///
            /// Applies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ApplyCouponResponse> ApplyCouponAsync(ApplyCouponRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ApplyCoupon, null, options, request);
            }

            /// <summary>
            /// Unapply a coupon
            ///
            /// Unapplies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnapplyCouponResponse UnapplyCoupon(UnapplyCouponRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => UnapplyCoupon(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Unapply a coupon
            ///
            /// Unapplies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual UnapplyCouponResponse UnapplyCoupon(UnapplyCouponRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_UnapplyCoupon, null, options, request);
            /// <summary>
            /// Unapply a coupon
            ///
            /// Unapplies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnapplyCouponResponse> UnapplyCouponAsync(UnapplyCouponRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return UnapplyCouponAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Unapply a coupon
            ///
            /// Unapplies a coupon to the subscription.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<UnapplyCouponResponse> UnapplyCouponAsync(UnapplyCouponRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_UnapplyCoupon, null, options, request);
            }

            /// <summary>
            /// Generate authorization token for uninitialized devices
            ///
            /// Generates an authorization token for a client application to use when
            /// connecting to an uninitialized Salto device. The token contains the
            /// necessary security material for the client to validate the device's
            /// identity. This prevents man-in-the-middle (MITM) attacks and ensures the
            /// client is connecting to a genuine Salto device during its initial
            /// initialization.
            ///
            /// This token is distinct from other `GenerateAuthorizationToken` methods, it
            /// is used only for the client to validate the device and does not contain a
            /// client certificate for authenticating the client itself.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GenerateAuthorizationToken(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Generate authorization token for uninitialized devices
            ///
            /// Generates an authorization token for a client application to use when
            /// connecting to an uninitialized Salto device. The token contains the
            /// necessary security material for the client to validate the device's
            /// identity. This prevents man-in-the-middle (MITM) attacks and ensures the
            /// client is connecting to a genuine Salto device during its initial
            /// initialization.
            ///
            /// This token is distinct from other `GenerateAuthorizationToken` methods, it
            /// is used only for the client to validate the device and does not contain a
            /// client certificate for authenticating the client itself.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual GenerateAuthorizationTokenResponse GenerateAuthorizationToken(GenerateAuthorizationTokenRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            /// <summary>
            /// Generate authorization token for uninitialized devices
            ///
            /// Generates an authorization token for a client application to use when
            /// connecting to an uninitialized Salto device. The token contains the
            /// necessary security material for the client to validate the device's
            /// identity. This prevents man-in-the-middle (MITM) attacks and ensures the
            /// client is connecting to a genuine Salto device during its initial
            /// initialization.
            ///
            /// This token is distinct from other `GenerateAuthorizationToken` methods, it
            /// is used only for the client to validate the device and does not contain a
            /// client certificate for authenticating the client itself.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GenerateAuthorizationTokenAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Generate authorization token for uninitialized devices
            ///
            /// Generates an authorization token for a client application to use when
            /// connecting to an uninitialized Salto device. The token contains the
            /// necessary security material for the client to validate the device's
            /// identity. This prevents man-in-the-middle (MITM) attacks and ensures the
            /// client is connecting to a genuine Salto device during its initial
            /// initialization.
            ///
            /// This token is distinct from other `GenerateAuthorizationToken` methods, it
            /// is used only for the client to validate the device and does not contain a
            /// client certificate for authenticating the client itself.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<GenerateAuthorizationTokenResponse> GenerateAuthorizationTokenAsync(GenerateAuthorizationTokenRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GenerateAuthorizationToken, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override InstallationServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
