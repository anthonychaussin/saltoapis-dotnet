namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// Representation of a card key, belonging to a user
    /// </summary>
    public sealed partial class CardKey : IMessage<CardKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CardKey> _parser = new(() => new CardKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CardKey> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => UserReflection.Descriptor.MessageTypes[2];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CardKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CardKey(CardKey other) : this()
        {
            name_ = other.name_;
            uid_ = other.uid_;
            state_ = other.state_;
            outdated_ = other.outdated_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CardKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Output only. Resource name of the user's card key. It must have the
        /// format of `installations/*/users/*/card-key`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/card-key`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "uid" field.</summary>
        public const int UidFieldNumber = 2;
        private string uid_ = "";
        /// <summary>
        /// Unique identifier of the physical card. Length dependent of technology.
        /// Max length for ISO14443-3 is 10 bytes.
        /// </summary>
        public string Uid
        {
            get => uid_; set => uid_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 3;
        private Types.State state_ = Types.State.Unspecified;
        /// <summary>
        /// Indicates whether this card key has been assigned, not assigned or is
        /// active and ready for use. This field cannot be modified using a standard
        /// [`UpdateCardKey`][salto.nebula.user.v1.UserService.UpdateCardKey]
        /// operation. To change the value of this field, you must call
        /// [`EncodeCardKey`][salto.nebula.user.v1.UserService.EncodeCardKey].
        ///
        /// If the value is `NOT_ASSIGNED` it also applies to cases where the
        /// assignation process has been initiated, but not completed.
        /// </summary>
        public Types.State State
        {
            get => state_; set => state_ = value;}
        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 4;
        private bool outdated_;
        /// <summary>
        /// Indicates whether this card key has pending updates or not.
        /// This field cannot be modified using a standard
        /// [`UpdateCardKey`][salto.nebula.user.v1.UserService.UpdateCardKey]
        /// operation. To change the value of this field, you must call
        /// [`OutdateCardKey`][salto.nebula.user.v1.UserService.OutdateCardKey].
        /// </summary>
        public bool Outdated
        {
            get => outdated_; set => outdated_ = value;}

        public override bool Equals(object other) => Equals(other as CardKey);
        public bool Equals(CardKey other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (Uid != other.Uid) || (State != other.State) || (Outdated != other.Outdated)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Uid.Length != 0) hash ^= Uid.GetHashCode();
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
      if (Name.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Uid.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (State != Saltoapis.Nebula.User.V1.CardKey.Types.State.Unspecified)
      {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (Outdated != false)
      {
        output.WriteRawTag(32);
        output.WriteBool(Outdated);
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
            if (Uid.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Uid);
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
            if (Uid.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Uid);
            if (State != Types.State.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            if (Outdated != false) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CardKey other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.Uid.Length != 0) Uid = other.Uid;
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
            Uid = input.ReadString();
            break;
          }
          case 24:
          {
            State = (Saltoapis.Nebula.User.V1.CardKey.Types.State) input.ReadEnum();
            break;
          }
          case 32:
          {
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
                            Uid = input.ReadString();
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
        /// <summary>Container for nested types declared in the CardKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a card key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The card key is not assigned to a physical card.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The card key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The card key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }
        }
    }

}