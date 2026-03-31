using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Gateway.V1
{
    /// <summary>
    /// The gateway object
    /// </summary>
    public sealed partial class Gateway : IMessage<Gateway>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Gateway> _parser = new(() => new Gateway());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Gateway> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Gateway()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Gateway(Gateway other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            connected_ = other.connected_;
            ethernetSettings_ = other.ethernetSettings_?.Clone();
            wifiSettings_ = other.wifiSettings_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Gateway Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the gateway. It must have the format of
        /// `installations/*/gateways/*`. For example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the gateway.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 3;
        private readonly static string DeviceIdDefaultValue = "";

        private string deviceId_;

        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, encoders and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_ ?? DeviceIdDefaultValue; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId
        {
            get { return deviceId_ != null; }
        }

        /// <summary>Clears the value of the "device_id" field</summary>
        public void ClearDeviceId()
        {
            deviceId_ = null;
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 4;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this gateway has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateGateway`][salto.nebula.gateway.v1.GatewayService.UpdateGateway]
        /// operation. To change the value of this field, you must call
        /// [`InitializeGateway`][salto.nebula.gateway.v1.GatewayService.InitializeGateway].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get { return initialized_; }
            set
            {
                initialized_ = value;
            }
        }

        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 8;
        private Type.DeviceMetadata deviceMetadata_;

        /// <summary>
        /// Device metadata contains information about a device hardware and firmware.
        /// </summary>
        public Type.DeviceMetadata DeviceMetadata
        {
            get { return deviceMetadata_; }
            set
            {
                deviceMetadata_ = value;
            }
        }

        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 7;
        private bool connected_;

        /// <summary>
        /// Indicates whether this gateway is connected or not. It's considered
        /// connected if the gateway has successfully established communication
        /// with the MQTT server.
        /// </summary>
        public bool Connected
        {
            get { return connected_; }
            set
            {
                connected_ = value;
            }
        }

        /// <summary>Field number for the "ethernet_settings" field.</summary>
        public const int EthernetSettingsFieldNumber = 5;
        private EthernetSettings ethernetSettings_;

        /// <summary>
        /// Ethernet network settings for a gateway
        /// </summary>
        public EthernetSettings EthernetSettings
        {
            get { return ethernetSettings_; }
            set
            {
                ethernetSettings_ = value;
            }
        }

        /// <summary>Field number for the "wifi_settings" field.</summary>
        public const int WifiSettingsFieldNumber = 6;
        private WifiSettings wifiSettings_;

        /// <summary>
        /// WiFi network settings for a gateway
        /// </summary>
        public WifiSettings WifiSettings
        {
            get { return wifiSettings_; }
            set
            {
                wifiSettings_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Gateway);
        public bool Equals(Gateway other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName)) return false;
            if ((DeviceId != other.DeviceId) || (Initialized != other.Initialized)) return false;
            if ((!Equals(DeviceMetadata, other.DeviceMetadata)) || (Connected != other.Connected)) return false;
            if ((!Equals(EthernetSettings, other.EthernetSettings)) || (!Equals(WifiSettings, other.WifiSettings))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Connected != false) hash ^= Connected.GetHashCode();
            if (ethernetSettings_ != null) hash ^= EthernetSettings.GetHashCode();
            if (wifiSettings_ != null) hash ^= WifiSettings.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (HasDeviceId) {
        output.WriteRawTag(26);
        output.WriteString(DeviceId);
      }
      if (Initialized != false) {
        output.WriteRawTag(32);
        output.WriteBool(Initialized);
      }
      if (ethernetSettings_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EthernetSettings);
      }
      if (wifiSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(WifiSettings);
      }
      if (Connected != false) {
        output.WriteRawTag(56);
        output.WriteBool(Connected);
      }
      if (deviceMetadata_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(DeviceMetadata);
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
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DisplayName);
            }
            if (HasDeviceId)
            {
                output.WriteRawTag(26);
                output.WriteString(DeviceId);
            }
            if (Initialized != false)
            {
                output.WriteRawTag(32);
                output.WriteBool(Initialized);
            }
            if (ethernetSettings_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(EthernetSettings);
            }
            if (wifiSettings_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(WifiSettings);
            }
            if (Connected != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(Connected);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(DeviceMetadata);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (HasDeviceId) size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            if (Initialized != false) size += 1 + 1;
            if (deviceMetadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            if (Connected != false) size += 1 + 1;
            if (ethernetSettings_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EthernetSettings);
            if (wifiSettings_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(WifiSettings);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Gateway other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasDeviceId) DeviceId = other.DeviceId;
            if (other.Initialized != false) Initialized = other.Initialized;
            if (other.deviceMetadata_ != null)
            {
                if (deviceMetadata_ == null) DeviceMetadata = new Type.DeviceMetadata();
                DeviceMetadata.MergeFrom(other.DeviceMetadata);
            }
            if (other.Connected != false) Connected = other.Connected;
            if (other.ethernetSettings_ != null)
            {
                if (ethernetSettings_ == null) EthernetSettings = new EthernetSettings();
                EthernetSettings.MergeFrom(other.EthernetSettings);
            }
            if (other.wifiSettings_ != null)
            {
                if (wifiSettings_ == null) WifiSettings = new WifiSettings();
                WifiSettings.MergeFrom(other.WifiSettings);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            DeviceId = input.ReadString();
            break;
          }
          case 32: {
            Initialized = input.ReadBool();
            break;
          }
          case 42: {
            if (ethernetSettings_ == null) {
              EthernetSettings = new Saltoapis.Nebula.Gateway.V1.EthernetSettings();
            }
            input.ReadMessage(EthernetSettings);
            break;
          }
          case 50: {
            if (wifiSettings_ == null) {
              WifiSettings = new Saltoapis.Nebula.Gateway.V1.WifiSettings();
            }
            input.ReadMessage(WifiSettings);
            break;
          }
          case 56: {
            Connected = input.ReadBool();
            break;
          }
          case 66: {
            if (deviceMetadata_ == null) {
              DeviceMetadata = new Saltoapis.Nebula.Type.DeviceMetadata();
            }
            input.ReadMessage(DeviceMetadata);
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
                            DisplayName = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DeviceId = input.ReadString();
                            break;
                        }
                    case 32:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 42:
                        {
                            if (ethernetSettings_ == null) EthernetSettings = new EthernetSettings();
                            input.ReadMessage(EthernetSettings);
                            break;
                        }
                    case 50:
                        {
                            if (wifiSettings_ == null) WifiSettings = new WifiSettings();
                            input.ReadMessage(WifiSettings);
                            break;
                        }
                    case 56:
                        {
                            Connected = input.ReadBool();
                            break;
                        }
                    case 66:
                        {
                            if (deviceMetadata_ == null) DeviceMetadata = new Type.DeviceMetadata();
                            input.ReadMessage(DeviceMetadata);
                            break;
                        }
                }
            }
        }
#endif

    }
}
