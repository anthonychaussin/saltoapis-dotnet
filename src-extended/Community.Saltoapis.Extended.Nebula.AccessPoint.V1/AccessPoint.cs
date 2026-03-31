namespace Saltoapis.Nebula.AccessPoint.V1
{
    /// <summary>
    /// The access point object
    /// </summary>
    public sealed partial class AccessPoint : IMessage<AccessPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPoint> _parser = new(() => new AccessPoint());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<AccessPoint> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessPointReflection.Descriptor.MessageTypes[0];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public AccessPoint()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPoint(AccessPoint other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            displayName_ = other.displayName_;
            calendar_ = other.calendar_;
            cardKeyUpdater_ = other.cardKeyUpdater_;
            unlockDuration_ = other.unlockDuration_?.Clone();
            leftOpen_ = other.leftOpen_;
            switch (other.OpeningModeCase)
            {
                case OpeningModeOneofCase.Fixed:
                    Fixed = other.Fixed;
                    break;
                case OpeningModeOneofCase.Schedule:
                    Schedule = other.Schedule;
                    break;
            }

            switch (other.SourceCase)
            {
                case SourceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case SourceOneofCase.Controller:
                    Controller = other.Controller;
                    break;
                case SourceOneofCase.IntercomAdaptor:
                    IntercomAdaptor = other.IntercomAdaptor;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPoint Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        ///  Resource name of the access point. It must have the format
        /// `installations/*/access-points/*`. For example:
        /// `installations/surelock-homes-hq/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";
        /// <summary>
        /// Display name of the access point.
        /// </summary>
        public string DisplayName
        {
            get => displayName_; set => displayName_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "fixed" field.</summary>
        public const int FixedFieldNumber = 3;
        /// <summary>
        /// The opening mode to be used permanently.
        /// </summary>
        public Type.OpeningMode Fixed
        {
            get { return HasFixed ? (Type.OpeningMode)openingMode_ : Type.OpeningMode.Unspecified; }
            set
            {
                openingMode_ = value;
                openingModeCase_ = OpeningModeOneofCase.Fixed;
            }
        }
        /// <summary>Gets whether the "fixed" field is set</summary>
        public bool HasFixed => openingModeCase_ == OpeningModeOneofCase.Fixed;
        /// <summary> Clears the value of the oneof if it's currently set to "fixed" </summary>
        public void ClearFixed()
        {
            if (HasFixed) ClearOpeningMode();
        }
        /// <summary>Field number for the "schedule" field.</summary>
        public const int ScheduleFieldNumber = 4;
        /// <summary>
        /// Reference to an opening mode schedule
        /// </summary>
        public string Schedule
        {
            get { return HasSchedule ? (string)openingMode_ : ""; }
            set
            {
                openingMode_ = ProtoPreconditions.CheckNotNull(value, "value");
                openingModeCase_ = OpeningModeOneofCase.Schedule;
            }
        }
        /// <summary>Gets whether the "schedule" field is set</summary>
        public bool HasSchedule => openingModeCase_ == OpeningModeOneofCase.Schedule;
        /// <summary> Clears the value of the oneof if it's currently set to "schedule" </summary>
        public void ClearSchedule()
        {
            if (HasSchedule) ClearOpeningMode();
        }
        /// <summary>Field number for the "calendar" field.</summary>
        public const int CalendarFieldNumber = 5;
        private static readonly string CalendarDefaultValue = "";

        private string calendar_;
        /// <summary>
        /// Calendar reference assigned to this access point.
        /// If not set, a calendar where all days are NORMAL will be used.
        /// That's to say a regular calendar that doesn't have any
        /// HOLIDAY or OTHER days added to it.
        /// </summary>
        public string Calendar
        {
            get => calendar_ ?? CalendarDefaultValue; set => calendar_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "calendar" field is set</summary>
        public bool HasCalendar => calendar_ != null;
        /// <summary>Clears the value of the "calendar" field</summary>
        public void ClearCalendar() => calendar_ = null;
        /// <summary>Field number for the "card_key_updater" field.</summary>
        public const int CardKeyUpdaterFieldNumber = 6;
        private static readonly bool CardKeyUpdaterDefaultValue = false;

        private bool cardKeyUpdater_;
        /// <summary>
        /// Enables or disables card key updates. This parameter doesn't have any
        /// effect on access points where its associated device is offline.
        /// This field is optional to maintain backward compatibility. The server
        /// checks for its presence to determine if clients are not updated and
        /// assigns a default value if it's missing.
        /// </summary>
        public bool CardKeyUpdater
        {
            get { if ((_hasBits0 & 1) != 0) { return cardKeyUpdater_; } else { return CardKeyUpdaterDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                cardKeyUpdater_ = value;
            }
        }
        /// <summary>Gets whether the "card_key_updater" field is set</summary>
        public bool HasCardKeyUpdater => (_hasBits0 & 1) != 0;
        /// <summary>Clears the value of the "card_key_updater" field</summary>
        public void ClearCardKeyUpdater()
        {
            _hasBits0 &= ~1;
        }
        /// <summary>Field number for the "unlock_duration" field.</summary>
        public const int UnlockDurationFieldNumber = 7;
        private Google.Protobuf.WellKnownTypes.Duration unlockDuration_;
        /// <summary>
        /// The duration the access point remains unlocked. This field is optional
        /// for the server to check for its presence and assign a default value if it's missing.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Duration UnlockDuration
        {
            get => unlockDuration_; set => unlockDuration_ = value;}
        /// <summary>Field number for the "left_open" field.</summary>
        public const int LeftOpenFieldNumber = 8;
        private bool leftOpen_;
        /// <summary>
        /// Indicates whether the access point was left open.
        /// </summary>
        public bool LeftOpen
        {
            get => leftOpen_; set => leftOpen_ = value;}
        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 9;
        /// <summary>
        /// Source name, when source is an electronic lock.
        /// </summary>
        public string ElectronicLock
        {
            get { return HasElectronicLock ? (string)source_ : ""; }
            set
            {
                source_ = ProtoPreconditions.CheckNotNull(value, "value");
                sourceCase_ = SourceOneofCase.ElectronicLock;
            }
        }
        /// <summary>Gets whether the "electronic_lock" field is set</summary>
        public bool HasElectronicLock => sourceCase_ == SourceOneofCase.ElectronicLock;
        /// <summary> Clears the value of the oneof if it's currently set to "electronic_lock" </summary>
        public void ClearElectronicLock()
        {
            if (HasElectronicLock) ClearSource();
        }
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 10;
        /// <summary>
        /// Source name, when source is a controller.
        /// </summary>
        public string Controller
        {
            get { return HasController ? (string)source_ : ""; }
            set
            {
                source_ = ProtoPreconditions.CheckNotNull(value, "value");
                sourceCase_ = SourceOneofCase.Controller;
            }
        }
        /// <summary>Gets whether the "controller" field is set</summary>
        public bool HasController => sourceCase_ == SourceOneofCase.Controller;
        /// <summary> Clears the value of the oneof if it's currently set to "controller" </summary>
        public void ClearController()
        {
            if (HasController) ClearSource();
        }
        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 11;
        /// <summary>
        /// Source name, when source is an intercom adaptor.
        /// </summary>
        public string IntercomAdaptor
        {
            get { return HasIntercomAdaptor ? (string)source_ : ""; }
            set
            {
                source_ = ProtoPreconditions.CheckNotNull(value, "value");
                sourceCase_ = SourceOneofCase.IntercomAdaptor;
            }
        }
        /// <summary>Gets whether the "intercom_adaptor" field is set</summary>
        public bool HasIntercomAdaptor => sourceCase_ == SourceOneofCase.IntercomAdaptor;
        /// <summary> Clears the value of the oneof if it's currently set to "intercom_adaptor" </summary>
        public void ClearIntercomAdaptor()
        {
            if (HasIntercomAdaptor) ClearSource();
        }

        private object openingMode_;
        /// <summary>Enum of possible cases for the "opening_mode" oneof.</summary>
        public enum OpeningModeOneofCase
        {
            None = 0,
            Fixed = 3,
            Schedule = 4,
        }

        private OpeningModeOneofCase openingModeCase_ = OpeningModeOneofCase.None;

        public OpeningModeOneofCase OpeningModeCase
        {
            get => openingModeCase_;}

        public void ClearOpeningMode()
        {
            openingModeCase_ = OpeningModeOneofCase.None;
            openingMode_ = null;
        }

        private object source_;
        /// <summary>Enum of possible cases for the "source" oneof.</summary>
        public enum SourceOneofCase
        {
            None = 0,
            ElectronicLock = 9,
            Controller = 10,
            IntercomAdaptor = 11,
        }

        private SourceOneofCase sourceCase_ = SourceOneofCase.None;

        public SourceOneofCase SourceCase
        {
            get => sourceCase_;}

        public void ClearSource()
        {
            sourceCase_ = SourceOneofCase.None;
            source_ = null;
        }

        public override bool Equals(object other) => Equals(other as AccessPoint);
        public bool Equals(AccessPoint other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName) || (Fixed != other.Fixed) || (Schedule != other.Schedule) || (Calendar != other.Calendar) || (CardKeyUpdater != other.CardKeyUpdater) || (!Equals(UnlockDuration, other.UnlockDuration)) || (LeftOpen != other.LeftOpen) || (ElectronicLock != other.ElectronicLock) || (Controller != other.Controller) || (IntercomAdaptor != other.IntercomAdaptor) || (OpeningModeCase != other.OpeningModeCase) || SourceCase != other.SourceCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasFixed) hash ^= Fixed.GetHashCode();
            if (HasSchedule) hash ^= Schedule.GetHashCode();
            if (HasCalendar) hash ^= Calendar.GetHashCode();
            if (HasCardKeyUpdater) hash ^= CardKeyUpdater.GetHashCode();
            if (unlockDuration_ != null) hash ^= UnlockDuration.GetHashCode();
            if (LeftOpen != false) hash ^= LeftOpen.GetHashCode();
            if (HasElectronicLock) hash ^= ElectronicLock.GetHashCode();
            if (HasController) hash ^= Controller.GetHashCode();
            if (HasIntercomAdaptor) hash ^= IntercomAdaptor.GetHashCode();
            hash ^= (int)openingModeCase_;
            hash ^= (int)sourceCase_;
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
      if (HasFixed)
      {
        output.WriteRawTag(24);
        output.WriteEnum((int) Fixed);
      }
      if (HasSchedule)
      {
        output.WriteRawTag(34);
        output.WriteString(Schedule);
      }
      if (HasCalendar)
      {
        output.WriteRawTag(42);
        output.WriteString(Calendar);
      }
      if (HasCardKeyUpdater)
      {
        output.WriteRawTag(48);
        output.WriteBool(CardKeyUpdater);
      }
      if (unlockDuration_ != null)
      {
        output.WriteRawTag(58);
        output.WriteMessage(UnlockDuration);
      }
      if (LeftOpen != false)
      {
        output.WriteRawTag(64);
        output.WriteBool(LeftOpen);
      }
      if (HasElectronicLock)
      {
        output.WriteRawTag(74);
        output.WriteString(ElectronicLock);
      }
      if (HasController)
      {
        output.WriteRawTag(82);
        output.WriteString(Controller);
      }
      if (HasIntercomAdaptor)
      {
        output.WriteRawTag(90);
        output.WriteString(IntercomAdaptor);
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
            if (HasFixed)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)Fixed);
            }
            if (HasSchedule)
            {
                output.WriteRawTag(34);
                output.WriteString(Schedule);
            }
            if (HasCalendar)
            {
                output.WriteRawTag(42);
                output.WriteString(Calendar);
            }
            if (HasCardKeyUpdater)
            {
                output.WriteRawTag(48);
                output.WriteBool(CardKeyUpdater);
            }
            if (unlockDuration_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(UnlockDuration);
            }
            if (LeftOpen != false)
            {
                output.WriteRawTag(64);
                output.WriteBool(LeftOpen);
            }
            if (HasElectronicLock)
            {
                output.WriteRawTag(74);
                output.WriteString(ElectronicLock);
            }
            if (HasController)
            {
                output.WriteRawTag(82);
                output.WriteString(Controller);
            }
            if (HasIntercomAdaptor)
            {
                output.WriteRawTag(90);
                output.WriteString(IntercomAdaptor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (HasFixed) size += 1 + CodedOutputStream.ComputeEnumSize((int)Fixed);
            if (HasSchedule) size += 1 + CodedOutputStream.ComputeStringSize(Schedule);
            if (HasCalendar) size += 1 + CodedOutputStream.ComputeStringSize(Calendar);
            if (HasCardKeyUpdater) size += 1 + 1;
            if (unlockDuration_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UnlockDuration);
            if (LeftOpen != false) size += 1 + 1;
            if (HasElectronicLock) size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLock);
            if (HasController) size += 1 + CodedOutputStream.ComputeStringSize(Controller);
            if (HasIntercomAdaptor) size += 1 + CodedOutputStream.ComputeStringSize(IntercomAdaptor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPoint other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasCalendar) Calendar = other.Calendar;
            if (other.HasCardKeyUpdater) CardKeyUpdater = other.CardKeyUpdater;
            if (other.unlockDuration_ != null)
            {
                if (unlockDuration_ == null) UnlockDuration = new Google.Protobuf.WellKnownTypes.Duration();
                UnlockDuration.MergeFrom(other.UnlockDuration);
            }
            if (other.LeftOpen != false) LeftOpen = other.LeftOpen;
            switch (other.OpeningModeCase)
            {
                case OpeningModeOneofCase.Fixed:
                    Fixed = other.Fixed;
                    break;
                case OpeningModeOneofCase.Schedule:
                    Schedule = other.Schedule;
                    break;
            }

            switch (other.SourceCase)
            {
                case SourceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case SourceOneofCase.Controller:
                    Controller = other.Controller;
                    break;
                case SourceOneofCase.IntercomAdaptor:
                    IntercomAdaptor = other.IntercomAdaptor;
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
          case 24:
          {
            openingMode_ = input.ReadEnum();
            openingModeCase_ = OpeningModeOneofCase.Fixed;
            break;
          }
          case 34:
          {
            Schedule = input.ReadString();
            break;
          }
          case 42:
          {
            Calendar = input.ReadString();
            break;
          }
          case 48:
          {
            CardKeyUpdater = input.ReadBool();
            break;
          }
          case 58:
          {
            if (unlockDuration_ == null)
            {
              UnlockDuration = new Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(UnlockDuration);
            break;
          }
          case 64:
          {
            LeftOpen = input.ReadBool();
            break;
          }
          case 74:
          {
            ElectronicLock = input.ReadString();
            break;
          }
          case 82:
          {
            Controller = input.ReadString();
            break;
          }
          case 90:
          {
            IntercomAdaptor = input.ReadString();
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
                            openingMode_ = input.ReadEnum();
                            openingModeCase_ = OpeningModeOneofCase.Fixed;
                            break;
                        }
                    case 34:
                        {
                            Schedule = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            Calendar = input.ReadString();
                            break;
                        }
                    case 48:
                        {
                            CardKeyUpdater = input.ReadBool();
                            break;
                        }
                    case 58:
                        {
                            if (unlockDuration_ == null) UnlockDuration = new Google.Protobuf.WellKnownTypes.Duration();
                            input.ReadMessage(UnlockDuration);
                            break;
                        }
                    case 64:
                        {
                            LeftOpen = input.ReadBool();
                            break;
                        }
                    case 74:
                        {
                            ElectronicLock = input.ReadString();
                            break;
                        }
                    case 82:
                        {
                            Controller = input.ReadString();
                            break;
                        }
                    case 90:
                        {
                            IntercomAdaptor = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }
}