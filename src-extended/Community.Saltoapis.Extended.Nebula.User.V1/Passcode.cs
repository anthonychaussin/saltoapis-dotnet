namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// Representation of a passcode, belonging to a user
    /// </summary>
    public sealed partial class Passcode : IMessage<Passcode>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Passcode> _parser = new(() => new Passcode());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Passcode> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => UserReflection.Descriptor.MessageTypes[5];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public Passcode()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Passcode(Passcode other) : this()
        {
            name_ = other.name_;
            state_ = other.state_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Passcode Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Output only. Resource name of the user's passcode. It must have the
        /// format of `installations/*/users/*/passcode`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/passcode`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 2;
        private Types.State state_ = Types.State.Unspecified;
        /// <summary>
        /// Indicates whether this passcode has been assigned, not assigned or is
        /// active and ready for use. This field cannot be modified using a standard
        /// passcode update operation. To change the value of this field, you must
        /// call
        /// [`AssignPasscode`][salto.nebula.user.v1.UserService.AssignPasscode].
        ///
        /// If the value is `NOT_ASSIGNED` it also applies to cases where the
        /// assignation process has been initiated, but not completed.
        /// </summary>
        public Types.State State
        {
            get => state_; set => state_ = value;}

        public override bool Equals(object other) => Equals(other as Passcode);
        public bool Equals(Passcode other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (State != other.State)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
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
      if (State != Saltoapis.Nebula.User.V1.Passcode.Types.State.Unspecified)
      {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)State);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (State != Types.State.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Passcode other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.State != Types.State.Unspecified) State = other.State;
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
          case 16:
          {
            State = (Saltoapis.Nebula.User.V1.Passcode.Types.State) input.ReadEnum();
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
                }
            }
        }
#endif
        /// <summary>Container for nested types declared in the Passcode message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a passcode.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The passcode is not assigned.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The passcode is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 2,
            }
        }
    }

}