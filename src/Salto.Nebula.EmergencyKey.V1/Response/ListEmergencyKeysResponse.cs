namespace Salto.Nebula.EmergencyKey.V1.Response
{
    /// <summary>
    /// The response message for [`ListEmergencyKeys`][salto.nebula.emergencykey.v1.EmergencyKeyService.ListEmergencyKeys].
    /// </summary>
    public sealed partial class ListEmergencyKeysResponse : IMessage<ListEmergencyKeysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListEmergencyKeysResponse> _parser = new(() => new ListEmergencyKeysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListEmergencyKeysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListEmergencyKeysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListEmergencyKeysResponse(ListEmergencyKeysResponse other) : this()
        {
            emergencyKeys_ = other.emergencyKeys_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListEmergencyKeysResponse Clone() => new(this);
        /// <summary>Field number for the "emergency_keys" field.</summary>
        public const int EmergencyKeysFieldNumber = 1;
        private static readonly FieldCodec<EmergencyKey> _repeated_emergencyKeys_codec
            = FieldCodec.ForMessage(10, EmergencyKey.Parser);
        private readonly RepeatedField<EmergencyKey> emergencyKeys_ = [];

        /// <summary>
        /// The field name should match the noun `emergency_keys` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<EmergencyKey> EmergencyKeys
        {
            get { return emergencyKeys_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// The token to retrieve the next page of emergency keys.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListEmergencyKeysResponse);
        public bool Equals(ListEmergencyKeysResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!emergencyKeys_.Equals(other.emergencyKeys_) || NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= emergencyKeys_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      emergencyKeys_.WriteTo(output, _repeated_emergencyKeys_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            emergencyKeys_.WriteTo(ref output, _repeated_emergencyKeys_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += emergencyKeys_.CalculateSize(_repeated_emergencyKeys_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListEmergencyKeysResponse other)
        {
            if (other == null) return;
            emergencyKeys_.Add(other.emergencyKeys_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
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
            emergencyKeys_.AddEntriesFrom(input, _repeated_emergencyKeys_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
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
                            emergencyKeys_.AddEntriesFrom(ref input, _repeated_emergencyKeys_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }
}
