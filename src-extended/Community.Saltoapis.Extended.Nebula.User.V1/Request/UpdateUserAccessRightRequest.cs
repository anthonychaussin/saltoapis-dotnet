namespace Saltoapis.Nebula.User.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateUserAccessRight`][salto.nebula.user.v1.UserService.UpdateUserAccessRight]
    /// </summary>
    public sealed partial class UpdateUserAccessRightRequest : IMessage<UpdateUserAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateUserAccessRightRequest> _parser = new(() => new UpdateUserAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateUserAccessRightRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => UserReflection.Descriptor.MessageTypes[23];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateUserAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateUserAccessRightRequest(UpdateUserAccessRightRequest other) : this()
        {
            userAccessRight_ = other.userAccessRight_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateUserAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "user_access_right" field.</summary>
        public const int UserAccessRightFieldNumber = 1;
        private UserAccessRight userAccessRight_;
        /// <summary>
        /// The user's access right resource which replaces the resource on the
        /// server.
        /// </summary>
        public UserAccessRight UserAccessRight
        {
            get => userAccessRight_; set => userAccessRight_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateUserAccessRightRequest);
        public bool Equals(UpdateUserAccessRightRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(UserAccessRight, other.UserAccessRight)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (userAccessRight_ != null) hash ^= UserAccessRight.GetHashCode();
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
      if (userAccessRight_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(UserAccessRight);
      }
      if (updateMask_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
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
            if (userAccessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(UserAccessRight);
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
            if (userAccessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UserAccessRight);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateUserAccessRightRequest other)
        {
            if (other == null) return;
            if (other.userAccessRight_ != null)
            {
                if (userAccessRight_ == null) UserAccessRight = new UserAccessRight();
                UserAccessRight.MergeFrom(other.UserAccessRight);
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
            if (userAccessRight_ == null)
            {
              UserAccessRight = new Saltoapis.Nebula.User.V1.UserAccessRight();
            }
            input.ReadMessage(UserAccessRight);
            break;
          }
          case 18:
          {
            if (updateMask_ == null)
            {
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
                            if (userAccessRight_ == null) UserAccessRight = new UserAccessRight();
                            input.ReadMessage(UserAccessRight);
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