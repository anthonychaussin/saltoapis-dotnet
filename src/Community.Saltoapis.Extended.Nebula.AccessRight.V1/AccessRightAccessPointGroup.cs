namespace Saltoapis.Nebula.AccessRight.V1
{
    /// <summary>
    /// The access right's access point group association
    /// </summary>
    public sealed partial class AccessRightAccessPointGroup : IMessage<AccessRightAccessPointGroup>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightAccessPointGroup> _parser = new(() => new AccessRightAccessPointGroup());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightAccessPointGroup> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightAccessPointGroup()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightAccessPointGroup(AccessRightAccessPointGroup other) : this()
        {
            name_ = other.name_;
            accessPointGroup_ = other.accessPointGroup_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightAccessPointGroup Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the access right's access point group association. It
        /// must have the format of
        /// `installations/*/access-rights/*/access-point-groups/*`. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/access-point-groups/common-accesses`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point_group" field.</summary>
        public const int AccessPointGroupFieldNumber = 2;
        private string accessPointGroup_ = "";

        /// <summary>
        /// The access point group resource name to bind as an association to the
        /// parent access right. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string AccessPointGroup
        {
            get { return accessPointGroup_; }
            set
            {
                accessPointGroup_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the associated entity. In this case an access point group.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightAccessPointGroup);
        public bool Equals(AccessRightAccessPointGroup other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (AccessPointGroup != other.AccessPointGroup)) return false;
            if (DisplayName != other.DisplayName) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (AccessPointGroup.Length != 0) hash ^= AccessPointGroup.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (AccessPointGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessPointGroup);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
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
            if (AccessPointGroup.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessPointGroup);
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
            if (AccessPointGroup.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccessPointGroup);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightAccessPointGroup other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.AccessPointGroup.Length != 0) AccessPointGroup = other.AccessPointGroup;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
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
            AccessPointGroup = input.ReadString();
            break;
          }
          case 26: {
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
                            AccessPointGroup = input.ReadString();
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
