namespace Saltoapis.Type
{
    public sealed partial class Date : IMessage<Date>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Date> _parser = new(() => new Date());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Date> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => DateReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public Date()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Date(Date other) : this()
        {
            year_ = other.year_;
            month_ = other.month_;
            day_ = other.day_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Date Clone() => new(this);
        /// <summary>Field number for the "year" field.</summary>
        public const int YearFieldNumber = 1;
        private int year_;
        /// <summary>
        /// Year of date. Must be from 1 to 9999, or 0 if specifying a date without a
        /// year.
        /// </summary>
        public int Year
        {
            get => year_; set => year_ = value;}
        /// <summary>Field number for the "month" field.</summary>
        public const int MonthFieldNumber = 2;
        private int month_;
        /// <summary>
        /// Month of year. Must be from 1 to 12.
        /// </summary>
        public int Month
        {
            get => month_; set => month_ = value;}
        /// <summary>Field number for the "day" field.</summary>
        public const int DayFieldNumber = 3;
        private int day_;
        /// <summary>
        /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0
        /// if specifying a year/month where the day is not significant.
        /// </summary>
        public int Day
        {
            get => day_; set => day_ = value;}

        public override bool Equals(object other) => Equals(other as Date);
        public bool Equals(Date other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Year != other.Year) || (Month != other.Month) || Day != other.Day) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Year != 0) hash ^= Year.GetHashCode();
            if (Month != 0) hash ^= Month.GetHashCode();
            if (Day != 0) hash ^= Day.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Year != 0)
      {
        output.WriteRawTag(8);
        output.WriteInt32(Year);
      }
      if (Month != 0)
      {
        output.WriteRawTag(16);
        output.WriteInt32(Month);
      }
      if (Day != 0)
      {
        output.WriteRawTag(24);
        output.WriteInt32(Day);
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
            if (Year != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Year);
            }
            if (Month != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Month);
            }
            if (Day != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(Day);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Year != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Year);
            if (Month != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Month);
            if (Day != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Day);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Date other)
        {
            if (other == null) return;
            if (other.Year != 0) Year = other.Year;
            if (other.Month != 0) Month = other.Month;
            if (other.Day != 0) Day = other.Day;
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
            Year = input.ReadInt32();
            break;
          }
          case 16:
          {
            Month = input.ReadInt32();
            break;
          }
          case 24:
          {
            Day = input.ReadInt32();
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
                            Year = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            Month = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            Day = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif
    }
}