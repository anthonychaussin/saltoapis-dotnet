namespace Saltoapis.Nebula.OpeningModeSchedule.V1
{
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

        public static MessageParser<OpeningModeSchedule> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => OpeningModeScheduleReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

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
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the opening mode schedule.
        /// </summary>
        public string DisplayName
        {
            get => displayName_; set => displayName_ = ProtoPreconditions.CheckNotNull(value, "value");}
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
            get => days_;}

        public override bool Equals(object other) => Equals(other as OpeningModeSchedule);
        public bool Equals(OpeningModeSchedule other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName) || !days_.Equals(other.days_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            hash ^= days_.GetHashCode();
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
      if (DisplayName.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      days_.WriteTo(output, _repeated_days_codec);
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
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            size += days_.CalculateSize(_repeated_days_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(OpeningModeSchedule other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            days_.Add(other.days_);
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
            DisplayName = input.ReadString();
            break;
          }
          case 26:
          {
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

                public static MessageParser<Day> Parser { get => _parser;}

                public static MessageDescriptor Descriptor
                {
                    get => OpeningModeSchedule.Descriptor.NestedTypes[0];}

                MessageDescriptor IMessage.Descriptor
                {
                    get => Descriptor;}

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
                    get => dayType_; set => dayType_ = value;}
                /// <summary>Field number for the "day_of_week" field.</summary>
                public const int DayOfWeekFieldNumber = 2;
                private Saltoapis.Type.DayOfWeek dayOfWeek_ = Saltoapis.Type.DayOfWeek.Unspecified;
                /// <summary>
                /// In case `day_type` is `NORMAL`, the specific day of the week.
                /// </summary>
                public Saltoapis.Type.DayOfWeek DayOfWeek
                {
                    get => dayOfWeek_; set => dayOfWeek_ = value;}
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
                    get => slots_;}

                public override bool Equals(object other) => Equals(other as Day);
                public bool Equals(Day other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((DayType != other.DayType) || (DayOfWeek != other.DayOfWeek) || !slots_.Equals(other.slots_)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (DayType != Type.DayType.Unspecified) hash ^= DayType.GetHashCode();
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) hash ^= DayOfWeek.GetHashCode();
                    hash ^= slots_.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (DayType != Saltoapis.Nebula.Type.DayType.Unspecified)
          {
            output.WriteRawTag(8);
            output.WriteEnum((int) DayType);
          }
          if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified)
          {
            output.WriteRawTag(16);
            output.WriteEnum((int) DayOfWeek);
          }
          slots_.WriteTo(output, _repeated_slots_codec);
          if (_unknownFields != null)
          {
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
                    if (DayType != Type.DayType.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)DayType);
                    if (DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)DayOfWeek);
                    size += slots_.CalculateSize(_repeated_slots_codec);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(Day other)
                {
                    if (other == null) return;
                    if (other.DayType != Type.DayType.Unspecified) DayType = other.DayType;
                    if (other.DayOfWeek != Saltoapis.Type.DayOfWeek.Unspecified) DayOfWeek = other.DayOfWeek;
                    slots_.Add(other.slots_);
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
              case 8:
              {
                DayType = (Saltoapis.Nebula.Type.DayType) input.ReadEnum();
                break;
              }
              case 16:
              {
                DayOfWeek = (Saltoapis.Type.DayOfWeek) input.ReadEnum();
                break;
              }
              case 26:
              {
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

                        public static MessageParser<Slot> Parser { get => _parser;}

                        public static MessageDescriptor Descriptor
                        {
                            get => Day.Descriptor.NestedTypes[0];}

                        MessageDescriptor IMessage.Descriptor
                        {
                            get => Descriptor;}

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
                            get => openingMode_; set => openingMode_ = value;}
                        /// <summary>Field number for the "start_time" field.</summary>
                        public const int StartTimeFieldNumber = 2;
                        private Saltoapis.Type.TimeOfDay startTime_;
                        /// <summary>
                        /// Start time of day when schedule starts being valid.
                        /// </summary>
                        public Saltoapis.Type.TimeOfDay StartTime
                        {
                            get => startTime_; set => startTime_ = value;}
                        /// <summary>Field number for the "end_time" field.</summary>
                        public const int EndTimeFieldNumber = 3;
                        private Saltoapis.Type.TimeOfDay endTime_;
                        /// <summary>
                        /// End time of day when schedule ends being valid.
                        /// </summary>
                        public Saltoapis.Type.TimeOfDay EndTime
                        {
                            get => endTime_; set => endTime_ = value;}

                        public override bool Equals(object other) => Equals(other as Slot);
                        public bool Equals(Slot other)
                        {
                            if (other is null) return false;
                            if (ReferenceEquals(other, this)) return true;
                            if ((OpeningMode != other.OpeningMode) || (!Equals(StartTime, other.StartTime)) || !Equals(EndTime, other.EndTime)) return false;
                            return Equals(_unknownFields, other._unknownFields);
                        }

                        public override int GetHashCode()
                        {
                            int hash = 1;
                            if (OpeningMode != Type.OpeningMode.Unspecified) hash ^= OpeningMode.GetHashCode();
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
              if (OpeningMode != Saltoapis.Nebula.Type.OpeningMode.Unspecified)
              {
                output.WriteRawTag(8);
                output.WriteEnum((int) OpeningMode);
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
              if (_unknownFields != null)
              {
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
                            if (OpeningMode != Type.OpeningMode.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)OpeningMode);
                            if (startTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(StartTime);
                            if (endTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EndTime);
                            if (_unknownFields != null) size += _unknownFields.CalculateSize();
                            return size;
                        }

                        public void MergeFrom(Slot other)
                        {
                            if (other == null) return;
                            if (other.OpeningMode != Type.OpeningMode.Unspecified) OpeningMode = other.OpeningMode;
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
                  case 8:
                  {
                    OpeningMode = (Saltoapis.Nebula.Type.OpeningMode) input.ReadEnum();
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
                    }
                }
            }
        }
    }
}