namespace Saltoapis.Nebula.Gateway.V1
{
    /// <summary>
    /// DNS settings
    /// </summary>
    public sealed partial class DNSSettings : IMessage<DNSSettings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DNSSettings> _parser = new(() => new DNSSettings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DNSSettings> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => GatewayReflection.Descriptor.MessageTypes[4];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public DNSSettings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DNSSettings(DNSSettings other) : this()
        {
            dnsAddresses_ = other.dnsAddresses_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DNSSettings Clone() => new(this);
        /// <summary>Field number for the "dns_addresses" field.</summary>
        public const int DnsAddressesFieldNumber = 1;
        private static readonly FieldCodec<string> _repeated_dnsAddresses_codec
            = FieldCodec.ForString(10);
        private readonly RepeatedField<string> dnsAddresses_ = [];
        /// <summary>
        /// DNS server IP addresses. The order of the elements in this list will mark
        /// priorities. For example: the first element will be primary DNS and the
        /// second element will be secondary DNS.
        ///
        /// If empty, an automatic DNS address given by the network will be used.
        /// </summary>
        public RepeatedField<string> DnsAddresses
        {
            get => dnsAddresses_;}

        public override bool Equals(object other) => Equals(other as DNSSettings);
        public bool Equals(DNSSettings other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!dnsAddresses_.Equals(other.dnsAddresses_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= dnsAddresses_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      dnsAddresses_.WriteTo(output, _repeated_dnsAddresses_codec);
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            dnsAddresses_.WriteTo(ref output, _repeated_dnsAddresses_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += dnsAddresses_.CalculateSize(_repeated_dnsAddresses_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(DNSSettings other)
        {
            if (other == null) return;
            dnsAddresses_.Add(other.dnsAddresses_);
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
            dnsAddresses_.AddEntriesFrom(input, _repeated_dnsAddresses_codec);
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
                            dnsAddresses_.AddEntriesFrom(ref input, _repeated_dnsAddresses_codec);
                            break;
                        }
                }
            }
        }
#endif
    }

}