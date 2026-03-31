namespace Saltoapis.Nebula.DigitalKey.V1.Response
{
    /// <summary>
    /// The request message for [`ListDigitalKeyAccessPoints`][salto.nebula.digitalkey.v1.DigitalKeyService.ListDigitalKeyAccessPoints]
    /// </summary>
    public sealed partial class ListDigitalKeyAccessPointsResponse : IMessage<ListDigitalKeyAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDigitalKeyAccessPointsResponse> _parser = new(() => new ListDigitalKeyAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDigitalKeyAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDigitalKeyAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDigitalKeyAccessPointsResponse(ListDigitalKeyAccessPointsResponse other) : this()
        {
            digitalKeyAccessPoints_ = other.digitalKeyAccessPoints_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDigitalKeyAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "digital_key_access_points" field.</summary>
        public const int DigitalKeyAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<DigitalKeyAccessPoint> _repeated_digitalKeyAccessPoints_codec
            = FieldCodec.ForMessage(10, DigitalKeyAccessPoint.Parser);
        private readonly RepeatedField<DigitalKeyAccessPoint> digitalKeyAccessPoints_ = [];

        /// <summary>
        /// The field name should match the noun `digital_key_access_points` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<DigitalKeyAccessPoint> DigitalKeyAccessPoints
        {
            get { return digitalKeyAccessPoints_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// Note: this field is not being used in the current implementation. It always returns an empty string.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListDigitalKeyAccessPointsResponse);
        public bool Equals(ListDigitalKeyAccessPointsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!digitalKeyAccessPoints_.Equals(other.digitalKeyAccessPoints_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= digitalKeyAccessPoints_.GetHashCode();
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
      digitalKeyAccessPoints_.WriteTo(output, _repeated_digitalKeyAccessPoints_codec);
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
            digitalKeyAccessPoints_.WriteTo(ref output, _repeated_digitalKeyAccessPoints_codec);
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
            size += digitalKeyAccessPoints_.CalculateSize(_repeated_digitalKeyAccessPoints_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListDigitalKeyAccessPointsResponse other)
        {
            if (other == null) return;
            digitalKeyAccessPoints_.Add(other.digitalKeyAccessPoints_);
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
            digitalKeyAccessPoints_.AddEntriesFrom(input, _repeated_digitalKeyAccessPoints_codec);
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
                            digitalKeyAccessPoints_.AddEntriesFrom(ref input, _repeated_digitalKeyAccessPoints_codec);
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
