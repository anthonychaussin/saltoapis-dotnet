using Google.Protobuf.Reflection;
using Saltoapis.Nebula.Encoder.V1.Request;
using Saltoapis.Nebula.Encoder.V1.Response;

namespace Saltoapis.Nebula.Encoder.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/encoder/v1/encoder.proto</summary>
    public static partial class EncoderReflection
    {

        /// <summary>File descriptor for salto/nebula/encoder/v1/encoder.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static EncoderReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiVzYWx0by9uZWJ1bGEvZW5jb2Rlci92MS9lbmNvZGVyLnByb3RvEhdzYWx0",
                  "by5uZWJ1bGEuZW5jb2Rlci52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
                  "b3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxofZ29vZ2xl",
                  "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxokc2FsdG8vbG9uZ3J1bm5pbmcv",
                  "djEvb3BlcmF0aW9uLnByb3RvGidzYWx0by9uZWJ1bGEvdHlwZS9kZXZpY2Vf",
                  "bWV0YWRhdGEucHJvdG8izQIKB0VuY29kZXISDAoEbmFtZRgBIAEoCRIUCgxk",
                  "aXNwbGF5X25hbWUYAiABKAkSFgoJZGV2aWNlX2lkGAMgASgJSAGIAQESEQoH",
                  "Z2F0ZXdheRgEIAEoCUgAEhIKCGV4dGVuZGVyGAUgASgJSAASEwoLaW5pdGlh",
                  "bGl6ZWQYBiABKAgSOgoPZGV2aWNlX21ldGFkYXRhGAsgASgLMiEuc2FsdG8u",
                  "bmVidWxhLnR5cGUuRGV2aWNlTWV0YWRhdGESEQoJY29ubmVjdGVkGAcgASgI",
                  "EjMKD2xhc3RfZXZlbnRfdGltZRgIIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
                  "aW1lc3RhbXASEAoIb3V0ZGF0ZWQYCSABKAgSFQoNZGlzYWJsZV9zb3VuZBgK",
                  "IAEoCEIPCg1wYXJlbnRfZGV2aWNlQgwKCl9kZXZpY2VfaWQigQEKFENyZWF0",
                  "ZUVuY29kZXJSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIXCgplbmNvZGVyX2lk",
                  "GAIgASgJSACIAQESMQoHZW5jb2RlchgDIAEoCzIgLnNhbHRvLm5lYnVsYS5l",
                  "bmNvZGVyLnYxLkVuY29kZXJCDQoLX2VuY29kZXJfaWQiIQoRR2V0RW5jb2Rl",
                  "clJlcXVlc3QSDAoEbmFtZRgBIAEoCSJuChNMaXN0RW5jb2RlcnNSZXF1ZXN0",
                  "Eg4KBnBhcmVudBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90",
                  "b2tlbhgDIAEoCRIOCgZmaWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkYBSABKAki",
                  "YwoUTGlzdEVuY29kZXJzUmVzcG9uc2USMgoIZW5jb2RlcnMYASADKAsyIC5z",
                  "YWx0by5uZWJ1bGEuZW5jb2Rlci52MS5FbmNvZGVyEhcKD25leHRfcGFnZV90",
                  "b2tlbhgCIAEoCSJ6ChRVcGRhdGVFbmNvZGVyUmVxdWVzdBIxCgdlbmNvZGVy",
                  "GAEgASgLMiAuc2FsdG8ubmVidWxhLmVuY29kZXIudjEuRW5jb2RlchIvCgt1",
                  "cGRhdGVfbWFzaxgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2si",
                  "JAoURGVsZXRlRW5jb2RlclJlcXVlc3QSDAoEbmFtZRgBIAEoCSI1ChJCaW5k",
                  "RW5jb2RlclJlcXVlc3QSDAoEbmFtZRgBIAEoCRIRCglkZXZpY2VfaWQYAiAB",
                  "KAkiFQoTQmluZEVuY29kZXJSZXNwb25zZSIzChRVbmJpbmRFbmNvZGVyUmVx",
                  "dWVzdBIMCgRuYW1lGAEgASgJEg0KBWZvcmNlGAIgASgIIhcKFVVuYmluZEVu",
                  "Y29kZXJSZXNwb25zZSIoChhJbml0aWFsaXplRW5jb2RlclJlcXVlc3QSDAoE",
                  "bmFtZRgBIAEoCSIbChlJbml0aWFsaXplRW5jb2RlclJlc3BvbnNlIhsKGUlu",
                  "aXRpYWxpemVFbmNvZGVyTWV0YWRhdGEiJwoXQ29uZmlndXJlRW5jb2RlclJl",
                  "cXVlc3QSDAoEbmFtZRgBIAEoCSIaChhDb25maWd1cmVFbmNvZGVyUmVzcG9u",
                  "c2UiGgoYQ29uZmlndXJlRW5jb2Rlck1ldGFkYXRhIiMKE1Jlc2V0RW5jb2Rl",
                  "clJlcXVlc3QSDAoEbmFtZRgBIAEoCSIWChRSZXNldEVuY29kZXJSZXNwb25z",
                  "ZSIWChRSZXNldEVuY29kZXJNZXRhZGF0YSIvChxVcGRhdGVFbmNvZGVyRmly",
                  "bXdhcmVSZXF1ZXN0Eg8KB2VuY29kZXIYASABKAkiHwodVXBkYXRlRW5jb2Rl",
                  "ckZpcm13YXJlUmVzcG9uc2UiOQodVXBkYXRlRW5jb2RlckZpcm13YXJlTWV0",
                  "YWRhdGESGAoQcHJvZ3Jlc3NfcGVyY2VudBgBIAEoBSIhCg5SZWFkS2V5UmVx",
                  "dWVzdBIPCgdlbmNvZGVyGAEgASgJInQKD1JlYWRLZXlSZXNwb25zZRISCghj",
                  "YXJkX2tleRgBIAEoCUgAEhgKDmVsZWN0cm9uaWNfa2V5GAIgASgJSAASDQoD",
                  "dWlkGAMgASgJSAESEwoJZGV2aWNlX2lkGAQgASgJSAFCBQoDa2V5QggKBmtl",
                  "eV9pZCIRCg9SZWFkS2V5TWV0YWRhdGEiNAohR2VuZXJhdGVBdXRob3JpemF0",
                  "aW9uVG9rZW5SZXF1ZXN0Eg8KB2VuY29kZXIYASABKAkiQQoiR2VuZXJhdGVB",
                  "dXRob3JpemF0aW9uVG9rZW5SZXNwb25zZRIbChNhdXRob3JpemF0aW9uX3Rv",
                  "a2VuGAEgASgMIjUKIkdlbmVyYXRlRmlybXdhcmVEb3dubG9hZFVyaVJlcXVl",
                  "c3QSDwoHZW5jb2RlchgBIAEoCSJLCiNHZW5lcmF0ZUZpcm13YXJlRG93bmxv",
                  "YWRVcmlSZXNwb25zZRIUCgxkb3dubG9hZF91cmkYASABKAkSDgoGZGlnZXN0",
                  "GAIgASgJIiUKI0dlbmVyYXRlRmlybXdhcmVEb3dubG9hZFVyaU1ldGFkYXRh",
                  "MtkLCg5FbmNvZGVyU2VydmljZRJgCg1DcmVhdGVFbmNvZGVyEi0uc2FsdG8u",
                  "bmVidWxhLmVuY29kZXIudjEuQ3JlYXRlRW5jb2RlclJlcXVlc3QaIC5zYWx0",
                  "by5uZWJ1bGEuZW5jb2Rlci52MS5FbmNvZGVyEloKCkdldEVuY29kZXISKi5z",
                  "YWx0by5uZWJ1bGEuZW5jb2Rlci52MS5HZXRFbmNvZGVyUmVxdWVzdBogLnNh",
                  "bHRvLm5lYnVsYS5lbmNvZGVyLnYxLkVuY29kZXISawoMTGlzdEVuY29kZXJz",
                  "Eiwuc2FsdG8ubmVidWxhLmVuY29kZXIudjEuTGlzdEVuY29kZXJzUmVxdWVz",
                  "dBotLnNhbHRvLm5lYnVsYS5lbmNvZGVyLnYxLkxpc3RFbmNvZGVyc1Jlc3Bv",
                  "bnNlEmAKDVVwZGF0ZUVuY29kZXISLS5zYWx0by5uZWJ1bGEuZW5jb2Rlci52",
                  "MS5VcGRhdGVFbmNvZGVyUmVxdWVzdBogLnNhbHRvLm5lYnVsYS5lbmNvZGVy",
                  "LnYxLkVuY29kZXISVgoNRGVsZXRlRW5jb2RlchItLnNhbHRvLm5lYnVsYS5l",
                  "bmNvZGVyLnYxLkRlbGV0ZUVuY29kZXJSZXF1ZXN0GhYuZ29vZ2xlLnByb3Rv",
                  "YnVmLkVtcHR5EmcKEUluaXRpYWxpemVFbmNvZGVyEjEuc2FsdG8ubmVidWxh",
                  "LmVuY29kZXIudjEuSW5pdGlhbGl6ZUVuY29kZXJSZXF1ZXN0Gh8uc2FsdG8u",
                  "bG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uEmUKEENvbmZpZ3VyZUVuY29kZXIS",
                  "MC5zYWx0by5uZWJ1bGEuZW5jb2Rlci52MS5Db25maWd1cmVFbmNvZGVyUmVx",
                  "dWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9wZXJhdGlvbhJdCgxSZXNl",
                  "dEVuY29kZXISLC5zYWx0by5uZWJ1bGEuZW5jb2Rlci52MS5SZXNldEVuY29k",
                  "ZXJSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uEm8K",
                  "FVVwZGF0ZUVuY29kZXJGaXJtd2FyZRI1LnNhbHRvLm5lYnVsYS5lbmNvZGVy",
                  "LnYxLlVwZGF0ZUVuY29kZXJGaXJtd2FyZVJlcXVlc3QaHy5zYWx0by5sb25n",
                  "cnVubmluZy52MS5PcGVyYXRpb24SaAoLQmluZEVuY29kZXISKy5zYWx0by5u",
                  "ZWJ1bGEuZW5jb2Rlci52MS5CaW5kRW5jb2RlclJlcXVlc3QaLC5zYWx0by5u",
                  "ZWJ1bGEuZW5jb2Rlci52MS5CaW5kRW5jb2RlclJlc3BvbnNlEm4KDVVuYmlu",
                  "ZEVuY29kZXISLS5zYWx0by5uZWJ1bGEuZW5jb2Rlci52MS5VbmJpbmRFbmNv",
                  "ZGVyUmVxdWVzdBouLnNhbHRvLm5lYnVsYS5lbmNvZGVyLnYxLlVuYmluZEVu",
                  "Y29kZXJSZXNwb25zZRJTCgdSZWFkS2V5Eicuc2FsdG8ubmVidWxhLmVuY29k",
                  "ZXIudjEuUmVhZEtleVJlcXVlc3QaHy5zYWx0by5sb25ncnVubmluZy52MS5P",
                  "cGVyYXRpb24SlQEKGkdlbmVyYXRlQXV0aG9yaXphdGlvblRva2VuEjouc2Fs",
                  "dG8ubmVidWxhLmVuY29kZXIudjEuR2VuZXJhdGVBdXRob3JpemF0aW9uVG9r",
                  "ZW5SZXF1ZXN0Gjsuc2FsdG8ubmVidWxhLmVuY29kZXIudjEuR2VuZXJhdGVB",
                  "dXRob3JpemF0aW9uVG9rZW5SZXNwb25zZRJ7ChtHZW5lcmF0ZUZpcm13YXJl",
                  "RG93bmxvYWRVcmkSOy5zYWx0by5uZWJ1bGEuZW5jb2Rlci52MS5HZW5lcmF0",
                  "ZUZpcm13YXJlRG93bmxvYWRVcmlSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5p",
                  "bmcudjEuT3BlcmF0aW9uQt0BCh9jb20uc2FsdG9hcGlzLm5lYnVsYS5lbmNv",
                  "ZGVyLnYxQgxFbmNvZGVyUHJvdG9QAVpEZ2l0aHViLmNvbS9zYWx0b2FwaXMt",
                  "aW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS9lbmNvZGVyL3YxO2VuY29k",
                  "ZXKqAhtTYWx0b2FwaXMuTmVidWxhLkVuY29kZXIuVjHKAhtTYWx0b2FwaXNc",
                  "TmVidWxhXEVuY29kZXJcVjHiAidHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVi",
                  "dWxhXEVuY29kZXJcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.DeviceMetadataReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Encoder), Encoder.Parser, ["Name", "DisplayName", "DeviceId", "Gateway", "Extender", "Initialized", "DeviceMetadata", "Connected", "LastEventTime", "Outdated", "DisableSound"], ["ParentDevice", "DeviceId"], null, null, null),
            new(typeof(CreateEncoderRequest), CreateEncoderRequest.Parser, ["Parent", "EncoderId", "Encoder"], ["EncoderId"], null, null, null),
            new(typeof(GetEncoderRequest), GetEncoderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListEncodersRequest), ListEncodersRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListEncodersResponse), ListEncodersResponse.Parser, ["Encoders", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateEncoderRequest), UpdateEncoderRequest.Parser, ["Encoder", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteEncoderRequest), DeleteEncoderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindEncoderRequest), BindEncoderRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindEncoderResponse), BindEncoderResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindEncoderRequest), UnbindEncoderRequest.Parser, ["Name", "Force"], null, null, null, null),
            new(typeof(UnbindEncoderResponse), UnbindEncoderResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeEncoderRequest), InitializeEncoderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(InitializeEncoderResponse), InitializeEncoderResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeEncoderMetadata), InitializeEncoderMetadata.Parser, null, null, null, null, null),
            new(typeof(ConfigureEncoderRequest), ConfigureEncoderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ConfigureEncoderResponse), ConfigureEncoderResponse.Parser, null, null, null, null, null),
            new(typeof(ConfigureEncoderMetadata), ConfigureEncoderMetadata.Parser, null, null, null, null, null),
            new(typeof(ResetEncoderRequest), ResetEncoderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetEncoderResponse), ResetEncoderResponse.Parser, null, null, null, null, null),
            new(typeof(ResetEncoderMetadata), ResetEncoderMetadata.Parser, null, null, null, null, null),
            new(typeof(UpdateEncoderFirmwareRequest), UpdateEncoderFirmwareRequest.Parser, ["Encoder"], null, null, null, null),
            new(typeof(UpdateEncoderFirmwareResponse), UpdateEncoderFirmwareResponse.Parser, null, null, null, null, null),
            new(typeof(UpdateEncoderFirmwareMetadata), UpdateEncoderFirmwareMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(ReadKeyRequest), ReadKeyRequest.Parser, ["Encoder"], null, null, null, null),
            new(typeof(ReadKeyResponse), ReadKeyResponse.Parser, ["CardKey", "ElectronicKey", "Uid", "DeviceId"], ["Key", "KeyId"], null, null, null),
            new(typeof(ReadKeyMetadata), ReadKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["Encoder"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["Encoder"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null)
                ]));
        }

    }


}
