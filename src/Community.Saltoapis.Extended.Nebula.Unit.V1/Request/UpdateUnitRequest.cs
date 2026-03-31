namespace Saltoapis.Nebula.Unit.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateUnit`][salto.nebula.unit.v1.UnitService.UpdateUnit]
    /// </summary>
    public sealed partial class UpdateUnitRequest : IMessage<UpdateUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateUnitRequest> _parser = new(() => new UpdateUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateUnitRequest(UpdateUnitRequest other) : this()
        {
            unit_ = other.unit_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateUnitRequest Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private Unit unit_;

        /// <summary>
        /// The unit resource which replaces the resource on the server.
        /// </summary>
        public Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateUnitRequest);
        public bool Equals(UpdateUnitRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Unit, other.Unit)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (unit_ != null) hash ^= Unit.GetHashCode();
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
      if (unit_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unit);
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
            if (unit_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Unit);
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
            if (unit_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateUnitRequest other)
        {
            if (other == null) return;
            if (other.unit_ != null)
            {
                if (unit_ == null) Unit = new Unit();
                Unit.MergeFrom(other.Unit);
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
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
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
                            if (unit_ == null) Unit = new Unit();
                            input.ReadMessage(Unit);
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
