namespace Saltoapis.Nebula.AccessPoint.V1.Response
{
    /// <summary>
    /// The request message for [`ListAccessPoints`][salto.nebula.accesspoint.v1.AccessPointService.ListAccessPoints]
    /// </summary>
    public sealed partial class ListAccessPointsResponse : IMessage<ListAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessPointsResponse> _parser = new(() => new ListAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessPointsResponse(ListAccessPointsResponse other) : this()
        {
            accessPoints_ = other.accessPoints_.Clone();
            nextPageToken_ = other.nextPageToken_;
            totalSize_ = other.totalSize_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_points" field.</summary>
        public const int AccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessPoint> _repeated_accessPoints_codec
            = FieldCodec.ForMessage(10, AccessPoint.Parser);
        private readonly RepeatedField<AccessPoint> accessPoints_ = [];

        /// <summary>
        /// The field name should match the noun `access_points` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<AccessPoint> AccessPoints
        {
            get { return accessPoints_; }
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

        /// <summary>Field number for the "total_size" field.</summary>
        public const int TotalSizeFieldNumber = 3;
        private int totalSize_;

        /// <summary>
        /// The total number of access points in all pages, irrespective of any pagination.
        /// This is an estimated number based on the requested filter, and it may change in
        /// subsequent pages.
        /// </summary>
        public int TotalSize
        {
            get { return totalSize_; }
            set
            {
                totalSize_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ListAccessPointsResponse);
        public bool Equals(ListAccessPointsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!accessPoints_.Equals(other.accessPoints_)) || (NextPageToken != other.NextPageToken)) return false;
            if (TotalSize != other.TotalSize) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessPoints_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (TotalSize != 0) hash ^= TotalSize.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      accessPoints_.WriteTo(output, _repeated_accessPoints_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (TotalSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TotalSize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            accessPoints_.WriteTo(ref output, _repeated_accessPoints_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            if (TotalSize != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(TotalSize);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += accessPoints_.CalculateSize(_repeated_accessPoints_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (TotalSize != 0) size += 1 + CodedOutputStream.ComputeInt32Size(TotalSize);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListAccessPointsResponse other)
        {
            if (other == null) return;
            accessPoints_.Add(other.accessPoints_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
            if (other.TotalSize != 0) TotalSize = other.TotalSize;
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
            accessPoints_.AddEntriesFrom(input, _repeated_accessPoints_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
          case 24: {
            TotalSize = input.ReadInt32();
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
                            accessPoints_.AddEntriesFrom(ref input, _repeated_accessPoints_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            TotalSize = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }


}
