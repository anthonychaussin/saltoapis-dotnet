namespace Saltoapis.Type
{
    public sealed partial class Interval : IMessage<Interval>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Interval> _parser = new(() => new Interval());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Interval> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => IntervalReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public Interval()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Interval(Interval other) : this()
        {
            startTime_ = other.startTime_?.Clone();
            endTime_ = other.endTime_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Interval Clone() => new(this);
        /// <summary>Field number for the "start_time" field.</summary>
        public const int StartTimeFieldNumber = 1;
        private Google.Protobuf.WellKnownTypes.Timestamp startTime_;
        /// <summary>
        /// The start time of the interval.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp StartTime
        {
            get => startTime_; set => startTime_ = value;}
        /// <summary>Field number for the "end_time" field.</summary>
        public const int EndTimeFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.Timestamp endTime_;
        /// <summary>
        /// The end time of the interval.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp EndTime
        {
            get => endTime_; set => endTime_ = value;}

        public override bool Equals(object other) => Equals(other as Interval);
        public bool Equals(Interval other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(StartTime, other.StartTime)) || (!Equals(EndTime, other.EndTime))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (startTime_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null)
      {
        output.WriteRawTag(18);
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
            if (startTime_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(StartTime);
            }
            if (endTime_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(EndTime);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (startTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(StartTime);
            if (endTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EndTime);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Interval other)
        {
            if (other == null) return;
            if (other.startTime_ != null)
            {
                if (startTime_ == null) StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                StartTime.MergeFrom(other.StartTime);
            }
            if (other.endTime_ != null)
            {
                if (endTime_ == null) EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
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
          case 10:
          {
            if (startTime_ == null)
            {
              StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 18:
          {
            if (endTime_ == null)
            {
              EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
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
                            if (startTime_ == null) StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(StartTime);
                            break;
                        }
                    case 18:
                        {
                            if (endTime_ == null) EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(EndTime);
                            break;
                        }
                }
            }
        }
#endif
    }
}