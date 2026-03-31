using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// The user object
    /// </summary>
    public sealed partial class User : IMessage<User>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<User> _parser = new(() => new User());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<User> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public User()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public User(User other) : this()
        {
            name_ = other.name_;
            parent_ = other.parent_;
            givenName_ = other.givenName_;
            familyName_ = other.familyName_;
            displayName_ = other.displayName_;
            email_ = other.email_;
            activateTime_ = other.activateTime_?.Clone();
            expireTime_ = other.expireTime_?.Clone();
            photo_ = other.photo_;
            photoUri_ = other.photoUri_;
            cardKey_ = other.cardKey_?.Clone();
            electronicKey_ = other.electronicKey_?.Clone();
            appKey_ = other.appKey_?.Clone();
            walletKey_ = other.walletKey_?.Clone();
            passcode_ = other.passcode_?.Clone();
            blocked_ = other.blocked_;
            manager_ = other.manager_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public User Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the user. It must have the format of
        /// `installations/*/users/*`. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 2;
        private readonly static string ParentDefaultValue = "";

        private string parent_;

        /// <summary>
        /// The name of the parent user of this user.
        /// Only users who have had keys shared with them will have this field set.
        /// </summary>
        public string Parent
        {
            get { return parent_ ?? ParentDefaultValue; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "parent" field is set</summary>
        public bool HasParent
        {
            get { return parent_ != null; }
        }

        /// <summary>Clears the value of the "parent" field</summary>
        public void ClearParent()
        {
            parent_ = null;
        }

        /// <summary>Field number for the "given_name" field.</summary>
        public const int GivenNameFieldNumber = 3;
        private string givenName_ = "";

        /// <summary>
        /// The personal name, forename or given name ("first name"). It could
        /// also contain a middle name. First name is not used because the given
        /// name is not placed first in some cultures.
        /// </summary>
        public string GivenName
        {
            get { return givenName_; }
            set
            {
                givenName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "family_name" field.</summary>
        public const int FamilyNameFieldNumber = 4;
        private readonly static string FamilyNameDefaultValue = "";

        private string familyName_;

        /// <summary>
        /// The surname or family name ("last name"). It could also contain more than
        /// one surname so that both matrilineal and patrilineal surnames can be
        /// included in one place. Last name is not used because the family name is
        /// not placed last in some cultures.
        /// </summary>
        public string FamilyName
        {
            get { return familyName_ ?? FamilyNameDefaultValue; }
            set
            {
                familyName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "family_name" field is set</summary>
        public bool HasFamilyName
        {
            get { return familyName_ != null; }
        }

        /// <summary>Clears the value of the "family_name" field</summary>
        public void ClearFamilyName()
        {
            familyName_ = null;
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 5;
        private string displayName_ = "";

        /// <summary>
        /// The display name of the user, formed by concatenating the first and last
        /// name values.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "email" field.</summary>
        public const int EmailFieldNumber = 6;
        private readonly static string EmailDefaultValue = "";

        private string email_;

        /// <summary>
        /// Email address.
        /// </summary>
        public string Email
        {
            get { return email_ ?? EmailDefaultValue; }
            set
            {
                email_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "email" field is set</summary>
        public bool HasEmail
        {
            get { return email_ != null; }
        }

        /// <summary>Clears the value of the "email" field</summary>
        public void ClearEmail()
        {
            email_ = null;
        }

        /// <summary>Field number for the "activate_time" field.</summary>
        public const int ActivateTimeFieldNumber = 7;
        private Google.Protobuf.WellKnownTypes.Timestamp activateTime_;

        /// <summary>
        /// Activation time independent of any time zone or calendar.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp ActivateTime
        {
            get { return activateTime_; }
            set
            {
                activateTime_ = value;
            }
        }

        /// <summary>Field number for the "expire_time" field.</summary>
        public const int ExpireTimeFieldNumber = 8;
        private Google.Protobuf.WellKnownTypes.Timestamp expireTime_;

        /// <summary>
        /// Expiration time independent of any time zone or calendar.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp ExpireTime
        {
            get { return expireTime_; }
            set
            {
                expireTime_ = value;
            }
        }

        /// <summary>Field number for the "photo" field.</summary>
        public const int PhotoFieldNumber = 9;
        private readonly static string PhotoDefaultValue = "";

        private string photo_;

        /// <summary>
        /// The file resource name for the user photo. It must have the
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
        public const int PhotoUriFieldNumber = 10;
        private string photoUri_ = "";

        /// <summary>
        /// The URI to view the user photo.
        /// </summary>
        public string PhotoUri
        {
            get { return photoUri_; }
            set
            {
                photoUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 11;
        private CardKey cardKey_;

        /// <summary>
        /// The card key resource that belongs to the user.
        /// </summary>
        public CardKey CardKey
        {
            get { return cardKey_; }
            set
            {
                cardKey_ = value;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 16;
        private ElectronicKey electronicKey_;

        /// <summary>
        /// The electronic key resource that belongs to the user.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 12;
        private AppKey appKey_;

        /// <summary>
        /// The app key resource that belongs to the user.
        /// </summary>
        public AppKey AppKey
        {
            get { return appKey_; }
            set
            {
                appKey_ = value;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 13;
        private WalletKey walletKey_;

        /// <summary>
        /// The wallet key resource that belongs to the user.
        /// </summary>
        public WalletKey WalletKey
        {
            get { return walletKey_; }
            set
            {
                walletKey_ = value;
            }
        }

        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 15;
        private Passcode passcode_;

        /// <summary>
        /// The passcode resource that belongs to the user.
        /// </summary>
        public Passcode Passcode
        {
            get { return passcode_; }
            set
            {
                passcode_ = value;
            }
        }

        /// <summary>Field number for the "blocked" field.</summary>
        public const int BlockedFieldNumber = 14;
        private bool blocked_;

        /// <summary>
        /// Indicates whether this user is blocked or not. A blocked user cannot
        /// perform any admin actions, that is, if they have a management role this
        /// will no longer be valid. If the user has a key then it will no longer
        /// unlock access points.
        /// </summary>
        public bool Blocked
        {
            get { return blocked_; }
            set
            {
                blocked_ = value;
            }
        }

        /// <summary>Field number for the "manager" field.</summary>
        public const int ManagerFieldNumber = 17;
        private readonly static string ManagerDefaultValue = "";

        private string manager_;

        /// <summary>
        /// The resource name of the manager resource that owns this user. A manager
        /// resource is any resource (such as a booking) that creates and governs the
        /// lifecycle of this user.
        ///
        /// Example: "installations/surelock-homes-hq/bookings/watson-family-booking"
        ///
        /// If set, this user is considered "managed" and cannot be modified directly.
        /// It behaves as a side-effect of the manager resource.
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

        public override bool Equals(object other) => Equals(other as User);
        public bool Equals(User other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (Parent != other.Parent)) return false;
            if ((GivenName != other.GivenName) || (FamilyName != other.FamilyName)) return false;
            if ((DisplayName != other.DisplayName) || (Email != other.Email)) return false;
            if ((!Equals(ActivateTime, other.ActivateTime)) || (!Equals(ExpireTime, other.ExpireTime))) return false;
            if ((Photo != other.Photo) || (PhotoUri != other.PhotoUri)) return false;
            if ((!Equals(CardKey, other.CardKey)) || (!Equals(ElectronicKey, other.ElectronicKey))) return false;
            if ((!Equals(AppKey, other.AppKey)) || (!Equals(WalletKey, other.WalletKey))) return false;
            if ((!Equals(Passcode, other.Passcode)) || (Blocked != other.Blocked)) return false;
            if (Manager != other.Manager) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasParent) hash ^= Parent.GetHashCode();
            if (GivenName.Length != 0) hash ^= GivenName.GetHashCode();
            if (HasFamilyName) hash ^= FamilyName.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasEmail) hash ^= Email.GetHashCode();
            if (activateTime_ != null) hash ^= ActivateTime.GetHashCode();
            if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
            if (HasPhoto) hash ^= Photo.GetHashCode();
            if (PhotoUri.Length != 0) hash ^= PhotoUri.GetHashCode();
            if (cardKey_ != null) hash ^= CardKey.GetHashCode();
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
            if (appKey_ != null) hash ^= AppKey.GetHashCode();
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
            if (passcode_ != null) hash ^= Passcode.GetHashCode();
            if (Blocked != false) hash ^= Blocked.GetHashCode();
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
      if (HasParent) {
        output.WriteRawTag(18);
        output.WriteString(Parent);
      }
      if (GivenName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GivenName);
      }
      if (HasFamilyName) {
        output.WriteRawTag(34);
        output.WriteString(FamilyName);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DisplayName);
      }
      if (HasEmail) {
        output.WriteRawTag(50);
        output.WriteString(Email);
      }
      if (activateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ActivateTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ExpireTime);
      }
      if (HasPhoto) {
        output.WriteRawTag(74);
        output.WriteString(Photo);
      }
      if (PhotoUri.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(PhotoUri);
      }
      if (cardKey_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CardKey);
      }
      if (appKey_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AppKey);
      }
      if (walletKey_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(WalletKey);
      }
      if (Blocked != false) {
        output.WriteRawTag(112);
        output.WriteBool(Blocked);
      }
      if (passcode_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Passcode);
      }
      if (electronicKey_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(ElectronicKey);
      }
      if (HasManager) {
        output.WriteRawTag(138, 1);
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
            if (HasParent)
            {
                output.WriteRawTag(18);
                output.WriteString(Parent);
            }
            if (GivenName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(GivenName);
            }
            if (HasFamilyName)
            {
                output.WriteRawTag(34);
                output.WriteString(FamilyName);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(DisplayName);
            }
            if (HasEmail)
            {
                output.WriteRawTag(50);
                output.WriteString(Email);
            }
            if (activateTime_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(ActivateTime);
            }
            if (expireTime_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(ExpireTime);
            }
            if (HasPhoto)
            {
                output.WriteRawTag(74);
                output.WriteString(Photo);
            }
            if (PhotoUri.Length != 0)
            {
                output.WriteRawTag(82);
                output.WriteString(PhotoUri);
            }
            if (cardKey_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(CardKey);
            }
            if (appKey_ != null)
            {
                output.WriteRawTag(98);
                output.WriteMessage(AppKey);
            }
            if (walletKey_ != null)
            {
                output.WriteRawTag(106);
                output.WriteMessage(WalletKey);
            }
            if (Blocked != false)
            {
                output.WriteRawTag(112);
                output.WriteBool(Blocked);
            }
            if (passcode_ != null)
            {
                output.WriteRawTag(122);
                output.WriteMessage(Passcode);
            }
            if (electronicKey_ != null)
            {
                output.WriteRawTag(130, 1);
                output.WriteMessage(ElectronicKey);
            }
            if (HasManager)
            {
                output.WriteRawTag(138, 1);
                output.WriteString(Manager);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (HasParent) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (GivenName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(GivenName);
            if (HasFamilyName) size += 1 + CodedOutputStream.ComputeStringSize(FamilyName);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (HasEmail) size += 1 + CodedOutputStream.ComputeStringSize(Email);
            if (activateTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ActivateTime);
            if (expireTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ExpireTime);
            if (HasPhoto) size += 1 + CodedOutputStream.ComputeStringSize(Photo);
            if (PhotoUri.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PhotoUri);
            if (cardKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            if (electronicKey_ != null) size += 2 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (appKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (walletKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (passcode_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            if (Blocked != false) size += 1 + 1;
            if (HasManager) size += 2 + CodedOutputStream.ComputeStringSize(Manager);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(User other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.HasParent) Parent = other.Parent;
            if (other.GivenName.Length != 0) GivenName = other.GivenName;
            if (other.HasFamilyName) FamilyName = other.FamilyName;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.HasEmail) Email = other.Email;
            if (other.activateTime_ != null)
            {
                if (activateTime_ == null) ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                ActivateTime.MergeFrom(other.ActivateTime);
            }
            if (other.expireTime_ != null)
            {
                if (expireTime_ == null) ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                ExpireTime.MergeFrom(other.ExpireTime);
            }
            if (other.HasPhoto) Photo = other.Photo;
            if (other.PhotoUri.Length != 0) PhotoUri = other.PhotoUri;
            if (other.cardKey_ != null)
            {
                if (cardKey_ == null) CardKey = new CardKey();
                CardKey.MergeFrom(other.CardKey);
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null) ElectronicKey = new ElectronicKey();
                ElectronicKey.MergeFrom(other.ElectronicKey);
            }
            if (other.appKey_ != null)
            {
                if (appKey_ == null) AppKey = new AppKey();
                AppKey.MergeFrom(other.AppKey);
            }
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null) WalletKey = new WalletKey();
                WalletKey.MergeFrom(other.WalletKey);
            }
            if (other.passcode_ != null)
            {
                if (passcode_ == null) Passcode = new Passcode();
                Passcode.MergeFrom(other.Passcode);
            }
            if (other.Blocked != false) Blocked = other.Blocked;
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
            Parent = input.ReadString();
            break;
          }
          case 26: {
            GivenName = input.ReadString();
            break;
          }
          case 34: {
            FamilyName = input.ReadString();
            break;
          }
          case 42: {
            DisplayName = input.ReadString();
            break;
          }
          case 50: {
            Email = input.ReadString();
            break;
          }
          case 58: {
            if (activateTime_ == null) {
              ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ActivateTime);
            break;
          }
          case 66: {
            if (expireTime_ == null) {
              ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
            break;
          }
          case 74: {
            Photo = input.ReadString();
            break;
          }
          case 82: {
            PhotoUri = input.ReadString();
            break;
          }
          case 90: {
            if (cardKey_ == null) {
              CardKey = new Saltoapis.Nebula.User.V1.CardKey();
            }
            input.ReadMessage(CardKey);
            break;
          }
          case 98: {
            if (appKey_ == null) {
              AppKey = new Saltoapis.Nebula.User.V1.AppKey();
            }
            input.ReadMessage(AppKey);
            break;
          }
          case 106: {
            if (walletKey_ == null) {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
            break;
          }
          case 112: {
            Blocked = input.ReadBool();
            break;
          }
          case 122: {
            if (passcode_ == null) {
              Passcode = new Saltoapis.Nebula.User.V1.Passcode();
            }
            input.ReadMessage(Passcode);
            break;
          }
          case 130: {
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.User.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
            break;
          }
          case 138: {
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            GivenName = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            FamilyName = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            Email = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            if (activateTime_ == null) ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(ActivateTime);
                            break;
                        }
                    case 66:
                        {
                            if (expireTime_ == null) ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(ExpireTime);
                            break;
                        }
                    case 74:
                        {
                            Photo = input.ReadString();
                            break;
                        }
                    case 82:
                        {
                            PhotoUri = input.ReadString();
                            break;
                        }
                    case 90:
                        {
                            if (cardKey_ == null) CardKey = new CardKey();
                            input.ReadMessage(CardKey);
                            break;
                        }
                    case 98:
                        {
                            if (appKey_ == null) AppKey = new AppKey();
                            input.ReadMessage(AppKey);
                            break;
                        }
                    case 106:
                        {
                            if (walletKey_ == null) WalletKey = new WalletKey();
                            input.ReadMessage(WalletKey);
                            break;
                        }
                    case 112:
                        {
                            Blocked = input.ReadBool();
                            break;
                        }
                    case 122:
                        {
                            if (passcode_ == null) Passcode = new Passcode();
                            input.ReadMessage(Passcode);
                            break;
                        }
                    case 130:
                        {
                            if (electronicKey_ == null) ElectronicKey = new ElectronicKey();
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                    case 138:
                        {
                            Manager = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

}
