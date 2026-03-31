namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`CreatePaymentAuthorization`][salto.nebula.installation.v1.InstallationService.CreatePaymentAuthorization]
    /// </summary>
    public sealed partial class CreatePaymentAuthorizationRequest : IMessage<CreatePaymentAuthorizationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreatePaymentAuthorizationRequest> _parser = new(() => new CreatePaymentAuthorizationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreatePaymentAuthorizationRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => InstallationReflection.Descriptor.MessageTypes[32];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreatePaymentAuthorizationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreatePaymentAuthorizationRequest(CreatePaymentAuthorizationRequest other) : this()
        {
            parent_ = other.parent_;
            paymentAuthorization_ = other.paymentAuthorization_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreatePaymentAuthorizationRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// The resource name of the subscription for which the payment authorization is being
        /// requested to be created. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "payment_authorization" field.</summary>
        public const int PaymentAuthorizationFieldNumber = 2;
        private PaymentAuthorization paymentAuthorization_;
        /// <summary>
        /// The payment authorization resource to be created. Client must not set the
        /// `PaymentAuthorization.name` field.
        /// </summary>
        public PaymentAuthorization PaymentAuthorization
        {
            get => paymentAuthorization_; set => paymentAuthorization_ = value;}

        public override bool Equals(object other) => Equals(other as CreatePaymentAuthorizationRequest);
        public bool Equals(CreatePaymentAuthorizationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(PaymentAuthorization, other.PaymentAuthorization))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (paymentAuthorization_ != null) hash ^= PaymentAuthorization.GetHashCode();
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
      if (paymentAuthorization_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(PaymentAuthorization);
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
            if (paymentAuthorization_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(PaymentAuthorization);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (paymentAuthorization_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PaymentAuthorization);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreatePaymentAuthorizationRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.paymentAuthorization_ != null)
            {
                if (paymentAuthorization_ == null) PaymentAuthorization = new PaymentAuthorization();
                PaymentAuthorization.MergeFrom(other.PaymentAuthorization);
            }
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
            if (paymentAuthorization_ == null)
            {
              PaymentAuthorization = new Saltoapis.Nebula.Installation.V1.PaymentAuthorization();
            }
            input.ReadMessage(PaymentAuthorization);
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
                            if (paymentAuthorization_ == null) PaymentAuthorization = new PaymentAuthorization();
                            input.ReadMessage(PaymentAuthorization);
                            break;
                        }
                }
            }
        }
#endif
    }

}