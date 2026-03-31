namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`ListInstallations`][salto.nebula.installation.v1.InstallationService.ListInstallations]
    /// </summary>
    public sealed partial class ListInstallationsRequest : IMessage<ListInstallationsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListInstallationsRequest> _parser = new(() => new ListInstallationsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListInstallationsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListInstallationsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListInstallationsRequest(ListInstallationsRequest other) : this()
        {
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            showDeleted_ = other.showDeleted_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListInstallationsRequest Clone() => new(this);
        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 1;
        private int pageSize_;

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
            }
        }

        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 2;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 3;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which installations to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "order_by" field.</summary>
        public const int OrderByFieldNumber = 4;
        private string orderBy_ = "";

        /// <summary>
        /// How the results should be sorted.
        /// </summary>
        public string OrderBy
        {
            get { return orderBy_; }
            set
            {
                orderBy_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "show_deleted" field.</summary>
        public const int ShowDeletedFieldNumber = 5;
        private bool showDeleted_;

        /// <summary>
        /// Show deleted installations.
        /// </summary>
        public bool ShowDeleted
        {
            get { return showDeleted_; }
            set
            {
                showDeleted_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ListInstallationsRequest);
        public bool Equals(ListInstallationsRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((PageSize != other.PageSize) || (PageToken != other.PageToken)) return false;
            if ((Filter != other.Filter) || (OrderBy != other.OrderBy)) return false;
            if (ShowDeleted != other.ShowDeleted) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
            if (ShowDeleted != false) hash ^= ShowDeleted.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (PageSize != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OrderBy);
      }
      if (ShowDeleted != false) {
        output.WriteRawTag(40);
        output.WriteBool(ShowDeleted);
      }
      if (_unknownFields != null) {
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
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(OrderBy);
            }
            if (ShowDeleted != false)
            {
                output.WriteRawTag(40);
                output.WriteBool(ShowDeleted);
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
            if (OrderBy.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            if (ShowDeleted != false) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListInstallationsRequest other)
        {
            if (other == null) return;
            if (other.PageSize != 0) PageSize = other.PageSize;
            if (other.PageToken.Length != 0) PageToken = other.PageToken;
            if (other.Filter.Length != 0) Filter = other.Filter;
            if (other.OrderBy.Length != 0) OrderBy = other.OrderBy;
            if (other.ShowDeleted != false) ShowDeleted = other.ShowDeleted;
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
          case 8: {
            PageSize = input.ReadInt32();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
          case 26: {
            Filter = input.ReadString();
            break;
          }
          case 34: {
            OrderBy = input.ReadString();
            break;
          }
          case 40: {
            ShowDeleted = input.ReadBool();
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
                    case 34:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                    case 40:
                        {
                            ShowDeleted = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }


}
