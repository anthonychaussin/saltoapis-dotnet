namespace Saltoapis.Nebula.Installation.V1.Response
{
    /// <summary>
    /// (-- api-linter: core::0158::response-next-page-token-field=disabled
    ///     aip.dev/not-precedent: We need to do this because there is no paging yet. --)
    /// The response message for [`ListInvoices`][salto.nebula.installation.v1.InstallationService.ListInvoices]
    /// </summary>
    public sealed partial class ListInvoicesResponse : IMessage<ListInvoicesResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListInvoicesResponse> _parser = new(() => new ListInvoicesResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListInvoicesResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => InstallationReflection.Descriptor.MessageTypes[34];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListInvoicesResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListInvoicesResponse(ListInvoicesResponse other) : this()
        {
            invoices_ = other.invoices_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListInvoicesResponse Clone() => new(this);
        /// <summary>Field number for the "invoices" field.</summary>
        public const int InvoicesFieldNumber = 1;
        private static readonly FieldCodec<Invoice> _repeated_invoices_codec
            = FieldCodec.ForMessage(10, Invoice.Parser);
        private readonly RepeatedField<Invoice> invoices_ = [];
        /// <summary>
        /// The field name should match the noun `invoices` in the method name.
        /// </summary>
        public RepeatedField<Invoice> Invoices
        {
            get => invoices_;}

        public override bool Equals(object other) => Equals(other as ListInvoicesResponse);
        public bool Equals(ListInvoicesResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!invoices_.Equals(other.invoices_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= invoices_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      invoices_.WriteTo(output, _repeated_invoices_codec);
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            invoices_.WriteTo(ref output, _repeated_invoices_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += invoices_.CalculateSize(_repeated_invoices_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListInvoicesResponse other)
        {
            if (other == null) return;
            invoices_.Add(other.invoices_);
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
            invoices_.AddEntriesFrom(input, _repeated_invoices_codec);
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
                            invoices_.AddEntriesFrom(ref input, _repeated_invoices_codec);
                            break;
                        }
                }
            }
        }
#endif
    }

}