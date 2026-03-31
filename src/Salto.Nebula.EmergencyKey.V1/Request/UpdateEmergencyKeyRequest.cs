namespace Salto.Nebula.EmergencyKey.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateEmergencyKey`][salto.nebula.emergencykey.v1.EmergencyKeyService.UpdateEmergencyKey].
    /// </summary>
    public sealed partial class UpdateEmergencyKeyRequest : IMessage<UpdateEmergencyKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEmergencyKeyRequest> _parser = new(() => new UpdateEmergencyKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEmergencyKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEmergencyKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEmergencyKeyRequest(UpdateEmergencyKeyRequest other) : this()
        {
            emergencyKey_ = other.emergencyKey_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEmergencyKeyRequest Clone() => new(this);
        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 1;
        private EmergencyKey emergencyKey_;

        /// <summary>
        /// The emergency key resource which replaces the resource on the server.
        /// </summary>
        public EmergencyKey EmergencyKey
        {
            get { return emergencyKey_; }
            set
            {
                emergencyKey_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateEmergencyKeyRequest);
        public bool Equals(UpdateEmergencyKeyRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(EmergencyKey, other.EmergencyKey) || !Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (emergencyKey_ != null) hash ^= EmergencyKey.GetHashCode();
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
      if (emergencyKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EmergencyKey);
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
            if (emergencyKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(EmergencyKey);
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
            if (emergencyKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateEmergencyKeyRequest other)
        {
            if (other == null) return;
            if (other.emergencyKey_ != null)
            {
                if (emergencyKey_ == null) EmergencyKey = new EmergencyKey();
                EmergencyKey.MergeFrom(other.EmergencyKey);
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
            if (emergencyKey_ == null) {
              EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            }
            input.ReadMessage(EmergencyKey);
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
                            input.ReadMessage(EmergencyKey ?? new EmergencyKey());
                            break;
                        }
                    case 18:
                        {
                            input.ReadMessage(UpdateMask ?? new Google.Protobuf.WellKnownTypes.FieldMask());
                            break;
                        }
                }
            }
        }
#endif

    }
}
