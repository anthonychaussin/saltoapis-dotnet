namespace Saltoapis.Nebula.OpeningModeSchedule.V1.Response
{
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

        public static MessageParser<ListOpeningModeSchedulesResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => OpeningModeScheduleReflection.Descriptor.MessageTypes[4];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

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
            get => openingModeSchedules_;}
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

        public override bool Equals(object other) => Equals(other as ListOpeningModeSchedulesResponse);
        public bool Equals(ListOpeningModeSchedulesResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!openingModeSchedules_.Equals(other.openingModeSchedules_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= openingModeSchedules_.GetHashCode();
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
      openingModeSchedules_.WriteTo(output, _repeated_openingModeSchedules_codec);
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
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListOpeningModeSchedulesResponse other)
        {
            if (other == null) return;
            openingModeSchedules_.Add(other.openingModeSchedules_);
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
            openingModeSchedules_.AddEntriesFrom(input, _repeated_openingModeSchedules_codec);
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

}