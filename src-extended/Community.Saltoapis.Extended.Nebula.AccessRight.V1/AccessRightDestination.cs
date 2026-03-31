namespace Saltoapis.Nebula.AccessRight.V1
{
    /// <summary>
    /// The access right's destination association
    /// </summary>
    public sealed partial class AccessRightDestination : IMessage<AccessRightDestination>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightDestination> _parser = new(() => new AccessRightDestination());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightDestination> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[3];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public AccessRightDestination()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightDestination(AccessRightDestination other) : this()
        {
            name_ = other.name_;
            destination_ = other.destination_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightDestination Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Resource name of the access right's destination association. It must
        /// have the format of `installations/*/access-rights/*/destinations/*`.
        /// For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/destinations/elevator-floor-5`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "destination" field.</summary>
        public const int DestinationFieldNumber = 2;
        private string destination_ = "";
        /// <summary>
        /// The destination resource name to bind as an association to the parent
        /// access right. For example:
        /// `installations/surelock-homes-hq/destinations/elevator-floor-5`.
        /// </summary>
        public string Destination
        {
            get => destination_; set => destination_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the associated entity. In this case a destination.
        /// </summary>
        public string DisplayName
        {
            get => displayName_; set => displayName_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as AccessRightDestination);
        public bool Equals(AccessRightDestination other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (Destination != other.Destination) || DisplayName != other.DisplayName) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Destination.Length != 0) hash ^= Destination.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (Destination.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(Destination);
      }
      if (DisplayName.Length != 0)
      {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
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
            if (Destination.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Destination);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DisplayName);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (Destination.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Destination);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightDestination other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.Destination.Length != 0) Destination = other.Destination;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
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
            Destination = input.ReadString();
            break;
          }
          case 26:
          {
            DisplayName = input.ReadString();
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
                            Destination = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}