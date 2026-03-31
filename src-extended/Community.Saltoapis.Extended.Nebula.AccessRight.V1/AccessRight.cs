namespace Saltoapis.Nebula.AccessRight.V1
{
    /// <summary>
    /// The access right object
    /// </summary>
    public sealed partial class AccessRight : IMessage<AccessRight>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRight> _parser = new(() => new AccessRight());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRight> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRight()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRight(AccessRight other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            schedules_ = other.schedules_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRight Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the access right. It must have the format
        /// of `installations/*/access-rights/*`. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
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
        /// Display name of the access right.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "schedules" field.</summary>
        public const int SchedulesFieldNumber = 5;
        private static readonly FieldCodec<Type.Schedule> _repeated_schedules_codec
            = FieldCodec.ForMessage(42, Type.Schedule.Parser);
        private readonly RepeatedField<Type.Schedule> schedules_ = [];

        /// <summary>
        /// Schedules in which this access right is applied.
        /// </summary>
        public RepeatedField<Type.Schedule> Schedules
        {
            get { return schedules_; }
        }

        public override bool Equals(object other) => Equals(other as AccessRight);
        public bool Equals(AccessRight other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName)) return false;
            if (!schedules_.Equals(other.schedules_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            hash ^= schedules_.GetHashCode();
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
      schedules_.WriteTo(output, _repeated_schedules_codec);
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
            schedules_.WriteTo(ref output, _repeated_schedules_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            size += schedules_.CalculateSize(_repeated_schedules_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRight other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            schedules_.Add(other.schedules_);
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
          case 42: {
            schedules_.AddEntriesFrom(input, _repeated_schedules_codec);
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
                    case 42:
                        {
                            schedules_.AddEntriesFrom(ref input, _repeated_schedules_codec);
                            break;
                        }
                }
            }
        }
#endif

    }
}
