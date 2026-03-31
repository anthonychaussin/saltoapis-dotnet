namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateAccessRightDestination`][salto.nebula.accessright.v1.AccessRightService.UpdateAccessRightDestination]
    /// </summary>
    public sealed partial class UpdateAccessRightDestinationRequest : IMessage<UpdateAccessRightDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessRightDestinationRequest> _parser = new(() => new UpdateAccessRightDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessRightDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[34]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessRightDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessRightDestinationRequest(UpdateAccessRightDestinationRequest other) : this()
        {
            accessRightDestination_ = other.accessRightDestination_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessRightDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "access_right_destination" field.</summary>
        public const int AccessRightDestinationFieldNumber = 1;
        private AccessRightDestination accessRightDestination_;

        /// <summary>
        /// The access right's destination resource which replaces the resource on
        /// the server.
        /// </summary>
        public AccessRightDestination AccessRightDestination
        {
            get { return accessRightDestination_; }
            set
            {
                accessRightDestination_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessRightDestinationRequest);
        public bool Equals(UpdateAccessRightDestinationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRightDestination, other.AccessRightDestination)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRightDestination_ != null) hash ^= AccessRightDestination.GetHashCode();
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
      if (accessRightDestination_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRightDestination);
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
            if (accessRightDestination_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRightDestination);
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
            if (accessRightDestination_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightDestination);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateAccessRightDestinationRequest other)
        {
            if (other == null) return;
            if (other.accessRightDestination_ != null)
            {
                if (accessRightDestination_ == null) AccessRightDestination = new AccessRightDestination();
                AccessRightDestination.MergeFrom(other.AccessRightDestination);
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
            if (accessRightDestination_ == null) {
              AccessRightDestination = new Saltoapis.Nebula.AccessRight.V1.AccessRightDestination();
            }
            input.ReadMessage(AccessRightDestination);
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
                            if (accessRightDestination_ == null) AccessRightDestination = new AccessRightDestination();
                            input.ReadMessage(AccessRightDestination);
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
