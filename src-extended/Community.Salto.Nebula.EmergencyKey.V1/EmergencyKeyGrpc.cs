using Salto.Nebula.EmergencyKey.V1.Request;
using Saltoapis.Grpc;
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

        static readonly Marshaller<CreateEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_CreateEmergencyKeyRequest = GrpcMessageHelper.CreateMarshaller(CreateEmergencyKeyRequest.Parser);

        static readonly Marshaller<EmergencyKey> __Marshaller_salto_nebula_emergencykey_v1_EmergencyKey = GrpcMessageHelper.CreateMarshaller(EmergencyKey.Parser);

        static readonly Marshaller<GetEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_GetEmergencyKeyRequest = GrpcMessageHelper.CreateMarshaller(GetEmergencyKeyRequest.Parser);

        static readonly Marshaller<ListEmergencyKeysRequest> __Marshaller_salto_nebula_emergencykey_v1_ListEmergencyKeysRequest = GrpcMessageHelper.CreateMarshaller(ListEmergencyKeysRequest.Parser);

        static readonly Marshaller<ListEmergencyKeysResponse> __Marshaller_salto_nebula_emergencykey_v1_ListEmergencyKeysResponse = GrpcMessageHelper.CreateMarshaller(ListEmergencyKeysResponse.Parser);

        static readonly Marshaller<UpdateEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_UpdateEmergencyKeyRequest = GrpcMessageHelper.CreateMarshaller(UpdateEmergencyKeyRequest.Parser);

        static readonly Marshaller<DeleteEmergencyKeyRequest> __Marshaller_salto_nebula_emergencykey_v1_DeleteEmergencyKeyRequest = GrpcMessageHelper.CreateMarshaller(DeleteEmergencyKeyRequest.Parser);

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
            GrpcMessageHelper.EmptyMarshaller);

        /// <summary>Service descriptor</summary>
        public static Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.Services[0]; }
        }
    }
}




