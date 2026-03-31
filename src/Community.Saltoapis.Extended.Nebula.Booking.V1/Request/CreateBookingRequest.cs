namespace Saltoapis.Nebula.Booking.V1.Request
{
    /// <summary>
    /// The request message for [CreateBooking][salto.nebula.booking.v1.BookingService.CreateBooking]
    /// </summary>
    public sealed partial class CreateBookingRequest : IMessage<CreateBookingRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateBookingRequest> _parser = new(() => new CreateBookingRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateBookingRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateBookingRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateBookingRequest(CreateBookingRequest other) : this()
        {
            parent_ = other.parent_;
            bookingId_ = other.bookingId_;
            booking_ = other.booking_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateBookingRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource under which the booking is created. For
        /// example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "booking_id" field.</summary>
        public const int BookingIdFieldNumber = 2;
        private readonly static string BookingIdDefaultValue = "";

        private string bookingId_;

        /// <summary>
        /// The booking ID to use for this booking. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string BookingId
        {
            get { return bookingId_ ?? BookingIdDefaultValue; }
            set
            {
                bookingId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "booking_id" field is set</summary>
        public bool HasBookingId
        {
            get { return bookingId_ != null; }
        }

        /// <summary>Clears the value of the "booking_id" field</summary>
        public void ClearBookingId()
        {
            bookingId_ = null;
        }

        /// <summary>Field number for the "booking" field.</summary>
        public const int BookingFieldNumber = 3;
        private Booking booking_;

        /// <summary>
        /// The booking resource to be created. Client must not set the
        /// `Booking.name` field.
        /// </summary>
        public Booking Booking
        {
            get { return booking_; }
            set
            {
                booking_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateBookingRequest);
        public bool Equals(CreateBookingRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (BookingId != other.BookingId)) return false;
            if (!Equals(Booking, other.Booking)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasBookingId) hash ^= BookingId.GetHashCode();
            if (booking_ != null) hash ^= Booking.GetHashCode();
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
      if (HasBookingId) {
        output.WriteRawTag(18);
        output.WriteString(BookingId);
      }
      if (booking_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Booking);
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
            if (HasBookingId)
            {
                output.WriteRawTag(18);
                output.WriteString(BookingId);
            }
            if (booking_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Booking);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasBookingId) size += 1 + CodedOutputStream.ComputeStringSize(BookingId);
            if (booking_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Booking);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateBookingRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasBookingId) BookingId = other.BookingId;
            if (other.booking_ != null)
            {
                if (booking_ == null) Booking = new Booking();
                Booking.MergeFrom(other.Booking);
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
            BookingId = input.ReadString();
            break;
          }
          case 26: {
            if (booking_ == null) {
              Booking = new Saltoapis.Nebula.Booking.V1.Booking();
            }
            input.ReadMessage(Booking);
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
                            BookingId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (booking_ == null) Booking = new Booking();
                            input.ReadMessage(Booking);
                            break;
                        }
                }
            }
        }
#endif

    }


}
