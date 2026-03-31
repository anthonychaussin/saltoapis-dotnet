namespace Saltoapis.Nebula.Encoder.V1.Request
{
    /// <summary>
    /// The request message for [CreateEncoder][salto.nebula.encoder.v1.EncoderService.CreateEncoder]
    /// </summary>
    public sealed partial class CreateEncoderRequest : IMessage<CreateEncoderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateEncoderRequest> _parser = new(() => new CreateEncoderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateEncoderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncoderReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateEncoderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateEncoderRequest(CreateEncoderRequest other) : this()
        {
            parent_ = other.parent_;
            encoderId_ = other.encoderId_;
            encoder_ = other.encoder_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateEncoderRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the encoder. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "encoder_id" field.</summary>
        public const int EncoderIdFieldNumber = 2;
        private static readonly string EncoderIdDefaultValue = "";

        private string encoderId_;

        /// <summary>
        /// The encoder ID to use for this encoder. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string EncoderId
        {
            get { return encoderId_ ?? EncoderIdDefaultValue; }
            set
            {
                encoderId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "encoder_id" field is set</summary>
        public bool HasEncoderId
        {
            get { return encoderId_ != null; }
        }

        /// <summary>Clears the value of the "encoder_id" field</summary>
        public void ClearEncoderId()
        {
            encoderId_ = null;
        }

        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 3;
        private Encoder encoder_;

        /// <summary>
        /// The encoder resource to be created. Client must not set the
        /// `Encoder.name` field.
        /// </summary>
        public Encoder Encoder
        {
            get { return encoder_; }
            set
            {
                encoder_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateEncoderRequest);
        public bool Equals(CreateEncoderRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (EncoderId != other.EncoderId)) return false;
            if (!Equals(Encoder, other.Encoder)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasEncoderId) hash ^= EncoderId.GetHashCode();
            if (encoder_ != null) hash ^= Encoder.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (HasEncoderId) {
        output.WriteRawTag(18);
        output.WriteString(EncoderId);
      }
      if (encoder_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Encoder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (HasEncoderId)
            {
                output.WriteRawTag(18);
                output.WriteString(EncoderId);
            }
            if (encoder_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Encoder);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasEncoderId) size += 1 + CodedOutputStream.ComputeStringSize(EncoderId);
            if (encoder_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Encoder);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateEncoderRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasEncoderId) EncoderId = other.EncoderId;
            if (other.encoder_ != null)
            {
                if (encoder_ == null) Encoder = new Encoder();
                Encoder.MergeFrom(other.Encoder);
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            EncoderId = input.ReadString();
            break;
          }
          case 26: {
            if (encoder_ == null) {
              Encoder = new Saltoapis.Nebula.Encoder.V1.Encoder();
            }
            input.ReadMessage(Encoder);
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            EncoderId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (encoder_ == null) Encoder = new Encoder();
                            input.ReadMessage(Encoder);
                            break;
                        }
                }
            }
        }
#endif

    }


}
