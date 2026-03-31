using Saltoapis.Nebula.ElectronicKey.V1.Request;
using Saltoapis.Nebula.ElectronicKey.V1.Response;

namespace Saltoapis.Nebula.ElectronicKey.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/electronickey/v1/electronic_key.proto</summary>
    public static partial class ElectronicKeyReflection
    {
        /// <summary>File descriptor for salto/nebula/electronickey/v1/electronic_key.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static ElectronicKeyReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjJzYWx0by9uZWJ1bGEvZWxlY3Ryb25pY2tleS92MS9lbGVjdHJvbmljX2tl",
                  "eS5wcm90bxIdc2FsdG8ubmVidWxhLmVsZWN0cm9uaWNrZXkudjEaG2dvb2ds",
                  "ZS9wcm90b2J1Zi9lbXB0eS5wcm90bxogZ29vZ2xlL3Byb3RvYnVmL2ZpZWxk",
                  "X21hc2sucHJvdG8aJHNhbHRvL2xvbmdydW5uaW5nL3YxL29wZXJhdGlvbi5w",
                  "cm90bxonc2FsdG8vbmVidWxhL3R5cGUvZGV2aWNlX21ldGFkYXRhLnByb3Rv",
                  "ItgBCg1FbGVjdHJvbmljS2V5EgwKBG5hbWUYASABKAkSFAoMZGlzcGxheV9u",
                  "YW1lGAIgASgJEhMKC2luaXRpYWxpemVkGAMgASgIEhYKCWRldmljZV9pZBgE",
                  "IAEoCUgAiAEBEhAKCG91dGRhdGVkGAUgASgIEjoKD2RldmljZV9tZXRhZGF0",
                  "YRgGIAEoCzIhLnNhbHRvLm5lYnVsYS50eXBlLkRldmljZU1ldGFkYXRhEhEK",
                  "BHVzZXIYCCABKAlIAYgBAUIMCgpfZGV2aWNlX2lkQgcKBV91c2VyIqgBChpD",
                  "cmVhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBIOCgZwYXJlbnQYASABKAkSHgoR",
                  "ZWxlY3Ryb25pY19rZXlfaWQYAiABKAlIAIgBARJECg5lbGVjdHJvbmljX2tl",
                  "eRgDIAEoCzIsLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkVsZWN0",
                  "cm9uaWNLZXlCFAoSX2VsZWN0cm9uaWNfa2V5X2lkIicKF0dldEVsZWN0cm9u",
                  "aWNLZXlSZXF1ZXN0EgwKBG5hbWUYASABKAkidAoZTGlzdEVsZWN0cm9uaWNL",
                  "ZXlzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkSEQoJcGFnZV9zaXplGAIgASgF",
                  "EhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmlsdGVyGAQgASgJEhAKCG9yZGVy",
                  "X2J5GAUgASgJInwKGkxpc3RFbGVjdHJvbmljS2V5c1Jlc3BvbnNlEkUKD2Vs",
                  "ZWN0cm9uaWNfa2V5cxgBIAMoCzIsLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlj",
                  "a2V5LnYxLkVsZWN0cm9uaWNLZXkSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJ",
                  "IpMBChpVcGRhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBJECg5lbGVjdHJvbmlj",
                  "X2tleRgBIAEoCzIsLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkVs",
                  "ZWN0cm9uaWNLZXkSLwoLdXBkYXRlX21hc2sYAiABKAsyGi5nb29nbGUucHJv",
                  "dG9idWYuRmllbGRNYXNrIioKGkRlbGV0ZUVsZWN0cm9uaWNLZXlSZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAkiOwoYQmluZEVsZWN0cm9uaWNLZXlSZXF1ZXN0EgwK",
                  "BG5hbWUYASABKAkSEQoJZGV2aWNlX2lkGAIgASgJIhsKGUJpbmRFbGVjdHJv",
                  "bmljS2V5UmVzcG9uc2UiOQoaVW5iaW5kRWxlY3Ryb25pY0tleVJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCRINCgVmb3JjZRgCIAEoCCIdChtVbmJpbmRFbGVjdHJv",
                  "bmljS2V5UmVzcG9uc2UiLgoeSW5pdGlhbGl6ZUVsZWN0cm9uaWNLZXlSZXF1",
                  "ZXN0EgwKBG5hbWUYASABKAkiIQofSW5pdGlhbGl6ZUVsZWN0cm9uaWNLZXlS",
                  "ZXNwb25zZSIhCh9Jbml0aWFsaXplRWxlY3Ryb25pY0tleU1ldGFkYXRhIi0K",
                  "HUNvbmZpZ3VyZUVsZWN0cm9uaWNLZXlSZXF1ZXN0EgwKBG5hbWUYASABKAki",
                  "IAoeQ29uZmlndXJlRWxlY3Ryb25pY0tleVJlc3BvbnNlIiAKHkNvbmZpZ3Vy",
                  "ZUVsZWN0cm9uaWNLZXlNZXRhZGF0YSIpChlSZXNldEVsZWN0cm9uaWNLZXlS",
                  "ZXF1ZXN0EgwKBG5hbWUYASABKAkiHAoaUmVzZXRFbGVjdHJvbmljS2V5UmVz",
                  "cG9uc2UiHAoaUmVzZXRFbGVjdHJvbmljS2V5TWV0YWRhdGEiOwohR2VuZXJh",
                  "dGVBdXRob3JpemF0aW9uVG9rZW5SZXF1ZXN0EhYKDmVsZWN0cm9uaWNfa2V5",
                  "GAEgASgJIkEKIkdlbmVyYXRlQXV0aG9yaXphdGlvblRva2VuUmVzcG9uc2US",
                  "GwoTYXV0aG9yaXphdGlvbl90b2tlbhgBIAEoDCI8CiJHZW5lcmF0ZUZpcm13",
                  "YXJlRG93bmxvYWRVcmlSZXF1ZXN0EhYKDmVsZWN0cm9uaWNfa2V5GAEgASgJ",
                  "IksKI0dlbmVyYXRlRmlybXdhcmVEb3dubG9hZFVyaVJlc3BvbnNlEhQKDGRv",
                  "d25sb2FkX3VyaRgBIAEoCRIOCgZkaWdlc3QYAiABKAkiJQojR2VuZXJhdGVG",
                  "aXJtd2FyZURvd25sb2FkVXJpTWV0YWRhdGEyqwwKFEVsZWN0cm9uaWNLZXlT",
                  "ZXJ2aWNlEn4KE0NyZWF0ZUVsZWN0cm9uaWNLZXkSOS5zYWx0by5uZWJ1bGEu",
                  "ZWxlY3Ryb25pY2tleS52MS5DcmVhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBos",
                  "LnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkVsZWN0cm9uaWNLZXkS",
                  "eAoQR2V0RWxlY3Ryb25pY0tleRI2LnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlj",
                  "a2V5LnYxLkdldEVsZWN0cm9uaWNLZXlSZXF1ZXN0Giwuc2FsdG8ubmVidWxh",
                  "LmVsZWN0cm9uaWNrZXkudjEuRWxlY3Ryb25pY0tleRKJAQoSTGlzdEVsZWN0",
                  "cm9uaWNLZXlzEjguc2FsdG8ubmVidWxhLmVsZWN0cm9uaWNrZXkudjEuTGlz",
                  "dEVsZWN0cm9uaWNLZXlzUmVxdWVzdBo5LnNhbHRvLm5lYnVsYS5lbGVjdHJv",
                  "bmlja2V5LnYxLkxpc3RFbGVjdHJvbmljS2V5c1Jlc3BvbnNlEn4KE1VwZGF0",
                  "ZUVsZWN0cm9uaWNLZXkSOS5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2tleS52",
                  "MS5VcGRhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBosLnNhbHRvLm5lYnVsYS5l",
                  "bGVjdHJvbmlja2V5LnYxLkVsZWN0cm9uaWNLZXkSaAoTRGVsZXRlRWxlY3Ry",
                  "b25pY0tleRI5LnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkRlbGV0",
                  "ZUVsZWN0cm9uaWNLZXlSZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
                  "EoYBChFCaW5kRWxlY3Ryb25pY0tleRI3LnNhbHRvLm5lYnVsYS5lbGVjdHJv",
                  "bmlja2V5LnYxLkJpbmRFbGVjdHJvbmljS2V5UmVxdWVzdBo4LnNhbHRvLm5l",
                  "YnVsYS5lbGVjdHJvbmlja2V5LnYxLkJpbmRFbGVjdHJvbmljS2V5UmVzcG9u",
                  "c2USjAEKE1VuYmluZEVsZWN0cm9uaWNLZXkSOS5zYWx0by5uZWJ1bGEuZWxl",
                  "Y3Ryb25pY2tleS52MS5VbmJpbmRFbGVjdHJvbmljS2V5UmVxdWVzdBo6LnNh",
                  "bHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLlVuYmluZEVsZWN0cm9uaWNL",
                  "ZXlSZXNwb25zZRJ5ChdJbml0aWFsaXplRWxlY3Ryb25pY0tleRI9LnNhbHRv",
                  "Lm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkluaXRpYWxpemVFbGVjdHJvbmlj",
                  "S2V5UmVxdWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9wZXJhdGlvbhJ3",
                  "ChZDb25maWd1cmVFbGVjdHJvbmljS2V5Ejwuc2FsdG8ubmVidWxhLmVsZWN0",
                  "cm9uaWNrZXkudjEuQ29uZmlndXJlRWxlY3Ryb25pY0tleVJlcXVlc3QaHy5z",
                  "YWx0by5sb25ncnVubmluZy52MS5PcGVyYXRpb24SbwoSUmVzZXRFbGVjdHJv",
                  "bmljS2V5Ejguc2FsdG8ubmVidWxhLmVsZWN0cm9uaWNrZXkudjEuUmVzZXRF",
                  "bGVjdHJvbmljS2V5UmVxdWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9w",
                  "ZXJhdGlvbhKhAQoaR2VuZXJhdGVBdXRob3JpemF0aW9uVG9rZW4SQC5zYWx0",
                  "by5uZWJ1bGEuZWxlY3Ryb25pY2tleS52MS5HZW5lcmF0ZUF1dGhvcml6YXRp",
                  "b25Ub2tlblJlcXVlc3QaQS5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2tleS52",
                  "MS5HZW5lcmF0ZUF1dGhvcml6YXRpb25Ub2tlblJlc3BvbnNlEoEBChtHZW5l",
                  "cmF0ZUZpcm13YXJlRG93bmxvYWRVcmkSQS5zYWx0by5uZWJ1bGEuZWxlY3Ry",
                  "b25pY2tleS52MS5HZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlSZXF1ZXN0",
                  "Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uQocCCiVjb20uc2Fs",
                  "dG9hcGlzLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxQhJFbGVjdHJvbmljS2V5",
                  "UHJvdG9QAVpQZ2l0aHViLmNvbS9zYWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9h",
                  "cGlzLWdvL25lYnVsYS9lbGVjdHJvbmlja2V5L3YxO2VsZWN0cm9uaWNrZXmq",
                  "AiFTYWx0b2FwaXMuTmVidWxhLkVsZWN0cm9uaWNLZXkuVjHKAiFTYWx0b2Fw",
                  "aXNcTmVidWxhXEVsZWN0cm9uaWNLZXlcVjHiAi1HUEJNZXRhZGF0YVxTYWx0",
                  "b2FwaXNcTmVidWxhXEVsZWN0cm9uaWNLZXlcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.DeviceMetadataReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(ElectronicKey), ElectronicKey.Parser, ["Name", "DisplayName", "Initialized", "DeviceId", "Outdated", "DeviceMetadata", "User"], ["DeviceId", "User"], null, null, null),
            new(typeof(CreateElectronicKeyRequest), CreateElectronicKeyRequest.Parser, ["Parent", "ElectronicKeyId", "ElectronicKey"], ["ElectronicKeyId"], null, null, null),
            new(typeof(GetElectronicKeyRequest), GetElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListElectronicKeysRequest), ListElectronicKeysRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListElectronicKeysResponse), ListElectronicKeysResponse.Parser, ["ElectronicKeys", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateElectronicKeyRequest), UpdateElectronicKeyRequest.Parser, ["ElectronicKey", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteElectronicKeyRequest), DeleteElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindElectronicKeyRequest), BindElectronicKeyRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindElectronicKeyResponse), BindElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindElectronicKeyRequest), UnbindElectronicKeyRequest.Parser, ["Name", "Force"], null, null, null, null),
            new(typeof(UnbindElectronicKeyResponse), UnbindElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeElectronicKeyRequest), InitializeElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(InitializeElectronicKeyResponse), InitializeElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeElectronicKeyMetadata), InitializeElectronicKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(ConfigureElectronicKeyRequest), ConfigureElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ConfigureElectronicKeyResponse), ConfigureElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(ConfigureElectronicKeyMetadata), ConfigureElectronicKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(ResetElectronicKeyRequest), ResetElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetElectronicKeyResponse), ResetElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(ResetElectronicKeyMetadata), ResetElectronicKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["ElectronicKey"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["ElectronicKey"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null)
                ]));
        }
    }

}