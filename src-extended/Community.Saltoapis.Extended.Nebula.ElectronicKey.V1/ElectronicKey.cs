namespace Saltoapis.Nebula.ElectronicKey.V1
{
    /// <summary>
    /// The electronic key object
    /// </summary>
    public sealed partial class ElectronicKey : IMessage<ElectronicKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicKey> _parser = new(() => new ElectronicKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ElectronicKey> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ElectronicKeyReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ElectronicKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicKey(ElectronicKey other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            initialized_ = other.initialized_;
            deviceId_ = other.deviceId_;
            outdated_ = other.outdated_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            user_ = other.user_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ElectronicKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Output only. Resource name of the electronic key. It must have the format of
        /// `installations/*/electronic-keys/*`. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the electronic key.
        /// </summary>
        public string DisplayName
        {
            get => displayName_; set => displayName_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 3;
        private bool initialized_;
        /// <summary>
        /// Indicates whether this electronic key has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.UpdateElectronicKey]
        /// operation. To change the value of this field, you must call
        /// [`InitializeElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.InitializeElectronicKey].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get => initialized_; set => initialized_ = value;}
        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 4;
        private static readonly string DeviceIdDefaultValue = "";

        private string deviceId_;
        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, electronic keys and so on.
        /// </summary>
        public string DeviceId
        {
            get => deviceId_ ?? DeviceIdDefaultValue; set => deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId => deviceId_ != null;
        /// <summary>Clears the value of the "device_id" field</summary>
        public void ClearDeviceId() => deviceId_ = null;
        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 5;
        private bool outdated_;
        /// <summary>
        /// Indicates whether this electronic key has pending updates or not. This
        /// could be because there was a pending configuration or a firmware update
        /// and is conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get => outdated_; set => outdated_ = value;}
        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 6;
        private Type.DeviceMetadata deviceMetadata_;
        /// <summary>
        /// Device metadata contains information about a device hardware and firmware.
        /// </summary>
        public Type.DeviceMetadata DeviceMetadata
        {
            get => deviceMetadata_; set => deviceMetadata_ = value;}
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 8;
        private static readonly string UserDefaultValue = "";

        private string user_;
        /// <summary>
        /// User associated with this electronic key.
        /// </summary>
        public string User
        {
            get => user_ ?? UserDefaultValue; set => user_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "user" field is set</summary>
        public bool HasUser => user_ != null;
        /// <summary>Clears the value of the "user" field</summary>
        public void ClearUser() => user_ = null;

        public override bool Equals(object other) => Equals(other as ElectronicKey);
        public bool Equals(ElectronicKey other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName) || (Initialized != other.Initialized) || (DeviceId != other.DeviceId) || (Outdated != other.Outdated) || (!Equals(DeviceMetadata, other.DeviceMetadata)) || User != other.User) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (HasUser) hash ^= User.GetHashCode();
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
      if (Initialized != false)
      {
        output.WriteRawTag(24);
        output.WriteBool(Initialized);
      }
      if (HasDeviceId)
      {
        output.WriteRawTag(34);
        output.WriteString(DeviceId);
      }
      if (Outdated != false)
      {
        output.WriteRawTag(40);
        output.WriteBool(Outdated);
      }
      if (deviceMetadata_ != null)
      {
        output.WriteRawTag(50);
        output.WriteMessage(DeviceMetadata);
      }
      if (HasUser)
      {
        output.WriteRawTag(66);
        output.WriteString(User);
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
            if (Initialized != false)
            {
                output.WriteRawTag(24);
                output.WriteBool(Initialized);
            }
            if (HasDeviceId)
            {
                output.WriteRawTag(34);
                output.WriteString(DeviceId);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(40);
                output.WriteBool(Outdated);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(DeviceMetadata);
            }
            if (HasUser)
            {
                output.WriteRawTag(66);
                output.WriteString(User);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (Initialized != false) size += 1 + 1;
            if (HasDeviceId) size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            if (Outdated != false) size += 1 + 1;
            if (deviceMetadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            if (HasUser) size += 1 + CodedOutputStream.ComputeStringSize(User);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ElectronicKey other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.Initialized != false) Initialized = other.Initialized;
            if (other.HasDeviceId) DeviceId = other.DeviceId;
            if (other.Outdated != false) Outdated = other.Outdated;
            if (other.deviceMetadata_ != null)
            {
                if (deviceMetadata_ == null) DeviceMetadata = new Type.DeviceMetadata();
                DeviceMetadata.MergeFrom(other.DeviceMetadata);
            }
            if (other.HasUser) User = other.User;
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
          case 24:
          {
            Initialized = input.ReadBool();
            break;
          }
          case 34:
          {
            DeviceId = input.ReadString();
            break;
          }
          case 40:
          {
            Outdated = input.ReadBool();
            break;
          }
          case 50:
          {
            if (deviceMetadata_ == null)
            {
              DeviceMetadata = new Saltoapis.Nebula.Type.DeviceMetadata();
            }
            input.ReadMessage(DeviceMetadata);
            break;
          }
          case 66:
          {
            User = input.ReadString();
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
                    case 24:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 34:
                        {
                            DeviceId = input.ReadString();
                            break;
                        }
                    case 40:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                    case 50:
                        {
                            if (deviceMetadata_ == null) DeviceMetadata = new Type.DeviceMetadata();
                            input.ReadMessage(DeviceMetadata);
                            break;
                        }
                    case 66:
                        {
                            User = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }
}