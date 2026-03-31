namespace Saltoapis.Nebula.Calendar.V1.Response
{
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

        public static MessageParser<ListEventsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => CalendarReflection.Descriptor.MessageTypes[11];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

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
            get => events_;}
        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get => nextPageToken_; set => nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as ListEventsResponse);
        public bool Equals(ListEventsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!events_.Equals(other.events_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= events_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      events_.WriteTo(output, _repeated_events_codec);
      if (NextPageToken.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
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
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListEventsResponse other)
        {
            if (other == null) return;
            events_.Add(other.events_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
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
            events_.AddEntriesFrom(input, _repeated_events_codec);
            break;
          }
          case 18:
          {
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

}