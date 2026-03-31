namespace Saltoapis.Nebula.Controller.V1
{
    /// <summary>
    /// Relay represents a configurable output from a controller that can be used to control
    /// external devices such as doors or other electrical systems. Relays can be
    /// located on the main controller board or on extension boards, with addressing
    /// determined by dipswitch settings.
    /// </summary>
    public sealed partial class ControllerRelay : IMessage<ControllerRelay>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ControllerRelay> _parser = new(() => new ControllerRelay());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<ControllerRelay> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ControllerReflection.Descriptor.MessageTypes[1];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ControllerRelay()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ControllerRelay(ControllerRelay other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            dipSwitch_ = other.dipSwitch_;
            relayId_ = other.relayId_;
            switch (other.TypeCase)
            {
                case TypeOneofCase.DestinationOutput:
                    DestinationOutput = other.DestinationOutput.Clone();
                    break;
                case TypeOneofCase.Strike:
                    Strike = other.Strike.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ControllerRelay Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Output only. Resource name of the controller relay. It must have the format of
        /// `installations/*/controllers/*/relays/*`. For example:
        /// `installations/surelock-homes-hq/controller/dancing-men/relays/first-floor`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "dip_switch" field.</summary>
        public const int DipSwitchFieldNumber = 2;
        private static readonly int DipSwitchDefaultValue = 0;

        private int dipSwitch_;
        /// <summary>
        /// Extension board address. Values range from 0-15, allowing for up to 16 boards in the system.
        /// This field is not applicable for master boards or wall reader extension boards.
        /// </summary>
        public int DipSwitch
        {
            get { if ((_hasBits0 & 1) != 0) { return dipSwitch_; } else { return DipSwitchDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                dipSwitch_ = value;
            }
        }
        /// <summary>Gets whether the "dip_switch" field is set</summary>
        public bool HasDipSwitch => (_hasBits0 & 1) != 0;
        /// <summary>Clears the value of the "dip_switch" field</summary>
        public void ClearDipSwitch()
        {
            _hasBits0 &= ~1;
        }
        /// <summary>Field number for the "relay_id" field.</summary>
        public const int RelayIdFieldNumber = 3;
        private int relayId_;
        /// <summary>
        /// Identifies the specific controller relay on the board (1-4). Board type determines
        /// which controller relay IDs are actually available for configuration and use.
        /// </summary>
        public int RelayId
        {
            get => relayId_; set => relayId_ = value;}
        /// <summary>Field number for the "destination_output" field.</summary>
        public const int DestinationOutputFieldNumber = 4;
        /// <summary>
        /// Destination output configuration for this controller relay.
        /// </summary>
        public Types.DestinationOutput DestinationOutput
        {
            get { return typeCase_ == TypeOneofCase.DestinationOutput ? (Types.DestinationOutput)type_ : null; }
            set
            {
                type_ = value;
                typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.DestinationOutput;
            }
        }
        /// <summary>Field number for the "strike" field.</summary>
        public const int StrikeFieldNumber = 5;
        /// <summary>
        /// Strike configuration for this controller relay.
        /// </summary>
        public Types.Strike Strike
        {
            get { return typeCase_ == TypeOneofCase.Strike ? (Types.Strike)type_ : null; }
            set
            {
                type_ = value;
                typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Strike;
            }
        }

        private object type_;
        /// <summary>Enum of possible cases for the "type" oneof.</summary>
        public enum TypeOneofCase
        {
            None = 0,
            DestinationOutput = 4,
            Strike = 5,
        }

        private TypeOneofCase typeCase_ = TypeOneofCase.None;

        public TypeOneofCase TypeCase
        {
            get => typeCase_;}

        public void ClearType()
        {
            typeCase_ = TypeOneofCase.None;
            type_ = null;
        }

        public override bool Equals(object other) => Equals(other as ControllerRelay);
        public bool Equals(ControllerRelay other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DipSwitch != other.DipSwitch) || (RelayId != other.RelayId) || (!Equals(DestinationOutput, other.DestinationOutput)) || (!Equals(Strike, other.Strike)) || (TypeCase != other.TypeCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasDipSwitch) hash ^= DipSwitch.GetHashCode();
            if (RelayId != 0) hash ^= RelayId.GetHashCode();
            if (typeCase_ == TypeOneofCase.DestinationOutput) hash ^= DestinationOutput.GetHashCode();
            if (typeCase_ == TypeOneofCase.Strike) hash ^= Strike.GetHashCode();
            hash ^= (int)typeCase_;
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
      if (HasDipSwitch)
      {
        output.WriteRawTag(16);
        output.WriteInt32(DipSwitch);
      }
      if (RelayId != 0)
      {
        output.WriteRawTag(24);
        output.WriteInt32(RelayId);
      }
      if (typeCase_ == TypeOneofCase.DestinationOutput)
      {
        output.WriteRawTag(34);
        output.WriteMessage(DestinationOutput);
      }
      if (typeCase_ == TypeOneofCase.Strike)
      {
        output.WriteRawTag(42);
        output.WriteMessage(Strike);
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
            if (HasDipSwitch)
            {
                output.WriteRawTag(16);
                output.WriteInt32(DipSwitch);
            }
            if (RelayId != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(RelayId);
            }
            if (typeCase_ == TypeOneofCase.DestinationOutput)
            {
                output.WriteRawTag(34);
                output.WriteMessage(DestinationOutput);
            }
            if (typeCase_ == TypeOneofCase.Strike)
            {
                output.WriteRawTag(42);
                output.WriteMessage(Strike);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (HasDipSwitch) size += 1 + CodedOutputStream.ComputeInt32Size(DipSwitch);
            if (RelayId != 0) size += 1 + CodedOutputStream.ComputeInt32Size(RelayId);
            if (typeCase_ == TypeOneofCase.DestinationOutput) size += 1 + CodedOutputStream.ComputeMessageSize(DestinationOutput);
            if (typeCase_ == TypeOneofCase.Strike) size += 1 + CodedOutputStream.ComputeMessageSize(Strike);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ControllerRelay other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.HasDipSwitch) DipSwitch = other.DipSwitch;
            if (other.RelayId != 0) RelayId = other.RelayId;
            switch (other.TypeCase)
            {
                case TypeOneofCase.DestinationOutput:
                    DestinationOutput ??= new Types.DestinationOutput();
                    DestinationOutput.MergeFrom(other.DestinationOutput);
                    break;
                case TypeOneofCase.Strike:
                    Strike ??= new Types.Strike();
                    Strike.MergeFrom(other.Strike);
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
          case 16:
          {
            DipSwitch = input.ReadInt32();
            break;
          }
          case 24:
          {
            RelayId = input.ReadInt32();
            break;
          }
          case 34:
          {
            Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.DestinationOutput subBuilder = new Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.DestinationOutput();
            if (typeCase_ == TypeOneofCase.DestinationOutput)
            {
              subBuilder.MergeFrom(DestinationOutput);
            }
            input.ReadMessage(subBuilder);
            DestinationOutput = subBuilder;
            break;
          }
          case 42:
          {
            Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.Strike subBuilder = new Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.Strike();
            if (typeCase_ == TypeOneofCase.Strike)
            {
              subBuilder.MergeFrom(Strike);
            }
            input.ReadMessage(subBuilder);
            Strike = subBuilder;
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
                    case 16:
                        {
                            DipSwitch = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            RelayId = input.ReadInt32();
                            break;
                        }
                    case 34:
                        {
                            Types.DestinationOutput subBuilder = new();
                            if (typeCase_ == TypeOneofCase.DestinationOutput) subBuilder.MergeFrom(DestinationOutput);
                            input.ReadMessage(subBuilder);
                            DestinationOutput = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            Types.Strike subBuilder = new();
                            if (typeCase_ == TypeOneofCase.Strike) subBuilder.MergeFrom(Strike);
                            input.ReadMessage(subBuilder);
                            Strike = subBuilder;
                            break;
                        }
                }
            }
        }
#endif
        /// <summary>Container for nested types declared in the ControllerRelay message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// DestinationOutput contains configuration information that identifies a specific
            /// destination resource and a specific output.
            ///
            /// This message maps a controller relay to a logical destination (like an elevator floor)
            /// and specifies which output activation value on the credential will trigger this controller relay.
            /// When used within a Relay's "type" oneof field, it configures the controller relay to activate
            /// when a credential with matching output permissions is presented at a reader connected
            /// to the controller.
            ///
            /// For example, in an elevator control scenario, each controller relay might control a different
            /// floor button, with the "output" field (0-255) corresponding to a specific permission
            /// bit in the credential's access rights.
            /// </summary>
            public sealed partial class DestinationOutput : IMessage<DestinationOutput>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<DestinationOutput> _parser = new(() => new DestinationOutput());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<DestinationOutput> Parser { get => _parser;}

                public static MessageDescriptor Descriptor
                {
                    get => ControllerRelay.Descriptor.NestedTypes[0];}

                MessageDescriptor IMessage.Descriptor
                {
                    get => Descriptor;}

                public DestinationOutput()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public DestinationOutput(DestinationOutput other) : this()
                {
                    destination_ = other.destination_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public DestinationOutput Clone() => new(this);
                /// <summary>Field number for the "destination" field.</summary>
                public const int DestinationFieldNumber = 1;
                private string destination_ = "";
                /// <summary>
                /// Resource name of the destination the controller relay points to.
                /// For example: installations/surelock-homes-hq/destinations/elevator-floor-5.
                /// </summary>
                public string Destination
                {
                    get => destination_; set => destination_ = ProtoPreconditions.CheckNotNull(value, "value");}

                public override bool Equals(object other) => Equals(other as DestinationOutput);
                public bool Equals(DestinationOutput other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
return Destination != other.Destination ? false : Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Destination.Length != 0) hash ^= Destination.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (Destination.Length != 0)
          {
            output.WriteRawTag(10);
            output.WriteString(Destination);
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
                    if (Destination.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(Destination);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Destination.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Destination);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(DestinationOutput other)
                {
                    if (other == null) return;
                    if (other.Destination.Length != 0) Destination = other.Destination;
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
                Destination = input.ReadString();
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
                                    Destination = input.ReadString();
                                    break;
                                }
                        }
                    }
                }
#endif
            }
            /// <summary>
            /// Strike contains configuration information that identifies a specific
            /// access point resource.
            /// </summary>
            public sealed partial class Strike : IMessage<Strike>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<Strike> _parser = new(() => new Strike());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<Strike> Parser { get => _parser;}

                public static MessageDescriptor Descriptor
                {
                    get => ControllerRelay.Descriptor.NestedTypes[1];}

                MessageDescriptor IMessage.Descriptor
                {
                    get => Descriptor;}

                public Strike()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public Strike(Strike other) : this()
                {
                    accessPoint_ = other.accessPoint_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Strike Clone() => new(this);
                /// <summary>Field number for the "access_point" field.</summary>
                public const int AccessPointFieldNumber = 1;
                private string accessPoint_ = "";
                /// <summary>
                /// Resource name of the access point the controller relay points to.
                /// For example: `installations/surelock-homes-hq/access-points/baker-street-entrance`.
                /// </summary>
                public string AccessPoint
                {
                    get => accessPoint_; set => accessPoint_ = ProtoPreconditions.CheckNotNull(value, "value");}

                public override bool Equals(object other) => Equals(other as Strike);
                public bool Equals(Strike other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
return AccessPoint != other.AccessPoint ? false : Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (AccessPoint.Length != 0)
          {
            output.WriteRawTag(10);
            output.WriteString(AccessPoint);
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
                    if (AccessPoint.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(AccessPoint);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (AccessPoint.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccessPoint);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(Strike other)
                {
                    if (other == null) return;
                    if (other.AccessPoint.Length != 0) AccessPoint = other.AccessPoint;
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
                AccessPoint = input.ReadString();
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
                                    AccessPoint = input.ReadString();
                                    break;
                                }
                        }
                    }
                }
#endif
            }
        }
    }

}