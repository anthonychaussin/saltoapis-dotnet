using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Type
{

    /// <summary>Holder for reflection information generated from salto/nebula/type/device_metadata.proto</summary>
    public static partial class DeviceMetadataReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/type/device_metadata.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static DeviceMetadataReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CidzYWx0by9uZWJ1bGEvdHlwZS9kZXZpY2VfbWV0YWRhdGEucHJvdG8SEXNh",
                  "bHRvLm5lYnVsYS50eXBlGhVzYWx0by90eXBlL2RhdGUucHJvdG8itwIKDkRl",
                  "dmljZU1ldGFkYXRhEkYKDmNpcmN1aXRfYm9hcmRzGAEgAygLMi4uc2FsdG8u",
                  "bmVidWxhLnR5cGUuRGV2aWNlTWV0YWRhdGEuQ2lyY3VpdEJvYXJkGtwBCgxD",
                  "aXJjdWl0Qm9hcmQSKgoQbWFudWZhY3R1cmVfZGF0ZRgCIAEoCzIQLnNhbHRv",
                  "LnR5cGUuRGF0ZRIVCg1zZXJpYWxfbnVtYmVyGAMgASgJEkoKCWZpcm13YXJl",
                  "cxgEIAMoCzI3LnNhbHRvLm5lYnVsYS50eXBlLkRldmljZU1ldGFkYXRhLkNp",
                  "cmN1aXRCb2FyZC5GaXJtd2FyZRo9CghGaXJtd2FyZRIOCgZudW1iZXIYASAB",
                  "KAkSDwoHdmVyc2lvbhgCIAEoCRIQCghyZXZpc2lvbhgDIAEoCULcAQoZY29t",
                  "LnNhbHRvYXBpcy5uZWJ1bGEudHlwZUITRGV2aWNlTWV0YWRhdGFQcm90b1AB",
                  "WlRnaXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28v",
                  "bmVidWxhL3R5cGUvZGV2aWNlbWV0YWRhdGE7ZGV2aWNlbWV0YWRhdGGqAhVT",
                  "YWx0b2FwaXMuTmVidWxhLlR5cGXKAhVTYWx0b2FwaXNcTmVidWxhXFR5cGXi",
                  "AiFHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXFR5cGViBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Saltoapis.Type.DateReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(DeviceMetadata), DeviceMetadata.Parser, ["CircuitBoards"], null, null, null, [new(typeof(DeviceMetadata.Types.CircuitBoard), DeviceMetadata.Types.CircuitBoard.Parser, ["ManufactureDate", "SerialNumber", "Firmwares"], null, null, null, [new(typeof(DeviceMetadata.Types.CircuitBoard.Types.Firmware), DeviceMetadata.Types.CircuitBoard.Types.Firmware.Parser, ["Number", "Version", "Revision"], null, null, null, null)])])
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// Metadata contains information about a device. Most metadata is immutable.
    /// </summary>
    public sealed partial class DeviceMetadata : IMessage<DeviceMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeviceMetadata> _parser = new(() => new DeviceMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeviceMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DeviceMetadataReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeviceMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeviceMetadata(DeviceMetadata other) : this()
        {
            circuitBoards_ = other.circuitBoards_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeviceMetadata Clone() => new(this);
        /// <summary>Field number for the "circuit_boards" field.</summary>
        public const int CircuitBoardsFieldNumber = 1;
        private static readonly FieldCodec<Types.CircuitBoard> _repeated_circuitBoards_codec
            = FieldCodec.ForMessage(10, Types.CircuitBoard.Parser);
        private readonly RepeatedField<Types.CircuitBoard> circuitBoards_ = [];

        /// <summary>
        /// Circuit boards present in this device.
        /// </summary>
        public RepeatedField<Types.CircuitBoard> CircuitBoards
        {
            get { return circuitBoards_; }
        }

        public override bool Equals(object other) => Equals(other as DeviceMetadata);
        public bool Equals(DeviceMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!circuitBoards_.Equals(other.circuitBoards_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= circuitBoards_.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      circuitBoards_.WriteTo(output, _repeated_circuitBoards_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            circuitBoards_.WriteTo(ref output, _repeated_circuitBoards_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += circuitBoards_.CalculateSize(_repeated_circuitBoards_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeviceMetadata other)
        {
            if (other == null)
            {
                return;
            }
            circuitBoards_.Add(other.circuitBoards_);
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
            circuitBoards_.AddEntriesFrom(input, _repeated_circuitBoards_codec);
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
                            circuitBoards_.AddEntriesFrom(ref input, _repeated_circuitBoards_codec);
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the DeviceMetadata message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// Metadata of a circuit board present on a device.
            /// </summary>
            public sealed partial class CircuitBoard : IMessage<CircuitBoard>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<CircuitBoard> _parser = new(() => new CircuitBoard());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<CircuitBoard> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return DeviceMetadata.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public CircuitBoard()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public CircuitBoard(CircuitBoard other) : this()
                {
                    manufactureDate_ = other.manufactureDate_?.Clone();
                    serialNumber_ = other.serialNumber_;
                    firmwares_ = other.firmwares_.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public CircuitBoard Clone() => new(this);
                /// <summary>Field number for the "manufacture_date" field.</summary>
                public const int ManufactureDateFieldNumber = 2;
                private Saltoapis.Type.Date manufactureDate_;

                /// <summary>
                /// Date manufactured
                /// </summary>
                public Saltoapis.Type.Date ManufactureDate
                {
                    get { return manufactureDate_; }
                    set
                    {
                        manufactureDate_ = value;
                    }
                }

                /// <summary>Field number for the "serial_number" field.</summary>
                public const int SerialNumberFieldNumber = 3;
                private string serialNumber_ = "";

                /// <summary>
                /// Hardware serial number, for example, `2.000.0020`
                /// </summary>
                public string SerialNumber
                {
                    get { return serialNumber_; }
                    set
                    {
                        serialNumber_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "firmwares" field.</summary>
                public const int FirmwaresFieldNumber = 4;
                private static readonly FieldCodec<Types.Firmware> _repeated_firmwares_codec
                    = FieldCodec.ForMessage(34, Types.Firmware.Parser);
                private readonly RepeatedField<Types.Firmware> firmwares_ = [];

                /// <summary>
                /// Firmwares present in this circuit board.
                /// </summary>
                public RepeatedField<Types.Firmware> Firmwares
                {
                    get { return firmwares_; }
                }

                public override bool Equals(object other) => Equals(other as CircuitBoard);
                public bool Equals(CircuitBoard other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (!Equals(ManufactureDate, other.ManufactureDate)) return false;
                    if (SerialNumber != other.SerialNumber) return false;
                    if (!firmwares_.Equals(other.firmwares_)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (manufactureDate_ != null) hash ^= ManufactureDate.GetHashCode();
                    if (SerialNumber.Length != 0) hash ^= SerialNumber.GetHashCode();
                    hash ^= firmwares_.GetHashCode();
                    if (_unknownFields != null)
                    {
                        hash ^= _unknownFields.GetHashCode();
                    }
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (manufactureDate_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(ManufactureDate);
          }
          if (SerialNumber.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(SerialNumber);
          }
          firmwares_.WriteTo(output, _repeated_firmwares_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (manufactureDate_ != null)
                    {
                        output.WriteRawTag(18);
                        output.WriteMessage(ManufactureDate);
                    }
                    if (SerialNumber.Length != 0)
                    {
                        output.WriteRawTag(26);
                        output.WriteString(SerialNumber);
                    }
                    firmwares_.WriteTo(ref output, _repeated_firmwares_codec);
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (manufactureDate_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(ManufactureDate);
                    }
                    if (SerialNumber.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(SerialNumber);
                    }
                    size += firmwares_.CalculateSize(_repeated_firmwares_codec);
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(CircuitBoard other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.manufactureDate_ != null)
                    {
                        if (manufactureDate_ == null)
                        {
                            ManufactureDate = new Saltoapis.Type.Date();
                        }
                        ManufactureDate.MergeFrom(other.ManufactureDate);
                    }
                    if (other.SerialNumber.Length != 0)
                    {
                        SerialNumber = other.SerialNumber;
                    }
                    firmwares_.Add(other.firmwares_);
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
              case 18: {
                if (manufactureDate_ == null) {
                  ManufactureDate = new Saltoapis.Type.Date();
                }
                input.ReadMessage(ManufactureDate);
                break;
              }
              case 26: {
                SerialNumber = input.ReadString();
                break;
              }
              case 34: {
                firmwares_.AddEntriesFrom(input, _repeated_firmwares_codec);
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
                            case 18:
                                {
                                    if (manufactureDate_ == null)
                                    {
                                        ManufactureDate = new Saltoapis.Type.Date();
                                    }
                                    input.ReadMessage(ManufactureDate);
                                    break;
                                }
                            case 26:
                                {
                                    SerialNumber = input.ReadString();
                                    break;
                                }
                            case 34:
                                {
                                    firmwares_.AddEntriesFrom(ref input, _repeated_firmwares_codec);
                                    break;
                                }
                        }
                    }
                }
#endif

                #region Nested types
                /// <summary>Container for nested types declared in the CircuitBoard message type.</summary>
                public static partial class Types
                {
                    /// <summary>
                    /// Firmware contains the firmware number and version.
                    /// </summary>
                    public sealed partial class Firmware : IMessage<Firmware>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                        , IBufferMessage
#endif
                    {
                        private static readonly MessageParser<Firmware> _parser = new(() => new Firmware());
                        private UnknownFieldSet _unknownFields;

                        public static MessageParser<Firmware> Parser { get { return _parser; } }

                        public static MessageDescriptor Descriptor
                        {
                            get { return CircuitBoard.Descriptor.NestedTypes[0]; }
                        }

                        MessageDescriptor IMessage.Descriptor
                        {
                            get { return Descriptor; }
                        }

                        public Firmware()
                        {
                            OnConstruction();
                        }

                        partial void OnConstruction();

                        public Firmware(Firmware other) : this()
                        {
                            number_ = other.number_;
                            version_ = other.version_;
                            revision_ = other.revision_;
                            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                        }

                        public Firmware Clone() => new(this);
                        /// <summary>Field number for the "number" field.</summary>
                        public const int NumberFieldNumber = 1;
                        private string number_ = "";

                        /// <summary>
                        /// Firmware number, for example '0180'.
                        /// </summary>
                        public string Number
                        {
                            get { return number_; }
                            set
                            {
                                number_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "version" field.</summary>
                        public const int VersionFieldNumber = 2;
                        private string version_ = "";

                        /// <summary>
                        /// Firmware version of a specific firmware number.
                        /// </summary>
                        public string Version
                        {
                            get { return version_; }
                            set
                            {
                                version_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "revision" field.</summary>
                        public const int RevisionFieldNumber = 3;
                        private string revision_ = "";

                        /// <summary>
                        /// Firmware revision of a specific firmware number and version.
                        /// </summary>
                        public string Revision
                        {
                            get { return revision_; }
                            set
                            {
                                revision_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        public override bool Equals(object other) => Equals(other as Firmware);
                        public bool Equals(Firmware other)
                        {
                            if (other is null)
                            {
                                return false;
                            }
                            if (ReferenceEquals(other, this))
                            {
                                return true;
                            }
                            if (Number != other.Number) return false;
                            if (Version != other.Version) return false;
                            if (Revision != other.Revision) return false;
                            return Equals(_unknownFields, other._unknownFields);
                        }

                        public override int GetHashCode()
                        {
                            int hash = 1;
                            if (Number.Length != 0) hash ^= Number.GetHashCode();
                            if (Version.Length != 0) hash ^= Version.GetHashCode();
                            if (Revision.Length != 0) hash ^= Revision.GetHashCode();
                            if (_unknownFields != null)
                            {
                                hash ^= _unknownFields.GetHashCode();
                            }
                            return hash;
                        }

                        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                        public void WriteTo(CodedOutputStream output)
                        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                            output.WriteRawMessage(this);
#else
              if (Number.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Number);
              }
              if (Version.Length != 0) {
                output.WriteRawTag(18);
                output.WriteString(Version);
              }
              if (Revision.Length != 0) {
                output.WriteRawTag(26);
                output.WriteString(Revision);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
#endif
                        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                        void IBufferMessage.InternalWriteTo(ref WriteContext output)
                        {
                            if (Number.Length != 0)
                            {
                                output.WriteRawTag(10);
                                output.WriteString(Number);
                            }
                            if (Version.Length != 0)
                            {
                                output.WriteRawTag(18);
                                output.WriteString(Version);
                            }
                            if (Revision.Length != 0)
                            {
                                output.WriteRawTag(26);
                                output.WriteString(Revision);
                            }
                            _unknownFields?.WriteTo(ref output);
                        }
#endif

                        public int CalculateSize()
                        {
                            int size = 0;
                            if (Number.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(Number);
                            }
                            if (Version.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(Version);
                            }
                            if (Revision.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(Revision);
                            }
                            if (_unknownFields != null)
                            {
                                size += _unknownFields.CalculateSize();
                            }
                            return size;
                        }

                        public void MergeFrom(Firmware other)
                        {
                            if (other == null)
                            {
                                return;
                            }
                            if (other.Number.Length != 0)
                            {
                                Number = other.Number;
                            }
                            if (other.Version.Length != 0)
                            {
                                Version = other.Version;
                            }
                            if (other.Revision.Length != 0)
                            {
                                Revision = other.Revision;
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
                    Number = input.ReadString();
                    break;
                  }
                  case 18: {
                    Version = input.ReadString();
                    break;
                  }
                  case 26: {
                    Revision = input.ReadString();
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
                                            Number = input.ReadString();
                                            break;
                                        }
                                    case 18:
                                        {
                                            Version = input.ReadString();
                                            break;
                                        }
                                    case 26:
                                        {
                                            Revision = input.ReadString();
                                            break;
                                        }
                                }
                            }
                        }
#endif

                    }

                }
                #endregion

            }

        }
        #endregion

    }

    #endregion

}
