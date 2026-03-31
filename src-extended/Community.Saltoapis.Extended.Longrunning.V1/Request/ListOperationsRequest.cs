namespace Saltoapis.Longrunning.V1.Request
{
    /// <summary>
    /// The request message for
    /// [`OperationService.ListOperations`][salto.longrunning.v1.OperationService.ListOperations].
    /// </summary>
    public sealed partial class ListOperationsRequest : IMessage<ListOperationsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListOperationsRequest> _parser = new(() => new ListOperationsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListOperationsRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => OperationReflection.Descriptor.MessageTypes[2];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListOperationsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListOperationsRequest(ListOperationsRequest other) : this()
        {
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListOperationsRequest Clone() => new(this);
        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 1;
        private int pageSize_;
        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get => pageSize_; set => pageSize_ = value;}
        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 2;
        private string pageToken_ = "";
        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// </summary>
        public string PageToken
        {
            get => pageToken_; set => pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 3;
        private string filter_ = "";
        /// <summary>
        /// A filter that chooses which operations to return. The maximum
        /// length of the filter is 20000 characters.
        /// </summary>
        public string Filter
        {
            get => filter_; set => filter_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as ListOperationsRequest);
        public bool Equals(ListOperationsRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((PageSize != other.PageSize) || (PageToken != other.PageToken) || Filter != other.Filter) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (PageSize != 0)
      {
        output.WriteRawTag(8);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0)
      {
        output.WriteRawTag(26);
        output.WriteString(Filter);
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
            if (PageSize != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Filter);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (PageSize != 0) size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            if (PageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            if (Filter.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListOperationsRequest other)
        {
            if (other == null) return;
            if (other.PageSize != 0) PageSize = other.PageSize;
            if (other.PageToken.Length != 0) PageToken = other.PageToken;
            if (other.Filter.Length != 0) Filter = other.Filter;
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
          case 8:
          {
            PageSize = input.ReadInt32();
            break;
          }
          case 18:
          {
            PageToken = input.ReadString();
            break;
          }
          case 26:
          {
            Filter = input.ReadString();
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
                    case 8:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 18:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}