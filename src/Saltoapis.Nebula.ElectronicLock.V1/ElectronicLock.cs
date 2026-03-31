using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.ElectronicLock.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/electroniclock/v1/electronic_lock.proto</summary>
    public static partial class ElectronicLockReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/electroniclock/v1/electronic_lock.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static ElectronicLockReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjRzYWx0by9uZWJ1bGEvZWxlY3Ryb25pY2xvY2svdjEvZWxlY3Ryb25pY19s",
                  "b2NrLnByb3RvEh5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2sudjEaHmdv",
                  "b2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90bxobZ29vZ2xlL3Byb3RvYnVm",
                  "L2VtcHR5LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90",
                  "bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxokc2FsdG8vbG9u",
                  "Z3J1bm5pbmcvdjEvb3BlcmF0aW9uLnByb3RvGidzYWx0by9uZWJ1bGEvdHlw",
                  "ZS9kZXZpY2VfbWV0YWRhdGEucHJvdG8i3AQKDkVsZWN0cm9uaWNMb2NrEgwK",
                  "BG5hbWUYASABKAkSFAoMZGlzcGxheV9uYW1lGAIgASgJEhYKCWRldmljZV9p",
                  "ZBgDIAEoCUgBiAEBEhEKB2dhdGV3YXkYBCABKAlIABISCghleHRlbmRlchgF",
                  "IAEoCUgAEhQKDGFjY2Vzc19wb2ludBgGIAEoCRITCgtpbml0aWFsaXplZBgH",
                  "IAEoCBI6Cg9kZXZpY2VfbWV0YWRhdGEYDyABKAsyIS5zYWx0by5uZWJ1bGEu",
                  "dHlwZS5EZXZpY2VNZXRhZGF0YRIQCghvdXRkYXRlZBgIIAEoCBIWCgljb25u",
                  "ZWN0ZWQYCSABKAhIAogBARITCgtsb3dfYmF0dGVyeRgKIAEoCBIzCg9sYXN0",
                  "X2V2ZW50X3RpbWUYCyABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
                  "EiEKFGNhbGlicmF0aW9uX3NldHRpbmdzGAwgASgMSAOIAQESJgoZZm9yY2Vf",
                  "cm90YXRlX2NhcnJpYWdlX2VuZBgNIAEoCEgEiAEBEkAKGGhvbGRfYmFja19s",
                  "YXRjaF9kdXJhdGlvbhgOIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlv",
                  "bkgFiAEBQg8KDXBhcmVudF9kZXZpY2VCDAoKX2RldmljZV9pZEIMCgpfY29u",
                  "bmVjdGVkQhcKFV9jYWxpYnJhdGlvbl9zZXR0aW5nc0IcChpfZm9yY2Vfcm90",
                  "YXRlX2NhcnJpYWdlX2VuZEIbChlfaG9sZF9iYWNrX2xhdGNoX2R1cmF0aW9u",
                  "Iq4BChtDcmVhdGVFbGVjdHJvbmljTG9ja1JlcXVlc3QSDgoGcGFyZW50GAEg",
                  "ASgJEh8KEmVsZWN0cm9uaWNfbG9ja19pZBgCIAEoCUgAiAEBEkcKD2VsZWN0",
                  "cm9uaWNfbG9jaxgDIAEoCzIuLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmljbG9j",
                  "ay52MS5FbGVjdHJvbmljTG9ja0IVChNfZWxlY3Ryb25pY19sb2NrX2lkIigK",
                  "GEdldEVsZWN0cm9uaWNMb2NrUmVxdWVzdBIMCgRuYW1lGAEgASgJInUKGkxp",
                  "c3RFbGVjdHJvbmljTG9ja3NSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIRCglw",
                  "YWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tlbhgDIAEoCRIOCgZmaWx0ZXIY",
                  "BCABKAkSEAoIb3JkZXJfYnkYBSABKAkigAEKG0xpc3RFbGVjdHJvbmljTG9j",
                  "a3NSZXNwb25zZRJIChBlbGVjdHJvbmljX2xvY2tzGAEgAygLMi4uc2FsdG8u",
                  "bmVidWxhLmVsZWN0cm9uaWNsb2NrLnYxLkVsZWN0cm9uaWNMb2NrEhcKD25l",
                  "eHRfcGFnZV90b2tlbhgCIAEoCSKXAQobVXBkYXRlRWxlY3Ryb25pY0xvY2tS",
                  "ZXF1ZXN0EkcKD2VsZWN0cm9uaWNfbG9jaxgBIAEoCzIuLnNhbHRvLm5lYnVs",
                  "YS5lbGVjdHJvbmljbG9jay52MS5FbGVjdHJvbmljTG9jaxIvCgt1cGRhdGVf",
                  "bWFzaxgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2siKwobRGVs",
                  "ZXRlRWxlY3Ryb25pY0xvY2tSZXF1ZXN0EgwKBG5hbWUYASABKAkiPAoZQmlu",
                  "ZEVsZWN0cm9uaWNMb2NrUmVxdWVzdBIMCgRuYW1lGAEgASgJEhEKCWRldmlj",
                  "ZV9pZBgCIAEoCSIcChpCaW5kRWxlY3Ryb25pY0xvY2tSZXNwb25zZSI6ChtV",
                  "bmJpbmRFbGVjdHJvbmljTG9ja1JlcXVlc3QSDAoEbmFtZRgBIAEoCRINCgVm",
                  "b3JjZRgCIAEoCCIeChxVbmJpbmRFbGVjdHJvbmljTG9ja1Jlc3BvbnNlIi8K",
                  "H0luaXRpYWxpemVFbGVjdHJvbmljTG9ja1JlcXVlc3QSDAoEbmFtZRgBIAEo",
                  "CSIiCiBJbml0aWFsaXplRWxlY3Ryb25pY0xvY2tSZXNwb25zZSI8CiBJbml0",
                  "aWFsaXplRWxlY3Ryb25pY0xvY2tNZXRhZGF0YRIYChBwcm9ncmVzc19wZXJj",
                  "ZW50GAEgASgFIi4KHkNvbmZpZ3VyZUVsZWN0cm9uaWNMb2NrUmVxdWVzdBIM",
                  "CgRuYW1lGAEgASgJIiEKH0NvbmZpZ3VyZUVsZWN0cm9uaWNMb2NrUmVzcG9u",
                  "c2UiIQofQ29uZmlndXJlRWxlY3Ryb25pY0xvY2tNZXRhZGF0YSIqChpSZXNl",
                  "dEVsZWN0cm9uaWNMb2NrUmVxdWVzdBIMCgRuYW1lGAEgASgJIh0KG1Jlc2V0",
                  "RWxlY3Ryb25pY0xvY2tSZXNwb25zZSIdChtSZXNldEVsZWN0cm9uaWNMb2Nr",
                  "TWV0YWRhdGEiPgojVXBkYXRlRWxlY3Ryb25pY0xvY2tGaXJtd2FyZVJlcXVl",
                  "c3QSFwoPZWxlY3Ryb25pY19sb2NrGAEgASgJIiYKJFVwZGF0ZUVsZWN0cm9u",
                  "aWNMb2NrRmlybXdhcmVSZXNwb25zZSJACiRVcGRhdGVFbGVjdHJvbmljTG9j",
                  "a0Zpcm13YXJlTWV0YWRhdGESGAoQcHJvZ3Jlc3NfcGVyY2VudBgBIAEoBSI8",
                  "CiFHZW5lcmF0ZUF1dGhvcml6YXRpb25Ub2tlblJlcXVlc3QSFwoPZWxlY3Ry",
                  "b25pY19sb2NrGAEgASgJIkEKIkdlbmVyYXRlQXV0aG9yaXphdGlvblRva2Vu",
                  "UmVzcG9uc2USGwoTYXV0aG9yaXphdGlvbl90b2tlbhgBIAEoDCI9CiJHZW5l",
                  "cmF0ZUZpcm13YXJlRG93bmxvYWRVcmlSZXF1ZXN0EhcKD2VsZWN0cm9uaWNf",
                  "bG9jaxgBIAEoCSJLCiNHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlSZXNw",
                  "b25zZRIUCgxkb3dubG9hZF91cmkYASABKAkSDgoGZGlnZXN0GAIgASgJIiUK",
                  "I0dlbmVyYXRlRmlybXdhcmVEb3dubG9hZFVyaU1ldGFkYXRhMuINChVFbGVj",
                  "dHJvbmljTG9ja1NlcnZpY2USgwEKFENyZWF0ZUVsZWN0cm9uaWNMb2NrEjsu",
                  "c2FsdG8ubmVidWxhLmVsZWN0cm9uaWNsb2NrLnYxLkNyZWF0ZUVsZWN0cm9u",
                  "aWNMb2NrUmVxdWVzdBouLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmljbG9jay52",
                  "MS5FbGVjdHJvbmljTG9jaxJ9ChFHZXRFbGVjdHJvbmljTG9jaxI4LnNhbHRv",
                  "Lm5lYnVsYS5lbGVjdHJvbmljbG9jay52MS5HZXRFbGVjdHJvbmljTG9ja1Jl",
                  "cXVlc3QaLi5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2sudjEuRWxlY3Ry",
                  "b25pY0xvY2sSjgEKE0xpc3RFbGVjdHJvbmljTG9ja3MSOi5zYWx0by5uZWJ1",
                  "bGEuZWxlY3Ryb25pY2xvY2sudjEuTGlzdEVsZWN0cm9uaWNMb2Nrc1JlcXVl",
                  "c3QaOy5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2sudjEuTGlzdEVsZWN0",
                  "cm9uaWNMb2Nrc1Jlc3BvbnNlEoMBChRVcGRhdGVFbGVjdHJvbmljTG9jaxI7",
                  "LnNhbHRvLm5lYnVsYS5lbGVjdHJvbmljbG9jay52MS5VcGRhdGVFbGVjdHJv",
                  "bmljTG9ja1JlcXVlc3QaLi5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2su",
                  "djEuRWxlY3Ryb25pY0xvY2sSawoURGVsZXRlRWxlY3Ryb25pY0xvY2sSOy5z",
                  "YWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2sudjEuRGVsZXRlRWxlY3Ryb25p",
                  "Y0xvY2tSZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5EosBChJCaW5k",
                  "RWxlY3Ryb25pY0xvY2sSOS5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2su",
                  "djEuQmluZEVsZWN0cm9uaWNMb2NrUmVxdWVzdBo6LnNhbHRvLm5lYnVsYS5l",
                  "bGVjdHJvbmljbG9jay52MS5CaW5kRWxlY3Ryb25pY0xvY2tSZXNwb25zZRKR",
                  "AQoUVW5iaW5kRWxlY3Ryb25pY0xvY2sSOy5zYWx0by5uZWJ1bGEuZWxlY3Ry",
                  "b25pY2xvY2sudjEuVW5iaW5kRWxlY3Ryb25pY0xvY2tSZXF1ZXN0Gjwuc2Fs",
                  "dG8ubmVidWxhLmVsZWN0cm9uaWNsb2NrLnYxLlVuYmluZEVsZWN0cm9uaWNM",
                  "b2NrUmVzcG9uc2USfAoYSW5pdGlhbGl6ZUVsZWN0cm9uaWNMb2NrEj8uc2Fs",
                  "dG8ubmVidWxhLmVsZWN0cm9uaWNsb2NrLnYxLkluaXRpYWxpemVFbGVjdHJv",
                  "bmljTG9ja1JlcXVlc3QaHy5zYWx0by5sb25ncnVubmluZy52MS5PcGVyYXRp",
                  "b24SegoXQ29uZmlndXJlRWxlY3Ryb25pY0xvY2sSPi5zYWx0by5uZWJ1bGEu",
                  "ZWxlY3Ryb25pY2xvY2sudjEuQ29uZmlndXJlRWxlY3Ryb25pY0xvY2tSZXF1",
                  "ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uEnIKE1Jlc2V0",
                  "RWxlY3Ryb25pY0xvY2sSOi5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2su",
                  "djEuUmVzZXRFbGVjdHJvbmljTG9ja1JlcXVlc3QaHy5zYWx0by5sb25ncnVu",
                  "bmluZy52MS5PcGVyYXRpb24ShAEKHFVwZGF0ZUVsZWN0cm9uaWNMb2NrRmly",
                  "bXdhcmUSQy5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2xvY2sudjEuVXBkYXRl",
                  "RWxlY3Ryb25pY0xvY2tGaXJtd2FyZVJlcXVlc3QaHy5zYWx0by5sb25ncnVu",
                  "bmluZy52MS5PcGVyYXRpb24SowEKGkdlbmVyYXRlQXV0aG9yaXphdGlvblRv",
                  "a2VuEkEuc2FsdG8ubmVidWxhLmVsZWN0cm9uaWNsb2NrLnYxLkdlbmVyYXRl",
                  "QXV0aG9yaXphdGlvblRva2VuUmVxdWVzdBpCLnNhbHRvLm5lYnVsYS5lbGVj",
                  "dHJvbmljbG9jay52MS5HZW5lcmF0ZUF1dGhvcml6YXRpb25Ub2tlblJlc3Bv",
                  "bnNlEoIBChtHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmkSQi5zYWx0by5u",
                  "ZWJ1bGEuZWxlY3Ryb25pY2xvY2sudjEuR2VuZXJhdGVGaXJtd2FyZURvd25s",
                  "b2FkVXJpUmVxdWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9wZXJhdGlv",
                  "bkKOAgomY29tLnNhbHRvYXBpcy5uZWJ1bGEuZWxlY3Ryb25pY2xvY2sudjFC",
                  "E0VsZWN0cm9uaWNMb2NrUHJvdG9QAVpSZ2l0aHViLmNvbS9zYWx0b2FwaXMt",
                  "aW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS9lbGVjdHJvbmljbG9jay92",
                  "MTtlbGVjdHJvbmljbG9ja6oCIlNhbHRvYXBpcy5OZWJ1bGEuRWxlY3Ryb25p",
                  "Y0xvY2suVjHKAiJTYWx0b2FwaXNcTmVidWxhXEVsZWN0cm9uaWNMb2NrXFYx",
                  "4gIuR1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxFbGVjdHJvbmljTG9j",
                  "a1xWMWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.DeviceMetadataReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(ElectronicLock), ElectronicLock.Parser, ["Name", "DisplayName", "DeviceId", "Gateway", "Extender", "AccessPoint", "Initialized", "DeviceMetadata", "Outdated", "Connected", "LowBattery", "LastEventTime", "CalibrationSettings", "ForceRotateCarriageEnd", "HoldBackLatchDuration"], ["ParentDevice", "DeviceId", "Connected", "CalibrationSettings", "ForceRotateCarriageEnd", "HoldBackLatchDuration"], null, null, null),
            new(typeof(CreateElectronicLockRequest), CreateElectronicLockRequest.Parser, ["Parent", "ElectronicLockId", "ElectronicLock"], ["ElectronicLockId"], null, null, null),
            new(typeof(GetElectronicLockRequest), GetElectronicLockRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListElectronicLocksRequest), ListElectronicLocksRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListElectronicLocksResponse), ListElectronicLocksResponse.Parser, ["ElectronicLocks", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateElectronicLockRequest), UpdateElectronicLockRequest.Parser, ["ElectronicLock", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteElectronicLockRequest), DeleteElectronicLockRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindElectronicLockRequest), BindElectronicLockRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindElectronicLockResponse), BindElectronicLockResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindElectronicLockRequest), UnbindElectronicLockRequest.Parser, ["Name", "Force"], null, null, null, null),
            new(typeof(UnbindElectronicLockResponse), UnbindElectronicLockResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeElectronicLockRequest), InitializeElectronicLockRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(InitializeElectronicLockResponse), InitializeElectronicLockResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeElectronicLockMetadata), InitializeElectronicLockMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(ConfigureElectronicLockRequest), ConfigureElectronicLockRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ConfigureElectronicLockResponse), ConfigureElectronicLockResponse.Parser, null, null, null, null, null),
            new(typeof(ConfigureElectronicLockMetadata), ConfigureElectronicLockMetadata.Parser, null, null, null, null, null),
            new(typeof(ResetElectronicLockRequest), ResetElectronicLockRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetElectronicLockResponse), ResetElectronicLockResponse.Parser, null, null, null, null, null),
            new(typeof(ResetElectronicLockMetadata), ResetElectronicLockMetadata.Parser, null, null, null, null, null),
            new(typeof(UpdateElectronicLockFirmwareRequest), UpdateElectronicLockFirmwareRequest.Parser, ["ElectronicLock"], null, null, null, null),
            new(typeof(UpdateElectronicLockFirmwareResponse), UpdateElectronicLockFirmwareResponse.Parser, null, null, null, null, null),
            new(typeof(UpdateElectronicLockFirmwareMetadata), UpdateElectronicLockFirmwareMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["ElectronicLock"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["ElectronicLock"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The electronic lock object
    /// </summary>
    public sealed partial class ElectronicLock : IMessage<ElectronicLock>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicLock> _parser = new(() => new ElectronicLock());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<ElectronicLock> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ElectronicLock()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicLock(ElectronicLock other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            accessPoint_ = other.accessPoint_;
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            outdated_ = other.outdated_;
            connected_ = other.connected_;
            lowBattery_ = other.lowBattery_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            calibrationSettings_ = other.calibrationSettings_;
            forceRotateCarriageEnd_ = other.forceRotateCarriageEnd_;
            holdBackLatchDuration_ = other.holdBackLatchDuration_?.Clone();
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender:
                    Extender = other.Extender;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ElectronicLock Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the electronic lock. It must have the format of
        /// `installations/*/electronic-locks/*`. For example:
        /// `installations/surelock-homes-hq/electronic-locks/dancing-men`.
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
        /// Display name of the electronic lock.
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
        /// by SALTO, including gateways, extenders, electronic locks and so on.
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

        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 4;

        /// <summary>
        /// Parent name, when electronic lock is connected to a gateway
        /// </summary>
        public string Gateway
        {
            get { return HasGateway ? (string)parentDevice_ : ""; }
            set
            {
                parentDevice_ = ProtoPreconditions.CheckNotNull(value, "value");
                parentDeviceCase_ = ParentDeviceOneofCase.Gateway;
            }
        }

        /// <summary>Gets whether the "gateway" field is set</summary>
        public bool HasGateway
        {
            get { return parentDeviceCase_ == ParentDeviceOneofCase.Gateway; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "gateway" </summary>
        public void ClearGateway()
        {
            if (HasGateway)
            {
                ClearParentDevice();
            }
        }

        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 5;

        /// <summary>
        /// Parent name, when electronic lock is connected to an extender
        /// </summary>
        public string Extender
        {
            get { return HasExtender ? (string)parentDevice_ : ""; }
            set
            {
                parentDevice_ = ProtoPreconditions.CheckNotNull(value, "value");
                parentDeviceCase_ = ParentDeviceOneofCase.Extender;
            }
        }

        /// <summary>Gets whether the "extender" field is set</summary>
        public bool HasExtender
        {
            get { return parentDeviceCase_ == ParentDeviceOneofCase.Extender; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "extender" </summary>
        public void ClearExtender()
        {
            if (HasExtender)
            {
                ClearParentDevice();
            }
        }

        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 6;
        private string accessPoint_ = "";

        /// <summary>
        /// The access point that the electronic lock gives coverage to.
        /// </summary>
        public string AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 7;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this electronic lock has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.UpdateElectronicLock]
        /// operation. To change the value of this field, you must call
        /// [`InitializeElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.InitializeElectronicLock].
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
        public const int DeviceMetadataFieldNumber = 15;
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

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 8;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this electronic lock has pending updates or not. This
        /// could be because there was a pending configuration or a firmware update
        /// and is conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 9;
        private readonly static bool ConnectedDefaultValue = false;

        private bool connected_;

        /// <summary>
        /// Indicates whether this electronic lock is connected or not. It's
        /// considered connected if there has been at least one communication with it
        /// within the last 10 minutes. The property is left unset if it is an
        /// offline electronic lock.
        /// </summary>
        public bool Connected
        {
            get { if ((_hasBits0 & 1) != 0) { return connected_; } else { return ConnectedDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                connected_ = value;
            }
        }

        /// <summary>Gets whether the "connected" field is set</summary>
        public bool HasConnected
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "connected" field</summary>
        public void ClearConnected()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "low_battery" field.</summary>
        public const int LowBatteryFieldNumber = 10;
        private bool lowBattery_;

        /// <summary>
        /// Indicates whether the battery of this electronic lock is low, and needs
        /// replacing, or is normal and doesn't need replacing.
        /// </summary>
        public bool LowBattery
        {
            get { return lowBattery_; }
            set
            {
                lowBattery_ = value;
            }
        }

        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 11;
        private Google.Protobuf.WellKnownTypes.Timestamp lastEventTime_;

        /// <summary>
        /// The last time an event was received.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp LastEventTime
        {
            get { return lastEventTime_; }
            set
            {
                lastEventTime_ = value;
            }
        }

        /// <summary>Field number for the "calibration_settings" field.</summary>
        public const int CalibrationSettingsFieldNumber = 12;
        private readonly static ByteString CalibrationSettingsDefaultValue = ByteString.Empty;

        private ByteString calibrationSettings_;

        /// <summary>
        /// Calibration settings of an electronic lock. This only applies to
        /// electronic locks that must be calibrated once mounted to adapt to the
        /// door's specific characteristics. For example, certain motorized
        /// electronic locks need to be calibrated so they can learn the different
        /// positions of a door.
        /// </summary>
        public ByteString CalibrationSettings
        {
            get { return calibrationSettings_ ?? CalibrationSettingsDefaultValue; }
            set
            {
                calibrationSettings_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "calibration_settings" field is set</summary>
        public bool HasCalibrationSettings
        {
            get { return calibrationSettings_ != null; }
        }

        /// <summary>Clears the value of the "calibration_settings" field</summary>
        public void ClearCalibrationSettings()
        {
            calibrationSettings_ = null;
        }

        /// <summary>Field number for the "force_rotate_carriage_end" field.</summary>
        public const int ForceRotateCarriageEndFieldNumber = 13;
        private readonly static bool ForceRotateCarriageEndDefaultValue = false;

        private bool forceRotateCarriageEnd_;

        /// <summary>
        /// Indicates whether the electronic lock operates by turning in one
        /// direction until it reaches the carriage end, or not.
        /// For example, this could apply to electronic locks that are unaware of the
        /// carriage's endpoint or those that can lose their position, as seen in
        /// double clutch cylinders.
        /// </summary>
        public bool ForceRotateCarriageEnd
        {
            get { if ((_hasBits0 & 2) != 0) { return forceRotateCarriageEnd_; } else { return ForceRotateCarriageEndDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                forceRotateCarriageEnd_ = value;
            }
        }

        /// <summary>Gets whether the "force_rotate_carriage_end" field is set</summary>
        public bool HasForceRotateCarriageEnd
        {
            get { return (_hasBits0 & 2) != 0; }
        }

        /// <summary>Clears the value of the "force_rotate_carriage_end" field</summary>
        public void ClearForceRotateCarriageEnd()
        {
            _hasBits0 &= ~2;
        }

        /// <summary>Field number for the "hold_back_latch_duration" field.</summary>
        public const int HoldBackLatchDurationFieldNumber = 14;
        private Google.Protobuf.WellKnownTypes.Duration holdBackLatchDuration_;

        /// <summary>
        /// If applicable, the duration the motorized lock's hold-back latch remains
        /// engaged before the latch closes.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Duration HoldBackLatchDuration
        {
            get { return holdBackLatchDuration_; }
            set
            {
                holdBackLatchDuration_ = value;
            }
        }

        private object parentDevice_;

        /// <summary>Enum of possible cases for the "parent_device" oneof.</summary>
        public enum ParentDeviceOneofCase
        {
            None = 0,
            Gateway = 4,
            Extender = 5,
        }

        private ParentDeviceOneofCase parentDeviceCase_ = ParentDeviceOneofCase.None;

        public ParentDeviceOneofCase ParentDeviceCase
        {
            get { return parentDeviceCase_; }
        }

        public void ClearParentDevice()
        {
            parentDeviceCase_ = ParentDeviceOneofCase.None;
            parentDevice_ = null;
        }

        public override bool Equals(object other) => Equals(other as ElectronicLock);
        public bool Equals(ElectronicLock other)
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
            if (Gateway != other.Gateway) return false;
            if (Extender != other.Extender) return false;
            if (AccessPoint != other.AccessPoint) return false;
            if (Initialized != other.Initialized) return false;
            if (!Equals(DeviceMetadata, other.DeviceMetadata)) return false;
            if (Outdated != other.Outdated) return false;
            if (Connected != other.Connected) return false;
            if (LowBattery != other.LowBattery) return false;
            if (!Equals(LastEventTime, other.LastEventTime)) return false;
            if (CalibrationSettings != other.CalibrationSettings) return false;
            if (ForceRotateCarriageEnd != other.ForceRotateCarriageEnd) return false;
            if (!Equals(HoldBackLatchDuration, other.HoldBackLatchDuration)) return false;
            if (ParentDeviceCase != other.ParentDeviceCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (HasGateway) hash ^= Gateway.GetHashCode();
            if (HasExtender) hash ^= Extender.GetHashCode();
            if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (HasConnected) hash ^= Connected.GetHashCode();
            if (LowBattery != false) hash ^= LowBattery.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (HasCalibrationSettings) hash ^= CalibrationSettings.GetHashCode();
            if (HasForceRotateCarriageEnd) hash ^= ForceRotateCarriageEnd.GetHashCode();
            if (holdBackLatchDuration_ != null) hash ^= HoldBackLatchDuration.GetHashCode();
            hash ^= (int)parentDeviceCase_;
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
      if (HasGateway) {
        output.WriteRawTag(34);
        output.WriteString(Gateway);
      }
      if (HasExtender) {
        output.WriteRawTag(42);
        output.WriteString(Extender);
      }
      if (AccessPoint.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AccessPoint);
      }
      if (Initialized != false) {
        output.WriteRawTag(56);
        output.WriteBool(Initialized);
      }
      if (Outdated != false) {
        output.WriteRawTag(64);
        output.WriteBool(Outdated);
      }
      if (HasConnected) {
        output.WriteRawTag(72);
        output.WriteBool(Connected);
      }
      if (LowBattery != false) {
        output.WriteRawTag(80);
        output.WriteBool(LowBattery);
      }
      if (lastEventTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(LastEventTime);
      }
      if (HasCalibrationSettings) {
        output.WriteRawTag(98);
        output.WriteBytes(CalibrationSettings);
      }
      if (HasForceRotateCarriageEnd) {
        output.WriteRawTag(104);
        output.WriteBool(ForceRotateCarriageEnd);
      }
      if (holdBackLatchDuration_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(HoldBackLatchDuration);
      }
      if (deviceMetadata_ != null) {
        output.WriteRawTag(122);
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
            if (HasGateway)
            {
                output.WriteRawTag(34);
                output.WriteString(Gateway);
            }
            if (HasExtender)
            {
                output.WriteRawTag(42);
                output.WriteString(Extender);
            }
            if (AccessPoint.Length != 0)
            {
                output.WriteRawTag(50);
                output.WriteString(AccessPoint);
            }
            if (Initialized != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(Initialized);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(64);
                output.WriteBool(Outdated);
            }
            if (HasConnected)
            {
                output.WriteRawTag(72);
                output.WriteBool(Connected);
            }
            if (LowBattery != false)
            {
                output.WriteRawTag(80);
                output.WriteBool(LowBattery);
            }
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(LastEventTime);
            }
            if (HasCalibrationSettings)
            {
                output.WriteRawTag(98);
                output.WriteBytes(CalibrationSettings);
            }
            if (HasForceRotateCarriageEnd)
            {
                output.WriteRawTag(104);
                output.WriteBool(ForceRotateCarriageEnd);
            }
            if (holdBackLatchDuration_ != null)
            {
                output.WriteRawTag(114);
                output.WriteMessage(HoldBackLatchDuration);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(122);
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
            if (HasGateway)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            }
            if (HasExtender)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Extender);
            }
            if (AccessPoint.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessPoint);
            }
            if (Initialized != false)
            {
                size += 1 + 1;
            }
            if (deviceMetadata_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (HasConnected)
            {
                size += 1 + 1;
            }
            if (LowBattery != false)
            {
                size += 1 + 1;
            }
            if (lastEventTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            }
            if (HasCalibrationSettings)
            {
                size += 1 + CodedOutputStream.ComputeBytesSize(CalibrationSettings);
            }
            if (HasForceRotateCarriageEnd)
            {
                size += 1 + 1;
            }
            if (holdBackLatchDuration_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(HoldBackLatchDuration);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ElectronicLock other)
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
            if (other.AccessPoint.Length != 0)
            {
                AccessPoint = other.AccessPoint;
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
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
            }
            if (other.HasConnected)
            {
                Connected = other.Connected;
            }
            if (other.LowBattery != false)
            {
                LowBattery = other.LowBattery;
            }
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null)
                {
                    LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.HasCalibrationSettings)
            {
                CalibrationSettings = other.CalibrationSettings;
            }
            if (other.HasForceRotateCarriageEnd)
            {
                ForceRotateCarriageEnd = other.ForceRotateCarriageEnd;
            }
            if (other.holdBackLatchDuration_ != null)
            {
                if (holdBackLatchDuration_ == null)
                {
                    HoldBackLatchDuration = new Google.Protobuf.WellKnownTypes.Duration();
                }
                HoldBackLatchDuration.MergeFrom(other.HoldBackLatchDuration);
            }
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender:
                    Extender = other.Extender;
                    break;
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
          case 34: {
            Gateway = input.ReadString();
            break;
          }
          case 42: {
            Extender = input.ReadString();
            break;
          }
          case 50: {
            AccessPoint = input.ReadString();
            break;
          }
          case 56: {
            Initialized = input.ReadBool();
            break;
          }
          case 64: {
            Outdated = input.ReadBool();
            break;
          }
          case 72: {
            Connected = input.ReadBool();
            break;
          }
          case 80: {
            LowBattery = input.ReadBool();
            break;
          }
          case 90: {
            if (lastEventTime_ == null) {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 98: {
            CalibrationSettings = input.ReadBytes();
            break;
          }
          case 104: {
            ForceRotateCarriageEnd = input.ReadBool();
            break;
          }
          case 114: {
            if (holdBackLatchDuration_ == null) {
              HoldBackLatchDuration = new Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(HoldBackLatchDuration);
            break;
          }
          case 122: {
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
                    case 34:
                        {
                            Gateway = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            Extender = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            AccessPoint = input.ReadString();
                            break;
                        }
                    case 56:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 64:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                    case 72:
                        {
                            Connected = input.ReadBool();
                            break;
                        }
                    case 80:
                        {
                            LowBattery = input.ReadBool();
                            break;
                        }
                    case 90:
                        {
                            if (lastEventTime_ == null)
                            {
                                LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(LastEventTime);
                            break;
                        }
                    case 98:
                        {
                            CalibrationSettings = input.ReadBytes();
                            break;
                        }
                    case 104:
                        {
                            ForceRotateCarriageEnd = input.ReadBool();
                            break;
                        }
                    case 114:
                        {
                            if (holdBackLatchDuration_ == null)
                            {
                                HoldBackLatchDuration = new Google.Protobuf.WellKnownTypes.Duration();
                            }
                            input.ReadMessage(HoldBackLatchDuration);
                            break;
                        }
                    case 122:
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
    /// The request message for [CreateElectronicLock][salto.nebula.electroniclock.v1.ElectronicLockService.CreateElectronicLock]
    /// </summary>
    public sealed partial class CreateElectronicLockRequest : IMessage<CreateElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateElectronicLockRequest> _parser = new(() => new CreateElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateElectronicLockRequest(CreateElectronicLockRequest other) : this()
        {
            parent_ = other.parent_;
            electronicLockId_ = other.electronicLockId_;
            electronicLock_ = other.electronicLock_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the electronic lock. For
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

        /// <summary>Field number for the "electronic_lock_id" field.</summary>
        public const int ElectronicLockIdFieldNumber = 2;
        private readonly static string ElectronicLockIdDefaultValue = "";

        private string electronicLockId_;

        /// <summary>
        /// The electronic lock ID to use for this electronic lock. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ElectronicLockId
        {
            get { return electronicLockId_ ?? ElectronicLockIdDefaultValue; }
            set
            {
                electronicLockId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "electronic_lock_id" field is set</summary>
        public bool HasElectronicLockId
        {
            get { return electronicLockId_ != null; }
        }

        /// <summary>Clears the value of the "electronic_lock_id" field</summary>
        public void ClearElectronicLockId()
        {
            electronicLockId_ = null;
        }

        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 3;
        private ElectronicLock electronicLock_;

        /// <summary>
        /// The electronic lock resource to be created. Client must not set the
        /// `ElectronicLock.name` field.
        /// </summary>
        public ElectronicLock ElectronicLock
        {
            get { return electronicLock_; }
            set
            {
                electronicLock_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateElectronicLockRequest);
        public bool Equals(CreateElectronicLockRequest other)
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
            if (ElectronicLockId != other.ElectronicLockId) return false;
            if (!Equals(ElectronicLock, other.ElectronicLock)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasElectronicLockId) hash ^= ElectronicLockId.GetHashCode();
            if (electronicLock_ != null) hash ^= ElectronicLock.GetHashCode();
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
      if (HasElectronicLockId) {
        output.WriteRawTag(18);
        output.WriteString(ElectronicLockId);
      }
      if (electronicLock_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ElectronicLock);
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
            if (HasElectronicLockId)
            {
                output.WriteRawTag(18);
                output.WriteString(ElectronicLockId);
            }
            if (electronicLock_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(ElectronicLock);
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
            if (HasElectronicLockId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLockId);
            }
            if (electronicLock_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicLock);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateElectronicLockRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasElectronicLockId)
            {
                ElectronicLockId = other.ElectronicLockId;
            }
            if (other.electronicLock_ != null)
            {
                if (electronicLock_ == null)
                {
                    ElectronicLock = new ElectronicLock();
                }
                ElectronicLock.MergeFrom(other.ElectronicLock);
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
            ElectronicLockId = input.ReadString();
            break;
          }
          case 26: {
            if (electronicLock_ == null) {
              ElectronicLock = new Saltoapis.Nebula.ElectronicLock.V1.ElectronicLock();
            }
            input.ReadMessage(ElectronicLock);
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
                            ElectronicLockId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (electronicLock_ == null)
                            {
                                ElectronicLock = new ElectronicLock();
                            }
                            input.ReadMessage(ElectronicLock);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetElectronicLock][salto.nebula.electroniclock.v1.ElectronicLockService.GetElectronicLock]
    /// </summary>
    public sealed partial class GetElectronicLockRequest : IMessage<GetElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetElectronicLockRequest> _parser = new(() => new GetElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetElectronicLockRequest(GetElectronicLockRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested electronic lock resource. For example:
        /// `installations/surelock-homes-hq/electronic-locks/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetElectronicLockRequest);
        public bool Equals(GetElectronicLockRequest other)
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

        public void MergeFrom(GetElectronicLockRequest other)
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
    /// The request message for [ListElectronicLocks][salto.nebula.electroniclock.v1.ElectronicLockService.ListElectronicLock]
    /// </summary>
    public sealed partial class ListElectronicLocksRequest : IMessage<ListElectronicLocksRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListElectronicLocksRequest> _parser = new(() => new ListElectronicLocksRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListElectronicLocksRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListElectronicLocksRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListElectronicLocksRequest(ListElectronicLocksRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListElectronicLocksRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example, `installations/surelock-homes-hq`.
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
        /// A filter that chooses which electronic locks to return.
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

        public override bool Equals(object other) => Equals(other as ListElectronicLocksRequest);
        public bool Equals(ListElectronicLocksRequest other)
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

        public void MergeFrom(ListElectronicLocksRequest other)
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
    /// The response message for [ListElectronicLocks][salto.nebula.electroniclock.v1.ElectronicLockService.ListElectronicLocks]
    /// </summary>
    public sealed partial class ListElectronicLocksResponse : IMessage<ListElectronicLocksResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListElectronicLocksResponse> _parser = new(() => new ListElectronicLocksResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListElectronicLocksResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListElectronicLocksResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListElectronicLocksResponse(ListElectronicLocksResponse other) : this()
        {
            electronicLocks_ = other.electronicLocks_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListElectronicLocksResponse Clone() => new(this);
        /// <summary>Field number for the "electronic_locks" field.</summary>
        public const int ElectronicLocksFieldNumber = 1;
        private static readonly FieldCodec<ElectronicLock> _repeated_electronicLocks_codec
            = FieldCodec.ForMessage(10, ElectronicLock.Parser);
        private readonly RepeatedField<ElectronicLock> electronicLocks_ = [];

        /// <summary>
        /// The field name should match the noun `electronic_locks` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<ElectronicLock> ElectronicLocks
        {
            get { return electronicLocks_; }
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

        public override bool Equals(object other) => Equals(other as ListElectronicLocksResponse);
        public bool Equals(ListElectronicLocksResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!electronicLocks_.Equals(other.electronicLocks_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= electronicLocks_.GetHashCode();
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
      electronicLocks_.WriteTo(output, _repeated_electronicLocks_codec);
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
            electronicLocks_.WriteTo(ref output, _repeated_electronicLocks_codec);
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
            size += electronicLocks_.CalculateSize(_repeated_electronicLocks_codec);
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

        public void MergeFrom(ListElectronicLocksResponse other)
        {
            if (other == null)
            {
                return;
            }
            electronicLocks_.Add(other.electronicLocks_);
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
            electronicLocks_.AddEntriesFrom(input, _repeated_electronicLocks_codec);
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
                            electronicLocks_.AddEntriesFrom(ref input, _repeated_electronicLocks_codec);
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
    /// The request message for [UpdateElectronicLock][salto.nebula.electroniclock.v1.ElectronicLockService.UpdateElectronicLock]
    /// </summary>
    public sealed partial class UpdateElectronicLockRequest : IMessage<UpdateElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateElectronicLockRequest> _parser = new(() => new UpdateElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateElectronicLockRequest(UpdateElectronicLockRequest other) : this()
        {
            electronicLock_ = other.electronicLock_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 1;
        private ElectronicLock electronicLock_;

        /// <summary>
        /// The electronic lock resource which replaces the resource on the server.
        /// </summary>
        public ElectronicLock ElectronicLock
        {
            get { return electronicLock_; }
            set
            {
                electronicLock_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateElectronicLockRequest);
        public bool Equals(UpdateElectronicLockRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(ElectronicLock, other.ElectronicLock)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (electronicLock_ != null) hash ^= ElectronicLock.GetHashCode();
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
      if (electronicLock_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ElectronicLock);
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
            if (electronicLock_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ElectronicLock);
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
            if (electronicLock_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicLock);
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

        public void MergeFrom(UpdateElectronicLockRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.electronicLock_ != null)
            {
                if (electronicLock_ == null)
                {
                    ElectronicLock = new ElectronicLock();
                }
                ElectronicLock.MergeFrom(other.ElectronicLock);
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
            if (electronicLock_ == null) {
              ElectronicLock = new Saltoapis.Nebula.ElectronicLock.V1.ElectronicLock();
            }
            input.ReadMessage(ElectronicLock);
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
                            if (electronicLock_ == null)
                            {
                                ElectronicLock = new ElectronicLock();
                            }
                            input.ReadMessage(ElectronicLock);
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
    /// The request message for [DeleteElectronicLock][salto.nebula.electroniclock.v1.ElectronicLockService.DeleteElectronicLock]
    /// </summary>
    public sealed partial class DeleteElectronicLockRequest : IMessage<DeleteElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteElectronicLockRequest> _parser = new(() => new DeleteElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteElectronicLockRequest(DeleteElectronicLockRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic lock to be deleted. For example:
        /// `installations/surelock-homes-hq/electronic-locks/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteElectronicLockRequest);
        public bool Equals(DeleteElectronicLockRequest other)
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

        public void MergeFrom(DeleteElectronicLockRequest other)
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
    /// The request message for [`BindElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.BindElectronicLock]
    /// </summary>
    public sealed partial class BindElectronicLockRequest : IMessage<BindElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindElectronicLockRequest> _parser = new(() => new BindElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindElectronicLockRequest(BindElectronicLockRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic lock to be bound. For example:
        /// `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
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

        public override bool Equals(object other) => Equals(other as BindElectronicLockRequest);
        public bool Equals(BindElectronicLockRequest other)
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

        public void MergeFrom(BindElectronicLockRequest other)
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
    /// The empty response message for [`BindElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.BindElectronicLock]
    /// </summary>
    public sealed partial class BindElectronicLockResponse : IMessage<BindElectronicLockResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindElectronicLockResponse> _parser = new(() => new BindElectronicLockResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindElectronicLockResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindElectronicLockResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindElectronicLockResponse(BindElectronicLockResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindElectronicLockResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BindElectronicLockResponse);
        public bool Equals(BindElectronicLockResponse other)
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

        public void MergeFrom(BindElectronicLockResponse other)
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
    /// The request message for [`UnbindElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.UnbindElectronicLock]
    /// </summary>
    public sealed partial class UnbindElectronicLockRequest : IMessage<UnbindElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindElectronicLockRequest> _parser = new(() => new UnbindElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindElectronicLockRequest(UnbindElectronicLockRequest other) : this()
        {
            name_ = other.name_;
            force_ = other.force_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic lock to be bound. For example:
        /// `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
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
        /// electronic lock. Otherwise, the request will only work if the electronic
        /// lock isn't bound to any previous device identifier.
        /// </summary>
        public bool Force
        {
            get { return force_; }
            set
            {
                force_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnbindElectronicLockRequest);
        public bool Equals(UnbindElectronicLockRequest other)
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

        public void MergeFrom(UnbindElectronicLockRequest other)
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
    /// The empty response message for [`UnbindElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.UnbindElectronicLock]
    /// </summary>
    public sealed partial class UnbindElectronicLockResponse : IMessage<UnbindElectronicLockResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindElectronicLockResponse> _parser = new(() => new UnbindElectronicLockResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindElectronicLockResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindElectronicLockResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindElectronicLockResponse(UnbindElectronicLockResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindElectronicLockResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnbindElectronicLockResponse);
        public bool Equals(UnbindElectronicLockResponse other)
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

        public void MergeFrom(UnbindElectronicLockResponse other)
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
    /// The request message for [`InitializeElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.InitializeElectronicLock]
    /// </summary>
    public sealed partial class InitializeElectronicLockRequest : IMessage<InitializeElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeElectronicLockRequest> _parser = new(() => new InitializeElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeElectronicLockRequest(InitializeElectronicLockRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic lock to be initialized. For example:
        /// `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as InitializeElectronicLockRequest);
        public bool Equals(InitializeElectronicLockRequest other)
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

        public void MergeFrom(InitializeElectronicLockRequest other)
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
    /// The empty response message for [`InitializeElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.InitializeElectronicLock]
    /// </summary>
    public sealed partial class InitializeElectronicLockResponse : IMessage<InitializeElectronicLockResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeElectronicLockResponse> _parser = new(() => new InitializeElectronicLockResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeElectronicLockResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeElectronicLockResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeElectronicLockResponse(InitializeElectronicLockResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeElectronicLockResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeElectronicLockResponse);
        public bool Equals(InitializeElectronicLockResponse other)
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

        public void MergeFrom(InitializeElectronicLockResponse other)
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

    public sealed partial class InitializeElectronicLockMetadata : IMessage<InitializeElectronicLockMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeElectronicLockMetadata> _parser = new(() => new InitializeElectronicLockMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeElectronicLockMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeElectronicLockMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeElectronicLockMetadata(InitializeElectronicLockMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeElectronicLockMetadata Clone() => new(this);
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

        public override bool Equals(object other) => Equals(other as InitializeElectronicLockMetadata);
        public bool Equals(InitializeElectronicLockMetadata other)
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

        public void MergeFrom(InitializeElectronicLockMetadata other)
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
    /// The request message for [`ConfigureElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.ConfigureElectronicLock]
    /// </summary>
    public sealed partial class ConfigureElectronicLockRequest : IMessage<ConfigureElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureElectronicLockRequest> _parser = new(() => new ConfigureElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureElectronicLockRequest(ConfigureElectronicLockRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic lock to be configured. For example:
        /// `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ConfigureElectronicLockRequest);
        public bool Equals(ConfigureElectronicLockRequest other)
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

        public void MergeFrom(ConfigureElectronicLockRequest other)
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
    /// The empty response message for [`ConfigureElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.ConfigureElectronicLock]
    /// </summary>
    public sealed partial class ConfigureElectronicLockResponse : IMessage<ConfigureElectronicLockResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureElectronicLockResponse> _parser = new(() => new ConfigureElectronicLockResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureElectronicLockResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureElectronicLockResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureElectronicLockResponse(ConfigureElectronicLockResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureElectronicLockResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureElectronicLockResponse);
        public bool Equals(ConfigureElectronicLockResponse other)
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

        public void MergeFrom(ConfigureElectronicLockResponse other)
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
    /// The metadata message for [`ConfigureElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.ConfigureElectronicLock]
    /// </summary>
    public sealed partial class ConfigureElectronicLockMetadata : IMessage<ConfigureElectronicLockMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureElectronicLockMetadata> _parser = new(() => new ConfigureElectronicLockMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureElectronicLockMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureElectronicLockMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureElectronicLockMetadata(ConfigureElectronicLockMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureElectronicLockMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureElectronicLockMetadata);
        public bool Equals(ConfigureElectronicLockMetadata other)
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

        public void MergeFrom(ConfigureElectronicLockMetadata other)
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
    /// The request message for [`ResetElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.ResetElectronicLock]
    /// </summary>
    public sealed partial class ResetElectronicLockRequest : IMessage<ResetElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetElectronicLockRequest> _parser = new(() => new ResetElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetElectronicLockRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetElectronicLockRequest(ResetElectronicLockRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic lock to be reset. For example:
        /// `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ResetElectronicLockRequest);
        public bool Equals(ResetElectronicLockRequest other)
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

        public void MergeFrom(ResetElectronicLockRequest other)
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
    /// The empty response message for [`ResetElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.ResetElectronicLock]
    /// </summary>
    public sealed partial class ResetElectronicLockResponse : IMessage<ResetElectronicLockResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetElectronicLockResponse> _parser = new(() => new ResetElectronicLockResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetElectronicLockResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetElectronicLockResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetElectronicLockResponse(ResetElectronicLockResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetElectronicLockResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetElectronicLockResponse);
        public bool Equals(ResetElectronicLockResponse other)
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

        public void MergeFrom(ResetElectronicLockResponse other)
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
    /// The metadata message for [`ResetElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.ResetElectronicLock]
    /// </summary>
    public sealed partial class ResetElectronicLockMetadata : IMessage<ResetElectronicLockMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetElectronicLockMetadata> _parser = new(() => new ResetElectronicLockMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetElectronicLockMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetElectronicLockMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetElectronicLockMetadata(ResetElectronicLockMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetElectronicLockMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetElectronicLockMetadata);
        public bool Equals(ResetElectronicLockMetadata other)
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

        public void MergeFrom(ResetElectronicLockMetadata other)
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
    /// The request message for [`UpdateElectronicLockFirmware`][salto.nebula.electroniclock.v1.ElectronicLockService.UpdateElectronicLockFirmware]
    /// </summary>
    public sealed partial class UpdateElectronicLockFirmwareRequest : IMessage<UpdateElectronicLockFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateElectronicLockFirmwareRequest> _parser = new(() => new UpdateElectronicLockFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateElectronicLockFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateElectronicLockFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateElectronicLockFirmwareRequest(UpdateElectronicLockFirmwareRequest other) : this()
        {
            electronicLock_ = other.electronicLock_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateElectronicLockFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 1;
        private string electronicLock_ = "";

        /// <summary>
        /// The resource name of the electronic lock whose firmware will be updated. For
        /// example:
        /// `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
        /// </summary>
        public string ElectronicLock
        {
            get { return electronicLock_; }
            set
            {
                electronicLock_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateElectronicLockFirmwareRequest);
        public bool Equals(UpdateElectronicLockFirmwareRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ElectronicLock != other.ElectronicLock) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ElectronicLock.Length != 0) hash ^= ElectronicLock.GetHashCode();
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
      if (ElectronicLock.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ElectronicLock);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ElectronicLock.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(ElectronicLock);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ElectronicLock.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLock);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateElectronicLockFirmwareRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ElectronicLock.Length != 0)
            {
                ElectronicLock = other.ElectronicLock;
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
            ElectronicLock = input.ReadString();
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
                            ElectronicLock = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UpdateElectronicLockFirmware`][salto.nebula.electroniclock.v1.ElectronicLockService.UpdateElectronicLockFirmware]
    /// </summary>
    public sealed partial class UpdateElectronicLockFirmwareResponse : IMessage<UpdateElectronicLockFirmwareResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateElectronicLockFirmwareResponse> _parser = new(() => new UpdateElectronicLockFirmwareResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateElectronicLockFirmwareResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateElectronicLockFirmwareResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateElectronicLockFirmwareResponse(UpdateElectronicLockFirmwareResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateElectronicLockFirmwareResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UpdateElectronicLockFirmwareResponse);
        public bool Equals(UpdateElectronicLockFirmwareResponse other)
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

        public void MergeFrom(UpdateElectronicLockFirmwareResponse other)
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
    /// The metadata message for [`UpdateElectronicLockFirmware`][salto.nebula.electroniclock.v1.ElectronicLockService.UpdateElectronicLockFirmware]
    /// </summary>
    public sealed partial class UpdateElectronicLockFirmwareMetadata : IMessage<UpdateElectronicLockFirmwareMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateElectronicLockFirmwareMetadata> _parser = new(() => new UpdateElectronicLockFirmwareMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateElectronicLockFirmwareMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicLockReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateElectronicLockFirmwareMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateElectronicLockFirmwareMetadata(UpdateElectronicLockFirmwareMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateElectronicLockFirmwareMetadata Clone() => new(this);
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

        public override bool Equals(object other) => Equals(other as UpdateElectronicLockFirmwareMetadata);
        public bool Equals(UpdateElectronicLockFirmwareMetadata other)
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

        public void MergeFrom(UpdateElectronicLockFirmwareMetadata other)
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
    /// The request message for [`GenerateAuthorizationToken`][salto.nebula.electroniclock.v1.ElectronicLockService.GenerateAuthorizationToken]
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
            get { return ElectronicLockReflection.Descriptor.MessageTypes[23]; }
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
            electronicLock_ = other.electronicLock_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 1;
        private string electronicLock_ = "";

        /// <summary>
        /// The resource name of the electronic lock that the authorization token is
        /// generated for. For example:
        /// `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
        /// </summary>
        public string ElectronicLock
        {
            get { return electronicLock_; }
            set
            {
                electronicLock_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (ElectronicLock != other.ElectronicLock) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ElectronicLock.Length != 0) hash ^= ElectronicLock.GetHashCode();
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
      if (ElectronicLock.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ElectronicLock);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ElectronicLock.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(ElectronicLock);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ElectronicLock.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLock);
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
            if (other.ElectronicLock.Length != 0)
            {
                ElectronicLock = other.ElectronicLock;
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
            ElectronicLock = input.ReadString();
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
                            ElectronicLock = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateAuthorizationToken`][salto.nebula.electroniclock.v1.ElectronicLockService.GenerateAuthorizationToken]
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
            get { return ElectronicLockReflection.Descriptor.MessageTypes[24]; }
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
        /// Authorization token to be used for connecting to an electronic lock.
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
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.electroniclock.v1.ElectronicLockService.GenerateFirmwareDownloadUri]
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
            get { return ElectronicLockReflection.Descriptor.MessageTypes[25]; }
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
            electronicLock_ = other.electronicLock_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 1;
        private string electronicLock_ = "";

        /// <summary>
        /// The resource name of the electronic lock to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/electronic-locks/baker-street-entrance`.
        /// </summary>
        public string ElectronicLock
        {
            get { return electronicLock_; }
            set
            {
                electronicLock_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (ElectronicLock != other.ElectronicLock) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ElectronicLock.Length != 0) hash ^= ElectronicLock.GetHashCode();
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
      if (ElectronicLock.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ElectronicLock);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ElectronicLock.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(ElectronicLock);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ElectronicLock.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLock);
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
            if (other.ElectronicLock.Length != 0)
            {
                ElectronicLock = other.ElectronicLock;
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
            ElectronicLock = input.ReadString();
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
                            ElectronicLock = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateFirmwareDownloadUri`][salto.nebula.electroniclock.v1.ElectronicLockService.GenerateFirmwareDownloadUri]
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
            get { return ElectronicLockReflection.Descriptor.MessageTypes[26]; }
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
    /// The metadata message for [`GenerateFirmwareDownloadUri`][salto.nebula.electroniclock.v1.ElectronicLockService.GenerateFirmwareDownloadUri]
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
            get { return ElectronicLockReflection.Descriptor.MessageTypes[27]; }
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
