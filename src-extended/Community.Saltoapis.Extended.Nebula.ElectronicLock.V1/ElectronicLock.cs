namespace Saltoapis.Nebula.ElectronicLock.V1
{
    /// <summary>
    /// The electronic lock object
    /// </summary>
    public sealed partial class ElectronicLock : IMessage<ElectronicLock>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicLock> _parser = new(() => new ElectronicLock());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<ElectronicLock> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ElectronicLockReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ElectronicLock()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicLock(ElectronicLock other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            accessPoint_ = other.accessPoint_;
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            outdated_ = other.outdated_;
            connected_ = other.connected_;
            lowBattery_ = other.lowBattery_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            calibrationSettings_ = other.calibrationSettings_;
            forceRotateCarriageEnd_ = other.forceRotateCarriageEnd_;
            holdBackLatchDuration_ = other.holdBackLatchDuration_?.Clone();
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

        public ElectronicLock Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Output only. Resource name of the electronic lock. It must have the format of
        /// `installations/*/electronic-locks/*`. For example:
        /// `installations/surelock-homes-hq/electronic-locks/dancing-men`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the electronic lock.
        /// </summary>
        public string DisplayName
        {
            get => displayName_; set => displayName_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 3;
        private static readonly string DeviceIdDefaultValue = "";

        private string deviceId_;
        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, electronic locks and so on.
        /// </summary>
        public string DeviceId
        {
            get => deviceId_ ?? DeviceIdDefaultValue; set => deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId => deviceId_ != null;
        /// <summary>Clears the value of the "device_id" field</summary>
        public void ClearDeviceId() => deviceId_ = null;
        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 4;
        /// <summary>
        /// Parent name, when electronic lock is connected to a gateway
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
        public bool HasGateway => parentDeviceCase_ == ParentDeviceOneofCase.Gateway;
        /// <summary> Clears the value of the oneof if it's currently set to "gateway" </summary>
        public void ClearGateway()
        {
            if (HasGateway) ClearParentDevice();
        }
        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 5;
        /// <summary>
        /// Parent name, when electronic lock is connected to an extender
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
        public bool HasExtender => parentDeviceCase_ == ParentDeviceOneofCase.Extender;
        /// <summary> Clears the value of the oneof if it's currently set to "extender" </summary>
        public void ClearExtender()
        {
            if (HasExtender) ClearParentDevice();
        }
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 6;
        private string accessPoint_ = "";
        /// <summary>
        /// The access point that the electronic lock gives coverage to.
        /// </summary>
        public string AccessPoint
        {
            get => accessPoint_; set => accessPoint_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 7;
        private bool initialized_;
        /// <summary>
        /// Indicates whether this electronic lock has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.UpdateElectronicLock]
        /// operation. To change the value of this field, you must call
        /// [`InitializeElectronicLock`][salto.nebula.electroniclock.v1.ElectronicLockService.InitializeElectronicLock].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get => initialized_; set => initialized_ = value;}
        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 15;
        private Type.DeviceMetadata deviceMetadata_;
        /// <summary>
        /// Device metadata contains information about a device hardware and firmware.
        /// </summary>
        public Type.DeviceMetadata DeviceMetadata
        {
            get => deviceMetadata_; set => deviceMetadata_ = value;}
        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 8;
        private bool outdated_;
        /// <summary>
        /// Indicates whether this electronic lock has pending updates or not. This
        /// could be because there was a pending configuration or a firmware update
        /// and is conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get => outdated_; set => outdated_ = value;}
        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 9;
        private static readonly bool ConnectedDefaultValue = false;

        private bool connected_;
        /// <summary>
        /// Indicates whether this electronic lock is connected or not. It's
        /// considered connected if there has been at least one communication with it
        /// within the last 10 minutes. The property is left unset if it is an
        /// offline electronic lock.
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
        public bool HasConnected => (_hasBits0 & 1) != 0;
        /// <summary>Clears the value of the "connected" field</summary>
        public void ClearConnected()
        {
            _hasBits0 &= ~1;
        }
        /// <summary>Field number for the "low_battery" field.</summary>
        public const int LowBatteryFieldNumber = 10;
        private bool lowBattery_;
        /// <summary>
        /// Indicates whether the battery of this electronic lock is low, and needs
        /// replacing, or is normal and doesn't need replacing.
        /// </summary>
        public bool LowBattery
        {
            get => lowBattery_; set => lowBattery_ = value;}
        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 11;
        private Google.Protobuf.WellKnownTypes.Timestamp lastEventTime_;
        /// <summary>
        /// The last time an event was received.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp LastEventTime
        {
            get => lastEventTime_; set => lastEventTime_ = value;}
        /// <summary>Field number for the "calibration_settings" field.</summary>
        public const int CalibrationSettingsFieldNumber = 12;
        private static readonly ByteString CalibrationSettingsDefaultValue = ByteString.Empty;

        private ByteString calibrationSettings_;
        /// <summary>
        /// Calibration settings of an electronic lock. This only applies to
        /// electronic locks that must be calibrated once mounted to adapt to the
        /// door's specific characteristics. For example, certain motorized
        /// electronic locks need to be calibrated so they can learn the different
        /// positions of a door.
        /// </summary>
        public ByteString CalibrationSettings
        {
            get => calibrationSettings_ ?? CalibrationSettingsDefaultValue; set => calibrationSettings_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "calibration_settings" field is set</summary>
        public bool HasCalibrationSettings => calibrationSettings_ != null;
        /// <summary>Clears the value of the "calibration_settings" field</summary>
        public void ClearCalibrationSettings() => calibrationSettings_ = null;
        /// <summary>Field number for the "force_rotate_carriage_end" field.</summary>
        public const int ForceRotateCarriageEndFieldNumber = 13;
        private static readonly bool ForceRotateCarriageEndDefaultValue = false;

        private bool forceRotateCarriageEnd_;
        /// <summary>
        /// Indicates whether the electronic lock operates by turning in one
        /// direction until it reaches the carriage end, or not.
        /// For example, this could apply to electronic locks that are unaware of the
        /// carriage's endpoint or those that can lose their position, as seen in
        /// double clutch cylinders.
        /// </summary>
        public bool ForceRotateCarriageEnd
        {
            get { if ((_hasBits0 & 2) != 0) { return forceRotateCarriageEnd_; } else { return ForceRotateCarriageEndDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                forceRotateCarriageEnd_ = value;
            }
        }
        /// <summary>Gets whether the "force_rotate_carriage_end" field is set</summary>
        public bool HasForceRotateCarriageEnd => (_hasBits0 & 2) != 0;
        /// <summary>Clears the value of the "force_rotate_carriage_end" field</summary>
        public void ClearForceRotateCarriageEnd()
        {
            _hasBits0 &= ~2;
        }
        /// <summary>Field number for the "hold_back_latch_duration" field.</summary>
        public const int HoldBackLatchDurationFieldNumber = 14;
        private Google.Protobuf.WellKnownTypes.Duration holdBackLatchDuration_;
        /// <summary>
        /// If applicable, the duration the motorized lock's hold-back latch remains
        /// engaged before the latch closes.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Duration HoldBackLatchDuration
        {
            get => holdBackLatchDuration_; set => holdBackLatchDuration_ = value;}

        private object parentDevice_;
        /// <summary>Enum of possible cases for the "parent_device" oneof.</summary>
        public enum ParentDeviceOneofCase
        {
            None = 0,
            Gateway = 4,
            Extender = 5,
        }

        private ParentDeviceOneofCase parentDeviceCase_ = ParentDeviceOneofCase.None;

        public ParentDeviceOneofCase ParentDeviceCase
        {
            get => parentDeviceCase_;}

        public void ClearParentDevice()
        {
            parentDeviceCase_ = ParentDeviceOneofCase.None;
            parentDevice_ = null;
        }

        public override bool Equals(object other) => Equals(other as ElectronicLock);
        public bool Equals(ElectronicLock other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName) || (DeviceId != other.DeviceId) || (Gateway != other.Gateway) || (Extender != other.Extender) || (AccessPoint != other.AccessPoint) || (Initialized != other.Initialized) || (!Equals(DeviceMetadata, other.DeviceMetadata)) || (Outdated != other.Outdated) || (Connected != other.Connected) || (LowBattery != other.LowBattery) || (!Equals(LastEventTime, other.LastEventTime)) || (CalibrationSettings != other.CalibrationSettings) || (ForceRotateCarriageEnd != other.ForceRotateCarriageEnd) || (!Equals(HoldBackLatchDuration, other.HoldBackLatchDuration)) || (ParentDeviceCase != other.ParentDeviceCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (HasGateway) hash ^= Gateway.GetHashCode();
            if (HasExtender) hash ^= Extender.GetHashCode();
            if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (HasConnected) hash ^= Connected.GetHashCode();
            if (LowBattery != false) hash ^= LowBattery.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (HasCalibrationSettings) hash ^= CalibrationSettings.GetHashCode();
            if (HasForceRotateCarriageEnd) hash ^= ForceRotateCarriageEnd.GetHashCode();
            if (holdBackLatchDuration_ != null) hash ^= HoldBackLatchDuration.GetHashCode();
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
      if (HasGateway)
      {
        output.WriteRawTag(34);
        output.WriteString(Gateway);
      }
      if (HasExtender)
      {
        output.WriteRawTag(42);
        output.WriteString(Extender);
      }
      if (AccessPoint.Length != 0)
      {
        output.WriteRawTag(50);
        output.WriteString(AccessPoint);
      }
      if (Initialized != false)
      {
        output.WriteRawTag(56);
        output.WriteBool(Initialized);
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
      if (LowBattery != false)
      {
        output.WriteRawTag(80);
        output.WriteBool(LowBattery);
      }
      if (lastEventTime_ != null)
      {
        output.WriteRawTag(90);
        output.WriteMessage(LastEventTime);
      }
      if (HasCalibrationSettings)
      {
        output.WriteRawTag(98);
        output.WriteBytes(CalibrationSettings);
      }
      if (HasForceRotateCarriageEnd)
      {
        output.WriteRawTag(104);
        output.WriteBool(ForceRotateCarriageEnd);
      }
      if (holdBackLatchDuration_ != null)
      {
        output.WriteRawTag(114);
        output.WriteMessage(HoldBackLatchDuration);
      }
      if (deviceMetadata_ != null)
      {
        output.WriteRawTag(122);
        output.WriteMessage(DeviceMetadata);
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
            if (HasGateway)
            {
                output.WriteRawTag(34);
                output.WriteString(Gateway);
            }
            if (HasExtender)
            {
                output.WriteRawTag(42);
                output.WriteString(Extender);
            }
            if (AccessPoint.Length != 0)
            {
                output.WriteRawTag(50);
                output.WriteString(AccessPoint);
            }
            if (Initialized != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(Initialized);
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
            if (LowBattery != false)
            {
                output.WriteRawTag(80);
                output.WriteBool(LowBattery);
            }
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(LastEventTime);
            }
            if (HasCalibrationSettings)
            {
                output.WriteRawTag(98);
                output.WriteBytes(CalibrationSettings);
            }
            if (HasForceRotateCarriageEnd)
            {
                output.WriteRawTag(104);
                output.WriteBool(ForceRotateCarriageEnd);
            }
            if (holdBackLatchDuration_ != null)
            {
                output.WriteRawTag(114);
                output.WriteMessage(HoldBackLatchDuration);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(122);
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
            if (HasGateway) size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            if (HasExtender) size += 1 + CodedOutputStream.ComputeStringSize(Extender);
            if (AccessPoint.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccessPoint);
            if (Initialized != false) size += 1 + 1;
            if (deviceMetadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            if ((Outdated != false) || (HasConnected)) size += 1 + 1;
            if (LowBattery != false) size += 1 + 1;
            if (lastEventTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            if (HasCalibrationSettings) size += 1 + CodedOutputStream.ComputeBytesSize(CalibrationSettings);
            if (HasForceRotateCarriageEnd) size += 1 + 1;
            if (holdBackLatchDuration_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(HoldBackLatchDuration);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ElectronicLock other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasDeviceId) DeviceId = other.DeviceId;
            if (other.AccessPoint.Length != 0) AccessPoint = other.AccessPoint;
            if (other.Initialized != false) Initialized = other.Initialized;
            if (other.deviceMetadata_ != null)
            {
                if (deviceMetadata_ == null) DeviceMetadata = new Type.DeviceMetadata();
                DeviceMetadata.MergeFrom(other.DeviceMetadata);
            }
            if (other.Outdated != false) Outdated = other.Outdated;
            if (other.HasConnected) Connected = other.Connected;
            if (other.LowBattery != false) LowBattery = other.LowBattery;
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.HasCalibrationSettings) CalibrationSettings = other.CalibrationSettings;
            if (other.HasForceRotateCarriageEnd) ForceRotateCarriageEnd = other.ForceRotateCarriageEnd;
            if (other.holdBackLatchDuration_ != null)
            {
                if (holdBackLatchDuration_ == null) HoldBackLatchDuration = new Google.Protobuf.WellKnownTypes.Duration();
                HoldBackLatchDuration.MergeFrom(other.HoldBackLatchDuration);
            }
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
          case 34:
          {
            Gateway = input.ReadString();
            break;
          }
          case 42:
          {
            Extender = input.ReadString();
            break;
          }
          case 50:
          {
            AccessPoint = input.ReadString();
            break;
          }
          case 56:
          {
            Initialized = input.ReadBool();
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
            if (lastEventTime_ == null)
            {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 98:
          {
            CalibrationSettings = input.ReadBytes();
            break;
          }
          case 104:
          {
            ForceRotateCarriageEnd = input.ReadBool();
            break;
          }
          case 114:
          {
            if (holdBackLatchDuration_ == null)
            {
              HoldBackLatchDuration = new Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(HoldBackLatchDuration);
            break;
          }
          case 122:
          {
            if (deviceMetadata_ == null)
            {
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
                    case 34:
                        {
                            Gateway = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            Extender = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            AccessPoint = input.ReadString();
                            break;
                        }
                    case 56:
                        {
                            Initialized = input.ReadBool();
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
                    case 98:
                        {
                            CalibrationSettings = input.ReadBytes();
                            break;
                        }
                    case 104:
                        {
                            ForceRotateCarriageEnd = input.ReadBool();
                            break;
                        }
                    case 114:
                        {
                            if (holdBackLatchDuration_ == null) HoldBackLatchDuration = new Google.Protobuf.WellKnownTypes.Duration();
                            input.ReadMessage(HoldBackLatchDuration);
                            break;
                        }
                    case 122:
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