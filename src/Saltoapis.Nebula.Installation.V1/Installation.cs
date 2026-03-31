using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>
    /// The installation object
    /// </summary>
    public sealed partial class Installation : IMessage<Installation>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Installation> _parser = new(() => new Installation());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Installation> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Installation()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Installation(Installation other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            photo_ = other.photo_;
            photoUri_ = other.photoUri_;
            address_ = other.address_;
            timeZone_ = other.timeZone_;
            digitalKeyArt_ = other.digitalKeyArt_?.Clone();
            transferOwnershipState_ = other.transferOwnershipState_?.Clone();
            deleteTime_ = other.deleteTime_?.Clone();
            partnerInfo_ = other.partnerInfo_?.Clone();
            blockTime_ = other.blockTime_?.Clone();
            keyRenewalDuration_ = other.keyRenewalDuration_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Installation Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the installation. It must have the format
        /// of `installations/*`. For example: `installations/surelock-homes-hq`.
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
        /// Display name of the installation.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "photo" field.</summary>
        public const int PhotoFieldNumber = 3;
        private readonly static string PhotoDefaultValue = "";

        private string photo_;

        /// <summary>
        /// The file resource name for the installation photo. It must have the
        /// format of
        /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
        /// </summary>
        public string Photo
        {
            get { return photo_ ?? PhotoDefaultValue; }
            set
            {
                photo_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "photo" field is set</summary>
        public bool HasPhoto
        {
            get { return photo_ != null; }
        }

        /// <summary>Clears the value of the "photo" field</summary>
        public void ClearPhoto()
        {
            photo_ = null;
        }

        /// <summary>Field number for the "photo_uri" field.</summary>
        public const int PhotoUriFieldNumber = 4;
        private string photoUri_ = "";

        /// <summary>
        /// The URI to view the installation photo.
        /// </summary>
        public string PhotoUri
        {
            get { return photoUri_; }
            set
            {
                photoUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "address" field.</summary>
        public const int AddressFieldNumber = 5;
        private string address_ = "";

        /// <summary>
        /// Unstructured address.
        ///
        /// For example: "1600 Amphitheatre Pkwy, Mountain View, CA 94043,
        /// Sunnyvale, California."
        /// </summary>
        public string Address
        {
            get { return address_; }
            set
            {
                address_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "time_zone" field.</summary>
        public const int TimeZoneFieldNumber = 6;
        private string timeZone_ = "";

        /// <summary>
        /// Time zone where the installation is located. It must follow the IANA Time
        /// Zone Database format. For example, "America/New_York."
        /// </summary>
        public string TimeZone
        {
            get { return timeZone_; }
            set
            {
                timeZone_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "digital_key_art" field.</summary>
        public const int DigitalKeyArtFieldNumber = 7;
        private Types.DigitalKeyArt digitalKeyArt_;

        /// <summary>
        /// The digital key art configuration resource that belongs to the installation.
        /// </summary>
        public Types.DigitalKeyArt DigitalKeyArt
        {
            get { return digitalKeyArt_; }
            set
            {
                digitalKeyArt_ = value;
            }
        }

        /// <summary>Field number for the "transfer_ownership_state" field.</summary>
        public const int TransferOwnershipStateFieldNumber = 8;
        private Types.TransferOwnershipState transferOwnershipState_;

        /// <summary>
        /// Current state of the ownership transfer. Client must not set the
        /// `Installation.transfer_ownership_state` field. This data is only
        /// visible to the current installation owner.
        /// </summary>
        public Types.TransferOwnershipState TransferOwnershipState
        {
            get { return transferOwnershipState_; }
            set
            {
                transferOwnershipState_ = value;
            }
        }

        /// <summary>Field number for the "delete_time" field.</summary>
        public const int DeleteTimeFieldNumber = 12;
        private Google.Protobuf.WellKnownTypes.Timestamp deleteTime_;

        /// <summary>
        /// The time when the installation was soft deleted.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp DeleteTime
        {
            get { return deleteTime_; }
            set
            {
                deleteTime_ = value;
            }
        }

        /// <summary>Field number for the "partner_info" field.</summary>
        public const int PartnerInfoFieldNumber = 9;
        private Types.PartnerInfo partnerInfo_;

        /// <summary>
        /// The information of the partner who created the installation.
        /// </summary>
        public Types.PartnerInfo PartnerInfo
        {
            get { return partnerInfo_; }
            set
            {
                partnerInfo_ = value;
            }
        }

        /// <summary>Field number for the "block_time" field.</summary>
        public const int BlockTimeFieldNumber = 11;
        private Google.Protobuf.WellKnownTypes.Timestamp blockTime_;

        /// <summary>
        /// The time when the installation was blocked.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp BlockTime
        {
            get { return blockTime_; }
            set
            {
                blockTime_ = value;
            }
        }

        /// <summary>Field number for the "key_renewal_duration" field.</summary>
        public const int KeyRenewalDurationFieldNumber = 10;
        private Google.Protobuf.WellKnownTypes.Duration keyRenewalDuration_;

        /// <summary>
        /// The length of time a key remains valid before requiring renewal. This
        /// duration defines the effective lifespan of a key, after which it must be
        /// updated to maintain access privileges. The duration is crucial for
        /// ensuring security in the system, as it determines how frequently keys
        /// need to be renewed.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Duration KeyRenewalDuration
        {
            get { return keyRenewalDuration_; }
            set
            {
                keyRenewalDuration_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Installation);
        public bool Equals(Installation other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DisplayName != other.DisplayName)) return false;
            if ((Photo != other.Photo) || (PhotoUri != other.PhotoUri)) return false;
            if ((Address != other.Address) || (TimeZone != other.TimeZone)) return false;
            if ((!Equals(DigitalKeyArt, other.DigitalKeyArt)) || (!Equals(TransferOwnershipState, other.TransferOwnershipState))) return false;
            if ((!Equals(DeleteTime, other.DeleteTime)) || (!Equals(PartnerInfo, other.PartnerInfo))) return false;
            if ((!Equals(BlockTime, other.BlockTime)) || (!Equals(KeyRenewalDuration, other.KeyRenewalDuration))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasPhoto) hash ^= Photo.GetHashCode();
            if (PhotoUri.Length != 0) hash ^= PhotoUri.GetHashCode();
            if (Address.Length != 0) hash ^= Address.GetHashCode();
            if (TimeZone.Length != 0) hash ^= TimeZone.GetHashCode();
            if (digitalKeyArt_ != null) hash ^= DigitalKeyArt.GetHashCode();
            if (transferOwnershipState_ != null) hash ^= TransferOwnershipState.GetHashCode();
            if (deleteTime_ != null) hash ^= DeleteTime.GetHashCode();
            if (partnerInfo_ != null) hash ^= PartnerInfo.GetHashCode();
            if (blockTime_ != null) hash ^= BlockTime.GetHashCode();
            if (keyRenewalDuration_ != null) hash ^= KeyRenewalDuration.GetHashCode();
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
      if (HasPhoto) {
        output.WriteRawTag(26);
        output.WriteString(Photo);
      }
      if (PhotoUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PhotoUri);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Address);
      }
      if (TimeZone.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TimeZone);
      }
      if (digitalKeyArt_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DigitalKeyArt);
      }
      if (transferOwnershipState_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TransferOwnershipState);
      }
      if (partnerInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PartnerInfo);
      }
      if (keyRenewalDuration_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(KeyRenewalDuration);
      }
      if (blockTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BlockTime);
      }
      if (deleteTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(DeleteTime);
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
            if (HasPhoto)
            {
                output.WriteRawTag(26);
                output.WriteString(Photo);
            }
            if (PhotoUri.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(PhotoUri);
            }
            if (Address.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(Address);
            }
            if (TimeZone.Length != 0)
            {
                output.WriteRawTag(50);
                output.WriteString(TimeZone);
            }
            if (digitalKeyArt_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(DigitalKeyArt);
            }
            if (transferOwnershipState_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(TransferOwnershipState);
            }
            if (partnerInfo_ != null)
            {
                output.WriteRawTag(74);
                output.WriteMessage(PartnerInfo);
            }
            if (keyRenewalDuration_ != null)
            {
                output.WriteRawTag(82);
                output.WriteMessage(KeyRenewalDuration);
            }
            if (blockTime_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(BlockTime);
            }
            if (deleteTime_ != null)
            {
                output.WriteRawTag(98);
                output.WriteMessage(DeleteTime);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (HasPhoto) size += 1 + CodedOutputStream.ComputeStringSize(Photo);
            if (PhotoUri.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PhotoUri);
            if (Address.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Address);
            if (TimeZone.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(TimeZone);
            if (digitalKeyArt_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DigitalKeyArt);
            if (transferOwnershipState_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(TransferOwnershipState);
            if (deleteTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(DeleteTime);
            if (partnerInfo_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PartnerInfo);
            if (blockTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(BlockTime);
            if (keyRenewalDuration_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(KeyRenewalDuration);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Installation other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasPhoto) Photo = other.Photo;
            if (other.PhotoUri.Length != 0) PhotoUri = other.PhotoUri;
            if (other.Address.Length != 0) Address = other.Address;
            if (other.TimeZone.Length != 0) TimeZone = other.TimeZone;
            if (other.digitalKeyArt_ != null)
            {
                if (digitalKeyArt_ == null) DigitalKeyArt = new Types.DigitalKeyArt();
                DigitalKeyArt.MergeFrom(other.DigitalKeyArt);
            }
            if (other.transferOwnershipState_ != null)
            {
                if (transferOwnershipState_ == null) TransferOwnershipState = new Types.TransferOwnershipState();
                TransferOwnershipState.MergeFrom(other.TransferOwnershipState);
            }
            if (other.deleteTime_ != null)
            {
                if (deleteTime_ == null) DeleteTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                DeleteTime.MergeFrom(other.DeleteTime);
            }
            if (other.partnerInfo_ != null)
            {
                if (partnerInfo_ == null) PartnerInfo = new Types.PartnerInfo();
                PartnerInfo.MergeFrom(other.PartnerInfo);
            }
            if (other.blockTime_ != null)
            {
                if (blockTime_ == null) BlockTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                BlockTime.MergeFrom(other.BlockTime);
            }
            if (other.keyRenewalDuration_ != null)
            {
                if (keyRenewalDuration_ == null) KeyRenewalDuration = new Google.Protobuf.WellKnownTypes.Duration();
                KeyRenewalDuration.MergeFrom(other.KeyRenewalDuration);
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
            Photo = input.ReadString();
            break;
          }
          case 34: {
            PhotoUri = input.ReadString();
            break;
          }
          case 42: {
            Address = input.ReadString();
            break;
          }
          case 50: {
            TimeZone = input.ReadString();
            break;
          }
          case 58: {
            if (digitalKeyArt_ == null) {
              DigitalKeyArt = new Saltoapis.Nebula.Installation.V1.Installation.Types.DigitalKeyArt();
            }
            input.ReadMessage(DigitalKeyArt);
            break;
          }
          case 66: {
            if (transferOwnershipState_ == null) {
              TransferOwnershipState = new Saltoapis.Nebula.Installation.V1.Installation.Types.TransferOwnershipState();
            }
            input.ReadMessage(TransferOwnershipState);
            break;
          }
          case 74: {
            if (partnerInfo_ == null) {
              PartnerInfo = new Saltoapis.Nebula.Installation.V1.Installation.Types.PartnerInfo();
            }
            input.ReadMessage(PartnerInfo);
            break;
          }
          case 82: {
            if (keyRenewalDuration_ == null) {
              KeyRenewalDuration = new Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(KeyRenewalDuration);
            break;
          }
          case 90: {
            if (blockTime_ == null) {
              BlockTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(BlockTime);
            break;
          }
          case 98: {
            if (deleteTime_ == null) {
              DeleteTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DeleteTime);
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
                            Photo = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            PhotoUri = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            Address = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            TimeZone = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            if (digitalKeyArt_ == null) DigitalKeyArt = new Types.DigitalKeyArt();
                            input.ReadMessage(DigitalKeyArt);
                            break;
                        }
                    case 66:
                        {
                            if (transferOwnershipState_ == null) TransferOwnershipState = new Types.TransferOwnershipState();
                            input.ReadMessage(TransferOwnershipState);
                            break;
                        }
                    case 74:
                        {
                            if (partnerInfo_ == null) PartnerInfo = new Types.PartnerInfo();
                            input.ReadMessage(PartnerInfo);
                            break;
                        }
                    case 82:
                        {
                            if (keyRenewalDuration_ == null) KeyRenewalDuration = new Google.Protobuf.WellKnownTypes.Duration();
                            input.ReadMessage(KeyRenewalDuration);
                            break;
                        }
                    case 90:
                        {
                            if (blockTime_ == null) BlockTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(BlockTime);
                            break;
                        }
                    case 98:
                        {
                            if (deleteTime_ == null) DeleteTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(DeleteTime);
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the Installation message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// The digital key art configuration object associated to the installation
            /// </summary>
            public sealed partial class DigitalKeyArt : IMessage<DigitalKeyArt>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<DigitalKeyArt> _parser = new(() => new DigitalKeyArt());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<DigitalKeyArt> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Installation.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public DigitalKeyArt()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public DigitalKeyArt(DigitalKeyArt other) : this()
                {
                    backgroundImage_ = other.backgroundImage_;
                    backgroundImageUri_ = other.backgroundImageUri_;
                    textColor_ = other.textColor_?.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public DigitalKeyArt Clone() => new(this);
                /// <summary>Field number for the "background_image" field.</summary>
                public const int BackgroundImageFieldNumber = 1;
                private readonly static string BackgroundImageDefaultValue = "";

                private string backgroundImage_;

                /// <summary>
                /// The file resource name for the digital key background image. It must
                /// have the format of
                /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
                /// </summary>
                public string BackgroundImage
                {
                    get { return backgroundImage_ ?? BackgroundImageDefaultValue; }
                    set
                    {
                        backgroundImage_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Gets whether the "background_image" field is set</summary>
                public bool HasBackgroundImage
                {
                    get { return backgroundImage_ != null; }
                }

                /// <summary>Clears the value of the "background_image" field</summary>
                public void ClearBackgroundImage()
                {
                    backgroundImage_ = null;
                }

                /// <summary>Field number for the "background_image_uri" field.</summary>
                public const int BackgroundImageUriFieldNumber = 2;
                private string backgroundImageUri_ = "";

                /// <summary>
                /// The URI to view the digital key background image.
                /// </summary>
                public string BackgroundImageUri
                {
                    get { return backgroundImageUri_; }
                    set
                    {
                        backgroundImageUri_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "text_color" field.</summary>
                public const int TextColorFieldNumber = 3;
                private Type.Color textColor_;

                /// <summary>
                /// The color used to display the installation name text on top of the background image.
                /// </summary>
                public Type.Color TextColor
                {
                    get { return textColor_; }
                    set
                    {
                        textColor_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as DigitalKeyArt);
                public bool Equals(DigitalKeyArt other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((BackgroundImage != other.BackgroundImage) || (BackgroundImageUri != other.BackgroundImageUri)) return false;
                    if (!Equals(TextColor, other.TextColor)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (HasBackgroundImage) hash ^= BackgroundImage.GetHashCode();
                    if (BackgroundImageUri.Length != 0) hash ^= BackgroundImageUri.GetHashCode();
                    if (textColor_ != null) hash ^= TextColor.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (HasBackgroundImage) {
            output.WriteRawTag(10);
            output.WriteString(BackgroundImage);
          }
          if (BackgroundImageUri.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(BackgroundImageUri);
          }
          if (textColor_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(TextColor);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (HasBackgroundImage)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(BackgroundImage);
                    }
                    if (BackgroundImageUri.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(BackgroundImageUri);
                    }
                    if (textColor_ != null)
                    {
                        output.WriteRawTag(26);
                        output.WriteMessage(TextColor);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (HasBackgroundImage) size += 1 + CodedOutputStream.ComputeStringSize(BackgroundImage);
                    if (BackgroundImageUri.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(BackgroundImageUri);
                    if (textColor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(TextColor);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(DigitalKeyArt other)
                {
                    if (other == null) return;
                    if (other.HasBackgroundImage) BackgroundImage = other.BackgroundImage;
                    if (other.BackgroundImageUri.Length != 0) BackgroundImageUri = other.BackgroundImageUri;
                    if (other.textColor_ != null)
                    {
                        if (textColor_ == null) TextColor = new Type.Color();
                        TextColor.MergeFrom(other.TextColor);
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
                BackgroundImage = input.ReadString();
                break;
              }
              case 18: {
                BackgroundImageUri = input.ReadString();
                break;
              }
              case 26: {
                if (textColor_ == null) {
                  TextColor = new Saltoapis.Type.Color();
                }
                input.ReadMessage(TextColor);
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
                                    BackgroundImage = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    BackgroundImageUri = input.ReadString();
                                    break;
                                }
                            case 26:
                                {
                                    if (textColor_ == null) TextColor = new Type.Color();
                                    input.ReadMessage(TextColor);
                                    break;
                                }
                        }
                    }
                }
#endif

            }

            /// <summary>
            /// Represents the current state of the ownership transfer.
            /// </summary>
            public sealed partial class TransferOwnershipState : IMessage<TransferOwnershipState>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<TransferOwnershipState> _parser = new(() => new TransferOwnershipState());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<TransferOwnershipState> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Installation.Descriptor.NestedTypes[1]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public TransferOwnershipState()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public TransferOwnershipState(TransferOwnershipState other) : this()
                {
                    email_ = other.email_;
                    expireTime_ = other.expireTime_?.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public TransferOwnershipState Clone() => new(this);
                /// <summary>Field number for the "email" field.</summary>
                public const int EmailFieldNumber = 1;
                private string email_ = "";

                /// <summary>
                /// Email address for the proposed installation owner.
                /// </summary>
                public string Email
                {
                    get { return email_; }
                    set
                    {
                        email_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "expire_time" field.</summary>
                public const int ExpireTimeFieldNumber = 2;
                private Google.Protobuf.WellKnownTypes.Timestamp expireTime_;

                /// <summary>
                /// Expiration time of the transfer proposal.
                /// (-- api-linter: core::0214::resource-expiry=disabled  --)
                /// </summary>
                public Google.Protobuf.WellKnownTypes.Timestamp ExpireTime
                {
                    get { return expireTime_; }
                    set
                    {
                        expireTime_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as TransferOwnershipState);
                public bool Equals(TransferOwnershipState other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((Email != other.Email) || (!Equals(ExpireTime, other.ExpireTime))) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Email.Length != 0) hash ^= Email.GetHashCode();
                    if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (Email.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Email);
          }
          if (expireTime_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(ExpireTime);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (Email.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(Email);
                    }
                    if (expireTime_ != null)
                    {
                        output.WriteRawTag(18);
                        output.WriteMessage(ExpireTime);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Email.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Email);
                    if (expireTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ExpireTime);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(TransferOwnershipState other)
                {
                    if (other == null) return;
                    if (other.Email.Length != 0) Email = other.Email;
                    if (other.expireTime_ != null)
                    {
                        if (expireTime_ == null) ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                        ExpireTime.MergeFrom(other.ExpireTime);
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
                Email = input.ReadString();
                break;
              }
              case 18: {
                if (expireTime_ == null) {
                  ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                input.ReadMessage(ExpireTime);
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
                                    Email = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    if (expireTime_ == null) ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                                    input.ReadMessage(ExpireTime);
                                    break;
                                }
                        }
                    }
                }
#endif

            }

            /// <summary>
            /// The partner info object.
            /// </summary>
            public sealed partial class PartnerInfo : IMessage<PartnerInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<PartnerInfo> _parser = new(() => new PartnerInfo());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<PartnerInfo> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Installation.Descriptor.NestedTypes[2]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public PartnerInfo()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public PartnerInfo(PartnerInfo other) : this()
                {
                    partnerId_ = other.partnerId_;
                    currencyCode_ = other.currencyCode_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public PartnerInfo Clone() => new(this);
                /// <summary>Field number for the "partner_id" field.</summary>
                public const int PartnerIdFieldNumber = 1;
                private string partnerId_ = "";

                /// <summary>
                /// The identifier of the partner who created the installation.
                /// </summary>
                public string PartnerId
                {
                    get { return partnerId_; }
                    set
                    {
                        partnerId_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "currency_code" field.</summary>
                public const int CurrencyCodeFieldNumber = 2;
                private string currencyCode_ = "";

                /// <summary>
                /// The currency code the partner used for the installation (ISO 4217 format).
                /// </summary>
                public string CurrencyCode
                {
                    get { return currencyCode_; }
                    set
                    {
                        currencyCode_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                public override bool Equals(object other) => Equals(other as PartnerInfo);
                public bool Equals(PartnerInfo other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((PartnerId != other.PartnerId) || (CurrencyCode != other.CurrencyCode)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (PartnerId.Length != 0) hash ^= PartnerId.GetHashCode();
                    if (CurrencyCode.Length != 0) hash ^= CurrencyCode.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (PartnerId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(PartnerId);
          }
          if (CurrencyCode.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(CurrencyCode);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (PartnerId.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(PartnerId);
                    }
                    if (CurrencyCode.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(CurrencyCode);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (PartnerId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PartnerId);
                    if (CurrencyCode.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(CurrencyCode);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(PartnerInfo other)
                {
                    if (other == null) return;
                    if (other.PartnerId.Length != 0) PartnerId = other.PartnerId;
                    if (other.CurrencyCode.Length != 0) CurrencyCode = other.CurrencyCode;
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
                PartnerId = input.ReadString();
                break;
              }
              case 18: {
                CurrencyCode = input.ReadString();
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
                                    PartnerId = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    CurrencyCode = input.ReadString();
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
