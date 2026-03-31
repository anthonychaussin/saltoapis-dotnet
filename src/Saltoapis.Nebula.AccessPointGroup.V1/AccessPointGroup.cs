using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.AccessPointGroup.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/accesspointgroup/v1/access_point_group.proto</summary>
    public static partial class AccessPointGroupReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/accesspointgroup/v1/access_point_group.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static AccessPointGroupReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjlzYWx0by9uZWJ1bGEvYWNjZXNzcG9pbnRncm91cC92MS9hY2Nlc3NfcG9p",
                  "bnRfZ3JvdXAucHJvdG8SIHNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludGdyb3Vw",
                  "LnYxGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aIGdvb2dsZS9wcm90",
                  "b2J1Zi9maWVsZF9tYXNrLnByb3RvIjYKEEFjY2Vzc1BvaW50R3JvdXASDAoE",
                  "bmFtZRgBIAEoCRIUCgxkaXNwbGF5X25hbWUYAyABKAkiVwobQWNjZXNzUG9p",
                  "bnRHcm91cEFjY2Vzc1BvaW50EgwKBG5hbWUYASABKAkSFAoMYWNjZXNzX3Bv",
                  "aW50GAIgASgJEhQKDGRpc3BsYXlfbmFtZRgDIAEoCSK9AQodQ3JlYXRlQWNj",
                  "ZXNzUG9pbnRHcm91cFJlcXVlc3QSDgoGcGFyZW50GAEgASgJEiIKFWFjY2Vz",
                  "c19wb2ludF9ncm91cF9pZBgCIAEoCUgAiAEBEk4KEmFjY2Vzc19wb2ludF9n",
                  "cm91cBgDIAEoCzIyLnNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludGdyb3VwLnYx",
                  "LkFjY2Vzc1BvaW50R3JvdXBCGAoWX2FjY2Vzc19wb2ludF9ncm91cF9pZCIq",
                  "ChpHZXRBY2Nlc3NQb2ludEdyb3VwUmVxdWVzdBIMCgRuYW1lGAEgASgJIo0B",
                  "ChxMaXN0QWNjZXNzUG9pbnRHcm91cHNSZXF1ZXN0Eg4KBnBhcmVudBgBIAEo",
                  "CRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tlbhgDIAEoCRIOCgZm",
                  "aWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkYBSABKAkSFAoMc2hvd19kZWxldGVk",
                  "GAYgASgIIokBCh1MaXN0QWNjZXNzUG9pbnRHcm91cHNSZXNwb25zZRJPChNh",
                  "Y2Nlc3NfcG9pbnRfZ3JvdXBzGAEgAygLMjIuc2FsdG8ubmVidWxhLmFjY2Vz",
                  "c3BvaW50Z3JvdXAudjEuQWNjZXNzUG9pbnRHcm91cBIXCg9uZXh0X3BhZ2Vf",
                  "dG9rZW4YAiABKAkioAEKHVVwZGF0ZUFjY2Vzc1BvaW50R3JvdXBSZXF1ZXN0",
                  "Ek4KEmFjY2Vzc19wb2ludF9ncm91cBgBIAEoCzIyLnNhbHRvLm5lYnVsYS5h",
                  "Y2Nlc3Nwb2ludGdyb3VwLnYxLkFjY2Vzc1BvaW50R3JvdXASLwoLdXBkYXRl",
                  "X21hc2sYAiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIi0KHURl",
                  "bGV0ZUFjY2Vzc1BvaW50R3JvdXBSZXF1ZXN0EgwKBG5hbWUYASABKAkiogEK",
                  "KENyZWF0ZUFjY2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2ludFJlcXVlc3QSDgoG",
                  "cGFyZW50GAEgASgJEmYKH2FjY2Vzc19wb2ludF9ncm91cF9hY2Nlc3NfcG9p",
                  "bnQYAiABKAsyPS5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52MS5B",
                  "Y2Nlc3NQb2ludEdyb3VwQWNjZXNzUG9pbnQingEKLkJhdGNoQ3JlYXRlQWNj",
                  "ZXNzUG9pbnRHcm91cEFjY2Vzc1BvaW50c1JlcXVlc3QSDgoGcGFyZW50GAEg",
                  "ASgJElwKCHJlcXVlc3RzGAIgAygLMkouc2FsdG8ubmVidWxhLmFjY2Vzc3Bv",
                  "aW50Z3JvdXAudjEuQ3JlYXRlQWNjZXNzUG9pbnRHcm91cEFjY2Vzc1BvaW50",
                  "UmVxdWVzdCKaAQovQmF0Y2hDcmVhdGVBY2Nlc3NQb2ludEdyb3VwQWNjZXNz",
                  "UG9pbnRzUmVzcG9uc2USZwogYWNjZXNzX3BvaW50X2dyb3VwX2FjY2Vzc19w",
                  "b2ludHMYASADKAsyPS5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52",
                  "MS5BY2Nlc3NQb2ludEdyb3VwQWNjZXNzUG9pbnQiNQolR2V0QWNjZXNzUG9p",
                  "bnRHcm91cEFjY2Vzc1BvaW50UmVxdWVzdBIMCgRuYW1lGAEgASgJIoIBCidM",
                  "aXN0QWNjZXNzUG9pbnRHcm91cEFjY2Vzc1BvaW50c1JlcXVlc3QSDgoGcGFy",
                  "ZW50GAEgASgJEhEKCXBhZ2Vfc2l6ZRgCIAEoBRISCgpwYWdlX3Rva2VuGAMg",
                  "ASgJEg4KBmZpbHRlchgEIAEoCRIQCghvcmRlcl9ieRgFIAEoCSKsAQooTGlz",
                  "dEFjY2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2ludHNSZXNwb25zZRJnCiBhY2Nl",
                  "c3NfcG9pbnRfZ3JvdXBfYWNjZXNzX3BvaW50cxgBIAMoCzI9LnNhbHRvLm5l",
                  "YnVsYS5hY2Nlc3Nwb2ludGdyb3VwLnYxLkFjY2Vzc1BvaW50R3JvdXBBY2Nl",
                  "c3NQb2ludBIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAkiwwEKKFVwZGF0ZUFj",
                  "Y2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2ludFJlcXVlc3QSZgofYWNjZXNzX3Bv",
                  "aW50X2dyb3VwX2FjY2Vzc19wb2ludBgBIAEoCzI9LnNhbHRvLm5lYnVsYS5h",
                  "Y2Nlc3Nwb2ludGdyb3VwLnYxLkFjY2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2lu",
                  "dBIvCgt1cGRhdGVfbWFzaxgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVs",
                  "ZE1hc2siOAooRGVsZXRlQWNjZXNzUG9pbnRHcm91cEFjY2Vzc1BvaW50UmVx",
                  "dWVzdBIMCgRuYW1lGAEgASgJIp4BCi5CYXRjaERlbGV0ZUFjY2Vzc1BvaW50",
                  "R3JvdXBBY2Nlc3NQb2ludHNSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJcCghy",
                  "ZXF1ZXN0cxgCIAMoCzJKLnNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludGdyb3Vw",
                  "LnYxLkRlbGV0ZUFjY2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2ludFJlcXVlc3Qi",
                  "MQovQmF0Y2hEZWxldGVBY2Nlc3NQb2ludEdyb3VwQWNjZXNzUG9pbnRzUmVz",
                  "cG9uc2Uy4w8KF0FjY2Vzc1BvaW50R3JvdXBTZXJ2aWNlEo0BChZDcmVhdGVB",
                  "Y2Nlc3NQb2ludEdyb3VwEj8uc2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50Z3Jv",
                  "dXAudjEuQ3JlYXRlQWNjZXNzUG9pbnRHcm91cFJlcXVlc3QaMi5zYWx0by5u",
                  "ZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52MS5BY2Nlc3NQb2ludEdyb3VwEocB",
                  "ChNHZXRBY2Nlc3NQb2ludEdyb3VwEjwuc2FsdG8ubmVidWxhLmFjY2Vzc3Bv",
                  "aW50Z3JvdXAudjEuR2V0QWNjZXNzUG9pbnRHcm91cFJlcXVlc3QaMi5zYWx0",
                  "by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52MS5BY2Nlc3NQb2ludEdyb3Vw",
                  "EpgBChVMaXN0QWNjZXNzUG9pbnRHcm91cHMSPi5zYWx0by5uZWJ1bGEuYWNj",
                  "ZXNzcG9pbnRncm91cC52MS5MaXN0QWNjZXNzUG9pbnRHcm91cHNSZXF1ZXN0",
                  "Gj8uc2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50Z3JvdXAudjEuTGlzdEFjY2Vz",
                  "c1BvaW50R3JvdXBzUmVzcG9uc2USjQEKFlVwZGF0ZUFjY2Vzc1BvaW50R3Jv",
                  "dXASPy5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52MS5VcGRhdGVB",
                  "Y2Nlc3NQb2ludEdyb3VwUmVxdWVzdBoyLnNhbHRvLm5lYnVsYS5hY2Nlc3Nw",
                  "b2ludGdyb3VwLnYxLkFjY2Vzc1BvaW50R3JvdXASjQEKFkRlbGV0ZUFjY2Vz",
                  "c1BvaW50R3JvdXASPy5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52",
                  "MS5EZWxldGVBY2Nlc3NQb2ludEdyb3VwUmVxdWVzdBoyLnNhbHRvLm5lYnVs",
                  "YS5hY2Nlc3Nwb2ludGdyb3VwLnYxLkFjY2Vzc1BvaW50R3JvdXASrgEKIUNy",
                  "ZWF0ZUFjY2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2ludBJKLnNhbHRvLm5lYnVs",
                  "YS5hY2Nlc3Nwb2ludGdyb3VwLnYxLkNyZWF0ZUFjY2Vzc1BvaW50R3JvdXBB",
                  "Y2Nlc3NQb2ludFJlcXVlc3QaPS5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRn",
                  "cm91cC52MS5BY2Nlc3NQb2ludEdyb3VwQWNjZXNzUG9pbnQSzgEKJ0JhdGNo",
                  "Q3JlYXRlQWNjZXNzUG9pbnRHcm91cEFjY2Vzc1BvaW50cxJQLnNhbHRvLm5l",
                  "YnVsYS5hY2Nlc3Nwb2ludGdyb3VwLnYxLkJhdGNoQ3JlYXRlQWNjZXNzUG9p",
                  "bnRHcm91cEFjY2Vzc1BvaW50c1JlcXVlc3QaUS5zYWx0by5uZWJ1bGEuYWNj",
                  "ZXNzcG9pbnRncm91cC52MS5CYXRjaENyZWF0ZUFjY2Vzc1BvaW50R3JvdXBB",
                  "Y2Nlc3NQb2ludHNSZXNwb25zZRKoAQoeR2V0QWNjZXNzUG9pbnRHcm91cEFj",
                  "Y2Vzc1BvaW50Ekcuc2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50Z3JvdXAudjEu",
                  "R2V0QWNjZXNzUG9pbnRHcm91cEFjY2Vzc1BvaW50UmVxdWVzdBo9LnNhbHRv",
                  "Lm5lYnVsYS5hY2Nlc3Nwb2ludGdyb3VwLnYxLkFjY2Vzc1BvaW50R3JvdXBB",
                  "Y2Nlc3NQb2ludBK5AQogTGlzdEFjY2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2lu",
                  "dHMSSS5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52MS5MaXN0QWNj",
                  "ZXNzUG9pbnRHcm91cEFjY2Vzc1BvaW50c1JlcXVlc3QaSi5zYWx0by5uZWJ1",
                  "bGEuYWNjZXNzcG9pbnRncm91cC52MS5MaXN0QWNjZXNzUG9pbnRHcm91cEFj",
                  "Y2Vzc1BvaW50c1Jlc3BvbnNlEq4BCiFVcGRhdGVBY2Nlc3NQb2ludEdyb3Vw",
                  "QWNjZXNzUG9pbnQSSi5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52",
                  "MS5VcGRhdGVBY2Nlc3NQb2ludEdyb3VwQWNjZXNzUG9pbnRSZXF1ZXN0Gj0u",
                  "c2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50Z3JvdXAudjEuQWNjZXNzUG9pbnRH",
                  "cm91cEFjY2Vzc1BvaW50EocBCiFEZWxldGVBY2Nlc3NQb2ludEdyb3VwQWNj",
                  "ZXNzUG9pbnQSSi5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRncm91cC52MS5E",
                  "ZWxldGVBY2Nlc3NQb2ludEdyb3VwQWNjZXNzUG9pbnRSZXF1ZXN0GhYuZ29v",
                  "Z2xlLnByb3RvYnVmLkVtcHR5Es4BCidCYXRjaERlbGV0ZUFjY2Vzc1BvaW50",
                  "R3JvdXBBY2Nlc3NQb2ludHMSUC5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnRn",
                  "cm91cC52MS5CYXRjaERlbGV0ZUFjY2Vzc1BvaW50R3JvdXBBY2Nlc3NQb2lu",
                  "dHNSZXF1ZXN0GlEuc2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50Z3JvdXAudjEu",
                  "QmF0Y2hEZWxldGVBY2Nlc3NQb2ludEdyb3VwQWNjZXNzUG9pbnRzUmVzcG9u",
                  "c2VCnAIKKGNvbS5zYWx0b2FwaXMubmVidWxhLmFjY2Vzc3BvaW50Z3JvdXAu",
                  "djFCFUFjY2Vzc1BvaW50R3JvdXBQcm90b1ABWlZnaXRodWIuY29tL3NhbHRv",
                  "YXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL2FjY2Vzc3BvaW50",
                  "Z3JvdXAvdjE7YWNjZXNzcG9pbnRncm91cKoCJFNhbHRvYXBpcy5OZWJ1bGEu",
                  "QWNjZXNzUG9pbnRHcm91cC5WMcoCJFNhbHRvYXBpc1xOZWJ1bGFcQWNjZXNz",
                  "UG9pbnRHcm91cFxWMeICMEdQQk1ldGFkYXRhXFNhbHRvYXBpc1xOZWJ1bGFc",
                  "QWNjZXNzUG9pbnRHcm91cFxWMWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(AccessPointGroup), AccessPointGroup.Parser, ["Name", "DisplayName"], null, null, null, null),
            new(typeof(AccessPointGroupAccessPoint), AccessPointGroupAccessPoint.Parser, ["Name", "AccessPoint", "DisplayName"], null, null, null, null),
            new(typeof(CreateAccessPointGroupRequest), CreateAccessPointGroupRequest.Parser, ["Parent", "AccessPointGroupId", "AccessPointGroup"], ["AccessPointGroupId"], null, null, null),
            new(typeof(GetAccessPointGroupRequest), GetAccessPointGroupRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListAccessPointGroupsRequest), ListAccessPointGroupsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy", "ShowDeleted"], null, null, null, null),
            new(typeof(ListAccessPointGroupsResponse), ListAccessPointGroupsResponse.Parser, ["AccessPointGroups", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateAccessPointGroupRequest), UpdateAccessPointGroupRequest.Parser, ["AccessPointGroup", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteAccessPointGroupRequest), DeleteAccessPointGroupRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CreateAccessPointGroupAccessPointRequest), CreateAccessPointGroupAccessPointRequest.Parser, ["Parent", "AccessPointGroupAccessPoint"], null, null, null, null),
            new(typeof(BatchCreateAccessPointGroupAccessPointsRequest), BatchCreateAccessPointGroupAccessPointsRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchCreateAccessPointGroupAccessPointsResponse), BatchCreateAccessPointGroupAccessPointsResponse.Parser, ["AccessPointGroupAccessPoints"], null, null, null, null),
            new(typeof(GetAccessPointGroupAccessPointRequest), GetAccessPointGroupAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListAccessPointGroupAccessPointsRequest), ListAccessPointGroupAccessPointsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListAccessPointGroupAccessPointsResponse), ListAccessPointGroupAccessPointsResponse.Parser, ["AccessPointGroupAccessPoints", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateAccessPointGroupAccessPointRequest), UpdateAccessPointGroupAccessPointRequest.Parser, ["AccessPointGroupAccessPoint", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteAccessPointGroupAccessPointRequest), DeleteAccessPointGroupAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BatchDeleteAccessPointGroupAccessPointsRequest), BatchDeleteAccessPointGroupAccessPointsRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchDeleteAccessPointGroupAccessPointsResponse), BatchDeleteAccessPointGroupAccessPointsResponse.Parser, null, null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The access point group object
    /// </summary>
    public sealed partial class AccessPointGroup : IMessage<AccessPointGroup>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointGroup> _parser = new(() => new AccessPointGroup());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointGroup> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointGroup()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointGroup(AccessPointGroup other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointGroup Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the access point group. It must have the format of
        /// `installations/*/access-point-groups/*`. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
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
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the access point group.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointGroup);
        public bool Equals(AccessPointGroup other)
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
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
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
                output.WriteRawTag(26);
                output.WriteString(DisplayName);
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
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AccessPointGroup other)
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
          case 26: {
            DisplayName = input.ReadString();
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
                    case 26:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The access point group's access point association
    /// </summary>
    public sealed partial class AccessPointGroupAccessPoint : IMessage<AccessPointGroupAccessPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointGroupAccessPoint> _parser = new(() => new AccessPointGroupAccessPoint());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointGroupAccessPoint> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointGroupAccessPoint()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointGroupAccessPoint(AccessPointGroupAccessPoint other) : this()
        {
            name_ = other.name_;
            accessPoint_ = other.accessPoint_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointGroupAccessPoint Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the access point groups's access point association. It
        /// must have the format of
        /// `installations/*/access-point-groups/*/access-points/*`. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 2;
        private string accessPoint_ = "";

        /// <summary>
        /// The access point resource name to bind as an association to the parent
        /// access point group. For example:
        /// `installations/surelock-homes-hq/access-points/baker-street-entrance`.
        /// </summary>
        public string AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the associated entity. In this case an access point.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointGroupAccessPoint);
        public bool Equals(AccessPointGroupAccessPoint other)
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
            if (AccessPoint != other.AccessPoint) return false;
            if (DisplayName != other.DisplayName) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (AccessPoint.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessPoint);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
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
            if (AccessPoint.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessPoint);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DisplayName);
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
            if (AccessPoint.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessPoint);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AccessPointGroupAccessPoint other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.AccessPoint.Length != 0)
            {
                AccessPoint = other.AccessPoint;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
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
            AccessPoint = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
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
                            AccessPoint = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateAccessPointGroup`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.CreateAccessPointGroup]
    /// </summary>
    public sealed partial class CreateAccessPointGroupRequest : IMessage<CreateAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessPointGroupRequest> _parser = new(() => new CreateAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessPointGroupRequest(CreateAccessPointGroupRequest other) : this()
        {
            parent_ = other.parent_;
            accessPointGroupId_ = other.accessPointGroupId_;
            accessPointGroup_ = other.accessPointGroup_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the access point
        /// group. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point_group_id" field.</summary>
        public const int AccessPointGroupIdFieldNumber = 2;
        private readonly static string AccessPointGroupIdDefaultValue = "";

        private string accessPointGroupId_;

        /// <summary>
        /// The access point group ID to use for this access point group. In
        /// case it's empty the server will autogenerate a unique identifier.
        /// </summary>
        public string AccessPointGroupId
        {
            get { return accessPointGroupId_ ?? AccessPointGroupIdDefaultValue; }
            set
            {
                accessPointGroupId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "access_point_group_id" field is set</summary>
        public bool HasAccessPointGroupId
        {
            get { return accessPointGroupId_ != null; }
        }

        /// <summary>Clears the value of the "access_point_group_id" field</summary>
        public void ClearAccessPointGroupId()
        {
            accessPointGroupId_ = null;
        }

        /// <summary>Field number for the "access_point_group" field.</summary>
        public const int AccessPointGroupFieldNumber = 3;
        private AccessPointGroup accessPointGroup_;

        /// <summary>
        /// The access point group resource to be created. Client must not set the
        /// `AccessPointGroup.name` field.
        /// </summary>
        public AccessPointGroup AccessPointGroup
        {
            get { return accessPointGroup_; }
            set
            {
                accessPointGroup_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessPointGroupRequest);
        public bool Equals(CreateAccessPointGroupRequest other)
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
            if (AccessPointGroupId != other.AccessPointGroupId) return false;
            if (!Equals(AccessPointGroup, other.AccessPointGroup)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasAccessPointGroupId) hash ^= AccessPointGroupId.GetHashCode();
            if (accessPointGroup_ != null) hash ^= AccessPointGroup.GetHashCode();
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
      if (HasAccessPointGroupId) {
        output.WriteRawTag(18);
        output.WriteString(AccessPointGroupId);
      }
      if (accessPointGroup_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AccessPointGroup);
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
            if (HasAccessPointGroupId)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessPointGroupId);
            }
            if (accessPointGroup_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(AccessPointGroup);
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
            if (HasAccessPointGroupId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessPointGroupId);
            }
            if (accessPointGroup_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroup);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateAccessPointGroupRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasAccessPointGroupId)
            {
                AccessPointGroupId = other.AccessPointGroupId;
            }
            if (other.accessPointGroup_ != null)
            {
                if (accessPointGroup_ == null)
                {
                    AccessPointGroup = new AccessPointGroup();
                }
                AccessPointGroup.MergeFrom(other.AccessPointGroup);
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
            AccessPointGroupId = input.ReadString();
            break;
          }
          case 26: {
            if (accessPointGroup_ == null) {
              AccessPointGroup = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroup();
            }
            input.ReadMessage(AccessPointGroup);
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
                            AccessPointGroupId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (accessPointGroup_ == null)
                            {
                                AccessPointGroup = new AccessPointGroup();
                            }
                            input.ReadMessage(AccessPointGroup);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetAccessPointGroup`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.GetAccessPointGroup]
    /// </summary>
    public sealed partial class GetAccessPointGroupRequest : IMessage<GetAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetAccessPointGroupRequest> _parser = new(() => new GetAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetAccessPointGroupRequest(GetAccessPointGroupRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested access point group resource. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetAccessPointGroupRequest);
        public bool Equals(GetAccessPointGroupRequest other)
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

        public void MergeFrom(GetAccessPointGroupRequest other)
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
    /// The request message for [`ListAccessPointGroups`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.ListAccessPointGroups]
    /// </summary>
    public sealed partial class ListAccessPointGroupsRequest : IMessage<ListAccessPointGroupsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessPointGroupsRequest> _parser = new(() => new ListAccessPointGroupsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessPointGroupsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessPointGroupsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessPointGroupsRequest(ListAccessPointGroupsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            showDeleted_ = other.showDeleted_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessPointGroupsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example: `installations/surelock-homes-hq`.
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
        /// A filter that chooses which access point groups to return.
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

        /// <summary>Field number for the "show_deleted" field.</summary>
        public const int ShowDeletedFieldNumber = 6;
        private bool showDeleted_;

        /// <summary>
        /// Show deleted access point groups.
        /// </summary>
        public bool ShowDeleted
        {
            get { return showDeleted_; }
            set
            {
                showDeleted_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ListAccessPointGroupsRequest);
        public bool Equals(ListAccessPointGroupsRequest other)
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
            if (ShowDeleted != other.ShowDeleted) return false;
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
            if (ShowDeleted != false) hash ^= ShowDeleted.GetHashCode();
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
      if (ShowDeleted != false) {
        output.WriteRawTag(48);
        output.WriteBool(ShowDeleted);
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
            if (ShowDeleted != false)
            {
                output.WriteRawTag(48);
                output.WriteBool(ShowDeleted);
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
            if (ShowDeleted != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListAccessPointGroupsRequest other)
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
            if (other.ShowDeleted != false)
            {
                ShowDeleted = other.ShowDeleted;
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
          case 48: {
            ShowDeleted = input.ReadBool();
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
                    case 48:
                        {
                            ShowDeleted = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ListAccessPointGroups`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.ListAccessPointGroups]
    /// </summary>
    public sealed partial class ListAccessPointGroupsResponse : IMessage<ListAccessPointGroupsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessPointGroupsResponse> _parser = new(() => new ListAccessPointGroupsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessPointGroupsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessPointGroupsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessPointGroupsResponse(ListAccessPointGroupsResponse other) : this()
        {
            accessPointGroups_ = other.accessPointGroups_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessPointGroupsResponse Clone() => new(this);
        /// <summary>Field number for the "access_point_groups" field.</summary>
        public const int AccessPointGroupsFieldNumber = 1;
        private static readonly FieldCodec<AccessPointGroup> _repeated_accessPointGroups_codec
            = FieldCodec.ForMessage(10, AccessPointGroup.Parser);
        private readonly RepeatedField<AccessPointGroup> accessPointGroups_ = [];

        /// <summary>
        /// The field name should match the noun `access_point_groups` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<AccessPointGroup> AccessPointGroups
        {
            get { return accessPointGroups_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessPointGroupsResponse);
        public bool Equals(ListAccessPointGroupsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessPointGroups_.Equals(other.accessPointGroups_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessPointGroups_.GetHashCode();
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
      accessPointGroups_.WriteTo(output, _repeated_accessPointGroups_codec);
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
            accessPointGroups_.WriteTo(ref output, _repeated_accessPointGroups_codec);
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
            size += accessPointGroups_.CalculateSize(_repeated_accessPointGroups_codec);
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

        public void MergeFrom(ListAccessPointGroupsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessPointGroups_.Add(other.accessPointGroups_);
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
            accessPointGroups_.AddEntriesFrom(input, _repeated_accessPointGroups_codec);
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
                            accessPointGroups_.AddEntriesFrom(ref input, _repeated_accessPointGroups_codec);
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
    /// The request message for [`UpdateAccessPointGroup`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.UpdateAccessPointGroup]
    /// </summary>
    public sealed partial class UpdateAccessPointGroupRequest : IMessage<UpdateAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessPointGroupRequest> _parser = new(() => new UpdateAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessPointGroupRequest(UpdateAccessPointGroupRequest other) : this()
        {
            accessPointGroup_ = other.accessPointGroup_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "access_point_group" field.</summary>
        public const int AccessPointGroupFieldNumber = 1;
        private AccessPointGroup accessPointGroup_;

        /// <summary>
        /// The access point group resource which replaces the resource on the server.
        /// </summary>
        public AccessPointGroup AccessPointGroup
        {
            get { return accessPointGroup_; }
            set
            {
                accessPointGroup_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessPointGroupRequest);
        public bool Equals(UpdateAccessPointGroupRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(AccessPointGroup, other.AccessPointGroup)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPointGroup_ != null) hash ^= AccessPointGroup.GetHashCode();
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
      if (accessPointGroup_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPointGroup);
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
            if (accessPointGroup_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPointGroup);
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
            if (accessPointGroup_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroup);
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

        public void MergeFrom(UpdateAccessPointGroupRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.accessPointGroup_ != null)
            {
                if (accessPointGroup_ == null)
                {
                    AccessPointGroup = new AccessPointGroup();
                }
                AccessPointGroup.MergeFrom(other.AccessPointGroup);
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
            if (accessPointGroup_ == null) {
              AccessPointGroup = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroup();
            }
            input.ReadMessage(AccessPointGroup);
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
                            if (accessPointGroup_ == null)
                            {
                                AccessPointGroup = new AccessPointGroup();
                            }
                            input.ReadMessage(AccessPointGroup);
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
    /// The request message for [`DeleteAccessPointGroup`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.DeleteAccessPointGroup]
    /// </summary>
    public sealed partial class DeleteAccessPointGroupRequest : IMessage<DeleteAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteAccessPointGroupRequest> _parser = new(() => new DeleteAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteAccessPointGroupRequest(DeleteAccessPointGroupRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the access point group to be soft deleted. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteAccessPointGroupRequest);
        public bool Equals(DeleteAccessPointGroupRequest other)
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

        public void MergeFrom(DeleteAccessPointGroupRequest other)
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
    /// The request message for [`CreateAccessPointGroupAccessPoint`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.CreateAccessPointGroupAccessPoint]
    /// </summary>
    public sealed partial class CreateAccessPointGroupAccessPointRequest : IMessage<CreateAccessPointGroupAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessPointGroupAccessPointRequest> _parser = new(() => new CreateAccessPointGroupAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessPointGroupAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessPointGroupAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessPointGroupAccessPointRequest(CreateAccessPointGroupAccessPointRequest other) : this()
        {
            parent_ = other.parent_;
            accessPointGroupAccessPoint_ = other.accessPointGroupAccessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessPointGroupAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access point group's
        /// access point association is to be created. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point_group_access_point" field.</summary>
        public const int AccessPointGroupAccessPointFieldNumber = 2;
        private AccessPointGroupAccessPoint accessPointGroupAccessPoint_;

        /// <summary>
        /// The access point group's access point association resource to be created.
        /// Client must not set the `AccessPointGroupAccessPoint.name` field.
        /// </summary>
        public AccessPointGroupAccessPoint AccessPointGroupAccessPoint
        {
            get { return accessPointGroupAccessPoint_; }
            set
            {
                accessPointGroupAccessPoint_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessPointGroupAccessPointRequest);
        public bool Equals(CreateAccessPointGroupAccessPointRequest other)
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
            if (!Equals(AccessPointGroupAccessPoint, other.AccessPointGroupAccessPoint)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessPointGroupAccessPoint_ != null) hash ^= AccessPointGroupAccessPoint.GetHashCode();
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
      if (accessPointGroupAccessPoint_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroupAccessPoint);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateAccessPointGroupAccessPointRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.accessPointGroupAccessPoint_ != null)
            {
                if (accessPointGroupAccessPoint_ == null)
                {
                    AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                }
                AccessPointGroupAccessPoint.MergeFrom(other.AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ == null) {
              AccessPointGroupAccessPoint = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroupAccessPoint();
            }
            input.ReadMessage(AccessPointGroupAccessPoint);
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
                            if (accessPointGroupAccessPoint_ == null)
                            {
                                AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                            }
                            input.ReadMessage(AccessPointGroupAccessPoint);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`BatchCreateAccessPointGroupAccessPoints`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.BatchCreateAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class BatchCreateAccessPointGroupAccessPointsRequest : IMessage<BatchCreateAccessPointGroupAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessPointGroupAccessPointsRequest> _parser = new(() => new BatchCreateAccessPointGroupAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessPointGroupAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateAccessPointGroupAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessPointGroupAccessPointsRequest(BatchCreateAccessPointGroupAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessPointGroupAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access point group's
        /// access point associations are to be created. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "requests" field.</summary>
        public const int RequestsFieldNumber = 2;
        private static readonly FieldCodec<CreateAccessPointGroupAccessPointRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, CreateAccessPointGroupAccessPointRequest.Parser);
        private readonly RepeatedField<CreateAccessPointGroupAccessPointRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to create.
        /// A maximum of 100 access point group access points can be created in a batch.
        /// </summary>
        public RepeatedField<CreateAccessPointGroupAccessPointRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateAccessPointGroupAccessPointsRequest);
        public bool Equals(BatchCreateAccessPointGroupAccessPointsRequest other)
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
            if (!requests_.Equals(other.requests_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= requests_.GetHashCode();
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
      requests_.WriteTo(output, _repeated_requests_codec);
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
            requests_.WriteTo(ref output, _repeated_requests_codec);
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
            size += requests_.CalculateSize(_repeated_requests_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchCreateAccessPointGroupAccessPointsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            requests_.Add(other.requests_);
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
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
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
                            requests_.AddEntriesFrom(ref input, _repeated_requests_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`BatchCreateAccessPointGroupAccessPoints`][salto.nebula.user.v1.AccessPointGroupService.BatchCreateAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class BatchCreateAccessPointGroupAccessPointsResponse : IMessage<BatchCreateAccessPointGroupAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessPointGroupAccessPointsResponse> _parser = new(() => new BatchCreateAccessPointGroupAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessPointGroupAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateAccessPointGroupAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessPointGroupAccessPointsResponse(BatchCreateAccessPointGroupAccessPointsResponse other) : this()
        {
            accessPointGroupAccessPoints_ = other.accessPointGroupAccessPoints_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessPointGroupAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_point_group_access_points" field.</summary>
        public const int AccessPointGroupAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessPointGroupAccessPoint> _repeated_accessPointGroupAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessPointGroupAccessPoint.Parser);
        private readonly RepeatedField<AccessPointGroupAccessPoint> accessPointGroupAccessPoints_ = [];

        /// <summary>
        /// Access point group access points created.
        /// </summary>
        public RepeatedField<AccessPointGroupAccessPoint> AccessPointGroupAccessPoints
        {
            get { return accessPointGroupAccessPoints_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateAccessPointGroupAccessPointsResponse);
        public bool Equals(BatchCreateAccessPointGroupAccessPointsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessPointGroupAccessPoints_.Equals(other.accessPointGroupAccessPoints_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessPointGroupAccessPoints_.GetHashCode();
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
      accessPointGroupAccessPoints_.WriteTo(output, _repeated_accessPointGroupAccessPoints_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            accessPointGroupAccessPoints_.WriteTo(ref output, _repeated_accessPointGroupAccessPoints_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += accessPointGroupAccessPoints_.CalculateSize(_repeated_accessPointGroupAccessPoints_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchCreateAccessPointGroupAccessPointsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessPointGroupAccessPoints_.Add(other.accessPointGroupAccessPoints_);
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
            accessPointGroupAccessPoints_.AddEntriesFrom(input, _repeated_accessPointGroupAccessPoints_codec);
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
                            accessPointGroupAccessPoints_.AddEntriesFrom(ref input, _repeated_accessPointGroupAccessPoints_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetAccessPointGroupAccessPoint`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.GetAccessPointGroupAccessPoint]
    /// </summary>
    public sealed partial class GetAccessPointGroupAccessPointRequest : IMessage<GetAccessPointGroupAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetAccessPointGroupAccessPointRequest> _parser = new(() => new GetAccessPointGroupAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetAccessPointGroupAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetAccessPointGroupAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetAccessPointGroupAccessPointRequest(GetAccessPointGroupAccessPointRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetAccessPointGroupAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested access point group's access point association
        /// resource. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetAccessPointGroupAccessPointRequest);
        public bool Equals(GetAccessPointGroupAccessPointRequest other)
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

        public void MergeFrom(GetAccessPointGroupAccessPointRequest other)
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
    /// The request message for [`ListAccessPointGroupAccessPoints`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.ListAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class ListAccessPointGroupAccessPointsRequest : IMessage<ListAccessPointGroupAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessPointGroupAccessPointsRequest> _parser = new(() => new ListAccessPointGroupAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessPointGroupAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessPointGroupAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessPointGroupAccessPointsRequest(ListAccessPointGroupAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessPointGroupAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
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
        /// A filter that chooses which access point group's access point
        /// associations to return.
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

        public override bool Equals(object other) => Equals(other as ListAccessPointGroupAccessPointsRequest);
        public bool Equals(ListAccessPointGroupAccessPointsRequest other)
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

        public void MergeFrom(ListAccessPointGroupAccessPointsRequest other)
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
    /// The request message for [`ListAccessPointGroupAccessPoints`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.ListAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class ListAccessPointGroupAccessPointsResponse : IMessage<ListAccessPointGroupAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessPointGroupAccessPointsResponse> _parser = new(() => new ListAccessPointGroupAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessPointGroupAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessPointGroupAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessPointGroupAccessPointsResponse(ListAccessPointGroupAccessPointsResponse other) : this()
        {
            accessPointGroupAccessPoints_ = other.accessPointGroupAccessPoints_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessPointGroupAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_point_group_access_points" field.</summary>
        public const int AccessPointGroupAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessPointGroupAccessPoint> _repeated_accessPointGroupAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessPointGroupAccessPoint.Parser);
        private readonly RepeatedField<AccessPointGroupAccessPoint> accessPointGroupAccessPoints_ = [];

        /// <summary>
        /// The field name should match the noun `access_point_group_access_points`
        /// in the method name. There will be a maximum number of items returned
        /// based on the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessPointGroupAccessPoint> AccessPointGroupAccessPoints
        {
            get { return accessPointGroupAccessPoints_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessPointGroupAccessPointsResponse);
        public bool Equals(ListAccessPointGroupAccessPointsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessPointGroupAccessPoints_.Equals(other.accessPointGroupAccessPoints_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessPointGroupAccessPoints_.GetHashCode();
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
      accessPointGroupAccessPoints_.WriteTo(output, _repeated_accessPointGroupAccessPoints_codec);
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
            accessPointGroupAccessPoints_.WriteTo(ref output, _repeated_accessPointGroupAccessPoints_codec);
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
            size += accessPointGroupAccessPoints_.CalculateSize(_repeated_accessPointGroupAccessPoints_codec);
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

        public void MergeFrom(ListAccessPointGroupAccessPointsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessPointGroupAccessPoints_.Add(other.accessPointGroupAccessPoints_);
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
            accessPointGroupAccessPoints_.AddEntriesFrom(input, _repeated_accessPointGroupAccessPoints_codec);
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
                            accessPointGroupAccessPoints_.AddEntriesFrom(ref input, _repeated_accessPointGroupAccessPoints_codec);
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
    /// The request message for [`UpdateAccessPointGroupAccessPoint`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.UpdateAccessPointGroupAccessPoint]
    /// </summary>
    public sealed partial class UpdateAccessPointGroupAccessPointRequest : IMessage<UpdateAccessPointGroupAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessPointGroupAccessPointRequest> _parser = new(() => new UpdateAccessPointGroupAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessPointGroupAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessPointGroupAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessPointGroupAccessPointRequest(UpdateAccessPointGroupAccessPointRequest other) : this()
        {
            accessPointGroupAccessPoint_ = other.accessPointGroupAccessPoint_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessPointGroupAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "access_point_group_access_point" field.</summary>
        public const int AccessPointGroupAccessPointFieldNumber = 1;
        private AccessPointGroupAccessPoint accessPointGroupAccessPoint_;

        /// <summary>
        /// The access point group's access point resource which replaces the resource on
        /// the server.
        /// </summary>
        public AccessPointGroupAccessPoint AccessPointGroupAccessPoint
        {
            get { return accessPointGroupAccessPoint_; }
            set
            {
                accessPointGroupAccessPoint_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessPointGroupAccessPointRequest);
        public bool Equals(UpdateAccessPointGroupAccessPointRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(AccessPointGroupAccessPoint, other.AccessPointGroupAccessPoint)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPointGroupAccessPoint_ != null) hash ^= AccessPointGroupAccessPoint.GetHashCode();
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
      if (accessPointGroupAccessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroupAccessPoint);
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

        public void MergeFrom(UpdateAccessPointGroupAccessPointRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.accessPointGroupAccessPoint_ != null)
            {
                if (accessPointGroupAccessPoint_ == null)
                {
                    AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                }
                AccessPointGroupAccessPoint.MergeFrom(other.AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ == null) {
              AccessPointGroupAccessPoint = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroupAccessPoint();
            }
            input.ReadMessage(AccessPointGroupAccessPoint);
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
                            if (accessPointGroupAccessPoint_ == null)
                            {
                                AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                            }
                            input.ReadMessage(AccessPointGroupAccessPoint);
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
    /// The request message for [`DeleteAccessPointGroupAccessPoint`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.DeleteAccessPointGroupAccessPoint]
    /// </summary>
    public sealed partial class DeleteAccessPointGroupAccessPointRequest : IMessage<DeleteAccessPointGroupAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteAccessPointGroupAccessPointRequest> _parser = new(() => new DeleteAccessPointGroupAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteAccessPointGroupAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteAccessPointGroupAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteAccessPointGroupAccessPointRequest(DeleteAccessPointGroupAccessPointRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteAccessPointGroupAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the access point group's access point association to be
        /// deleted. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteAccessPointGroupAccessPointRequest);
        public bool Equals(DeleteAccessPointGroupAccessPointRequest other)
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

        public void MergeFrom(DeleteAccessPointGroupAccessPointRequest other)
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
    /// The request message for [`BatchDeleteAccessPointGroupAccessPoints`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.BatchDeleteAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class BatchDeleteAccessPointGroupAccessPointsRequest : IMessage<BatchDeleteAccessPointGroupAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteAccessPointGroupAccessPointsRequest> _parser = new(() => new BatchDeleteAccessPointGroupAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteAccessPointGroupAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteAccessPointGroupAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteAccessPointGroupAccessPointsRequest(BatchDeleteAccessPointGroupAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteAccessPointGroupAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The resource name of the access point group's access point associations to be deleted.
        /// For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "requests" field.</summary>
        public const int RequestsFieldNumber = 2;
        private static readonly FieldCodec<DeleteAccessPointGroupAccessPointRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, DeleteAccessPointGroupAccessPointRequest.Parser);
        private readonly RepeatedField<DeleteAccessPointGroupAccessPointRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to delete.
        /// A maximum of 100 access point group access points can be deleted in a batch.
        /// </summary>
        public RepeatedField<DeleteAccessPointGroupAccessPointRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchDeleteAccessPointGroupAccessPointsRequest);
        public bool Equals(BatchDeleteAccessPointGroupAccessPointsRequest other)
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
            if (!requests_.Equals(other.requests_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= requests_.GetHashCode();
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
      requests_.WriteTo(output, _repeated_requests_codec);
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
            requests_.WriteTo(ref output, _repeated_requests_codec);
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
            size += requests_.CalculateSize(_repeated_requests_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchDeleteAccessPointGroupAccessPointsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            requests_.Add(other.requests_);
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
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
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
                            requests_.AddEntriesFrom(ref input, _repeated_requests_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`BatchDeleteAccessPointGroupAccessPoints`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.BatchDeleteAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class BatchDeleteAccessPointGroupAccessPointsResponse : IMessage<BatchDeleteAccessPointGroupAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteAccessPointGroupAccessPointsResponse> _parser = new(() => new BatchDeleteAccessPointGroupAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteAccessPointGroupAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteAccessPointGroupAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteAccessPointGroupAccessPointsResponse(BatchDeleteAccessPointGroupAccessPointsResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteAccessPointGroupAccessPointsResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BatchDeleteAccessPointGroupAccessPointsResponse);
        public bool Equals(BatchDeleteAccessPointGroupAccessPointsResponse other)
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

        public void MergeFrom(BatchDeleteAccessPointGroupAccessPointsResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    #endregion

}
