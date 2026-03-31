using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Extender.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/extender/v1/extender.proto</summary>
    public static partial class ExtenderReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/extender/v1/extender.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

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
        #endregion

    }
    #region Messages
    /// <summary>
    /// The extender object
    /// </summary>
    public sealed partial class Extender : IMessage<Extender>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Extender> _parser = new(() => new Extender());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Extender> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Extender()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Extender(Extender other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender_:
                    Extender_ = other.Extender_;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Extender Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the extender. It must have the format of
        /// `installations/*/extenders/*`. For example:
        /// `installations/surelock-homes-hq/extenders/elementary`.
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
        /// Display name of the extender.
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
        /// Parent name, when extender is connected to a gateway
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
        public const int Extender_FieldNumber = 5;

        /// <summary>
        /// Parent name, when extender is connected to an extender
        /// </summary>
        public string Extender_
        {
            get { return HasExtender_ ? (string)parentDevice_ : ""; }
            set
            {
                parentDevice_ = ProtoPreconditions.CheckNotNull(value, "value");
                parentDeviceCase_ = ParentDeviceOneofCase.Extender_;
            }
        }

        /// <summary>Gets whether the "extender" field is set</summary>
        public bool HasExtender_
        {
            get { return parentDeviceCase_ == ParentDeviceOneofCase.Extender_; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "extender" </summary>
        public void ClearExtender_()
        {
            if (HasExtender_)
            {
                ClearParentDevice();
            }
        }

        private object parentDevice_;

        /// <summary>Enum of possible cases for the "parent_device" oneof.</summary>
        public enum ParentDeviceOneofCase
        {
            None = 0,
            Gateway = 4,
            Extender_ = 5,
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

        public override bool Equals(object other) => Equals(other as Extender);
        public bool Equals(Extender other)
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
            if (Extender_ != other.Extender_) return false;
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
            if (HasExtender_) hash ^= Extender_.GetHashCode();
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
      if (HasExtender_) {
        output.WriteRawTag(42);
        output.WriteString(Extender_);
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
            if (HasExtender_)
            {
                output.WriteRawTag(42);
                output.WriteString(Extender_);
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
            if (HasExtender_)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Extender_);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Extender other)
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
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender_:
                    Extender_ = other.Extender_;
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
            Extender_ = input.ReadString();
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
                            Extender_ = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [CreateExtender][salto.nebula.extender.v1.ExtenderService.CreateExtender]
    /// </summary>
    public sealed partial class CreateExtenderRequest : IMessage<CreateExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateExtenderRequest> _parser = new(() => new CreateExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateExtenderRequest(CreateExtenderRequest other) : this()
        {
            parent_ = other.parent_;
            extenderId_ = other.extenderId_;
            extender_ = other.extender_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the extender. For
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

        /// <summary>Field number for the "extender_id" field.</summary>
        public const int ExtenderIdFieldNumber = 2;
        private readonly static string ExtenderIdDefaultValue = "";

        private string extenderId_;

        /// <summary>
        /// The extender ID to use for this extender. In case it's empty
        /// the server will autogenerate a unique identifier.
        /// </summary>
        public string ExtenderId
        {
            get { return extenderId_ ?? ExtenderIdDefaultValue; }
            set
            {
                extenderId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "extender_id" field is set</summary>
        public bool HasExtenderId
        {
            get { return extenderId_ != null; }
        }

        /// <summary>Clears the value of the "extender_id" field</summary>
        public void ClearExtenderId()
        {
            extenderId_ = null;
        }

        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 3;
        private Extender extender_;

        /// <summary>
        /// The extender resource to be created. Client must not set the
        /// `Extender.name` field.
        /// </summary>
        public Extender Extender
        {
            get { return extender_; }
            set
            {
                extender_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateExtenderRequest);
        public bool Equals(CreateExtenderRequest other)
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
            if (ExtenderId != other.ExtenderId) return false;
            if (!Equals(Extender, other.Extender)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasExtenderId) hash ^= ExtenderId.GetHashCode();
            if (extender_ != null) hash ^= Extender.GetHashCode();
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
      if (HasExtenderId) {
        output.WriteRawTag(18);
        output.WriteString(ExtenderId);
      }
      if (extender_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Extender);
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
            if (HasExtenderId)
            {
                output.WriteRawTag(18);
                output.WriteString(ExtenderId);
            }
            if (extender_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Extender);
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
            if (HasExtenderId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ExtenderId);
            }
            if (extender_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Extender);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateExtenderRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasExtenderId)
            {
                ExtenderId = other.ExtenderId;
            }
            if (other.extender_ != null)
            {
                if (extender_ == null)
                {
                    Extender = new Extender();
                }
                Extender.MergeFrom(other.Extender);
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
            ExtenderId = input.ReadString();
            break;
          }
          case 26: {
            if (extender_ == null) {
              Extender = new Saltoapis.Nebula.Extender.V1.Extender();
            }
            input.ReadMessage(Extender);
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
                            ExtenderId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (extender_ == null)
                            {
                                Extender = new Extender();
                            }
                            input.ReadMessage(Extender);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetExtender][salto.nebula.extender.v1.ExtenderService.GetExtender]
    /// </summary>
    public sealed partial class GetExtenderRequest : IMessage<GetExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetExtenderRequest> _parser = new(() => new GetExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetExtenderRequest(GetExtenderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested extender resource. For example:
        /// `installations/surelock-homes-hq/extenders/elementary`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetExtenderRequest);
        public bool Equals(GetExtenderRequest other)
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

        public void MergeFrom(GetExtenderRequest other)
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
    /// The request message for [ListExtenders][salto.nebula.extender.v1.ExtenderService.ListExtenders]
    /// </summary>
    public sealed partial class ListExtendersRequest : IMessage<ListExtendersRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListExtendersRequest> _parser = new(() => new ListExtendersRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListExtendersRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListExtendersRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListExtendersRequest(ListExtendersRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListExtendersRequest Clone() => new(this);
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
        /// A filter that chooses which extenders to return.
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

        public override bool Equals(object other) => Equals(other as ListExtendersRequest);
        public bool Equals(ListExtendersRequest other)
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

        public void MergeFrom(ListExtendersRequest other)
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
    /// The response message for [ListExtenders][salto.nebula.extender.v1.ExtenderService.ListExtenders]
    /// </summary>
    public sealed partial class ListExtendersResponse : IMessage<ListExtendersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListExtendersResponse> _parser = new(() => new ListExtendersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListExtendersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListExtendersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListExtendersResponse(ListExtendersResponse other) : this()
        {
            extenders_ = other.extenders_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListExtendersResponse Clone() => new(this);
        /// <summary>Field number for the "extenders" field.</summary>
        public const int ExtendersFieldNumber = 1;
        private static readonly FieldCodec<Extender> _repeated_extenders_codec
            = FieldCodec.ForMessage(10, Extender.Parser);
        private readonly RepeatedField<Extender> extenders_ = [];

        /// <summary>
        /// The field name should match the noun `extenders` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<Extender> Extenders
        {
            get { return extenders_; }
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

        public override bool Equals(object other) => Equals(other as ListExtendersResponse);
        public bool Equals(ListExtendersResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!extenders_.Equals(other.extenders_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= extenders_.GetHashCode();
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
      extenders_.WriteTo(output, _repeated_extenders_codec);
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
            extenders_.WriteTo(ref output, _repeated_extenders_codec);
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
            size += extenders_.CalculateSize(_repeated_extenders_codec);
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

        public void MergeFrom(ListExtendersResponse other)
        {
            if (other == null)
            {
                return;
            }
            extenders_.Add(other.extenders_);
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
            extenders_.AddEntriesFrom(input, _repeated_extenders_codec);
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
                            extenders_.AddEntriesFrom(ref input, _repeated_extenders_codec);
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
    /// The response message for [UpdateExtender][salto.nebula.extender.v1.ExtenderService.UpdateExtender]
    /// </summary>
    public sealed partial class UpdateExtenderRequest : IMessage<UpdateExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateExtenderRequest> _parser = new(() => new UpdateExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateExtenderRequest(UpdateExtenderRequest other) : this()
        {
            extender_ = other.extender_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 1;
        private Extender extender_;

        /// <summary>
        /// The extender resource which replaces the resource on the server.
        /// </summary>
        public Extender Extender
        {
            get { return extender_; }
            set
            {
                extender_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateExtenderRequest);
        public bool Equals(UpdateExtenderRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Extender, other.Extender)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (extender_ != null) hash ^= Extender.GetHashCode();
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
      if (extender_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Extender);
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
            if (extender_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Extender);
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
            if (extender_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Extender);
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

        public void MergeFrom(UpdateExtenderRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.extender_ != null)
            {
                if (extender_ == null)
                {
                    Extender = new Extender();
                }
                Extender.MergeFrom(other.Extender);
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
            if (extender_ == null) {
              Extender = new Saltoapis.Nebula.Extender.V1.Extender();
            }
            input.ReadMessage(Extender);
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
                            if (extender_ == null)
                            {
                                Extender = new Extender();
                            }
                            input.ReadMessage(Extender);
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
    /// The response message for [DeleteExtender][salto.nebula.extender.v1.ExtenderService.DeleteExtender]
    /// </summary>
    public sealed partial class DeleteExtenderRequest : IMessage<DeleteExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteExtenderRequest> _parser = new(() => new DeleteExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteExtenderRequest(DeleteExtenderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the extender to be deleted. For example:
        /// `installations/surelock-homes-hq/extenders/elementary`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteExtenderRequest);
        public bool Equals(DeleteExtenderRequest other)
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

        public void MergeFrom(DeleteExtenderRequest other)
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
    /// The request message for [`BindExtender`][salto.nebula.extender.v1.ExtenderService.BindExtender]
    /// </summary>
    public sealed partial class BindExtenderRequest : IMessage<BindExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindExtenderRequest> _parser = new(() => new BindExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindExtenderRequest(BindExtenderRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the extender to be bound. For example:
        /// `installations/surelock-homes-hq/extenders/baker-street-entrance`.
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

        public override bool Equals(object other) => Equals(other as BindExtenderRequest);
        public bool Equals(BindExtenderRequest other)
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

        public void MergeFrom(BindExtenderRequest other)
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
    /// The empty response message for [`BindExtender`][salto.nebula.extender.v1.ExtenderService.BindExtender]
    /// </summary>
    public sealed partial class BindExtenderResponse : IMessage<BindExtenderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindExtenderResponse> _parser = new(() => new BindExtenderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindExtenderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindExtenderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindExtenderResponse(BindExtenderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindExtenderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BindExtenderResponse);
        public bool Equals(BindExtenderResponse other)
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

        public void MergeFrom(BindExtenderResponse other)
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
    /// The request message for [`UnbindExtender`][salto.nebula.extender.v1.ExtenderService.UnbindExtender]
    /// </summary>
    public sealed partial class UnbindExtenderRequest : IMessage<UnbindExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindExtenderRequest> _parser = new(() => new UnbindExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindExtenderRequest(UnbindExtenderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the gateway to be unbound. For example:
        /// `installations/surelock-homes-hq/extenders/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UnbindExtenderRequest);
        public bool Equals(UnbindExtenderRequest other)
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

        public void MergeFrom(UnbindExtenderRequest other)
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
    /// The empty response message for [`UnbindExtender`][salto.nebula.extender.v1.ExtenderService.UnbindExtender]
    /// </summary>
    public sealed partial class UnbindExtenderResponse : IMessage<UnbindExtenderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindExtenderResponse> _parser = new(() => new UnbindExtenderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindExtenderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindExtenderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindExtenderResponse(UnbindExtenderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindExtenderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnbindExtenderResponse);
        public bool Equals(UnbindExtenderResponse other)
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

        public void MergeFrom(UnbindExtenderResponse other)
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
    /// The request message for [`UpdateExtenderFirmware`][salto.nebula.extender.v1.ExtenderService.UpdateExtenderFirmware]
    /// </summary>
    public sealed partial class UpdateExtenderFirmwareRequest : IMessage<UpdateExtenderFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateExtenderFirmwareRequest> _parser = new(() => new UpdateExtenderFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateExtenderFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateExtenderFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateExtenderFirmwareRequest(UpdateExtenderFirmwareRequest other) : this()
        {
            extender_ = other.extender_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateExtenderFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 1;
        private string extender_ = "";

        /// <summary>
        /// The resource name of the extender whose firmware will be updated, for
        /// example:
        /// `installations/surelock-homes-hq/extenders/elementary`.
        /// </summary>
        public string Extender
        {
            get { return extender_; }
            set
            {
                extender_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateExtenderFirmwareRequest);
        public bool Equals(UpdateExtenderFirmwareRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Extender != other.Extender) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Extender.Length != 0) hash ^= Extender.GetHashCode();
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
      if (Extender.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Extender);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Extender.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Extender);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Extender.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Extender);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateExtenderFirmwareRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Extender.Length != 0)
            {
                Extender = other.Extender;
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
            Extender = input.ReadString();
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
                            Extender = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UpdateExtenderFirmware`][salto.nebula.extender.v1.ExtenderService.UpdateExtenderFirmware]
    /// </summary>
    public sealed partial class UpdateExtenderFirmwareResponse : IMessage<UpdateExtenderFirmwareResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateExtenderFirmwareResponse> _parser = new(() => new UpdateExtenderFirmwareResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateExtenderFirmwareResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateExtenderFirmwareResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateExtenderFirmwareResponse(UpdateExtenderFirmwareResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateExtenderFirmwareResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UpdateExtenderFirmwareResponse);
        public bool Equals(UpdateExtenderFirmwareResponse other)
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

        public void MergeFrom(UpdateExtenderFirmwareResponse other)
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
    /// The metadata message for [`UpdateExtenderFirmware`][salto.nebula.extender.v1.ExtenderService.UpdateExtenderFirmware]
    /// </summary>
    public sealed partial class UpdateExtenderFirmwareMetadata : IMessage<UpdateExtenderFirmwareMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateExtenderFirmwareMetadata> _parser = new(() => new UpdateExtenderFirmwareMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateExtenderFirmwareMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateExtenderFirmwareMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateExtenderFirmwareMetadata(UpdateExtenderFirmwareMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateExtenderFirmwareMetadata Clone() => new(this);
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

        public override bool Equals(object other) => Equals(other as UpdateExtenderFirmwareMetadata);
        public bool Equals(UpdateExtenderFirmwareMetadata other)
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

        public void MergeFrom(UpdateExtenderFirmwareMetadata other)
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
    /// The request message for [`ResetExtender`][salto.nebula.extender.v1.ExtenderService.ResetExtender]
    /// </summary>
    public sealed partial class ResetExtenderRequest : IMessage<ResetExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetExtenderRequest> _parser = new(() => new ResetExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetExtenderRequest(ResetExtenderRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the extender to be reset. For example:
        /// `installations/surelock-homes-hq/extenders/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ResetExtenderRequest);
        public bool Equals(ResetExtenderRequest other)
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

        public void MergeFrom(ResetExtenderRequest other)
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
    /// The empty response message for [`ResetExtender`][salto.nebula.extender.v1.ExtenderService.ResetExtender]
    /// </summary>
    public sealed partial class ResetExtenderResponse : IMessage<ResetExtenderResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetExtenderResponse> _parser = new(() => new ResetExtenderResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetExtenderResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetExtenderResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetExtenderResponse(ResetExtenderResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetExtenderResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetExtenderResponse);
        public bool Equals(ResetExtenderResponse other)
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

        public void MergeFrom(ResetExtenderResponse other)
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
    /// The metadata message for [`ResetExtender`][salto.nebula.extender.v1.ExtenderService.ResetExtender]
    /// </summary>
    public sealed partial class ResetExtenderMetadata : IMessage<ResetExtenderMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetExtenderMetadata> _parser = new(() => new ResetExtenderMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetExtenderMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetExtenderMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetExtenderMetadata(ResetExtenderMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetExtenderMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetExtenderMetadata);
        public bool Equals(ResetExtenderMetadata other)
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

        public void MergeFrom(ResetExtenderMetadata other)
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
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.extender.v1.ExtenderService.GenerateFirmwareDownloadUri]
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
            get { return ExtenderReflection.Descriptor.MessageTypes[17]; }
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
            extender_ = other.extender_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 1;
        private string extender_ = "";

        /// <summary>
        /// The resource name of the extender to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/extenders/baker-street-entrance`.
        /// </summary>
        public string Extender
        {
            get { return extender_; }
            set
            {
                extender_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (Extender != other.Extender) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Extender.Length != 0) hash ^= Extender.GetHashCode();
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
      if (Extender.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Extender);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Extender.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Extender);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Extender.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Extender);
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
            if (other.Extender.Length != 0)
            {
                Extender = other.Extender;
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
            Extender = input.ReadString();
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
                            Extender = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateFirmwareDownloadUri`][salto.nebula.extender.v1.ExtenderService.GenerateFirmwareDownloadUri]
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
            get { return ExtenderReflection.Descriptor.MessageTypes[18]; }
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
    /// The metadata message for [`GenerateFirmwareDownloadUri`][salto.nebula.extender.v1.ExtenderService.GenerateFirmwareDownloadUri]
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
            get { return ExtenderReflection.Descriptor.MessageTypes[19]; }
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
