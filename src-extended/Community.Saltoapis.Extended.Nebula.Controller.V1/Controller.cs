namespace Saltoapis.Nebula.Controller.V1
{
    /// <summary>
    /// The controller object
    /// </summary>
    public sealed partial class Controller : IMessage<Controller>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Controller> _parser = new(() => new Controller());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<Controller> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Controller()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Controller(Controller other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            accessPoints_ = other.accessPoints_.Clone();
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            outdated_ = other.outdated_;
            connected_ = other.connected_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            cardKeyUpdater_ = other.cardKeyUpdater_;
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

        public Controller Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the controller. It must have the format of
        /// `installations/*/controllers/*`. For example:
        /// `installations/surelock-homes-hq/controller/dancing-men`.
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
        /// Display name of the controller.
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
        private static readonly string DeviceIdDefaultValue = "";

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

        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 4;

        /// <summary>
        /// Parent name, when controller is connected to a gateway
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
        public const int ExtenderFieldNumber = 5;

        /// <summary>
        /// Parent name, when controller is connected to an extender
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

        /// <summary>Field number for the "access_points" field.</summary>
        public const int AccessPointsFieldNumber = 6;
        private static readonly FieldCodec<string> _repeated_accessPoints_codec
            = FieldCodec.ForString(50);
        private readonly RepeatedField<string> accessPoints_ = [];

        /// <summary>
        /// The access points that the controller gives coverage to.
        /// </summary>
        public RepeatedField<string> AccessPoints
        {
            get { return accessPoints_; }
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 7;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this controller has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateController`][salto.nebula.controller.v1.ControllerService.UpdateController]
        /// operation. To change the value of this field, you must call
        /// [`InitializeController`][salto.nebula.controller.v1.ControllerService.InitializeController].
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
        public const int DeviceMetadataFieldNumber = 11;
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

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 8;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this controller has pending updates or not. This
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
        private static readonly bool ConnectedDefaultValue = false;

        private bool connected_;

        /// <summary>
        /// Indicates whether this controller is connected or not. It's
        /// considered connected if there has been at least one communication with it
        /// within the last 10 minutes. The property is left unset if it is an
        /// offline controller.
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

        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 10;
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

        /// <summary>Field number for the "card_key_updater" field.</summary>
        public const int CardKeyUpdaterFieldNumber = 12;
        private static readonly bool CardKeyUpdaterDefaultValue = false;

        private bool cardKeyUpdater_;

        /// <summary>
        /// Enables or disables card key updates. This property is only relevant when
        /// the controller functions as a destination enabler.
        /// </summary>
        public bool CardKeyUpdater
        {
            get { if ((_hasBits0 & 2) != 0) { return cardKeyUpdater_; } else { return CardKeyUpdaterDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                cardKeyUpdater_ = value;
            }
        }

        /// <summary>Gets whether the "card_key_updater" field is set</summary>
        public bool HasCardKeyUpdater
        {
            get { return (_hasBits0 & 2) != 0; }
        }

        /// <summary>Clears the value of the "card_key_updater" field</summary>
        public void ClearCardKeyUpdater()
        {
            _hasBits0 &= ~2;
        }

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
            get { return parentDeviceCase_; }
        }

        public void ClearParentDevice()
        {
            parentDeviceCase_ = ParentDeviceOneofCase.None;
            parentDevice_ = null;
        }

        public override bool Equals(object other) => Equals(other as Controller);
        public bool Equals(Controller other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName)) return false;
            if ((DeviceId != other.DeviceId) || (Gateway != other.Gateway)) return false;
            if ((Extender != other.Extender) || (!accessPoints_.Equals(other.accessPoints_))) return false;
            if ((Initialized != other.Initialized) || (!Equals(DeviceMetadata, other.DeviceMetadata))) return false;
            if ((Outdated != other.Outdated) || (Connected != other.Connected)) return false;
            if ((!Equals(LastEventTime, other.LastEventTime)) || (CardKeyUpdater != other.CardKeyUpdater)) return false;
            if (ParentDeviceCase != other.ParentDeviceCase) return false;
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
            hash ^= accessPoints_.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (HasConnected) hash ^= Connected.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (HasCardKeyUpdater) hash ^= CardKeyUpdater.GetHashCode();
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
      if (HasGateway) {
        output.WriteRawTag(34);
        output.WriteString(Gateway);
      }
      if (HasExtender) {
        output.WriteRawTag(42);
        output.WriteString(Extender);
      }
      accessPoints_.WriteTo(output, _repeated_accessPoints_codec);
      if (Initialized != false) {
        output.WriteRawTag(56);
        output.WriteBool(Initialized);
      }
      if (Outdated != false) {
        output.WriteRawTag(64);
        output.WriteBool(Outdated);
      }
      if (HasConnected) {
        output.WriteRawTag(72);
        output.WriteBool(Connected);
      }
      if (lastEventTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LastEventTime);
      }
      if (deviceMetadata_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DeviceMetadata);
      }
      if (HasCardKeyUpdater) {
        output.WriteRawTag(96);
        output.WriteBool(CardKeyUpdater);
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
            accessPoints_.WriteTo(ref output, _repeated_accessPoints_codec);
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
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(82);
                output.WriteMessage(LastEventTime);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(DeviceMetadata);
            }
            if (HasCardKeyUpdater)
            {
                output.WriteRawTag(96);
                output.WriteBool(CardKeyUpdater);
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
            size += accessPoints_.CalculateSize(_repeated_accessPoints_codec);
            if (Initialized != false) size += 1 + 1;
            if (deviceMetadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            if ((Outdated != false) || (HasConnected)) size += 1 + 1;
            if (lastEventTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            if (HasCardKeyUpdater) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Controller other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasDeviceId) DeviceId = other.DeviceId;
            accessPoints_.Add(other.accessPoints_);
            if (other.Initialized != false) Initialized = other.Initialized;
            if (other.deviceMetadata_ != null)
            {
                if (deviceMetadata_ == null) DeviceMetadata = new Type.DeviceMetadata();
                DeviceMetadata.MergeFrom(other.DeviceMetadata);
            }
            if (other.Outdated != false) Outdated = other.Outdated;
            if (other.HasConnected) Connected = other.Connected;
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.HasCardKeyUpdater) CardKeyUpdater = other.CardKeyUpdater;
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
          case 34: {
            Gateway = input.ReadString();
            break;
          }
          case 42: {
            Extender = input.ReadString();
            break;
          }
          case 50: {
            accessPoints_.AddEntriesFrom(input, _repeated_accessPoints_codec);
            break;
          }
          case 56: {
            Initialized = input.ReadBool();
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
          case 82: {
            if (lastEventTime_ == null) {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 90: {
            if (deviceMetadata_ == null) {
              DeviceMetadata = new Saltoapis.Nebula.Type.DeviceMetadata();
            }
            input.ReadMessage(DeviceMetadata);
            break;
          }
          case 96: {
            CardKeyUpdater = input.ReadBool();
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
                            accessPoints_.AddEntriesFrom(ref input, _repeated_accessPoints_codec);
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
                    case 82:
                        {
                            if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(LastEventTime);
                            break;
                        }
                    case 90:
                        {
                            if (deviceMetadata_ == null) DeviceMetadata = new Type.DeviceMetadata();
                            input.ReadMessage(DeviceMetadata);
                            break;
                        }
                    case 96:
                        {
                            CardKeyUpdater = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }
}
