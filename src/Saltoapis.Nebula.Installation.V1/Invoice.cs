using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>
    /// The invoice object used for billing
    /// </summary>
    public sealed partial class Invoice : IMessage<Invoice>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Invoice> _parser = new(() => new Invoice());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Invoice> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Invoice()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Invoice(Invoice other) : this()
        {
            name_ = other.name_;
            startTime_ = other.startTime_?.Clone();
            endTime_ = other.endTime_?.Clone();
            lineItems_ = other.lineItems_.Clone();
            total_ = other.total_;
            state_ = other.state_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Invoice Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the invoice. It must have the format of
        /// `installations/*/subscription/invoices/*`. For example:
        /// `installations/salto-hq/subscription/invoices/2023-000015`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "start_time" field.</summary>
        public const int StartTimeFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.Timestamp startTime_;

        /// <summary>
        /// Start time of the invoice. It must be past time.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp StartTime
        {
            get { return startTime_; }
            set
            {
                startTime_ = value;
            }
        }

        /// <summary>Field number for the "end_time" field.</summary>
        public const int EndTimeFieldNumber = 3;
        private Google.Protobuf.WellKnownTypes.Timestamp endTime_;

        /// <summary>
        /// End time of the invoice.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp EndTime
        {
            get { return endTime_; }
            set
            {
                endTime_ = value;
            }
        }

        /// <summary>Field number for the "line_items" field.</summary>
        public const int LineItemsFieldNumber = 4;
        private static readonly FieldCodec<Types.LineItem> _repeated_lineItems_codec
            = FieldCodec.ForMessage(34, Types.LineItem.Parser);
        private readonly RepeatedField<Types.LineItem> lineItems_ = [];

        /// <summary>
        /// The line items included in the invoice. Must include at least one
        /// item and no more than 50.
        /// </summary>
        public RepeatedField<Types.LineItem> LineItems
        {
            get { return lineItems_; }
        }

        /// <summary>Field number for the "total" field.</summary>
        public const int TotalFieldNumber = 5;
        private long total_;

        /// <summary>
        /// The total cost of the invoice.
        /// The value is in the minor unit of the currency. (for example: cents).
        /// </summary>
        public long Total
        {
            get { return total_; }
            set
            {
                total_ = value;
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 6;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this invoice has been paid or not.
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Invoice);
        public bool Equals(Invoice other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (!Equals(StartTime, other.StartTime))) return false;
            if ((!Equals(EndTime, other.EndTime)) || (!lineItems_.Equals(other.lineItems_))) return false;
            if ((Total != other.Total) || (State != other.State)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (startTime_ != null) hash ^= StartTime.GetHashCode();
            if (endTime_ != null) hash ^= EndTime.GetHashCode();
            hash ^= lineItems_.GetHashCode();
            if (Total != 0L) hash ^= Total.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      lineItems_.WriteTo(output, _repeated_lineItems_codec);
      if (Total != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(Total);
      }
      if (State != Saltoapis.Nebula.Installation.V1.Invoice.Types.State.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) State);
      }
      if (_unknownFields != null) {
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
            if (startTime_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(StartTime);
            }
            if (endTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EndTime);
            }
            lineItems_.WriteTo(ref output, _repeated_lineItems_codec);
            if (Total != 0L)
            {
                output.WriteRawTag(40);
                output.WriteInt64(Total);
            }
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(48);
                output.WriteEnum((int)State);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (startTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(StartTime);
            if (endTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EndTime);
            size += lineItems_.CalculateSize(_repeated_lineItems_codec);
            if (Total != 0L) size += 1 + CodedOutputStream.ComputeInt64Size(Total);
            if (State != Types.State.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Invoice other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.startTime_ != null)
            {
                if (startTime_ == null) StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                StartTime.MergeFrom(other.StartTime);
            }
            if (other.endTime_ != null)
            {
                if (endTime_ == null) EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                EndTime.MergeFrom(other.EndTime);
            }
            lineItems_.Add(other.lineItems_);
            if (other.Total != 0L) Total = other.Total;
            if (other.State != Types.State.Unspecified) State = other.State;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (startTime_ == null) {
              StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 34: {
            lineItems_.AddEntriesFrom(input, _repeated_lineItems_codec);
            break;
          }
          case 40: {
            Total = input.ReadInt64();
            break;
          }
          case 48: {
            State = (Saltoapis.Nebula.Installation.V1.Invoice.Types.State) input.ReadEnum();
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
                            if (startTime_ == null) StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(StartTime);
                            break;
                        }
                    case 26:
                        {
                            if (endTime_ == null) EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(EndTime);
                            break;
                        }
                    case 34:
                        {
                            lineItems_.AddEntriesFrom(ref input, _repeated_lineItems_codec);
                            break;
                        }
                    case 40:
                        {
                            Total = input.ReadInt64();
                            break;
                        }
                    case 48:
                        {
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the Invoice message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a invoice.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The invoice is unpaid.
                /// </summary>
                [OriginalName("UNPAID")] Unpaid = 1,
                /// <summary>
                /// The invoice has been paid.
                /// </summary>
                [OriginalName("PAID")] Paid = 2,
            }

            /// <summary>
            /// The line item object.
            /// </summary>
            public sealed partial class LineItem : IMessage<LineItem>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<LineItem> _parser = new(() => new LineItem());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<LineItem> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Invoice.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public LineItem()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public LineItem(LineItem other) : this()
                {
                    id_ = other.id_;
                    quantity_ = other.quantity_;
                    price_ = other.price_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public LineItem Clone() => new(this);
                /// <summary>Field number for the "id" field.</summary>
                public const int IdFieldNumber = 1;
                private string id_ = "";

                /// <summary>
                /// The line item ID belonging to the subscription. For example:
                /// `elevators`.
                /// </summary>
                public string Id
                {
                    get { return id_; }
                    set
                    {
                        id_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "quantity" field.</summary>
                public const int QuantityFieldNumber = 2;
                private int quantity_;

                /// <summary>
                /// The quantity of the line item used.
                /// </summary>
                public int Quantity
                {
                    get { return quantity_; }
                    set
                    {
                        quantity_ = value;
                    }
                }

                /// <summary>Field number for the "price" field.</summary>
                public const int PriceFieldNumber = 3;
                private long price_;

                /// <summary>
                /// The cost of the item price when the pricing model is flat fee.
                /// When the pricing model is per unit, it is the price per unit quantity of the item.
                /// The value is in the minor unit of the currency. (for example: cents).
                /// </summary>
                public long Price
                {
                    get { return price_; }
                    set
                    {
                        price_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as LineItem);
                public bool Equals(LineItem other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((Id != other.Id) || (Quantity != other.Quantity)) return false;
                    if (Price != other.Price) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Id.Length != 0) hash ^= Id.GetHashCode();
                    if (Quantity != 0) hash ^= Quantity.GetHashCode();
                    if (Price != 0L) hash ^= Price.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Id);
          }
          if (Quantity != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Quantity);
          }
          if (Price != 0L) {
            output.WriteRawTag(24);
            output.WriteInt64(Price);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (Id.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(Id);
                    }
                    if (Quantity != 0)
                    {
                        output.WriteRawTag(16);
                        output.WriteInt32(Quantity);
                    }
                    if (Price != 0L)
                    {
                        output.WriteRawTag(24);
                        output.WriteInt64(Price);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Id.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Id);
                    if (Quantity != 0) size += 1 + CodedOutputStream.ComputeInt32Size(Quantity);
                    if (Price != 0L) size += 1 + CodedOutputStream.ComputeInt64Size(Price);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(LineItem other)
                {
                    if (other == null) return;
                    if (other.Id.Length != 0) Id = other.Id;
                    if (other.Quantity != 0) Quantity = other.Quantity;
                    if (other.Price != 0L) Price = other.Price;
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
                Id = input.ReadString();
                break;
              }
              case 16: {
                Quantity = input.ReadInt32();
                break;
              }
              case 24: {
                Price = input.ReadInt64();
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
                                    Id = input.ReadString();
                                    break;
                                }
                            case 16:
                                {
                                    Quantity = input.ReadInt32();
                                    break;
                                }
                            case 24:
                                {
                                    Price = input.ReadInt64();
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
