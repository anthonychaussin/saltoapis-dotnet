namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`CreateAccessRightAccessPointGroup`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRightAccessPointGroup]
    /// </summary>
    public sealed partial class CreateAccessRightAccessPointGroupRequest : IMessage<CreateAccessRightAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightAccessPointGroupRequest> _parser = new(() => new CreateAccessRightAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightAccessPointGroupRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[18];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateAccessRightAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightAccessPointGroupRequest(CreateAccessRightAccessPointGroupRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightAccessPointGroup_ = other.accessRightAccessPointGroup_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where the access right's access
        /// point group association is to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "access_right_access_point_group" field.</summary>
        public const int AccessRightAccessPointGroupFieldNumber = 2;
        private AccessRightAccessPointGroup accessRightAccessPointGroup_;
        /// <summary>
        /// The access right's access point group association resource to be created.
        /// Client must not set the `AccessRightAccessPointGroup.name` field.
        /// </summary>
        public AccessRightAccessPointGroup AccessRightAccessPointGroup
        {
            get => accessRightAccessPointGroup_; set => accessRightAccessPointGroup_ = value;}

        public override bool Equals(object other) => Equals(other as CreateAccessRightAccessPointGroupRequest);
        public bool Equals(CreateAccessRightAccessPointGroupRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(AccessRightAccessPointGroup, other.AccessRightAccessPointGroup))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessRightAccessPointGroup_ != null) hash ^= AccessRightAccessPointGroup.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (accessRightAccessPointGroup_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRightAccessPointGroup);
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
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (accessRightAccessPointGroup_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRightAccessPointGroup);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (accessRightAccessPointGroup_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPointGroup);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateAccessRightAccessPointGroupRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.accessRightAccessPointGroup_ != null)
            {
                if (accessRightAccessPointGroup_ == null) AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                AccessRightAccessPointGroup.MergeFrom(other.AccessRightAccessPointGroup);
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
            Parent = input.ReadString();
            break;
          }
          case 18:
          {
            if (accessRightAccessPointGroup_ == null)
            {
              AccessRightAccessPointGroup = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPointGroup();
            }
            input.ReadMessage(AccessRightAccessPointGroup);
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            if (accessRightAccessPointGroup_ == null) AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                            input.ReadMessage(AccessRightAccessPointGroup);
                            break;
                        }
                }
            }
        }
#endif
    }

}