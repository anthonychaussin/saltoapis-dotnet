using Saltoapis.Nebula.Extender.V1.Request;
using Saltoapis.Nebula.Extender.V1.Response;

namespace Saltoapis.Nebula.Extender.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/extender/v1/extender.proto</summary>
    public static partial class ExtenderReflection
    {
        /// <summary>File descriptor for salto/nebula/extender/v1/extender.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static ExtenderReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CidzYWx0by9uZWJ1bGEvZXh0ZW5kZXIvdjEvZXh0ZW5kZXIucHJvdG8SGHNh",
                  "bHRvLm5lYnVsYS5leHRlbmRlci52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5",
                  "LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxokc2Fs",
                  "dG8vbG9uZ3J1bm5pbmcvdjEvb3BlcmF0aW9uLnByb3RvIowBCghFeHRlbmRl",
                  "chIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRIWCglkZXZp",
                  "Y2VfaWQYAyABKAlIAYgBARIRCgdnYXRld2F5GAQgASgJSAASEgoIZXh0ZW5k",
                  "ZXIYBSABKAlIAEIPCg1wYXJlbnRfZGV2aWNlQgwKCl9kZXZpY2VfaWQihwEK",
                  "FUNyZWF0ZUV4dGVuZGVyUmVxdWVzdBIOCgZwYXJlbnQYASABKAkSGAoLZXh0",
                  "ZW5kZXJfaWQYAiABKAlIAIgBARI0CghleHRlbmRlchgDIAEoCzIiLnNhbHRv",
                  "Lm5lYnVsYS5leHRlbmRlci52MS5FeHRlbmRlckIOCgxfZXh0ZW5kZXJfaWQi",
                  "IgoSR2V0RXh0ZW5kZXJSZXF1ZXN0EgwKBG5hbWUYASABKAkibwoUTGlzdEV4",
                  "dGVuZGVyc1JlcXVlc3QSDgoGcGFyZW50GAEgASgJEhEKCXBhZ2Vfc2l6ZRgC",
                  "IAEoBRISCgpwYWdlX3Rva2VuGAMgASgJEg4KBmZpbHRlchgEIAEoCRIQCghv",
                  "cmRlcl9ieRgFIAEoCSJnChVMaXN0RXh0ZW5kZXJzUmVzcG9uc2USNQoJZXh0",
                  "ZW5kZXJzGAEgAygLMiIuc2FsdG8ubmVidWxhLmV4dGVuZGVyLnYxLkV4dGVu",
                  "ZGVyEhcKD25leHRfcGFnZV90b2tlbhgCIAEoCSJ+ChVVcGRhdGVFeHRlbmRl",
                  "clJlcXVlc3QSNAoIZXh0ZW5kZXIYASABKAsyIi5zYWx0by5uZWJ1bGEuZXh0",
                  "ZW5kZXIudjEuRXh0ZW5kZXISLwoLdXBkYXRlX21hc2sYAiABKAsyGi5nb29n",
                  "bGUucHJvdG9idWYuRmllbGRNYXNrIiUKFURlbGV0ZUV4dGVuZGVyUmVxdWVz",
                  "dBIMCgRuYW1lGAEgASgJIjYKE0JpbmRFeHRlbmRlclJlcXVlc3QSDAoEbmFt",
                  "ZRgBIAEoCRIRCglkZXZpY2VfaWQYAiABKAkiFgoUQmluZEV4dGVuZGVyUmVz",
                  "cG9uc2UiJQoVVW5iaW5kRXh0ZW5kZXJSZXF1ZXN0EgwKBG5hbWUYASABKAki",
                  "GAoWVW5iaW5kRXh0ZW5kZXJSZXNwb25zZSIxCh1VcGRhdGVFeHRlbmRlckZp",
                  "cm13YXJlUmVxdWVzdBIQCghleHRlbmRlchgBIAEoCSIgCh5VcGRhdGVFeHRl",
                  "bmRlckZpcm13YXJlUmVzcG9uc2UiOgoeVXBkYXRlRXh0ZW5kZXJGaXJtd2Fy",
                  "ZU1ldGFkYXRhEhgKEHByb2dyZXNzX3BlcmNlbnQYASABKAUiJAoUUmVzZXRF",
                  "eHRlbmRlclJlcXVlc3QSDAoEbmFtZRgBIAEoCSIXChVSZXNldEV4dGVuZGVy",
                  "UmVzcG9uc2UiFwoVUmVzZXRFeHRlbmRlck1ldGFkYXRhIjYKIkdlbmVyYXRl",
                  "RmlybXdhcmVEb3dubG9hZFVyaVJlcXVlc3QSEAoIZXh0ZW5kZXIYASABKAki",
                  "SwojR2VuZXJhdGVGaXJtd2FyZURvd25sb2FkVXJpUmVzcG9uc2USFAoMZG93",
                  "bmxvYWRfdXJpGAEgASgJEg4KBmRpZ2VzdBgCIAEoCSIlCiNHZW5lcmF0ZUZp",
                  "cm13YXJlRG93bmxvYWRVcmlNZXRhZGF0YTLFCAoPRXh0ZW5kZXJTZXJ2aWNl",
                  "EmUKDkNyZWF0ZUV4dGVuZGVyEi8uc2FsdG8ubmVidWxhLmV4dGVuZGVyLnYx",
                  "LkNyZWF0ZUV4dGVuZGVyUmVxdWVzdBoiLnNhbHRvLm5lYnVsYS5leHRlbmRl",
                  "ci52MS5FeHRlbmRlchJfCgtHZXRFeHRlbmRlchIsLnNhbHRvLm5lYnVsYS5l",
                  "eHRlbmRlci52MS5HZXRFeHRlbmRlclJlcXVlc3QaIi5zYWx0by5uZWJ1bGEu",
                  "ZXh0ZW5kZXIudjEuRXh0ZW5kZXIScAoNTGlzdEV4dGVuZGVycxIuLnNhbHRv",
                  "Lm5lYnVsYS5leHRlbmRlci52MS5MaXN0RXh0ZW5kZXJzUmVxdWVzdBovLnNh",
                  "bHRvLm5lYnVsYS5leHRlbmRlci52MS5MaXN0RXh0ZW5kZXJzUmVzcG9uc2US",
                  "ZQoOVXBkYXRlRXh0ZW5kZXISLy5zYWx0by5uZWJ1bGEuZXh0ZW5kZXIudjEu",
                  "VXBkYXRlRXh0ZW5kZXJSZXF1ZXN0GiIuc2FsdG8ubmVidWxhLmV4dGVuZGVy",
                  "LnYxLkV4dGVuZGVyElkKDkRlbGV0ZUV4dGVuZGVyEi8uc2FsdG8ubmVidWxh",
                  "LmV4dGVuZGVyLnYxLkRlbGV0ZUV4dGVuZGVyUmVxdWVzdBoWLmdvb2dsZS5w",
                  "cm90b2J1Zi5FbXB0eRJtCgxCaW5kRXh0ZW5kZXISLS5zYWx0by5uZWJ1bGEu",
                  "ZXh0ZW5kZXIudjEuQmluZEV4dGVuZGVyUmVxdWVzdBouLnNhbHRvLm5lYnVs",
                  "YS5leHRlbmRlci52MS5CaW5kRXh0ZW5kZXJSZXNwb25zZRJzCg5VbmJpbmRF",
                  "eHRlbmRlchIvLnNhbHRvLm5lYnVsYS5leHRlbmRlci52MS5VbmJpbmRFeHRl",
                  "bmRlclJlcXVlc3QaMC5zYWx0by5uZWJ1bGEuZXh0ZW5kZXIudjEuVW5iaW5k",
                  "RXh0ZW5kZXJSZXNwb25zZRJyChZVcGRhdGVFeHRlbmRlckZpcm13YXJlEjcu",
                  "c2FsdG8ubmVidWxhLmV4dGVuZGVyLnYxLlVwZGF0ZUV4dGVuZGVyRmlybXdh",
                  "cmVSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uEmAK",
                  "DVJlc2V0RXh0ZW5kZXISLi5zYWx0by5uZWJ1bGEuZXh0ZW5kZXIudjEuUmVz",
                  "ZXRFeHRlbmRlclJlcXVlc3QaHy5zYWx0by5sb25ncnVubmluZy52MS5PcGVy",
                  "YXRpb24SfAobR2VuZXJhdGVGaXJtd2FyZURvd25sb2FkVXJpEjwuc2FsdG8u",
                  "bmVidWxhLmV4dGVuZGVyLnYxLkdlbmVyYXRlRmlybXdhcmVEb3dubG9hZFVy",
                  "aVJlcXVlc3QaHy5zYWx0by5sb25ncnVubmluZy52MS5PcGVyYXRpb25C5AEK",
                  "IGNvbS5zYWx0b2FwaXMubmVidWxhLmV4dGVuZGVyLnYxQg1FeHRlbmRlclBy",
                  "b3RvUAFaRmdpdGh1Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBp",
                  "cy1nby9uZWJ1bGEvZXh0ZW5kZXIvdjE7ZXh0ZW5kZXKqAhxTYWx0b2FwaXMu",
                  "TmVidWxhLkV4dGVuZGVyLlYxygIcU2FsdG9hcGlzXE5lYnVsYVxFeHRlbmRl",
                  "clxWMeICKEdQQk1ldGFkYXRhXFNhbHRvYXBpc1xOZWJ1bGFcRXh0ZW5kZXJc",
                  "VjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Extender), Extender.Parser, ["Name", "DisplayName", "DeviceId", "Gateway", "Extender_"], ["ParentDevice", "DeviceId"], null, null, null),
            new(typeof(CreateExtenderRequest), CreateExtenderRequest.Parser, ["Parent", "ExtenderId", "Extender"], ["ExtenderId"], null, null, null),
            new(typeof(GetExtenderRequest), GetExtenderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListExtendersRequest), ListExtendersRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListExtendersResponse), ListExtendersResponse.Parser, ["Extenders", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateExtenderRequest), UpdateExtenderRequest.Parser, ["Extender", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteExtenderRequest), DeleteExtenderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindExtenderRequest), BindExtenderRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindExtenderResponse), BindExtenderResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindExtenderRequest), UnbindExtenderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(UnbindExtenderResponse), UnbindExtenderResponse.Parser, null, null, null, null, null),
            new(typeof(UpdateExtenderFirmwareRequest), UpdateExtenderFirmwareRequest.Parser, ["Extender"], null, null, null, null),
            new(typeof(UpdateExtenderFirmwareResponse), UpdateExtenderFirmwareResponse.Parser, null, null, null, null, null),
            new(typeof(UpdateExtenderFirmwareMetadata), UpdateExtenderFirmwareMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(ResetExtenderRequest), ResetExtenderRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetExtenderResponse), ResetExtenderResponse.Parser, null, null, null, null, null),
            new(typeof(ResetExtenderMetadata), ResetExtenderMetadata.Parser, null, null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["Extender"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null)
                ]));
        }
    }

}