namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`IngestEncryptedPayloads`][salto.nebula.installation.v1.EncryptedPayloadService.IngestEncryptedPayloads]
    /// </summary>
    public sealed partial class IngestEncryptedPayloadsRequest : IMessage<IngestEncryptedPayloadsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IngestEncryptedPayloadsRequest> _parser = new(() => new IngestEncryptedPayloadsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IngestEncryptedPayloadsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncryptedPayloadReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IngestEncryptedPayloadsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IngestEncryptedPayloadsRequest(IngestEncryptedPayloadsRequest other) : this()
        {
            installation_ = other.installation_;
            encryptedPayloads_ = other.encryptedPayloads_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IngestEncryptedPayloadsRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";

        /// <summary>
        /// The parent installation resource name.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get { return installation_; }
            set
            {
                installation_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "encrypted_payloads" field.</summary>
        public const int EncryptedPayloadsFieldNumber = 2;
        private static readonly FieldCodec<ByteString> _repeated_encryptedPayloads_codec
            = FieldCodec.ForBytes(18);
        private readonly RepeatedField<ByteString> encryptedPayloads_ = [];

        /// <summary>
        /// The encrypted payloads to be ingested.
        /// </summary>
        public RepeatedField<ByteString> EncryptedPayloads
        {
            get { return encryptedPayloads_; }
        }

        public override bool Equals(object other) => Equals(other as IngestEncryptedPayloadsRequest);
        public bool Equals(IngestEncryptedPayloadsRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Installation != other.Installation) || (!encryptedPayloads_.Equals(other.encryptedPayloads_))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            hash ^= encryptedPayloads_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      encryptedPayloads_.WriteTo(output, _repeated_encryptedPayloads_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Installation.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Installation);
            }
            encryptedPayloads_.WriteTo(ref output, _repeated_encryptedPayloads_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            size += encryptedPayloads_.CalculateSize(_repeated_encryptedPayloads_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(IngestEncryptedPayloadsRequest other)
        {
            if (other == null) return;
            if (other.Installation.Length != 0) Installation = other.Installation;
            encryptedPayloads_.Add(other.encryptedPayloads_);
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
            Installation = input.ReadString();
            break;
          }
          case 18: {
            encryptedPayloads_.AddEntriesFrom(input, _repeated_encryptedPayloads_codec);
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
                            Installation = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            encryptedPayloads_.AddEntriesFrom(ref input, _repeated_encryptedPayloads_codec);
                            break;
                        }
                }
            }
        }
#endif

    }


}
