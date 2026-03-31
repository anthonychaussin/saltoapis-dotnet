using Salto.Nebula.EmergencyKey.V1.Request;
using Salto.Nebula.EmergencyKey.V1.Response;

namespace Salto.Nebula.EmergencyKey.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/emergencykey/v1/emergency_key.proto</summary>
    public static partial class EmergencyKeyReflection
    {

        /// <summary>File descriptor for salto/nebula/emergencykey/v1/emergency_key.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static EmergencyKeyReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjBzYWx0by9uZWJ1bGEvZW1lcmdlbmN5a2V5L3YxL2VtZXJnZW5jeV9rZXku",
                  "cHJvdG8SHHNhbHRvLm5lYnVsYS5lbWVyZ2VuY3lrZXkudjEaG2dvb2dsZS9w",
                  "cm90b2J1Zi9lbXB0eS5wcm90bxogZ29vZ2xlL3Byb3RvYnVmL2ZpZWxkX21h",
                  "c2sucHJvdG8iPwoMRW1lcmdlbmN5S2V5EgwKBG5hbWUYASABKAkSFAoMZGlz",
                  "cGxheV9uYW1lGAIgASgJEgsKA3VpZBgDIAEoCSJuChlDcmVhdGVFbWVyZ2Vu",
                  "Y3lLZXlSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJBCg1lbWVyZ2VuY3lfa2V5",
                  "GAMgASgLMiouc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2Vu",
                  "Y3lLZXkiJgoWR2V0RW1lcmdlbmN5S2V5UmVxdWVzdBIMCgRuYW1lGAEgASgJ",
                  "InMKGExpc3RFbWVyZ2VuY3lLZXlzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkS",
                  "EQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmls",
                  "dGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIngKGUxpc3RFbWVyZ2VuY3lL",
                  "ZXlzUmVzcG9uc2USQgoOZW1lcmdlbmN5X2tleXMYASADKAsyKi5zYWx0by5u",
                  "ZWJ1bGEuZW1lcmdlbmN5a2V5LnYxLkVtZXJnZW5jeUtleRIXCg9uZXh0X3Bh",
                  "Z2VfdG9rZW4YAiABKAkijwEKGVVwZGF0ZUVtZXJnZW5jeUtleVJlcXVlc3QS",
                  "QQoNZW1lcmdlbmN5X2tleRgBIAEoCzIqLnNhbHRvLm5lYnVsYS5lbWVyZ2Vu",
                  "Y3lrZXkudjEuRW1lcmdlbmN5S2V5Ei8KC3VwZGF0ZV9tYXNrGAIgASgLMhou",
                  "Z29vZ2xlLnByb3RvYnVmLkZpZWxkTWFzayIpChlEZWxldGVFbWVyZ2VuY3lL",
                  "ZXlSZXF1ZXN0EgwKBG5hbWUYASABKAky7gQKE0VtZXJnZW5jeUtleVNlcnZp",
                  "Y2USeQoSQ3JlYXRlRW1lcmdlbmN5S2V5Ejcuc2FsdG8ubmVidWxhLmVtZXJn",
                  "ZW5jeWtleS52MS5DcmVhdGVFbWVyZ2VuY3lLZXlSZXF1ZXN0Giouc2FsdG8u",
                  "bmVidWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2VuY3lLZXkScwoPR2V0RW1l",
                  "cmdlbmN5S2V5EjQuc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5HZXRF",
                  "bWVyZ2VuY3lLZXlSZXF1ZXN0Giouc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtl",
                  "eS52MS5FbWVyZ2VuY3lLZXkShAEKEUxpc3RFbWVyZ2VuY3lLZXlzEjYuc2Fs",
                  "dG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5MaXN0RW1lcmdlbmN5S2V5c1Jl",
                  "cXVlc3QaNy5zYWx0by5uZWJ1bGEuZW1lcmdlbmN5a2V5LnYxLkxpc3RFbWVy",
                  "Z2VuY3lLZXlzUmVzcG9uc2USeQoSVXBkYXRlRW1lcmdlbmN5S2V5Ejcuc2Fs",
                  "dG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5VcGRhdGVFbWVyZ2VuY3lLZXlS",
                  "ZXF1ZXN0Giouc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2Vu",
                  "Y3lLZXkSZQoSRGVsZXRlRW1lcmdlbmN5S2V5Ejcuc2FsdG8ubmVidWxhLmVt",
                  "ZXJnZW5jeWtleS52MS5EZWxldGVFbWVyZ2VuY3lLZXlSZXF1ZXN0GhYuZ29v",
                  "Z2xlLnByb3RvYnVmLkVtcHR5QvgBCiBjb20uc2FsdG8ubmVidWxhLmVtZXJn",
                  "ZW5jeWtleS52MUIRRW1lcmdlbmN5S2V5UHJvdG9QAVpOZ2l0aHViLmNvbS9z",
                  "YWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS9lbWVyZ2Vu",
                  "Y3lrZXkvdjE7ZW1lcmdlbmN5a2V5qgIcU2FsdG8uTmVidWxhLkVtZXJnZW5j",
                  "eUtleS5WMcoCIFNhbHRvYXBpc1xOZWJ1bGFcRW1lcmdlbmN5S2V5XFYx4gIs",
                  "R1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxFbWVyZ2VuY3lLZXlcVjFi",
                  "BnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(EmergencyKey), EmergencyKey.Parser, ["Name", "DisplayName", "Uid"], null, null, null, null),
            new(typeof(CreateEmergencyKeyRequest), CreateEmergencyKeyRequest.Parser, ["Parent", "EmergencyKey"], null, null, null, null),
            new(typeof(GetEmergencyKeyRequest), GetEmergencyKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListEmergencyKeysRequest), ListEmergencyKeysRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListEmergencyKeysResponse), ListEmergencyKeysResponse.Parser, ["EmergencyKeys", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateEmergencyKeyRequest), UpdateEmergencyKeyRequest.Parser, ["EmergencyKey", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteEmergencyKeyRequest), DeleteEmergencyKeyRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }

    }
}
