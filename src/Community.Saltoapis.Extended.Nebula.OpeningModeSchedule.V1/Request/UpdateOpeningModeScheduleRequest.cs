namespace Saltoapis.Nebula.OpeningModeSchedule.V1.Request
{
    /// <summary>
    /// The response message for [`UpdateOpeningModeSchedule`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.UpdateOpeningModeSchedule]
    /// </summary>
    public sealed partial class UpdateOpeningModeScheduleRequest : IMessage<UpdateOpeningModeScheduleRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateOpeningModeScheduleRequest> _parser = new(() => new UpdateOpeningModeScheduleRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateOpeningModeScheduleRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateOpeningModeScheduleRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateOpeningModeScheduleRequest(UpdateOpeningModeScheduleRequest other) : this()
        {
            openingModeSchedule_ = other.openingModeSchedule_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateOpeningModeScheduleRequest Clone() => new(this);
        /// <summary>Field number for the "opening_mode_schedule" field.</summary>
        public const int OpeningModeScheduleFieldNumber = 1;
        private OpeningModeSchedule openingModeSchedule_;

        /// <summary>
        /// The opening mode schedule resource which replaces the resource on the server.
        /// </summary>
        public OpeningModeSchedule OpeningModeSchedule
        {
            get { return openingModeSchedule_; }
            set
            {
                openingModeSchedule_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateOpeningModeScheduleRequest);
        public bool Equals(UpdateOpeningModeScheduleRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(OpeningModeSchedule, other.OpeningModeSchedule)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (openingModeSchedule_ != null) hash ^= OpeningModeSchedule.GetHashCode();
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
      if (openingModeSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OpeningModeSchedule);
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
            if (openingModeSchedule_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(OpeningModeSchedule);
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
            if (openingModeSchedule_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(OpeningModeSchedule);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateOpeningModeScheduleRequest other)
        {
            if (other == null) return;
            if (other.openingModeSchedule_ != null)
            {
                if (openingModeSchedule_ == null) OpeningModeSchedule = new OpeningModeSchedule();
                OpeningModeSchedule.MergeFrom(other.OpeningModeSchedule);
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
            if (openingModeSchedule_ == null) {
              OpeningModeSchedule = new Saltoapis.Nebula.OpeningModeSchedule.V1.OpeningModeSchedule();
            }
            input.ReadMessage(OpeningModeSchedule);
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
                            if (openingModeSchedule_ == null) OpeningModeSchedule = new OpeningModeSchedule();
                            input.ReadMessage(OpeningModeSchedule);
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
