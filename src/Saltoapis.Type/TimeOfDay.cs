namespace Saltoapis.Type
{

    /// <summary>Holder for reflection information generated from salto/type/time_of_day.proto</summary>
    public static partial class TimeOfDayReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/type/time_of_day.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static TimeOfDayReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "ChxzYWx0by90eXBlL3RpbWVfb2ZfZGF5LnByb3RvEgpzYWx0by50eXBlIksK",
                  "CVRpbWVPZkRheRINCgVob3VycxgBIAEoBRIPCgdtaW51dGVzGAIgASgFEg8K",
                  "B3NlY29uZHMYAyABKAUSDQoFbmFub3MYBCABKAVCqgEKEmNvbS5zYWx0b2Fw",
                  "aXMudHlwZUIOVGltZU9mRGF5UHJvdG9QAVpDZ2l0aHViLmNvbS9zYWx0b2Fw",
                  "aXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL3R5cGUvdGltZW9mZGF5O3RpbWVv",
                  "ZmRheaoCDlNhbHRvYXBpcy5UeXBlygIOU2FsdG9hcGlzXFR5cGXiAhpHUEJN",
                  "ZXRhZGF0YVxTYWx0b2FwaXNcVHlwZWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(TimeOfDay), TimeOfDay.Parser, ["Hours", "Minutes", "Seconds", "Nanos"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant
    /// or are specified elsewhere. An API may chose to allow leap seconds. Related
    /// types are [`salto.type.Date`][salto.type.Date] and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public sealed partial class TimeOfDay : IMessage<TimeOfDay>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TimeOfDay> _parser = new(() => new TimeOfDay());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TimeOfDay> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TimeOfDayReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TimeOfDay()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TimeOfDay(TimeOfDay other) : this()
        {
            hours_ = other.hours_;
            minutes_ = other.minutes_;
            seconds_ = other.seconds_;
            nanos_ = other.nanos_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TimeOfDay Clone() => new(this);

        /// <summary>Field number for the "hours" field.</summary>
        public const int HoursFieldNumber = 1;
        private int hours_;

        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23.
        /// </summary>
        public int Hours
        {
            get { return hours_; }
            set
            {
                hours_ = value;
            }
        }

        /// <summary>Field number for the "minutes" field.</summary>
        public const int MinutesFieldNumber = 2;
        private int minutes_;

        /// <summary>
        /// Minutes of hour of day. Must be from 0 to 59.
        /// </summary>
        public int Minutes
        {
            get { return minutes_; }
            set
            {
                minutes_ = value;
            }
        }

        /// <summary>Field number for the "seconds" field.</summary>
        public const int SecondsFieldNumber = 3;
        private int seconds_;

        /// <summary>
        /// Seconds of minutes of the time. Must be from 0 to 59.
        /// </summary>
        public int Seconds
        {
            get { return seconds_; }
            set
            {
                seconds_ = value;
            }
        }

        /// <summary>Field number for the "nanos" field.</summary>
        public const int NanosFieldNumber = 4;
        private int nanos_;

        /// <summary>
        /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
        /// </summary>
        public int Nanos
        {
            get { return nanos_; }
            set
            {
                nanos_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as TimeOfDay);
        public bool Equals(TimeOfDay other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Hours != other.Hours
                || Minutes != other.Minutes
                || Seconds != other.Seconds
                || Nanos != other.Nanos) return false;

            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Hours != 0) hash ^= Hours.GetHashCode();
            if (Minutes != 0) hash ^= Minutes.GetHashCode();
            if (Seconds != 0) hash ^= Seconds.GetHashCode();
            if (Nanos != 0) hash ^= Nanos.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Hours != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Hours);
      }
      if (Minutes != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Minutes);
      }
      if (Seconds != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Nanos);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Hours != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(Hours);
            }
            if (Minutes != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(Minutes);
            }
            if (Seconds != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(Seconds);
            }
            if (Nanos != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(Nanos);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Hours != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Hours);
            if (Minutes != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Minutes);
            if (Seconds != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Seconds);
            if (Nanos != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Nanos);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(TimeOfDay other)
        {
            if (other == null) return;
            if (other.Hours != 0) Hours = other.Hours;
            if (other.Minutes != 0) Minutes = other.Minutes;
            if (other.Seconds != 0) Seconds = other.Seconds;
            if (other.Nanos != 0) Nanos = other.Nanos;
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
            Hours = input.ReadInt32();
            break;
          }
          case 16: {
            Minutes = input.ReadInt32();
            break;
          }
          case 24: {
            Seconds = input.ReadInt32();
            break;
          }
          case 32: {
            Nanos = input.ReadInt32();
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
                            Hours = input.ReadInt32();
                            break;
                        }
                    case 16:
                        {
                            Minutes = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            Seconds = input.ReadInt32();
                            break;
                        }
                    case 32:
                        {
                            Nanos = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }

    #endregion

}
