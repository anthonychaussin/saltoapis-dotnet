namespace Saltoapis.Nebula.Unit.V1.Request
{
    /// <summary>
    /// The request message for [`MoveInUnit`][salto.nebula.unit.v1.UnitService.MoveInUnit]
    /// </summary>
    public sealed partial class MoveInUnitRequest : IMessage<MoveInUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<MoveInUnitRequest> _parser = new(() => new MoveInUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<MoveInUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MoveInUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public MoveInUnitRequest(MoveInUnitRequest other) : this()
        {
            name_ = other.name_;
            occupants_ = other.occupants_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public MoveInUnitRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the parent resource where to move in the unit. For
        /// example: `installations/surelock-homes-hq/units/101`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "occupants" field.</summary>
        public const int OccupantsFieldNumber = 2;
        private static readonly FieldCodec<Types.Occupant> _repeated_occupants_codec
            = FieldCodec.ForMessage(18, Types.Occupant.Parser);
        private readonly RepeatedField<Types.Occupant> occupants_ = [];

        /// <summary>
        /// The occupants to be created inside the unit.
        /// </summary>
        public RepeatedField<Types.Occupant> Occupants
        {
            get { return occupants_; }
        }

        public override bool Equals(object other) => Equals(other as MoveInUnitRequest);
        public bool Equals(MoveInUnitRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (!occupants_.Equals(other.occupants_))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            hash ^= occupants_.GetHashCode();
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
      occupants_.WriteTo(output, _repeated_occupants_codec);
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
            occupants_.WriteTo(ref output, _repeated_occupants_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            size += occupants_.CalculateSize(_repeated_occupants_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(MoveInUnitRequest other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            occupants_.Add(other.occupants_);
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
            occupants_.AddEntriesFrom(input, _repeated_occupants_codec);
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
                            occupants_.AddEntriesFrom(ref input, _repeated_occupants_codec);
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the MoveInUnitRequest message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// Representation of a unit occupant resource inside the API.
            /// They can have roles to manage the unit.
            /// </summary>
            public sealed partial class Occupant : IMessage<Occupant>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<Occupant> _parser = new(() => new Occupant());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<Occupant> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return MoveInUnitRequest.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public Occupant()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public Occupant(Occupant other) : this()
                {
                    givenName_ = other.givenName_;
                    familyName_ = other.familyName_;
                    email_ = other.email_;
                    accessRights_ = other.accessRights_.Clone();
                    iamRoles_ = other.iamRoles_.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Occupant Clone() => new(this);
                /// <summary>Field number for the "given_name" field.</summary>
                public const int GivenNameFieldNumber = 1;
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
                public const int FamilyNameFieldNumber = 2;
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

                /// <summary>Field number for the "email" field.</summary>
                public const int EmailFieldNumber = 3;
                private readonly static string EmailDefaultValue = "";

                private string email_;

                /// <summary>
                /// The email address of the occupant. It must be unique within the
                /// unit.
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

                /// <summary>Field number for the "access_rights" field.</summary>
                public const int AccessRightsFieldNumber = 4;
                private static readonly FieldCodec<string> _repeated_accessRights_codec
                    = FieldCodec.ForString(34);
                private readonly RepeatedField<string> accessRights_ = [];

                /// <summary>
                /// The access rights resource names to bind as an association to the
                /// occupant. For example:
                /// `installations/surelock-homes-hq/units/101/access-rights/baskerville`.
                /// </summary>
                public RepeatedField<string> AccessRights
                {
                    get { return accessRights_; }
                }

                /// <summary>Field number for the "iam_roles" field.</summary>
                public const int IamRolesFieldNumber = 5;
                private static readonly FieldCodec<string> _repeated_iamRoles_codec
                    = FieldCodec.ForString(42);
                private readonly RepeatedField<string> iamRoles_ = [];

                /// <summary>
                /// The IAM roles to bind as an association to the occupant. For example:
                /// `iam-roles/unit.admin`.
                /// </summary>
                public RepeatedField<string> IamRoles
                {
                    get { return iamRoles_; }
                }

                public override bool Equals(object other) => Equals(other as Occupant);
                public bool Equals(Occupant other)
                {
                    if (other is null) return false;
                    if (ReferenceEquals(other, this)) return true;
                    if ((GivenName != other.GivenName) || (FamilyName != other.FamilyName)) return false;
                    if ((Email != other.Email) || (!accessRights_.Equals(other.accessRights_))) return false;
                    if (!iamRoles_.Equals(other.iamRoles_)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (GivenName.Length != 0) hash ^= GivenName.GetHashCode();
                    if (HasFamilyName) hash ^= FamilyName.GetHashCode();
                    if (HasEmail) hash ^= Email.GetHashCode();
                    hash ^= accessRights_.GetHashCode();
                    hash ^= iamRoles_.GetHashCode();
                    if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
                    return hash;
                }

                public override string ToString() => JsonFormatter.ToDiagnosticString(this);
                public void WriteTo(CodedOutputStream output)
                {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                    output.WriteRawMessage(this);
#else
          if (GivenName.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(GivenName);
          }
          if (HasFamilyName) {
            output.WriteRawTag(18);
            output.WriteString(FamilyName);
          }
          if (HasEmail) {
            output.WriteRawTag(26);
            output.WriteString(Email);
          }
          accessRights_.WriteTo(output, _repeated_accessRights_codec);
          iamRoles_.WriteTo(output, _repeated_iamRoles_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (GivenName.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(GivenName);
                    }
                    if (HasFamilyName)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(FamilyName);
                    }
                    if (HasEmail)
                    {
                        output.WriteRawTag(26);
                        output.WriteString(Email);
                    }
                    accessRights_.WriteTo(ref output, _repeated_accessRights_codec);
                    iamRoles_.WriteTo(ref output, _repeated_iamRoles_codec);
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (GivenName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(GivenName);
                    if (HasFamilyName) size += 1 + CodedOutputStream.ComputeStringSize(FamilyName);
                    if (HasEmail) size += 1 + CodedOutputStream.ComputeStringSize(Email);
                    size += accessRights_.CalculateSize(_repeated_accessRights_codec);
                    size += iamRoles_.CalculateSize(_repeated_iamRoles_codec);
                    if (_unknownFields != null) size += _unknownFields.CalculateSize();
                    return size;
                }

                public void MergeFrom(Occupant other)
                {
                    if (other == null) return;
                    if (other.GivenName.Length != 0) GivenName = other.GivenName;
                    if (other.HasFamilyName) FamilyName = other.FamilyName;
                    if (other.HasEmail) Email = other.Email;
                    accessRights_.Add(other.accessRights_);
                    iamRoles_.Add(other.iamRoles_);
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
                GivenName = input.ReadString();
                break;
              }
              case 18: {
                FamilyName = input.ReadString();
                break;
              }
              case 26: {
                Email = input.ReadString();
                break;
              }
              case 34: {
                accessRights_.AddEntriesFrom(input, _repeated_accessRights_codec);
                break;
              }
              case 42: {
                iamRoles_.AddEntriesFrom(input, _repeated_iamRoles_codec);
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
                                    GivenName = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    FamilyName = input.ReadString();
                                    break;
                                }
                            case 26:
                                {
                                    Email = input.ReadString();
                                    break;
                                }
                            case 34:
                                {
                                    accessRights_.AddEntriesFrom(ref input, _repeated_accessRights_codec);
                                    break;
                                }
                            case 42:
                                {
                                    iamRoles_.AddEntriesFrom(ref input, _repeated_iamRoles_codec);
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
