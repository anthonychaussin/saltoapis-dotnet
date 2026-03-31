namespace Saltoapis.Nebula.Unit.V1
{
    /// <summary>
    /// Representation of a unit resource inside the API
    /// </summary>
    public sealed partial class Unit : IMessage<Unit>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Unit> _parser = new(() => new Unit());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Unit> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Unit()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Unit(Unit other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            moveInTime_ = other.moveInTime_?.Clone();
            moveOutTime_ = other.moveOutTime_?.Clone();
            privacySettings_ = other.privacySettings_?.Clone();
            defaultAccessRights_ = other.defaultAccessRights_.Clone();
            manager_ = other.manager_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Unit Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the unit. It must have the format
        /// `installations/*/units/*`, for example:
        /// `installations/surelock-homes-hq/units/101`.
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
        /// Display name.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "move_in_time" field.</summary>
        public const int MoveInTimeFieldNumber = 3;
        private Google.Protobuf.WellKnownTypes.Timestamp moveInTime_;

        /// <summary>
        /// Time the unit was moved in.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp MoveInTime
        {
            get { return moveInTime_; }
            set
            {
                moveInTime_ = value;
            }
        }

        /// <summary>Field number for the "move_out_time" field.</summary>
        public const int MoveOutTimeFieldNumber = 4;
        private Google.Protobuf.WellKnownTypes.Timestamp moveOutTime_;

        /// <summary>
        /// Time the unit was moved out.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp MoveOutTime
        {
            get { return moveOutTime_; }
            set
            {
                moveOutTime_ = value;
            }
        }

        /// <summary>Field number for the "privacy_settings" field.</summary>
        public const int PrivacySettingsFieldNumber = 5;
        private Types.PrivacySettings privacySettings_;

        /// <summary>
        /// The privacy settings of the unit. Can either be enabled or disabled.
        /// If enabled, owners and installation managers can see neither events
        /// nor users that belong to the unit.
        /// </summary>
        public Types.PrivacySettings PrivacySettings
        {
            get { return privacySettings_; }
            set
            {
                privacySettings_ = value;
            }
        }

        /// <summary>Field number for the "default_access_rights" field.</summary>
        public const int DefaultAccessRightsFieldNumber = 6;
        private static readonly FieldCodec<string> _repeated_defaultAccessRights_codec
            = FieldCodec.ForString(50);
        private readonly RepeatedField<string> defaultAccessRights_ = [];

        /// <summary>
        /// The resource names of the default access rights to be associated within this unit.
        /// For example: installations/surelock-homes-hq/access-rights/baskerville.
        /// A maximum of 5 access rights can be specified.
        /// </summary>
        public RepeatedField<string> DefaultAccessRights
        {
            get { return defaultAccessRights_; }
        }

        /// <summary>Field number for the "manager" field.</summary>
        public const int ManagerFieldNumber = 7;
        private static readonly string ManagerDefaultValue = "";

        private string manager_;

        /// <summary>
        /// The resource name of the manager resource that currently controls this
        /// unit. A manager resource is any resource (such as a booking) that creates
        /// and governs the lifecycle of this unit.
        ///
        /// Example: "installations/surelock-homes-hq/bookings/watson-family-booking"
        ///
        /// If set, this unit is considered "managed" and cannot be modified directly.
        /// It behaves as a side-effect of the manager resource. For example, a unit
        /// may become managed when a booking is checked in, and unmanaged when the
        /// booking is checked out.
        /// </summary>
        public string Manager
        {
            get { return manager_ ?? ManagerDefaultValue; }
            set
            {
                manager_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "manager" field is set</summary>
        public bool HasManager
        {
            get { return manager_ != null; }
        }

        /// <summary>Clears the value of the "manager" field</summary>
        public void ClearManager()
        {
            manager_ = null;
        }

        public override bool Equals(object other) => Equals(other as Unit);
        public bool Equals(Unit other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName)) return false;
            if ((!Equals(MoveInTime, other.MoveInTime)) || (!Equals(MoveOutTime, other.MoveOutTime))) return false;
            if ((!Equals(PrivacySettings, other.PrivacySettings)) || (!defaultAccessRights_.Equals(other.defaultAccessRights_))) return false;
            if (Manager != other.Manager) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (moveInTime_ != null) hash ^= MoveInTime.GetHashCode();
            if (moveOutTime_ != null) hash ^= MoveOutTime.GetHashCode();
            if (privacySettings_ != null) hash ^= PrivacySettings.GetHashCode();
            hash ^= defaultAccessRights_.GetHashCode();
            if (HasManager) hash ^= Manager.GetHashCode();
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
      if (moveInTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MoveInTime);
      }
      if (moveOutTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MoveOutTime);
      }
      if (privacySettings_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PrivacySettings);
      }
      defaultAccessRights_.WriteTo(output, _repeated_defaultAccessRights_codec);
      if (HasManager) {
        output.WriteRawTag(58);
        output.WriteString(Manager);
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
            if (moveInTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(MoveInTime);
            }
            if (moveOutTime_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(MoveOutTime);
            }
            if (privacySettings_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(PrivacySettings);
            }
            defaultAccessRights_.WriteTo(ref output, _repeated_defaultAccessRights_codec);
            if (HasManager)
            {
                output.WriteRawTag(58);
                output.WriteString(Manager);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (moveInTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(MoveInTime);
            if (moveOutTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(MoveOutTime);
            if (privacySettings_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PrivacySettings);
            size += defaultAccessRights_.CalculateSize(_repeated_defaultAccessRights_codec);
            if (HasManager) size += 1 + CodedOutputStream.ComputeStringSize(Manager);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Unit other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.moveInTime_ != null)
            {
                if (moveInTime_ == null) MoveInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                MoveInTime.MergeFrom(other.MoveInTime);
            }
            if (other.moveOutTime_ != null)
            {
                if (moveOutTime_ == null) MoveOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                MoveOutTime.MergeFrom(other.MoveOutTime);
            }
            if (other.privacySettings_ != null)
            {
                if (privacySettings_ == null) PrivacySettings = new Types.PrivacySettings();
                PrivacySettings.MergeFrom(other.PrivacySettings);
            }
            defaultAccessRights_.Add(other.defaultAccessRights_);
            if (other.HasManager) Manager = other.Manager;
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
            if (moveInTime_ == null) {
              MoveInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MoveInTime);
            break;
          }
          case 34: {
            if (moveOutTime_ == null) {
              MoveOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(MoveOutTime);
            break;
          }
          case 42: {
            if (privacySettings_ == null) {
              PrivacySettings = new Saltoapis.Nebula.Unit.V1.Unit.Types.PrivacySettings();
            }
            input.ReadMessage(PrivacySettings);
            break;
          }
          case 50: {
            defaultAccessRights_.AddEntriesFrom(input, _repeated_defaultAccessRights_codec);
            break;
          }
          case 58: {
            Manager = input.ReadString();
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
                            if (moveInTime_ == null) MoveInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(MoveInTime);
                            break;
                        }
                    case 34:
                        {
                            if (moveOutTime_ == null) MoveOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(MoveOutTime);
                            break;
                        }
                    case 42:
                        {
                            if (privacySettings_ == null) PrivacySettings = new Types.PrivacySettings();
                            input.ReadMessage(PrivacySettings);
                            break;
                        }
                    case 50:
                        {
                            defaultAccessRights_.AddEntriesFrom(ref input, _repeated_defaultAccessRights_codec);
                            break;
                        }
                    case 58:
                        {
                            Manager = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the Unit message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// The privacy settings object.
            /// </summary>
            public sealed partial class PrivacySettings : IMessage<PrivacySettings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<PrivacySettings> _parser = new(() => new PrivacySettings());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<PrivacySettings> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Unit.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public PrivacySettings()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public PrivacySettings(PrivacySettings other) : this()
                {
                    enabled_ = other.enabled_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public PrivacySettings Clone() => new(this);
                /// <summary>Field number for the "enabled" field.</summary>
                public const int EnabledFieldNumber = 1;
                private bool enabled_;

                /// <summary>
                /// The privacy status of the unit.
                /// </summary>
                public bool Enabled
                {
                    get { return enabled_; }
                    set
                    {
                        enabled_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as PrivacySettings);
                public bool Equals(PrivacySettings other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if (Enabled != other.Enabled) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Enabled != false) hash ^= Enabled.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (Enabled != false) {
            output.WriteRawTag(8);
            output.WriteBool(Enabled);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (Enabled != false)
                    {
                        output.WriteRawTag(8);
                        output.WriteBool(Enabled);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Enabled != false) size += 1 + 1;
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(PrivacySettings other)
                {
                    if (other == null) return;
                    if (other.Enabled != false) Enabled = other.Enabled;
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
              case 8: {
                Enabled = input.ReadBool();
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
                            case 8:
                                {
                                    Enabled = input.ReadBool();
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
