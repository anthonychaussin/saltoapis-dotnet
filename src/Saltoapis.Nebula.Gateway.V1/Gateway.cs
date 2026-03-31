using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Gateway.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/gateway/v1/gateway.proto</summary>
    public static partial class GatewayReflection
    {

        #region Descriptor
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
        #endregion

    }
    #region Messages
    /// <summary>
    /// The gateway object
    /// </summary>
    public sealed partial class Gateway : IMessage<Gateway>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Gateway> _parser = new(() => new Gateway());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Gateway> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Gateway()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Gateway(Gateway other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            connected_ = other.connected_;
            ethernetSettings_ = other.ethernetSettings_?.Clone();
            wifiSettings_ = other.wifiSettings_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Gateway Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the gateway. It must have the format of
        /// `installations/*/gateways/*`. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the gateway.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 3;
        private readonly static string DeviceIdDefaultValue = "";

        private string deviceId_;

        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, encoders and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_ ?? DeviceIdDefaultValue; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId
        {
            get { return deviceId_ != null; }
        }

        /// <summary>Clears the value of the "device_id" field</summary>
        public void ClearDeviceId()
        {
            deviceId_ = null;
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 4;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this gateway has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateGateway`][salto.nebula.gateway.v1.GatewayService.UpdateGateway]
        /// operation. To change the value of this field, you must call
        /// [`InitializeGateway`][salto.nebula.gateway.v1.GatewayService.InitializeGateway].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get { return initialized_; }
            set
            {
                initialized_ = value;
            }
        }

        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 8;
        private Type.DeviceMetadata deviceMetadata_;

        /// <summary>
        /// Device metadata contains information about a device hardware and firmware.
        /// </summary>
        public Type.DeviceMetadata DeviceMetadata
        {
            get { return deviceMetadata_; }
            set
            {
                deviceMetadata_ = value;
            }
        }

        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 7;
        private bool connected_;

        /// <summary>
        /// Indicates whether this gateway is connected or not. It's considered
        /// connected if the gateway has successfully established communication
        /// with the MQTT server.
        /// </summary>
        public bool Connected
        {
            get { return connected_; }
            set
            {
                connected_ = value;
            }
        }

        /// <summary>Field number for the "ethernet_settings" field.</summary>
        public const int EthernetSettingsFieldNumber = 5;
        private EthernetSettings ethernetSettings_;

        /// <summary>
        /// Ethernet network settings for a gateway
        /// </summary>
        public EthernetSettings EthernetSettings
        {
            get { return ethernetSettings_; }
            set
            {
                ethernetSettings_ = value;
            }
        }

        /// <summary>Field number for the "wifi_settings" field.</summary>
        public const int WifiSettingsFieldNumber = 6;
        private WifiSettings wifiSettings_;

        /// <summary>
        /// WiFi network settings for a gateway
        /// </summary>
        public WifiSettings WifiSettings
        {
            get { return wifiSettings_; }
            set
            {
                wifiSettings_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Gateway);
        public bool Equals(Gateway other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (DisplayName != other.DisplayName) return false;
            if (DeviceId != other.DeviceId) return false;
            if (Initialized != other.Initialized) return false;
            if (!Equals(DeviceMetadata, other.DeviceMetadata)) return false;
            if (Connected != other.Connected) return false;
            if (!Equals(EthernetSettings, other.EthernetSettings)) return false;
            if (!Equals(WifiSettings, other.WifiSettings)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Connected != false) hash ^= Connected.GetHashCode();
            if (ethernetSettings_ != null) hash ^= EthernetSettings.GetHashCode();
            if (wifiSettings_ != null) hash ^= WifiSettings.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (HasDeviceId) {
        output.WriteRawTag(26);
        output.WriteString(DeviceId);
      }
      if (Initialized != false) {
        output.WriteRawTag(32);
        output.WriteBool(Initialized);
      }
      if (ethernetSettings_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EthernetSettings);
      }
      if (wifiSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(WifiSettings);
      }
      if (Connected != false) {
        output.WriteRawTag(56);
        output.WriteBool(Connected);
      }
      if (deviceMetadata_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(DeviceMetadata);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DisplayName);
            }
            if (HasDeviceId)
            {
                output.WriteRawTag(26);
                output.WriteString(DeviceId);
            }
            if (Initialized != false)
            {
                output.WriteRawTag(32);
                output.WriteBool(Initialized);
            }
            if (ethernetSettings_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(EthernetSettings);
            }
            if (wifiSettings_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(WifiSettings);
            }
            if (Connected != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(Connected);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(DeviceMetadata);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (HasDeviceId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            if (Initialized != false)
            {
                size += 1 + 1;
            }
            if (deviceMetadata_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            }
            if (Connected != false)
            {
                size += 1 + 1;
            }
            if (ethernetSettings_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(EthernetSettings);
            }
            if (wifiSettings_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(WifiSettings);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Gateway other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
            }
            if (other.HasDeviceId)
            {
                DeviceId = other.DeviceId;
            }
            if (other.Initialized != false)
            {
                Initialized = other.Initialized;
            }
            if (other.deviceMetadata_ != null)
            {
                if (deviceMetadata_ == null)
                {
                    DeviceMetadata = new Type.DeviceMetadata();
                }
                DeviceMetadata.MergeFrom(other.DeviceMetadata);
            }
            if (other.Connected != false)
            {
                Connected = other.Connected;
            }
            if (other.ethernetSettings_ != null)
            {
                if (ethernetSettings_ == null)
                {
                    EthernetSettings = new EthernetSettings();
                }
                EthernetSettings.MergeFrom(other.EthernetSettings);
            }
            if (other.wifiSettings_ != null)
            {
                if (wifiSettings_ == null)
                {
                    WifiSettings = new WifiSettings();
                }
                WifiSettings.MergeFrom(other.WifiSettings);
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            DeviceId = input.ReadString();
            break;
          }
          case 32: {
            Initialized = input.ReadBool();
            break;
          }
          case 42: {
            if (ethernetSettings_ == null) {
              EthernetSettings = new Saltoapis.Nebula.Gateway.V1.EthernetSettings();
            }
            input.ReadMessage(EthernetSettings);
            break;
          }
          case 50: {
            if (wifiSettings_ == null) {
              WifiSettings = new Saltoapis.Nebula.Gateway.V1.WifiSettings();
            }
            input.ReadMessage(WifiSettings);
            break;
          }
          case 56: {
            Connected = input.ReadBool();
            break;
          }
          case 66: {
            if (deviceMetadata_ == null) {
              DeviceMetadata = new Saltoapis.Nebula.Type.DeviceMetadata();
            }
            input.ReadMessage(DeviceMetadata);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DeviceId = input.ReadString();
                            break;
                        }
                    case 32:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 42:
                        {
                            if (ethernetSettings_ == null)
                            {
                                EthernetSettings = new EthernetSettings();
                            }
                            input.ReadMessage(EthernetSettings);
                            break;
                        }
                    case 50:
                        {
                            if (wifiSettings_ == null)
                            {
                                WifiSettings = new WifiSettings();
                            }
                            input.ReadMessage(WifiSettings);
                            break;
                        }
                    case 56:
                        {
                            Connected = input.ReadBool();
                            break;
                        }
                    case 66:
                        {
                            if (deviceMetadata_ == null)
                            {
                                DeviceMetadata = new Type.DeviceMetadata();
                            }
                            input.ReadMessage(DeviceMetadata);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Ethernet network settings
    /// </summary>
    public sealed partial class EthernetSettings : IMessage<EthernetSettings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EthernetSettings> _parser = new(() => new EthernetSettings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EthernetSettings> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EthernetSettings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EthernetSettings(EthernetSettings other) : this()
        {
            ipv4Settings_ = other.ipv4Settings_?.Clone();
            dnsSettings_ = other.dnsSettings_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EthernetSettings Clone() => new(this);
        /// <summary>Field number for the "ipv4_settings" field.</summary>
        public const int Ipv4SettingsFieldNumber = 1;
        private IPv4Settings ipv4Settings_;

        /// <summary>
        /// IPv4 (Internet Protocol version 4) settings of an ethernet network.
        /// </summary>
        public IPv4Settings Ipv4Settings
        {
            get { return ipv4Settings_; }
            set
            {
                ipv4Settings_ = value;
            }
        }

        /// <summary>Field number for the "dns_settings" field.</summary>
        public const int DnsSettingsFieldNumber = 2;
        private DNSSettings dnsSettings_;

        /// <summary>
        /// DNS settings of an ethernet network.
        /// </summary>
        public DNSSettings DnsSettings
        {
            get { return dnsSettings_; }
            set
            {
                dnsSettings_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as EthernetSettings);
        public bool Equals(EthernetSettings other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Ipv4Settings, other.Ipv4Settings)) return false;
            if (!Equals(DnsSettings, other.DnsSettings)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ipv4Settings_ != null) hash ^= Ipv4Settings.GetHashCode();
            if (dnsSettings_ != null) hash ^= DnsSettings.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (ipv4Settings_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Ipv4Settings);
      }
      if (dnsSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DnsSettings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ipv4Settings_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Ipv4Settings);
            }
            if (dnsSettings_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(DnsSettings);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ipv4Settings_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Ipv4Settings);
            }
            if (dnsSettings_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DnsSettings);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(EthernetSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ipv4Settings_ != null)
            {
                if (ipv4Settings_ == null)
                {
                    Ipv4Settings = new IPv4Settings();
                }
                Ipv4Settings.MergeFrom(other.Ipv4Settings);
            }
            if (other.dnsSettings_ != null)
            {
                if (dnsSettings_ == null)
                {
                    DnsSettings = new DNSSettings();
                }
                DnsSettings.MergeFrom(other.DnsSettings);
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (ipv4Settings_ == null) {
              Ipv4Settings = new Saltoapis.Nebula.Gateway.V1.IPv4Settings();
            }
            input.ReadMessage(Ipv4Settings);
            break;
          }
          case 18: {
            if (dnsSettings_ == null) {
              DnsSettings = new Saltoapis.Nebula.Gateway.V1.DNSSettings();
            }
            input.ReadMessage(DnsSettings);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            if (ipv4Settings_ == null)
                            {
                                Ipv4Settings = new IPv4Settings();
                            }
                            input.ReadMessage(Ipv4Settings);
                            break;
                        }
                    case 18:
                        {
                            if (dnsSettings_ == null)
                            {
                                DnsSettings = new DNSSettings();
                            }
                            input.ReadMessage(DnsSettings);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// WiFi network settings
    /// </summary>
    public sealed partial class WifiSettings : IMessage<WifiSettings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<WifiSettings> _parser = new(() => new WifiSettings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<WifiSettings> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public WifiSettings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public WifiSettings(WifiSettings other) : this()
        {
            ipv4Settings_ = other.ipv4Settings_?.Clone();
            dnsSettings_ = other.dnsSettings_?.Clone();
            ssid_ = other.ssid_;
            password_ = other.password_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public WifiSettings Clone() => new(this);
        /// <summary>Field number for the "ipv4_settings" field.</summary>
        public const int Ipv4SettingsFieldNumber = 1;
        private IPv4Settings ipv4Settings_;

        /// <summary>
        /// IPv4 (Internet Protocol version 4) settings of a WiFi network.
        /// </summary>
        public IPv4Settings Ipv4Settings
        {
            get { return ipv4Settings_; }
            set
            {
                ipv4Settings_ = value;
            }
        }

        /// <summary>Field number for the "dns_settings" field.</summary>
        public const int DnsSettingsFieldNumber = 2;
        private DNSSettings dnsSettings_;

        /// <summary>
        /// DNS settings of a WiFi network.
        /// </summary>
        public DNSSettings DnsSettings
        {
            get { return dnsSettings_; }
            set
            {
                dnsSettings_ = value;
            }
        }

        /// <summary>Field number for the "ssid" field.</summary>
        public const int SsidFieldNumber = 3;
        private string ssid_ = "";

        /// <summary>
        /// Service set identifier of a WiFi network. An SSID is a 32-character
        /// unique identifier attached to the header of packets that are sent over a
        /// Wireless Local Area Network. SSIDs serve as "network names" and are
        /// typically human readable.
        /// </summary>
        public string Ssid
        {
            get { return ssid_; }
            set
            {
                ssid_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "password" field.</summary>
        public const int PasswordFieldNumber = 4;
        private readonly static string PasswordDefaultValue = "";

        private string password_;

        /// <summary>
        /// Password to be used to authenticate on a WiFi network.
        /// </summary>
        public string Password
        {
            get { return password_ ?? PasswordDefaultValue; }
            set
            {
                password_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "password" field is set</summary>
        public bool HasPassword
        {
            get { return password_ != null; }
        }

        /// <summary>Clears the value of the "password" field</summary>
        public void ClearPassword()
        {
            password_ = null;
        }

        public override bool Equals(object other) => Equals(other as WifiSettings);
        public bool Equals(WifiSettings other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Ipv4Settings, other.Ipv4Settings)) return false;
            if (!Equals(DnsSettings, other.DnsSettings)) return false;
            if (Ssid != other.Ssid) return false;
            if (Password != other.Password) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ipv4Settings_ != null) hash ^= Ipv4Settings.GetHashCode();
            if (dnsSettings_ != null) hash ^= DnsSettings.GetHashCode();
            if (Ssid.Length != 0) hash ^= Ssid.GetHashCode();
            if (HasPassword) hash ^= Password.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (ipv4Settings_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Ipv4Settings);
      }
      if (dnsSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DnsSettings);
      }
      if (Ssid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ssid);
      }
      if (HasPassword) {
        output.WriteRawTag(34);
        output.WriteString(Password);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ipv4Settings_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Ipv4Settings);
            }
            if (dnsSettings_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(DnsSettings);
            }
            if (Ssid.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Ssid);
            }
            if (HasPassword)
            {
                output.WriteRawTag(34);
                output.WriteString(Password);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ipv4Settings_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Ipv4Settings);
            }
            if (dnsSettings_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DnsSettings);
            }
            if (Ssid.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Ssid);
            }
            if (HasPassword)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Password);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(WifiSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ipv4Settings_ != null)
            {
                if (ipv4Settings_ == null)
                {
                    Ipv4Settings = new IPv4Settings();
                }
                Ipv4Settings.MergeFrom(other.Ipv4Settings);
            }
            if (other.dnsSettings_ != null)
            {
                if (dnsSettings_ == null)
                {
                    DnsSettings = new DNSSettings();
                }
                DnsSettings.MergeFrom(other.DnsSettings);
            }
            if (other.Ssid.Length != 0)
            {
                Ssid = other.Ssid;
            }
            if (other.HasPassword)
            {
                Password = other.Password;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (ipv4Settings_ == null) {
              Ipv4Settings = new Saltoapis.Nebula.Gateway.V1.IPv4Settings();
            }
            input.ReadMessage(Ipv4Settings);
            break;
          }
          case 18: {
            if (dnsSettings_ == null) {
              DnsSettings = new Saltoapis.Nebula.Gateway.V1.DNSSettings();
            }
            input.ReadMessage(DnsSettings);
            break;
          }
          case 26: {
            Ssid = input.ReadString();
            break;
          }
          case 34: {
            Password = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            if (ipv4Settings_ == null)
                            {
                                Ipv4Settings = new IPv4Settings();
                            }
                            input.ReadMessage(Ipv4Settings);
                            break;
                        }
                    case 18:
                        {
                            if (dnsSettings_ == null)
                            {
                                DnsSettings = new DNSSettings();
                            }
                            input.ReadMessage(DnsSettings);
                            break;
                        }
                    case 26:
                        {
                            Ssid = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Password = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// IPv4 (Internet Protocol version 4) settings
    /// </summary>
    public sealed partial class IPv4Settings : IMessage<IPv4Settings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IPv4Settings> _parser = new(() => new IPv4Settings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IPv4Settings> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IPv4Settings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IPv4Settings(IPv4Settings other) : this()
        {
            ipAddress_ = other.ipAddress_;
            mask_ = other.mask_;
            routerAddress_ = other.routerAddress_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IPv4Settings Clone() => new(this);
        /// <summary>Field number for the "ip_address" field.</summary>
        public const int IpAddressFieldNumber = 1;
        private readonly static string IpAddressDefaultValue = "";

        private string ipAddress_;

        /// <summary>
        /// IP address
        ///
        /// If unset, an automatic value given by the network will be used.
        /// </summary>
        public string IpAddress
        {
            get { return ipAddress_ ?? IpAddressDefaultValue; }
            set
            {
                ipAddress_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "ip_address" field is set</summary>
        public bool HasIpAddress
        {
            get { return ipAddress_ != null; }
        }

        /// <summary>Clears the value of the "ip_address" field</summary>
        public void ClearIpAddress()
        {
            ipAddress_ = null;
        }

        /// <summary>Field number for the "mask" field.</summary>
        public const int MaskFieldNumber = 2;
        private readonly static string MaskDefaultValue = "";

        private string mask_;

        /// <summary>
        /// Subnet mask is expressed in dot-decimal notation like an address.
        /// For example: 255.255.255.0 is the subnet mask for the prefix
        /// 198.51.100.0/24.
        ///
        /// If unset, an automatic value given by the network will be used.
        /// </summary>
        public string Mask
        {
            get { return mask_ ?? MaskDefaultValue; }
            set
            {
                mask_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "mask" field is set</summary>
        public bool HasMask
        {
            get { return mask_ != null; }
        }

        /// <summary>Clears the value of the "mask" field</summary>
        public void ClearMask()
        {
            mask_ = null;
        }

        /// <summary>Field number for the "router_address" field.</summary>
        public const int RouterAddressFieldNumber = 3;
        private readonly static string RouterAddressDefaultValue = "";

        private string routerAddress_;

        /// <summary>
        /// Default network router's IP address
        ///
        /// If unset, an automatic value given by the network will be used.
        /// </summary>
        public string RouterAddress
        {
            get { return routerAddress_ ?? RouterAddressDefaultValue; }
            set
            {
                routerAddress_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "router_address" field is set</summary>
        public bool HasRouterAddress
        {
            get { return routerAddress_ != null; }
        }

        /// <summary>Clears the value of the "router_address" field</summary>
        public void ClearRouterAddress()
        {
            routerAddress_ = null;
        }

        public override bool Equals(object other) => Equals(other as IPv4Settings);
        public bool Equals(IPv4Settings other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IpAddress != other.IpAddress) return false;
            if (Mask != other.Mask) return false;
            if (RouterAddress != other.RouterAddress) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (HasIpAddress) hash ^= IpAddress.GetHashCode();
            if (HasMask) hash ^= Mask.GetHashCode();
            if (HasRouterAddress) hash ^= RouterAddress.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (HasIpAddress) {
        output.WriteRawTag(10);
        output.WriteString(IpAddress);
      }
      if (HasMask) {
        output.WriteRawTag(18);
        output.WriteString(Mask);
      }
      if (HasRouterAddress) {
        output.WriteRawTag(26);
        output.WriteString(RouterAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (HasIpAddress)
            {
                output.WriteRawTag(10);
                output.WriteString(IpAddress);
            }
            if (HasMask)
            {
                output.WriteRawTag(18);
                output.WriteString(Mask);
            }
            if (HasRouterAddress)
            {
                output.WriteRawTag(26);
                output.WriteString(RouterAddress);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (HasIpAddress)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(IpAddress);
            }
            if (HasMask)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Mask);
            }
            if (HasRouterAddress)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(RouterAddress);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(IPv4Settings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.HasIpAddress)
            {
                IpAddress = other.IpAddress;
            }
            if (other.HasMask)
            {
                Mask = other.Mask;
            }
            if (other.HasRouterAddress)
            {
                RouterAddress = other.RouterAddress;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            IpAddress = input.ReadString();
            break;
          }
          case 18: {
            Mask = input.ReadString();
            break;
          }
          case 26: {
            RouterAddress = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            IpAddress = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Mask = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            RouterAddress = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// DNS settings
    /// </summary>
    public sealed partial class DNSSettings : IMessage<DNSSettings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DNSSettings> _parser = new(() => new DNSSettings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DNSSettings> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DNSSettings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DNSSettings(DNSSettings other) : this()
        {
            dnsAddresses_ = other.dnsAddresses_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DNSSettings Clone() => new(this);
        /// <summary>Field number for the "dns_addresses" field.</summary>
        public const int DnsAddressesFieldNumber = 1;
        private static readonly FieldCodec<string> _repeated_dnsAddresses_codec
            = FieldCodec.ForString(10);
        private readonly RepeatedField<string> dnsAddresses_ = [];

        /// <summary>
        /// DNS server IP addresses. The order of the elements in this list will mark
        /// priorities. For example: the first element will be primary DNS and the
        /// second element will be secondary DNS.
        ///
        /// If empty, an automatic DNS address given by the network will be used.
        /// </summary>
        public RepeatedField<string> DnsAddresses
        {
            get { return dnsAddresses_; }
        }

        public override bool Equals(object other) => Equals(other as DNSSettings);
        public bool Equals(DNSSettings other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!dnsAddresses_.Equals(other.dnsAddresses_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= dnsAddresses_.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      dnsAddresses_.WriteTo(output, _repeated_dnsAddresses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            dnsAddresses_.WriteTo(ref output, _repeated_dnsAddresses_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += dnsAddresses_.CalculateSize(_repeated_dnsAddresses_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DNSSettings other)
        {
            if (other == null)
            {
                return;
            }
            dnsAddresses_.Add(other.dnsAddresses_);
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            dnsAddresses_.AddEntriesFrom(input, _repeated_dnsAddresses_codec);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            dnsAddresses_.AddEntriesFrom(ref input, _repeated_dnsAddresses_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [CreateGateway][salto.nebula.gateway.v1.GatewayService.CreateGateway]
    /// </summary>
    public sealed partial class CreateGatewayRequest : IMessage<CreateGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateGatewayRequest> _parser = new(() => new CreateGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateGatewayRequest(CreateGatewayRequest other) : this()
        {
            parent_ = other.parent_;
            gatewayId_ = other.gatewayId_;
            gateway_ = other.gateway_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the gateway. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "gateway_id" field.</summary>
        public const int GatewayIdFieldNumber = 2;
        private readonly static string GatewayIdDefaultValue = "";

        private string gatewayId_;

        /// <summary>
        /// The gateway ID to use for this gateway. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string GatewayId
        {
            get { return gatewayId_ ?? GatewayIdDefaultValue; }
            set
            {
                gatewayId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "gateway_id" field is set</summary>
        public bool HasGatewayId
        {
            get { return gatewayId_ != null; }
        }

        /// <summary>Clears the value of the "gateway_id" field</summary>
        public void ClearGatewayId()
        {
            gatewayId_ = null;
        }

        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 3;
        private Gateway gateway_;

        /// <summary>
        /// The gateway resource to be created. Client must not set the
        /// `Gateway.name` field.
        /// </summary>
        public Gateway Gateway
        {
            get { return gateway_; }
            set
            {
                gateway_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateGatewayRequest);
        public bool Equals(CreateGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (GatewayId != other.GatewayId) return false;
            if (!Equals(Gateway, other.Gateway)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasGatewayId) hash ^= GatewayId.GetHashCode();
            if (gateway_ != null) hash ^= Gateway.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (HasGatewayId) {
        output.WriteRawTag(18);
        output.WriteString(GatewayId);
      }
      if (gateway_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Gateway);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (HasGatewayId)
            {
                output.WriteRawTag(18);
                output.WriteString(GatewayId);
            }
            if (gateway_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Gateway);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (HasGatewayId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(GatewayId);
            }
            if (gateway_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Gateway);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasGatewayId)
            {
                GatewayId = other.GatewayId;
            }
            if (other.gateway_ != null)
            {
                if (gateway_ == null)
                {
                    Gateway = new Gateway();
                }
                Gateway.MergeFrom(other.Gateway);
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Parent = input.ReadString();
            break;
          }
          case 18: {
            GatewayId = input.ReadString();
            break;
          }
          case 26: {
            if (gateway_ == null) {
              Gateway = new Saltoapis.Nebula.Gateway.V1.Gateway();
            }
            input.ReadMessage(Gateway);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Parent = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            GatewayId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (gateway_ == null)
                            {
                                Gateway = new Gateway();
                            }
                            input.ReadMessage(Gateway);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetGateway][salto.nebula.gateway.v1.GatewayService.GetGateway]
    /// </summary>
    public sealed partial class GetGatewayRequest : IMessage<GetGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetGatewayRequest> _parser = new(() => new GetGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetGatewayRequest(GetGatewayRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested gateway resource. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetGatewayRequest);
        public bool Equals(GetGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GetGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [ListGateways][salto.nebula.gateway.v1.GatewayService.ListGateways]
    /// </summary>
    public sealed partial class ListGatewaysRequest : IMessage<ListGatewaysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListGatewaysRequest> _parser = new(() => new ListGatewaysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListGatewaysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListGatewaysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListGatewaysRequest(ListGatewaysRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListGatewaysRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 2;
        private int pageSize_;

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
            }
        }

        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 3;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 4;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which gateways to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "order_by" field.</summary>
        public const int OrderByFieldNumber = 5;
        private string orderBy_ = "";

        /// <summary>
        /// How the results should be sorted.
        /// </summary>
        public string OrderBy
        {
            get { return orderBy_; }
            set
            {
                orderBy_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListGatewaysRequest);
        public bool Equals(ListGatewaysRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            if (OrderBy != other.OrderBy) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (PageSize != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Filter);
            }
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(OrderBy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (PageSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            }
            if (PageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            }
            if (Filter.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            }
            if (OrderBy.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListGatewaysRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PageSize != 0)
            {
                PageSize = other.PageSize;
            }
            if (other.PageToken.Length != 0)
            {
                PageToken = other.PageToken;
            }
            if (other.Filter.Length != 0)
            {
                Filter = other.Filter;
            }
            if (other.OrderBy.Length != 0)
            {
                OrderBy = other.OrderBy;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Parent = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 26:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [ListGateways][salto.nebula.gateway.v1.GatewayService.ListGateways]
    /// </summary>
    public sealed partial class ListGatewaysResponse : IMessage<ListGatewaysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListGatewaysResponse> _parser = new(() => new ListGatewaysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListGatewaysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListGatewaysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListGatewaysResponse(ListGatewaysResponse other) : this()
        {
            gateways_ = other.gateways_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListGatewaysResponse Clone() => new(this);
        /// <summary>Field number for the "gateways" field.</summary>
        public const int GatewaysFieldNumber = 1;
        private static readonly FieldCodec<Gateway> _repeated_gateways_codec
            = FieldCodec.ForMessage(10, Gateway.Parser);
        private readonly RepeatedField<Gateway> gateways_ = [];

        /// <summary>
        /// The field name should match the noun `gateways` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Gateway> Gateways
        {
            get { return gateways_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListGatewaysResponse);
        public bool Equals(ListGatewaysResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!gateways_.Equals(other.gateways_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= gateways_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      gateways_.WriteTo(output, _repeated_gateways_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            gateways_.WriteTo(ref output, _repeated_gateways_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += gateways_.CalculateSize(_repeated_gateways_codec);
            if (NextPageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListGatewaysResponse other)
        {
            if (other == null)
            {
                return;
            }
            gateways_.Add(other.gateways_);
            if (other.NextPageToken.Length != 0)
            {
                NextPageToken = other.NextPageToken;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            gateways_.AddEntriesFrom(input, _repeated_gateways_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            gateways_.AddEntriesFrom(ref input, _repeated_gateways_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [UpdateGateway][salto.nebula.gateway.v1.GatewayService.UpdateGateway]
    /// </summary>
    public sealed partial class UpdateGatewayRequest : IMessage<UpdateGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateGatewayRequest> _parser = new(() => new UpdateGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateGatewayRequest(UpdateGatewayRequest other) : this()
        {
            gateway_ = other.gateway_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 1;
        private Gateway gateway_;

        /// <summary>
        /// The gateway resource which replaces the resource on the server.
        /// </summary>
        public Gateway Gateway
        {
            get { return gateway_; }
            set
            {
                gateway_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateGatewayRequest);
        public bool Equals(UpdateGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Gateway, other.Gateway)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (gateway_ != null) hash ^= Gateway.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (gateway_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Gateway);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (gateway_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Gateway);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (gateway_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Gateway);
            }
            if (updateMask_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.gateway_ != null)
            {
                if (gateway_ == null)
                {
                    Gateway = new Gateway();
                }
                Gateway.MergeFrom(other.Gateway);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null)
                {
                    UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                }
                UpdateMask.MergeFrom(other.UpdateMask);
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (gateway_ == null) {
              Gateway = new Saltoapis.Nebula.Gateway.V1.Gateway();
            }
            input.ReadMessage(Gateway);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            if (gateway_ == null)
                            {
                                Gateway = new Gateway();
                            }
                            input.ReadMessage(Gateway);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null)
                            {
                                UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            }
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [DeleteGateway][salto.nebula.gateway.v1.GatewayService.DeleteGateway]
    /// </summary>
    public sealed partial class DeleteGatewayRequest : IMessage<DeleteGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteGatewayRequest> _parser = new(() => new DeleteGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteGatewayRequest(DeleteGatewayRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the gateway to be deleted. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteGatewayRequest);
        public bool Equals(DeleteGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeleteGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`BindGateway`][salto.nebula.gateway.v1.GatewayService.BindGateway]
    /// </summary>
    public sealed partial class BindGatewayRequest : IMessage<BindGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindGatewayRequest> _parser = new(() => new BindGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindGatewayRequest(BindGatewayRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the gateway to be bound. For example:
        /// `installations/surelock-homes-hq/gateways/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 2;
        private string deviceId_ = "";

        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, electronic locks and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as BindGatewayRequest);
        public bool Equals(BindGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (DeviceId != other.DeviceId) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DeviceId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            if (DeviceId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DeviceId);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (DeviceId.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BindGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DeviceId.Length != 0)
            {
                DeviceId = other.DeviceId;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DeviceId = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            DeviceId = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`BindGateway`][salto.nebula.gateway.v1.GatewayService.BindGateway]
    /// </summary>
    public sealed partial class BindGatewayResponse : IMessage<BindGatewayResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindGatewayResponse> _parser = new(() => new BindGatewayResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindGatewayResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindGatewayResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindGatewayResponse(BindGatewayResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindGatewayResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BindGatewayResponse);
        public bool Equals(BindGatewayResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BindGatewayResponse other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UnbindGateway`][salto.nebula.gateway.v1.GatewayService.UnbindGateway]
    /// </summary>
    public sealed partial class UnbindGatewayRequest : IMessage<UnbindGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindGatewayRequest> _parser = new(() => new UnbindGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindGatewayRequest(UnbindGatewayRequest other) : this()
        {
            name_ = other.name_;
            force_ = other.force_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the gateway to be unbound. For example:
        /// `installations/surelock-homes-hq/gateways/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "force" field.</summary>
        public const int ForceFieldNumber = 2;
        private bool force_;

        /// <summary>
        /// If set to true, the device identifier is removed (unbound) from the
        /// gateway. Otherwise, the request will only work if the gateway
        /// isn't bound to any previous device identifier.
        /// </summary>
        public bool Force
        {
            get { return force_; }
            set
            {
                force_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnbindGatewayRequest);
        public bool Equals(UnbindGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (Force != other.Force) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Force != false) hash ^= Force.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Force != false) {
        output.WriteRawTag(16);
        output.WriteBool(Force);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            if (Force != false)
            {
                output.WriteRawTag(16);
                output.WriteBool(Force);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (Force != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UnbindGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Force != false)
            {
                Force = other.Force;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Force = input.ReadBool();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            Force = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`UnbindGateway`][salto.nebula.gateway.v1.GatewayService.UnbindGateway]
    /// </summary>
    public sealed partial class UnbindGatewayResponse : IMessage<UnbindGatewayResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindGatewayResponse> _parser = new(() => new UnbindGatewayResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindGatewayResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindGatewayResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindGatewayResponse(UnbindGatewayResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindGatewayResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnbindGatewayResponse);
        public bool Equals(UnbindGatewayResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UnbindGatewayResponse other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`InitializeGateway`][salto.nebula.gateway.v1.GatewayService.InitializeGateway]
    /// </summary>
    public sealed partial class InitializeGatewayRequest : IMessage<InitializeGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeGatewayRequest> _parser = new(() => new InitializeGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeGatewayRequest(InitializeGatewayRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the gateway to be initialized. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as InitializeGatewayRequest);
        public bool Equals(InitializeGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(InitializeGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`InitializeGateway`][salto.nebula.gateway.v1.GatewayService.InitializeGateway]
    /// </summary>
    public sealed partial class InitializeGatewayResponse : IMessage<InitializeGatewayResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeGatewayResponse> _parser = new(() => new InitializeGatewayResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeGatewayResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeGatewayResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeGatewayResponse(InitializeGatewayResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeGatewayResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeGatewayResponse);
        public bool Equals(InitializeGatewayResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(InitializeGatewayResponse other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`InitializeGateway`][salto.nebula.gateway.v1.GatewayService.InitializeGateway]
    /// </summary>
    public sealed partial class InitializeGatewayMetadata : IMessage<InitializeGatewayMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeGatewayMetadata> _parser = new(() => new InitializeGatewayMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeGatewayMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeGatewayMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeGatewayMetadata(InitializeGatewayMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeGatewayMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeGatewayMetadata);
        public bool Equals(InitializeGatewayMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(InitializeGatewayMetadata other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ConfigureGateway`][salto.nebula.gateway.v1.GatewayService.ConfigureGateway]
    /// </summary>
    public sealed partial class ConfigureGatewayRequest : IMessage<ConfigureGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureGatewayRequest> _parser = new(() => new ConfigureGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureGatewayRequest(ConfigureGatewayRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the gateway to be configured. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ConfigureGatewayRequest);
        public bool Equals(ConfigureGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ConfigureGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`ConfigureGateway`][salto.nebula.gateway.v1.GatewayService.ConfigureGateway]
    /// </summary>
    public sealed partial class ConfigureGatewayResponse : IMessage<ConfigureGatewayResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureGatewayResponse> _parser = new(() => new ConfigureGatewayResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureGatewayResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureGatewayResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureGatewayResponse(ConfigureGatewayResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureGatewayResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureGatewayResponse);
        public bool Equals(ConfigureGatewayResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ConfigureGatewayResponse other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`ConfigureGateway`][salto.nebula.gateway.v1.GatewayService.ConfigureGateway]
    /// </summary>
    public sealed partial class ConfigureGatewayMetadata : IMessage<ConfigureGatewayMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureGatewayMetadata> _parser = new(() => new ConfigureGatewayMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureGatewayMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureGatewayMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureGatewayMetadata(ConfigureGatewayMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureGatewayMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureGatewayMetadata);
        public bool Equals(ConfigureGatewayMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ConfigureGatewayMetadata other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ResetGateway`][salto.nebula.gateway.v1.GatewayService.ResetGateway]
    /// </summary>
    public sealed partial class ResetGatewayRequest : IMessage<ResetGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetGatewayRequest> _parser = new(() => new ResetGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetGatewayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetGatewayRequest(ResetGatewayRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the gateway to be reset. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ResetGatewayRequest);
        public bool Equals(ResetGatewayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ResetGatewayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Name = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`ResetGateway`][salto.nebula.gateway.v1.GatewayService.ResetGateway]
    /// </summary>
    public sealed partial class ResetGatewayResponse : IMessage<ResetGatewayResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetGatewayResponse> _parser = new(() => new ResetGatewayResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetGatewayResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetGatewayResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetGatewayResponse(ResetGatewayResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetGatewayResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetGatewayResponse);
        public bool Equals(ResetGatewayResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ResetGatewayResponse other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`ResetGateway`][salto.nebula.gateway.v1.GatewayService.ResetGateway]
    /// </summary>
    public sealed partial class ResetGatewayMetadata : IMessage<ResetGatewayMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetGatewayMetadata> _parser = new(() => new ResetGatewayMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetGatewayMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetGatewayMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetGatewayMetadata(ResetGatewayMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetGatewayMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetGatewayMetadata);
        public bool Equals(ResetGatewayMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ResetGatewayMetadata other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdateGatewayFirmware`][salto.nebula.gateway.v1.GatewayService.UpdateGatewayFirmware]
    /// </summary>
    public sealed partial class UpdateGatewayFirmwareRequest : IMessage<UpdateGatewayFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateGatewayFirmwareRequest> _parser = new(() => new UpdateGatewayFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateGatewayFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateGatewayFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateGatewayFirmwareRequest(UpdateGatewayFirmwareRequest other) : this()
        {
            gateway_ = other.gateway_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateGatewayFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 1;
        private string gateway_ = "";

        /// <summary>
        /// The resource name of the gateway whose firmware will be updated, for
        /// example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Gateway
        {
            get { return gateway_; }
            set
            {
                gateway_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateGatewayFirmwareRequest);
        public bool Equals(UpdateGatewayFirmwareRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Gateway != other.Gateway) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Gateway.Length != 0) hash ^= Gateway.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Gateway.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Gateway);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Gateway.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Gateway);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Gateway.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateGatewayFirmwareRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Gateway.Length != 0)
            {
                Gateway = other.Gateway;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Gateway = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Gateway = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UpdateGatewayFirmware`][salto.nebula.gateway.v1.GatewayService.UpdateGatewayFirmware]
    /// </summary>
    public sealed partial class UpdateGatewayFirmwareResponse : IMessage<UpdateGatewayFirmwareResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateGatewayFirmwareResponse> _parser = new(() => new UpdateGatewayFirmwareResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateGatewayFirmwareResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[25]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateGatewayFirmwareResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateGatewayFirmwareResponse(UpdateGatewayFirmwareResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateGatewayFirmwareResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UpdateGatewayFirmwareResponse);
        public bool Equals(UpdateGatewayFirmwareResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateGatewayFirmwareResponse other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`UpdateGatewayFirmware`][salto.nebula.gateway.v1.GatewayService.UpdateGatewayFirmware]
    /// </summary>
    public sealed partial class UpdateGatewayFirmwareMetadata : IMessage<UpdateGatewayFirmwareMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateGatewayFirmwareMetadata> _parser = new(() => new UpdateGatewayFirmwareMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateGatewayFirmwareMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[26]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateGatewayFirmwareMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateGatewayFirmwareMetadata(UpdateGatewayFirmwareMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateGatewayFirmwareMetadata Clone() => new(this);
        /// <summary>Field number for the "progress_percent" field.</summary>
        public const int ProgressPercentFieldNumber = 1;
        private int progressPercent_;

        /// <summary>
        /// Progress of operation. Range: [0, 100].
        /// </summary>
        public int ProgressPercent
        {
            get { return progressPercent_; }
            set
            {
                progressPercent_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateGatewayFirmwareMetadata);
        public bool Equals(UpdateGatewayFirmwareMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ProgressPercent != other.ProgressPercent) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ProgressPercent != 0) hash ^= ProgressPercent.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (ProgressPercent != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProgressPercent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ProgressPercent != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(ProgressPercent);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ProgressPercent != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(ProgressPercent);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateGatewayFirmwareMetadata other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ProgressPercent != 0)
            {
                ProgressPercent = other.ProgressPercent;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ProgressPercent = input.ReadInt32();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 8:
                        {
                            ProgressPercent = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GenerateAuthorizationToken`][salto.nebula.gateway.v1.GatewayService.GenerateAuthorizationToken]
    /// </summary>
    public sealed partial class GenerateAuthorizationTokenRequest : IMessage<GenerateAuthorizationTokenRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateAuthorizationTokenRequest> _parser = new(() => new GenerateAuthorizationTokenRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateAuthorizationTokenRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[27]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateAuthorizationTokenRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateAuthorizationTokenRequest(GenerateAuthorizationTokenRequest other) : this()
        {
            gateway_ = other.gateway_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenRequest Clone() => new(this);
        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 1;
        private string gateway_ = "";

        /// <summary>
        /// The resource name of the gateway that the authorization token is
        /// generated for. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Gateway
        {
            get { return gateway_; }
            set
            {
                gateway_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateAuthorizationTokenRequest);
        public bool Equals(GenerateAuthorizationTokenRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Gateway != other.Gateway) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Gateway.Length != 0) hash ^= Gateway.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Gateway.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Gateway);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Gateway.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Gateway);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Gateway.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateAuthorizationTokenRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Gateway.Length != 0)
            {
                Gateway = other.Gateway;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Gateway = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Gateway = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateAuthorizationToken`][salto.nebula.gateway.v1.GatewayService.GenerateAuthorizationToken]
    /// </summary>
    public sealed partial class GenerateAuthorizationTokenResponse : IMessage<GenerateAuthorizationTokenResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateAuthorizationTokenResponse> _parser = new(() => new GenerateAuthorizationTokenResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateAuthorizationTokenResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[28]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateAuthorizationTokenResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateAuthorizationTokenResponse(GenerateAuthorizationTokenResponse other) : this()
        {
            authorizationToken_ = other.authorizationToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenResponse Clone() => new(this);
        /// <summary>Field number for the "authorization_token" field.</summary>
        public const int AuthorizationTokenFieldNumber = 1;
        private ByteString authorizationToken_ = ByteString.Empty;

        /// <summary>
        /// Authorization token to be used for connecting against a gateway.
        /// </summary>
        public ByteString AuthorizationToken
        {
            get { return authorizationToken_; }
            set
            {
                authorizationToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateAuthorizationTokenResponse);
        public bool Equals(GenerateAuthorizationTokenResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (AuthorizationToken != other.AuthorizationToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (AuthorizationToken.Length != 0) hash ^= AuthorizationToken.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (AuthorizationToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(AuthorizationToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (AuthorizationToken.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(AuthorizationToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (AuthorizationToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeBytesSize(AuthorizationToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateAuthorizationTokenResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.AuthorizationToken.Length != 0)
            {
                AuthorizationToken = other.AuthorizationToken;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AuthorizationToken = input.ReadBytes();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            AuthorizationToken = input.ReadBytes();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.gateway.v1.GatewayService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriRequest : IMessage<GenerateFirmwareDownloadUriRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriRequest> _parser = new(() => new GenerateFirmwareDownloadUriRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriRequest(GenerateFirmwareDownloadUriRequest other) : this()
        {
            gateway_ = other.gateway_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 1;
        private string gateway_ = "";

        /// <summary>
        /// The resource name of the gateway to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Gateway
        {
            get { return gateway_; }
            set
            {
                gateway_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriRequest);
        public bool Equals(GenerateFirmwareDownloadUriRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Gateway != other.Gateway) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Gateway.Length != 0) hash ^= Gateway.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Gateway.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Gateway);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Gateway.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Gateway);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Gateway.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Gateway.Length != 0)
            {
                Gateway = other.Gateway;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Gateway = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Gateway = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateFirmwareDownloadUri`][salto.nebula.gateway.v1.GatewayService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriResponse : IMessage<GenerateFirmwareDownloadUriResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriResponse> _parser = new(() => new GenerateFirmwareDownloadUriResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[30]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriResponse(GenerateFirmwareDownloadUriResponse other) : this()
        {
            downloadUri_ = other.downloadUri_;
            digest_ = other.digest_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriResponse Clone() => new(this);
        /// <summary>Field number for the "download_uri" field.</summary>
        public const int DownloadUriFieldNumber = 1;
        private string downloadUri_ = "";

        /// <summary>
        /// The URI to download the firmware bundle. The URI will be valid for 15
        /// minutes.
        /// </summary>
        public string DownloadUri
        {
            get { return downloadUri_; }
            set
            {
                downloadUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "digest" field.</summary>
        public const int DigestFieldNumber = 2;
        private string digest_ = "";

        /// <summary>
        /// Digest of the file to be download. This can be used to cache the file and
        /// avoid downloading it multiple times.
        /// The digest has the following format: `&lt;algorithm>:&lt;digest>`.
        /// For example: `sha256:8ff2483f2fbaa6c8dfd4e3556dbde298eb5e342b5e46f84eabdccc8e1cbe2d5a`.
        /// </summary>
        public string Digest
        {
            get { return digest_; }
            set
            {
                digest_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriResponse);
        public bool Equals(GenerateFirmwareDownloadUriResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (DownloadUri != other.DownloadUri) return false;
            if (Digest != other.Digest) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (DownloadUri.Length != 0) hash ^= DownloadUri.GetHashCode();
            if (Digest.Length != 0) hash ^= Digest.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (DownloadUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DownloadUri);
      }
      if (Digest.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Digest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (DownloadUri.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(DownloadUri);
            }
            if (Digest.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Digest);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (DownloadUri.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DownloadUri);
            }
            if (Digest.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Digest);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.DownloadUri.Length != 0)
            {
                DownloadUri = other.DownloadUri;
            }
            if (other.Digest.Length != 0)
            {
                Digest = other.Digest;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            DownloadUri = input.ReadString();
            break;
          }
          case 18: {
            Digest = input.ReadString();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            DownloadUri = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Digest = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`GenerateFirmwareDownloadUri`][salto.nebula.gateway.v1.GatewayService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriMetadata : IMessage<GenerateFirmwareDownloadUriMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriMetadata> _parser = new(() => new GenerateFirmwareDownloadUriMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[31]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriMetadata(GenerateFirmwareDownloadUriMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriMetadata);
        public bool Equals(GenerateFirmwareDownloadUriMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriMetadata other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    #endregion

}
