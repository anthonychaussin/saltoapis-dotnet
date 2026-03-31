namespace Saltoapis.Nebula.DigitalKey.V1.Request
{
    /// <summary>
    /// The request message for [`ListDigitalKeyAccessPoints`][salto.nebula.digitalkey.v1.DigitalKeyService.ListDigitalKeyAccessPoints]
    /// </summary>
    public sealed partial class ListDigitalKeyAccessPointsRequest : IMessage<ListDigitalKeyAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDigitalKeyAccessPointsRequest> _parser = new(() => new ListDigitalKeyAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDigitalKeyAccessPointsRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => DigitalKeyReflection.Descriptor.MessageTypes[6];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListDigitalKeyAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDigitalKeyAccessPointsRequest(ListDigitalKeyAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            filter_ = other.filter_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDigitalKeyAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// The parent resource name. For example, `digital-keys/baker-street-key`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 2;
        private string filter_ = "";
        /// <summary>
        /// A filter that chooses which access points to return.
        /// </summary>
        public string Filter
        {
            get => filter_; set => filter_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 3;
        private int pageSize_;
        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get => pageSize_; set => pageSize_ = value;}
        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 4;
        private string pageToken_ = "";
        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// Note: this field is not being used in the current implementation. It is being ignored.
        /// </summary>
        public string PageToken
        {
            get => pageToken_; set => pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as ListDigitalKeyAccessPointsRequest);
        public bool Equals(ListDigitalKeyAccessPointsRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (Filter != other.Filter) || (PageSize != other.PageSize) || (PageToken != other.PageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (Filter.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(Filter);
      }
      if (PageSize != 0)
      {
        output.WriteRawTag(24);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0)
      {
        output.WriteRawTag(34);
        output.WriteString(PageToken);
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
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Filter);
            }
            if (PageSize != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(PageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (Filter.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            if (PageSize != 0) size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            if (PageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListDigitalKeyAccessPointsRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.Filter.Length != 0) Filter = other.Filter;
            if (other.PageSize != 0) PageSize = other.PageSize;
            if (other.PageToken.Length != 0) PageToken = other.PageToken;
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
            Parent = input.ReadString();
            break;
          }
          case 18:
          {
            Filter = input.ReadString();
            break;
          }
          case 24:
          {
            PageSize = input.ReadInt32();
            break;
          }
          case 34:
          {
            PageToken = input.ReadString();
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 34:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}