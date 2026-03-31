namespace Saltoapis.Nebula.Encoder.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateEncoderFirmware`][salto.nebula.encoder.v1.EncoderService.UpdateEncoderFirmware]
    /// </summary>
    public sealed partial class UpdateEncoderFirmwareRequest : IMessage<UpdateEncoderFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEncoderFirmwareRequest> _parser = new(() => new UpdateEncoderFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEncoderFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEncoderFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEncoderFirmwareRequest(UpdateEncoderFirmwareRequest other) : this()
        {
            encoder_ = other.encoder_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEncoderFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 1;
        private string encoder_ = "";

        /// <summary>
        /// The resource name of the encoder whose firmware will be updated. For
        /// example:
        /// `installations/surelock-homes-hq/encoders/conan-doyle`.
        /// </summary>
        public string Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateEncoderFirmwareRequest);
        public bool Equals(UpdateEncoderFirmwareRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (Encoder != other.Encoder) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Encoder.Length != 0) hash ^= Encoder.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Encoder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Encoder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Encoder.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Encoder);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Encoder.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateEncoderFirmwareRequest other)
        {
            if (other == null) return;
            if (other.Encoder.Length != 0) Encoder = other.Encoder;
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
            Encoder = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
