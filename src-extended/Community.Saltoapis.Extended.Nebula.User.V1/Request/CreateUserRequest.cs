namespace Saltoapis.Nebula.User.V1.Request
{
    /// <summary>
    /// The request message for [`CreateUser`][salto.nebula.user.v1.UserService.CreateUser]
    /// </summary>
    public sealed partial class CreateUserRequest : IMessage<CreateUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateUserRequest> _parser = new(() => new CreateUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateUserRequest(CreateUserRequest other) : this()
        {
            parent_ = other.parent_;
            userId_ = other.userId_;
            user_ = other.user_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateUserRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the user is to be created. For
        /// example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "user_id" field.</summary>
        public const int UserIdFieldNumber = 2;
        private static readonly string UserIdDefaultValue = "";

        private string userId_;

        /// <summary>
        /// The user id to use for this user. In case it's empty the server
        /// will autogenerate a unique identifier.
        /// </summary>
        public string UserId
        {
            get { return userId_ ?? UserIdDefaultValue; }
            set
            {
                userId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "user_id" field is set</summary>
        public bool HasUserId
        {
            get { return userId_ != null; }
        }

        /// <summary>Clears the value of the "user_id" field</summary>
        public void ClearUserId()
        {
            userId_ = null;
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 3;
        private User user_;

        /// <summary>
        /// The user resource to be created. Client must not set the `User.name`
        /// field.
        /// </summary>
        public User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateUserRequest);
        public bool Equals(CreateUserRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (UserId != other.UserId)) return false;
            if (!Equals(User, other.User)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasUserId) hash ^= UserId.GetHashCode();
            if (user_ != null) hash ^= User.GetHashCode();
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
      if (HasUserId) {
        output.WriteRawTag(18);
        output.WriteString(UserId);
      }
      if (user_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(User);
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
            if (HasUserId)
            {
                output.WriteRawTag(18);
                output.WriteString(UserId);
            }
            if (user_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(User);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasUserId) size += 1 + CodedOutputStream.ComputeStringSize(UserId);
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateUserRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasUserId) UserId = other.UserId;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User();
                User.MergeFrom(other.User);
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
            UserId = input.ReadString();
            break;
          }
          case 26: {
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
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
                            UserId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (user_ == null) User = new User();
                            input.ReadMessage(User);
                            break;
                        }
                }
            }
        }
#endif

    }


}
