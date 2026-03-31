namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// Representation of an app key, belonging to a user
    /// </summary>
    public sealed partial class AppKey : IMessage<AppKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AppKey> _parser = new(() => new AppKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AppKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AppKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AppKey(AppKey other) : this()
        {
            name_ = other.name_;
            state_ = other.state_;
            outdated_ = other.outdated_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AppKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the user's app key. It must have the
        /// format of `installations/*/users/*/app-key`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/app-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 2;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this app key has been assigned or not. This field
        /// cannot be modified using a standard
        /// [`UpdateAppKey`][salto.nebula.user.v1.UserService.UpdateAppKey]
        /// operation. To change the value of this field, you must call
        /// [`AssignAppKey`][salto.nebula.user.v1.UserService.AssignAppKey].
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
        public const int OutdatedFieldNumber = 3;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this app key has pending updates or not.
        /// This field cannot be modified using a standard
        /// [`UpdateAppKey`][salto.nebula.user.v1.UserService.UpdateAppKey]
        /// operation. To change the value of this field, you must call
        /// [`OutdateAppKey`][salto.nebula.user.v1.UserService.OutdateAppKey].
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AppKey);
        public bool Equals(AppKey other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (State != other.State)) return false;
            if (Outdated != other.Outdated) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (State != Saltoapis.Nebula.User.V1.AppKey.Types.State.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (Outdated != false) {
        output.WriteRawTag(24);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)State);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(24);
                output.WriteBool(Outdated);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (State != Types.State.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            if (Outdated != false) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AppKey other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
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
          case 16: {
            State = (Saltoapis.Nebula.User.V1.AppKey.Types.State) input.ReadEnum();
            break;
          }
          case 24: {
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
                    case 16:
                        {
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the AppKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for an app key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The app key is not assigned.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The app key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The app key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }

        }

    }


}
