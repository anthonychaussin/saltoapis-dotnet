namespace Saltoapis.Nebula.AccessRight.V1.Response
{
    /// <summary>
    /// The request message for [`ListAccessRightDestinations`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightDestinations]
    /// </summary>
    public sealed partial class ListAccessRightDestinationsResponse : IMessage<ListAccessRightDestinationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightDestinationsResponse> _parser = new(() => new ListAccessRightDestinationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightDestinationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[33]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightDestinationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightDestinationsResponse(ListAccessRightDestinationsResponse other) : this()
        {
            accessRightDestinations_ = other.accessRightDestinations_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightDestinationsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_destinations" field.</summary>
        public const int AccessRightDestinationsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightDestination> _repeated_accessRightDestinations_codec
            = FieldCodec.ForMessage(10, AccessRightDestination.Parser);
        private readonly RepeatedField<AccessRightDestination> accessRightDestinations_ = [];

        /// <summary>
        /// The field name should match the noun `access_right_destinations` in the
        /// method name. There will be a maximum number of items returned based on
        /// the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessRightDestination> AccessRightDestinations
        {
            get { return accessRightDestinations_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessRightDestinationsResponse);
        public bool Equals(ListAccessRightDestinationsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!accessRightDestinations_.Equals(other.accessRightDestinations_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightDestinations_.GetHashCode();
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
      accessRightDestinations_.WriteTo(output, _repeated_accessRightDestinations_codec);
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
            accessRightDestinations_.WriteTo(ref output, _repeated_accessRightDestinations_codec);
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
            size += accessRightDestinations_.CalculateSize(_repeated_accessRightDestinations_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListAccessRightDestinationsResponse other)
        {
            if (other == null) return;
            accessRightDestinations_.Add(other.accessRightDestinations_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
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
            accessRightDestinations_.AddEntriesFrom(input, _repeated_accessRightDestinations_codec);
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
                            accessRightDestinations_.AddEntriesFrom(ref input, _repeated_accessRightDestinations_codec);
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
