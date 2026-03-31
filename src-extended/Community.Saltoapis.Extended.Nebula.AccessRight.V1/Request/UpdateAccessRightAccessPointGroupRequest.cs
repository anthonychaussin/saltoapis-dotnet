namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateAccessRightAccessPointGroup`][salto.nebula.accessright.v1.AccessRightService.UpdateAccessRightAccessPointGroup]
    /// </summary>
    public sealed partial class UpdateAccessRightAccessPointGroupRequest : IMessage<UpdateAccessRightAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessRightAccessPointGroupRequest> _parser = new(() => new UpdateAccessRightAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessRightAccessPointGroupRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[24];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateAccessRightAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessRightAccessPointGroupRequest(UpdateAccessRightAccessPointGroupRequest other) : this()
        {
            accessRightAccessPointGroup_ = other.accessRightAccessPointGroup_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessRightAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point_group" field.</summary>
        public const int AccessRightAccessPointGroupFieldNumber = 1;
        private AccessRightAccessPointGroup accessRightAccessPointGroup_;
        /// <summary>
        /// The access right's access point group resource which replaces the
        /// resource on the server.
        /// </summary>
        public AccessRightAccessPointGroup AccessRightAccessPointGroup
        {
            get => accessRightAccessPointGroup_; set => accessRightAccessPointGroup_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateAccessRightAccessPointGroupRequest);
        public bool Equals(UpdateAccessRightAccessPointGroupRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRightAccessPointGroup, other.AccessRightAccessPointGroup)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRightAccessPointGroup_ != null) hash ^= AccessRightAccessPointGroup.GetHashCode();
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
      if (accessRightAccessPointGroup_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPointGroup);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateAccessRightAccessPointGroupRequest other)
        {
            if (other == null) return;
            if (other.accessRightAccessPointGroup_ != null)
            {
                if (accessRightAccessPointGroup_ == null) AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                AccessRightAccessPointGroup.MergeFrom(other.AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ == null)
            {
              AccessRightAccessPointGroup = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPointGroup();
            }
            input.ReadMessage(AccessRightAccessPointGroup);
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
                            if (accessRightAccessPointGroup_ == null) AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                            input.ReadMessage(AccessRightAccessPointGroup);
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