namespace Saltoapis.Nebula.Extender.V1
{
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

        public static MessageParser<Extender> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ExtenderReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

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
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the extender.
        /// </summary>
        public string DisplayName
        {
            get => displayName_; set => displayName_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 3;
        private static readonly string DeviceIdDefaultValue = "";

        private string deviceId_;
        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, encoders and so on.
        /// </summary>
        public string DeviceId
        {
            get => deviceId_ ?? DeviceIdDefaultValue; set => deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId => deviceId_ != null;
        /// <summary>Clears the value of the "device_id" field</summary>
        public void ClearDeviceId() => deviceId_ = null;
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
        public bool HasGateway => parentDeviceCase_ == ParentDeviceOneofCase.Gateway;
        /// <summary> Clears the value of the oneof if it's currently set to "gateway" </summary>
        public void ClearGateway()
        {
            if (HasGateway) ClearParentDevice();
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
        public bool HasExtender_ => parentDeviceCase_ == ParentDeviceOneofCase.Extender_;
        /// <summary> Clears the value of the oneof if it's currently set to "extender" </summary>
        public void ClearExtender_()
        {
            if (HasExtender_) ClearParentDevice();
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
            get => parentDeviceCase_;}

        public void ClearParentDevice()
        {
            parentDeviceCase_ = ParentDeviceOneofCase.None;
            parentDevice_ = null;
        }

        public override bool Equals(object other) => Equals(other as Extender);
        public bool Equals(Extender other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName) || (DeviceId != other.DeviceId) || (Gateway != other.Gateway) || (Extender_ != other.Extender_) || (ParentDeviceCase != other.ParentDeviceCase)) return false;
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
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
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
      if (_unknownFields != null)
      {
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
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (HasDeviceId) size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            if (HasGateway) size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            if (HasExtender_) size += 1 + CodedOutputStream.ComputeStringSize(Extender_);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Extender other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasDeviceId) DeviceId = other.DeviceId;
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
      while ((tag = input.ReadTag()) != 0)
      {
      if ((tag & 7) == 4)
      {
        // Abort on any end group tag.
        return;
      }
      switch(tag)
      {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
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
}