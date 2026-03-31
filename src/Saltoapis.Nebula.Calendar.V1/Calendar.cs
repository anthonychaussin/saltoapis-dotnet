using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Calendar.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/calendar/v1/calendar.proto</summary>
    public static partial class CalendarReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/calendar/v1/calendar.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static CalendarReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CidzYWx0by9uZWJ1bGEvY2FsZW5kYXIvdjEvY2FsZW5kYXIucHJvdG8SGHNh",
                  "bHRvLm5lYnVsYS5jYWxlbmRhci52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5",
                  "LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxogc2Fs",
                  "dG8vbmVidWxhL3R5cGUvZGF5X3R5cGUucHJvdG8aFXNhbHRvL3R5cGUvZGF0",
                  "ZS5wcm90byIuCghDYWxlbmRhchIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlf",
                  "bmFtZRgCIAEoCSKNAQoFRXZlbnQSDAoEbmFtZRgBIAEoCRIsCghkYXlfdHlw",
                  "ZRgCIAEoDjIaLnNhbHRvLm5lYnVsYS50eXBlLkRheVR5cGUSJAoKc3RhcnRf",
                  "ZGF0ZRgDIAEoCzIQLnNhbHRvLnR5cGUuRGF0ZRIiCghlbmRfZGF0ZRgEIAEo",
                  "CzIQLnNhbHRvLnR5cGUuRGF0ZSKHAQoVQ3JlYXRlQ2FsZW5kYXJSZXF1ZXN0",
                  "Eg4KBnBhcmVudBgBIAEoCRIYCgtjYWxlbmRhcl9pZBgCIAEoCUgAiAEBEjQK",
                  "CGNhbGVuZGFyGAMgASgLMiIuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYxLkNh",
                  "bGVuZGFyQg4KDF9jYWxlbmRhcl9pZCIiChJHZXRDYWxlbmRhclJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCSJvChRMaXN0Q2FsZW5kYXJzUmVxdWVzdBIOCgZwYXJl",
                  "bnQYASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyAB",
                  "KAkSDgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJImcKFUxpc3RD",
                  "YWxlbmRhcnNSZXNwb25zZRI1CgljYWxlbmRhcnMYASADKAsyIi5zYWx0by5u",
                  "ZWJ1bGEuY2FsZW5kYXIudjEuQ2FsZW5kYXISFwoPbmV4dF9wYWdlX3Rva2Vu",
                  "GAIgASgJIn4KFVVwZGF0ZUNhbGVuZGFyUmVxdWVzdBI0CghjYWxlbmRhchgB",
                  "IAEoCzIiLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5DYWxlbmRhchIvCgt1",
                  "cGRhdGVfbWFzaxgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2si",
                  "JQoVRGVsZXRlQ2FsZW5kYXJSZXF1ZXN0EgwKBG5hbWUYASABKAkieAoSQ3Jl",
                  "YXRlRXZlbnRSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIVCghldmVudF9pZBgC",
                  "IAEoCUgAiAEBEi4KBWV2ZW50GAMgASgLMh8uc2FsdG8ubmVidWxhLmNhbGVu",
                  "ZGFyLnYxLkV2ZW50QgsKCV9ldmVudF9pZCIfCg9HZXRFdmVudFJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCSJsChFMaXN0RXZlbnRzUmVxdWVzdBIOCgZwYXJlbnQY",
                  "ASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkS",
                  "DgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIl4KEkxpc3RFdmVu",
                  "dHNSZXNwb25zZRIvCgZldmVudHMYASADKAsyHy5zYWx0by5uZWJ1bGEuY2Fs",
                  "ZW5kYXIudjEuRXZlbnQSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJInUKElVw",
                  "ZGF0ZUV2ZW50UmVxdWVzdBIuCgVldmVudBgBIAEoCzIfLnNhbHRvLm5lYnVs",
                  "YS5jYWxlbmRhci52MS5FdmVudBIvCgt1cGRhdGVfbWFzaxgCIAEoCzIaLmdv",
                  "b2dsZS5wcm90b2J1Zi5GaWVsZE1hc2siIgoSRGVsZXRlRXZlbnRSZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAky3wcKD0NhbGVuZGFyU2VydmljZRJlCg5DcmVhdGVD",
                  "YWxlbmRhchIvLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5DcmVhdGVDYWxl",
                  "bmRhclJlcXVlc3QaIi5zYWx0by5uZWJ1bGEuY2FsZW5kYXIudjEuQ2FsZW5k",
                  "YXISXwoLR2V0Q2FsZW5kYXISLC5zYWx0by5uZWJ1bGEuY2FsZW5kYXIudjEu",
                  "R2V0Q2FsZW5kYXJSZXF1ZXN0GiIuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "LkNhbGVuZGFyEnAKDUxpc3RDYWxlbmRhcnMSLi5zYWx0by5uZWJ1bGEuY2Fs",
                  "ZW5kYXIudjEuTGlzdENhbGVuZGFyc1JlcXVlc3QaLy5zYWx0by5uZWJ1bGEu",
                  "Y2FsZW5kYXIudjEuTGlzdENhbGVuZGFyc1Jlc3BvbnNlEmUKDlVwZGF0ZUNh",
                  "bGVuZGFyEi8uc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYxLlVwZGF0ZUNhbGVu",
                  "ZGFyUmVxdWVzdBoiLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5DYWxlbmRh",
                  "chJZCg5EZWxldGVDYWxlbmRhchIvLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52",
                  "MS5EZWxldGVDYWxlbmRhclJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1w",
                  "dHkSXAoLQ3JlYXRlRXZlbnQSLC5zYWx0by5uZWJ1bGEuY2FsZW5kYXIudjEu",
                  "Q3JlYXRlRXZlbnRSZXF1ZXN0Gh8uc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "LkV2ZW50ElYKCEdldEV2ZW50Eikuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "LkdldEV2ZW50UmVxdWVzdBofLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5F",
                  "dmVudBJnCgpMaXN0RXZlbnRzEisuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "Lkxpc3RFdmVudHNSZXF1ZXN0Giwuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "Lkxpc3RFdmVudHNSZXNwb25zZRJcCgtVcGRhdGVFdmVudBIsLnNhbHRvLm5l",
                  "YnVsYS5jYWxlbmRhci52MS5VcGRhdGVFdmVudFJlcXVlc3QaHy5zYWx0by5u",
                  "ZWJ1bGEuY2FsZW5kYXIudjEuRXZlbnQSUwoLRGVsZXRlRXZlbnQSLC5zYWx0",
                  "by5uZWJ1bGEuY2FsZW5kYXIudjEuRGVsZXRlRXZlbnRSZXF1ZXN0GhYuZ29v",
                  "Z2xlLnByb3RvYnVmLkVtcHR5QuQBCiBjb20uc2FsdG9hcGlzLm5lYnVsYS5j",
                  "YWxlbmRhci52MUINQ2FsZW5kYXJQcm90b1ABWkZnaXRodWIuY29tL3NhbHRv",
                  "YXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL2NhbGVuZGFyL3Yx",
                  "O2NhbGVuZGFyqgIcU2FsdG9hcGlzLk5lYnVsYS5DYWxlbmRhci5WMcoCHFNh",
                  "bHRvYXBpc1xOZWJ1bGFcQ2FsZW5kYXJcVjHiAihHUEJNZXRhZGF0YVxTYWx0",
                  "b2FwaXNcTmVidWxhXENhbGVuZGFyXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Type.DayTypeReflection.Descriptor, Saltoapis.Type.DateReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Calendar), Calendar.Parser, ["Name", "DisplayName"], null, null, null, null),
            new(typeof(Event), Event.Parser, ["Name", "DayType", "StartDate", "EndDate"], null, null, null, null),
            new(typeof(CreateCalendarRequest), CreateCalendarRequest.Parser, ["Parent", "CalendarId", "Calendar"], ["CalendarId"], null, null, null),
            new(typeof(GetCalendarRequest), GetCalendarRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListCalendarsRequest), ListCalendarsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListCalendarsResponse), ListCalendarsResponse.Parser, ["Calendars", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateCalendarRequest), UpdateCalendarRequest.Parser, ["Calendar", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteCalendarRequest), DeleteCalendarRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CreateEventRequest), CreateEventRequest.Parser, ["Parent", "EventId", "Event"], ["EventId"], null, null, null),
            new(typeof(GetEventRequest), GetEventRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListEventsRequest), ListEventsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListEventsResponse), ListEventsResponse.Parser, ["Events", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateEventRequest), UpdateEventRequest.Parser, ["Event", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteEventRequest), DeleteEventRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The calendar object
    /// </summary>
    public sealed partial class Calendar : IMessage<Calendar>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Calendar> _parser = new(() => new Calendar());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Calendar> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Calendar()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Calendar(Calendar other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Calendar Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the calendar. It must have the format of
        /// `installations/*/calendars/*`. For example:
        /// `installations/surelock-homes-hq/calendars/gmt`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the calendar.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as Calendar);
        public bool Equals(Calendar other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (DisplayName != other.DisplayName) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
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
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DisplayName);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Calendar other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
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
          case 18: {
            DisplayName = input.ReadString();
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
                            DisplayName = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (DayType != other.DayType) return false;
            if (!Equals(StartDate, other.StartDate)) return false;
            if (!Equals(EndDate, other.EndDate)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DayType != Type.DayType.Unspecified) hash ^= DayType.GetHashCode();
            if (startDate_ != null) hash ^= StartDate.GetHashCode();
            if (endDate_ != null) hash ^= EndDate.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (DayType != Type.DayType.Unspecified)
            {
                size += 1 + CodedOutputStream.ComputeEnumSize((int)DayType);
            }
            if (startDate_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(StartDate);
            }
            if (endDate_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(EndDate);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Event other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DayType != Type.DayType.Unspecified)
            {
                DayType = other.DayType;
            }
            if (other.startDate_ != null)
            {
                if (startDate_ == null)
                {
                    StartDate = new Saltoapis.Type.Date();
                }
                StartDate.MergeFrom(other.StartDate);
            }
            if (other.endDate_ != null)
            {
                if (endDate_ == null)
                {
                    EndDate = new Saltoapis.Type.Date();
                }
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
                            if (startDate_ == null)
                            {
                                StartDate = new Saltoapis.Type.Date();
                            }
                            input.ReadMessage(StartDate);
                            break;
                        }
                    case 34:
                        {
                            if (endDate_ == null)
                            {
                                EndDate = new Saltoapis.Type.Date();
                            }
                            input.ReadMessage(EndDate);
                            break;
                        }
                }
            }
        }
#endif

    }

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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (CalendarId != other.CalendarId) return false;
            if (!Equals(Calendar, other.Calendar)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasCalendarId) hash ^= CalendarId.GetHashCode();
            if (calendar_ != null) hash ^= Calendar.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (HasCalendarId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(CalendarId);
            }
            if (calendar_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Calendar);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateCalendarRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasCalendarId)
            {
                CalendarId = other.CalendarId;
            }
            if (other.calendar_ != null)
            {
                if (calendar_ == null)
                {
                    Calendar = new Calendar();
                }
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
                            if (calendar_ == null)
                            {
                                Calendar = new Calendar();
                            }
                            input.ReadMessage(Calendar);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetCalendar`][salto.nebula.calendar.v1.CalendarService.GetCalendar]
    /// </summary>
    public sealed partial class GetCalendarRequest : IMessage<GetCalendarRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetCalendarRequest> _parser = new(() => new GetCalendarRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetCalendarRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetCalendarRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetCalendarRequest(GetCalendarRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetCalendarRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested calendar resource. For example:
        /// `installations/surelock-homes-hq/calendars/gmt`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetCalendarRequest);
        public bool Equals(GetCalendarRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GetCalendarRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListCalendars`][salto.nebula.calendar.v1.CalendarService.ListCalendars]
    /// </summary>
    public sealed partial class ListCalendarsRequest : IMessage<ListCalendarsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListCalendarsRequest> _parser = new(() => new ListCalendarsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListCalendarsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListCalendarsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListCalendarsRequest(ListCalendarsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListCalendarsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 2;
        private int pageSize_;

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
            }
        }

        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 3;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 4;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which calendars to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "order_by" field.</summary>
        public const int OrderByFieldNumber = 5;
        private string orderBy_ = "";

        /// <summary>
        /// How the results should be sorted.
        /// </summary>
        public string OrderBy
        {
            get { return orderBy_; }
            set
            {
                orderBy_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListCalendarsRequest);
        public bool Equals(ListCalendarsRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            if (OrderBy != other.OrderBy) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
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
            if (PageSize != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Filter);
            }
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(OrderBy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (PageSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            }
            if (PageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            }
            if (Filter.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            }
            if (OrderBy.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListCalendarsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PageSize != 0)
            {
                PageSize = other.PageSize;
            }
            if (other.PageToken.Length != 0)
            {
                PageToken = other.PageToken;
            }
            if (other.Filter.Length != 0)
            {
                Filter = other.Filter;
            }
            if (other.OrderBy.Length != 0)
            {
                OrderBy = other.OrderBy;
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
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
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
                    case 16:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 26:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ListCalendars`][salto.nebula.calendar.v1.CalendarService.ListCalendars]
    /// </summary>
    public sealed partial class ListCalendarsResponse : IMessage<ListCalendarsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListCalendarsResponse> _parser = new(() => new ListCalendarsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListCalendarsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListCalendarsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListCalendarsResponse(ListCalendarsResponse other) : this()
        {
            calendars_ = other.calendars_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListCalendarsResponse Clone() => new(this);
        /// <summary>Field number for the "calendars" field.</summary>
        public const int CalendarsFieldNumber = 1;
        private static readonly FieldCodec<Calendar> _repeated_calendars_codec
            = FieldCodec.ForMessage(10, Calendar.Parser);
        private readonly RepeatedField<Calendar> calendars_ = [];

        /// <summary>
        /// The field name should match the noun `calendars` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<Calendar> Calendars
        {
            get { return calendars_; }
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

        public override bool Equals(object other) => Equals(other as ListCalendarsResponse);
        public bool Equals(ListCalendarsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!calendars_.Equals(other.calendars_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= calendars_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      calendars_.WriteTo(output, _repeated_calendars_codec);
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
            calendars_.WriteTo(ref output, _repeated_calendars_codec);
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
            size += calendars_.CalculateSize(_repeated_calendars_codec);
            if (NextPageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListCalendarsResponse other)
        {
            if (other == null)
            {
                return;
            }
            calendars_.Add(other.calendars_);
            if (other.NextPageToken.Length != 0)
            {
                NextPageToken = other.NextPageToken;
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
            calendars_.AddEntriesFrom(input, _repeated_calendars_codec);
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
                            calendars_.AddEntriesFrom(ref input, _repeated_calendars_codec);
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

    /// <summary>
    /// The response message for [`UpdateCalendar`][salto.nebula.calendar.v1.CalendarService.UpdateCalendar]
    /// </summary>
    public sealed partial class UpdateCalendarRequest : IMessage<UpdateCalendarRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateCalendarRequest> _parser = new(() => new UpdateCalendarRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateCalendarRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateCalendarRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateCalendarRequest(UpdateCalendarRequest other) : this()
        {
            calendar_ = other.calendar_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateCalendarRequest Clone() => new(this);
        /// <summary>Field number for the "calendar" field.</summary>
        public const int CalendarFieldNumber = 1;
        private Calendar calendar_;

        /// <summary>
        /// The calendar resource which replaces the resource on the server.
        /// </summary>
        public Calendar Calendar
        {
            get { return calendar_; }
            set
            {
                calendar_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateCalendarRequest);
        public bool Equals(UpdateCalendarRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Calendar, other.Calendar)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (calendar_ != null) hash ^= Calendar.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (calendar_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Calendar);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (calendar_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Calendar);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (calendar_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Calendar);
            }
            if (updateMask_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateCalendarRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.calendar_ != null)
            {
                if (calendar_ == null)
                {
                    Calendar = new Calendar();
                }
                Calendar.MergeFrom(other.Calendar);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null)
                {
                    UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                }
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (calendar_ == null) {
              Calendar = new Saltoapis.Nebula.Calendar.V1.Calendar();
            }
            input.ReadMessage(Calendar);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            if (calendar_ == null)
                            {
                                Calendar = new Calendar();
                            }
                            input.ReadMessage(Calendar);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null)
                            {
                                UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            }
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`DeleteCalendar`][salto.nebula.calendar.v1.CalendarService.DeleteCalendar]
    /// </summary>
    public sealed partial class DeleteCalendarRequest : IMessage<DeleteCalendarRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteCalendarRequest> _parser = new(() => new DeleteCalendarRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteCalendarRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteCalendarRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteCalendarRequest(DeleteCalendarRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteCalendarRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the calendar to be deleted. For example:
        /// `installations/surelock-homes-hq/calendars/gmt`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteCalendarRequest);
        public bool Equals(DeleteCalendarRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeleteCalendarRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

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

        public static MessageParser<CreateEventRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

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
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "event_id" field.</summary>
        public const int EventIdFieldNumber = 2;
        private readonly static string EventIdDefaultValue = "";

        private string eventId_;

        /// <summary>
        /// The event ID to use for this calendar event. In case it's
        /// empty the server will autogenerate a unique identifier.
        /// </summary>
        public string EventId
        {
            get { return eventId_ ?? EventIdDefaultValue; }
            set
            {
                eventId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "event_id" field is set</summary>
        public bool HasEventId
        {
            get { return eventId_ != null; }
        }

        /// <summary>Clears the value of the "event_id" field</summary>
        public void ClearEventId()
        {
            eventId_ = null;
        }

        /// <summary>Field number for the "event" field.</summary>
        public const int EventFieldNumber = 3;
        private Event event_;

        /// <summary>
        /// The calendar event resource to be created. Client must not set the
        /// `Event.name` field.
        /// </summary>
        public Event Event
        {
            get { return event_; }
            set
            {
                event_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateEventRequest);
        public bool Equals(CreateEventRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (EventId != other.EventId) return false;
            if (!Equals(Event, other.Event)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasEventId) hash ^= EventId.GetHashCode();
            if (event_ != null) hash ^= Event.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
      if (HasEventId) {
        output.WriteRawTag(18);
        output.WriteString(EventId);
      }
      if (event_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Event);
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
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (HasEventId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(EventId);
            }
            if (event_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Event);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateEventRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasEventId)
            {
                EventId = other.EventId;
            }
            if (other.event_ != null)
            {
                if (event_ == null)
                {
                    Event = new Event();
                }
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
            EventId = input.ReadString();
            break;
          }
          case 26: {
            if (event_ == null) {
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
                            if (event_ == null)
                            {
                                Event = new Event();
                            }
                            input.ReadMessage(Event);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetEvent`][salto.nebula.calendar.v1.CalendarService.GetEvent]
    /// </summary>
    public sealed partial class GetEventRequest : IMessage<GetEventRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetEventRequest> _parser = new(() => new GetEventRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetEventRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetEventRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetEventRequest(GetEventRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetEventRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested calendar event resource. For example:
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

        public override bool Equals(object other) => Equals(other as GetEventRequest);
        public bool Equals(GetEventRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GetEventRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListEvent`][salto.nebula.calendar.v1.CalendarService.ListEvent]
    /// </summary>
    public sealed partial class ListEventsRequest : IMessage<ListEventsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListEventsRequest> _parser = new(() => new ListEventsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListEventsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListEventsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListEventsRequest(ListEventsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListEventsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example:
        /// `installations/surelock-homes-hq/calendars/gmt`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 2;
        private int pageSize_;

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
            }
        }

        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 3;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 4;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which calendar events to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "order_by" field.</summary>
        public const int OrderByFieldNumber = 5;
        private string orderBy_ = "";

        /// <summary>
        /// How the results should be sorted.
        /// </summary>
        public string OrderBy
        {
            get { return orderBy_; }
            set
            {
                orderBy_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListEventsRequest);
        public bool Equals(ListEventsRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            if (OrderBy != other.OrderBy) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
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
            if (PageSize != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Filter);
            }
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(OrderBy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (PageSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            }
            if (PageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            }
            if (Filter.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            }
            if (OrderBy.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListEventsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PageSize != 0)
            {
                PageSize = other.PageSize;
            }
            if (other.PageToken.Length != 0)
            {
                PageToken = other.PageToken;
            }
            if (other.Filter.Length != 0)
            {
                Filter = other.Filter;
            }
            if (other.OrderBy.Length != 0)
            {
                OrderBy = other.OrderBy;
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
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
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
                    case 16:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 26:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ListEvent`][salto.nebula.calendar.v1.CalendarService.ListEvent]
    /// </summary>
    public sealed partial class ListEventsResponse : IMessage<ListEventsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListEventsResponse> _parser = new(() => new ListEventsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListEventsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListEventsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListEventsResponse(ListEventsResponse other) : this()
        {
            events_ = other.events_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListEventsResponse Clone() => new(this);
        /// <summary>Field number for the "events" field.</summary>
        public const int EventsFieldNumber = 1;
        private static readonly FieldCodec<Event> _repeated_events_codec
            = FieldCodec.ForMessage(10, Event.Parser);
        private readonly RepeatedField<Event> events_ = [];

        /// <summary>
        /// The field name should match the noun `events` in the method name. There
        /// will be a maximum number of items
        /// returned based on the `page_size` field in the request.
        /// </summary>
        public RepeatedField<Event> Events
        {
            get { return events_; }
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

        public override bool Equals(object other) => Equals(other as ListEventsResponse);
        public bool Equals(ListEventsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!events_.Equals(other.events_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= events_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      events_.WriteTo(output, _repeated_events_codec);
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
            events_.WriteTo(ref output, _repeated_events_codec);
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
            size += events_.CalculateSize(_repeated_events_codec);
            if (NextPageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListEventsResponse other)
        {
            if (other == null)
            {
                return;
            }
            events_.Add(other.events_);
            if (other.NextPageToken.Length != 0)
            {
                NextPageToken = other.NextPageToken;
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
            events_.AddEntriesFrom(input, _repeated_events_codec);
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
                            events_.AddEntriesFrom(ref input, _repeated_events_codec);
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

    /// <summary>
    /// The response message for [`UpdateEvent`][salto.nebula.calendar.v1.CalendarService.UpdateEvent]
    /// </summary>
    public sealed partial class UpdateEventRequest : IMessage<UpdateEventRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEventRequest> _parser = new(() => new UpdateEventRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEventRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEventRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEventRequest(UpdateEventRequest other) : this()
        {
            event_ = other.event_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEventRequest Clone() => new(this);
        /// <summary>Field number for the "event" field.</summary>
        public const int EventFieldNumber = 1;
        private Event event_;

        /// <summary>
        /// The calendar event resource which replaces the resource on the server.
        /// </summary>
        public Event Event
        {
            get { return event_; }
            set
            {
                event_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateEventRequest);
        public bool Equals(UpdateEventRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Event, other.Event)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (event_ != null) hash ^= Event.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (event_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Event);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (event_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Event);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (event_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Event);
            }
            if (updateMask_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateEventRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.event_ != null)
            {
                if (event_ == null)
                {
                    Event = new Event();
                }
                Event.MergeFrom(other.Event);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null)
                {
                    UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                }
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (event_ == null) {
              Event = new Saltoapis.Nebula.Calendar.V1.Event();
            }
            input.ReadMessage(Event);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            if (event_ == null)
                            {
                                Event = new Event();
                            }
                            input.ReadMessage(Event);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null)
                            {
                                UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            }
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`DeleteEvent`][salto.nebula.calendar.v1.CalendarService.DeleteEvent]
    /// </summary>
    public sealed partial class DeleteEventRequest : IMessage<DeleteEventRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteEventRequest> _parser = new(() => new DeleteEventRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteEventRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return CalendarReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteEventRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteEventRequest(DeleteEventRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteEventRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the calendar event to be deleted. For example:
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

        public override bool Equals(object other) => Equals(other as DeleteEventRequest);
        public bool Equals(DeleteEventRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeleteEventRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    #endregion

}
