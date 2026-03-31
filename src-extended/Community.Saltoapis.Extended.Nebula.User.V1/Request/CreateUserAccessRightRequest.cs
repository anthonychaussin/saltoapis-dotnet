namespace Saltoapis.Nebula.User.V1.Request
{
    /// <summary>
    /// The request message for [`CreateUserAccessRight`][salto.nebula.user.v1.UserService.CreateUserAccessRight]
    /// </summary>
    public sealed partial class CreateUserAccessRightRequest : IMessage<CreateUserAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateUserAccessRightRequest> _parser = new(() => new CreateUserAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateUserAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateUserAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateUserAccessRightRequest(CreateUserAccessRightRequest other) : this()
        {
            parent_ = other.parent_;
            userAccessRight_ = other.userAccessRight_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateUserAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the users's access right
        /// association is to be created. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "user_access_right" field.</summary>
        public const int UserAccessRightFieldNumber = 2;
        private UserAccessRight userAccessRight_;

        /// <summary>
        /// The user's access right association resource to be created. Client must
        /// not set the `UserAccessRight.name` field.
        /// </summary>
        public UserAccessRight UserAccessRight
        {
            get { return userAccessRight_; }
            set
            {
                userAccessRight_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateUserAccessRightRequest);
        public bool Equals(CreateUserAccessRightRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(UserAccessRight, other.UserAccessRight))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (userAccessRight_ != null) hash ^= UserAccessRight.GetHashCode();
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
      if (userAccessRight_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserAccessRight);
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
            if (userAccessRight_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UserAccessRight);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (userAccessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UserAccessRight);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateUserAccessRightRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.userAccessRight_ != null)
            {
                if (userAccessRight_ == null) UserAccessRight = new UserAccessRight();
                UserAccessRight.MergeFrom(other.UserAccessRight);
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
            if (userAccessRight_ == null) {
              UserAccessRight = new Saltoapis.Nebula.User.V1.UserAccessRight();
            }
            input.ReadMessage(UserAccessRight);
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
                            if (userAccessRight_ == null) UserAccessRight = new UserAccessRight();
                            input.ReadMessage(UserAccessRight);
                            break;
                        }
                }
            }
        }
#endif

    }


}
