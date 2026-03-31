using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.DigitalKey.V1
{
    /// <summary>
    /// The digital key object
    /// </summary>
    public sealed partial class DigitalKey : IMessage<DigitalKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DigitalKey> _parser = new(() => new DigitalKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DigitalKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DigitalKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DigitalKey(DigitalKey other) : this()
        {
            name_ = other.name_;
            switch (other.TypeCase)
            {
                case TypeOneofCase.AppKey:
                    AppKey = other.AppKey.Clone();
                    break;
                case TypeOneofCase.WalletKey:
                    WalletKey = other.WalletKey.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DigitalKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the digital key. It must have the format of
        /// `digital-keys/*`. For example: `digital-keys/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 2;

        /// <summary>
        /// An app key.
        /// </summary>
        public Types.AppKey AppKey
        {
            get { return typeCase_ == TypeOneofCase.AppKey ? (Types.AppKey)type_ : null; }
            set
            {
                type_ = value;
                typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.AppKey;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 3;

        /// <summary>
        /// A wallet key.
        /// </summary>
        public Types.WalletKey WalletKey
        {
            get { return typeCase_ == TypeOneofCase.WalletKey ? (Types.WalletKey)type_ : null; }
            set
            {
                type_ = value;
                typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.WalletKey;
            }
        }

        private object type_;

        /// <summary>Enum of possible cases for the "type" oneof.</summary>
        public enum TypeOneofCase
        {
            None = 0,
            AppKey = 2,
            WalletKey = 3,
        }

        private TypeOneofCase typeCase_ = TypeOneofCase.None;

        public TypeOneofCase TypeCase
        {
            get { return typeCase_; }
        }

        public void ClearType()
        {
            typeCase_ = TypeOneofCase.None;
            type_ = null;
        }

        public override bool Equals(object other) => Equals(other as DigitalKey);
        public bool Equals(DigitalKey other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (!Equals(AppKey, other.AppKey))) return false;
            if ((!Equals(WalletKey, other.WalletKey)) || (TypeCase != other.TypeCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (typeCase_ == TypeOneofCase.AppKey) hash ^= AppKey.GetHashCode();
            if (typeCase_ == TypeOneofCase.WalletKey) hash ^= WalletKey.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (typeCase_ == TypeOneofCase.AppKey) {
        output.WriteRawTag(18);
        output.WriteMessage(AppKey);
      }
      if (typeCase_ == TypeOneofCase.WalletKey) {
        output.WriteRawTag(26);
        output.WriteMessage(WalletKey);
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
            if (typeCase_ == TypeOneofCase.AppKey)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AppKey);
            }
            if (typeCase_ == TypeOneofCase.WalletKey)
            {
                output.WriteRawTag(26);
                output.WriteMessage(WalletKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (typeCase_ == TypeOneofCase.AppKey) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (typeCase_ == TypeOneofCase.WalletKey) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(DigitalKey other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            switch (other.TypeCase)
            {
                case TypeOneofCase.AppKey:
                    AppKey ??= new Types.AppKey();
                    AppKey.MergeFrom(other.AppKey);
                    break;
                case TypeOneofCase.WalletKey:
                    WalletKey ??= new Types.WalletKey();
                    WalletKey.MergeFrom(other.WalletKey);
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
            Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.AppKey subBuilder = new Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.AppKey();
            if (typeCase_ == TypeOneofCase.AppKey) {
              subBuilder.MergeFrom(AppKey);
            }
            input.ReadMessage(subBuilder);
            AppKey = subBuilder;
            break;
          }
          case 26: {
            Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.WalletKey subBuilder = new Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.WalletKey();
            if (typeCase_ == TypeOneofCase.WalletKey) {
              subBuilder.MergeFrom(WalletKey);
            }
            input.ReadMessage(subBuilder);
            WalletKey = subBuilder;
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
                            Types.AppKey subBuilder = new();
                            if (typeCase_ == TypeOneofCase.AppKey) subBuilder.MergeFrom(AppKey);
                            input.ReadMessage(subBuilder);
                            AppKey = subBuilder;
                            break;
                        }
                    case 26:
                        {
                            Types.WalletKey subBuilder = new();
                            if (typeCase_ == TypeOneofCase.WalletKey) subBuilder.MergeFrom(WalletKey);
                            input.ReadMessage(subBuilder);
                            WalletKey = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the DigitalKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// Metadata associated to the digital key.
            /// </summary>
            public sealed partial class Metadata : IMessage<Metadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<Metadata> _parser = new(() => new Metadata());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<Metadata> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return DigitalKey.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public Metadata()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public Metadata(Metadata other) : this()
                {
                    title_ = other.title_;
                    subtitle_ = other.subtitle_;
                    photoUri_ = other.photoUri_;
                    address_ = other.address_;
                    textColor_ = other.textColor_?.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Metadata Clone() => new(this);
                /// <summary>Field number for the "title" field.</summary>
                public const int TitleFieldNumber = 1;
                private string title_ = "";

                /// <summary>
                /// The title of the digital key.
                /// </summary>
                public string Title
                {
                    get { return title_; }
                    set
                    {
                        title_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "subtitle" field.</summary>
                public const int SubtitleFieldNumber = 2;
                private string subtitle_ = "";

                /// <summary>
                /// The subtitle of the digital key.
                /// </summary>
                public string Subtitle
                {
                    get { return subtitle_; }
                    set
                    {
                        subtitle_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "photo_uri" field.</summary>
                public const int PhotoUriFieldNumber = 3;
                private string photoUri_ = "";

                /// <summary>
                /// The URI to view the digital key photo.
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
                public const int AddressFieldNumber = 4;
                private string address_ = "";

                /// <summary>
                /// Unstructured address of the digital key location.
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

                /// <summary>Field number for the "text_color" field.</summary>
                public const int TextColorFieldNumber = 5;
                private Saltoapis.Type.Color textColor_;

                /// <summary>
                /// The color used to display the text on top of the background image.
                /// </summary>
                public Saltoapis.Type.Color TextColor
                {
                    get { return textColor_; }
                    set
                    {
                        textColor_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as Metadata);
                public bool Equals(Metadata other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((Title != other.Title) || (Subtitle != other.Subtitle)) return false;
                    if ((PhotoUri != other.PhotoUri) || (Address != other.Address)) return false;
                    if (!Equals(TextColor, other.TextColor)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Title.Length != 0) hash ^= Title.GetHashCode();
                    if (Subtitle.Length != 0) hash ^= Subtitle.GetHashCode();
                    if (PhotoUri.Length != 0) hash ^= PhotoUri.GetHashCode();
                    if (Address.Length != 0) hash ^= Address.GetHashCode();
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
          if (Title.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Title);
          }
          if (Subtitle.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Subtitle);
          }
          if (PhotoUri.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(PhotoUri);
          }
          if (Address.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Address);
          }
          if (textColor_ != null) {
            output.WriteRawTag(42);
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
                    if (Title.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(Title);
                    }
                    if (Subtitle.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(Subtitle);
                    }
                    if (PhotoUri.Length != 0)
                    {
                        output.WriteRawTag(26);
                        output.WriteString(PhotoUri);
                    }
                    if (Address.Length != 0)
                    {
                        output.WriteRawTag(34);
                        output.WriteString(Address);
                    }
                    if (textColor_ != null)
                    {
                        output.WriteRawTag(42);
                        output.WriteMessage(TextColor);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Title.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Title);
                    if (Subtitle.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Subtitle);
                    if (PhotoUri.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PhotoUri);
                    if (Address.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Address);
                    if (textColor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(TextColor);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(Metadata other)
                {
                    if (other == null) return;
                    if (other.Title.Length != 0) Title = other.Title;
                    if (other.Subtitle.Length != 0) Subtitle = other.Subtitle;
                    if (other.PhotoUri.Length != 0) PhotoUri = other.PhotoUri;
                    if (other.Address.Length != 0) Address = other.Address;
                    if (other.textColor_ != null)
                    {
                        if (textColor_ == null) TextColor = new Saltoapis.Type.Color();
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
                Title = input.ReadString();
                break;
              }
              case 18: {
                Subtitle = input.ReadString();
                break;
              }
              case 26: {
                PhotoUri = input.ReadString();
                break;
              }
              case 34: {
                Address = input.ReadString();
                break;
              }
              case 42: {
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
                                    Title = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    Subtitle = input.ReadString();
                                    break;
                                }
                            case 26:
                                {
                                    PhotoUri = input.ReadString();
                                    break;
                                }
                            case 34:
                                {
                                    Address = input.ReadString();
                                    break;
                                }
                            case 42:
                                {
                                    if (textColor_ == null) TextColor = new Saltoapis.Type.Color();
                                    input.ReadMessage(TextColor);
                                    break;
                                }
                        }
                    }
                }
#endif

            }

            /// <summary>
            /// App key.
            /// </summary>
            public sealed partial class AppKey : IMessage<AppKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<AppKey> _parser = new(() => new AppKey());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<AppKey> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return DigitalKey.Descriptor.NestedTypes[1]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public AppKey()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public AppKey(AppKey other) : this()
                {
                    metadata_ = other.metadata_?.Clone();
                    data_ = other.data_;
                    installation_ = other.installation_;
                    unit_ = other.unit_;
                    installationId_ = other.installationId_;
                    unitId_ = other.unitId_;
                    accessPointsSyncTime_ = other.accessPointsSyncTime_?.Clone();
                    accessPointsSyncState_ = other.accessPointsSyncState_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public AppKey Clone() => new(this);
                /// <summary>Field number for the "metadata" field.</summary>
                public const int MetadataFieldNumber = 1;
                private Metadata metadata_;

                /// <summary>
                /// Metadata associated to this app key.
                /// </summary>
                public Metadata Metadata
                {
                    get { return metadata_; }
                    set
                    {
                        metadata_ = value;
                    }
                }

                /// <summary>Field number for the "data" field.</summary>
                public const int DataFieldNumber = 2;
                private ByteString data_ = ByteString.Empty;

                /// <summary>
                /// An encrypted and authenticated data blob of the app key.
                /// </summary>
                public ByteString Data
                {
                    get { return data_; }
                    set
                    {
                        data_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "installation" field.</summary>
                public const int InstallationFieldNumber = 5;
                private string installation_ = "";

                /// <summary>
                /// The resource name of the installation this app key belong to.
                /// For example: `installations/surelock-homes-hq`.
                /// </summary>
                public string Installation
                {
                    get { return installation_; }
                    set
                    {
                        installation_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "unit" field.</summary>
                public const int UnitFieldNumber = 6;
                private readonly static string UnitDefaultValue = "";

                private string unit_;

                /// <summary>
                /// The resource name of the unit this app key belong to.
                /// For example: `installations/surelock-homes-hq/units/101`.
                /// </summary>
                public string Unit
                {
                    get { return unit_ ?? UnitDefaultValue; }
                    set
                    {
                        unit_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Gets whether the "unit" field is set</summary>
                public bool HasUnit
                {
                    get { return unit_ != null; }
                }

                /// <summary>Clears the value of the "unit" field</summary>
                public void ClearUnit()
                {
                    unit_ = null;
                }

                /// <summary>Field number for the "installation_id" field.</summary>
                public const int InstallationIdFieldNumber = 3;
                private string installationId_ = "";

                /// <summary>
                /// Installation identifier for low-level purposes.
                ///
                /// WARNING: This is going to be removed after the initial nebula release
                /// as its only purpose is to ease the installation picking mechanism in
                /// mobile apps.
                /// </summary>
                public string InstallationId
                {
                    get { return installationId_; }
                    set
                    {
                        installationId_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "unit_id" field.</summary>
                public const int UnitIdFieldNumber = 4;
                private readonly static string UnitIdDefaultValue = "";

                private string unitId_;

                /// <summary>
                /// Unit identifier for low-level purposes.
                ///
                /// WARNING: This is going to be removed after the initial nebula release
                /// as its only purpose is to ease the unit picking mechanism in mobile
                /// apps.
                /// </summary>
                public string UnitId
                {
                    get { return unitId_ ?? UnitIdDefaultValue; }
                    set
                    {
                        unitId_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Gets whether the "unit_id" field is set</summary>
                public bool HasUnitId
                {
                    get { return unitId_ != null; }
                }

                /// <summary>Clears the value of the "unit_id" field</summary>
                public void ClearUnitId()
                {
                    unitId_ = null;
                }

                /// <summary>Field number for the "access_points_sync_time" field.</summary>
                public const int AccessPointsSyncTimeFieldNumber = 7;
                private Google.Protobuf.WellKnownTypes.Timestamp accessPointsSyncTime_;

                /// <summary>
                /// Access points synchronization time.
                ///
                /// This data is populated with the user's access points sync time.
                /// Indicates the last time the digital key's access points were synced.
                /// </summary>
                public Google.Protobuf.WellKnownTypes.Timestamp AccessPointsSyncTime
                {
                    get { return accessPointsSyncTime_; }
                    set
                    {
                        accessPointsSyncTime_ = value;
                    }
                }

                /// <summary>Field number for the "access_points_sync_state" field.</summary>
                public const int AccessPointsSyncStateFieldNumber = 8;
                private Types.AccessPointsSyncState accessPointsSyncState_ = Types.AccessPointsSyncState.Unspecified;

                /// <summary>
                /// The sync state of the digital key's access points.
                /// </summary>
                public Types.AccessPointsSyncState AccessPointsSyncState
                {
                    get { return accessPointsSyncState_; }
                    set
                    {
                        accessPointsSyncState_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as AppKey);
                public bool Equals(AppKey other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((!Equals(Metadata, other.Metadata)) || (Data != other.Data)) return false;
                    if ((Installation != other.Installation) || (Unit != other.Unit)) return false;
                    if ((InstallationId != other.InstallationId) || (UnitId != other.UnitId)) return false;
                    if ((!Equals(AccessPointsSyncTime, other.AccessPointsSyncTime)) || (AccessPointsSyncState != other.AccessPointsSyncState)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (metadata_ != null) hash ^= Metadata.GetHashCode();
                    if (Data.Length != 0) hash ^= Data.GetHashCode();
                    if (Installation.Length != 0) hash ^= Installation.GetHashCode();
                    if (HasUnit) hash ^= Unit.GetHashCode();
                    if (InstallationId.Length != 0) hash ^= InstallationId.GetHashCode();
                    if (HasUnitId) hash ^= UnitId.GetHashCode();
                    if (accessPointsSyncTime_ != null) hash ^= AccessPointsSyncTime.GetHashCode();
                    if (AccessPointsSyncState != Types.AccessPointsSyncState.Unspecified) hash ^= AccessPointsSyncState.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (metadata_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(Metadata);
          }
          if (Data.Length != 0) {
            output.WriteRawTag(18);
            output.WriteBytes(Data);
          }
          if (InstallationId.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(InstallationId);
          }
          if (HasUnitId) {
            output.WriteRawTag(34);
            output.WriteString(UnitId);
          }
          if (Installation.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(Installation);
          }
          if (HasUnit) {
            output.WriteRawTag(50);
            output.WriteString(Unit);
          }
          if (accessPointsSyncTime_ != null) {
            output.WriteRawTag(58);
            output.WriteMessage(AccessPointsSyncTime);
          }
          if (AccessPointsSyncState != Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.AppKey.Types.AccessPointsSyncState.Unspecified) {
            output.WriteRawTag(64);
            output.WriteEnum((int) AccessPointsSyncState);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (metadata_ != null)
                    {
                        output.WriteRawTag(10);
                        output.WriteMessage(Metadata);
                    }
                    if (Data.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteBytes(Data);
                    }
                    if (InstallationId.Length != 0)
                    {
                        output.WriteRawTag(26);
                        output.WriteString(InstallationId);
                    }
                    if (HasUnitId)
                    {
                        output.WriteRawTag(34);
                        output.WriteString(UnitId);
                    }
                    if (Installation.Length != 0)
                    {
                        output.WriteRawTag(42);
                        output.WriteString(Installation);
                    }
                    if (HasUnit)
                    {
                        output.WriteRawTag(50);
                        output.WriteString(Unit);
                    }
                    if (accessPointsSyncTime_ != null)
                    {
                        output.WriteRawTag(58);
                        output.WriteMessage(AccessPointsSyncTime);
                    }
                    if (AccessPointsSyncState != Types.AccessPointsSyncState.Unspecified)
                    {
                        output.WriteRawTag(64);
                        output.WriteEnum((int)AccessPointsSyncState);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (metadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Metadata);
                    if (Data.Length != 0) size += 1 + CodedOutputStream.ComputeBytesSize(Data);
                    if (Installation.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Installation);
                    if (HasUnit) size += 1 + CodedOutputStream.ComputeStringSize(Unit);
                    if (InstallationId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(InstallationId);
                    if (HasUnitId) size += 1 + CodedOutputStream.ComputeStringSize(UnitId);
                    if (accessPointsSyncTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointsSyncTime);
                    if (AccessPointsSyncState != Types.AccessPointsSyncState.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)AccessPointsSyncState);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(AppKey other)
                {
                    if (other == null) return;
                    if (other.metadata_ != null)
                    {
                        if (metadata_ == null) Metadata = new Metadata();
                        Metadata.MergeFrom(other.Metadata);
                    }
                    if (other.Data.Length != 0) Data = other.Data;
                    if (other.Installation.Length != 0) Installation = other.Installation;
                    if (other.HasUnit) Unit = other.Unit;
                    if (other.InstallationId.Length != 0) InstallationId = other.InstallationId;
                    if (other.HasUnitId) UnitId = other.UnitId;
                    if (other.accessPointsSyncTime_ != null)
                    {
                        if (accessPointsSyncTime_ == null) AccessPointsSyncTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                        AccessPointsSyncTime.MergeFrom(other.AccessPointsSyncTime);
                    }
                    if (other.AccessPointsSyncState != Types.AccessPointsSyncState.Unspecified) AccessPointsSyncState = other.AccessPointsSyncState;
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
                if (metadata_ == null) {
                  Metadata = new Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.Metadata();
                }
                input.ReadMessage(Metadata);
                break;
              }
              case 18: {
                Data = input.ReadBytes();
                break;
              }
              case 26: {
                InstallationId = input.ReadString();
                break;
              }
              case 34: {
                UnitId = input.ReadString();
                break;
              }
              case 42: {
                Installation = input.ReadString();
                break;
              }
              case 50: {
                Unit = input.ReadString();
                break;
              }
              case 58: {
                if (accessPointsSyncTime_ == null) {
                  AccessPointsSyncTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                input.ReadMessage(AccessPointsSyncTime);
                break;
              }
              case 64: {
                AccessPointsSyncState = (Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.AppKey.Types.AccessPointsSyncState) input.ReadEnum();
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
                                    if (metadata_ == null) Metadata = new Metadata();
                                    input.ReadMessage(Metadata);
                                    break;
                                }
                            case 18:
                                {
                                    Data = input.ReadBytes();
                                    break;
                                }
                            case 26:
                                {
                                    InstallationId = input.ReadString();
                                    break;
                                }
                            case 34:
                                {
                                    UnitId = input.ReadString();
                                    break;
                                }
                            case 42:
                                {
                                    Installation = input.ReadString();
                                    break;
                                }
                            case 50:
                                {
                                    Unit = input.ReadString();
                                    break;
                                }
                            case 58:
                                {
                                    if (accessPointsSyncTime_ == null) AccessPointsSyncTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                                    input.ReadMessage(AccessPointsSyncTime);
                                    break;
                                }
                            case 64:
                                {
                                    AccessPointsSyncState = (Types.AccessPointsSyncState)input.ReadEnum();
                                    break;
                                }
                        }
                    }
                }
#endif

                /// <summary>Container for nested types declared in the AppKey message type.</summary>
                public static partial class Types
                {
                    /// <summary>
                    /// Sync state of the digital key's access points.
                    /// </summary>
                    public enum AccessPointsSyncState
                    {
                        /// <summary>
                        /// Sentinel value used to indicate that the state is unknown, omitted,
                        /// or is not applicable.
                        /// </summary>
                        [OriginalName("ACCESS_POINTS_SYNC_STATE_UNSPECIFIED")] Unspecified = 0,
                        /// <summary>
                        /// The digital key's access points are invalidated.
                        /// </summary>
                        [OriginalName("INVALIDATED")] Invalidated = 3,
                        /// <summary>
                        /// The digital key's access points are being synced.
                        /// </summary>
                        [OriginalName("SYNCING")] Syncing = 1,
                        /// <summary>
                        /// The digital key's access points are synced.
                        /// </summary>
                        [OriginalName("SYNCED")] Synced = 2,
                        /// <summary>
                        /// The digital key's access points are not supported on the digital key's installation.
                        /// </summary>
                        [OriginalName("NOT_SUPPORTED")] NotSupported = 4,
                        /// <summary>
                        /// The digital key's access points synchronization is skipped because the
                        /// number of access points associated with this digital key
                        /// exceeds the system's maximum allowed limit.
                        /// </summary>
                        [OriginalName("LIMIT_EXCEEDED")] LimitExceeded = 5,
                    }

                }

            }

            /// <summary>
            /// Wallet key.
            /// </summary>
            public sealed partial class WalletKey : IMessage<WalletKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<WalletKey> _parser = new(() => new WalletKey());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<WalletKey> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return DigitalKey.Descriptor.NestedTypes[2]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public WalletKey()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public WalletKey(WalletKey other) : this()
                {
                    metadata_ = other.metadata_?.Clone();
                    hydraCredential_ = other.hydraCredential_?.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public WalletKey Clone() => new(this);
                /// <summary>Field number for the "metadata" field.</summary>
                public const int MetadataFieldNumber = 1;
                private Metadata metadata_;

                /// <summary>
                /// Metadata associated to this wallet key.
                /// </summary>
                public Metadata Metadata
                {
                    get { return metadata_; }
                    set
                    {
                        metadata_ = value;
                    }
                }

                /// <summary>Field number for the "hydra_credential" field.</summary>
                public const int HydraCredentialFieldNumber = 2;
                private Types.HydraCredential hydraCredential_;

                /// <summary>
                /// Hydra credential of this user's wallet key.
                /// </summary>
                public Types.HydraCredential HydraCredential
                {
                    get { return hydraCredential_; }
                    set
                    {
                        hydraCredential_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as WalletKey);
                public bool Equals(WalletKey other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((!Equals(Metadata, other.Metadata)) || (!Equals(HydraCredential, other.HydraCredential))) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (metadata_ != null) hash ^= Metadata.GetHashCode();
                    if (hydraCredential_ != null) hash ^= HydraCredential.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (metadata_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(Metadata);
          }
          if (hydraCredential_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(HydraCredential);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (metadata_ != null)
                    {
                        output.WriteRawTag(10);
                        output.WriteMessage(Metadata);
                    }
                    if (hydraCredential_ != null)
                    {
                        output.WriteRawTag(18);
                        output.WriteMessage(HydraCredential);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (metadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Metadata);
                    if (hydraCredential_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(HydraCredential);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(WalletKey other)
                {
                    if (other == null) return;
                    if (other.metadata_ != null)
                    {
                        if (metadata_ == null) Metadata = new Metadata();
                        Metadata.MergeFrom(other.Metadata);
                    }
                    if (other.hydraCredential_ != null)
                    {
                        if (hydraCredential_ == null) HydraCredential = new Types.HydraCredential();
                        HydraCredential.MergeFrom(other.HydraCredential);
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
                if (metadata_ == null) {
                  Metadata = new Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.Metadata();
                }
                input.ReadMessage(Metadata);
                break;
              }
              case 18: {
                if (hydraCredential_ == null) {
                  HydraCredential = new Saltoapis.Nebula.DigitalKey.V1.DigitalKey.Types.WalletKey.Types.HydraCredential();
                }
                input.ReadMessage(HydraCredential);
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
                                    if (metadata_ == null) Metadata = new Metadata();
                                    input.ReadMessage(Metadata);
                                    break;
                                }
                            case 18:
                                {
                                    if (hydraCredential_ == null) HydraCredential = new Types.HydraCredential();
                                    input.ReadMessage(HydraCredential);
                                    break;
                                }
                        }
                    }
                }
#endif

                /// <summary>Container for nested types declared in the WalletKey message type.</summary>
                public static partial class Types
                {
                    /// <summary>
                    /// Representation of an Hydra credential
                    /// </summary>
                    public sealed partial class HydraCredential : IMessage<HydraCredential>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                        , IBufferMessage
#endif
                    {
                        private static readonly MessageParser<HydraCredential> _parser = new(() => new HydraCredential());
                        private UnknownFieldSet _unknownFields;

                        public static MessageParser<HydraCredential> Parser { get { return _parser; } }

                        public static MessageDescriptor Descriptor
                        {
                            get { return WalletKey.Descriptor.NestedTypes[0]; }
                        }

                        MessageDescriptor IMessage.Descriptor
                        {
                            get { return Descriptor; }
                        }

                        public HydraCredential()
                        {
                            OnConstruction();
                        }

                        partial void OnConstruction();

                        public HydraCredential(HydraCredential other) : this()
                        {
                            credentialId_ = other.credentialId_;
                            sharingInstanceId_ = other.sharingInstanceId_;
                            accountHash_ = other.accountHash_;
                            templateId_ = other.templateId_;
                            relyingPartyId_ = other.relyingPartyId_;
                            referenceId_ = other.referenceId_;
                            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                        }

                        public HydraCredential Clone() => new(this);
                        /// <summary>Field number for the "credential_id" field.</summary>
                        public const int CredentialIdFieldNumber = 1;
                        private string credentialId_ = "";

                        /// <summary>
                        /// Credential identifier created and managed by Wallet Hub.
                        /// </summary>
                        public string CredentialId
                        {
                            get { return credentialId_; }
                            set
                            {
                                credentialId_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "sharing_instance_id" field.</summary>
                        public const int SharingInstanceIdFieldNumber = 2;
                        private string sharingInstanceId_ = "";

                        /// <summary>
                        /// An identifier that helps mapping which devices are being provisioned
                        /// simultaneously as a result of user initiating an in-app provisioning
                        /// on the main device.
                        /// </summary>
                        public string SharingInstanceId
                        {
                            get { return sharingInstanceId_; }
                            set
                            {
                                sharingInstanceId_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "account_hash" field.</summary>
                        public const int AccountHashFieldNumber = 3;
                        private string accountHash_ = "";

                        /// <summary>
                        /// An identifier that has a direct reference to user's account with the
                        /// issuer.
                        /// </summary>
                        public string AccountHash
                        {
                            get { return accountHash_; }
                            set
                            {
                                accountHash_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "template_id" field.</summary>
                        public const int TemplateIdFieldNumber = 4;
                        private string templateId_ = "";

                        /// <summary>
                        /// Card template identifier. Identifies a combination of
                        /// card profile identifier, card configuration identifier and
                        /// card art bundle name.
                        /// </summary>
                        public string TemplateId
                        {
                            get { return templateId_; }
                            set
                            {
                                templateId_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "relying_party_id" field.</summary>
                        public const int RelyingPartyIdFieldNumber = 5;
                        private string relyingPartyId_ = "";

                        /// <summary>
                        /// An identifier representing an entity that uses a FIDO protocol to
                        /// directly authenticate users.
                        /// </summary>
                        public string RelyingPartyId
                        {
                            get { return relyingPartyId_; }
                            set
                            {
                                relyingPartyId_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "reference_id" field.</summary>
                        public const int ReferenceIdFieldNumber = 6;
                        private string referenceId_ = "";

                        /// <summary>
                        /// Reference identifier for this card.
                        /// </summary>
                        public string ReferenceId
                        {
                            get { return referenceId_; }
                            set
                            {
                                referenceId_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        public override bool Equals(object other) => Equals(other as HydraCredential);
                        public bool Equals(HydraCredential other)
                        {
                            if (other is null) return false;
                            if (ReferenceEquals(other, this)) return true;
                            if ((CredentialId != other.CredentialId) || (SharingInstanceId != other.SharingInstanceId)) return false;
                            if ((AccountHash != other.AccountHash) || (TemplateId != other.TemplateId)) return false;
                            if ((RelyingPartyId != other.RelyingPartyId) || (ReferenceId != other.ReferenceId)) return false;
                            return Equals(_unknownFields, other._unknownFields);
                        }

                        public override int GetHashCode()
                        {
                            int hash = 1;
                            if (CredentialId.Length != 0) hash ^= CredentialId.GetHashCode();
                            if (SharingInstanceId.Length != 0) hash ^= SharingInstanceId.GetHashCode();
                            if (AccountHash.Length != 0) hash ^= AccountHash.GetHashCode();
                            if (TemplateId.Length != 0) hash ^= TemplateId.GetHashCode();
                            if (RelyingPartyId.Length != 0) hash ^= RelyingPartyId.GetHashCode();
                            if (ReferenceId.Length != 0) hash ^= ReferenceId.GetHashCode();
                            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                            return hash;
                        }

                        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                        public void WriteTo(CodedOutputStream output)
                        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                            output.WriteRawMessage(this);
#else
              if (CredentialId.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(CredentialId);
              }
              if (SharingInstanceId.Length != 0) {
                output.WriteRawTag(18);
                output.WriteString(SharingInstanceId);
              }
              if (AccountHash.Length != 0) {
                output.WriteRawTag(26);
                output.WriteString(AccountHash);
              }
              if (TemplateId.Length != 0) {
                output.WriteRawTag(34);
                output.WriteString(TemplateId);
              }
              if (RelyingPartyId.Length != 0) {
                output.WriteRawTag(42);
                output.WriteString(RelyingPartyId);
              }
              if (ReferenceId.Length != 0) {
                output.WriteRawTag(50);
                output.WriteString(ReferenceId);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
#endif
                        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                        void IBufferMessage.InternalWriteTo(ref WriteContext output)
                        {
                            if (CredentialId.Length != 0)
                            {
                                output.WriteRawTag(10);
                                output.WriteString(CredentialId);
                            }
                            if (SharingInstanceId.Length != 0)
                            {
                                output.WriteRawTag(18);
                                output.WriteString(SharingInstanceId);
                            }
                            if (AccountHash.Length != 0)
                            {
                                output.WriteRawTag(26);
                                output.WriteString(AccountHash);
                            }
                            if (TemplateId.Length != 0)
                            {
                                output.WriteRawTag(34);
                                output.WriteString(TemplateId);
                            }
                            if (RelyingPartyId.Length != 0)
                            {
                                output.WriteRawTag(42);
                                output.WriteString(RelyingPartyId);
                            }
                            if (ReferenceId.Length != 0)
                            {
                                output.WriteRawTag(50);
                                output.WriteString(ReferenceId);
                            }
                            _unknownFields?.WriteTo(ref output);
                        }
#endif

                        public int CalculateSize()
                        {
                            int size = 0;
                            if (CredentialId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(CredentialId);
                            if (SharingInstanceId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(SharingInstanceId);
                            if (AccountHash.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccountHash);
                            if (TemplateId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(TemplateId);
                            if (RelyingPartyId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(RelyingPartyId);
                            if (ReferenceId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(ReferenceId);
                            if (_unknownFields != null) size += _unknownFields.CalculateSize();
                            return size;
                        }

                        public void MergeFrom(HydraCredential other)
                        {
                            if (other == null) return;
                            if (other.CredentialId.Length != 0) CredentialId = other.CredentialId;
                            if (other.SharingInstanceId.Length != 0) SharingInstanceId = other.SharingInstanceId;
                            if (other.AccountHash.Length != 0) AccountHash = other.AccountHash;
                            if (other.TemplateId.Length != 0) TemplateId = other.TemplateId;
                            if (other.RelyingPartyId.Length != 0) RelyingPartyId = other.RelyingPartyId;
                            if (other.ReferenceId.Length != 0) ReferenceId = other.ReferenceId;
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
                    CredentialId = input.ReadString();
                    break;
                  }
                  case 18: {
                    SharingInstanceId = input.ReadString();
                    break;
                  }
                  case 26: {
                    AccountHash = input.ReadString();
                    break;
                  }
                  case 34: {
                    TemplateId = input.ReadString();
                    break;
                  }
                  case 42: {
                    RelyingPartyId = input.ReadString();
                    break;
                  }
                  case 50: {
                    ReferenceId = input.ReadString();
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
                                            CredentialId = input.ReadString();
                                            break;
                                        }
                                    case 18:
                                        {
                                            SharingInstanceId = input.ReadString();
                                            break;
                                        }
                                    case 26:
                                        {
                                            AccountHash = input.ReadString();
                                            break;
                                        }
                                    case 34:
                                        {
                                            TemplateId = input.ReadString();
                                            break;
                                        }
                                    case 42:
                                        {
                                            RelyingPartyId = input.ReadString();
                                            break;
                                        }
                                    case 50:
                                        {
                                            ReferenceId = input.ReadString();
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

    }
}