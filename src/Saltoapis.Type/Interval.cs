namespace Saltoapis.Type
{

    /// <summary>Holder for reflection information generated from salto/type/interval.proto</summary>
    public static partial class IntervalReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/type/interval.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static IntervalReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "ChlzYWx0by90eXBlL2ludGVydmFsLnByb3RvEgpzYWx0by50eXBlGh9nb29n",
                  "bGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvImgKCEludGVydmFsEi4KCnN0",
                  "YXJ0X3RpbWUYASABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEiwK",
                  "CGVuZF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEKn",
                  "AQoSY29tLnNhbHRvYXBpcy50eXBlQg1JbnRlcnZhbFByb3RvUAFaQWdpdGh1",
                  "Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby90eXBlL2lu",
                  "dGVydmFsO2ludGVydmFsqgIOU2FsdG9hcGlzLlR5cGXKAg5TYWx0b2FwaXNc",
                  "VHlwZeICGkdQQk1ldGFkYXRhXFNhbHRvYXBpc1xUeXBlYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Interval), Interval.Parser, ["StartTime", "EndTime"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// Represents a time interval with a start and end time.
    /// </summary>
    public sealed partial class Interval : IMessage<Interval>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Interval> _parser = new(() => new Interval());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Interval> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntervalReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

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
            get { return startTime_; }
            set
            {
                startTime_ = value;
            }
        }

        /// <summary>Field number for the "end_time" field.</summary>
        public const int EndTimeFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.Timestamp endTime_;

        /// <summary>
        /// The end time of the interval.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp EndTime
        {
            get { return endTime_; }
            set
            {
                endTime_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Interval);
        public bool Equals(Interval other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(StartTime, other.StartTime)) return false;
            if (!Equals(EndTime, other.EndTime)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (startTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
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

        public void MergeFrom(Interval other)
        {
            if (other == null)
            {
                return;
            }
            if (other.startTime_ != null)
            {
                if (startTime_ == null)
                {
                    StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                StartTime.MergeFrom(other.StartTime);
            }
            if (other.endTime_ != null)
            {
                if (endTime_ == null)
                {
                    EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
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
          case 10: {
            if (startTime_ == null) {
              StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 18: {
            if (endTime_ == null) {
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
        }
#endif

    }

    #endregion

}
