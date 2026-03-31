namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateCard`][salto.nebula.installation.v1.InstallationService.UpdateCard]
    /// </summary>
    public sealed partial class UpdateCardRequest : IMessage<UpdateCardRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateCardRequest> _parser = new(() => new UpdateCardRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateCardRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[30]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateCardRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateCardRequest(UpdateCardRequest other) : this()
        {
            paymentMethod_ = other.paymentMethod_;
            token_ = other.token_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateCardRequest Clone() => new(this);
        /// <summary>Field number for the "payment_method" field.</summary>
        public const int PaymentMethodFieldNumber = 1;
        private string paymentMethod_ = "";

        /// <summary>
        /// The resource name of the subscription's payment method for which the card is being
        /// requested to be updated. For example:
        /// `installations/surelock-homes-hq/subscription/payment-method`.
        /// </summary>
        public string PaymentMethod
        {
            get { return paymentMethod_; }
            set
            {
                paymentMethod_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "token" field.</summary>
        public const int TokenFieldNumber = 2;
        private string token_ = "";

        /// <summary>
        /// The token provided for the operation.
        /// </summary>
        public string Token
        {
            get { return token_; }
            set
            {
                token_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateCardRequest);
        public bool Equals(UpdateCardRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((PaymentMethod != other.PaymentMethod) || (Token != other.Token)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (PaymentMethod.Length != 0) hash ^= PaymentMethod.GetHashCode();
            if (Token.Length != 0) hash ^= Token.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (PaymentMethod.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PaymentMethod);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Token);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (PaymentMethod.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(PaymentMethod);
            }
            if (Token.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Token);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (PaymentMethod.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PaymentMethod);
            if (Token.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Token);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateCardRequest other)
        {
            if (other == null) return;
            if (other.PaymentMethod.Length != 0) PaymentMethod = other.PaymentMethod;
            if (other.Token.Length != 0) Token = other.Token;
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
            PaymentMethod = input.ReadString();
            break;
          }
          case 18: {
            Token = input.ReadString();
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
                            PaymentMethod = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Token = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
