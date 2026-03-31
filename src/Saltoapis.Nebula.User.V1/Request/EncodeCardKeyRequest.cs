using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1.Request
{
    /// <summary>
    /// The request message for [`EncodeCardKey`][salto.nebula.user.v1.UserService.EncodeCardKey]
    /// </summary>
    public sealed partial class EncodeCardKeyRequest : IMessage<EncodeCardKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EncodeCardKeyRequest> _parser = new(() => new EncodeCardKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EncodeCardKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[27]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncodeCardKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EncodeCardKeyRequest(EncodeCardKeyRequest other) : this()
        {
            name_ = other.name_;
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Encoder:
                    Encoder = other.Encoder;
                    break;
                case DeviceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case DeviceOneofCase.Controller:
                    Controller = other.Controller;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EncodeCardKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's card key to be encoded. For example:
        /// `installations/surelock-homes-hq/users/john-watson/card-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 2;

        /// <summary>
        /// Device name, when device is an encoder
        /// </summary>
        public string Encoder
        {
            get { return HasEncoder ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.Encoder;
            }
        }

        /// <summary>Gets whether the "encoder" field is set</summary>
        public bool HasEncoder
        {
            get { return deviceCase_ == DeviceOneofCase.Encoder; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "encoder" </summary>
        public void ClearEncoder()
        {
            if (HasEncoder) ClearDevice();
        }

        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 3;

        /// <summary>
        /// Device name, when device is an electronic lock
        /// </summary>
        public string ElectronicLock
        {
            get { return HasElectronicLock ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.ElectronicLock;
            }
        }

        /// <summary>Gets whether the "electronic_lock" field is set</summary>
        public bool HasElectronicLock
        {
            get { return deviceCase_ == DeviceOneofCase.ElectronicLock; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "electronic_lock" </summary>
        public void ClearElectronicLock()
        {
            if (HasElectronicLock) ClearDevice();
        }

        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 4;

        /// <summary>
        /// Device name, when device is a controller
        /// </summary>
        public string Controller
        {
            get { return HasController ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.Controller;
            }
        }

        /// <summary>Gets whether the "controller" field is set</summary>
        public bool HasController
        {
            get { return deviceCase_ == DeviceOneofCase.Controller; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "controller" </summary>
        public void ClearController()
        {
            if (HasController) ClearDevice();
        }

        private object device_;

        /// <summary>Enum of possible cases for the "device" oneof.</summary>
        public enum DeviceOneofCase
        {
            None = 0,
            Encoder = 2,
            ElectronicLock = 3,
            Controller = 4,
        }

        private DeviceOneofCase deviceCase_ = DeviceOneofCase.None;

        public DeviceOneofCase DeviceCase
        {
            get { return deviceCase_; }
        }

        public void ClearDevice()
        {
            deviceCase_ = DeviceOneofCase.None;
            device_ = null;
        }

        public override bool Equals(object other) => Equals(other as EncodeCardKeyRequest);
        public bool Equals(EncodeCardKeyRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (Encoder != other.Encoder)) return false;
            if ((ElectronicLock != other.ElectronicLock) || (Controller != other.Controller)) return false;
            if (DeviceCase != other.DeviceCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasEncoder) hash ^= Encoder.GetHashCode();
            if (HasElectronicLock) hash ^= ElectronicLock.GetHashCode();
            if (HasController) hash ^= Controller.GetHashCode();
            hash ^= (int)deviceCase_;
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
      if (HasEncoder) {
        output.WriteRawTag(18);
        output.WriteString(Encoder);
      }
      if (HasElectronicLock) {
        output.WriteRawTag(26);
        output.WriteString(ElectronicLock);
      }
      if (HasController) {
        output.WriteRawTag(34);
        output.WriteString(Controller);
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
            if (HasEncoder)
            {
                output.WriteRawTag(18);
                output.WriteString(Encoder);
            }
            if (HasElectronicLock)
            {
                output.WriteRawTag(26);
                output.WriteString(ElectronicLock);
            }
            if (HasController)
            {
                output.WriteRawTag(34);
                output.WriteString(Controller);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (HasEncoder) size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
            if (HasElectronicLock) size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLock);
            if (HasController) size += 1 + CodedOutputStream.ComputeStringSize(Controller);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(EncodeCardKeyRequest other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Encoder:
                    Encoder = other.Encoder;
                    break;
                case DeviceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case DeviceOneofCase.Controller:
                    Controller = other.Controller;
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
            Encoder = input.ReadString();
            break;
          }
          case 26: {
            ElectronicLock = input.ReadString();
            break;
          }
          case 34: {
            Controller = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            ElectronicLock = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Controller = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
