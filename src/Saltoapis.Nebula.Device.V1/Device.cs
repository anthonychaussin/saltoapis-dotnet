using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Device.V1
{
    /// <summary>
    /// The device object
    /// </summary>
    public sealed partial class Device : IMessage<Device>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Device> _parser = new(() => new Device());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<Device> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DeviceReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Device()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Device(Device other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            deviceType_ = other.deviceType_;
            source_ = other.source_;
            outdated_ = other.outdated_;
            connected_ = other.connected_;
            lowBattery_ = other.lowBattery_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            initialized_ = other.initialized_;
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender:
                    Extender = other.Extender;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Device Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the device. It must have the format of
        /// `installations/*/devices/*`. For example:
        /// `installations/surelock-homes-hq/devices/dancing-men`.
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
        /// Display name of the device.
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
        /// by SALTO, including gateways, extenders, electronic locks and so on.
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

        /// <summary>Field number for the "device_type" field.</summary>
        public const int DeviceTypeFieldNumber = 4;
        private Type.DeviceType deviceType_ = Type.DeviceType.Unspecified;

        /// <summary>
        /// Device type.
        /// </summary>
        public Type.DeviceType DeviceType
        {
            get { return deviceType_; }
            set
            {
                deviceType_ = value;
            }
        }

        /// <summary>Field number for the "source" field.</summary>
        public const int SourceFieldNumber = 5;
        private string source_ = "";

        /// <summary>
        /// Resource name of the specific source device (gateway, extender, electronic_lock, encoder). For example:
        /// `installations/surelock-homes-hq/electronic-locks/dancing-men` or
        /// `installations/surelock-homes-hq/gateways/conan-doyle` or
        /// `installations/surelock-homes-hq/extenders/elementary` or
        /// `installations/surelock-homes-hq/encoders/dancing-men`.
        /// </summary>
        public string Source
        {
            get { return source_; }
            set
            {
                source_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 6;

        /// <summary>
        /// Parent name, when the device has a gateway relative
        /// </summary>
        public string Gateway
        {
            get { return HasGateway ? (string)parentDevice_ : ""; }
            set
            {
                parentDevice_ = ProtoPreconditions.CheckNotNull(value, "value");
                parentDeviceCase_ = ParentDeviceOneofCase.Gateway;
            }
        }

        /// <summary>Gets whether the "gateway" field is set</summary>
        public bool HasGateway
        {
            get { return parentDeviceCase_ == ParentDeviceOneofCase.Gateway; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "gateway" </summary>
        public void ClearGateway()
        {
            if (HasGateway) ClearParentDevice();
        }

        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 7;

        /// <summary>
        /// Parent name, when the device has a extender relative
        /// </summary>
        public string Extender
        {
            get { return HasExtender ? (string)parentDevice_ : ""; }
            set
            {
                parentDevice_ = ProtoPreconditions.CheckNotNull(value, "value");
                parentDeviceCase_ = ParentDeviceOneofCase.Extender;
            }
        }

        /// <summary>Gets whether the "extender" field is set</summary>
        public bool HasExtender
        {
            get { return parentDeviceCase_ == ParentDeviceOneofCase.Extender; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "extender" </summary>
        public void ClearExtender()
        {
            if (HasExtender) ClearParentDevice();
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 8;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this device has pending updates or not. This
        /// could be because there was a pending configuration or a firmware update
        /// and is conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 9;
        private readonly static bool ConnectedDefaultValue = false;

        private bool connected_;

        /// <summary>
        /// Indicates whether this device is connected or not. The connectivity
        /// detection policy could vary depending on the device. The property is
        /// left unset if it is an offline device.
        /// </summary>
        public bool Connected
        {
            get { if ((_hasBits0 & 1) != 0) { return connected_; } else { return ConnectedDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                connected_ = value;
            }
        }

        /// <summary>Gets whether the "connected" field is set</summary>
        public bool HasConnected
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "connected" field</summary>
        public void ClearConnected()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "low_battery" field.</summary>
        public const int LowBatteryFieldNumber = 10;
        private readonly static bool LowBatteryDefaultValue = false;

        private bool lowBattery_;

        /// <summary>
        /// Indicates whether the battery of this device is low, and needs
        /// replacing, or is normal and doesn't need replacing. If unset it means
        /// the device is mains powered. For example, the device could be a
        /// gateway, an extender, or a control unit.
        /// </summary>
        public bool LowBattery
        {
            get { if ((_hasBits0 & 2) != 0) { return lowBattery_; } else { return LowBatteryDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                lowBattery_ = value;
            }
        }

        /// <summary>Gets whether the "low_battery" field is set</summary>
        public bool HasLowBattery
        {
            get { return (_hasBits0 & 2) != 0; }
        }

        /// <summary>Clears the value of the "low_battery" field</summary>
        public void ClearLowBattery()
        {
            _hasBits0 &= ~2;
        }

        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 11;
        private Google.Protobuf.WellKnownTypes.Timestamp lastEventTime_;

        /// <summary>
        /// The last time an event was received.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp LastEventTime
        {
            get { return lastEventTime_; }
            set
            {
                lastEventTime_ = value;
            }
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 12;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this device has been initialized or not. To change
        /// the value of this field, you must call the device-type-specific
        /// initialization operation (for example, InitializeElectronicLock).
        /// </summary>
        public bool Initialized
        {
            get { return initialized_; }
            set
            {
                initialized_ = value;
            }
        }

        private object parentDevice_;

        /// <summary>Enum of possible cases for the "parent_device" oneof.</summary>
        public enum ParentDeviceOneofCase
        {
            None = 0,
            Gateway = 6,
            Extender = 7,
        }

        private ParentDeviceOneofCase parentDeviceCase_ = ParentDeviceOneofCase.None;

        public ParentDeviceOneofCase ParentDeviceCase
        {
            get { return parentDeviceCase_; }
        }

        public void ClearParentDevice()
        {
            parentDeviceCase_ = ParentDeviceOneofCase.None;
            parentDevice_ = null;
        }

        public override bool Equals(object other) => Equals(other as Device);
        public bool Equals(Device other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName)) return false;
            if ((DeviceId != other.DeviceId) || (DeviceType != other.DeviceType)) return false;
            if ((Source != other.Source) || (Gateway != other.Gateway)) return false;
            if ((Extender != other.Extender) || (Outdated != other.Outdated)) return false;
            if ((Connected != other.Connected) || (LowBattery != other.LowBattery)) return false;
            if ((!Equals(LastEventTime, other.LastEventTime)) || (Initialized != other.Initialized)) return false;
            if (ParentDeviceCase != other.ParentDeviceCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (DeviceType != Type.DeviceType.Unspecified) hash ^= DeviceType.GetHashCode();
            if (Source.Length != 0) hash ^= Source.GetHashCode();
            if (HasGateway) hash ^= Gateway.GetHashCode();
            if (HasExtender) hash ^= Extender.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (HasConnected) hash ^= Connected.GetHashCode();
            if (HasLowBattery) hash ^= LowBattery.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            hash ^= (int)parentDeviceCase_;
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
      if (DeviceType != Saltoapis.Nebula.Type.DeviceType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) DeviceType);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Source);
      }
      if (HasGateway) {
        output.WriteRawTag(50);
        output.WriteString(Gateway);
      }
      if (HasExtender) {
        output.WriteRawTag(58);
        output.WriteString(Extender);
      }
      if (Outdated != false) {
        output.WriteRawTag(64);
        output.WriteBool(Outdated);
      }
      if (HasConnected) {
        output.WriteRawTag(72);
        output.WriteBool(Connected);
      }
      if (HasLowBattery) {
        output.WriteRawTag(80);
        output.WriteBool(LowBattery);
      }
      if (lastEventTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(LastEventTime);
      }
      if (Initialized != false) {
        output.WriteRawTag(96);
        output.WriteBool(Initialized);
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
            if (DeviceType != Type.DeviceType.Unspecified)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)DeviceType);
            }
            if (Source.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(Source);
            }
            if (HasGateway)
            {
                output.WriteRawTag(50);
                output.WriteString(Gateway);
            }
            if (HasExtender)
            {
                output.WriteRawTag(58);
                output.WriteString(Extender);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(64);
                output.WriteBool(Outdated);
            }
            if (HasConnected)
            {
                output.WriteRawTag(72);
                output.WriteBool(Connected);
            }
            if (HasLowBattery)
            {
                output.WriteRawTag(80);
                output.WriteBool(LowBattery);
            }
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(LastEventTime);
            }
            if (Initialized != false)
            {
                output.WriteRawTag(96);
                output.WriteBool(Initialized);
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
            if (DeviceType != Type.DeviceType.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)DeviceType);
            if (Source.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Source);
            if (HasGateway) size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            if (HasExtender) size += 1 + CodedOutputStream.ComputeStringSize(Extender);
            if ((Outdated != false) || (HasConnected)) size += 1 + 1;
            if (HasLowBattery) size += 1 + 1;
            if (lastEventTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            if (Initialized != false) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Device other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasDeviceId) DeviceId = other.DeviceId;
            if (other.DeviceType != Type.DeviceType.Unspecified) DeviceType = other.DeviceType;
            if (other.Source.Length != 0) Source = other.Source;
            if (other.Outdated != false) Outdated = other.Outdated;
            if (other.HasConnected) Connected = other.Connected;
            if (other.HasLowBattery) LowBattery = other.LowBattery;
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.Initialized != false) Initialized = other.Initialized;
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender:
                    Extender = other.Extender;
                    break;
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
            DeviceType = (Saltoapis.Nebula.Type.DeviceType) input.ReadEnum();
            break;
          }
          case 42: {
            Source = input.ReadString();
            break;
          }
          case 50: {
            Gateway = input.ReadString();
            break;
          }
          case 58: {
            Extender = input.ReadString();
            break;
          }
          case 64: {
            Outdated = input.ReadBool();
            break;
          }
          case 72: {
            Connected = input.ReadBool();
            break;
          }
          case 80: {
            LowBattery = input.ReadBool();
            break;
          }
          case 90: {
            if (lastEventTime_ == null) {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 96: {
            Initialized = input.ReadBool();
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
                            DeviceType = (Type.DeviceType)input.ReadEnum();
                            break;
                        }
                    case 42:
                        {
                            Source = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            Gateway = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            Extender = input.ReadString();
                            break;
                        }
                    case 64:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                    case 72:
                        {
                            Connected = input.ReadBool();
                            break;
                        }
                    case 80:
                        {
                            LowBattery = input.ReadBool();
                            break;
                        }
                    case 90:
                        {
                            if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(LastEventTime);
                            break;
                        }
                    case 96:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }
}
