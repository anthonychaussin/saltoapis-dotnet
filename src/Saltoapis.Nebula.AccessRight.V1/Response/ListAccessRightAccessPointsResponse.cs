namespace Saltoapis.Nebula.AccessRight.V1.Response
{
    /// <summary>
    /// The request message for [`ListAccessRightAccessPoints`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightAccessPoints]
    /// </summary>
    public sealed partial class ListAccessRightAccessPointsResponse : IMessage<ListAccessRightAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightAccessPointsResponse> _parser = new(() => new ListAccessRightAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightAccessPointsResponse(ListAccessRightAccessPointsResponse other) : this()
        {
            accessRightAccessPoints_ = other.accessRightAccessPoints_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_points" field.</summary>
        public const int AccessRightAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPoint> _repeated_accessRightAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPoint.Parser);
        private readonly RepeatedField<AccessRightAccessPoint> accessRightAccessPoints_ = [];

        /// <summary>
        /// The field name should match the noun `access_right_access_points` in the
        /// method name. There will be a maximum number of items returned based on
        /// the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessRightAccessPoint> AccessRightAccessPoints
        {
            get { return accessRightAccessPoints_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessRightAccessPointsResponse);
        public bool Equals(ListAccessRightAccessPointsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!accessRightAccessPoints_.Equals(other.accessRightAccessPoints_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPoints_.GetHashCode();
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
      accessRightAccessPoints_.WriteTo(output, _repeated_accessRightAccessPoints_codec);
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
            accessRightAccessPoints_.WriteTo(ref output, _repeated_accessRightAccessPoints_codec);
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
            size += accessRightAccessPoints_.CalculateSize(_repeated_accessRightAccessPoints_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListAccessRightAccessPointsResponse other)
        {
            if (other == null) return;
            accessRightAccessPoints_.Add(other.accessRightAccessPoints_);
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
            accessRightAccessPoints_.AddEntriesFrom(input, _repeated_accessRightAccessPoints_codec);
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
                            accessRightAccessPoints_.AddEntriesFrom(ref input, _repeated_accessRightAccessPoints_codec);
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
