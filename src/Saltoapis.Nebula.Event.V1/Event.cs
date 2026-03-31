using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Event.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/event/v1/event.proto</summary>
    public static partial class EventReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/event/v1/event.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static EventReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiFzYWx0by9uZWJ1bGEvZXZlbnQvdjEvZXZlbnQucHJvdG8SFXNhbHRvLm5l",
                  "YnVsYS5ldmVudC52MRocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxof",
                  "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byK9AQoFRXZlbnQSDAoE",
                  "bmFtZRgBIAEoCRIMCgR0eXBlGAIgASgJEhAKCHJlc291cmNlGAMgASgJEi8K",
                  "C2NyZWF0ZV90aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
                  "cBIuCgpvY2N1cl90aW1lGAUgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
                  "dGFtcBIlCgRkYXRhGAYgASgLMhcuZ29vZ2xlLnByb3RvYnVmLlN0cnVjdCIf",
                  "Cg9HZXRFdmVudFJlcXVlc3QSDAoEbmFtZRgBIAEoCSJsChFMaXN0RXZlbnRz",
                  "UmVxdWVzdBIOCgZwYXJlbnQYASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIK",
                  "CnBhZ2VfdG9rZW4YAyABKAkSDgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5",
                  "GAUgASgJIlsKEkxpc3RFdmVudHNSZXNwb25zZRIsCgZldmVudHMYASADKAsy",
                  "HC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuRXZlbnQSFwoPbmV4dF9wYWdlX3Rv",
                  "a2VuGAIgASgJMsMBCgxFdmVudFNlcnZpY2USUAoIR2V0RXZlbnQSJi5zYWx0",
                  "by5uZWJ1bGEuZXZlbnQudjEuR2V0RXZlbnRSZXF1ZXN0Ghwuc2FsdG8ubmVi",
                  "dWxhLmV2ZW50LnYxLkV2ZW50EmEKCkxpc3RFdmVudHMSKC5zYWx0by5uZWJ1",
                  "bGEuZXZlbnQudjEuTGlzdEV2ZW50c1JlcXVlc3QaKS5zYWx0by5uZWJ1bGEu",
                  "ZXZlbnQudjEuTGlzdEV2ZW50c1Jlc3BvbnNlQs8BCh1jb20uc2FsdG9hcGlz",
                  "Lm5lYnVsYS5ldmVudC52MUIKRXZlbnRQcm90b1ABWkBnaXRodWIuY29tL3Nh",
                  "bHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL2V2ZW50L3Yx",
                  "O2V2ZW50qgIZU2FsdG9hcGlzLk5lYnVsYS5FdmVudC5WMcoCGVNhbHRvYXBp",
                  "c1xOZWJ1bGFcRXZlbnRcVjHiAiVHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVi",
                  "dWxhXEV2ZW50XFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Event), Event.Parser, ["Name", "Type", "Resource", "CreateTime", "OccurTime", "Data"], null, null, null, null),
            new(typeof(GetEventRequest), GetEventRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListEventsRequest), ListEventsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListEventsResponse), ListEventsResponse.Parser, ["Events", "NextPageToken"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (Type != other.Type) return false;
            if (Resource != other.Resource) return false;
            if (!Equals(CreateTime, other.CreateTime)) return false;
            if (!Equals(OccurTime, other.OccurTime)) return false;
            if (!Equals(Data, other.Data)) return false;
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
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (Type.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Type);
            }
            if (Resource.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Resource);
            }
            if (createTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(CreateTime);
            }
            if (occurTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(OccurTime);
            }
            if (data_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Data);
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
            if (other.Type.Length != 0)
            {
                Type = other.Type;
            }
            if (other.Resource.Length != 0)
            {
                Resource = other.Resource;
            }
            if (other.createTime_ != null)
            {
                if (createTime_ == null)
                {
                    CreateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                CreateTime.MergeFrom(other.CreateTime);
            }
            if (other.occurTime_ != null)
            {
                if (occurTime_ == null)
                {
                    OccurTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                OccurTime.MergeFrom(other.OccurTime);
            }
            if (other.data_ != null)
            {
                if (data_ == null)
                {
                    Data = new Google.Protobuf.WellKnownTypes.Struct();
                }
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
                            if (createTime_ == null)
                            {
                                CreateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(CreateTime);
                            break;
                        }
                    case 42:
                        {
                            if (occurTime_ == null)
                            {
                                OccurTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(OccurTime);
                            break;
                        }
                    case 50:
                        {
                            if (data_ == null)
                            {
                                Data = new Google.Protobuf.WellKnownTypes.Struct();
                            }
                            input.ReadMessage(Data);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetEvent`][salto.nebula.event.v1.EventService.GetEvent]
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
            get { return EventReflection.Descriptor.MessageTypes[1]; }
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
        /// The name of the requested event resource. For example:
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
    /// The request message for [`ListEvents`][salto.nebula.event.v1.EventService.ListEvents]
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
            get { return EventReflection.Descriptor.MessageTypes[2]; }
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
        /// A filter that chooses which events to return.
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
    /// The response message for [`ListEvents`][salto.nebula.event.v1.EventService.ListEvents]
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
            get { return EventReflection.Descriptor.MessageTypes[3]; }
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
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
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

    #endregion

}
