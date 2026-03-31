using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Unit.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/unit/v1/unit.proto</summary>
    public static partial class UnitReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/unit/v1/unit.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static UnitReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ch9zYWx0by9uZWJ1bGEvdW5pdC92MS91bml0LnByb3RvEhRzYWx0by5uZWJ1",
                  "bGEudW5pdC52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGiBnb29n",
                  "bGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxofZ29vZ2xlL3Byb3RvYnVm",
                  "L3RpbWVzdGFtcC5wcm90byK6AgoEVW5pdBIMCgRuYW1lGAEgASgJEhQKDGRp",
                  "c3BsYXlfbmFtZRgCIAEoCRIwCgxtb3ZlX2luX3RpbWUYAyABKAsyGi5nb29n",
                  "bGUucHJvdG9idWYuVGltZXN0YW1wEjEKDW1vdmVfb3V0X3RpbWUYBCABKAsy",
                  "Gi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEkQKEHByaXZhY3lfc2V0dGlu",
                  "Z3MYBSABKAsyKi5zYWx0by5uZWJ1bGEudW5pdC52MS5Vbml0LlByaXZhY3lT",
                  "ZXR0aW5ncxIdChVkZWZhdWx0X2FjY2Vzc19yaWdodHMYBiADKAkSFAoHbWFu",
                  "YWdlchgHIAEoCUgAiAEBGiIKD1ByaXZhY3lTZXR0aW5ncxIPCgdlbmFibGVk",
                  "GAEgASgIQgoKCF9tYW5hZ2VyIjUKBlBvbGljeRIMCgRuYW1lGAEgASgJEg4K",
                  "Bm1lbWJlchgCIAEoCRINCgVyb2xlcxgDIAMoCSJvChFDcmVhdGVVbml0UmVx",
                  "dWVzdBIOCgZwYXJlbnQYASABKAkSFAoHdW5pdF9pZBgCIAEoCUgAiAEBEigK",
                  "BHVuaXQYAyABKAsyGi5zYWx0by5uZWJ1bGEudW5pdC52MS5Vbml0QgoKCF91",
                  "bml0X2lkIh4KDkdldFVuaXRSZXF1ZXN0EgwKBG5hbWUYASABKAkiawoQTGlz",
                  "dFVuaXRzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkSEQoJcGFnZV9zaXplGAIg",
                  "ASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmlsdGVyGAQgASgJEhAKCG9y",
                  "ZGVyX2J5GAUgASgJIlcKEUxpc3RVbml0c1Jlc3BvbnNlEikKBXVuaXRzGAEg",
                  "AygLMhouc2FsdG8ubmVidWxhLnVuaXQudjEuVW5pdBIXCg9uZXh0X3BhZ2Vf",
                  "dG9rZW4YAiABKAkibgoRVXBkYXRlVW5pdFJlcXVlc3QSKAoEdW5pdBgBIAEo",
                  "CzIaLnNhbHRvLm5lYnVsYS51bml0LnYxLlVuaXQSLwoLdXBkYXRlX21hc2sY",
                  "AiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIiEKEURlbGV0ZVVu",
                  "aXRSZXF1ZXN0EgwKBG5hbWUYASABKAkiIwoTQ2xlYW5PdXRVbml0UmVxdWVz",
                  "dBIMCgRuYW1lGAEgASgJIhYKFENsZWFuT3V0VW5pdFJlc3BvbnNlIvkBChFN",
                  "b3ZlSW5Vbml0UmVxdWVzdBIMCgRuYW1lGAEgASgJEkMKCW9jY3VwYW50cxgC",
                  "IAMoCzIwLnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVJblVuaXRSZXF1ZXN0",
                  "Lk9jY3VwYW50GpABCghPY2N1cGFudBISCgpnaXZlbl9uYW1lGAEgASgJEhgK",
                  "C2ZhbWlseV9uYW1lGAIgASgJSACIAQESEgoFZW1haWwYAyABKAlIAYgBARIV",
                  "Cg1hY2Nlc3NfcmlnaHRzGAQgAygJEhEKCWlhbV9yb2xlcxgFIAMoCUIOCgxf",
                  "ZmFtaWx5X25hbWVCCAoGX2VtYWlsIhQKEk1vdmVJblVuaXRSZXNwb25zZSIi",
                  "ChJNb3ZlT3V0VW5pdFJlcXVlc3QSDAoEbmFtZRgBIAEoCSIVChNNb3ZlT3V0",
                  "VW5pdFJlc3BvbnNlImYKE0NyZWF0ZVBvbGljeVJlcXVlc3QSDgoGcGFyZW50",
                  "GAEgASgJEhEKCXBvbGljeV9pZBgCIAEoCRIsCgZwb2xpY3kYAyABKAsyHC5z",
                  "YWx0by5uZWJ1bGEudW5pdC52MS5Qb2xpY3kiIAoQR2V0UG9saWN5UmVxdWVz",
                  "dBIMCgRuYW1lGAEgASgJIm4KE0xpc3RQb2xpY2llc1JlcXVlc3QSDgoGcGFy",
                  "ZW50GAEgASgJEhEKCXBhZ2Vfc2l6ZRgCIAEoBRISCgpwYWdlX3Rva2VuGAMg",
                  "ASgJEg4KBmZpbHRlchgEIAEoCRIQCghvcmRlcl9ieRgFIAEoCSJfChRMaXN0",
                  "UG9saWNpZXNSZXNwb25zZRIuCghwb2xpY2llcxgBIAMoCzIcLnNhbHRvLm5l",
                  "YnVsYS51bml0LnYxLlBvbGljeRIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAki",
                  "dAoTVXBkYXRlUG9saWN5UmVxdWVzdBIsCgZwb2xpY3kYASABKAsyHC5zYWx0",
                  "by5uZWJ1bGEudW5pdC52MS5Qb2xpY3kSLwoLdXBkYXRlX21hc2sYAiABKAsy",
                  "Gi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIiMKE0RlbGV0ZVBvbGljeVJl",
                  "cXVlc3QSDAoEbmFtZRgBIAEoCSI7ChZUZXN0UGVybWlzc2lvbnNSZXF1ZXN0",
                  "EgwKBHVuaXQYASABKAkSEwoLcGVybWlzc2lvbnMYAiADKAkiLgoXVGVzdFBl",
                  "cm1pc3Npb25zUmVzcG9uc2USEwoLcGVybWlzc2lvbnMYASADKAkyiAoKC1Vu",
                  "aXRTZXJ2aWNlElEKCkNyZWF0ZVVuaXQSJy5zYWx0by5uZWJ1bGEudW5pdC52",
                  "MS5DcmVhdGVVbml0UmVxdWVzdBoaLnNhbHRvLm5lYnVsYS51bml0LnYxLlVu",
                  "aXQSSwoHR2V0VW5pdBIkLnNhbHRvLm5lYnVsYS51bml0LnYxLkdldFVuaXRS",
                  "ZXF1ZXN0Ghouc2FsdG8ubmVidWxhLnVuaXQudjEuVW5pdBJcCglMaXN0VW5p",
                  "dHMSJi5zYWx0by5uZWJ1bGEudW5pdC52MS5MaXN0VW5pdHNSZXF1ZXN0Gicu",
                  "c2FsdG8ubmVidWxhLnVuaXQudjEuTGlzdFVuaXRzUmVzcG9uc2USUQoKVXBk",
                  "YXRlVW5pdBInLnNhbHRvLm5lYnVsYS51bml0LnYxLlVwZGF0ZVVuaXRSZXF1",
                  "ZXN0Ghouc2FsdG8ubmVidWxhLnVuaXQudjEuVW5pdBJNCgpEZWxldGVVbml0",
                  "Eicuc2FsdG8ubmVidWxhLnVuaXQudjEuRGVsZXRlVW5pdFJlcXVlc3QaFi5n",
                  "b29nbGUucHJvdG9idWYuRW1wdHkSZQoMQ2xlYW5PdXRVbml0Eikuc2FsdG8u",
                  "bmVidWxhLnVuaXQudjEuQ2xlYW5PdXRVbml0UmVxdWVzdBoqLnNhbHRvLm5l",
                  "YnVsYS51bml0LnYxLkNsZWFuT3V0VW5pdFJlc3BvbnNlEl8KCk1vdmVJblVu",
                  "aXQSJy5zYWx0by5uZWJ1bGEudW5pdC52MS5Nb3ZlSW5Vbml0UmVxdWVzdBoo",
                  "LnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVJblVuaXRSZXNwb25zZRJiCgtN",
                  "b3ZlT3V0VW5pdBIoLnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVPdXRVbml0",
                  "UmVxdWVzdBopLnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVPdXRVbml0UmVz",
                  "cG9uc2USVwoMQ3JlYXRlUG9saWN5Eikuc2FsdG8ubmVidWxhLnVuaXQudjEu",
                  "Q3JlYXRlUG9saWN5UmVxdWVzdBocLnNhbHRvLm5lYnVsYS51bml0LnYxLlBv",
                  "bGljeRJRCglHZXRQb2xpY3kSJi5zYWx0by5uZWJ1bGEudW5pdC52MS5HZXRQ",
                  "b2xpY3lSZXF1ZXN0Ghwuc2FsdG8ubmVidWxhLnVuaXQudjEuUG9saWN5EmUK",
                  "DExpc3RQb2xpY2llcxIpLnNhbHRvLm5lYnVsYS51bml0LnYxLkxpc3RQb2xp",
                  "Y2llc1JlcXVlc3QaKi5zYWx0by5uZWJ1bGEudW5pdC52MS5MaXN0UG9saWNp",
                  "ZXNSZXNwb25zZRJXCgxVcGRhdGVQb2xpY3kSKS5zYWx0by5uZWJ1bGEudW5p",
                  "dC52MS5VcGRhdGVQb2xpY3lSZXF1ZXN0Ghwuc2FsdG8ubmVidWxhLnVuaXQu",
                  "djEuUG9saWN5ElEKDERlbGV0ZVBvbGljeRIpLnNhbHRvLm5lYnVsYS51bml0",
                  "LnYxLkRlbGV0ZVBvbGljeVJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1w",
                  "dHkSbgoPVGVzdFBlcm1pc3Npb25zEiwuc2FsdG8ubmVidWxhLnVuaXQudjEu",
                  "VGVzdFBlcm1pc3Npb25zUmVxdWVzdBotLnNhbHRvLm5lYnVsYS51bml0LnYx",
                  "LlRlc3RQZXJtaXNzaW9uc1Jlc3BvbnNlQsgBChxjb20uc2FsdG9hcGlzLm5l",
                  "YnVsYS51bml0LnYxQglVbml0UHJvdG9QAVo+Z2l0aHViLmNvbS9zYWx0b2Fw",
                  "aXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS91bml0L3YxO3VuaXSq",
                  "AhhTYWx0b2FwaXMuTmVidWxhLlVuaXQuVjHKAhhTYWx0b2FwaXNcTmVidWxh",
                  "XFVuaXRcVjHiAiRHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXFVuaXRc",
                  "VjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Unit), Unit.Parser, ["Name", "DisplayName", "MoveInTime", "MoveOutTime", "PrivacySettings", "DefaultAccessRights", "Manager"], ["Manager"], null, null, [new(typeof(Unit.Types.PrivacySettings), Unit.Types.PrivacySettings.Parser, ["Enabled"], null, null, null, null)]),
            new(typeof(Policy), Policy.Parser, ["Name", "Member", "Roles"], null, null, null, null),
            new(typeof(CreateUnitRequest), CreateUnitRequest.Parser, ["Parent", "UnitId", "Unit"], ["UnitId"], null, null, null),
            new(typeof(GetUnitRequest), GetUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListUnitsRequest), ListUnitsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListUnitsResponse), ListUnitsResponse.Parser, ["Units", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateUnitRequest), UpdateUnitRequest.Parser, ["Unit", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteUnitRequest), DeleteUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CleanOutUnitRequest), CleanOutUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CleanOutUnitResponse), CleanOutUnitResponse.Parser, null, null, null, null, null),
            new(typeof(MoveInUnitRequest), MoveInUnitRequest.Parser, ["Name", "Occupants"], null, null, null, [new(typeof(MoveInUnitRequest.Types.Occupant), MoveInUnitRequest.Types.Occupant.Parser, ["GivenName", "FamilyName", "Email", "AccessRights", "IamRoles"], ["FamilyName", "Email"], null, null, null)]),
            new(typeof(MoveInUnitResponse), MoveInUnitResponse.Parser, null, null, null, null, null),
            new(typeof(MoveOutUnitRequest), MoveOutUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(MoveOutUnitResponse), MoveOutUnitResponse.Parser, null, null, null, null, null),
            new(typeof(CreatePolicyRequest), CreatePolicyRequest.Parser, ["Parent", "PolicyId", "Policy"], null, null, null, null),
            new(typeof(GetPolicyRequest), GetPolicyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListPoliciesRequest), ListPoliciesRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListPoliciesResponse), ListPoliciesResponse.Parser, ["Policies", "NextPageToken"], null, null, null, null),
            new(typeof(UpdatePolicyRequest), UpdatePolicyRequest.Parser, ["Policy", "UpdateMask"], null, null, null, null),
            new(typeof(DeletePolicyRequest), DeletePolicyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(TestPermissionsRequest), TestPermissionsRequest.Parser, ["Unit", "Permissions"], null, null, null, null),
            new(typeof(TestPermissionsResponse), TestPermissionsResponse.Parser, ["Permissions"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
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
        private readonly static string ManagerDefaultValue = "";

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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (DisplayName != other.DisplayName) return false;
            if (!Equals(MoveInTime, other.MoveInTime)) return false;
            if (!Equals(MoveOutTime, other.MoveOutTime)) return false;
            if (!Equals(PrivacySettings, other.PrivacySettings)) return false;
            if (!defaultAccessRights_.Equals(other.defaultAccessRights_)) return false;
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
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (moveInTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(MoveInTime);
            }
            if (moveOutTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(MoveOutTime);
            }
            if (privacySettings_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(PrivacySettings);
            }
            size += defaultAccessRights_.CalculateSize(_repeated_defaultAccessRights_codec);
            if (HasManager)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Manager);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Unit other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
            }
            if (other.moveInTime_ != null)
            {
                if (moveInTime_ == null)
                {
                    MoveInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                MoveInTime.MergeFrom(other.MoveInTime);
            }
            if (other.moveOutTime_ != null)
            {
                if (moveOutTime_ == null)
                {
                    MoveOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                MoveOutTime.MergeFrom(other.MoveOutTime);
            }
            if (other.privacySettings_ != null)
            {
                if (privacySettings_ == null)
                {
                    PrivacySettings = new Types.PrivacySettings();
                }
                PrivacySettings.MergeFrom(other.PrivacySettings);
            }
            defaultAccessRights_.Add(other.defaultAccessRights_);
            if (other.HasManager)
            {
                Manager = other.Manager;
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
                            if (moveInTime_ == null)
                            {
                                MoveInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(MoveInTime);
                            break;
                        }
                    case 34:
                        {
                            if (moveOutTime_ == null)
                            {
                                MoveOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(MoveOutTime);
                            break;
                        }
                    case 42:
                        {
                            if (privacySettings_ == null)
                            {
                                PrivacySettings = new Types.PrivacySettings();
                            }
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

        #region Nested types
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
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (Enabled != other.Enabled) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Enabled != false) hash ^= Enabled.GetHashCode();
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
                    if (Enabled != false)
                    {
                        size += 1 + 1;
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(PrivacySettings other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.Enabled != false)
                    {
                        Enabled = other.Enabled;
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
        #endregion

    }

    /// <summary>
    /// Representation of an IAM policy inside the API
    /// </summary>
    public sealed partial class Policy : IMessage<Policy>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Policy> _parser = new(() => new Policy());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Policy> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Policy()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Policy(Policy other) : this()
        {
            name_ = other.name_;
            member_ = other.member_;
            roles_ = other.roles_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Policy Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the policy. It must have the format of
        /// `installations/*/units/*/iam-policies`, for example:
        /// `installations/surelock-homes-hq/units/101/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "member" field.</summary>
        public const int MemberFieldNumber = 2;
        private string member_ = "";

        /// <summary>
        /// Specifies the identity requesting access to this resource.
        /// </summary>
        public string Member
        {
            get { return member_; }
            set
            {
                member_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "roles" field.</summary>
        public const int RolesFieldNumber = 3;
        private static readonly FieldCodec<string> _repeated_roles_codec
            = FieldCodec.ForString(26);
        private readonly RepeatedField<string> roles_ = [];

        /// <summary>
        /// The names of the roles this policy grants.
        /// </summary>
        public RepeatedField<string> Roles
        {
            get { return roles_; }
        }

        public override bool Equals(object other) => Equals(other as Policy);
        public bool Equals(Policy other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (Member != other.Member) return false;
            if (!roles_.Equals(other.roles_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Member.Length != 0) hash ^= Member.GetHashCode();
            hash ^= roles_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Member.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Member);
      }
      roles_.WriteTo(output, _repeated_roles_codec);
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
            if (Member.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Member);
            }
            roles_.WriteTo(ref output, _repeated_roles_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (Member.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Member);
            }
            size += roles_.CalculateSize(_repeated_roles_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Policy other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Member.Length != 0)
            {
                Member = other.Member;
            }
            roles_.Add(other.roles_);
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
            Member = input.ReadString();
            break;
          }
          case 26: {
            roles_.AddEntriesFrom(input, _repeated_roles_codec);
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
                            Member = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            roles_.AddEntriesFrom(ref input, _repeated_roles_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateUnit`][salto.nebula.unit.v1.UnitService.CreateUnit]
    /// </summary>
    public sealed partial class CreateUnitRequest : IMessage<CreateUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateUnitRequest> _parser = new(() => new CreateUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateUnitRequest(CreateUnitRequest other) : this()
        {
            parent_ = other.parent_;
            unitId_ = other.unitId_;
            unit_ = other.unit_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateUnitRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource under which the unit is created. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "unit_id" field.</summary>
        public const int UnitIdFieldNumber = 2;
        private readonly static string UnitIdDefaultValue = "";

        private string unitId_;

        /// <summary>
        /// The unit id to use for this unit. If it's empty the server will
        /// autogenerate a unique identifier.
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

        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 3;
        private Unit unit_;

        /// <summary>
        /// The unit resource to be created. Client must not set the `Unit.name`
        /// field.
        /// </summary>
        public Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateUnitRequest);
        public bool Equals(CreateUnitRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (UnitId != other.UnitId) return false;
            if (!Equals(Unit, other.Unit)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasUnitId) hash ^= UnitId.GetHashCode();
            if (unit_ != null) hash ^= Unit.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (HasUnitId) {
        output.WriteRawTag(18);
        output.WriteString(UnitId);
      }
      if (unit_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Unit);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (HasUnitId)
            {
                output.WriteRawTag(18);
                output.WriteString(UnitId);
            }
            if (unit_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Unit);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (HasUnitId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(UnitId);
            }
            if (unit_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateUnitRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasUnitId)
            {
                UnitId = other.UnitId;
            }
            if (other.unit_ != null)
            {
                if (unit_ == null)
                {
                    Unit = new Unit();
                }
                Unit.MergeFrom(other.Unit);
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            UnitId = input.ReadString();
            break;
          }
          case 26: {
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            UnitId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (unit_ == null)
                            {
                                Unit = new Unit();
                            }
                            input.ReadMessage(Unit);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetUnit`][salto.nebula.unit.v1.UnitService.GetUnit]
    /// </summary>
    public sealed partial class GetUnitRequest : IMessage<GetUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetUnitRequest> _parser = new(() => new GetUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetUnitRequest(GetUnitRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetUnitRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested unit resource. For example:
        /// `installations/surelock-homes-hq/unit/101`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetUnitRequest);
        public bool Equals(GetUnitRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GetUnitRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListUnits`][salto.nebula.unit.v1.UnitService.ListUnits]
    /// </summary>
    public sealed partial class ListUnitsRequest : IMessage<ListUnitsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUnitsRequest> _parser = new(() => new ListUnitsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUnitsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUnitsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUnitsRequest(ListUnitsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUnitsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name, for example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 2;
        private int pageSize_;

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
            }
        }

        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 3;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 4;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which units to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "order_by" field.</summary>
        public const int OrderByFieldNumber = 5;
        private string orderBy_ = "";

        /// <summary>
        /// How the results should be sorted.
        /// </summary>
        public string OrderBy
        {
            get { return orderBy_; }
            set
            {
                orderBy_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListUnitsRequest);
        public bool Equals(ListUnitsRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            if (OrderBy != other.OrderBy) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (PageSize != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Filter);
            }
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(OrderBy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (PageSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            }
            if (PageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            }
            if (Filter.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            }
            if (OrderBy.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListUnitsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PageSize != 0)
            {
                PageSize = other.PageSize;
            }
            if (other.PageToken.Length != 0)
            {
                PageToken = other.PageToken;
            }
            if (other.Filter.Length != 0)
            {
                Filter = other.Filter;
            }
            if (other.OrderBy.Length != 0)
            {
                OrderBy = other.OrderBy;
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
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 26:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListUnits`][salto.nebula.unit.v1.UnitService.ListUnits]
    /// </summary>
    public sealed partial class ListUnitsResponse : IMessage<ListUnitsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUnitsResponse> _parser = new(() => new ListUnitsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUnitsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUnitsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUnitsResponse(ListUnitsResponse other) : this()
        {
            units_ = other.units_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUnitsResponse Clone() => new(this);
        /// <summary>Field number for the "units" field.</summary>
        public const int UnitsFieldNumber = 1;
        private static readonly FieldCodec<Unit> _repeated_units_codec
            = FieldCodec.ForMessage(10, Unit.Parser);
        private readonly RepeatedField<Unit> units_ = [];

        /// <summary>
        /// The field name should match the noun `units` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Unit> Units
        {
            get { return units_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListUnitsResponse);
        public bool Equals(ListUnitsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!units_.Equals(other.units_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= units_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
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
      units_.WriteTo(output, _repeated_units_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            units_.WriteTo(ref output, _repeated_units_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += units_.CalculateSize(_repeated_units_codec);
            if (NextPageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListUnitsResponse other)
        {
            if (other == null)
            {
                return;
            }
            units_.Add(other.units_);
            if (other.NextPageToken.Length != 0)
            {
                NextPageToken = other.NextPageToken;
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
            units_.AddEntriesFrom(input, _repeated_units_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
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
                            units_.AddEntriesFrom(ref input, _repeated_units_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdateUnit`][salto.nebula.unit.v1.UnitService.UpdateUnit]
    /// </summary>
    public sealed partial class UpdateUnitRequest : IMessage<UpdateUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateUnitRequest> _parser = new(() => new UpdateUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateUnitRequest(UpdateUnitRequest other) : this()
        {
            unit_ = other.unit_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateUnitRequest Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private Unit unit_;

        /// <summary>
        /// The unit resource which replaces the resource on the server.
        /// </summary>
        public Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateUnitRequest);
        public bool Equals(UpdateUnitRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Unit, other.Unit)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (unit_ != null) hash ^= Unit.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
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
      if (unit_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unit);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (unit_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Unit);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (unit_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            }
            if (updateMask_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateUnitRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.unit_ != null)
            {
                if (unit_ == null)
                {
                    Unit = new Unit();
                }
                Unit.MergeFrom(other.Unit);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null)
                {
                    UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                }
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            if (unit_ == null)
                            {
                                Unit = new Unit();
                            }
                            input.ReadMessage(Unit);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null)
                            {
                                UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            }
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`DeleteUnit`][salto.nebula.unit.v1.UnitService.DeleteUnit]
    /// </summary>
    public sealed partial class DeleteUnitRequest : IMessage<DeleteUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteUnitRequest> _parser = new(() => new DeleteUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteUnitRequest(DeleteUnitRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteUnitRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the unit to be deleted, for example:
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

        public override bool Equals(object other) => Equals(other as DeleteUnitRequest);
        public bool Equals(DeleteUnitRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeleteUnitRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CleanOutUnit`][salto.nebula.unit.v1.UnitService.CleanOutUnit]
    /// </summary>
    public sealed partial class CleanOutUnitRequest : IMessage<CleanOutUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CleanOutUnitRequest> _parser = new(() => new CleanOutUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CleanOutUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CleanOutUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CleanOutUnitRequest(CleanOutUnitRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CleanOutUnitRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the unit to be cleaned out. For example:
        /// `installations/salto-hq/units/101`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CleanOutUnitRequest);
        public bool Equals(CleanOutUnitRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CleanOutUnitRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`CleanOutUnit`][salto.nebula.unit.v1.UnitService.CleanOutUnit]
    /// </summary>
    public sealed partial class CleanOutUnitResponse : IMessage<CleanOutUnitResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CleanOutUnitResponse> _parser = new(() => new CleanOutUnitResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CleanOutUnitResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CleanOutUnitResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CleanOutUnitResponse(CleanOutUnitResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CleanOutUnitResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as CleanOutUnitResponse);
        public bool Equals(CleanOutUnitResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CleanOutUnitResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (!occupants_.Equals(other.occupants_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            hash ^= occupants_.GetHashCode();
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
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            size += occupants_.CalculateSize(_repeated_occupants_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(MoveInUnitRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
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

        #region Nested types
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
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (GivenName != other.GivenName) return false;
                    if (FamilyName != other.FamilyName) return false;
                    if (Email != other.Email) return false;
                    if (!accessRights_.Equals(other.accessRights_)) return false;
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
                    if (GivenName.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(GivenName);
                    }
                    if (HasFamilyName)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(FamilyName);
                    }
                    if (HasEmail)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Email);
                    }
                    size += accessRights_.CalculateSize(_repeated_accessRights_codec);
                    size += iamRoles_.CalculateSize(_repeated_iamRoles_codec);
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(Occupant other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.GivenName.Length != 0)
                    {
                        GivenName = other.GivenName;
                    }
                    if (other.HasFamilyName)
                    {
                        FamilyName = other.FamilyName;
                    }
                    if (other.HasEmail)
                    {
                        Email = other.Email;
                    }
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
        #endregion

    }

    /// <summary>
    /// The response message for [`MoveInUnit`][salto.nebula.unit.v1.UnitService.MoveInUnit]
    /// </summary>
    public sealed partial class MoveInUnitResponse : IMessage<MoveInUnitResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<MoveInUnitResponse> _parser = new(() => new MoveInUnitResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<MoveInUnitResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MoveInUnitResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public MoveInUnitResponse(MoveInUnitResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public MoveInUnitResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as MoveInUnitResponse);
        public bool Equals(MoveInUnitResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(MoveInUnitResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`MoveOutUnit`][salto.nebula.unit.v1.UnitService.MoveOutUnit]
    /// </summary>
    public sealed partial class MoveOutUnitRequest : IMessage<MoveOutUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<MoveOutUnitRequest> _parser = new(() => new MoveOutUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<MoveOutUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MoveOutUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public MoveOutUnitRequest(MoveOutUnitRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public MoveOutUnitRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the unit to be moved out. For example:
        /// `installations/salto-hq/units/101`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as MoveOutUnitRequest);
        public bool Equals(MoveOutUnitRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(MoveOutUnitRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`MoveOutUnit`][salto.nebula.unit.v1.UnitService.MoveOutUnit]
    /// </summary>
    public sealed partial class MoveOutUnitResponse : IMessage<MoveOutUnitResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<MoveOutUnitResponse> _parser = new(() => new MoveOutUnitResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<MoveOutUnitResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public MoveOutUnitResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public MoveOutUnitResponse(MoveOutUnitResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public MoveOutUnitResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as MoveOutUnitResponse);
        public bool Equals(MoveOutUnitResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(MoveOutUnitResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreatePolicy`][salto.nebula.unit.v1.UnitService.CreatePolicy]
    /// </summary>
    public sealed partial class CreatePolicyRequest : IMessage<CreatePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreatePolicyRequest> _parser = new(() => new CreatePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreatePolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreatePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreatePolicyRequest(CreatePolicyRequest other) : this()
        {
            parent_ = other.parent_;
            policyId_ = other.policyId_;
            policy_ = other.policy_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreatePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the policy. For
        /// example: `installations/salto-hq/units/101`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "policy_id" field.</summary>
        public const int PolicyIdFieldNumber = 2;
        private string policyId_ = "";

        /// <summary>
        /// The policy ID to use for policy. In case it's empty the server
        /// will autogenerate a unique identifier.
        /// </summary>
        public string PolicyId
        {
            get { return policyId_; }
            set
            {
                policyId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "policy" field.</summary>
        public const int PolicyFieldNumber = 3;
        private Policy policy_;

        /// <summary>
        /// The policy resource to be created. Client must not set the `Policy.name`
        /// field.
        /// </summary>
        public Policy Policy
        {
            get { return policy_; }
            set
            {
                policy_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreatePolicyRequest);
        public bool Equals(CreatePolicyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (PolicyId != other.PolicyId) return false;
            if (!Equals(Policy, other.Policy)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PolicyId.Length != 0) hash ^= PolicyId.GetHashCode();
            if (policy_ != null) hash ^= Policy.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PolicyId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PolicyId);
      }
      if (policy_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Policy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (PolicyId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(PolicyId);
            }
            if (policy_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Policy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (PolicyId.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PolicyId);
            }
            if (policy_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Policy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreatePolicyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PolicyId.Length != 0)
            {
                PolicyId = other.PolicyId;
            }
            if (other.policy_ != null)
            {
                if (policy_ == null)
                {
                    Policy = new Policy();
                }
                Policy.MergeFrom(other.Policy);
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            PolicyId = input.ReadString();
            break;
          }
          case 26: {
            if (policy_ == null) {
              Policy = new Saltoapis.Nebula.Unit.V1.Policy();
            }
            input.ReadMessage(Policy);
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            PolicyId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (policy_ == null)
                            {
                                Policy = new Policy();
                            }
                            input.ReadMessage(Policy);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetPolicy`][salto.nebula.unit.v1.UnitService.GetPolicy]
    /// </summary>
    public sealed partial class GetPolicyRequest : IMessage<GetPolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetPolicyRequest> _parser = new(() => new GetPolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetPolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetPolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetPolicyRequest(GetPolicyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetPolicyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested policy resource. For example:
        /// `installations/surelock-homes-hq/units/101/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetPolicyRequest);
        public bool Equals(GetPolicyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GetPolicyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListPolicies`][salto.nebula.unit.v1.UnitService.ListPolicies]
    /// </summary>
    public sealed partial class ListPoliciesRequest : IMessage<ListPoliciesRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListPoliciesRequest> _parser = new(() => new ListPoliciesRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListPoliciesRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListPoliciesRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListPoliciesRequest(ListPoliciesRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListPoliciesRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name, for example:
        /// `installations/surelock-homes-hq/units/101`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 2;
        private int pageSize_;

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
            }
        }

        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 3;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 4;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which policies to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "order_by" field.</summary>
        public const int OrderByFieldNumber = 5;
        private string orderBy_ = "";

        /// <summary>
        /// How the results should be sorted.
        /// </summary>
        public string OrderBy
        {
            get { return orderBy_; }
            set
            {
                orderBy_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListPoliciesRequest);
        public bool Equals(ListPoliciesRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            if (OrderBy != other.OrderBy) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (PageSize != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Filter);
            }
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(OrderBy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (PageSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            }
            if (PageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            }
            if (Filter.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            }
            if (OrderBy.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListPoliciesRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PageSize != 0)
            {
                PageSize = other.PageSize;
            }
            if (other.PageToken.Length != 0)
            {
                PageToken = other.PageToken;
            }
            if (other.Filter.Length != 0)
            {
                Filter = other.Filter;
            }
            if (other.OrderBy.Length != 0)
            {
                OrderBy = other.OrderBy;
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
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 26:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ListPolicies`][salto.nebula.unit.v1.UnitService.ListPolicies]
    /// </summary>
    public sealed partial class ListPoliciesResponse : IMessage<ListPoliciesResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListPoliciesResponse> _parser = new(() => new ListPoliciesResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListPoliciesResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListPoliciesResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListPoliciesResponse(ListPoliciesResponse other) : this()
        {
            policies_ = other.policies_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListPoliciesResponse Clone() => new(this);
        /// <summary>Field number for the "policies" field.</summary>
        public const int PoliciesFieldNumber = 1;
        private static readonly FieldCodec<Policy> _repeated_policies_codec
            = FieldCodec.ForMessage(10, Policy.Parser);
        private readonly RepeatedField<Policy> policies_ = [];

        /// <summary>
        /// The field name should match the noun `policies` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<Policy> Policies
        {
            get { return policies_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListPoliciesResponse);
        public bool Equals(ListPoliciesResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!policies_.Equals(other.policies_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= policies_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
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
      policies_.WriteTo(output, _repeated_policies_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            policies_.WriteTo(ref output, _repeated_policies_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += policies_.CalculateSize(_repeated_policies_codec);
            if (NextPageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListPoliciesResponse other)
        {
            if (other == null)
            {
                return;
            }
            policies_.Add(other.policies_);
            if (other.NextPageToken.Length != 0)
            {
                NextPageToken = other.NextPageToken;
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
            policies_.AddEntriesFrom(input, _repeated_policies_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
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
                            policies_.AddEntriesFrom(ref input, _repeated_policies_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdatePolicy`][salto.nebula.unit.v1.UnitService.UpdatePolicy]
    /// </summary>
    public sealed partial class UpdatePolicyRequest : IMessage<UpdatePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdatePolicyRequest> _parser = new(() => new UpdatePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdatePolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdatePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdatePolicyRequest(UpdatePolicyRequest other) : this()
        {
            policy_ = other.policy_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdatePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "policy" field.</summary>
        public const int PolicyFieldNumber = 1;
        private Policy policy_;

        /// <summary>
        /// The policy resource which replaces the resource on the server.
        /// </summary>
        public Policy Policy
        {
            get { return policy_; }
            set
            {
                policy_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdatePolicyRequest);
        public bool Equals(UpdatePolicyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Policy, other.Policy)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (policy_ != null) hash ^= Policy.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
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
      if (policy_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Policy);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (policy_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Policy);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (policy_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Policy);
            }
            if (updateMask_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdatePolicyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.policy_ != null)
            {
                if (policy_ == null)
                {
                    Policy = new Policy();
                }
                Policy.MergeFrom(other.Policy);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null)
                {
                    UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                }
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (policy_ == null) {
              Policy = new Saltoapis.Nebula.Unit.V1.Policy();
            }
            input.ReadMessage(Policy);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            if (policy_ == null)
                            {
                                Policy = new Policy();
                            }
                            input.ReadMessage(Policy);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null)
                            {
                                UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            }
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`DeletePolicy`][salto.nebula.unit.v1.UnitService.DeletePolicy]
    /// </summary>
    public sealed partial class DeletePolicyRequest : IMessage<DeletePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeletePolicyRequest> _parser = new(() => new DeletePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeletePolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeletePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeletePolicyRequest(DeletePolicyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeletePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the policy to be deleted, for example:
        /// `installations/surelock-homes-hq/units/101/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeletePolicyRequest);
        public bool Equals(DeletePolicyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeletePolicyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`TestPermissions`][salto.nebula.unit.v1.UnitService.TestPermissions]
    /// </summary>
    public sealed partial class TestPermissionsRequest : IMessage<TestPermissionsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TestPermissionsRequest> _parser = new(() => new TestPermissionsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TestPermissionsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TestPermissionsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TestPermissionsRequest(TestPermissionsRequest other) : this()
        {
            unit_ = other.unit_;
            permissions_ = other.permissions_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TestPermissionsRequest Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private string unit_ = "";

        /// <summary>
        /// The resource name for which the policy detail is being requested, for
        /// example: `installations/surelock-homes-hq/units/101`.
        /// </summary>
        public string Unit
        {
            get { return unit_; }
            set
            {
                unit_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "permissions" field.</summary>
        public const int PermissionsFieldNumber = 2;
        private static readonly FieldCodec<string> _repeated_permissions_codec
            = FieldCodec.ForString(18);
        private readonly RepeatedField<string> permissions_ = [];

        /// <summary>
        /// The set of permissions to check for the `resource_name`. Permissions with
        /// wildcards (such as '*' or 'nebula.access-point.*') are not allowed.
        /// </summary>
        public RepeatedField<string> Permissions
        {
            get { return permissions_; }
        }

        public override bool Equals(object other) => Equals(other as TestPermissionsRequest);
        public bool Equals(TestPermissionsRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Unit != other.Unit) return false;
            if (!permissions_.Equals(other.permissions_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Unit.Length != 0) hash ^= Unit.GetHashCode();
            hash ^= permissions_.GetHashCode();
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
      if (Unit.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Unit);
      }
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Unit.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Unit);
            }
            permissions_.WriteTo(ref output, _repeated_permissions_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Unit.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Unit);
            }
            size += permissions_.CalculateSize(_repeated_permissions_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(TestPermissionsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Unit.Length != 0)
            {
                Unit = other.Unit;
            }
            permissions_.Add(other.permissions_);
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
            Unit = input.ReadString();
            break;
          }
          case 18: {
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
                            Unit = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`TestPermissions`][salto.nebula.unit.v1.UnitService.TestPermissions]
    /// </summary>
    public sealed partial class TestPermissionsResponse : IMessage<TestPermissionsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TestPermissionsResponse> _parser = new(() => new TestPermissionsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TestPermissionsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TestPermissionsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TestPermissionsResponse(TestPermissionsResponse other) : this()
        {
            permissions_ = other.permissions_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TestPermissionsResponse Clone() => new(this);
        /// <summary>Field number for the "permissions" field.</summary>
        public const int PermissionsFieldNumber = 1;
        private static readonly FieldCodec<string> _repeated_permissions_codec
            = FieldCodec.ForString(10);
        private readonly RepeatedField<string> permissions_ = [];

        /// <summary>
        /// A subset of `TestPermissionsRequest.permissions` that the caller is
        /// allowed.
        /// </summary>
        public RepeatedField<string> Permissions
        {
            get { return permissions_; }
        }

        public override bool Equals(object other) => Equals(other as TestPermissionsResponse);
        public bool Equals(TestPermissionsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!permissions_.Equals(other.permissions_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= permissions_.GetHashCode();
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
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            permissions_.WriteTo(ref output, _repeated_permissions_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += permissions_.CalculateSize(_repeated_permissions_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(TestPermissionsResponse other)
        {
            if (other == null)
            {
                return;
            }
            permissions_.Add(other.permissions_);
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
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
                            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    #endregion

}
