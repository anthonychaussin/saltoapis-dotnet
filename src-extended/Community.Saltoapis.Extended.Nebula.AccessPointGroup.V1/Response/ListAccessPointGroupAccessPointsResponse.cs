namespace Saltoapis.Nebula.AccessPointGroup.V1.Response
{
    /// <summary>
    /// The request message for [`ListAccessPointGroupAccessPoints`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.ListAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class ListAccessPointGroupAccessPointsResponse : IMessage<ListAccessPointGroupAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessPointGroupAccessPointsResponse> _parser = new(() => new ListAccessPointGroupAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessPointGroupAccessPointsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessPointGroupReflection.Descriptor.MessageTypes[13];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListAccessPointGroupAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessPointGroupAccessPointsResponse(ListAccessPointGroupAccessPointsResponse other) : this()
        {
            accessPointGroupAccessPoints_ = other.accessPointGroupAccessPoints_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessPointGroupAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_point_group_access_points" field.</summary>
        public const int AccessPointGroupAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessPointGroupAccessPoint> _repeated_accessPointGroupAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessPointGroupAccessPoint.Parser);
        private readonly RepeatedField<AccessPointGroupAccessPoint> accessPointGroupAccessPoints_ = [];
        /// <summary>
        /// The field name should match the noun `access_point_group_access_points`
        /// in the method name. There will be a maximum number of items returned
        /// based on the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessPointGroupAccessPoint> AccessPointGroupAccessPoints
        {
            get => accessPointGroupAccessPoints_;}
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

        public override bool Equals(object other) => Equals(other as ListAccessPointGroupAccessPointsResponse);
        public bool Equals(ListAccessPointGroupAccessPointsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!accessPointGroupAccessPoints_.Equals(other.accessPointGroupAccessPoints_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessPointGroupAccessPoints_.GetHashCode();
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
      accessPointGroupAccessPoints_.WriteTo(output, _repeated_accessPointGroupAccessPoints_codec);
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
            accessPointGroupAccessPoints_.WriteTo(ref output, _repeated_accessPointGroupAccessPoints_codec);
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
            size += accessPointGroupAccessPoints_.CalculateSize(_repeated_accessPointGroupAccessPoints_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListAccessPointGroupAccessPointsResponse other)
        {
            if (other == null) return;
            accessPointGroupAccessPoints_.Add(other.accessPointGroupAccessPoints_);
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
            accessPointGroupAccessPoints_.AddEntriesFrom(input, _repeated_accessPointGroupAccessPoints_codec);
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
                            accessPointGroupAccessPoints_.AddEntriesFrom(ref input, _repeated_accessPointGroupAccessPoints_codec);
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