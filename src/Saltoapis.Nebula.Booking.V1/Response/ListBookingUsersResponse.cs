using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Booking.V1.Response
{
    /// <summary>
    /// The response message for [`ListBookingUsers`][salto.nebula.booking.v1.BookingService.ListBookingUsers]
    /// </summary>
    public sealed partial class ListBookingUsersResponse : IMessage<ListBookingUsersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListBookingUsersResponse> _parser = new(() => new ListBookingUsersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListBookingUsersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListBookingUsersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListBookingUsersResponse(ListBookingUsersResponse other) : this()
        {
            bookingUsers_ = other.bookingUsers_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListBookingUsersResponse Clone() => new(this);
        /// <summary>Field number for the "booking_users" field.</summary>
        public const int BookingUsersFieldNumber = 1;
        private static readonly FieldCodec<BookingUser> _repeated_bookingUsers_codec
            = FieldCodec.ForMessage(10, BookingUser.Parser);
        private readonly RepeatedField<BookingUser> bookingUsers_ = [];

        /// <summary>
        /// The field name should match the noun `booking_users` in the
        /// method name. There will be a maximum number of items returned based on
        /// the `page_size` field in the request.
        /// </summary>
        public RepeatedField<BookingUser> BookingUsers
        {
            get { return bookingUsers_; }
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

        public override bool Equals(object other) => Equals(other as ListBookingUsersResponse);
        public bool Equals(ListBookingUsersResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!bookingUsers_.Equals(other.bookingUsers_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= bookingUsers_.GetHashCode();
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
      bookingUsers_.WriteTo(output, _repeated_bookingUsers_codec);
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
            bookingUsers_.WriteTo(ref output, _repeated_bookingUsers_codec);
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
            size += bookingUsers_.CalculateSize(_repeated_bookingUsers_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListBookingUsersResponse other)
        {
            if (other == null) return;
            bookingUsers_.Add(other.bookingUsers_);
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
            bookingUsers_.AddEntriesFrom(input, _repeated_bookingUsers_codec);
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
                            bookingUsers_.AddEntriesFrom(ref input, _repeated_bookingUsers_codec);
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
