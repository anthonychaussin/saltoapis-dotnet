namespace Saltoapis.Nebula.AccessPointGroup.V1.Request
{
    /// <summary>
    /// The request message for [`CreateAccessPointGroup`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.CreateAccessPointGroup]
    /// </summary>
    public sealed partial class CreateAccessPointGroupRequest : IMessage<CreateAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessPointGroupRequest> _parser = new(() => new CreateAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessPointGroupRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessPointGroupReflection.Descriptor.MessageTypes[2];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessPointGroupRequest(CreateAccessPointGroupRequest other) : this()
        {
            parent_ = other.parent_;
            accessPointGroupId_ = other.accessPointGroupId_;
            accessPointGroup_ = other.accessPointGroup_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where to create the access point
        /// group. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "access_point_group_id" field.</summary>
        public const int AccessPointGroupIdFieldNumber = 2;
        private static readonly string AccessPointGroupIdDefaultValue = "";

        private string accessPointGroupId_;
        /// <summary>
        /// The access point group ID to use for this access point group. In
        /// case it's empty the server will autogenerate a unique identifier.
        /// </summary>
        public string AccessPointGroupId
        {
            get => accessPointGroupId_ ?? AccessPointGroupIdDefaultValue; set => accessPointGroupId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "access_point_group_id" field is set</summary>
        public bool HasAccessPointGroupId => accessPointGroupId_ != null;
        /// <summary>Clears the value of the "access_point_group_id" field</summary>
        public void ClearAccessPointGroupId() => accessPointGroupId_ = null;
        /// <summary>Field number for the "access_point_group" field.</summary>
        public const int AccessPointGroupFieldNumber = 3;
        private AccessPointGroup accessPointGroup_;
        /// <summary>
        /// The access point group resource to be created. Client must not set the
        /// `AccessPointGroup.name` field.
        /// </summary>
        public AccessPointGroup AccessPointGroup
        {
            get => accessPointGroup_; set => accessPointGroup_ = value;}

        public override bool Equals(object other) => Equals(other as CreateAccessPointGroupRequest);
        public bool Equals(CreateAccessPointGroupRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (AccessPointGroupId != other.AccessPointGroupId) || !Equals(AccessPointGroup, other.AccessPointGroup)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasAccessPointGroupId) hash ^= AccessPointGroupId.GetHashCode();
            if (accessPointGroup_ != null) hash ^= AccessPointGroup.GetHashCode();
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
      if (HasAccessPointGroupId)
      {
        output.WriteRawTag(18);
        output.WriteString(AccessPointGroupId);
      }
      if (accessPointGroup_ != null)
      {
        output.WriteRawTag(26);
        output.WriteMessage(AccessPointGroup);
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
            if (HasAccessPointGroupId)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessPointGroupId);
            }
            if (accessPointGroup_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(AccessPointGroup);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasAccessPointGroupId) size += 1 + CodedOutputStream.ComputeStringSize(AccessPointGroupId);
            if (accessPointGroup_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroup);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateAccessPointGroupRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasAccessPointGroupId) AccessPointGroupId = other.AccessPointGroupId;
            if (other.accessPointGroup_ != null)
            {
                if (accessPointGroup_ == null) AccessPointGroup = new AccessPointGroup();
                AccessPointGroup.MergeFrom(other.AccessPointGroup);
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
            AccessPointGroupId = input.ReadString();
            break;
          }
          case 26:
          {
            if (accessPointGroup_ == null)
            {
              AccessPointGroup = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroup();
            }
            input.ReadMessage(AccessPointGroup);
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
                            AccessPointGroupId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (accessPointGroup_ == null) AccessPointGroup = new AccessPointGroup();
                            input.ReadMessage(AccessPointGroup);
                            break;
                        }
                }
            }
        }
#endif
    }

}