namespace Saltoapis.Nebula.AccessRight.V1.Response
{
    /// <summary>
    /// The request message for [`ListAccessRightAccessPointGroups`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class ListAccessRightAccessPointGroupsResponse : IMessage<ListAccessRightAccessPointGroupsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightAccessPointGroupsResponse> _parser = new(() => new ListAccessRightAccessPointGroupsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightAccessPointGroupsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[23];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListAccessRightAccessPointGroupsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightAccessPointGroupsResponse(ListAccessRightAccessPointGroupsResponse other) : this()
        {
            accessRightAccessPointGroups_ = other.accessRightAccessPointGroups_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightAccessPointGroupsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point_groups" field.</summary>
        public const int AccessRightAccessPointGroupsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPointGroup> _repeated_accessRightAccessPointGroups_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPointGroup.Parser);
        private readonly RepeatedField<AccessRightAccessPointGroup> accessRightAccessPointGroups_ = [];
        /// <summary>
        /// The field name should match the noun `access_right_access_point_groups`
        /// in the method name. There will be a maximum number of items returned
        /// based on the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessRightAccessPointGroup> AccessRightAccessPointGroups
        {
            get => accessRightAccessPointGroups_;}
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

        public override bool Equals(object other) => Equals(other as ListAccessRightAccessPointGroupsResponse);
        public bool Equals(ListAccessRightAccessPointGroupsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!accessRightAccessPointGroups_.Equals(other.accessRightAccessPointGroups_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPointGroups_.GetHashCode();
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
      accessRightAccessPointGroups_.WriteTo(output, _repeated_accessRightAccessPointGroups_codec);
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
            accessRightAccessPointGroups_.WriteTo(ref output, _repeated_accessRightAccessPointGroups_codec);
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
            size += accessRightAccessPointGroups_.CalculateSize(_repeated_accessRightAccessPointGroups_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListAccessRightAccessPointGroupsResponse other)
        {
            if (other == null) return;
            accessRightAccessPointGroups_.Add(other.accessRightAccessPointGroups_);
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
            accessRightAccessPointGroups_.AddEntriesFrom(input, _repeated_accessRightAccessPointGroups_codec);
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
                            accessRightAccessPointGroups_.AddEntriesFrom(ref input, _repeated_accessRightAccessPointGroups_codec);
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