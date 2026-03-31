using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Booking.V1.Request
{
    /// <summary>
    /// The request message for [`CreateBookingUser`][salto.nebula.booking.v1.BookingService.CreateBookingUser]
    /// </summary>
    public sealed partial class CreateBookingUserRequest : IMessage<CreateBookingUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateBookingUserRequest> _parser = new(() => new CreateBookingUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateBookingUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateBookingUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateBookingUserRequest(CreateBookingUserRequest other) : this()
        {
            parent_ = other.parent_;
            bookingUser_ = other.bookingUser_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateBookingUserRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the booking's user
        /// association is to be created. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "booking_user" field.</summary>
        public const int BookingUserFieldNumber = 2;
        private BookingUser bookingUser_;

        /// <summary>
        /// The booking's user association resource to be created.
        /// Client must not set the `BookingUser.name` field.
        /// </summary>
        public BookingUser BookingUser
        {
            get { return bookingUser_; }
            set
            {
                bookingUser_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateBookingUserRequest);
        public bool Equals(CreateBookingUserRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(BookingUser, other.BookingUser))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (bookingUser_ != null) hash ^= BookingUser.GetHashCode();
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
      if (bookingUser_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BookingUser);
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
            if (bookingUser_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(BookingUser);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (bookingUser_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(BookingUser);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateBookingUserRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.bookingUser_ != null)
            {
                if (bookingUser_ == null) BookingUser = new BookingUser();
                BookingUser.MergeFrom(other.BookingUser);
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
            if (bookingUser_ == null) {
              BookingUser = new Saltoapis.Nebula.Booking.V1.BookingUser();
            }
            input.ReadMessage(BookingUser);
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
                            if (bookingUser_ == null) BookingUser = new BookingUser();
                            input.ReadMessage(BookingUser);
                            break;
                        }
                }
            }
        }
#endif

    }


}
