using Google.Protobuf.Reflection;
using Saltoapis.Nebula.Gateway.V1.Request;
using Saltoapis.Nebula.Gateway.V1.Response;

namespace Saltoapis.Nebula.Gateway.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/gateway/v1/gateway.proto</summary>
    public static partial class GatewayReflection
    {

        /// <summary>File descriptor for salto/nebula/gateway/v1/gateway.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static GatewayReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiVzYWx0by9uZWJ1bGEvZ2F0ZXdheS92MS9nYXRld2F5LnByb3RvEhdzYWx0",
                  "by5uZWJ1bGEuZ2F0ZXdheS52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
                  "b3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxokc2FsdG8v",
                  "bG9uZ3J1bm5pbmcvdjEvb3BlcmF0aW9uLnByb3RvGidzYWx0by9uZWJ1bGEv",
                  "dHlwZS9kZXZpY2VfbWV0YWRhdGEucHJvdG8iuwIKB0dhdGV3YXkSDAoEbmFt",
                  "ZRgBIAEoCRIUCgxkaXNwbGF5X25hbWUYAiABKAkSFgoJZGV2aWNlX2lkGAMg",
                  "ASgJSACIAQESEwoLaW5pdGlhbGl6ZWQYBCABKAgSOgoPZGV2aWNlX21ldGFk",
                  "YXRhGAggASgLMiEuc2FsdG8ubmVidWxhLnR5cGUuRGV2aWNlTWV0YWRhdGES",
                  "EQoJY29ubmVjdGVkGAcgASgIEkQKEWV0aGVybmV0X3NldHRpbmdzGAUgASgL",
                  "Mikuc2FsdG8ubmVidWxhLmdhdGV3YXkudjEuRXRoZXJuZXRTZXR0aW5ncxI8",
                  "Cg13aWZpX3NldHRpbmdzGAYgASgLMiUuc2FsdG8ubmVidWxhLmdhdGV3YXku",
                  "djEuV2lmaVNldHRpbmdzQgwKCl9kZXZpY2VfaWQijAEKEEV0aGVybmV0U2V0",
                  "dGluZ3MSPAoNaXB2NF9zZXR0aW5ncxgBIAEoCzIlLnNhbHRvLm5lYnVsYS5n",
                  "YXRld2F5LnYxLklQdjRTZXR0aW5ncxI6CgxkbnNfc2V0dGluZ3MYAiABKAsy",
                  "JC5zYWx0by5uZWJ1bGEuZ2F0ZXdheS52MS5ETlNTZXR0aW5ncyK6AQoMV2lm",
                  "aVNldHRpbmdzEjwKDWlwdjRfc2V0dGluZ3MYASABKAsyJS5zYWx0by5uZWJ1",
                  "bGEuZ2F0ZXdheS52MS5JUHY0U2V0dGluZ3MSOgoMZG5zX3NldHRpbmdzGAIg",
                  "ASgLMiQuc2FsdG8ubmVidWxhLmdhdGV3YXkudjEuRE5TU2V0dGluZ3MSDAoE",
                  "c3NpZBgDIAEoCRIVCghwYXNzd29yZBgEIAEoCUgAiAEBQgsKCV9wYXNzd29y",
                  "ZCKCAQoMSVB2NFNldHRpbmdzEhcKCmlwX2FkZHJlc3MYASABKAlIAIgBARIR",
                  "CgRtYXNrGAIgASgJSAGIAQESGwoOcm91dGVyX2FkZHJlc3MYAyABKAlIAogB",
                  "AUINCgtfaXBfYWRkcmVzc0IHCgVfbWFza0IRCg9fcm91dGVyX2FkZHJlc3Mi",
                  "JAoLRE5TU2V0dGluZ3MSFQoNZG5zX2FkZHJlc3NlcxgBIAMoCSKBAQoUQ3Jl",
                  "YXRlR2F0ZXdheVJlcXVlc3QSDgoGcGFyZW50GAEgASgJEhcKCmdhdGV3YXlf",
                  "aWQYAiABKAlIAIgBARIxCgdnYXRld2F5GAMgASgLMiAuc2FsdG8ubmVidWxh",
                  "LmdhdGV3YXkudjEuR2F0ZXdheUINCgtfZ2F0ZXdheV9pZCIhChFHZXRHYXRl",
                  "d2F5UmVxdWVzdBIMCgRuYW1lGAEgASgJIm4KE0xpc3RHYXRld2F5c1JlcXVl",
                  "c3QSDgoGcGFyZW50GAEgASgJEhEKCXBhZ2Vfc2l6ZRgCIAEoBRISCgpwYWdl",
                  "X3Rva2VuGAMgASgJEg4KBmZpbHRlchgEIAEoCRIQCghvcmRlcl9ieRgFIAEo",
                  "CSJjChRMaXN0R2F0ZXdheXNSZXNwb25zZRIyCghnYXRld2F5cxgBIAMoCzIg",
                  "LnNhbHRvLm5lYnVsYS5nYXRld2F5LnYxLkdhdGV3YXkSFwoPbmV4dF9wYWdl",
                  "X3Rva2VuGAIgASgJInoKFFVwZGF0ZUdhdGV3YXlSZXF1ZXN0EjEKB2dhdGV3",
                  "YXkYASABKAsyIC5zYWx0by5uZWJ1bGEuZ2F0ZXdheS52MS5HYXRld2F5Ei8K",
                  "C3VwZGF0ZV9tYXNrGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLkZpZWxkTWFz",
                  "ayIkChREZWxldGVHYXRld2F5UmVxdWVzdBIMCgRuYW1lGAEgASgJIjUKEkJp",
                  "bmRHYXRld2F5UmVxdWVzdBIMCgRuYW1lGAEgASgJEhEKCWRldmljZV9pZBgC",
                  "IAEoCSIVChNCaW5kR2F0ZXdheVJlc3BvbnNlIjMKFFVuYmluZEdhdGV3YXlS",
                  "ZXF1ZXN0EgwKBG5hbWUYASABKAkSDQoFZm9yY2UYAiABKAgiFwoVVW5iaW5k",
                  "R2F0ZXdheVJlc3BvbnNlIigKGEluaXRpYWxpemVHYXRld2F5UmVxdWVzdBIM",
                  "CgRuYW1lGAEgASgJIhsKGUluaXRpYWxpemVHYXRld2F5UmVzcG9uc2UiGwoZ",
                  "SW5pdGlhbGl6ZUdhdGV3YXlNZXRhZGF0YSInChdDb25maWd1cmVHYXRld2F5",
                  "UmVxdWVzdBIMCgRuYW1lGAEgASgJIhoKGENvbmZpZ3VyZUdhdGV3YXlSZXNw",
                  "b25zZSIaChhDb25maWd1cmVHYXRld2F5TWV0YWRhdGEiIwoTUmVzZXRHYXRl",
                  "d2F5UmVxdWVzdBIMCgRuYW1lGAEgASgJIhYKFFJlc2V0R2F0ZXdheVJlc3Bv",
                  "bnNlIhYKFFJlc2V0R2F0ZXdheU1ldGFkYXRhIi8KHFVwZGF0ZUdhdGV3YXlG",
                  "aXJtd2FyZVJlcXVlc3QSDwoHZ2F0ZXdheRgBIAEoCSIfCh1VcGRhdGVHYXRl",
                  "d2F5RmlybXdhcmVSZXNwb25zZSI5Ch1VcGRhdGVHYXRld2F5RmlybXdhcmVN",
                  "ZXRhZGF0YRIYChBwcm9ncmVzc19wZXJjZW50GAEgASgFIjQKIUdlbmVyYXRl",
                  "QXV0aG9yaXphdGlvblRva2VuUmVxdWVzdBIPCgdnYXRld2F5GAEgASgJIkEK",
                  "IkdlbmVyYXRlQXV0aG9yaXphdGlvblRva2VuUmVzcG9uc2USGwoTYXV0aG9y",
                  "aXphdGlvbl90b2tlbhgBIAEoDCI1CiJHZW5lcmF0ZUZpcm13YXJlRG93bmxv",
                  "YWRVcmlSZXF1ZXN0Eg8KB2dhdGV3YXkYASABKAkiSwojR2VuZXJhdGVGaXJt",
                  "d2FyZURvd25sb2FkVXJpUmVzcG9uc2USFAoMZG93bmxvYWRfdXJpGAEgASgJ",
                  "Eg4KBmRpZ2VzdBgCIAEoCSIlCiNHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRV",
                  "cmlNZXRhZGF0YTKECwoOR2F0ZXdheVNlcnZpY2USYAoNQ3JlYXRlR2F0ZXdh",
                  "eRItLnNhbHRvLm5lYnVsYS5nYXRld2F5LnYxLkNyZWF0ZUdhdGV3YXlSZXF1",
                  "ZXN0GiAuc2FsdG8ubmVidWxhLmdhdGV3YXkudjEuR2F0ZXdheRJaCgpHZXRH",
                  "YXRld2F5Eiouc2FsdG8ubmVidWxhLmdhdGV3YXkudjEuR2V0R2F0ZXdheVJl",
                  "cXVlc3QaIC5zYWx0by5uZWJ1bGEuZ2F0ZXdheS52MS5HYXRld2F5EmsKDExp",
                  "c3RHYXRld2F5cxIsLnNhbHRvLm5lYnVsYS5nYXRld2F5LnYxLkxpc3RHYXRl",
                  "d2F5c1JlcXVlc3QaLS5zYWx0by5uZWJ1bGEuZ2F0ZXdheS52MS5MaXN0R2F0",
                  "ZXdheXNSZXNwb25zZRJgCg1VcGRhdGVHYXRld2F5Ei0uc2FsdG8ubmVidWxh",
                  "LmdhdGV3YXkudjEuVXBkYXRlR2F0ZXdheVJlcXVlc3QaIC5zYWx0by5uZWJ1",
                  "bGEuZ2F0ZXdheS52MS5HYXRld2F5ElYKDURlbGV0ZUdhdGV3YXkSLS5zYWx0",
                  "by5uZWJ1bGEuZ2F0ZXdheS52MS5EZWxldGVHYXRld2F5UmVxdWVzdBoWLmdv",
                  "b2dsZS5wcm90b2J1Zi5FbXB0eRJoCgtCaW5kR2F0ZXdheRIrLnNhbHRvLm5l",
                  "YnVsYS5nYXRld2F5LnYxLkJpbmRHYXRld2F5UmVxdWVzdBosLnNhbHRvLm5l",
                  "YnVsYS5nYXRld2F5LnYxLkJpbmRHYXRld2F5UmVzcG9uc2USbgoNVW5iaW5k",
                  "R2F0ZXdheRItLnNhbHRvLm5lYnVsYS5nYXRld2F5LnYxLlVuYmluZEdhdGV3",
                  "YXlSZXF1ZXN0Gi4uc2FsdG8ubmVidWxhLmdhdGV3YXkudjEuVW5iaW5kR2F0",
                  "ZXdheVJlc3BvbnNlEmcKEUluaXRpYWxpemVHYXRld2F5EjEuc2FsdG8ubmVi",
                  "dWxhLmdhdGV3YXkudjEuSW5pdGlhbGl6ZUdhdGV3YXlSZXF1ZXN0Gh8uc2Fs",
                  "dG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uEmUKEENvbmZpZ3VyZUdhdGV3",
                  "YXkSMC5zYWx0by5uZWJ1bGEuZ2F0ZXdheS52MS5Db25maWd1cmVHYXRld2F5",
                  "UmVxdWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9wZXJhdGlvbhJdCgxS",
                  "ZXNldEdhdGV3YXkSLC5zYWx0by5uZWJ1bGEuZ2F0ZXdheS52MS5SZXNldEdh",
                  "dGV3YXlSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9u",
                  "Em8KFVVwZGF0ZUdhdGV3YXlGaXJtd2FyZRI1LnNhbHRvLm5lYnVsYS5nYXRl",
                  "d2F5LnYxLlVwZGF0ZUdhdGV3YXlGaXJtd2FyZVJlcXVlc3QaHy5zYWx0by5s",
                  "b25ncnVubmluZy52MS5PcGVyYXRpb24SlQEKGkdlbmVyYXRlQXV0aG9yaXph",
                  "dGlvblRva2VuEjouc2FsdG8ubmVidWxhLmdhdGV3YXkudjEuR2VuZXJhdGVB",
                  "dXRob3JpemF0aW9uVG9rZW5SZXF1ZXN0Gjsuc2FsdG8ubmVidWxhLmdhdGV3",
                  "YXkudjEuR2VuZXJhdGVBdXRob3JpemF0aW9uVG9rZW5SZXNwb25zZRJ7ChtH",
                  "ZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmkSOy5zYWx0by5uZWJ1bGEuZ2F0",
                  "ZXdheS52MS5HZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlSZXF1ZXN0Gh8u",
                  "c2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uQt0BCh9jb20uc2FsdG9h",
                  "cGlzLm5lYnVsYS5nYXRld2F5LnYxQgxHYXRld2F5UHJvdG9QAVpEZ2l0aHVi",
                  "LmNvbS9zYWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS9n",
                  "YXRld2F5L3YxO2dhdGV3YXmqAhtTYWx0b2FwaXMuTmVidWxhLkdhdGV3YXku",
                  "VjHKAhtTYWx0b2FwaXNcTmVidWxhXEdhdGV3YXlcVjHiAidHUEJNZXRhZGF0",
                  "YVxTYWx0b2FwaXNcTmVidWxhXEdhdGV3YXlcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.DeviceMetadataReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Gateway), Gateway.Parser, ["Name", "DisplayName", "DeviceId", "Initialized", "DeviceMetadata", "Connected", "EthernetSettings", "WifiSettings"], ["DeviceId"], null, null, null),
            new(typeof(EthernetSettings), EthernetSettings.Parser, ["Ipv4Settings", "DnsSettings"], null, null, null, null),
            new(typeof(WifiSettings), WifiSettings.Parser, ["Ipv4Settings", "DnsSettings", "Ssid", "Password"], ["Password"], null, null, null),
            new(typeof(IPv4Settings), IPv4Settings.Parser, ["IpAddress", "Mask", "RouterAddress"], ["IpAddress", "Mask", "RouterAddress"], null, null, null),
            new(typeof(DNSSettings), DNSSettings.Parser, ["DnsAddresses"], null, null, null, null),
            new(typeof(CreateGatewayRequest), CreateGatewayRequest.Parser, ["Parent", "GatewayId", "Gateway"], ["GatewayId"], null, null, null),
            new(typeof(GetGatewayRequest), GetGatewayRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListGatewaysRequest), ListGatewaysRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListGatewaysResponse), ListGatewaysResponse.Parser, ["Gateways", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateGatewayRequest), UpdateGatewayRequest.Parser, ["Gateway", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteGatewayRequest), DeleteGatewayRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindGatewayRequest), BindGatewayRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindGatewayResponse), BindGatewayResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindGatewayRequest), UnbindGatewayRequest.Parser, ["Name", "Force"], null, null, null, null),
            new(typeof(UnbindGatewayResponse), UnbindGatewayResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeGatewayRequest), InitializeGatewayRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(InitializeGatewayResponse), InitializeGatewayResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeGatewayMetadata), InitializeGatewayMetadata.Parser, null, null, null, null, null),
            new(typeof(ConfigureGatewayRequest), ConfigureGatewayRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ConfigureGatewayResponse), ConfigureGatewayResponse.Parser, null, null, null, null, null),
            new(typeof(ConfigureGatewayMetadata), ConfigureGatewayMetadata.Parser, null, null, null, null, null),
            new(typeof(ResetGatewayRequest), ResetGatewayRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetGatewayResponse), ResetGatewayResponse.Parser, null, null, null, null, null),
            new(typeof(ResetGatewayMetadata), ResetGatewayMetadata.Parser, null, null, null, null, null),
            new(typeof(UpdateGatewayFirmwareRequest), UpdateGatewayFirmwareRequest.Parser, ["Gateway"], null, null, null, null),
            new(typeof(UpdateGatewayFirmwareResponse), UpdateGatewayFirmwareResponse.Parser, null, null, null, null, null),
            new(typeof(UpdateGatewayFirmwareMetadata), UpdateGatewayFirmwareMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["Gateway"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["Gateway"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null)
                ]));
        }

    }


}
