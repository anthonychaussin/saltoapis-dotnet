using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Encoder.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/encoder/v1/encoder.proto</summary>
    public static partial class EncoderReflection
    {

        #region Descriptor
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
        #endregion

    }
    #region Messages
    /// <summary>
    /// The encoder object
    /// </summary>
    public sealed partial class Encoder : IMessage<Encoder>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Encoder> _parser = new(() => new Encoder());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Encoder> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Encoder()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Encoder(Encoder other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            connected_ = other.connected_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            outdated_ = other.outdated_;
            disableSound_ = other.disableSound_;
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

        public Encoder Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the encoder. It must have the format of
        /// `installations/*/encoders/*`. For example:
        /// `installations/surelock-homes-hq/encoders/dancing-men`.
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
        /// Display name of the encoder.
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

        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 4;

        /// <summary>
        /// Parent name, when encoder is connected to a gateway
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
        /// Parent name, when encoder is connected to an extender
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

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 6;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this encoder has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateEncoder`][salto.nebula.encoder.v1.EncoderService.UpdateEncoder]
        /// operation. To change the value of this field, you must call
        /// [`InitializeEncoder`][salto.nebula.encoder.v1.EncoderService.InitializeEncoder].
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
        public const int DeviceMetadataFieldNumber = 11;
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
        /// Indicates whether this encoder is connected or not. It's considered
        /// connected if there has been at least one communication with it within the
        /// last 10 minutes.
        /// </summary>
        public bool Connected
        {
            get { return connected_; }
            set
            {
                connected_ = value;
            }
        }

        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 8;
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

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 9;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this encoder has pending updates or not. This could be
        /// because there was a pending configuration or a firmware update and is
        /// conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        /// <summary>Field number for the "disable_sound" field.</summary>
        public const int DisableSoundFieldNumber = 10;
        private bool disableSound_;

        /// <summary>
        /// Disables the sound emitted by the encoder during operation.
        /// </summary>
        public bool DisableSound
        {
            get { return disableSound_; }
            set
            {
                disableSound_ = value;
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

        public override bool Equals(object other) => Equals(other as Encoder);
        public bool Equals(Encoder other)
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
            if (Initialized != other.Initialized) return false;
            if (!Equals(DeviceMetadata, other.DeviceMetadata)) return false;
            if (Connected != other.Connected) return false;
            if (!Equals(LastEventTime, other.LastEventTime)) return false;
            if (Outdated != other.Outdated) return false;
            if (DisableSound != other.DisableSound) return false;
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
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Connected != false) hash ^= Connected.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (DisableSound != false) hash ^= DisableSound.GetHashCode();
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
      if (Initialized != false) {
        output.WriteRawTag(48);
        output.WriteBool(Initialized);
      }
      if (Connected != false) {
        output.WriteRawTag(56);
        output.WriteBool(Connected);
      }
      if (lastEventTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(LastEventTime);
      }
      if (Outdated != false) {
        output.WriteRawTag(72);
        output.WriteBool(Outdated);
      }
      if (DisableSound != false) {
        output.WriteRawTag(80);
        output.WriteBool(DisableSound);
      }
      if (deviceMetadata_ != null) {
        output.WriteRawTag(90);
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
            if (Initialized != false)
            {
                output.WriteRawTag(48);
                output.WriteBool(Initialized);
            }
            if (Connected != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(Connected);
            }
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(LastEventTime);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(72);
                output.WriteBool(Outdated);
            }
            if (DisableSound != false)
            {
                output.WriteRawTag(80);
                output.WriteBool(DisableSound);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(90);
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
            if (lastEventTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (DisableSound != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Encoder other)
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
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null)
                {
                    LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
            }
            if (other.DisableSound != false)
            {
                DisableSound = other.DisableSound;
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
          case 48: {
            Initialized = input.ReadBool();
            break;
          }
          case 56: {
            Connected = input.ReadBool();
            break;
          }
          case 66: {
            if (lastEventTime_ == null) {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 72: {
            Outdated = input.ReadBool();
            break;
          }
          case 80: {
            DisableSound = input.ReadBool();
            break;
          }
          case 90: {
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
                    case 48:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 56:
                        {
                            Connected = input.ReadBool();
                            break;
                        }
                    case 66:
                        {
                            if (lastEventTime_ == null)
                            {
                                LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(LastEventTime);
                            break;
                        }
                    case 72:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                    case 80:
                        {
                            DisableSound = input.ReadBool();
                            break;
                        }
                    case 90:
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
    /// The request message for [CreateEncoder][salto.nebula.encoder.v1.EncoderService.CreateEncoder]
    /// </summary>
    public sealed partial class CreateEncoderRequest : IMessage<CreateEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateEncoderRequest> _parser = new(() => new CreateEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateEncoderRequest(CreateEncoderRequest other) : this()
        {
            parent_ = other.parent_;
            encoderId_ = other.encoderId_;
            encoder_ = other.encoder_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the encoder. For
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

        /// <summary>Field number for the "encoder_id" field.</summary>
        public const int EncoderIdFieldNumber = 2;
        private readonly static string EncoderIdDefaultValue = "";

        private string encoderId_;

        /// <summary>
        /// The encoder ID to use for this encoder. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string EncoderId
        {
            get { return encoderId_ ?? EncoderIdDefaultValue; }
            set
            {
                encoderId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "encoder_id" field is set</summary>
        public bool HasEncoderId
        {
            get { return encoderId_ != null; }
        }

        /// <summary>Clears the value of the "encoder_id" field</summary>
        public void ClearEncoderId()
        {
            encoderId_ = null;
        }

        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 3;
        private Encoder encoder_;

        /// <summary>
        /// The encoder resource to be created. Client must not set the
        /// `Encoder.name` field.
        /// </summary>
        public Encoder Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateEncoderRequest);
        public bool Equals(CreateEncoderRequest other)
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
            if (EncoderId != other.EncoderId) return false;
            if (!Equals(Encoder, other.Encoder)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasEncoderId) hash ^= EncoderId.GetHashCode();
            if (encoder_ != null) hash ^= Encoder.GetHashCode();
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
      if (HasEncoderId) {
        output.WriteRawTag(18);
        output.WriteString(EncoderId);
      }
      if (encoder_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Encoder);
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
            if (HasEncoderId)
            {
                output.WriteRawTag(18);
                output.WriteString(EncoderId);
            }
            if (encoder_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Encoder);
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
            if (HasEncoderId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(EncoderId);
            }
            if (encoder_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Encoder);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateEncoderRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasEncoderId)
            {
                EncoderId = other.EncoderId;
            }
            if (other.encoder_ != null)
            {
                if (encoder_ == null)
                {
                    Encoder = new Encoder();
                }
                Encoder.MergeFrom(other.Encoder);
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
            EncoderId = input.ReadString();
            break;
          }
          case 26: {
            if (encoder_ == null) {
              Encoder = new Saltoapis.Nebula.Encoder.V1.Encoder();
            }
            input.ReadMessage(Encoder);
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
                            EncoderId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (encoder_ == null)
                            {
                                Encoder = new Encoder();
                            }
                            input.ReadMessage(Encoder);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetEncoder][salto.nebula.encoder.v1.EncoderService.GetEncoder]
    /// </summary>
    public sealed partial class GetEncoderRequest : IMessage<GetEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetEncoderRequest> _parser = new(() => new GetEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetEncoderRequest(GetEncoderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested encoder resource. For example:
        /// `installations/surelock-homes-hq/encoders/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetEncoderRequest);
        public bool Equals(GetEncoderRequest other)
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

        public void MergeFrom(GetEncoderRequest other)
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
    /// The request message for [ListEncoders][salto.nebula.encoder.v1.EncoderService.ListEncoders]
    /// </summary>
    public sealed partial class ListEncodersRequest : IMessage<ListEncodersRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListEncodersRequest> _parser = new(() => new ListEncodersRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListEncodersRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListEncodersRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListEncodersRequest(ListEncodersRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListEncodersRequest Clone() => new(this);
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
        /// A filter that chooses which encoders to return.
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

        public override bool Equals(object other) => Equals(other as ListEncodersRequest);
        public bool Equals(ListEncodersRequest other)
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

        public void MergeFrom(ListEncodersRequest other)
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
    /// The response message for [ListEncoders][salto.nebula.encoder.v1.EncoderService.ListEncoders]
    /// </summary>
    public sealed partial class ListEncodersResponse : IMessage<ListEncodersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListEncodersResponse> _parser = new(() => new ListEncodersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListEncodersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListEncodersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListEncodersResponse(ListEncodersResponse other) : this()
        {
            encoders_ = other.encoders_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListEncodersResponse Clone() => new(this);
        /// <summary>Field number for the "encoders" field.</summary>
        public const int EncodersFieldNumber = 1;
        private static readonly FieldCodec<Encoder> _repeated_encoders_codec
            = FieldCodec.ForMessage(10, Encoder.Parser);
        private readonly RepeatedField<Encoder> encoders_ = [];

        /// <summary>
        /// The field name should match the noun `encoders` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Encoder> Encoders
        {
            get { return encoders_; }
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

        public override bool Equals(object other) => Equals(other as ListEncodersResponse);
        public bool Equals(ListEncodersResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!encoders_.Equals(other.encoders_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= encoders_.GetHashCode();
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
      encoders_.WriteTo(output, _repeated_encoders_codec);
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
            encoders_.WriteTo(ref output, _repeated_encoders_codec);
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
            size += encoders_.CalculateSize(_repeated_encoders_codec);
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

        public void MergeFrom(ListEncodersResponse other)
        {
            if (other == null)
            {
                return;
            }
            encoders_.Add(other.encoders_);
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
            encoders_.AddEntriesFrom(input, _repeated_encoders_codec);
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
                            encoders_.AddEntriesFrom(ref input, _repeated_encoders_codec);
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
    /// The request message for [UpdateEncoder][salto.nebula.encoder.v1.EncoderService.UpdateEncoder]
    /// </summary>
    public sealed partial class UpdateEncoderRequest : IMessage<UpdateEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEncoderRequest> _parser = new(() => new UpdateEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEncoderRequest(UpdateEncoderRequest other) : this()
        {
            encoder_ = other.encoder_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 1;
        private Encoder encoder_;

        /// <summary>
        /// The encoder resource which replaces the resource on the server.
        /// </summary>
        public Encoder Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateEncoderRequest);
        public bool Equals(UpdateEncoderRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Encoder, other.Encoder)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (encoder_ != null) hash ^= Encoder.GetHashCode();
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
      if (encoder_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Encoder);
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
            if (encoder_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Encoder);
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
            if (encoder_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Encoder);
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

        public void MergeFrom(UpdateEncoderRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.encoder_ != null)
            {
                if (encoder_ == null)
                {
                    Encoder = new Encoder();
                }
                Encoder.MergeFrom(other.Encoder);
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
            if (encoder_ == null) {
              Encoder = new Saltoapis.Nebula.Encoder.V1.Encoder();
            }
            input.ReadMessage(Encoder);
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
                            if (encoder_ == null)
                            {
                                Encoder = new Encoder();
                            }
                            input.ReadMessage(Encoder);
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
    /// The request message for [DeleteEncoder][salto.nebula.encoder.v1.EncoderService.DeleteEncoder]
    /// </summary>
    public sealed partial class DeleteEncoderRequest : IMessage<DeleteEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteEncoderRequest> _parser = new(() => new DeleteEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteEncoderRequest(DeleteEncoderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the encoder to be deleted. For example:
        /// `installations/surelock-homes-hq/encoders/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteEncoderRequest);
        public bool Equals(DeleteEncoderRequest other)
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

        public void MergeFrom(DeleteEncoderRequest other)
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
    /// The request message for [`BindEncoder`][salto.nebula.encoder.v1.EncoderService.BindEncoder]
    /// </summary>
    public sealed partial class BindEncoderRequest : IMessage<BindEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindEncoderRequest> _parser = new(() => new BindEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindEncoderRequest(BindEncoderRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the encoder to be bound. For example:
        /// `installations/surelock-homes-hq/encoders/baker-street-entrance`.
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

        public override bool Equals(object other) => Equals(other as BindEncoderRequest);
        public bool Equals(BindEncoderRequest other)
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

        public void MergeFrom(BindEncoderRequest other)
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
    /// The empty response message for [`BindEncoder`][salto.nebula.encoder.v1.EncoderService.BindEncoder]
    /// </summary>
    public sealed partial class BindEncoderResponse : IMessage<BindEncoderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindEncoderResponse> _parser = new(() => new BindEncoderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindEncoderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindEncoderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindEncoderResponse(BindEncoderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindEncoderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BindEncoderResponse);
        public bool Equals(BindEncoderResponse other)
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

        public void MergeFrom(BindEncoderResponse other)
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
    /// The request message for [`UnbindEncoder`][salto.nebula.enconder.v1.EncoderService.UnbindEncoder]
    /// </summary>
    public sealed partial class UnbindEncoderRequest : IMessage<UnbindEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindEncoderRequest> _parser = new(() => new UnbindEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindEncoderRequest(UnbindEncoderRequest other) : this()
        {
            name_ = other.name_;
            force_ = other.force_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the encoder to be unbound. For example:
        /// `installations/surelock-homes-hq/encoders/baker-street-entrance`.
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
        /// encoder. Otherwise, the request will only work if the encoder
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

        public override bool Equals(object other) => Equals(other as UnbindEncoderRequest);
        public bool Equals(UnbindEncoderRequest other)
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

        public void MergeFrom(UnbindEncoderRequest other)
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
    /// The empty response message for [`UnbindEnconder`][salto.nebula.enconder.v1.EncoderService.UnbindEnconder]
    /// </summary>
    public sealed partial class UnbindEncoderResponse : IMessage<UnbindEncoderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindEncoderResponse> _parser = new(() => new UnbindEncoderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindEncoderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindEncoderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindEncoderResponse(UnbindEncoderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindEncoderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnbindEncoderResponse);
        public bool Equals(UnbindEncoderResponse other)
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

        public void MergeFrom(UnbindEncoderResponse other)
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
    /// The request message for [`InitializeEncoder`][salto.nebula.encoder.v1.EncoderService.InitializeEncoder]
    /// </summary>
    public sealed partial class InitializeEncoderRequest : IMessage<InitializeEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeEncoderRequest> _parser = new(() => new InitializeEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeEncoderRequest(InitializeEncoderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the encoder to be initialized. For example:
        /// `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as InitializeEncoderRequest);
        public bool Equals(InitializeEncoderRequest other)
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

        public void MergeFrom(InitializeEncoderRequest other)
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
    /// The empty response message for [`InitializeEncoder`][salto.nebula.encoder.v1.EncoderService.InitializeEncoder]
    /// </summary>
    public sealed partial class InitializeEncoderResponse : IMessage<InitializeEncoderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeEncoderResponse> _parser = new(() => new InitializeEncoderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeEncoderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeEncoderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeEncoderResponse(InitializeEncoderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeEncoderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeEncoderResponse);
        public bool Equals(InitializeEncoderResponse other)
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

        public void MergeFrom(InitializeEncoderResponse other)
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
    /// The metadata message for [`InitializeEncoder`][salto.nebula.encoder.v1.EncoderService.InitializeEncoder]
    /// </summary>
    public sealed partial class InitializeEncoderMetadata : IMessage<InitializeEncoderMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeEncoderMetadata> _parser = new(() => new InitializeEncoderMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeEncoderMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeEncoderMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeEncoderMetadata(InitializeEncoderMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeEncoderMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeEncoderMetadata);
        public bool Equals(InitializeEncoderMetadata other)
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

        public void MergeFrom(InitializeEncoderMetadata other)
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
    /// The request message for [`ConfigureEncoder`][salto.nebula.encoder.v1.EncoderService.ConfigureEncoder]
    /// </summary>
    public sealed partial class ConfigureEncoderRequest : IMessage<ConfigureEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureEncoderRequest> _parser = new(() => new ConfigureEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureEncoderRequest(ConfigureEncoderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the encoder to be configured. For example:
        /// `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ConfigureEncoderRequest);
        public bool Equals(ConfigureEncoderRequest other)
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

        public void MergeFrom(ConfigureEncoderRequest other)
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
    /// The empty response message for [`ConfigureEncoder`][salto.nebula.encoder.v1.EncoderService.ConfigureEncoder]
    /// </summary>
    public sealed partial class ConfigureEncoderResponse : IMessage<ConfigureEncoderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureEncoderResponse> _parser = new(() => new ConfigureEncoderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureEncoderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureEncoderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureEncoderResponse(ConfigureEncoderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureEncoderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureEncoderResponse);
        public bool Equals(ConfigureEncoderResponse other)
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

        public void MergeFrom(ConfigureEncoderResponse other)
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
    /// The metadata message for [`ConfigureEncoder`][salto.nebula.encoder.v1.EncoderService.ConfigureEncoder]
    /// </summary>
    public sealed partial class ConfigureEncoderMetadata : IMessage<ConfigureEncoderMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureEncoderMetadata> _parser = new(() => new ConfigureEncoderMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureEncoderMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureEncoderMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureEncoderMetadata(ConfigureEncoderMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureEncoderMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureEncoderMetadata);
        public bool Equals(ConfigureEncoderMetadata other)
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

        public void MergeFrom(ConfigureEncoderMetadata other)
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
    /// The request message for [`ResetEncoder`][salto.nebula.encoder.v1.EncoderService.ResetEncoder]
    /// </summary>
    public sealed partial class ResetEncoderRequest : IMessage<ResetEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetEncoderRequest> _parser = new(() => new ResetEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetEncoderRequest(ResetEncoderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the encoder to be reset. For example:
        /// `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ResetEncoderRequest);
        public bool Equals(ResetEncoderRequest other)
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

        public void MergeFrom(ResetEncoderRequest other)
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
    /// The empty response message for [`ResetEncoder`][salto.nebula.encoder.v1.EncoderService.ResetEncoder]
    /// </summary>
    public sealed partial class ResetEncoderResponse : IMessage<ResetEncoderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetEncoderResponse> _parser = new(() => new ResetEncoderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetEncoderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetEncoderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetEncoderResponse(ResetEncoderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetEncoderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetEncoderResponse);
        public bool Equals(ResetEncoderResponse other)
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

        public void MergeFrom(ResetEncoderResponse other)
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
    /// The metadata message for [`ResetEncoder`][salto.nebula.encoder.v1.EncoderService.ResetEncoder]
    /// </summary>
    public sealed partial class ResetEncoderMetadata : IMessage<ResetEncoderMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetEncoderMetadata> _parser = new(() => new ResetEncoderMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetEncoderMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetEncoderMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetEncoderMetadata(ResetEncoderMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetEncoderMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetEncoderMetadata);
        public bool Equals(ResetEncoderMetadata other)
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

        public void MergeFrom(ResetEncoderMetadata other)
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
    /// The request message for [`UpdateEncoderFirmware`][salto.nebula.encoder.v1.EncoderService.UpdateEncoderFirmware]
    /// </summary>
    public sealed partial class UpdateEncoderFirmwareRequest : IMessage<UpdateEncoderFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEncoderFirmwareRequest> _parser = new(() => new UpdateEncoderFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEncoderFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEncoderFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEncoderFirmwareRequest(UpdateEncoderFirmwareRequest other) : this()
        {
            encoder_ = other.encoder_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEncoderFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 1;
        private string encoder_ = "";

        /// <summary>
        /// The resource name of the encoder whose firmware will be updated. For
        /// example:
        /// `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateEncoderFirmwareRequest);
        public bool Equals(UpdateEncoderFirmwareRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Encoder != other.Encoder) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Encoder.Length != 0) hash ^= Encoder.GetHashCode();
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
      if (Encoder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Encoder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Encoder.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Encoder);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Encoder.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateEncoderFirmwareRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Encoder.Length != 0)
            {
                Encoder = other.Encoder;
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
            Encoder = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`UpdateEncoderFirmware`][salto.nebula.encoder.v1.EncoderService.UpdateEncoderFirmware]
    /// </summary>
    public sealed partial class UpdateEncoderFirmwareResponse : IMessage<UpdateEncoderFirmwareResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEncoderFirmwareResponse> _parser = new(() => new UpdateEncoderFirmwareResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEncoderFirmwareResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEncoderFirmwareResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEncoderFirmwareResponse(UpdateEncoderFirmwareResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEncoderFirmwareResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UpdateEncoderFirmwareResponse);
        public bool Equals(UpdateEncoderFirmwareResponse other)
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

        public void MergeFrom(UpdateEncoderFirmwareResponse other)
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
    /// The metadata message for [`UpdateEncoderFirmware`][salto.nebula.encoder.v1.EncoderService.UpdateEncoderFirmware]
    /// </summary>
    public sealed partial class UpdateEncoderFirmwareMetadata : IMessage<UpdateEncoderFirmwareMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEncoderFirmwareMetadata> _parser = new(() => new UpdateEncoderFirmwareMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEncoderFirmwareMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEncoderFirmwareMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEncoderFirmwareMetadata(UpdateEncoderFirmwareMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEncoderFirmwareMetadata Clone() => new(this);
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

        public override bool Equals(object other) => Equals(other as UpdateEncoderFirmwareMetadata);
        public bool Equals(UpdateEncoderFirmwareMetadata other)
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

        public void MergeFrom(UpdateEncoderFirmwareMetadata other)
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
    /// The request message for [`ReadKey`][salto.nebula.device.v1.EncoderService.ReadKey]
    /// </summary>
    public sealed partial class ReadKeyRequest : IMessage<ReadKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ReadKeyRequest> _parser = new(() => new ReadKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ReadKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ReadKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ReadKeyRequest(ReadKeyRequest other) : this()
        {
            encoder_ = other.encoder_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ReadKeyRequest Clone() => new(this);
        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 1;
        private string encoder_ = "";

        /// <summary>
        /// The name of the requested encoder resource. For example:
        /// `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ReadKeyRequest);
        public bool Equals(ReadKeyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Encoder != other.Encoder) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Encoder.Length != 0) hash ^= Encoder.GetHashCode();
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
      if (Encoder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Encoder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Encoder.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Encoder);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Encoder.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ReadKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Encoder.Length != 0)
            {
                Encoder = other.Encoder;
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
            Encoder = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ReadKey`][salto.nebula.device.v1.EncoderService.ReadKey]
    /// </summary>
    public sealed partial class ReadKeyResponse : IMessage<ReadKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ReadKeyResponse> _parser = new(() => new ReadKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ReadKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ReadKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ReadKeyResponse(ReadKeyResponse other) : this()
        {
            switch (other.KeyCase)
            {
                case KeyOneofCase.CardKey:
                    CardKey = other.CardKey;
                    break;
                case KeyOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey;
                    break;
            }

            switch (other.KeyIdCase)
            {
                case KeyIdOneofCase.Uid:
                    Uid = other.Uid;
                    break;
                case KeyIdOneofCase.DeviceId:
                    DeviceId = other.DeviceId;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ReadKeyResponse Clone() => new(this);
        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 1;

        /// <summary>
        /// Card key reference, belonging to a user.
        /// </summary>
        public string CardKey
        {
            get { return HasCardKey ? (string)key_ : ""; }
            set
            {
                key_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyCase_ = KeyOneofCase.CardKey;
            }
        }

        /// <summary>Gets whether the "card_key" field is set</summary>
        public bool HasCardKey
        {
            get { return keyCase_ == KeyOneofCase.CardKey; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "card_key" </summary>
        public void ClearCardKey()
        {
            if (HasCardKey)
            {
                ClearKey();
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 2;

        /// <summary>
        /// Electronic key reference, belonging to a user.
        /// </summary>
        public string ElectronicKey
        {
            get { return HasElectronicKey ? (string)key_ : ""; }
            set
            {
                key_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyCase_ = KeyOneofCase.ElectronicKey;
            }
        }

        /// <summary>Gets whether the "electronic_key" field is set</summary>
        public bool HasElectronicKey
        {
            get { return keyCase_ == KeyOneofCase.ElectronicKey; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "electronic_key" </summary>
        public void ClearElectronicKey()
        {
            if (HasElectronicKey)
            {
                ClearKey();
            }
        }

        /// <summary>Field number for the "uid" field.</summary>
        public const int UidFieldNumber = 3;

        /// <summary>
        /// UID of the key that was read.
        /// </summary>
        public string Uid
        {
            get { return HasUid ? (string)keyId_ : ""; }
            set
            {
                keyId_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyIdCase_ = KeyIdOneofCase.Uid;
            }
        }

        /// <summary>Gets whether the "uid" field is set</summary>
        public bool HasUid
        {
            get { return keyIdCase_ == KeyIdOneofCase.Uid; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "uid" </summary>
        public void ClearUid()
        {
            if (HasUid)
            {
                ClearKeyId();
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 4;

        /// <summary>
        /// Device ID of the key that was read.
        /// </summary>
        public string DeviceId
        {
            get { return HasDeviceId ? (string)keyId_ : ""; }
            set
            {
                keyId_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyIdCase_ = KeyIdOneofCase.DeviceId;
            }
        }

        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId
        {
            get { return keyIdCase_ == KeyIdOneofCase.DeviceId; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "device_id" </summary>
        public void ClearDeviceId()
        {
            if (HasDeviceId)
            {
                ClearKeyId();
            }
        }

        private object key_;

        /// <summary>Enum of possible cases for the "key" oneof.</summary>
        public enum KeyOneofCase
        {
            None = 0,
            CardKey = 1,
            ElectronicKey = 2,
        }

        private KeyOneofCase keyCase_ = KeyOneofCase.None;

        public KeyOneofCase KeyCase
        {
            get { return keyCase_; }
        }

        public void ClearKey()
        {
            keyCase_ = KeyOneofCase.None;
            key_ = null;
        }

        private object keyId_;

        /// <summary>Enum of possible cases for the "key_id" oneof.</summary>
        public enum KeyIdOneofCase
        {
            None = 0,
            Uid = 3,
            DeviceId = 4,
        }

        private KeyIdOneofCase keyIdCase_ = KeyIdOneofCase.None;

        public KeyIdOneofCase KeyIdCase
        {
            get { return keyIdCase_; }
        }

        public void ClearKeyId()
        {
            keyIdCase_ = KeyIdOneofCase.None;
            keyId_ = null;
        }

        public override bool Equals(object other) => Equals(other as ReadKeyResponse);
        public bool Equals(ReadKeyResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (CardKey != other.CardKey) return false;
            if (ElectronicKey != other.ElectronicKey) return false;
            if (Uid != other.Uid) return false;
            if (DeviceId != other.DeviceId) return false;
            if (KeyCase != other.KeyCase) return false;
            if (KeyIdCase != other.KeyIdCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (HasCardKey) hash ^= CardKey.GetHashCode();
            if (HasElectronicKey) hash ^= ElectronicKey.GetHashCode();
            if (HasUid) hash ^= Uid.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            hash ^= (int)keyCase_;
            hash ^= (int)keyIdCase_;
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
      if (HasCardKey) {
        output.WriteRawTag(10);
        output.WriteString(CardKey);
      }
      if (HasElectronicKey) {
        output.WriteRawTag(18);
        output.WriteString(ElectronicKey);
      }
      if (HasUid) {
        output.WriteRawTag(26);
        output.WriteString(Uid);
      }
      if (HasDeviceId) {
        output.WriteRawTag(34);
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
            if (HasCardKey)
            {
                output.WriteRawTag(10);
                output.WriteString(CardKey);
            }
            if (HasElectronicKey)
            {
                output.WriteRawTag(18);
                output.WriteString(ElectronicKey);
            }
            if (HasUid)
            {
                output.WriteRawTag(26);
                output.WriteString(Uid);
            }
            if (HasDeviceId)
            {
                output.WriteRawTag(34);
                output.WriteString(DeviceId);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (HasCardKey)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(CardKey);
            }
            if (HasElectronicKey)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicKey);
            }
            if (HasUid)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Uid);
            }
            if (HasDeviceId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ReadKeyResponse other)
        {
            if (other == null)
            {
                return;
            }
            switch (other.KeyCase)
            {
                case KeyOneofCase.CardKey:
                    CardKey = other.CardKey;
                    break;
                case KeyOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey;
                    break;
            }

            switch (other.KeyIdCase)
            {
                case KeyIdOneofCase.Uid:
                    Uid = other.Uid;
                    break;
                case KeyIdOneofCase.DeviceId:
                    DeviceId = other.DeviceId;
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
            CardKey = input.ReadString();
            break;
          }
          case 18: {
            ElectronicKey = input.ReadString();
            break;
          }
          case 26: {
            Uid = input.ReadString();
            break;
          }
          case 34: {
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
                            CardKey = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            ElectronicKey = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Uid = input.ReadString();
                            break;
                        }
                    case 34:
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
    /// The metadata message for [`ReadKey`][salto.nebula.device.v1.EncoderService.ReadKey]
    /// </summary>
    public sealed partial class ReadKeyMetadata : IMessage<ReadKeyMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ReadKeyMetadata> _parser = new(() => new ReadKeyMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ReadKeyMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[25]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ReadKeyMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ReadKeyMetadata(ReadKeyMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ReadKeyMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ReadKeyMetadata);
        public bool Equals(ReadKeyMetadata other)
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

        public void MergeFrom(ReadKeyMetadata other)
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
    /// The request message for [`GenerateAuthorizationToken`][salto.nebula.encoder.v1.EncoderService.GenerateAuthorizationToken]
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
            get { return EncoderReflection.Descriptor.MessageTypes[26]; }
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
            encoder_ = other.encoder_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenRequest Clone() => new(this);
        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 1;
        private string encoder_ = "";

        /// <summary>
        /// The resource name of the encoder that the authorization token is
        /// generated for. For example:
        /// `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (Encoder != other.Encoder) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Encoder.Length != 0) hash ^= Encoder.GetHashCode();
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
      if (Encoder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Encoder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Encoder.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Encoder);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Encoder.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
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
            if (other.Encoder.Length != 0)
            {
                Encoder = other.Encoder;
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
            Encoder = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateAuthorizationToken`][salto.nebula.encoder.v1.EncoderService.GenerateAuthorizationToken]
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
            get { return EncoderReflection.Descriptor.MessageTypes[27]; }
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
        /// Authorization token to be used for connecting against an encoder.
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
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.encoder.v1.EncoderService.GenerateFirmwareDownloadUri]
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
            get { return EncoderReflection.Descriptor.MessageTypes[28]; }
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
            encoder_ = other.encoder_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 1;
        private string encoder_ = "";

        /// <summary>
        /// The resource name of the encoder to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (Encoder != other.Encoder) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Encoder.Length != 0) hash ^= Encoder.GetHashCode();
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
      if (Encoder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Encoder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Encoder.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Encoder);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Encoder.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
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
            if (other.Encoder.Length != 0)
            {
                Encoder = other.Encoder;
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
            Encoder = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateFirmwareDownloadUri`][salto.nebula.encoder.v1.EncoderService.GenerateFirmwareDownloadUri]
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
            get { return EncoderReflection.Descriptor.MessageTypes[29]; }
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
    /// The metadata message for [`GenerateFirmwareDownloadUri`][salto.nebula.encoder.v1.EncoderService.GenerateFirmwareDownloadUri]
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
            get { return EncoderReflection.Descriptor.MessageTypes[30]; }
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
