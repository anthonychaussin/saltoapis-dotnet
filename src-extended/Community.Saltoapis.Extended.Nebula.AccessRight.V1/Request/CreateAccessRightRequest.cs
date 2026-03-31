namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`CreateAccessRight`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRight]
    /// </summary>
    public sealed partial class CreateAccessRightRequest : IMessage<CreateAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightRequest> _parser = new(() => new CreateAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightRequest(CreateAccessRightRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightId_ = other.accessRightId_;
            accessRight_ = other.accessRight_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right is to be
        /// created. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_right_id" field.</summary>
        public const int AccessRightIdFieldNumber = 2;
        private static readonly string AccessRightIdDefaultValue = "";

        private string accessRightId_;

        /// <summary>
        /// The access right ID to use for this access right. In case it's
        /// empty the server will autogenerate a unique identifier.
        /// </summary>
        public string AccessRightId
        {
            get { return accessRightId_ ?? AccessRightIdDefaultValue; }
            set
            {
                accessRightId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "access_right_id" field is set</summary>
        public bool HasAccessRightId
        {
            get { return accessRightId_ != null; }
        }

        /// <summary>Clears the value of the "access_right_id" field</summary>
        public void ClearAccessRightId()
        {
            accessRightId_ = null;
        }

        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 3;
        private AccessRight accessRight_;

        /// <summary>
        /// The access right resource to be created. Client must not set the
        /// `AccessRight.name` field.
        /// </summary>
        public AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessRightRequest);
        public bool Equals(CreateAccessRightRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (AccessRightId != other.AccessRightId)) return false;
            if (!Equals(AccessRight, other.AccessRight)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasAccessRightId) hash ^= AccessRightId.GetHashCode();
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (HasAccessRightId) {
        output.WriteRawTag(18);
        output.WriteString(AccessRightId);
      }
      if (accessRight_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AccessRight);
      }
      if (_unknownFields != null) {
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
            if (HasAccessRightId)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessRightId);
            }
            if (accessRight_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(AccessRight);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasAccessRightId) size += 1 + CodedOutputStream.ComputeStringSize(AccessRightId);
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateAccessRightRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasAccessRightId) AccessRightId = other.AccessRightId;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            AccessRightId = input.ReadString();
            break;
          }
          case 26: {
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
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
                            AccessRightId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (accessRight_ == null) AccessRight = new AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                }
            }
        }
#endif

    }


}
