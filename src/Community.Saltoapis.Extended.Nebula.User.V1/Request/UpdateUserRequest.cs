namespace Saltoapis.Nebula.User.V1.Request
{
    /// <summary>
    /// The response message for [`UpdateUser`][salto.nebula.user.v1.UserService.UpdateUser]
    /// </summary>
    public sealed partial class UpdateUserRequest : IMessage<UpdateUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateUserRequest> _parser = new(() => new UpdateUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateUserRequest(UpdateUserRequest other) : this()
        {
            user_ = other.user_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateUserRequest Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User user_;

        /// <summary>
        /// The user resource which replaces the resource on the server.
        /// </summary>
        public User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateUserRequest);
        public bool Equals(UpdateUserRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateUserRequest other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User();
                User.MergeFrom(other.User);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            if (user_ == null) User = new User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }


}
