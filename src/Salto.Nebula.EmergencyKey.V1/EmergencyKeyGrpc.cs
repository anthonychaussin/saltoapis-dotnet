using Grpc.Core;
using Salto.Nebula.EmergencyKey.V1.Request;
using Salto.Nebula.EmergencyKey.V1.Response;

namespace Salto.Nebula.EmergencyKey.V1
{
    /// <summary>
    /// Emergency keys are a credential type in Nebula, based on allowlisting,
    /// that grant access to designated access points within an installation.
    /// They do not expire and do not require any form of revalidation.
    /// This service is responsible for managing Emergency Key resources.
    /// </summary>
    public static partial class EmergencyKeyService
    {
        static readonly string __ServiceName = "salto.nebula.emergencykey.v1.EmergencyKeyService";

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

        static readonly Marshaller<CreateEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_CreateEmergencyKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, CreateEmergencyKeyRequest.Parser));

        static readonly Marshaller<EmergencyKey> __Marshaller_salto_nebula_emergencykey_v1_EmergencyKey = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, EmergencyKey.Parser));

        static readonly Marshaller<GetEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_GetEmergencyKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, GetEmergencyKeyRequest.Parser));

        static readonly Marshaller<ListEmergencyKeysRequest> __Marshaller_salto_nebula_emergencykey_v1_ListEmergencyKeysRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEmergencyKeysRequest.Parser));

        static readonly Marshaller<ListEmergencyKeysResponse> __Marshaller_salto_nebula_emergencykey_v1_ListEmergencyKeysResponse = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, ListEmergencyKeysResponse.Parser));

        static readonly Marshaller<UpdateEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_UpdateEmergencyKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, UpdateEmergencyKeyRequest.Parser));

        static readonly Marshaller<DeleteEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_DeleteEmergencyKeyRequest = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, DeleteEmergencyKeyRequest.Parser));

        static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, Google.Protobuf.WellKnownTypes.Empty.Parser));

        static readonly Method<CreateEmergencyKeyRequest, EmergencyKey> __Method_CreateEmergencyKey = new(
            MethodType.Unary,
            __ServiceName,
            "CreateEmergencyKey",
            __Marshaller_salto_nebula_emergencykey_v1_CreateEmergencyKeyRequest,
            __Marshaller_salto_nebula_emergencykey_v1_EmergencyKey);

        static readonly Method<GetEmergencyKeyRequest, EmergencyKey> __Method_GetEmergencyKey = new(
            MethodType.Unary,
            __ServiceName,
            "GetEmergencyKey",
            __Marshaller_salto_nebula_emergencykey_v1_GetEmergencyKeyRequest,
            __Marshaller_salto_nebula_emergencykey_v1_EmergencyKey);

        static readonly Method<ListEmergencyKeysRequest, ListEmergencyKeysResponse> __Method_ListEmergencyKeys = new(
            MethodType.Unary,
            __ServiceName,
            "ListEmergencyKeys",
            __Marshaller_salto_nebula_emergencykey_v1_ListEmergencyKeysRequest,
            __Marshaller_salto_nebula_emergencykey_v1_ListEmergencyKeysResponse);

        static readonly Method<UpdateEmergencyKeyRequest, EmergencyKey> __Method_UpdateEmergencyKey = new(
            MethodType.Unary,
            __ServiceName,
            "UpdateEmergencyKey",
            __Marshaller_salto_nebula_emergencykey_v1_UpdateEmergencyKeyRequest,
            __Marshaller_salto_nebula_emergencykey_v1_EmergencyKey);

        static readonly Method<DeleteEmergencyKeyRequest, Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteEmergencyKey = new(
            MethodType.Unary,
            __ServiceName,
            "DeleteEmergencyKey",
            __Marshaller_salto_nebula_emergencykey_v1_DeleteEmergencyKeyRequest,
            __Marshaller_google_protobuf_Empty);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.Services[0]; }
        }
    }
}
