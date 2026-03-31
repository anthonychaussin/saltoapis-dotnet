using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Type
{
    /// <summary>
    /// Represents an schedule.
    /// </summary>
    public sealed partial class Schedule : IMessage<Schedule>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Schedule> _parser = new(() => new Schedule());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Schedule> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ScheduleReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Schedule()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Schedule(Schedule other) : this()
        {
            days_ = other.days_.Clone();
            startTime_ = other.startTime_?.Clone();
            endTime_ = other.endTime_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Schedule Clone() => new(this);
        /// <summary>Field number for the "days" field.</summary>
        public const int DaysFieldNumber = 1;
        private static readonly FieldCodec<Types.Day> _repeated_days_codec
            = FieldCodec.ForMessage(10, Types.Day.Parser);
        private readonly RepeatedField<Types.Day> days_ = [];

        /// <summary>
        /// Days when it's valid.
        /// </summary>
        public RepeatedField<Types.Day> Days
        {
            get { return days_; }
        }

        /// <summary>Field number for the "start_time" field.</summary>
        public const int StartTimeFieldNumber = 2;
        private Saltoapis.Type.TimeOfDay startTime_;

        /// <summary>
        /// Start time of day when schedule starts being valid.
        /// </summary>
        public Saltoapis.Type.TimeOfDay StartTime
        {
            get { return startTime_; }
            set
            {
                startTime_ = value;
            }
        }

        /// <summary>Field number for the "end_time" field.</summary>
        public const int EndTimeFieldNumber = 3;
        private Saltoapis.Type.TimeOfDay endTime_;

        /// <summary>
        /// End time of day when schedule ends being valid.
        /// </summary>
        public Saltoapis.Type.TimeOfDay EndTime
        {
            get { return endTime_; }
            set
            {
                endTime_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Schedule);
        public bool Equals(Schedule other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!days_.Equals(other.days_)) || (!Equals(StartTime, other.StartTime))) return false;
            if (!Equals(EndTime, other.EndTime)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= days_.GetHashCode();
            if (startTime_ != null) hash ^= StartTime.GetHashCode();
            if (endTime_ != null) hash ^= EndTime.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      days_.WriteTo(output, _repeated_days_codec);
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            days_.WriteTo(ref output, _repeated_days_codec);
            if (startTime_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(StartTime);
            }
            if (endTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EndTime);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += days_.CalculateSize(_repeated_days_codec);
            if (startTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(StartTime);
            if (endTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EndTime);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Schedule other)
        {
            if (other == null) return;
            days_.Add(other.days_);
            if (other.startTime_ != null)
            {
                if (startTime_ == null) StartTime = new Saltoapis.Type.TimeOfDay();
                StartTime.MergeFrom(other.StartTime);
            }
            if (other.endTime_ != null)
            {
                if (endTime_ == null) EndTime = new Saltoapis.Type.TimeOfDay();
                EndTime.MergeFrom(other.EndTime);
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
            days_.AddEntriesFrom(input, _repeated_days_codec);
            break;
          }
          case 18: {
            if (startTime_ == null) {
              StartTime = new Saltoapis.Type.TimeOfDay();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              EndTime = new Saltoapis.Type.TimeOfDay();
            }
            input.ReadMessage(EndTime);
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
                            days_.AddEntriesFrom(ref input, _repeated_days_codec);
                            break;
                        }
                    case 18:
                        {
                            if (startTime_ == null) StartTime = new Saltoapis.Type.TimeOfDay();
                            input.ReadMessage(StartTime);
                            break;
                        }
                    case 26:
                        {
                            if (endTime_ == null) EndTime = new Saltoapis.Type.TimeOfDay();
                            input.ReadMessage(EndTime);
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the Schedule message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// Day of the week
            /// </summary>
            public sealed partial class Day : IMessage<Day>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<Day> _parser = new(() => new Day());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<Day> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Schedule.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public Day()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public Day(Day other) : this()
                {
                    dayType_ = other.dayType_;
                    dayOfWeek_ = other.dayOfWeek_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Day Clone() => new(this);
                /// <summary>Field number for the "day_type" field.</summary>
                public const int DayTypeFieldNumber = 1;
                private DayType dayType_ = DayType.Unspecified;

                /// <summary>
                /// Day type
                /// </summary>
                public DayType DayType
                {
                    get { return dayType_; }
                    set
                    {
                        dayType_ = value;
                    }
                }

                /// <summary>Field number for the "day_of_week" field.</summary>
                public const int DayOfWeekFieldNumber = 2;
                private Saltoapis.Type.DayOfWeek dayOfWeek_ = Saltoapis.Type.DayOfWeek.Unspecified;

                /// <summary>
                /// In case `day_type` is `NORMAL`, the specific day of the week.
                /// </summary>
                public Saltoapis.Type.DayOfWeek DayOfWeek
                {
                    get { return dayOfWeek_; }
                    set
                    {
                        dayOfWeek_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as Day);
                public bool Equals(Day other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((DayType != other.DayType) || (DayOfWeek != other.DayOfWeek)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (DayType != DayType.Unspecified) hash ^= DayType.GetHashCode();
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) hash ^= DayOfWeek.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (DayType != Saltoapis.Nebula.Type.DayType.Unspecified) {
            output.WriteRawTag(8);
            output.WriteEnum((int) DayType);
          }
          if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) {
            output.WriteRawTag(16);
            output.WriteEnum((int) DayOfWeek);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (DayType != DayType.Unspecified)
                    {
                        output.WriteRawTag(8);
                        output.WriteEnum((int)DayType);
                    }
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified)
                    {
                        output.WriteRawTag(16);
                        output.WriteEnum((int)DayOfWeek);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (DayType != DayType.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)DayType);
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)DayOfWeek);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(Day other)
                {
                    if (other == null) return;
                    if (other.DayType != DayType.Unspecified) DayType = other.DayType;
                    if (other.DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) DayOfWeek = other.DayOfWeek;
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
              case 8: {
                DayType = (Saltoapis.Nebula.Type.DayType) input.ReadEnum();
                break;
              }
              case 16: {
                DayOfWeek = (Saltoapis.Type.DayOfWeek) input.ReadEnum();
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
                            case 8:
                                {
                                    DayType = (DayType)input.ReadEnum();
                                    break;
                                }
                            case 16:
                                {
                                    DayOfWeek = (Saltoapis.Type.DayOfWeek)input.ReadEnum();
                                    break;
                                }
                        }
                    }
                }
#endif

            }

        }

    }


}
