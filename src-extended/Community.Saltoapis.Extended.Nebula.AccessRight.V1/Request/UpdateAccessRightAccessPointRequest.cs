namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateAccessRightAccessPoint`][salto.nebula.accessright.v1.AccessRightService.UpdateAccessRightAccessPoint]
    /// </summary>
    public sealed partial class UpdateAccessRightAccessPointRequest : IMessage<UpdateAccessRightAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessRightAccessPointRequest> _parser = new(() => new UpdateAccessRightAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessRightAccessPointRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[16];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateAccessRightAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessRightAccessPointRequest(UpdateAccessRightAccessPointRequest other) : this()
        {
            accessRightAccessPoint_ = other.accessRightAccessPoint_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessRightAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point" field.</summary>
        public const int AccessRightAccessPointFieldNumber = 1;
        private AccessRightAccessPoint accessRightAccessPoint_;
        /// <summary>
        /// The access right's access point resource which replaces the resource on
        /// the server.
        /// </summary>
        public AccessRightAccessPoint AccessRightAccessPoint
        {
            get => accessRightAccessPoint_; set => accessRightAccessPoint_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateAccessRightAccessPointRequest);
        public bool Equals(UpdateAccessRightAccessPointRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRightAccessPoint, other.AccessRightAccessPoint)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRightAccessPoint_ != null) hash ^= AccessRightAccessPoint.GetHashCode();
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
      if (accessRightAccessPoint_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPoint);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateAccessRightAccessPointRequest other)
        {
            if (other == null) return;
            if (other.accessRightAccessPoint_ != null)
            {
                if (accessRightAccessPoint_ == null) AccessRightAccessPoint = new AccessRightAccessPoint();
                AccessRightAccessPoint.MergeFrom(other.AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ == null)
            {
              AccessRightAccessPoint = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPoint();
            }
            input.ReadMessage(AccessRightAccessPoint);
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
                            if (accessRightAccessPoint_ == null) AccessRightAccessPoint = new AccessRightAccessPoint();
                            input.ReadMessage(AccessRightAccessPoint);
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