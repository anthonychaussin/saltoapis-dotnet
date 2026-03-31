namespace Saltoapis.Nebula.Booking.V1
{
    /// <summary>
    /// The BookingUser resource represents a user associated with a booking.
    /// </summary>
    public sealed partial class BookingUser : IMessage<BookingUser>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BookingUser> _parser = new(() => new BookingUser());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BookingUser> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => BookingReflection.Descriptor.MessageTypes[9];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public BookingUser()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BookingUser(BookingUser other) : this()
        {
            name_ = other.name_;
            user_ = other.user_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BookingUser Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// The resource name of the booking's user association.
        /// It must have the format of `installations/*/bookings/*/users/*`.
        /// For example: `installations/surelock-homes-hq/bookings/my-booking/users/john-watson`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 2;
        private string user_ = "";
        /// <summary>
        /// The user resource name to bind as an association to the parent booking.
        /// For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string User
        {
            get => user_; set => user_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as BookingUser);
        public bool Equals(BookingUser other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (User != other.User)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (User.Length != 0) hash ^= User.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (User.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(User);
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
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            if (User.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(User);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (User.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(User);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BookingUser other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.User.Length != 0) User = other.User;
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
            Name = input.ReadString();
            break;
          }
          case 18:
          {
            User = input.ReadString();
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
                            Name = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            User = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}