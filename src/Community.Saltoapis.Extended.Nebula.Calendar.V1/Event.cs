namespace Saltoapis.Nebula.Calendar.V1
{
    public sealed partial class Event : IMessage<Event>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Event> _parser = new(() => new Event());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Event> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Event()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Event(Event other) : this()
        {
            name_ = other.name_;
            dayType_ = other.dayType_;
            startDate_ = other.startDate_?.Clone();
            endDate_ = other.endDate_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Event Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the calendar event. It must have the
        /// format of `installations/*/calendars/*/events/*`. For example:
        /// `installations/surelock-homes-hq/calendars/gmt/events/twelvetide`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "day_type" field.</summary>
        public const int DayTypeFieldNumber = 2;
        private Type.DayType dayType_ = Type.DayType.Unspecified;

        /// <summary>
        /// Day type.
        /// </summary>
        public Type.DayType DayType
        {
            get { return dayType_; }
            set
            {
                dayType_ = value;
            }
        }

        /// <summary>Field number for the "start_date" field.</summary>
        public const int StartDateFieldNumber = 3;
        private Saltoapis.Type.Date startDate_;

        /// <summary>
        /// Start date.
        /// </summary>
        public Saltoapis.Type.Date StartDate
        {
            get { return startDate_; }
            set
            {
                startDate_ = value;
            }
        }

        /// <summary>Field number for the "end_date" field.</summary>
        public const int EndDateFieldNumber = 4;
        private Saltoapis.Type.Date endDate_;

        /// <summary>
        /// End date.
        /// </summary>
        public Saltoapis.Type.Date EndDate
        {
            get { return endDate_; }
            set
            {
                endDate_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Event);
        public bool Equals(Event other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DayType != other.DayType)) return false;
            if ((!Equals(StartDate, other.StartDate)) || (!Equals(EndDate, other.EndDate))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DayType != Type.DayType.Unspecified) hash ^= DayType.GetHashCode();
            if (startDate_ != null) hash ^= StartDate.GetHashCode();
            if (endDate_ != null) hash ^= EndDate.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DayType != Saltoapis.Nebula.Type.DayType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) DayType);
      }
      if (startDate_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(StartDate);
      }
      if (endDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EndDate);
      }
      if (_unknownFields != null) {
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
            if (DayType != Type.DayType.Unspecified)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)DayType);
            }
            if (startDate_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(StartDate);
            }
            if (endDate_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(EndDate);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DayType != Type.DayType.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)DayType);
            if (startDate_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(StartDate);
            if (endDate_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EndDate);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Event other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DayType != Type.DayType.Unspecified) DayType = other.DayType;
            if (other.startDate_ != null)
            {
                if (startDate_ == null) StartDate = new Saltoapis.Type.Date();
                StartDate.MergeFrom(other.StartDate);
            }
            if (other.endDate_ != null)
            {
                if (endDate_ == null) EndDate = new Saltoapis.Type.Date();
                EndDate.MergeFrom(other.EndDate);
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            DayType = (Saltoapis.Nebula.Type.DayType) input.ReadEnum();
            break;
          }
          case 26: {
            if (startDate_ == null) {
              StartDate = new Saltoapis.Type.Date();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 34: {
            if (endDate_ == null) {
              EndDate = new Saltoapis.Type.Date();
            }
            input.ReadMessage(EndDate);
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
                    case 16:
                        {
                            DayType = (Type.DayType)input.ReadEnum();
                            break;
                        }
                    case 26:
                        {
                            if (startDate_ == null) StartDate = new Saltoapis.Type.Date();
                            input.ReadMessage(StartDate);
                            break;
                        }
                    case 34:
                        {
                            if (endDate_ == null) EndDate = new Saltoapis.Type.Date();
                            input.ReadMessage(EndDate);
                            break;
                        }
                }
            }
        }
#endif

    }


}
