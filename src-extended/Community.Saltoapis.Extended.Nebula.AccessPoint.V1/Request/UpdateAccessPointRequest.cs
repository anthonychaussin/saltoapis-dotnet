namespace Saltoapis.Nebula.AccessPoint.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateAccessPoint`][salto.nebula.accesspoint.v1.AccessPointService.UpdateAccessPoint]
    /// </summary>
    public sealed partial class UpdateAccessPointRequest : IMessage<UpdateAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessPointRequest> _parser = new(() => new UpdateAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessPointRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessPointReflection.Descriptor.MessageTypes[5];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessPointRequest(UpdateAccessPointRequest other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint accessPoint_;
        /// <summary>
        /// The access point resource which replaces the resource on the server.
        /// </summary>
        public AccessPoint AccessPoint
        {
            get => accessPoint_; set => accessPoint_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateAccessPointRequest);
        public bool Equals(UpdateAccessPointRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPoint, other.AccessPoint)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
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
      if (accessPoint_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
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
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
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
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateAccessPointRequest other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
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
            if (accessPoint_ == null)
            {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint();
                            input.ReadMessage(AccessPoint);
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