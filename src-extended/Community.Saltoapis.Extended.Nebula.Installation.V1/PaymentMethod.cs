namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>
    /// Representation of a payment method, belonging to a subscription
    /// </summary>
    public sealed partial class PaymentMethod : IMessage<PaymentMethod>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<PaymentMethod> _parser = new(() => new PaymentMethod());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<PaymentMethod> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => InstallationReflection.Descriptor.MessageTypes[3];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public PaymentMethod()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public PaymentMethod(PaymentMethod other) : this()
        {
            name_ = other.name_;
            switch (other.MethodCase)
            {
                case MethodOneofCase.Card:
                    Card = other.Card.Clone();
                    break;
                case MethodOneofCase.DirectDebit:
                    DirectDebit = other.DirectDebit.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public PaymentMethod Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Resource name of the subscription's payment method. It must have the format of
        /// `installations/*/subscription/payment-method`. For example:
        /// `installations/surelock-homes-hq/subscription/payment-method`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "card" field.</summary>
        public const int CardFieldNumber = 2;
        /// <summary>
        /// Card details.
        /// </summary>
        public Types.Card Card
        {
            get { return methodCase_ == MethodOneofCase.Card ? (Types.Card)method_ : null; }
            set
            {
                method_ = value;
                methodCase_ = value == null ? MethodOneofCase.None : MethodOneofCase.Card;
            }
        }
        /// <summary>Field number for the "direct_debit" field.</summary>
        public const int DirectDebitFieldNumber = 3;
        /// <summary>
        /// Direct debit details.
        /// </summary>
        public Types.DirectDebit DirectDebit
        {
            get { return methodCase_ == MethodOneofCase.DirectDebit ? (Types.DirectDebit)method_ : null; }
            set
            {
                method_ = value;
                methodCase_ = value == null ? MethodOneofCase.None : MethodOneofCase.DirectDebit;
            }
        }

        private object method_;
        /// <summary>Enum of possible cases for the "method" oneof.</summary>
        public enum MethodOneofCase
        {
            None = 0,
            Card = 2,
            DirectDebit = 3,
        }

        private MethodOneofCase methodCase_ = MethodOneofCase.None;

        public MethodOneofCase MethodCase
        {
            get => methodCase_;}

        public void ClearMethod()
        {
            methodCase_ = MethodOneofCase.None;
            method_ = null;
        }

        public override bool Equals(object other) => Equals(other as PaymentMethod);
        public bool Equals(PaymentMethod other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (!Equals(Card, other.Card)) || (!Equals(DirectDebit, other.DirectDebit)) || (MethodCase != other.MethodCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (methodCase_ == MethodOneofCase.Card) hash ^= Card.GetHashCode();
            if (methodCase_ == MethodOneofCase.DirectDebit) hash ^= DirectDebit.GetHashCode();
            hash ^= (int)methodCase_;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (methodCase_ == MethodOneofCase.Card)
      {
        output.WriteRawTag(18);
        output.WriteMessage(Card);
      }
      if (methodCase_ == MethodOneofCase.DirectDebit)
      {
        output.WriteRawTag(26);
        output.WriteMessage(DirectDebit);
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
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            if (methodCase_ == MethodOneofCase.Card)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Card);
            }
            if (methodCase_ == MethodOneofCase.DirectDebit)
            {
                output.WriteRawTag(26);
                output.WriteMessage(DirectDebit);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (methodCase_ == MethodOneofCase.Card) size += 1 + CodedOutputStream.ComputeMessageSize(Card);
            if (methodCase_ == MethodOneofCase.DirectDebit) size += 1 + CodedOutputStream.ComputeMessageSize(DirectDebit);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(PaymentMethod other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            switch (other.MethodCase)
            {
                case MethodOneofCase.Card:
                    Card ??= new Types.Card();
                    Card.MergeFrom(other.Card);
                    break;
                case MethodOneofCase.DirectDebit:
                    DirectDebit ??= new Types.DirectDebit();
                    DirectDebit.MergeFrom(other.DirectDebit);
                    break;
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
            Name = input.ReadString();
            break;
          }
          case 18:
          {
            Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.Card subBuilder = new Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.Card();
            if (methodCase_ == MethodOneofCase.Card)
            {
              subBuilder.MergeFrom(Card);
            }
            input.ReadMessage(subBuilder);
            Card = subBuilder;
            break;
          }
          case 26:
          {
            Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit subBuilder = new Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit();
            if (methodCase_ == MethodOneofCase.DirectDebit)
            {
              subBuilder.MergeFrom(DirectDebit);
            }
            input.ReadMessage(subBuilder);
            DirectDebit = subBuilder;
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
                            Name = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Types.Card subBuilder = new();
                            if (methodCase_ == MethodOneofCase.Card) subBuilder.MergeFrom(Card);
                            input.ReadMessage(subBuilder);
                            Card = subBuilder;
                            break;
                        }
                    case 26:
                        {
                            Types.DirectDebit subBuilder = new();
                            if (methodCase_ == MethodOneofCase.DirectDebit) subBuilder.MergeFrom(DirectDebit);
                            input.ReadMessage(subBuilder);
                            DirectDebit = subBuilder;
                            break;
                        }
                }
            }
        }
#endif
        /// <summary>Container for nested types declared in the PaymentMethod message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// Card object
            /// </summary>
            public sealed partial class Card : IMessage<Card>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<Card> _parser = new(() => new Card());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<Card> Parser { get => _parser;}

                public static MessageDescriptor Descriptor
                {
                    get => PaymentMethod.Descriptor.NestedTypes[0];}

                MessageDescriptor IMessage.Descriptor
                {
                    get => Descriptor;}

                public Card()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public Card(Card other) : this()
                {
                    expireDate_ = other.expireDate_?.Clone();
                    lastFour_ = other.lastFour_;
                    brand_ = other.brand_;
                    paymentAuthorization_ = other.paymentAuthorization_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Card Clone() => new(this);
                /// <summary>Field number for the "expire_date" field.</summary>
                public const int ExpireDateFieldNumber = 1;
                private Type.Date expireDate_;
                /// <summary>
                /// The date the card expires.
                /// </summary>
                public Type.Date ExpireDate
                {
                    get => expireDate_; set => expireDate_ = value;}
                /// <summary>Field number for the "last_four" field.</summary>
                public const int LastFourFieldNumber = 2;
                private string lastFour_ = "";
                /// <summary>
                /// The last four digits of the card.
                /// </summary>
                public string LastFour
                {
                    get => lastFour_; set => lastFour_ = ProtoPreconditions.CheckNotNull(value, "value");}
                /// <summary>Field number for the "brand" field.</summary>
                public const int BrandFieldNumber = 3;
                private string brand_ = "";
                /// <summary>
                /// The card brand. For example: visa, mastercard, american_express, other.
                /// </summary>
                public string Brand
                {
                    get => brand_; set => brand_ = ProtoPreconditions.CheckNotNull(value, "value");}
                /// <summary>Field number for the "payment_authorization" field.</summary>
                public const int PaymentAuthorizationFieldNumber = 4;
                private string paymentAuthorization_ = "";
                /// <summary>
                /// The payment authorization resource reference for updating the card.
                /// It must be authorized by the payment provider before it can be used.
                /// </summary>
                public string PaymentAuthorization
                {
                    get => paymentAuthorization_; set => paymentAuthorization_ = ProtoPreconditions.CheckNotNull(value, "value");}

                public override bool Equals(object other) => Equals(other as Card);
                public bool Equals(Card other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((!Equals(ExpireDate, other.ExpireDate)) || (LastFour != other.LastFour) || (Brand != other.Brand) || (PaymentAuthorization != other.PaymentAuthorization)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (expireDate_ != null) hash ^= ExpireDate.GetHashCode();
                    if (LastFour.Length != 0) hash ^= LastFour.GetHashCode();
                    if (Brand.Length != 0) hash ^= Brand.GetHashCode();
                    if (PaymentAuthorization.Length != 0) hash ^= PaymentAuthorization.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (expireDate_ != null)
          {
            output.WriteRawTag(10);
            output.WriteMessage(ExpireDate);
          }
          if (LastFour.Length != 0)
          {
            output.WriteRawTag(18);
            output.WriteString(LastFour);
          }
          if (Brand.Length != 0)
          {
            output.WriteRawTag(26);
            output.WriteString(Brand);
          }
          if (PaymentAuthorization.Length != 0)
          {
            output.WriteRawTag(34);
            output.WriteString(PaymentAuthorization);
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
                    if (expireDate_ != null)
                    {
                        output.WriteRawTag(10);
                        output.WriteMessage(ExpireDate);
                    }
                    if (LastFour.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(LastFour);
                    }
                    if (Brand.Length != 0)
                    {
                        output.WriteRawTag(26);
                        output.WriteString(Brand);
                    }
                    if (PaymentAuthorization.Length != 0)
                    {
                        output.WriteRawTag(34);
                        output.WriteString(PaymentAuthorization);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (expireDate_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ExpireDate);
                    if (LastFour.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(LastFour);
                    if (Brand.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Brand);
                    if (PaymentAuthorization.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PaymentAuthorization);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(Card other)
                {
                    if (other == null) return;
                    if (other.expireDate_ != null)
                    {
                        if (expireDate_ == null) ExpireDate = new Type.Date();
                        ExpireDate.MergeFrom(other.ExpireDate);
                    }
                    if (other.LastFour.Length != 0) LastFour = other.LastFour;
                    if (other.Brand.Length != 0) Brand = other.Brand;
                    if (other.PaymentAuthorization.Length != 0) PaymentAuthorization = other.PaymentAuthorization;
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
                if (expireDate_ == null)
                {
                  ExpireDate = new Saltoapis.Type.Date();
                }
                input.ReadMessage(ExpireDate);
                break;
              }
              case 18:
              {
                LastFour = input.ReadString();
                break;
              }
              case 26:
              {
                Brand = input.ReadString();
                break;
              }
              case 34:
              {
                PaymentAuthorization = input.ReadString();
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
                                    if (expireDate_ == null) ExpireDate = new Type.Date();
                                    input.ReadMessage(ExpireDate);
                                    break;
                                }
                            case 18:
                                {
                                    LastFour = input.ReadString();
                                    break;
                                }
                            case 26:
                                {
                                    Brand = input.ReadString();
                                    break;
                                }
                            case 34:
                                {
                                    PaymentAuthorization = input.ReadString();
                                    break;
                                }
                        }
                    }
                }
#endif
            }
            /// <summary>
            /// Direct debit object
            /// </summary>
            public sealed partial class DirectDebit : IMessage<DirectDebit>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<DirectDebit> _parser = new(() => new DirectDebit());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<DirectDebit> Parser { get => _parser;}

                public static MessageDescriptor Descriptor
                {
                    get => PaymentMethod.Descriptor.NestedTypes[1];}

                MessageDescriptor IMessage.Descriptor
                {
                    get => Descriptor;}

                public DirectDebit()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public DirectDebit(DirectDebit other) : this()
                {
                    switch (other.SchemeCase)
                    {
                        case SchemeOneofCase.Sepa:
                            Sepa = other.Sepa.Clone();
                            break;
                    }

                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public DirectDebit Clone() => new(this);
                /// <summary>Field number for the "sepa" field.</summary>
                public const int SepaFieldNumber = 1;
                /// <summary>
                /// SEPA details.
                /// </summary>
                public Types.SEPA Sepa
                {
                    get { return schemeCase_ == SchemeOneofCase.Sepa ? (Types.SEPA)scheme_ : null; }
                    set
                    {
                        scheme_ = value;
                        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.Sepa;
                    }
                }

                private object scheme_;
                /// <summary>Enum of possible cases for the "scheme" oneof.</summary>
                public enum SchemeOneofCase
                {
                    None = 0,
                    Sepa = 1,
                }

                private SchemeOneofCase schemeCase_ = SchemeOneofCase.None;

                public SchemeOneofCase SchemeCase
                {
                    get => schemeCase_;}

                public void ClearScheme()
                {
                    schemeCase_ = SchemeOneofCase.None;
                    scheme_ = null;
                }

                public override bool Equals(object other) => Equals(other as DirectDebit);
                public bool Equals(DirectDebit other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((!Equals(Sepa, other.Sepa)) || (SchemeCase != other.SchemeCase)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (schemeCase_ == SchemeOneofCase.Sepa) hash ^= Sepa.GetHashCode();
                    hash ^= (int)schemeCase_;
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (schemeCase_ == SchemeOneofCase.Sepa)
          {
            output.WriteRawTag(10);
            output.WriteMessage(Sepa);
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
                    if (schemeCase_ == SchemeOneofCase.Sepa)
                    {
                        output.WriteRawTag(10);
                        output.WriteMessage(Sepa);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (schemeCase_ == SchemeOneofCase.Sepa) size += 1 + CodedOutputStream.ComputeMessageSize(Sepa);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(DirectDebit other)
                {
                    if (other == null) return;
                    switch (other.SchemeCase)
                    {
                        case SchemeOneofCase.Sepa:
                            Sepa ??= new Types.SEPA();
                            Sepa.MergeFrom(other.Sepa);
                            break;
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
                Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit.Types.SEPA subBuilder = new Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit.Types.SEPA();
                if (schemeCase_ == SchemeOneofCase.Sepa)
                {
                  subBuilder.MergeFrom(Sepa);
                }
                input.ReadMessage(subBuilder);
                Sepa = subBuilder;
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
                                    Types.SEPA subBuilder = new();
                                    if (schemeCase_ == SchemeOneofCase.Sepa) subBuilder.MergeFrom(Sepa);
                                    input.ReadMessage(subBuilder);
                                    Sepa = subBuilder;
                                    break;
                                }
                        }
                    }
                }
#endif
                /// <summary>Container for nested types declared in the DirectDebit message type.</summary>
                public static partial class Types
                {
                    /// <summary>
                    /// The SEPA object
                    /// </summary>
                    public sealed partial class SEPA : IMessage<SEPA>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                        , IBufferMessage
#endif
                    {
                        private static readonly MessageParser<SEPA> _parser = new(() => new SEPA());
                        private UnknownFieldSet _unknownFields;

                        public static MessageParser<SEPA> Parser { get => _parser;}

                        public static MessageDescriptor Descriptor
                        {
                            get => DirectDebit.Descriptor.NestedTypes[0];}

                        MessageDescriptor IMessage.Descriptor
                        {
                            get => Descriptor;}

                        public SEPA()
                        {
                            OnConstruction();
                        }

                        partial void OnConstruction();

                        public SEPA(SEPA other) : this()
                        {
                            lastFour_ = other.lastFour_;
                            accountHolder_ = other.accountHolder_;
                            iban_ = other.iban_;
                            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                        }

                        public SEPA Clone() => new(this);
                        /// <summary>Field number for the "last_four" field.</summary>
                        public const int LastFourFieldNumber = 1;
                        private string lastFour_ = "";
                        /// <summary>
                        /// The last four digits of the bank account number used for direct
                        /// debit.
                        /// </summary>
                        public string LastFour
                        {
                            get => lastFour_; set => lastFour_ = ProtoPreconditions.CheckNotNull(value, "value");}
                        /// <summary>Field number for the "account_holder" field.</summary>
                        public const int AccountHolderFieldNumber = 2;
                        private string accountHolder_ = "";
                        /// <summary>
                        /// The name of the person or business that owns the bank account.
                        /// </summary>
                        public string AccountHolder
                        {
                            get => accountHolder_; set => accountHolder_ = ProtoPreconditions.CheckNotNull(value, "value");}
                        /// <summary>Field number for the "iban" field.</summary>
                        public const int IbanFieldNumber = 3;
                        private string iban_ = "";
                        /// <summary>
                        /// The IBAN (International Bank Account Number) of the bank account.
                        /// </summary>
                        public string Iban
                        {
                            get => iban_; set => iban_ = ProtoPreconditions.CheckNotNull(value, "value");}

                        public override bool Equals(object other) => Equals(other as SEPA);
                        public bool Equals(SEPA other)
                        {
                            if (other is null) return false;
                            if (ReferenceEquals(other, this)) return true;
                            if ((LastFour != other.LastFour) || (AccountHolder != other.AccountHolder) || Iban != other.Iban) return false;
                            return Equals(_unknownFields, other._unknownFields);
                        }

                        public override int GetHashCode()
                        {
                            int hash = 1;
                            if (LastFour.Length != 0) hash ^= LastFour.GetHashCode();
                            if (AccountHolder.Length != 0) hash ^= AccountHolder.GetHashCode();
                            if (Iban.Length != 0) hash ^= Iban.GetHashCode();
                            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                            return hash;
                        }

                        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                        public void WriteTo(CodedOutputStream output)
                        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                            output.WriteRawMessage(this);
#else
              if (LastFour.Length != 0)
              {
                output.WriteRawTag(10);
                output.WriteString(LastFour);
              }
              if (AccountHolder.Length != 0)
              {
                output.WriteRawTag(18);
                output.WriteString(AccountHolder);
              }
              if (Iban.Length != 0)
              {
                output.WriteRawTag(26);
                output.WriteString(Iban);
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
                            if (LastFour.Length != 0)
                            {
                                output.WriteRawTag(10);
                                output.WriteString(LastFour);
                            }
                            if (AccountHolder.Length != 0)
                            {
                                output.WriteRawTag(18);
                                output.WriteString(AccountHolder);
                            }
                            if (Iban.Length != 0)
                            {
                                output.WriteRawTag(26);
                                output.WriteString(Iban);
                            }
                            _unknownFields?.WriteTo(ref output);
                        }
#endif

                        public int CalculateSize()
                        {
                            int size = 0;
                            if (LastFour.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(LastFour);
                            if (AccountHolder.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccountHolder);
                            if (Iban.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Iban);
                            if (_unknownFields != null) size += _unknownFields.CalculateSize();
                            return size;
                        }

                        public void MergeFrom(SEPA other)
                        {
                            if (other == null) return;
                            if (other.LastFour.Length != 0) LastFour = other.LastFour;
                            if (other.AccountHolder.Length != 0) AccountHolder = other.AccountHolder;
                            if (other.Iban.Length != 0) Iban = other.Iban;
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
                    LastFour = input.ReadString();
                    break;
                  }
                  case 18:
                  {
                    AccountHolder = input.ReadString();
                    break;
                  }
                  case 26:
                  {
                    Iban = input.ReadString();
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
                                            LastFour = input.ReadString();
                                            break;
                                        }
                                    case 18:
                                        {
                                            AccountHolder = input.ReadString();
                                            break;
                                        }
                                    case 26:
                                        {
                                            Iban = input.ReadString();
                                            break;
                                        }
                                }
                            }
                        }
#endif
                    }
                }
            }
        }
    }

}