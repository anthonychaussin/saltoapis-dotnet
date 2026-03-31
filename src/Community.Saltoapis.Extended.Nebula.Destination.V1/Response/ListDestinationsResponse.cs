namespace Saltoapis.Nebula.Destination.V1.Response
{
    /// <summary>
    /// The response message for [`ListDestinations`][salto.nebula.destination.v1.DestinationService.ListDestinations]
    /// </summary>
    public sealed partial class ListDestinationsResponse : IMessage<ListDestinationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDestinationsResponse> _parser = new(() => new ListDestinationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDestinationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDestinationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDestinationsResponse(ListDestinationsResponse other) : this()
        {
            destinations_ = other.destinations_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDestinationsResponse Clone() => new(this);
        /// <summary>Field number for the "destinations" field.</summary>
        public const int DestinationsFieldNumber = 1;
        private static readonly FieldCodec<Destination> _repeated_destinations_codec
            = FieldCodec.ForMessage(10, Destination.Parser);
        private readonly RepeatedField<Destination> destinations_ = [];

        /// <summary>
        /// The field name should match the noun `destinations` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Destination> Destinations
        {
            get { return destinations_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListDestinationsResponse);
        public bool Equals(ListDestinationsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!destinations_.Equals(other.destinations_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= destinations_.GetHashCode();
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
      destinations_.WriteTo(output, _repeated_destinations_codec);
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
            destinations_.WriteTo(ref output, _repeated_destinations_codec);
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
            size += destinations_.CalculateSize(_repeated_destinations_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListDestinationsResponse other)
        {
            if (other == null) return;
            destinations_.Add(other.destinations_);
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
            destinations_.AddEntriesFrom(input, _repeated_destinations_codec);
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
                            destinations_.AddEntriesFrom(ref input, _repeated_destinations_codec);
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
