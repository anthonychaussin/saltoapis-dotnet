namespace Saltoapis.Nebula.Encoder.V1.Response
{
    /// <summary>
    /// The response message for [`ReadKey`][salto.nebula.device.v1.EncoderService.ReadKey]
    /// </summary>
    public sealed partial class ReadKeyResponse : IMessage<ReadKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ReadKeyResponse> _parser = new(() => new ReadKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ReadKeyResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => EncoderReflection.Descriptor.MessageTypes[24];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ReadKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ReadKeyResponse(ReadKeyResponse other) : this()
        {
            switch (other.KeyCase)
            {
                case KeyOneofCase.CardKey:
                    CardKey = other.CardKey;
                    break;
                case KeyOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey;
                    break;
            }

            switch (other.KeyIdCase)
            {
                case KeyIdOneofCase.Uid:
                    Uid = other.Uid;
                    break;
                case KeyIdOneofCase.DeviceId:
                    DeviceId = other.DeviceId;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ReadKeyResponse Clone() => new(this);
        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 1;
        /// <summary>
        /// Card key reference, belonging to a user.
        /// </summary>
        public string CardKey
        {
            get { return HasCardKey ? (string)key_ : ""; }
            set
            {
                key_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyCase_ = KeyOneofCase.CardKey;
            }
        }
        /// <summary>Gets whether the "card_key" field is set</summary>
        public bool HasCardKey => keyCase_ == KeyOneofCase.CardKey;
        /// <summary> Clears the value of the oneof if it's currently set to "card_key" </summary>
        public void ClearCardKey()
        {
            if (HasCardKey) ClearKey();
        }
        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 2;
        /// <summary>
        /// Electronic key reference, belonging to a user.
        /// </summary>
        public string ElectronicKey
        {
            get { return HasElectronicKey ? (string)key_ : ""; }
            set
            {
                key_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyCase_ = KeyOneofCase.ElectronicKey;
            }
        }
        /// <summary>Gets whether the "electronic_key" field is set</summary>
        public bool HasElectronicKey => keyCase_ == KeyOneofCase.ElectronicKey;
        /// <summary> Clears the value of the oneof if it's currently set to "electronic_key" </summary>
        public void ClearElectronicKey()
        {
            if (HasElectronicKey) ClearKey();
        }
        /// <summary>Field number for the "uid" field.</summary>
        public const int UidFieldNumber = 3;
        /// <summary>
        /// UID of the key that was read.
        /// </summary>
        public string Uid
        {
            get { return HasUid ? (string)keyId_ : ""; }
            set
            {
                keyId_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyIdCase_ = KeyIdOneofCase.Uid;
            }
        }
        /// <summary>Gets whether the "uid" field is set</summary>
        public bool HasUid => keyIdCase_ == KeyIdOneofCase.Uid;
        /// <summary> Clears the value of the oneof if it's currently set to "uid" </summary>
        public void ClearUid()
        {
            if (HasUid) ClearKeyId();
        }
        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 4;
        /// <summary>
        /// Device ID of the key that was read.
        /// </summary>
        public string DeviceId
        {
            get { return HasDeviceId ? (string)keyId_ : ""; }
            set
            {
                keyId_ = ProtoPreconditions.CheckNotNull(value, "value");
                keyIdCase_ = KeyIdOneofCase.DeviceId;
            }
        }
        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId => keyIdCase_ == KeyIdOneofCase.DeviceId;
        /// <summary> Clears the value of the oneof if it's currently set to "device_id" </summary>
        public void ClearDeviceId()
        {
            if (HasDeviceId) ClearKeyId();
        }

        private object key_;
        /// <summary>Enum of possible cases for the "key" oneof.</summary>
        public enum KeyOneofCase
        {
            None = 0,
            CardKey = 1,
            ElectronicKey = 2,
        }

        private KeyOneofCase keyCase_ = KeyOneofCase.None;

        public KeyOneofCase KeyCase
        {
            get => keyCase_;}

        public void ClearKey()
        {
            keyCase_ = KeyOneofCase.None;
            key_ = null;
        }

        private object keyId_;
        /// <summary>Enum of possible cases for the "key_id" oneof.</summary>
        public enum KeyIdOneofCase
        {
            None = 0,
            Uid = 3,
            DeviceId = 4,
        }

        private KeyIdOneofCase keyIdCase_ = KeyIdOneofCase.None;

        public KeyIdOneofCase KeyIdCase
        {
            get => keyIdCase_;}

        public void ClearKeyId()
        {
            keyIdCase_ = KeyIdOneofCase.None;
            keyId_ = null;
        }

        public override bool Equals(object other) => Equals(other as ReadKeyResponse);
        public bool Equals(ReadKeyResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((CardKey != other.CardKey) || (ElectronicKey != other.ElectronicKey) || (Uid != other.Uid) || (DeviceId != other.DeviceId) || (KeyCase != other.KeyCase) || (KeyIdCase != other.KeyIdCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (HasCardKey) hash ^= CardKey.GetHashCode();
            if (HasElectronicKey) hash ^= ElectronicKey.GetHashCode();
            if (HasUid) hash ^= Uid.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            hash ^= (int)keyCase_;
            hash ^= (int)keyIdCase_;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (HasCardKey)
      {
        output.WriteRawTag(10);
        output.WriteString(CardKey);
      }
      if (HasElectronicKey)
      {
        output.WriteRawTag(18);
        output.WriteString(ElectronicKey);
      }
      if (HasUid)
      {
        output.WriteRawTag(26);
        output.WriteString(Uid);
      }
      if (HasDeviceId)
      {
        output.WriteRawTag(34);
        output.WriteString(DeviceId);
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
            if (HasCardKey)
            {
                output.WriteRawTag(10);
                output.WriteString(CardKey);
            }
            if (HasElectronicKey)
            {
                output.WriteRawTag(18);
                output.WriteString(ElectronicKey);
            }
            if (HasUid)
            {
                output.WriteRawTag(26);
                output.WriteString(Uid);
            }
            if (HasDeviceId)
            {
                output.WriteRawTag(34);
                output.WriteString(DeviceId);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (HasCardKey) size += 1 + CodedOutputStream.ComputeStringSize(CardKey);
            if (HasElectronicKey) size += 1 + CodedOutputStream.ComputeStringSize(ElectronicKey);
            if (HasUid) size += 1 + CodedOutputStream.ComputeStringSize(Uid);
            if (HasDeviceId) size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ReadKeyResponse other)
        {
            if (other == null) return;
            switch (other.KeyCase)
            {
                case KeyOneofCase.CardKey:
                    CardKey = other.CardKey;
                    break;
                case KeyOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey;
                    break;
            }

            switch (other.KeyIdCase)
            {
                case KeyIdOneofCase.Uid:
                    Uid = other.Uid;
                    break;
                case KeyIdOneofCase.DeviceId:
                    DeviceId = other.DeviceId;
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
            CardKey = input.ReadString();
            break;
          }
          case 18:
          {
            ElectronicKey = input.ReadString();
            break;
          }
          case 26:
          {
            Uid = input.ReadString();
            break;
          }
          case 34:
          {
            DeviceId = input.ReadString();
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
                            CardKey = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            ElectronicKey = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Uid = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            DeviceId = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}