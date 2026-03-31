namespace Saltoapis.Nebula.IntercomAdaptor.V1
{
    /// <summary>
    /// The intercom adaptor object
    /// </summary>
    public sealed partial class IntercomAdaptor : IMessage<IntercomAdaptor>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IntercomAdaptor> _parser = new(() => new IntercomAdaptor());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IntercomAdaptor> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => IntercomAdaptorReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public IntercomAdaptor()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IntercomAdaptor(IntercomAdaptor other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            accessPoints_ = other.accessPoints_.Clone();
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            outdated_ = other.outdated_;
            connected_ = other.connected_;
            lowBattery_ = other.lowBattery_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            intercom_ = other.intercom_;
            photos_ = other.photos_.Clone();
            photoUris_ = other.photoUris_.Clone();
            readings_ = other.readings_.Clone();
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

        public IntercomAdaptor Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Output only. Resource name of the intercom adaptor. It must have the format of
        /// `installations/*/intercom-adaptors/*`. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/dancing-men`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the intercom adaptor.
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
        /// by SALTO, including gateways, extenders, intercom adaptors and so on.
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
        /// Parent name, when intercom adaptor is connected to a gateway
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
        /// Parent name, when intercom adaptor is connected to an extender
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
        /// <summary>Field number for the "access_points" field.</summary>
        public const int AccessPointsFieldNumber = 6;
        private static readonly FieldCodec<IntercomAdaptorAccessPoint> _repeated_accessPoints_codec
            = FieldCodec.ForMessage(50, IntercomAdaptorAccessPoint.Parser);
        private readonly RepeatedField<IntercomAdaptorAccessPoint> accessPoints_ = [];
        /// <summary>
        /// The access points that the intercom adaptor gives coverage to.
        /// </summary>
        public RepeatedField<IntercomAdaptorAccessPoint> AccessPoints
        {
            get => accessPoints_;}
        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 7;
        private bool initialized_;
        /// <summary>
        /// Indicates whether this intercom adaptor has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UpdateIntercomAdaptor]
        /// operation. To change the value of this field, you must call
        /// [`InitializeIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.InitializeIntercomAdaptor].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get => initialized_; set => initialized_ = value;}
        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 16;
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
        /// Indicates whether this intercom adaptor has pending updates or not. This
        /// could be because there was a pending configuration or a firmware update
        /// and is conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get => outdated_; set => outdated_ = value;}
        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 9;
        private bool connected_;
        /// <summary>
        /// Indicates whether this intercom adaptor is connected or not. It's
        /// considered connected if there has been at least one communication with it
        /// within the last 10 minutes.
        /// </summary>
        public bool Connected
        {
            get => connected_; set => connected_ = value;}
        /// <summary>Field number for the "low_battery" field.</summary>
        public const int LowBatteryFieldNumber = 10;
        private bool lowBattery_;
        /// <summary>
        /// Indicates whether the battery of this intercom adaptor is low, and needs
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
        /// <summary>Field number for the "intercom" field.</summary>
        public const int IntercomFieldNumber = 12;
        private static readonly string IntercomDefaultValue = "";

        private string intercom_;
        /// <summary>
        /// Reference to intercom system model it is connected to. It will be used to
        /// know which parametrization to apply when configuring it.
        /// </summary>
        public string Intercom
        {
            get => intercom_ ?? IntercomDefaultValue; set => intercom_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "intercom" field is set</summary>
        public bool HasIntercom => intercom_ != null;
        /// <summary>Clears the value of the "intercom" field</summary>
        public void ClearIntercom() => intercom_ = null;
        /// <summary>Field number for the "photos" field.</summary>
        public const int PhotosFieldNumber = 13;
        private static readonly FieldCodec<string> _repeated_photos_codec
            = FieldCodec.ForString(106);
        private readonly RepeatedField<string> photos_ = [];
        /// <summary>
        /// The file resource names for the intercom adaptor photos. It must have the
        /// format of
        /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
        /// </summary>
        public RepeatedField<string> Photos
        {
            get => photos_;}
        /// <summary>Field number for the "photo_uris" field.</summary>
        public const int PhotoUrisFieldNumber = 14;
        private static readonly FieldCodec<string> _repeated_photoUris_codec
            = FieldCodec.ForString(114);
        private readonly RepeatedField<string> photoUris_ = [];
        /// <summary>
        /// The URIs to view the intercom adaptor photos.
        /// </summary>
        public RepeatedField<string> PhotoUris
        {
            get => photoUris_;}
        /// <summary>Field number for the "readings" field.</summary>
        public const int ReadingsFieldNumber = 15;
        private static readonly FieldCodec<string> _repeated_readings_codec
            = FieldCodec.ForString(122);
        private readonly RepeatedField<string> readings_ = [];
        /// <summary>
        /// The file resource names for intercom adaptor readings retrieved from the device's bus.
        /// It comes into play when the learning process encounters unexpected issues, prompting expert
        /// analysis of the readings. It must have the
        /// format of
        /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
        /// </summary>
        public RepeatedField<string> Readings
        {
            get => readings_;}

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

        public override bool Equals(object other) => Equals(other as IntercomAdaptor);
        public bool Equals(IntercomAdaptor other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName) || (DeviceId != other.DeviceId) || (Gateway != other.Gateway) || (Extender != other.Extender) || (!accessPoints_.Equals(other.accessPoints_)) || (Initialized != other.Initialized) || (!Equals(DeviceMetadata, other.DeviceMetadata)) || (Outdated != other.Outdated) || (Connected != other.Connected) || (LowBattery != other.LowBattery) || (!Equals(LastEventTime, other.LastEventTime)) || (Intercom != other.Intercom) || (!photos_.Equals(other.photos_)) || (!photoUris_.Equals(other.photoUris_)) || (!readings_.Equals(other.readings_)) || ParentDeviceCase != other.ParentDeviceCase) return false;
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
            if (Connected != false) hash ^= Connected.GetHashCode();
            if (LowBattery != false) hash ^= LowBattery.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (HasIntercom) hash ^= Intercom.GetHashCode();
            hash ^= photos_.GetHashCode();
            hash ^= photoUris_.GetHashCode();
            hash ^= readings_.GetHashCode();
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
      accessPoints_.WriteTo(output, _repeated_accessPoints_codec);
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
      if (Connected != false)
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
      if (HasIntercom)
      {
        output.WriteRawTag(98);
        output.WriteString(Intercom);
      }
      photos_.WriteTo(output, _repeated_photos_codec);
      photoUris_.WriteTo(output, _repeated_photoUris_codec);
      readings_.WriteTo(output, _repeated_readings_codec);
      if (deviceMetadata_ != null)
      {
        output.WriteRawTag(130, 1);
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
            if (Connected != false)
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
            if (HasIntercom)
            {
                output.WriteRawTag(98);
                output.WriteString(Intercom);
            }
            photos_.WriteTo(ref output, _repeated_photos_codec);
            photoUris_.WriteTo(ref output, _repeated_photoUris_codec);
            readings_.WriteTo(ref output, _repeated_readings_codec);
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(130, 1);
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
            size += accessPoints_.CalculateSize(_repeated_accessPoints_codec);
            if (Initialized != false) size += 1 + 1;
            if (deviceMetadata_ != null) size += 2 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            if ((Outdated != false) || (Connected != false)) size += 1 + 1;
            if (LowBattery != false) size += 1 + 1;
            if (lastEventTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            if (HasIntercom) size += 1 + CodedOutputStream.ComputeStringSize(Intercom);
            size += photos_.CalculateSize(_repeated_photos_codec);
            size += photoUris_.CalculateSize(_repeated_photoUris_codec);
            size += readings_.CalculateSize(_repeated_readings_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(IntercomAdaptor other)
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
            if (other.Connected != false) Connected = other.Connected;
            if (other.LowBattery != false) LowBattery = other.LowBattery;
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.HasIntercom) Intercom = other.Intercom;
            photos_.Add(other.photos_);
            photoUris_.Add(other.photoUris_);
            readings_.Add(other.readings_);
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
            accessPoints_.AddEntriesFrom(input, _repeated_accessPoints_codec);
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
            Intercom = input.ReadString();
            break;
          }
          case 106:
          {
            photos_.AddEntriesFrom(input, _repeated_photos_codec);
            break;
          }
          case 114:
          {
            photoUris_.AddEntriesFrom(input, _repeated_photoUris_codec);
            break;
          }
          case 122:
          {
            readings_.AddEntriesFrom(input, _repeated_readings_codec);
            break;
          }
          case 130:
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
                            Intercom = input.ReadString();
                            break;
                        }
                    case 106:
                        {
                            photos_.AddEntriesFrom(ref input, _repeated_photos_codec);
                            break;
                        }
                    case 114:
                        {
                            photoUris_.AddEntriesFrom(ref input, _repeated_photoUris_codec);
                            break;
                        }
                    case 122:
                        {
                            readings_.AddEntriesFrom(ref input, _repeated_readings_codec);
                            break;
                        }
                    case 130:
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