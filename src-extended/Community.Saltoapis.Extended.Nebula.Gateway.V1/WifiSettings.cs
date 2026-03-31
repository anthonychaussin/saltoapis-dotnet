namespace Saltoapis.Nebula.Gateway.V1
{
    /// <summary>
    /// WiFi network settings
    /// </summary>
    public sealed partial class WifiSettings : IMessage<WifiSettings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<WifiSettings> _parser = new(() => new WifiSettings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<WifiSettings> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public WifiSettings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public WifiSettings(WifiSettings other) : this()
        {
            ipv4Settings_ = other.ipv4Settings_?.Clone();
            dnsSettings_ = other.dnsSettings_?.Clone();
            ssid_ = other.ssid_;
            password_ = other.password_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public WifiSettings Clone() => new(this);
        /// <summary>Field number for the "ipv4_settings" field.</summary>
        public const int Ipv4SettingsFieldNumber = 1;
        private IPv4Settings ipv4Settings_;

        /// <summary>
        /// IPv4 (Internet Protocol version 4) settings of a WiFi network.
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
        /// DNS settings of a WiFi network.
        /// </summary>
        public DNSSettings DnsSettings
        {
            get { return dnsSettings_; }
            set
            {
                dnsSettings_ = value;
            }
        }

        /// <summary>Field number for the "ssid" field.</summary>
        public const int SsidFieldNumber = 3;
        private string ssid_ = "";

        /// <summary>
        /// Service set identifier of a WiFi network. An SSID is a 32-character
        /// unique identifier attached to the header of packets that are sent over a
        /// Wireless Local Area Network. SSIDs serve as "network names" and are
        /// typically human readable.
        /// </summary>
        public string Ssid
        {
            get { return ssid_; }
            set
            {
                ssid_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "password" field.</summary>
        public const int PasswordFieldNumber = 4;
        private static readonly string PasswordDefaultValue = "";

        private string password_;

        /// <summary>
        /// Password to be used to authenticate on a WiFi network.
        /// </summary>
        public string Password
        {
            get { return password_ ?? PasswordDefaultValue; }
            set
            {
                password_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "password" field is set</summary>
        public bool HasPassword
        {
            get { return password_ != null; }
        }

        /// <summary>Clears the value of the "password" field</summary>
        public void ClearPassword()
        {
            password_ = null;
        }

        public override bool Equals(object other) => Equals(other as WifiSettings);
        public bool Equals(WifiSettings other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Ipv4Settings, other.Ipv4Settings)) || (!Equals(DnsSettings, other.DnsSettings))) return false;
            if ((Ssid != other.Ssid) || (Password != other.Password)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ipv4Settings_ != null) hash ^= Ipv4Settings.GetHashCode();
            if (dnsSettings_ != null) hash ^= DnsSettings.GetHashCode();
            if (Ssid.Length != 0) hash ^= Ssid.GetHashCode();
            if (HasPassword) hash ^= Password.GetHashCode();
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
      if (Ssid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ssid);
      }
      if (HasPassword) {
        output.WriteRawTag(34);
        output.WriteString(Password);
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
            if (Ssid.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Ssid);
            }
            if (HasPassword)
            {
                output.WriteRawTag(34);
                output.WriteString(Password);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ipv4Settings_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Ipv4Settings);
            if (dnsSettings_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DnsSettings);
            if (Ssid.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Ssid);
            if (HasPassword) size += 1 + CodedOutputStream.ComputeStringSize(Password);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(WifiSettings other)
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
            if (other.Ssid.Length != 0) Ssid = other.Ssid;
            if (other.HasPassword) Password = other.Password;
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
          case 26: {
            Ssid = input.ReadString();
            break;
          }
          case 34: {
            Password = input.ReadString();
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
                    case 26:
                        {
                            Ssid = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Password = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
