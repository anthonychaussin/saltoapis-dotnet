using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.OpeningModeSchedule.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/openingmodeschedule/v1/opening_mode_schedule.proto</summary>
    public static partial class OpeningModeScheduleReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/openingmodeschedule/v1/opening_mode_schedule.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static OpeningModeScheduleReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Cj9zYWx0by9uZWJ1bGEvb3BlbmluZ21vZGVzY2hlZHVsZS92MS9vcGVuaW5n",
                  "X21vZGVfc2NoZWR1bGUucHJvdG8SI3NhbHRvLm5lYnVsYS5vcGVuaW5nbW9k",
                  "ZXNjaGVkdWxlLnYxGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aIGdv",
                  "b2dsZS9wcm90b2J1Zi9maWVsZF9tYXNrLnByb3RvGiBzYWx0by9uZWJ1bGEv",
                  "dHlwZS9kYXlfdHlwZS5wcm90bxokc2FsdG8vbmVidWxhL3R5cGUvb3Blbmlu",
                  "Z19tb2RlLnByb3RvGhxzYWx0by90eXBlL2RheV9vZl93ZWVrLnByb3RvGhxz",
                  "YWx0by90eXBlL3RpbWVfb2ZfZGF5LnByb3RvIswDChNPcGVuaW5nTW9kZVNj",
                  "aGVkdWxlEgwKBG5hbWUYASABKAkSFAoMZGlzcGxheV9uYW1lGAIgASgJEkoK",
                  "BGRheXMYAyADKAsyPC5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVs",
                  "ZS52MS5PcGVuaW5nTW9kZVNjaGVkdWxlLkRheRrEAgoDRGF5EiwKCGRheV90",
                  "eXBlGAEgASgOMhouc2FsdG8ubmVidWxhLnR5cGUuRGF5VHlwZRIqCgtkYXlf",
                  "b2Zfd2VlaxgCIAEoDjIVLnNhbHRvLnR5cGUuRGF5T2ZXZWVrElAKBXNsb3Rz",
                  "GAMgAygLMkEuc2FsdG8ubmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEu",
                  "T3BlbmluZ01vZGVTY2hlZHVsZS5EYXkuU2xvdBqQAQoEU2xvdBI0CgxvcGVu",
                  "aW5nX21vZGUYASABKA4yHi5zYWx0by5uZWJ1bGEudHlwZS5PcGVuaW5nTW9k",
                  "ZRIpCgpzdGFydF90aW1lGAIgASgLMhUuc2FsdG8udHlwZS5UaW1lT2ZEYXkS",
                  "JwoIZW5kX3RpbWUYAyABKAsyFS5zYWx0by50eXBlLlRpbWVPZkRheSKtAQog",
                  "Q3JlYXRlT3BlbmluZ01vZGVTY2hlZHVsZVJlcXVlc3QSDgoGcGFyZW50GAEg",
                  "ASgJEiAKGG9wZW5pbmdfbW9kZV9zY2hlZHVsZV9pZBgCIAEoCRJXChVvcGVu",
                  "aW5nX21vZGVfc2NoZWR1bGUYAyABKAsyOC5zYWx0by5uZWJ1bGEub3Blbmlu",
                  "Z21vZGVzY2hlZHVsZS52MS5PcGVuaW5nTW9kZVNjaGVkdWxlIi0KHUdldE9w",
                  "ZW5pbmdNb2RlU2NoZWR1bGVSZXF1ZXN0EgwKBG5hbWUYASABKAkiegofTGlz",
                  "dE9wZW5pbmdNb2RlU2NoZWR1bGVzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkS",
                  "EQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmls",
                  "dGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIpUBCiBMaXN0T3BlbmluZ01v",
                  "ZGVTY2hlZHVsZXNSZXNwb25zZRJYChZvcGVuaW5nX21vZGVfc2NoZWR1bGVz",
                  "GAEgAygLMjguc2FsdG8ubmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEu",
                  "T3BlbmluZ01vZGVTY2hlZHVsZRIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAki",
                  "rAEKIFVwZGF0ZU9wZW5pbmdNb2RlU2NoZWR1bGVSZXF1ZXN0ElcKFW9wZW5p",
                  "bmdfbW9kZV9zY2hlZHVsZRgBIAEoCzI4LnNhbHRvLm5lYnVsYS5vcGVuaW5n",
                  "bW9kZXNjaGVkdWxlLnYxLk9wZW5pbmdNb2RlU2NoZWR1bGUSLwoLdXBkYXRl",
                  "X21hc2sYAiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIjAKIERl",
                  "bGV0ZU9wZW5pbmdNb2RlU2NoZWR1bGVSZXF1ZXN0EgwKBG5hbWUYASABKAky",
                  "mQYKGk9wZW5pbmdNb2RlU2NoZWR1bGVTZXJ2aWNlEpwBChlDcmVhdGVPcGVu",
                  "aW5nTW9kZVNjaGVkdWxlEkUuc2FsdG8ubmVidWxhLm9wZW5pbmdtb2Rlc2No",
                  "ZWR1bGUudjEuQ3JlYXRlT3BlbmluZ01vZGVTY2hlZHVsZVJlcXVlc3QaOC5z",
                  "YWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVsZS52MS5PcGVuaW5nTW9k",
                  "ZVNjaGVkdWxlEpYBChZHZXRPcGVuaW5nTW9kZVNjaGVkdWxlEkIuc2FsdG8u",
                  "bmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEuR2V0T3BlbmluZ01vZGVT",
                  "Y2hlZHVsZVJlcXVlc3QaOC5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hl",
                  "ZHVsZS52MS5PcGVuaW5nTW9kZVNjaGVkdWxlEqcBChhMaXN0T3BlbmluZ01v",
                  "ZGVTY2hlZHVsZXMSRC5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVs",
                  "ZS52MS5MaXN0T3BlbmluZ01vZGVTY2hlZHVsZXNSZXF1ZXN0GkUuc2FsdG8u",
                  "bmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEuTGlzdE9wZW5pbmdNb2Rl",
                  "U2NoZWR1bGVzUmVzcG9uc2USnAEKGVVwZGF0ZU9wZW5pbmdNb2RlU2NoZWR1",
                  "bGUSRS5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVsZS52MS5VcGRh",
                  "dGVPcGVuaW5nTW9kZVNjaGVkdWxlUmVxdWVzdBo4LnNhbHRvLm5lYnVsYS5v",
                  "cGVuaW5nbW9kZXNjaGVkdWxlLnYxLk9wZW5pbmdNb2RlU2NoZWR1bGUSegoZ",
                  "RGVsZXRlT3BlbmluZ01vZGVTY2hlZHVsZRJFLnNhbHRvLm5lYnVsYS5vcGVu",
                  "aW5nbW9kZXNjaGVkdWxlLnYxLkRlbGV0ZU9wZW5pbmdNb2RlU2NoZWR1bGVS",
                  "ZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5QrECCitjb20uc2FsdG9h",
                  "cGlzLm5lYnVsYS5vcGVuaW5nbW9kZXNjaGVkdWxlLnYxQhhPcGVuaW5nTW9k",
                  "ZVNjaGVkdWxlUHJvdG9QAVpcZ2l0aHViLmNvbS9zYWx0b2FwaXMtaW50ZXJu",
                  "YWwvc2FsdG9hcGlzLWdvL25lYnVsYS9vcGVuaW5nbW9kZXNjaGVkdWxlL3Yx",
                  "O29wZW5pbmdtb2Rlc2NoZWR1bGWqAidTYWx0b2FwaXMuTmVidWxhLk9wZW5p",
                  "bmdNb2RlU2NoZWR1bGUuVjHKAidTYWx0b2FwaXNcTmVidWxhXE9wZW5pbmdN",
                  "b2RlU2NoZWR1bGVcVjHiAjNHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxh",
                  "XE9wZW5pbmdNb2RlU2NoZWR1bGVcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Type.DayTypeReflection.Descriptor, Type.OpeningModeReflection.Descriptor, Saltoapis.Type.DayOfWeekReflection.Descriptor, Saltoapis.Type.TimeOfDayReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(OpeningModeSchedule), OpeningModeSchedule.Parser, ["Name", "DisplayName", "Days"], null, null, null, [new(typeof(OpeningModeSchedule.Types.Day), OpeningModeSchedule.Types.Day.Parser, ["DayType", "DayOfWeek", "Slots"], null, null, null, [new(typeof(OpeningModeSchedule.Types.Day.Types.Slot), OpeningModeSchedule.Types.Day.Types.Slot.Parser, ["OpeningMode", "StartTime", "EndTime"], null, null, null, null)])]),
            new(typeof(CreateOpeningModeScheduleRequest), CreateOpeningModeScheduleRequest.Parser, ["Parent", "OpeningModeScheduleId", "OpeningModeSchedule"], null, null, null, null),
            new(typeof(GetOpeningModeScheduleRequest), GetOpeningModeScheduleRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListOpeningModeSchedulesRequest), ListOpeningModeSchedulesRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListOpeningModeSchedulesResponse), ListOpeningModeSchedulesResponse.Parser, ["OpeningModeSchedules", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateOpeningModeScheduleRequest), UpdateOpeningModeScheduleRequest.Parser, ["OpeningModeSchedule", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteOpeningModeScheduleRequest), DeleteOpeningModeScheduleRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The opening mode schedule object
    /// </summary>
    public sealed partial class OpeningModeSchedule : IMessage<OpeningModeSchedule>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<OpeningModeSchedule> _parser = new(() => new OpeningModeSchedule());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<OpeningModeSchedule> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public OpeningModeSchedule()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public OpeningModeSchedule(OpeningModeSchedule other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            days_ = other.days_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public OpeningModeSchedule Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the opening mode schedule. It must have the format of
        /// `installations/*/opening-mode-schedules/*`. For example:
        /// `installations/surelock-homes-hq/opening-mode-schedules/office-24-7`.
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
        /// Display name of the opening mode schedule.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "days" field.</summary>
        public const int DaysFieldNumber = 3;
        private static readonly FieldCodec<Types.Day> _repeated_days_codec
            = FieldCodec.ForMessage(26, Types.Day.Parser);
        private readonly RepeatedField<Types.Day> days_ = [];

        /// <summary>
        /// Days when the opening mode schedule is valid.
        /// </summary>
        public RepeatedField<Types.Day> Days
        {
            get { return days_; }
        }

        public override bool Equals(object other) => Equals(other as OpeningModeSchedule);
        public bool Equals(OpeningModeSchedule other)
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
            if (!days_.Equals(other.days_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            hash ^= days_.GetHashCode();
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
      days_.WriteTo(output, _repeated_days_codec);
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
            days_.WriteTo(ref output, _repeated_days_codec);
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
            size += days_.CalculateSize(_repeated_days_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(OpeningModeSchedule other)
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
            days_.Add(other.days_);
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
          case 26: {
            days_.AddEntriesFrom(input, _repeated_days_codec);
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
                    case 26:
                        {
                            days_.AddEntriesFrom(ref input, _repeated_days_codec);
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the OpeningModeSchedule message type.</summary>
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
                    get { return OpeningModeSchedule.Descriptor.NestedTypes[0]; }
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
                    slots_ = other.slots_.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Day Clone() => new(this);
                /// <summary>Field number for the "day_type" field.</summary>
                public const int DayTypeFieldNumber = 1;
                private Type.DayType dayType_ = Type.DayType.Unspecified;

                /// <summary>
                /// Day type
                /// </summary>
                public Type.DayType DayType
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

                /// <summary>Field number for the "slots" field.</summary>
                public const int SlotsFieldNumber = 3;
                private static readonly FieldCodec<Types.Slot> _repeated_slots_codec
                    = FieldCodec.ForMessage(26, Types.Slot.Parser);
                private readonly RepeatedField<Types.Slot> slots_ = [];

                /// <summary>
                /// The slot to be applied.
                /// </summary>
                public RepeatedField<Types.Slot> Slots
                {
                    get { return slots_; }
                }

                public override bool Equals(object other) => Equals(other as Day);
                public bool Equals(Day other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (DayType != other.DayType) return false;
                    if (DayOfWeek != other.DayOfWeek) return false;
                    if (!slots_.Equals(other.slots_)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (DayType != Type.DayType.Unspecified) hash ^= DayType.GetHashCode();
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) hash ^= DayOfWeek.GetHashCode();
                    hash ^= slots_.GetHashCode();
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
          if (DayType != Saltoapis.Nebula.Type.DayType.Unspecified) {
            output.WriteRawTag(8);
            output.WriteEnum((int) DayType);
          }
          if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) {
            output.WriteRawTag(16);
            output.WriteEnum((int) DayOfWeek);
          }
          slots_.WriteTo(output, _repeated_slots_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (DayType != Type.DayType.Unspecified)
                    {
                        output.WriteRawTag(8);
                        output.WriteEnum((int)DayType);
                    }
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified)
                    {
                        output.WriteRawTag(16);
                        output.WriteEnum((int)DayOfWeek);
                    }
                    slots_.WriteTo(ref output, _repeated_slots_codec);
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (DayType != Type.DayType.Unspecified)
                    {
                        size += 1 + CodedOutputStream.ComputeEnumSize((int)DayType);
                    }
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified)
                    {
                        size += 1 + CodedOutputStream.ComputeEnumSize((int)DayOfWeek);
                    }
                    size += slots_.CalculateSize(_repeated_slots_codec);
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(Day other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.DayType != Type.DayType.Unspecified)
                    {
                        DayType = other.DayType;
                    }
                    if (other.DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified)
                    {
                        DayOfWeek = other.DayOfWeek;
                    }
                    slots_.Add(other.slots_);
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
              case 26: {
                slots_.AddEntriesFrom(input, _repeated_slots_codec);
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
                                    DayType = (Type.DayType)input.ReadEnum();
                                    break;
                                }
                            case 16:
                                {
                                    DayOfWeek = (Saltoapis.Type.DayOfWeek)input.ReadEnum();
                                    break;
                                }
                            case 26:
                                {
                                    slots_.AddEntriesFrom(ref input, _repeated_slots_codec);
                                    break;
                                }
                        }
                    }
                }
#endif

                #region Nested types
                /// <summary>Container for nested types declared in the Day message type.</summary>
                public static partial class Types
                {
                    /// <summary>
                    /// The time period in which the opening mode will be valid
                    /// </summary>
                    public sealed partial class Slot : IMessage<Slot>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                        , IBufferMessage
#endif
                    {
                        private static readonly MessageParser<Slot> _parser = new(() => new Slot());
                        private UnknownFieldSet _unknownFields;

                        public static MessageParser<Slot> Parser { get { return _parser; } }

                        public static MessageDescriptor Descriptor
                        {
                            get { return Day.Descriptor.NestedTypes[0]; }
                        }

                        MessageDescriptor IMessage.Descriptor
                        {
                            get { return Descriptor; }
                        }

                        public Slot()
                        {
                            OnConstruction();
                        }

                        partial void OnConstruction();

                        public Slot(Slot other) : this()
                        {
                            openingMode_ = other.openingMode_;
                            startTime_ = other.startTime_?.Clone();
                            endTime_ = other.endTime_?.Clone();
                            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                        }

                        public Slot Clone() => new(this);
                        /// <summary>Field number for the "opening_mode" field.</summary>
                        public const int OpeningModeFieldNumber = 1;
                        private Type.OpeningMode openingMode_ = Type.OpeningMode.Unspecified;

                        /// <summary>
                        /// The opening mode to be applied.
                        /// </summary>
                        public Type.OpeningMode OpeningMode
                        {
                            get { return openingMode_; }
                            set
                            {
                                openingMode_ = value;
                            }
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

                        public override bool Equals(object other) => Equals(other as Slot);
                        public bool Equals(Slot other)
                        {
                            if (other is null)
                            {
                                return false;
                            }
                            if (ReferenceEquals(other, this))
                            {
                                return true;
                            }
                            if (OpeningMode != other.OpeningMode) return false;
                            if (!Equals(StartTime, other.StartTime)) return false;
                            if (!Equals(EndTime, other.EndTime)) return false;
                            return Equals(_unknownFields, other._unknownFields);
                        }

                        public override int GetHashCode()
                        {
                            int hash = 1;
                            if (OpeningMode != Type.OpeningMode.Unspecified) hash ^= OpeningMode.GetHashCode();
                            if (startTime_ != null) hash ^= StartTime.GetHashCode();
                            if (endTime_ != null) hash ^= EndTime.GetHashCode();
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
              if (OpeningMode != Saltoapis.Nebula.Type.OpeningMode.Unspecified) {
                output.WriteRawTag(8);
                output.WriteEnum((int) OpeningMode);
              }
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
                            if (OpeningMode != Type.OpeningMode.Unspecified)
                            {
                                output.WriteRawTag(8);
                                output.WriteEnum((int)OpeningMode);
                            }
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
                            if (OpeningMode != Type.OpeningMode.Unspecified)
                            {
                                size += 1 + CodedOutputStream.ComputeEnumSize((int)OpeningMode);
                            }
                            if (startTime_ != null)
                            {
                                size += 1 + CodedOutputStream.ComputeMessageSize(StartTime);
                            }
                            if (endTime_ != null)
                            {
                                size += 1 + CodedOutputStream.ComputeMessageSize(EndTime);
                            }
                            if (_unknownFields != null)
                            {
                                size += _unknownFields.CalculateSize();
                            }
                            return size;
                        }

                        public void MergeFrom(Slot other)
                        {
                            if (other == null)
                            {
                                return;
                            }
                            if (other.OpeningMode != Type.OpeningMode.Unspecified)
                            {
                                OpeningMode = other.OpeningMode;
                            }
                            if (other.startTime_ != null)
                            {
                                if (startTime_ == null)
                                {
                                    StartTime = new Saltoapis.Type.TimeOfDay();
                                }
                                StartTime.MergeFrom(other.StartTime);
                            }
                            if (other.endTime_ != null)
                            {
                                if (endTime_ == null)
                                {
                                    EndTime = new Saltoapis.Type.TimeOfDay();
                                }
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
                  case 8: {
                    OpeningMode = (Saltoapis.Nebula.Type.OpeningMode) input.ReadEnum();
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
                                    case 8:
                                        {
                                            OpeningMode = (Type.OpeningMode)input.ReadEnum();
                                            break;
                                        }
                                    case 18:
                                        {
                                            if (startTime_ == null)
                                            {
                                                StartTime = new Saltoapis.Type.TimeOfDay();
                                            }
                                            input.ReadMessage(StartTime);
                                            break;
                                        }
                                    case 26:
                                        {
                                            if (endTime_ == null)
                                            {
                                                EndTime = new Saltoapis.Type.TimeOfDay();
                                            }
                                            input.ReadMessage(EndTime);
                                            break;
                                        }
                                }
                            }
                        }
#endif

                    }

                }
                #endregion

            }

        }
        #endregion

    }

    /// <summary>
    /// The request message for [`CreateOpeningModeSchedule`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.CreateOpeningModeSchedule]
    /// </summary>
    public sealed partial class CreateOpeningModeScheduleRequest : IMessage<CreateOpeningModeScheduleRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateOpeningModeScheduleRequest> _parser = new(() => new CreateOpeningModeScheduleRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateOpeningModeScheduleRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateOpeningModeScheduleRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateOpeningModeScheduleRequest(CreateOpeningModeScheduleRequest other) : this()
        {
            parent_ = other.parent_;
            openingModeScheduleId_ = other.openingModeScheduleId_;
            openingModeSchedule_ = other.openingModeSchedule_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateOpeningModeScheduleRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the opening mode
        /// schedule. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "opening_mode_schedule_id" field.</summary>
        public const int OpeningModeScheduleIdFieldNumber = 2;
        private string openingModeScheduleId_ = "";

        /// <summary>
        /// The opening mode schedule ID to use for this opening mode schedule. In
        /// case it's empty the server will autogenerate a unique identifier.
        /// </summary>
        public string OpeningModeScheduleId
        {
            get { return openingModeScheduleId_; }
            set
            {
                openingModeScheduleId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "opening_mode_schedule" field.</summary>
        public const int OpeningModeScheduleFieldNumber = 3;
        private OpeningModeSchedule openingModeSchedule_;

        /// <summary>
        /// The opening mode schedule resource to be created. Client must not set the
        /// `OpeningModeSchedule.name` field.
        /// </summary>
        public OpeningModeSchedule OpeningModeSchedule
        {
            get { return openingModeSchedule_; }
            set
            {
                openingModeSchedule_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateOpeningModeScheduleRequest);
        public bool Equals(CreateOpeningModeScheduleRequest other)
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
            if (OpeningModeScheduleId != other.OpeningModeScheduleId) return false;
            if (!Equals(OpeningModeSchedule, other.OpeningModeSchedule)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (OpeningModeScheduleId.Length != 0) hash ^= OpeningModeScheduleId.GetHashCode();
            if (openingModeSchedule_ != null) hash ^= OpeningModeSchedule.GetHashCode();
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
      if (OpeningModeScheduleId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OpeningModeScheduleId);
      }
      if (openingModeSchedule_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OpeningModeSchedule);
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
            if (OpeningModeScheduleId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(OpeningModeScheduleId);
            }
            if (openingModeSchedule_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(OpeningModeSchedule);
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
            if (OpeningModeScheduleId.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OpeningModeScheduleId);
            }
            if (openingModeSchedule_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(OpeningModeSchedule);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateOpeningModeScheduleRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.OpeningModeScheduleId.Length != 0)
            {
                OpeningModeScheduleId = other.OpeningModeScheduleId;
            }
            if (other.openingModeSchedule_ != null)
            {
                if (openingModeSchedule_ == null)
                {
                    OpeningModeSchedule = new OpeningModeSchedule();
                }
                OpeningModeSchedule.MergeFrom(other.OpeningModeSchedule);
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
            OpeningModeScheduleId = input.ReadString();
            break;
          }
          case 26: {
            if (openingModeSchedule_ == null) {
              OpeningModeSchedule = new Saltoapis.Nebula.OpeningModeSchedule.V1.OpeningModeSchedule();
            }
            input.ReadMessage(OpeningModeSchedule);
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
                            OpeningModeScheduleId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (openingModeSchedule_ == null)
                            {
                                OpeningModeSchedule = new OpeningModeSchedule();
                            }
                            input.ReadMessage(OpeningModeSchedule);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetOpeningModeSchedule`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.GetOpeningModeSchedule]
    /// </summary>
    public sealed partial class GetOpeningModeScheduleRequest : IMessage<GetOpeningModeScheduleRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetOpeningModeScheduleRequest> _parser = new(() => new GetOpeningModeScheduleRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetOpeningModeScheduleRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetOpeningModeScheduleRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetOpeningModeScheduleRequest(GetOpeningModeScheduleRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetOpeningModeScheduleRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested opening mode schedule resource. For example:
        /// `installations/surelock-homes-hq/opening-mode-schedules/office-24-7`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetOpeningModeScheduleRequest);
        public bool Equals(GetOpeningModeScheduleRequest other)
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

        public void MergeFrom(GetOpeningModeScheduleRequest other)
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
    /// The request message for [`ListOpeningModeSchedules`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.ListOpeningModeSchedules]
    /// </summary>
    public sealed partial class ListOpeningModeSchedulesRequest : IMessage<ListOpeningModeSchedulesRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListOpeningModeSchedulesRequest> _parser = new(() => new ListOpeningModeSchedulesRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListOpeningModeSchedulesRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListOpeningModeSchedulesRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListOpeningModeSchedulesRequest(ListOpeningModeSchedulesRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListOpeningModeSchedulesRequest Clone() => new(this);
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
        /// A filter that chooses which opening mode schedules to return.
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

        public override bool Equals(object other) => Equals(other as ListOpeningModeSchedulesRequest);
        public bool Equals(ListOpeningModeSchedulesRequest other)
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

        public void MergeFrom(ListOpeningModeSchedulesRequest other)
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
    /// The response message for [`ListOpeningModeSchedules`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.ListOpeningModeSchedules]
    /// </summary>
    public sealed partial class ListOpeningModeSchedulesResponse : IMessage<ListOpeningModeSchedulesResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListOpeningModeSchedulesResponse> _parser = new(() => new ListOpeningModeSchedulesResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListOpeningModeSchedulesResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListOpeningModeSchedulesResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListOpeningModeSchedulesResponse(ListOpeningModeSchedulesResponse other) : this()
        {
            openingModeSchedules_ = other.openingModeSchedules_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListOpeningModeSchedulesResponse Clone() => new(this);
        /// <summary>Field number for the "opening_mode_schedules" field.</summary>
        public const int OpeningModeSchedulesFieldNumber = 1;
        private static readonly FieldCodec<OpeningModeSchedule> _repeated_openingModeSchedules_codec
            = FieldCodec.ForMessage(10, OpeningModeSchedule.Parser);
        private readonly RepeatedField<OpeningModeSchedule> openingModeSchedules_ = [];

        /// <summary>
        /// The field name should match the noun `opening_mode_schedules` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<OpeningModeSchedule> OpeningModeSchedules
        {
            get { return openingModeSchedules_; }
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

        public override bool Equals(object other) => Equals(other as ListOpeningModeSchedulesResponse);
        public bool Equals(ListOpeningModeSchedulesResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!openingModeSchedules_.Equals(other.openingModeSchedules_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= openingModeSchedules_.GetHashCode();
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
      openingModeSchedules_.WriteTo(output, _repeated_openingModeSchedules_codec);
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
            openingModeSchedules_.WriteTo(ref output, _repeated_openingModeSchedules_codec);
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
            size += openingModeSchedules_.CalculateSize(_repeated_openingModeSchedules_codec);
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

        public void MergeFrom(ListOpeningModeSchedulesResponse other)
        {
            if (other == null)
            {
                return;
            }
            openingModeSchedules_.Add(other.openingModeSchedules_);
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
            openingModeSchedules_.AddEntriesFrom(input, _repeated_openingModeSchedules_codec);
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
                            openingModeSchedules_.AddEntriesFrom(ref input, _repeated_openingModeSchedules_codec);
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
    /// The response message for [`UpdateOpeningModeSchedule`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.UpdateOpeningModeSchedule]
    /// </summary>
    public sealed partial class UpdateOpeningModeScheduleRequest : IMessage<UpdateOpeningModeScheduleRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateOpeningModeScheduleRequest> _parser = new(() => new UpdateOpeningModeScheduleRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateOpeningModeScheduleRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateOpeningModeScheduleRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateOpeningModeScheduleRequest(UpdateOpeningModeScheduleRequest other) : this()
        {
            openingModeSchedule_ = other.openingModeSchedule_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateOpeningModeScheduleRequest Clone() => new(this);
        /// <summary>Field number for the "opening_mode_schedule" field.</summary>
        public const int OpeningModeScheduleFieldNumber = 1;
        private OpeningModeSchedule openingModeSchedule_;

        /// <summary>
        /// The opening mode schedule resource which replaces the resource on the server.
        /// </summary>
        public OpeningModeSchedule OpeningModeSchedule
        {
            get { return openingModeSchedule_; }
            set
            {
                openingModeSchedule_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateOpeningModeScheduleRequest);
        public bool Equals(UpdateOpeningModeScheduleRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(OpeningModeSchedule, other.OpeningModeSchedule)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (openingModeSchedule_ != null) hash ^= OpeningModeSchedule.GetHashCode();
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
      if (openingModeSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OpeningModeSchedule);
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
            if (openingModeSchedule_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(OpeningModeSchedule);
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
            if (openingModeSchedule_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(OpeningModeSchedule);
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

        public void MergeFrom(UpdateOpeningModeScheduleRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.openingModeSchedule_ != null)
            {
                if (openingModeSchedule_ == null)
                {
                    OpeningModeSchedule = new OpeningModeSchedule();
                }
                OpeningModeSchedule.MergeFrom(other.OpeningModeSchedule);
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
            if (openingModeSchedule_ == null) {
              OpeningModeSchedule = new Saltoapis.Nebula.OpeningModeSchedule.V1.OpeningModeSchedule();
            }
            input.ReadMessage(OpeningModeSchedule);
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
                            if (openingModeSchedule_ == null)
                            {
                                OpeningModeSchedule = new OpeningModeSchedule();
                            }
                            input.ReadMessage(OpeningModeSchedule);
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
    /// The response message for [`DeleteOpeningModeSchedule`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.DeleteOpeningModeSchedule]
    /// </summary>
    public sealed partial class DeleteOpeningModeScheduleRequest : IMessage<DeleteOpeningModeScheduleRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteOpeningModeScheduleRequest> _parser = new(() => new DeleteOpeningModeScheduleRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteOpeningModeScheduleRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteOpeningModeScheduleRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteOpeningModeScheduleRequest(DeleteOpeningModeScheduleRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteOpeningModeScheduleRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the opening mode schedule to be deleted. For example:
        /// `installations/surelock-homes-hq/opening-mode-schedules/office-24-7`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteOpeningModeScheduleRequest);
        public bool Equals(DeleteOpeningModeScheduleRequest other)
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

        public void MergeFrom(DeleteOpeningModeScheduleRequest other)
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
