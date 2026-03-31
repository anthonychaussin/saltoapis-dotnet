namespace Saltoapis.Nebula.AccessPointGroup.V1.Response
{
    /// <summary>
    /// The response message for [`ListAccessPointGroups`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.ListAccessPointGroups]
    /// </summary>
    public sealed partial class ListAccessPointGroupsResponse : IMessage<ListAccessPointGroupsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessPointGroupsResponse> _parser = new(() => new ListAccessPointGroupsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessPointGroupsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessPointGroupsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessPointGroupsResponse(ListAccessPointGroupsResponse other) : this()
        {
            accessPointGroups_ = other.accessPointGroups_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessPointGroupsResponse Clone() => new(this);
        /// <summary>Field number for the "access_point_groups" field.</summary>
        public const int AccessPointGroupsFieldNumber = 1;
        private static readonly FieldCodec<AccessPointGroup> _repeated_accessPointGroups_codec
            = FieldCodec.ForMessage(10, AccessPointGroup.Parser);
        private readonly RepeatedField<AccessPointGroup> accessPointGroups_ = [];

        /// <summary>
        /// The field name should match the noun `access_point_groups` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<AccessPointGroup> AccessPointGroups
        {
            get { return accessPointGroups_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessPointGroupsResponse);
        public bool Equals(ListAccessPointGroupsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!accessPointGroups_.Equals(other.accessPointGroups_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessPointGroups_.GetHashCode();
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
      accessPointGroups_.WriteTo(output, _repeated_accessPointGroups_codec);
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
            accessPointGroups_.WriteTo(ref output, _repeated_accessPointGroups_codec);
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
            size += accessPointGroups_.CalculateSize(_repeated_accessPointGroups_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListAccessPointGroupsResponse other)
        {
            if (other == null) return;
            accessPointGroups_.Add(other.accessPointGroups_);
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
            accessPointGroups_.AddEntriesFrom(input, _repeated_accessPointGroups_codec);
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
                            accessPointGroups_.AddEntriesFrom(ref input, _repeated_accessPointGroups_codec);
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
