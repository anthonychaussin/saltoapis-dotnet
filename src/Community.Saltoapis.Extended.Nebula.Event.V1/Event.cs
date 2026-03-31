namespace Saltoapis.Nebula.Event.V1
{
    /// <summary>
    /// The event object
    /// </summary>
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
            get { return EventReflection.Descriptor.MessageTypes[0]; }
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
            type_ = other.type_;
            resource_ = other.resource_;
            createTime_ = other.createTime_?.Clone();
            occurTime_ = other.occurTime_?.Clone();
            data_ = other.data_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Event Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the event. It must have the format
        /// `installations/*/events/*`. For example:
        /// `installations/surelock-homes-hq/events/01ARZ3NDEKTSV4RRFFQ69G5FAV`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private string type_ = "";

        /// <summary>
        /// Type of occurrence which has taken place. Often this attribute is used
        /// for routing, observability, policy enforcement, etc.
        /// </summary>
        public string Type
        {
            get { return type_; }
            set
            {
                type_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "resource" field.</summary>
        public const int ResourceFieldNumber = 3;
        private string resource_ = "";

        /// <summary>
        /// This describes the event producer.
        /// </summary>
        public string Resource
        {
            get { return resource_; }
            set
            {
                resource_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "create_time" field.</summary>
        public const int CreateTimeFieldNumber = 4;
        private Google.Protobuf.WellKnownTypes.Timestamp createTime_;

        /// <summary>
        /// Timestamp of when the event has been created.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp CreateTime
        {
            get { return createTime_; }
            set
            {
                createTime_ = value;
            }
        }

        /// <summary>Field number for the "occur_time" field.</summary>
        public const int OccurTimeFieldNumber = 5;
        private Google.Protobuf.WellKnownTypes.Timestamp occurTime_;

        /// <summary>
        /// Timestamp of when the occurrence took place. If the time of the
        /// occurrence cannot be determined then this attribute is set to the current
        /// time by the producer. All producers for the type of event are consistent
        /// in this respect.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp OccurTime
        {
            get { return occurTime_; }
            set
            {
                occurTime_ = value;
            }
        }

        /// <summary>Field number for the "data" field.</summary>
        public const int DataFieldNumber = 6;
        private Google.Protobuf.WellKnownTypes.Struct data_;

        /// <summary>
        /// The event entry payload, represented as a structure that is
        /// expressed as a JSON object.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Struct Data
        {
            get { return data_; }
            set
            {
                data_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Event);
        public bool Equals(Event other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (Type != other.Type)) return false;
            if ((Resource != other.Resource) || (!Equals(CreateTime, other.CreateTime))) return false;
            if ((!Equals(OccurTime, other.OccurTime)) || (!Equals(Data, other.Data))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Type.Length != 0) hash ^= Type.GetHashCode();
            if (Resource.Length != 0) hash ^= Resource.GetHashCode();
            if (createTime_ != null) hash ^= CreateTime.GetHashCode();
            if (occurTime_ != null) hash ^= OccurTime.GetHashCode();
            if (data_ != null) hash ^= Data.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (Resource.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Resource);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (occurTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(OccurTime);
      }
      if (data_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Data);
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
            if (Type.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Type);
            }
            if (Resource.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Resource);
            }
            if (createTime_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(CreateTime);
            }
            if (occurTime_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(OccurTime);
            }
            if (data_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(Data);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (Type.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Type);
            if (Resource.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Resource);
            if (createTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(CreateTime);
            if (occurTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(OccurTime);
            if (data_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Data);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Event other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.Type.Length != 0) Type = other.Type;
            if (other.Resource.Length != 0) Resource = other.Resource;
            if (other.createTime_ != null)
            {
                if (createTime_ == null) CreateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                CreateTime.MergeFrom(other.CreateTime);
            }
            if (other.occurTime_ != null)
            {
                if (occurTime_ == null) OccurTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                OccurTime.MergeFrom(other.OccurTime);
            }
            if (other.data_ != null)
            {
                if (data_ == null) Data = new Google.Protobuf.WellKnownTypes.Struct();
                Data.MergeFrom(other.Data);
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
            Type = input.ReadString();
            break;
          }
          case 26: {
            Resource = input.ReadString();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (occurTime_ == null) {
              OccurTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(OccurTime);
            break;
          }
          case 50: {
            if (data_ == null) {
              Data = new Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Data);
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
                            Type = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Resource = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            if (createTime_ == null) CreateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(CreateTime);
                            break;
                        }
                    case 42:
                        {
                            if (occurTime_ == null) OccurTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(OccurTime);
                            break;
                        }
                    case 50:
                        {
                            if (data_ == null) Data = new Google.Protobuf.WellKnownTypes.Struct();
                            input.ReadMessage(Data);
                            break;
                        }
                }
            }
        }
#endif

    }
}
