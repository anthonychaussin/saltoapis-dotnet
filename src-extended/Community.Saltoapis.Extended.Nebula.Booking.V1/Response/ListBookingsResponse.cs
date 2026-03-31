namespace Saltoapis.Nebula.Booking.V1.Response
{
    /// <summary>
    /// The response message for [ListBookings][salto.nebula.booking.v1.BookingService.ListBookings]
    /// </summary>
    public sealed partial class ListBookingsResponse : IMessage<ListBookingsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListBookingsResponse> _parser = new(() => new ListBookingsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListBookingsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => BookingReflection.Descriptor.MessageTypes[4];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListBookingsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListBookingsResponse(ListBookingsResponse other) : this()
        {
            bookings_ = other.bookings_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListBookingsResponse Clone() => new(this);
        /// <summary>Field number for the "bookings" field.</summary>
        public const int BookingsFieldNumber = 1;
        private static readonly FieldCodec<Booking> _repeated_bookings_codec
            = FieldCodec.ForMessage(10, Booking.Parser);
        private readonly RepeatedField<Booking> bookings_ = [];
        /// <summary>
        /// The field name should match the noun `bookings` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Booking> Bookings
        {
            get => bookings_;}
        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get => nextPageToken_; set => nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as ListBookingsResponse);
        public bool Equals(ListBookingsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!bookings_.Equals(other.bookings_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= bookings_.GetHashCode();
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
      bookings_.WriteTo(output, _repeated_bookings_codec);
      if (NextPageToken.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
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
            bookings_.WriteTo(ref output, _repeated_bookings_codec);
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
            size += bookings_.CalculateSize(_repeated_bookings_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListBookingsResponse other)
        {
            if (other == null) return;
            bookings_.Add(other.bookings_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
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
            bookings_.AddEntriesFrom(input, _repeated_bookings_codec);
            break;
          }
          case 18:
          {
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
                            bookings_.AddEntriesFrom(ref input, _repeated_bookings_codec);
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