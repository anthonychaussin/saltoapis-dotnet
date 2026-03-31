namespace Saltoapis.Nebula.IntercomAdaptor.V1.Response
{
    /// <summary>
    /// The response message for [ListIntercomAdaptors][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ListIntercomAdaptors]
    /// </summary>
    public sealed partial class ListIntercomAdaptorsResponse : IMessage<ListIntercomAdaptorsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListIntercomAdaptorsResponse> _parser = new(() => new ListIntercomAdaptorsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListIntercomAdaptorsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => IntercomAdaptorReflection.Descriptor.MessageTypes[5];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListIntercomAdaptorsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListIntercomAdaptorsResponse(ListIntercomAdaptorsResponse other) : this()
        {
            intercomAdaptors_ = other.intercomAdaptors_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListIntercomAdaptorsResponse Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptors" field.</summary>
        public const int IntercomAdaptorsFieldNumber = 1;
        private static readonly FieldCodec<IntercomAdaptor> _repeated_intercomAdaptors_codec
            = FieldCodec.ForMessage(10, IntercomAdaptor.Parser);
        private readonly RepeatedField<IntercomAdaptor> intercomAdaptors_ = [];
        /// <summary>
        /// The field name should match the noun `intercom_adaptors` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<IntercomAdaptor> IntercomAdaptors
        {
            get => intercomAdaptors_;}
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

        public override bool Equals(object other) => Equals(other as ListIntercomAdaptorsResponse);
        public bool Equals(ListIntercomAdaptorsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!intercomAdaptors_.Equals(other.intercomAdaptors_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= intercomAdaptors_.GetHashCode();
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
      intercomAdaptors_.WriteTo(output, _repeated_intercomAdaptors_codec);
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
            intercomAdaptors_.WriteTo(ref output, _repeated_intercomAdaptors_codec);
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
            size += intercomAdaptors_.CalculateSize(_repeated_intercomAdaptors_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListIntercomAdaptorsResponse other)
        {
            if (other == null) return;
            intercomAdaptors_.Add(other.intercomAdaptors_);
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
            intercomAdaptors_.AddEntriesFrom(input, _repeated_intercomAdaptors_codec);
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
                            intercomAdaptors_.AddEntriesFrom(ref input, _repeated_intercomAdaptors_codec);
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