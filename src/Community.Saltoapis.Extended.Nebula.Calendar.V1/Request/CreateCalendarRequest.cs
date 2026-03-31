namespace Saltoapis.Nebula.Calendar.V1.Request
{
    /// <summary>
    /// The request message for [`CreateCalendar`][salto.nebula.mobilekey.v1.MobileKeyService.CreateCalendar]
    /// </summary>
    public sealed partial class CreateCalendarRequest : IMessage<CreateCalendarRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateCalendarRequest> _parser = new(() => new CreateCalendarRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateCalendarRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateCalendarRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateCalendarRequest(CreateCalendarRequest other) : this()
        {
            parent_ = other.parent_;
            calendarId_ = other.calendarId_;
            calendar_ = other.calendar_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateCalendarRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the calendar. For
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

        /// <summary>Field number for the "calendar_id" field.</summary>
        public const int CalendarIdFieldNumber = 2;
        private readonly static string CalendarIdDefaultValue = "";

        private string calendarId_;

        /// <summary>
        /// The calendar ID to use for this calendar. In case it's empty
        /// the server will autogenerate a unique identifier.
        /// </summary>
        public string CalendarId
        {
            get { return calendarId_ ?? CalendarIdDefaultValue; }
            set
            {
                calendarId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "calendar_id" field is set</summary>
        public bool HasCalendarId
        {
            get { return calendarId_ != null; }
        }

        /// <summary>Clears the value of the "calendar_id" field</summary>
        public void ClearCalendarId()
        {
            calendarId_ = null;
        }

        /// <summary>Field number for the "calendar" field.</summary>
        public const int CalendarFieldNumber = 3;
        private Calendar calendar_;

        /// <summary>
        /// The calendar resource to be created. Client must not set the
        /// `Calendar.name` field.
        /// </summary>
        public Calendar Calendar
        {
            get { return calendar_; }
            set
            {
                calendar_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateCalendarRequest);
        public bool Equals(CreateCalendarRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (CalendarId != other.CalendarId)) return false;
            if (!Equals(Calendar, other.Calendar)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasCalendarId) hash ^= CalendarId.GetHashCode();
            if (calendar_ != null) hash ^= Calendar.GetHashCode();
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
      if (HasCalendarId) {
        output.WriteRawTag(18);
        output.WriteString(CalendarId);
      }
      if (calendar_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Calendar);
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
            if (HasCalendarId)
            {
                output.WriteRawTag(18);
                output.WriteString(CalendarId);
            }
            if (calendar_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Calendar);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasCalendarId) size += 1 + CodedOutputStream.ComputeStringSize(CalendarId);
            if (calendar_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Calendar);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateCalendarRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasCalendarId) CalendarId = other.CalendarId;
            if (other.calendar_ != null)
            {
                if (calendar_ == null) Calendar = new Calendar();
                Calendar.MergeFrom(other.Calendar);
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
            CalendarId = input.ReadString();
            break;
          }
          case 26: {
            if (calendar_ == null) {
              Calendar = new Saltoapis.Nebula.Calendar.V1.Calendar();
            }
            input.ReadMessage(Calendar);
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
                            CalendarId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (calendar_ == null) Calendar = new Calendar();
                            input.ReadMessage(Calendar);
                            break;
                        }
                }
            }
        }
#endif

    }


}
