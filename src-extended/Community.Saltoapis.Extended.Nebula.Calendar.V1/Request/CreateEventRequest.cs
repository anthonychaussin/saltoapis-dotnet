namespace Saltoapis.Nebula.Calendar.V1.Request
{
    /// <summary>
    /// The request message for [`CreateEvent`][salto.nebula.calendar.v1.CalendarService.CreateEvent]
    /// </summary>
    public sealed partial class CreateEventRequest : IMessage<CreateEventRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateEventRequest> _parser = new(() => new CreateEventRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateEventRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => CalendarReflection.Descriptor.MessageTypes[8];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateEventRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateEventRequest(CreateEventRequest other) : this()
        {
            parent_ = other.parent_;
            eventId_ = other.eventId_;
            event_ = other.event_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateEventRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where to create the calendar
        /// event. For example: `installations/surelock-homes-hq/calendars/gmt`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "event_id" field.</summary>
        public const int EventIdFieldNumber = 2;
        private static readonly string EventIdDefaultValue = "";

        private string eventId_;
        /// <summary>
        /// The event ID to use for this calendar event. In case it's
        /// empty the server will autogenerate a unique identifier.
        /// </summary>
        public string EventId
        {
            get => eventId_ ?? EventIdDefaultValue; set => eventId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "event_id" field is set</summary>
        public bool HasEventId => eventId_ != null;
        /// <summary>Clears the value of the "event_id" field</summary>
        public void ClearEventId() => eventId_ = null;
        /// <summary>Field number for the "event" field.</summary>
        public const int EventFieldNumber = 3;
        private Event event_;
        /// <summary>
        /// The calendar event resource to be created. Client must not set the
        /// `Event.name` field.
        /// </summary>
        public Event Event
        {
            get => event_; set => event_ = value;}

        public override bool Equals(object other) => Equals(other as CreateEventRequest);
        public bool Equals(CreateEventRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (EventId != other.EventId) || !Equals(Event, other.Event)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasEventId) hash ^= EventId.GetHashCode();
            if (event_ != null) hash ^= Event.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (HasEventId)
      {
        output.WriteRawTag(18);
        output.WriteString(EventId);
      }
      if (event_ != null)
      {
        output.WriteRawTag(26);
        output.WriteMessage(Event);
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
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (HasEventId)
            {
                output.WriteRawTag(18);
                output.WriteString(EventId);
            }
            if (event_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Event);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasEventId) size += 1 + CodedOutputStream.ComputeStringSize(EventId);
            if (event_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Event);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateEventRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasEventId) EventId = other.EventId;
            if (other.event_ != null)
            {
                if (event_ == null) Event = new Event();
                Event.MergeFrom(other.Event);
            }
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
            Parent = input.ReadString();
            break;
          }
          case 18:
          {
            EventId = input.ReadString();
            break;
          }
          case 26:
          {
            if (event_ == null)
            {
              Event = new Saltoapis.Nebula.Calendar.V1.Event();
            }
            input.ReadMessage(Event);
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
                            EventId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (event_ == null) Event = new Event();
                            input.ReadMessage(Event);
                            break;
                        }
                }
            }
        }
#endif
    }

}