namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// The response message for [`ComputeAppKeyData`][salto.nebula.user.v1.UserService.ComputeAppKeyData]
    /// </summary>
    public sealed partial class ComputeAppKeyDataResponse : IMessage<ComputeAppKeyDataResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ComputeAppKeyDataResponse> _parser = new(() => new ComputeAppKeyDataResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ComputeAppKeyDataResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[33]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ComputeAppKeyDataResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ComputeAppKeyDataResponse(ComputeAppKeyDataResponse other) : this()
        {
            data_ = other.data_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ComputeAppKeyDataResponse Clone() => new(this);
        /// <summary>Field number for the "data" field.</summary>
        public const int DataFieldNumber = 1;
        private ByteString data_ = ByteString.Empty;

        /// <summary>
        /// Computed data of the requested app key.
        /// </summary>
        public ByteString Data
        {
            get { return data_; }
            set
            {
                data_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ComputeAppKeyDataResponse);
        public bool Equals(ComputeAppKeyDataResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (Data != other.Data) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Data.Length != 0) hash ^= Data.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Data.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Data.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(Data);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Data.Length != 0) size += 1 + CodedOutputStream.ComputeBytesSize(Data);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ComputeAppKeyDataResponse other)
        {
            if (other == null) return;
            if (other.Data.Length != 0) Data = other.Data;
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
            Data = input.ReadBytes();
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
                            Data = input.ReadBytes();
                            break;
                        }
                }
            }
        }
#endif

    }


}
