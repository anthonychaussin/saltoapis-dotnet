namespace Saltoapis.Nebula.Gateway.V1
{
    /// <summary>
    /// Ethernet network settings
    /// </summary>
    public sealed partial class EthernetSettings : IMessage<EthernetSettings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EthernetSettings> _parser = new(() => new EthernetSettings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EthernetSettings> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EthernetSettings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EthernetSettings(EthernetSettings other) : this()
        {
            ipv4Settings_ = other.ipv4Settings_?.Clone();
            dnsSettings_ = other.dnsSettings_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EthernetSettings Clone() => new(this);
        /// <summary>Field number for the "ipv4_settings" field.</summary>
        public const int Ipv4SettingsFieldNumber = 1;
        private IPv4Settings ipv4Settings_;

        /// <summary>
        /// IPv4 (Internet Protocol version 4) settings of an ethernet network.
        /// </summary>
        public IPv4Settings Ipv4Settings
        {
            get { return ipv4Settings_; }
            set
            {
                ipv4Settings_ = value;
            }
        }

        /// <summary>Field number for the "dns_settings" field.</summary>
        public const int DnsSettingsFieldNumber = 2;
        private DNSSettings dnsSettings_;

        /// <summary>
        /// DNS settings of an ethernet network.
        /// </summary>
        public DNSSettings DnsSettings
        {
            get { return dnsSettings_; }
            set
            {
                dnsSettings_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as EthernetSettings);
        public bool Equals(EthernetSettings other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Ipv4Settings, other.Ipv4Settings)) || (!Equals(DnsSettings, other.DnsSettings))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ipv4Settings_ != null) hash ^= Ipv4Settings.GetHashCode();
            if (dnsSettings_ != null) hash ^= DnsSettings.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (ipv4Settings_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Ipv4Settings);
      }
      if (dnsSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DnsSettings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ipv4Settings_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Ipv4Settings);
            }
            if (dnsSettings_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(DnsSettings);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ipv4Settings_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Ipv4Settings);
            if (dnsSettings_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DnsSettings);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(EthernetSettings other)
        {
            if (other == null) return;
            if (other.ipv4Settings_ != null)
            {
                if (ipv4Settings_ == null) Ipv4Settings = new IPv4Settings();
                Ipv4Settings.MergeFrom(other.Ipv4Settings);
            }
            if (other.dnsSettings_ != null)
            {
                if (dnsSettings_ == null) DnsSettings = new DNSSettings();
                DnsSettings.MergeFrom(other.DnsSettings);
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
            if (ipv4Settings_ == null) {
              Ipv4Settings = new Saltoapis.Nebula.Gateway.V1.IPv4Settings();
            }
            input.ReadMessage(Ipv4Settings);
            break;
          }
          case 18: {
            if (dnsSettings_ == null) {
              DnsSettings = new Saltoapis.Nebula.Gateway.V1.DNSSettings();
            }
            input.ReadMessage(DnsSettings);
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
                            if (ipv4Settings_ == null) Ipv4Settings = new IPv4Settings();
                            input.ReadMessage(Ipv4Settings);
                            break;
                        }
                    case 18:
                        {
                            if (dnsSettings_ == null) DnsSettings = new DNSSettings();
                            input.ReadMessage(DnsSettings);
                            break;
                        }
                }
            }
        }
#endif

    }


}
