using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.DigitalKey.V1
{
    /// <summary>
    /// The digital key's access point association
    /// </summary>
    public sealed partial class DigitalKeyAccessPoint : IMessage<DigitalKeyAccessPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DigitalKeyAccessPoint> _parser = new(() => new DigitalKeyAccessPoint());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DigitalKeyAccessPoint> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DigitalKeyAccessPoint()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DigitalKeyAccessPoint(DigitalKeyAccessPoint other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            supportedTechnologies_ = other.supportedTechnologies_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DigitalKeyAccessPoint Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the access point. It must have the format
        /// `digital-keys/{digital-key}/access-points/*`. For example:
        /// `digital-keys/baker-street-key/access-points/baker-street-entrance`.
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
        /// Display name of the access point.
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
        private string deviceId_ = "";

        /// <summary>
        /// The device which gives coverage to the access point.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "supported_technologies" field.</summary>
        public const int SupportedTechnologiesFieldNumber = 4;
        private static readonly FieldCodec<Type.AppKeyTechnology> _repeated_supportedTechnologies_codec
            = FieldCodec.ForEnum(34, x => (int)x, x => (Type.AppKeyTechnology)x);
        private readonly RepeatedField<Type.AppKeyTechnology> supportedTechnologies_ = [];

        /// <summary>
        /// Supported technologies used by the app to open an access point.
        /// </summary>
        public RepeatedField<Type.AppKeyTechnology> SupportedTechnologies
        {
            get { return supportedTechnologies_; }
        }

        public override bool Equals(object other) => Equals(other as DigitalKeyAccessPoint);
        public bool Equals(DigitalKeyAccessPoint other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName)) return false;
            if ((DeviceId != other.DeviceId) || (!supportedTechnologies_.Equals(other.supportedTechnologies_))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
            hash ^= supportedTechnologies_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
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
      if (DeviceId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DeviceId);
      }
      supportedTechnologies_.WriteTo(output, _repeated_supportedTechnologies_codec);
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
            if (DeviceId.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DeviceId);
            }
            supportedTechnologies_.WriteTo(ref output, _repeated_supportedTechnologies_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (DeviceId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            size += supportedTechnologies_.CalculateSize(_repeated_supportedTechnologies_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(DigitalKeyAccessPoint other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.DeviceId.Length != 0) DeviceId = other.DeviceId;
            supportedTechnologies_.Add(other.supportedTechnologies_);
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
          case 34:
          case 32: {
            supportedTechnologies_.AddEntriesFrom(input, _repeated_supportedTechnologies_codec);
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
                    case 32:
                        {
                            supportedTechnologies_.AddEntriesFrom(ref input, _repeated_supportedTechnologies_codec);
                            break;
                        }
                }
            }
        }
#endif

    }


}
