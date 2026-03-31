namespace Saltoapis.Nebula.Calendar.V1.Response
{
    /// <summary>
    /// The response message for [`ListCalendars`][salto.nebula.calendar.v1.CalendarService.ListCalendars]
    /// </summary>
    public sealed partial class ListCalendarsResponse : IMessage<ListCalendarsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListCalendarsResponse> _parser = new(() => new ListCalendarsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListCalendarsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => CalendarReflection.Descriptor.MessageTypes[5];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListCalendarsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListCalendarsResponse(ListCalendarsResponse other) : this()
        {
            calendars_ = other.calendars_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListCalendarsResponse Clone() => new(this);
        /// <summary>Field number for the "calendars" field.</summary>
        public const int CalendarsFieldNumber = 1;
        private static readonly FieldCodec<Calendar> _repeated_calendars_codec
            = FieldCodec.ForMessage(10, Calendar.Parser);
        private readonly RepeatedField<Calendar> calendars_ = [];
        /// <summary>
        /// The field name should match the noun `calendars` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<Calendar> Calendars
        {
            get => calendars_;}
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

        public override bool Equals(object other) => Equals(other as ListCalendarsResponse);
        public bool Equals(ListCalendarsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!calendars_.Equals(other.calendars_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= calendars_.GetHashCode();
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
      calendars_.WriteTo(output, _repeated_calendars_codec);
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
            calendars_.WriteTo(ref output, _repeated_calendars_codec);
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
            size += calendars_.CalculateSize(_repeated_calendars_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListCalendarsResponse other)
        {
            if (other == null) return;
            calendars_.Add(other.calendars_);
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
            calendars_.AddEntriesFrom(input, _repeated_calendars_codec);
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
                            calendars_.AddEntriesFrom(ref input, _repeated_calendars_codec);
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