namespace Saltoapis.Nebula.ElectronicKey.V1.Response
{
    /// <summary>
    /// The empty response message for [`InitializeElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.InitializeElectronicKey]
    /// </summary>
    public sealed partial class InitializeElectronicKeyResponse : IMessage<InitializeElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeElectronicKeyResponse> _parser = new(() => new InitializeElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeElectronicKeyResponse(InitializeElectronicKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeElectronicKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeElectronicKeyResponse);
        public bool Equals(InitializeElectronicKeyResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(InitializeElectronicKeyResponse other)
        {
            if (other == null) return;
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }


}
