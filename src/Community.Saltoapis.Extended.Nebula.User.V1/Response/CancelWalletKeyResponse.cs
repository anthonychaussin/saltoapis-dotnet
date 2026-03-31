namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// The response message for [`CancelWalletKey`][salto.nebula.user.v1.UserService.CancelWalletKey]
    /// </summary>
    public sealed partial class CancelWalletKeyResponse : IMessage<CancelWalletKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelWalletKeyResponse> _parser = new(() => new CancelWalletKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelWalletKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[37]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelWalletKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelWalletKeyResponse(CancelWalletKeyResponse other) : this()
        {
            walletKey_ = other.walletKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelWalletKeyResponse Clone() => new(this);
        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 1;
        private WalletKey walletKey_;

        /// <summary>
        /// The canceled wallet key.
        /// </summary>
        public WalletKey WalletKey
        {
            get { return walletKey_; }
            set
            {
                walletKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CancelWalletKeyResponse);
        public bool Equals(CancelWalletKeyResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(WalletKey, other.WalletKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (walletKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(WalletKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (walletKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(WalletKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (walletKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CancelWalletKeyResponse other)
        {
            if (other == null) return;
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null) WalletKey = new WalletKey();
                WalletKey.MergeFrom(other.WalletKey);
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
            if (walletKey_ == null) {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
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
                            if (walletKey_ == null) WalletKey = new WalletKey();
                            input.ReadMessage(WalletKey);
                            break;
                        }
                }
            }
        }
#endif

    }


}
