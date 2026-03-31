using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// Representation of an electronic key, belonging to a user
    /// </summary>
    public sealed partial class ElectronicKey : IMessage<ElectronicKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicKey> _parser = new(() => new ElectronicKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ElectronicKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ElectronicKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicKey(ElectronicKey other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            state_ = other.state_;
            outdated_ = other.outdated_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ElectronicKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the user's electronic key. It must have the
        /// format of `installations/*/users/*/electronic-key`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/electronic-key`.
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
        /// by SALTO.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 3;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this electronic key has been assigned, not assigned or is
        /// active and ready for use. This field cannot be modified using a standard
        /// [`UpdateElectronicKey`][salto.nebula.user.v1.UserService.UpdateElectronicKey]
        /// operation. To change the value of this field, you must call
        /// [`EncodeElectronicKey`][salto.nebula.user.v1.UserService.EncodeElectronicKey].
        ///
        /// If the value is `NOT_ASSIGNED` it also applies to cases where the
        /// assignation process has been initiated, but not completed.
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 4;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this electronic key has pending updates or not.
        /// This field cannot be modified using a standard
        /// [`UpdateElectronicKey`][salto.nebula.user.v1.UserService.UpdateElectronicKey]
        /// operation. To change the value of this field, you must call
        /// [`OutdateElectronicKey`][salto.nebula.user.v1.UserService.OutdateElectronicKey].
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ElectronicKey);
        public bool Equals(ElectronicKey other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DeviceId != other.DeviceId)) return false;
            if ((State != other.State) || (Outdated != other.Outdated)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
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
      if (DeviceId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
      }
      if (State != Saltoapis.Nebula.User.V1.ElectronicKey.Types.State.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (Outdated != false) {
        output.WriteRawTag(32);
        output.WriteBool(Outdated);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)State);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(32);
                output.WriteBool(Outdated);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DeviceId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            if (State != Types.State.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            if (Outdated != false) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ElectronicKey other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DeviceId.Length != 0) DeviceId = other.DeviceId;
            if (other.State != Types.State.Unspecified) State = other.State;
            if (other.Outdated != false) Outdated = other.Outdated;
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
          case 24: {
            State = (Saltoapis.Nebula.User.V1.ElectronicKey.Types.State) input.ReadEnum();
            break;
          }
          case 32: {
            Outdated = input.ReadBool();
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
                    case 24:
                        {
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                    case 32:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the ElectronicKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for an electronic key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The electronic key is not assigned to a physical device.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The electronic key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The electronic key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }

        }

    }


}
