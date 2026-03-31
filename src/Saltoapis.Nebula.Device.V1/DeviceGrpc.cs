using Grpc.Core;

namespace Saltoapis.Nebula.Device.V1
{
    /// <summary>
    /// A device could be an electronic lock, gateway, extender or any piece of
    /// hardware manufactured by SALTO. This service provides access to an aggregated
    /// view of all of them in an eventual consistent way.
    /// </summary>
    public static partial class DeviceService
    {
        static readonly string __ServiceName = "salto.nebula.device.v1.DeviceService";

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

        static readonly Marshaller<GetDeviceRequest> __Marshaller_salto_nebula_device_v1_GetDeviceRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetDeviceRequest.Parser));

        static readonly Marshaller<Device> __Marshaller_salto_nebula_device_v1_Device = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Device.Parser));

        static readonly Marshaller<ListDevicesRequest> __Marshaller_salto_nebula_device_v1_ListDevicesRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListDevicesRequest.Parser));

        static readonly Marshaller<ListDevicesResponse> __Marshaller_salto_nebula_device_v1_ListDevicesResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListDevicesResponse.Parser));

        static readonly Method<GetDeviceRequest, Device> __Method_GetDevice = new(
            MethodType.Unary,
            __ServiceName,
            "GetDevice",
            __Marshaller_salto_nebula_device_v1_GetDeviceRequest,
            __Marshaller_salto_nebula_device_v1_Device);

        static readonly Method<ListDevicesRequest, ListDevicesResponse> __Method_ListDevices = new(
            MethodType.Unary,
            __ServiceName,
            "ListDevices",
            __Marshaller_salto_nebula_device_v1_ListDevicesRequest,
            __Marshaller_salto_nebula_device_v1_ListDevicesResponse);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return DeviceReflection.Descriptor.Services[0]; }
        }

        /// <summary>Client for DeviceService</summary>
        public partial class DeviceServiceClient : ClientBase<DeviceServiceClient>
        {
            /// <summary>Creates a new client for DeviceService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public DeviceServiceClient(ChannelBase channel) : base(channel)
            {
            }

            /// <summary>Creates a new client for DeviceService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public DeviceServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }

            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected DeviceServiceClient() : base()
            {
            }

            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected DeviceServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Get a device
            ///
            /// Gets an existing device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Device GetDevice(GetDeviceRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => GetDevice(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Get a device
            ///
            /// Gets an existing device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual Device GetDevice(GetDeviceRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_GetDevice, null, options, request);
            /// <summary>
            /// Get a device
            ///
            /// Gets an existing device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Device> GetDeviceAsync(GetDeviceRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return GetDeviceAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// Get a device
            ///
            /// Gets an existing device.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<Device> GetDeviceAsync(GetDeviceRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_GetDevice, null, options, request);
            }

            /// <summary>
            /// List devices
            ///
            /// Returns a list of devices that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDevicesResponse ListDevices(ListDevicesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default) => ListDevices(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// List devices
            ///
            /// Returns a list of devices that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual ListDevicesResponse ListDevices(ListDevicesRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_ListDevices, null, options, request);
            /// <summary>
            /// List devices
            ///
            /// Returns a list of devices that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, Metadata headers = null, System.DateTime? deadline = null, System.Threading.CancellationToken cancellationToken = default)
            {
                return ListDevicesAsync(request, new CallOptions(headers, deadline, cancellationToken));
            }

            /// <summary>
            /// List devices
            ///
            /// Returns a list of devices that have been previously created.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_ListDevices, null, options, request);
            }

            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override DeviceServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }

    }
}
