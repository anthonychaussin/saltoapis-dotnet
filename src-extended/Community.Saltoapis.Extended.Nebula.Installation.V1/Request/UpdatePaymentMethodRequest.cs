namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// (-- api-linter: core::0134::request-mask-required=disabled
    ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
    /// The request message for [`UpdatePaymentMethod`][salto.nebula.installation.v1.InstallationService.UpdatePaymentMethod]
    /// </summary>
    public sealed partial class UpdatePaymentMethodRequest : IMessage<UpdatePaymentMethodRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdatePaymentMethodRequest> _parser = new(() => new UpdatePaymentMethodRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdatePaymentMethodRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdatePaymentMethodRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdatePaymentMethodRequest(UpdatePaymentMethodRequest other) : this()
        {
            paymentMethod_ = other.paymentMethod_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdatePaymentMethodRequest Clone() => new(this);
        /// <summary>Field number for the "payment_method" field.</summary>
        public const int PaymentMethodFieldNumber = 1;
        private PaymentMethod paymentMethod_;

        /// <summary>
        /// The payment method resource which replaces the resource on the server.
        /// </summary>
        public PaymentMethod PaymentMethod
        {
            get { return paymentMethod_; }
            set
            {
                paymentMethod_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdatePaymentMethodRequest);
        public bool Equals(UpdatePaymentMethodRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(PaymentMethod, other.PaymentMethod)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (paymentMethod_ != null) hash ^= PaymentMethod.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (paymentMethod_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PaymentMethod);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (paymentMethod_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(PaymentMethod);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (paymentMethod_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PaymentMethod);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdatePaymentMethodRequest other)
        {
            if (other == null) return;
            if (other.paymentMethod_ != null)
            {
                if (paymentMethod_ == null) PaymentMethod = new PaymentMethod();
                PaymentMethod.MergeFrom(other.PaymentMethod);
            }
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
            if (paymentMethod_ == null) {
              PaymentMethod = new Saltoapis.Nebula.Installation.V1.PaymentMethod();
            }
            input.ReadMessage(PaymentMethod);
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
                            if (paymentMethod_ == null) PaymentMethod = new PaymentMethod();
                            input.ReadMessage(PaymentMethod);
                            break;
                        }
                }
            }
        }
#endif

    }


}
