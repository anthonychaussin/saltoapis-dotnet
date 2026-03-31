namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>
    /// Billing info object, belonging to a subscription
    /// </summary>
    public sealed partial class BillingInfo : IMessage<BillingInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BillingInfo> _parser = new(() => new BillingInfo());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BillingInfo> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BillingInfo()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BillingInfo(BillingInfo other) : this()
        {
            name_ = other.name_;
            company_ = other.company_;
            address_ = other.address_.Clone();
            regionCode_ = other.regionCode_;
            city_ = other.city_;
            stateCode_ = other.stateCode_;
            zip_ = other.zip_;
            vatNumber_ = other.vatNumber_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BillingInfo Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the subscription's billing info. It must have the format of
        /// `installations/*/subscription/billing-info`. For example:
        /// `installations/surelock-homes-hq/subscription/billing-info`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "company" field.</summary>
        public const int CompanyFieldNumber = 2;
        private string company_ = "";

        /// <summary>
        /// The company name.
        /// </summary>
        public string Company
        {
            get { return company_; }
            set
            {
                company_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "address" field.</summary>
        public const int AddressFieldNumber = 3;
        private static readonly FieldCodec<string> _repeated_address_codec
            = FieldCodec.ForString(26);
        private readonly RepeatedField<string> address_ = [];

        /// <summary>
        /// The lines of the address. The first line may include the street name,
        /// number, P.O. box, and further lines can include information such as
        /// an apartment number, suite or unit.
        /// </summary>
        public RepeatedField<string> Address
        {
            get { return address_; }
        }

        /// <summary>Field number for the "region_code" field.</summary>
        public const int RegionCodeFieldNumber = 4;
        private string regionCode_ = "";

        /// <summary>
        /// The region, country or territory code. Must be in ISO 3166-1 format.
        /// </summary>
        public string RegionCode
        {
            get { return regionCode_; }
            set
            {
                regionCode_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "city" field.</summary>
        public const int CityFieldNumber = 5;
        private string city_ = "";

        /// <summary>
        /// The city, district, suburb, town, or village name.
        /// </summary>
        public string City
        {
            get { return city_; }
            set
            {
                city_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state_code" field.</summary>
        public const int StateCodeFieldNumber = 6;
        private static readonly string StateCodeDefaultValue = "";

        private string stateCode_;

        /// <summary>
        /// The state or province code. Must be in ISO 3166-2 format.
        /// Mandatory for the following countries: USA, Canada and India.
        /// For the rest of the countries, it will be ignored.
        /// </summary>
        public string StateCode
        {
            get { return stateCode_ ?? StateCodeDefaultValue; }
            set
            {
                stateCode_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "state_code" field is set</summary>
        public bool HasStateCode
        {
            get { return stateCode_ != null; }
        }

        /// <summary>Clears the value of the "state_code" field</summary>
        public void ClearStateCode()
        {
            stateCode_ = null;
        }

        /// <summary>Field number for the "zip" field.</summary>
        public const int ZipFieldNumber = 7;
        private string zip_ = "";

        /// <summary>
        /// The ZIP or postal code.
        /// </summary>
        public string Zip
        {
            get { return zip_; }
            set
            {
                zip_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "vat_number" field.</summary>
        public const int VatNumberFieldNumber = 8;
        private static readonly string VatNumberDefaultValue = "";

        private string vatNumber_;

        /// <summary>
        /// The VAT or Tax Registration Number (TRN).
        /// </summary>
        public string VatNumber
        {
            get { return vatNumber_ ?? VatNumberDefaultValue; }
            set
            {
                vatNumber_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "vat_number" field is set</summary>
        public bool HasVatNumber
        {
            get { return vatNumber_ != null; }
        }

        /// <summary>Clears the value of the "vat_number" field</summary>
        public void ClearVatNumber()
        {
            vatNumber_ = null;
        }

        public override bool Equals(object other) => Equals(other as BillingInfo);
        public bool Equals(BillingInfo other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (Company != other.Company)) return false;
            if ((!address_.Equals(other.address_)) || (RegionCode != other.RegionCode)) return false;
            if ((City != other.City) || (StateCode != other.StateCode)) return false;
            if ((Zip != other.Zip) || (VatNumber != other.VatNumber)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Company.Length != 0) hash ^= Company.GetHashCode();
            hash ^= address_.GetHashCode();
            if (RegionCode.Length != 0) hash ^= RegionCode.GetHashCode();
            if (City.Length != 0) hash ^= City.GetHashCode();
            if (HasStateCode) hash ^= StateCode.GetHashCode();
            if (Zip.Length != 0) hash ^= Zip.GetHashCode();
            if (HasVatNumber) hash ^= VatNumber.GetHashCode();
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
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      address_.WriteTo(output, _repeated_address_codec);
      if (RegionCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RegionCode);
      }
      if (City.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(City);
      }
      if (HasStateCode) {
        output.WriteRawTag(50);
        output.WriteString(StateCode);
      }
      if (Zip.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Zip);
      }
      if (HasVatNumber) {
        output.WriteRawTag(66);
        output.WriteString(VatNumber);
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
            if (Company.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Company);
            }
            address_.WriteTo(ref output, _repeated_address_codec);
            if (RegionCode.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(RegionCode);
            }
            if (City.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(City);
            }
            if (HasStateCode)
            {
                output.WriteRawTag(50);
                output.WriteString(StateCode);
            }
            if (Zip.Length != 0)
            {
                output.WriteRawTag(58);
                output.WriteString(Zip);
            }
            if (HasVatNumber)
            {
                output.WriteRawTag(66);
                output.WriteString(VatNumber);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (Company.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Company);
            size += address_.CalculateSize(_repeated_address_codec);
            if (RegionCode.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(RegionCode);
            if (City.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(City);
            if (HasStateCode) size += 1 + CodedOutputStream.ComputeStringSize(StateCode);
            if (Zip.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Zip);
            if (HasVatNumber) size += 1 + CodedOutputStream.ComputeStringSize(VatNumber);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BillingInfo other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.Company.Length != 0) Company = other.Company;
            address_.Add(other.address_);
            if (other.RegionCode.Length != 0) RegionCode = other.RegionCode;
            if (other.City.Length != 0) City = other.City;
            if (other.HasStateCode) StateCode = other.StateCode;
            if (other.Zip.Length != 0) Zip = other.Zip;
            if (other.HasVatNumber) VatNumber = other.VatNumber;
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
            Company = input.ReadString();
            break;
          }
          case 26: {
            address_.AddEntriesFrom(input, _repeated_address_codec);
            break;
          }
          case 34: {
            RegionCode = input.ReadString();
            break;
          }
          case 42: {
            City = input.ReadString();
            break;
          }
          case 50: {
            StateCode = input.ReadString();
            break;
          }
          case 58: {
            Zip = input.ReadString();
            break;
          }
          case 66: {
            VatNumber = input.ReadString();
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
                            Company = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            address_.AddEntriesFrom(ref input, _repeated_address_codec);
                            break;
                        }
                    case 34:
                        {
                            RegionCode = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            City = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            StateCode = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            Zip = input.ReadString();
                            break;
                        }
                    case 66:
                        {
                            VatNumber = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
