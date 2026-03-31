namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// The response message for [`CancelElectronicKey`][salto.nebula.user.v1.UserService.CancelElectronicKey]
    /// </summary>
    public sealed partial class CancelElectronicKeyResponse : IMessage<CancelElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelElectronicKeyResponse> _parser = new(() => new CancelElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelElectronicKeyResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => UserReflection.Descriptor.MessageTypes[45];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CancelElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelElectronicKeyResponse(CancelElectronicKeyResponse other) : this()
        {
            electronicKey_ = other.electronicKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelElectronicKeyResponse Clone() => new(this);
        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 1;
        private ElectronicKey electronicKey_;
        /// <summary>
        /// The canceled electronic key.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get => electronicKey_; set => electronicKey_ = value;}

        public override bool Equals(object other) => Equals(other as CancelElectronicKeyResponse);
        public bool Equals(CancelElectronicKeyResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(ElectronicKey, other.ElectronicKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (electronicKey_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(ElectronicKey);
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
            if (electronicKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (electronicKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CancelElectronicKeyResponse other)
        {
            if (other == null) return;
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null) ElectronicKey = new ElectronicKey();
                ElectronicKey.MergeFrom(other.ElectronicKey);
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
            if (electronicKey_ == null)
            {
              ElectronicKey = new Saltoapis.Nebula.User.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
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
                            if (electronicKey_ == null) ElectronicKey = new ElectronicKey();
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                }
            }
        }
#endif
    }

}