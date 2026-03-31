namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// The response message for [`AssignWalletKey`][salto.nebula.user.v1.UserService.AssignWalletKey]
    /// </summary>
    public sealed partial class AssignWalletKeyResponse : IMessage<AssignWalletKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignWalletKeyResponse> _parser = new(() => new AssignWalletKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignWalletKeyResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => UserReflection.Descriptor.MessageTypes[35];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public AssignWalletKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignWalletKeyResponse(AssignWalletKeyResponse other) : this()
        {
            walletKey_ = other.walletKey_?.Clone();
            accessUri_ = other.accessUri_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignWalletKeyResponse Clone() => new(this);
        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 1;
        private WalletKey walletKey_;
        /// <summary>
        /// The newly-assigned wallet key.
        /// </summary>
        public WalletKey WalletKey
        {
            get => walletKey_; set => walletKey_ = value;}
        /// <summary>Field number for the "access_uri" field.</summary>
        public const int AccessUriFieldNumber = 2;
        private string accessUri_ = "";
        /// <summary>
        /// The access URL which contains the data to allow end users to
        /// sign in to SALTO Identity seamlessly and which is also used
        /// in the add-to-wallet process.
        /// </summary>
        public string AccessUri
        {
            get => accessUri_; set => accessUri_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as AssignWalletKeyResponse);
        public bool Equals(AssignWalletKeyResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(WalletKey, other.WalletKey)) || (AccessUri != other.AccessUri)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
            if (AccessUri.Length != 0) hash ^= AccessUri.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (walletKey_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(WalletKey);
      }
      if (AccessUri.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(AccessUri);
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
            if (walletKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(WalletKey);
            }
            if (AccessUri.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessUri);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (walletKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (AccessUri.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccessUri);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AssignWalletKeyResponse other)
        {
            if (other == null) return;
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null) WalletKey = new WalletKey();
                WalletKey.MergeFrom(other.WalletKey);
            }
            if (other.AccessUri.Length != 0) AccessUri = other.AccessUri;
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
            if (walletKey_ == null)
            {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
            break;
          }
          case 18:
          {
            AccessUri = input.ReadString();
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
                    case 18:
                        {
                            AccessUri = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}