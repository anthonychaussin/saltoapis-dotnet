namespace Saltoapis.Nebula.Encoder.V1
{
    /// <summary>
    /// The encoder object
    /// </summary>
    public sealed partial class Encoder : IMessage<Encoder>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Encoder> _parser = new(() => new Encoder());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Encoder> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => EncoderReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public Encoder()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Encoder(Encoder other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            connected_ = other.connected_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            outdated_ = other.outdated_;
            disableSound_ = other.disableSound_;
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

        public Encoder Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Output only. Resource name of the encoder. It must have the format of
        /// `installations/*/encoders/*`. For example:
        /// `installations/surelock-homes-hq/encoders/dancing-men`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the encoder.
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
        /// by SALTO, including gateways, extenders, encoders and so on.
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
        /// Parent name, when encoder is connected to a gateway
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
        /// Parent name, when encoder is connected to an extender
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
        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 6;
        private bool initialized_;
        /// <summary>
        /// Indicates whether this encoder has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateEncoder`][salto.nebula.encoder.v1.EncoderService.UpdateEncoder]
        /// operation. To change the value of this field, you must call
        /// [`InitializeEncoder`][salto.nebula.encoder.v1.EncoderService.InitializeEncoder].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get => initialized_; set => initialized_ = value;}
        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 11;
        private Type.DeviceMetadata deviceMetadata_;
        /// <summary>
        /// Device metadata contains information about a device hardware and firmware.
        /// </summary>
        public Type.DeviceMetadata DeviceMetadata
        {
            get => deviceMetadata_; set => deviceMetadata_ = value;}
        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 7;
        private bool connected_;
        /// <summary>
        /// Indicates whether this encoder is connected or not. It's considered
        /// connected if there has been at least one communication with it within the
        /// last 10 minutes.
        /// </summary>
        public bool Connected
        {
            get => connected_; set => connected_ = value;}
        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 8;
        private Google.Protobuf.WellKnownTypes.Timestamp lastEventTime_;
        /// <summary>
        /// The last time an event was received.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp LastEventTime
        {
            get => lastEventTime_; set => lastEventTime_ = value;}
        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 9;
        private bool outdated_;
        /// <summary>
        /// Indicates whether this encoder has pending updates or not. This could be
        /// because there was a pending configuration or a firmware update and is
        /// conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get => outdated_; set => outdated_ = value;}
        /// <summary>Field number for the "disable_sound" field.</summary>
        public const int DisableSoundFieldNumber = 10;
        private bool disableSound_;
        /// <summary>
        /// Disables the sound emitted by the encoder during operation.
        /// </summary>
        public bool DisableSound
        {
            get => disableSound_; set => disableSound_ = value;}

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

        public override bool Equals(object other) => Equals(other as Encoder);
        public bool Equals(Encoder other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName) || (DeviceId != other.DeviceId) || (Gateway != other.Gateway) || (Extender != other.Extender) || (Initialized != other.Initialized) || (!Equals(DeviceMetadata, other.DeviceMetadata)) || (Connected != other.Connected) || (!Equals(LastEventTime, other.LastEventTime)) || (Outdated != other.Outdated) || (DisableSound != other.DisableSound) || (ParentDeviceCase != other.ParentDeviceCase)) return false;
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
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Connected != false) hash ^= Connected.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (DisableSound != false) hash ^= DisableSound.GetHashCode();
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
      if (Initialized != false)
      {
        output.WriteRawTag(48);
        output.WriteBool(Initialized);
      }
      if (Connected != false)
      {
        output.WriteRawTag(56);
        output.WriteBool(Connected);
      }
      if (lastEventTime_ != null)
      {
        output.WriteRawTag(66);
        output.WriteMessage(LastEventTime);
      }
      if (Outdated != false)
      {
        output.WriteRawTag(72);
        output.WriteBool(Outdated);
      }
      if (DisableSound != false)
      {
        output.WriteRawTag(80);
        output.WriteBool(DisableSound);
      }
      if (deviceMetadata_ != null)
      {
        output.WriteRawTag(90);
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
            if (Initialized != false)
            {
                output.WriteRawTag(48);
                output.WriteBool(Initialized);
            }
            if (Connected != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(Connected);
            }
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(LastEventTime);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(72);
                output.WriteBool(Outdated);
            }
            if (DisableSound != false)
            {
                output.WriteRawTag(80);
                output.WriteBool(DisableSound);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(90);
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
            if (Initialized != false) size += 1 + 1;
            if (deviceMetadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            if (Connected != false) size += 1 + 1;
            if (lastEventTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            if ((Outdated != false) || (DisableSound != false)) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Encoder other)
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
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.Outdated != false) Outdated = other.Outdated;
            if (other.DisableSound != false) DisableSound = other.DisableSound;
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
          case 48:
          {
            Initialized = input.ReadBool();
            break;
          }
          case 56:
          {
            Connected = input.ReadBool();
            break;
          }
          case 66:
          {
            if (lastEventTime_ == null)
            {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 72:
          {
            Outdated = input.ReadBool();
            break;
          }
          case 80:
          {
            DisableSound = input.ReadBool();
            break;
          }
          case 90:
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
                    case 48:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 56:
                        {
                            Connected = input.ReadBool();
                            break;
                        }
                    case 66:
                        {
                            if (lastEventTime_ == null) LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(LastEventTime);
                            break;
                        }
                    case 72:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                    case 80:
                        {
                            DisableSound = input.ReadBool();
                            break;
                        }
                    case 90:
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