using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.ElectronicKey.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/electronickey/v1/electronic_key.proto</summary>
    public static partial class ElectronicKeyReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/electronickey/v1/electronic_key.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static ElectronicKeyReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjJzYWx0by9uZWJ1bGEvZWxlY3Ryb25pY2tleS92MS9lbGVjdHJvbmljX2tl",
                  "eS5wcm90bxIdc2FsdG8ubmVidWxhLmVsZWN0cm9uaWNrZXkudjEaG2dvb2ds",
                  "ZS9wcm90b2J1Zi9lbXB0eS5wcm90bxogZ29vZ2xlL3Byb3RvYnVmL2ZpZWxk",
                  "X21hc2sucHJvdG8aJHNhbHRvL2xvbmdydW5uaW5nL3YxL29wZXJhdGlvbi5w",
                  "cm90bxonc2FsdG8vbmVidWxhL3R5cGUvZGV2aWNlX21ldGFkYXRhLnByb3Rv",
                  "ItgBCg1FbGVjdHJvbmljS2V5EgwKBG5hbWUYASABKAkSFAoMZGlzcGxheV9u",
                  "YW1lGAIgASgJEhMKC2luaXRpYWxpemVkGAMgASgIEhYKCWRldmljZV9pZBgE",
                  "IAEoCUgAiAEBEhAKCG91dGRhdGVkGAUgASgIEjoKD2RldmljZV9tZXRhZGF0",
                  "YRgGIAEoCzIhLnNhbHRvLm5lYnVsYS50eXBlLkRldmljZU1ldGFkYXRhEhEK",
                  "BHVzZXIYCCABKAlIAYgBAUIMCgpfZGV2aWNlX2lkQgcKBV91c2VyIqgBChpD",
                  "cmVhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBIOCgZwYXJlbnQYASABKAkSHgoR",
                  "ZWxlY3Ryb25pY19rZXlfaWQYAiABKAlIAIgBARJECg5lbGVjdHJvbmljX2tl",
                  "eRgDIAEoCzIsLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkVsZWN0",
                  "cm9uaWNLZXlCFAoSX2VsZWN0cm9uaWNfa2V5X2lkIicKF0dldEVsZWN0cm9u",
                  "aWNLZXlSZXF1ZXN0EgwKBG5hbWUYASABKAkidAoZTGlzdEVsZWN0cm9uaWNL",
                  "ZXlzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkSEQoJcGFnZV9zaXplGAIgASgF",
                  "EhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmlsdGVyGAQgASgJEhAKCG9yZGVy",
                  "X2J5GAUgASgJInwKGkxpc3RFbGVjdHJvbmljS2V5c1Jlc3BvbnNlEkUKD2Vs",
                  "ZWN0cm9uaWNfa2V5cxgBIAMoCzIsLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlj",
                  "a2V5LnYxLkVsZWN0cm9uaWNLZXkSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJ",
                  "IpMBChpVcGRhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBJECg5lbGVjdHJvbmlj",
                  "X2tleRgBIAEoCzIsLnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkVs",
                  "ZWN0cm9uaWNLZXkSLwoLdXBkYXRlX21hc2sYAiABKAsyGi5nb29nbGUucHJv",
                  "dG9idWYuRmllbGRNYXNrIioKGkRlbGV0ZUVsZWN0cm9uaWNLZXlSZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAkiOwoYQmluZEVsZWN0cm9uaWNLZXlSZXF1ZXN0EgwK",
                  "BG5hbWUYASABKAkSEQoJZGV2aWNlX2lkGAIgASgJIhsKGUJpbmRFbGVjdHJv",
                  "bmljS2V5UmVzcG9uc2UiOQoaVW5iaW5kRWxlY3Ryb25pY0tleVJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCRINCgVmb3JjZRgCIAEoCCIdChtVbmJpbmRFbGVjdHJv",
                  "bmljS2V5UmVzcG9uc2UiLgoeSW5pdGlhbGl6ZUVsZWN0cm9uaWNLZXlSZXF1",
                  "ZXN0EgwKBG5hbWUYASABKAkiIQofSW5pdGlhbGl6ZUVsZWN0cm9uaWNLZXlS",
                  "ZXNwb25zZSIhCh9Jbml0aWFsaXplRWxlY3Ryb25pY0tleU1ldGFkYXRhIi0K",
                  "HUNvbmZpZ3VyZUVsZWN0cm9uaWNLZXlSZXF1ZXN0EgwKBG5hbWUYASABKAki",
                  "IAoeQ29uZmlndXJlRWxlY3Ryb25pY0tleVJlc3BvbnNlIiAKHkNvbmZpZ3Vy",
                  "ZUVsZWN0cm9uaWNLZXlNZXRhZGF0YSIpChlSZXNldEVsZWN0cm9uaWNLZXlS",
                  "ZXF1ZXN0EgwKBG5hbWUYASABKAkiHAoaUmVzZXRFbGVjdHJvbmljS2V5UmVz",
                  "cG9uc2UiHAoaUmVzZXRFbGVjdHJvbmljS2V5TWV0YWRhdGEiOwohR2VuZXJh",
                  "dGVBdXRob3JpemF0aW9uVG9rZW5SZXF1ZXN0EhYKDmVsZWN0cm9uaWNfa2V5",
                  "GAEgASgJIkEKIkdlbmVyYXRlQXV0aG9yaXphdGlvblRva2VuUmVzcG9uc2US",
                  "GwoTYXV0aG9yaXphdGlvbl90b2tlbhgBIAEoDCI8CiJHZW5lcmF0ZUZpcm13",
                  "YXJlRG93bmxvYWRVcmlSZXF1ZXN0EhYKDmVsZWN0cm9uaWNfa2V5GAEgASgJ",
                  "IksKI0dlbmVyYXRlRmlybXdhcmVEb3dubG9hZFVyaVJlc3BvbnNlEhQKDGRv",
                  "d25sb2FkX3VyaRgBIAEoCRIOCgZkaWdlc3QYAiABKAkiJQojR2VuZXJhdGVG",
                  "aXJtd2FyZURvd25sb2FkVXJpTWV0YWRhdGEyqwwKFEVsZWN0cm9uaWNLZXlT",
                  "ZXJ2aWNlEn4KE0NyZWF0ZUVsZWN0cm9uaWNLZXkSOS5zYWx0by5uZWJ1bGEu",
                  "ZWxlY3Ryb25pY2tleS52MS5DcmVhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBos",
                  "LnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkVsZWN0cm9uaWNLZXkS",
                  "eAoQR2V0RWxlY3Ryb25pY0tleRI2LnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlj",
                  "a2V5LnYxLkdldEVsZWN0cm9uaWNLZXlSZXF1ZXN0Giwuc2FsdG8ubmVidWxh",
                  "LmVsZWN0cm9uaWNrZXkudjEuRWxlY3Ryb25pY0tleRKJAQoSTGlzdEVsZWN0",
                  "cm9uaWNLZXlzEjguc2FsdG8ubmVidWxhLmVsZWN0cm9uaWNrZXkudjEuTGlz",
                  "dEVsZWN0cm9uaWNLZXlzUmVxdWVzdBo5LnNhbHRvLm5lYnVsYS5lbGVjdHJv",
                  "bmlja2V5LnYxLkxpc3RFbGVjdHJvbmljS2V5c1Jlc3BvbnNlEn4KE1VwZGF0",
                  "ZUVsZWN0cm9uaWNLZXkSOS5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2tleS52",
                  "MS5VcGRhdGVFbGVjdHJvbmljS2V5UmVxdWVzdBosLnNhbHRvLm5lYnVsYS5l",
                  "bGVjdHJvbmlja2V5LnYxLkVsZWN0cm9uaWNLZXkSaAoTRGVsZXRlRWxlY3Ry",
                  "b25pY0tleRI5LnNhbHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkRlbGV0",
                  "ZUVsZWN0cm9uaWNLZXlSZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
                  "EoYBChFCaW5kRWxlY3Ryb25pY0tleRI3LnNhbHRvLm5lYnVsYS5lbGVjdHJv",
                  "bmlja2V5LnYxLkJpbmRFbGVjdHJvbmljS2V5UmVxdWVzdBo4LnNhbHRvLm5l",
                  "YnVsYS5lbGVjdHJvbmlja2V5LnYxLkJpbmRFbGVjdHJvbmljS2V5UmVzcG9u",
                  "c2USjAEKE1VuYmluZEVsZWN0cm9uaWNLZXkSOS5zYWx0by5uZWJ1bGEuZWxl",
                  "Y3Ryb25pY2tleS52MS5VbmJpbmRFbGVjdHJvbmljS2V5UmVxdWVzdBo6LnNh",
                  "bHRvLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLlVuYmluZEVsZWN0cm9uaWNL",
                  "ZXlSZXNwb25zZRJ5ChdJbml0aWFsaXplRWxlY3Ryb25pY0tleRI9LnNhbHRv",
                  "Lm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxLkluaXRpYWxpemVFbGVjdHJvbmlj",
                  "S2V5UmVxdWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9wZXJhdGlvbhJ3",
                  "ChZDb25maWd1cmVFbGVjdHJvbmljS2V5Ejwuc2FsdG8ubmVidWxhLmVsZWN0",
                  "cm9uaWNrZXkudjEuQ29uZmlndXJlRWxlY3Ryb25pY0tleVJlcXVlc3QaHy5z",
                  "YWx0by5sb25ncnVubmluZy52MS5PcGVyYXRpb24SbwoSUmVzZXRFbGVjdHJv",
                  "bmljS2V5Ejguc2FsdG8ubmVidWxhLmVsZWN0cm9uaWNrZXkudjEuUmVzZXRF",
                  "bGVjdHJvbmljS2V5UmVxdWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9w",
                  "ZXJhdGlvbhKhAQoaR2VuZXJhdGVBdXRob3JpemF0aW9uVG9rZW4SQC5zYWx0",
                  "by5uZWJ1bGEuZWxlY3Ryb25pY2tleS52MS5HZW5lcmF0ZUF1dGhvcml6YXRp",
                  "b25Ub2tlblJlcXVlc3QaQS5zYWx0by5uZWJ1bGEuZWxlY3Ryb25pY2tleS52",
                  "MS5HZW5lcmF0ZUF1dGhvcml6YXRpb25Ub2tlblJlc3BvbnNlEoEBChtHZW5l",
                  "cmF0ZUZpcm13YXJlRG93bmxvYWRVcmkSQS5zYWx0by5uZWJ1bGEuZWxlY3Ry",
                  "b25pY2tleS52MS5HZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlSZXF1ZXN0",
                  "Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uQocCCiVjb20uc2Fs",
                  "dG9hcGlzLm5lYnVsYS5lbGVjdHJvbmlja2V5LnYxQhJFbGVjdHJvbmljS2V5",
                  "UHJvdG9QAVpQZ2l0aHViLmNvbS9zYWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9h",
                  "cGlzLWdvL25lYnVsYS9lbGVjdHJvbmlja2V5L3YxO2VsZWN0cm9uaWNrZXmq",
                  "AiFTYWx0b2FwaXMuTmVidWxhLkVsZWN0cm9uaWNLZXkuVjHKAiFTYWx0b2Fw",
                  "aXNcTmVidWxhXEVsZWN0cm9uaWNLZXlcVjHiAi1HUEJNZXRhZGF0YVxTYWx0",
                  "b2FwaXNcTmVidWxhXEVsZWN0cm9uaWNLZXlcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.DeviceMetadataReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(ElectronicKey), ElectronicKey.Parser, ["Name", "DisplayName", "Initialized", "DeviceId", "Outdated", "DeviceMetadata", "User"], ["DeviceId", "User"], null, null, null),
            new(typeof(CreateElectronicKeyRequest), CreateElectronicKeyRequest.Parser, ["Parent", "ElectronicKeyId", "ElectronicKey"], ["ElectronicKeyId"], null, null, null),
            new(typeof(GetElectronicKeyRequest), GetElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListElectronicKeysRequest), ListElectronicKeysRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListElectronicKeysResponse), ListElectronicKeysResponse.Parser, ["ElectronicKeys", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateElectronicKeyRequest), UpdateElectronicKeyRequest.Parser, ["ElectronicKey", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteElectronicKeyRequest), DeleteElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindElectronicKeyRequest), BindElectronicKeyRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindElectronicKeyResponse), BindElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindElectronicKeyRequest), UnbindElectronicKeyRequest.Parser, ["Name", "Force"], null, null, null, null),
            new(typeof(UnbindElectronicKeyResponse), UnbindElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeElectronicKeyRequest), InitializeElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(InitializeElectronicKeyResponse), InitializeElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeElectronicKeyMetadata), InitializeElectronicKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(ConfigureElectronicKeyRequest), ConfigureElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ConfigureElectronicKeyResponse), ConfigureElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(ConfigureElectronicKeyMetadata), ConfigureElectronicKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(ResetElectronicKeyRequest), ResetElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetElectronicKeyResponse), ResetElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(ResetElectronicKeyMetadata), ResetElectronicKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["ElectronicKey"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["ElectronicKey"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The electronic key object
    /// </summary>
    public sealed partial class ElectronicKey : IMessage<ElectronicKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicKey> _parser = new(() => new ElectronicKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ElectronicKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ElectronicKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicKey(ElectronicKey other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            initialized_ = other.initialized_;
            deviceId_ = other.deviceId_;
            outdated_ = other.outdated_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            user_ = other.user_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ElectronicKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the electronic key. It must have the format of
        /// `installations/*/electronic-keys/*`. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
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
        /// Display name of the electronic key.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 3;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this electronic key has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.UpdateElectronicKey]
        /// operation. To change the value of this field, you must call
        /// [`InitializeElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.InitializeElectronicKey].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get { return initialized_; }
            set
            {
                initialized_ = value;
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 4;
        private readonly static string DeviceIdDefaultValue = "";

        private string deviceId_;

        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, electronic keys and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_ ?? DeviceIdDefaultValue; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId
        {
            get { return deviceId_ != null; }
        }

        /// <summary>Clears the value of the "device_id" field</summary>
        public void ClearDeviceId()
        {
            deviceId_ = null;
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 5;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this electronic key has pending updates or not. This
        /// could be because there was a pending configuration or a firmware update
        /// and is conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 6;
        private Type.DeviceMetadata deviceMetadata_;

        /// <summary>
        /// Device metadata contains information about a device hardware and firmware.
        /// </summary>
        public Type.DeviceMetadata DeviceMetadata
        {
            get { return deviceMetadata_; }
            set
            {
                deviceMetadata_ = value;
            }
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 8;
        private readonly static string UserDefaultValue = "";

        private string user_;

        /// <summary>
        /// User associated with this electronic key.
        /// </summary>
        public string User
        {
            get { return user_ ?? UserDefaultValue; }
            set
            {
                user_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "user" field is set</summary>
        public bool HasUser
        {
            get { return user_ != null; }
        }

        /// <summary>Clears the value of the "user" field</summary>
        public void ClearUser()
        {
            user_ = null;
        }

        public override bool Equals(object other) => Equals(other as ElectronicKey);
        public bool Equals(ElectronicKey other)
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
            if (Initialized != other.Initialized) return false;
            if (DeviceId != other.DeviceId) return false;
            if (Outdated != other.Outdated) return false;
            if (!Equals(DeviceMetadata, other.DeviceMetadata)) return false;
            if (User != other.User) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (HasUser) hash ^= User.GetHashCode();
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
      if (Initialized != false) {
        output.WriteRawTag(24);
        output.WriteBool(Initialized);
      }
      if (HasDeviceId) {
        output.WriteRawTag(34);
        output.WriteString(DeviceId);
      }
      if (Outdated != false) {
        output.WriteRawTag(40);
        output.WriteBool(Outdated);
      }
      if (deviceMetadata_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DeviceMetadata);
      }
      if (HasUser) {
        output.WriteRawTag(66);
        output.WriteString(User);
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
            if (Initialized != false)
            {
                output.WriteRawTag(24);
                output.WriteBool(Initialized);
            }
            if (HasDeviceId)
            {
                output.WriteRawTag(34);
                output.WriteString(DeviceId);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(40);
                output.WriteBool(Outdated);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(DeviceMetadata);
            }
            if (HasUser)
            {
                output.WriteRawTag(66);
                output.WriteString(User);
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
            if (Initialized != false)
            {
                size += 1 + 1;
            }
            if (HasDeviceId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (deviceMetadata_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            }
            if (HasUser)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(User);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ElectronicKey other)
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
            if (other.Initialized != false)
            {
                Initialized = other.Initialized;
            }
            if (other.HasDeviceId)
            {
                DeviceId = other.DeviceId;
            }
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
            }
            if (other.deviceMetadata_ != null)
            {
                if (deviceMetadata_ == null)
                {
                    DeviceMetadata = new Type.DeviceMetadata();
                }
                DeviceMetadata.MergeFrom(other.DeviceMetadata);
            }
            if (other.HasUser)
            {
                User = other.User;
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
          case 24: {
            Initialized = input.ReadBool();
            break;
          }
          case 34: {
            DeviceId = input.ReadString();
            break;
          }
          case 40: {
            Outdated = input.ReadBool();
            break;
          }
          case 50: {
            if (deviceMetadata_ == null) {
              DeviceMetadata = new Saltoapis.Nebula.Type.DeviceMetadata();
            }
            input.ReadMessage(DeviceMetadata);
            break;
          }
          case 66: {
            User = input.ReadString();
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
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 34:
                        {
                            DeviceId = input.ReadString();
                            break;
                        }
                    case 40:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                    case 50:
                        {
                            if (deviceMetadata_ == null)
                            {
                                DeviceMetadata = new Type.DeviceMetadata();
                            }
                            input.ReadMessage(DeviceMetadata);
                            break;
                        }
                    case 66:
                        {
                            User = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [CreateElectronicKey][salto.nebula.electronickey.v1.ElectronicKeyService.CreateElectronicKey]
    /// </summary>
    public sealed partial class CreateElectronicKeyRequest : IMessage<CreateElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateElectronicKeyRequest> _parser = new(() => new CreateElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateElectronicKeyRequest(CreateElectronicKeyRequest other) : this()
        {
            parent_ = other.parent_;
            electronicKeyId_ = other.electronicKeyId_;
            electronicKey_ = other.electronicKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the electronic key. For
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

        /// <summary>Field number for the "electronic_key_id" field.</summary>
        public const int ElectronicKeyIdFieldNumber = 2;
        private readonly static string ElectronicKeyIdDefaultValue = "";

        private string electronicKeyId_;

        /// <summary>
        /// The electronic key ID to use for this electronic key. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ElectronicKeyId
        {
            get { return electronicKeyId_ ?? ElectronicKeyIdDefaultValue; }
            set
            {
                electronicKeyId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "electronic_key_id" field is set</summary>
        public bool HasElectronicKeyId
        {
            get { return electronicKeyId_ != null; }
        }

        /// <summary>Clears the value of the "electronic_key_id" field</summary>
        public void ClearElectronicKeyId()
        {
            electronicKeyId_ = null;
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 3;
        private ElectronicKey electronicKey_;

        /// <summary>
        /// The electronic key resource to be created. Client must not set the
        /// `ElectronicKey.name` field.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateElectronicKeyRequest);
        public bool Equals(CreateElectronicKeyRequest other)
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
            if (ElectronicKeyId != other.ElectronicKeyId) return false;
            if (!Equals(ElectronicKey, other.ElectronicKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasElectronicKeyId) hash ^= ElectronicKeyId.GetHashCode();
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
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
      if (HasElectronicKeyId) {
        output.WriteRawTag(18);
        output.WriteString(ElectronicKeyId);
      }
      if (electronicKey_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ElectronicKey);
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
            if (HasElectronicKeyId)
            {
                output.WriteRawTag(18);
                output.WriteString(ElectronicKeyId);
            }
            if (electronicKey_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(ElectronicKey);
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
            if (HasElectronicKeyId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicKeyId);
            }
            if (electronicKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateElectronicKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasElectronicKeyId)
            {
                ElectronicKeyId = other.ElectronicKeyId;
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null)
                {
                    ElectronicKey = new ElectronicKey();
                }
                ElectronicKey.MergeFrom(other.ElectronicKey);
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
            ElectronicKeyId = input.ReadString();
            break;
          }
          case 26: {
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.ElectronicKey.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
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
                            ElectronicKeyId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (electronicKey_ == null)
                            {
                                ElectronicKey = new ElectronicKey();
                            }
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetElectronicKey][salto.nebula.electronickey.v1.ElectronicKeyService.GetElectronicKey]
    /// </summary>
    public sealed partial class GetElectronicKeyRequest : IMessage<GetElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetElectronicKeyRequest> _parser = new(() => new GetElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetElectronicKeyRequest(GetElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested electronic key resource. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetElectronicKeyRequest);
        public bool Equals(GetElectronicKeyRequest other)
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

        public void MergeFrom(GetElectronicKeyRequest other)
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
    /// The request message for [ListElectronicKeys][salto.nebula.electronickey.v1.ElectronicKeyService.ListElectronicKeys]
    /// </summary>
    public sealed partial class ListElectronicKeysRequest : IMessage<ListElectronicKeysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListElectronicKeysRequest> _parser = new(() => new ListElectronicKeysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListElectronicKeysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListElectronicKeysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListElectronicKeysRequest(ListElectronicKeysRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListElectronicKeysRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example, `installations/surelock-homes-hq`.
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
        /// A filter that chooses which electronic keys to return.
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

        public override bool Equals(object other) => Equals(other as ListElectronicKeysRequest);
        public bool Equals(ListElectronicKeysRequest other)
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

        public void MergeFrom(ListElectronicKeysRequest other)
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
    /// The response message for [ListElectronicKeys][salto.nebula.electronickey.v1.ElectronicKeyService.ListElectronicKeys]
    /// </summary>
    public sealed partial class ListElectronicKeysResponse : IMessage<ListElectronicKeysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListElectronicKeysResponse> _parser = new(() => new ListElectronicKeysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListElectronicKeysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListElectronicKeysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListElectronicKeysResponse(ListElectronicKeysResponse other) : this()
        {
            electronicKeys_ = other.electronicKeys_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListElectronicKeysResponse Clone() => new(this);
        /// <summary>Field number for the "electronic_keys" field.</summary>
        public const int ElectronicKeysFieldNumber = 1;
        private static readonly FieldCodec<ElectronicKey> _repeated_electronicKeys_codec
            = FieldCodec.ForMessage(10, ElectronicKey.Parser);
        private readonly RepeatedField<ElectronicKey> electronicKeys_ = [];

        /// <summary>
        /// The field name should match the noun `electronic_keys` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<ElectronicKey> ElectronicKeys
        {
            get { return electronicKeys_; }
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

        public override bool Equals(object other) => Equals(other as ListElectronicKeysResponse);
        public bool Equals(ListElectronicKeysResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!electronicKeys_.Equals(other.electronicKeys_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= electronicKeys_.GetHashCode();
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
      electronicKeys_.WriteTo(output, _repeated_electronicKeys_codec);
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
            electronicKeys_.WriteTo(ref output, _repeated_electronicKeys_codec);
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
            size += electronicKeys_.CalculateSize(_repeated_electronicKeys_codec);
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

        public void MergeFrom(ListElectronicKeysResponse other)
        {
            if (other == null)
            {
                return;
            }
            electronicKeys_.Add(other.electronicKeys_);
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
            electronicKeys_.AddEntriesFrom(input, _repeated_electronicKeys_codec);
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
                            electronicKeys_.AddEntriesFrom(ref input, _repeated_electronicKeys_codec);
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
    /// The request message for [UpdateElectronicKey][salto.nebula.electronickey.v1.ElectronicKeyService.UpdateElectronicKey]
    /// </summary>
    public sealed partial class UpdateElectronicKeyRequest : IMessage<UpdateElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateElectronicKeyRequest> _parser = new(() => new UpdateElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateElectronicKeyRequest(UpdateElectronicKeyRequest other) : this()
        {
            electronicKey_ = other.electronicKey_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 1;
        private ElectronicKey electronicKey_;

        /// <summary>
        /// The electronic key resource which replaces the resource on the server.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateElectronicKeyRequest);
        public bool Equals(UpdateElectronicKeyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(ElectronicKey, other.ElectronicKey)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
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
      if (electronicKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ElectronicKey);
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
            if (electronicKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ElectronicKey);
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
            if (electronicKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
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

        public void MergeFrom(UpdateElectronicKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null)
                {
                    ElectronicKey = new ElectronicKey();
                }
                ElectronicKey.MergeFrom(other.ElectronicKey);
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
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.ElectronicKey.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
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
                            if (electronicKey_ == null)
                            {
                                ElectronicKey = new ElectronicKey();
                            }
                            input.ReadMessage(ElectronicKey);
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
    /// The request message for [DeleteElectronicKey][salto.nebula.electronickey.v1.ElectronicKeyService.DeleteElectronicKey]
    /// </summary>
    public sealed partial class DeleteElectronicKeyRequest : IMessage<DeleteElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteElectronicKeyRequest> _parser = new(() => new DeleteElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteElectronicKeyRequest(DeleteElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic key to be deleted. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteElectronicKeyRequest);
        public bool Equals(DeleteElectronicKeyRequest other)
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

        public void MergeFrom(DeleteElectronicKeyRequest other)
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
    /// The request message for [`BindElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.BindElectronicKey]
    /// </summary>
    public sealed partial class BindElectronicKeyRequest : IMessage<BindElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindElectronicKeyRequest> _parser = new(() => new BindElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindElectronicKeyRequest(BindElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic key to be bound. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 2;
        private string deviceId_ = "";

        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, electronic keys and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as BindElectronicKeyRequest);
        public bool Equals(BindElectronicKeyRequest other)
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
            if (DeviceId != other.DeviceId) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
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
      if (DeviceId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
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
            if (DeviceId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DeviceId);
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
            if (DeviceId.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BindElectronicKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DeviceId.Length != 0)
            {
                DeviceId = other.DeviceId;
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
            DeviceId = input.ReadString();
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
                            DeviceId = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`BindElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.BindElectronicKey]
    /// </summary>
    public sealed partial class BindElectronicKeyResponse : IMessage<BindElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindElectronicKeyResponse> _parser = new(() => new BindElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindElectronicKeyResponse(BindElectronicKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindElectronicKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BindElectronicKeyResponse);
        public bool Equals(BindElectronicKeyResponse other)
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

        public void MergeFrom(BindElectronicKeyResponse other)
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
    /// The request message for [`UnbindElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.UnbindElectronicKey]
    /// </summary>
    public sealed partial class UnbindElectronicKeyRequest : IMessage<UnbindElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindElectronicKeyRequest> _parser = new(() => new UnbindElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindElectronicKeyRequest(UnbindElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            force_ = other.force_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic key to be unbound. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "force" field.</summary>
        public const int ForceFieldNumber = 2;
        private bool force_;

        /// <summary>
        /// If set to true, the device identifier is removed (unbound) from the
        /// electronic key. Otherwise, the request will only work if the electronic
        /// key isn't bound to any previous device identifier.
        /// </summary>
        public bool Force
        {
            get { return force_; }
            set
            {
                force_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnbindElectronicKeyRequest);
        public bool Equals(UnbindElectronicKeyRequest other)
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
            if (Force != other.Force) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Force != false) hash ^= Force.GetHashCode();
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
      if (Force != false) {
        output.WriteRawTag(16);
        output.WriteBool(Force);
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
            if (Force != false)
            {
                output.WriteRawTag(16);
                output.WriteBool(Force);
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
            if (Force != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UnbindElectronicKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Force != false)
            {
                Force = other.Force;
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
          case 16: {
            Force = input.ReadBool();
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
                            Force = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`UnbindElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.UnbindElectronicKey]
    /// </summary>
    public sealed partial class UnbindElectronicKeyResponse : IMessage<UnbindElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindElectronicKeyResponse> _parser = new(() => new UnbindElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindElectronicKeyResponse(UnbindElectronicKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindElectronicKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnbindElectronicKeyResponse);
        public bool Equals(UnbindElectronicKeyResponse other)
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

        public void MergeFrom(UnbindElectronicKeyResponse other)
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
    /// The request message for [`InitializeElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.InitializeElectronicKey]
    /// </summary>
    public sealed partial class InitializeElectronicKeyRequest : IMessage<InitializeElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeElectronicKeyRequest> _parser = new(() => new InitializeElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeElectronicKeyRequest(InitializeElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic key to be initialized. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as InitializeElectronicKeyRequest);
        public bool Equals(InitializeElectronicKeyRequest other)
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

        public void MergeFrom(InitializeElectronicKeyRequest other)
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
    /// The empty response message for [`InitializeElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.InitializeElectronicKey]
    /// </summary>
    public sealed partial class InitializeElectronicKeyResponse : IMessage<InitializeElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeElectronicKeyResponse> _parser = new(() => new InitializeElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeElectronicKeyResponse(InitializeElectronicKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeElectronicKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeElectronicKeyResponse);
        public bool Equals(InitializeElectronicKeyResponse other)
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

        public void MergeFrom(InitializeElectronicKeyResponse other)
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
    /// The metadata message for [`InitializeElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.InitializeElectronicKey]
    /// </summary>
    public sealed partial class InitializeElectronicKeyMetadata : IMessage<InitializeElectronicKeyMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeElectronicKeyMetadata> _parser = new(() => new InitializeElectronicKeyMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeElectronicKeyMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeElectronicKeyMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeElectronicKeyMetadata(InitializeElectronicKeyMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeElectronicKeyMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeElectronicKeyMetadata);
        public bool Equals(InitializeElectronicKeyMetadata other)
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

        public void MergeFrom(InitializeElectronicKeyMetadata other)
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
    /// The request message for [`ConfigureElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.ConfigureElectronicKey]
    /// </summary>
    public sealed partial class ConfigureElectronicKeyRequest : IMessage<ConfigureElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureElectronicKeyRequest> _parser = new(() => new ConfigureElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureElectronicKeyRequest(ConfigureElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic key to be configured. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ConfigureElectronicKeyRequest);
        public bool Equals(ConfigureElectronicKeyRequest other)
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

        public void MergeFrom(ConfigureElectronicKeyRequest other)
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
    /// The empty response message for [`ConfigureElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.ConfigureElectronicKey]
    /// </summary>
    public sealed partial class ConfigureElectronicKeyResponse : IMessage<ConfigureElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureElectronicKeyResponse> _parser = new(() => new ConfigureElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureElectronicKeyResponse(ConfigureElectronicKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureElectronicKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureElectronicKeyResponse);
        public bool Equals(ConfigureElectronicKeyResponse other)
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

        public void MergeFrom(ConfigureElectronicKeyResponse other)
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
    /// The metadata message for [`ConfigureElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.ConfigureElectronicKey]
    /// </summary>
    public sealed partial class ConfigureElectronicKeyMetadata : IMessage<ConfigureElectronicKeyMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureElectronicKeyMetadata> _parser = new(() => new ConfigureElectronicKeyMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureElectronicKeyMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureElectronicKeyMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureElectronicKeyMetadata(ConfigureElectronicKeyMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureElectronicKeyMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureElectronicKeyMetadata);
        public bool Equals(ConfigureElectronicKeyMetadata other)
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

        public void MergeFrom(ConfigureElectronicKeyMetadata other)
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
    /// The request message for [`ResetElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.ResetElectronicKey]
    /// </summary>
    public sealed partial class ResetElectronicKeyRequest : IMessage<ResetElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetElectronicKeyRequest> _parser = new(() => new ResetElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetElectronicKeyRequest(ResetElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the electronic key to be reset. For example:
        /// `installations/surelock-homes-hq/electronic-keys/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ResetElectronicKeyRequest);
        public bool Equals(ResetElectronicKeyRequest other)
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

        public void MergeFrom(ResetElectronicKeyRequest other)
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
    /// The empty response message for [`ResetElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.ResetElectronicKey]
    /// </summary>
    public sealed partial class ResetElectronicKeyResponse : IMessage<ResetElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetElectronicKeyResponse> _parser = new(() => new ResetElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetElectronicKeyResponse(ResetElectronicKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetElectronicKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetElectronicKeyResponse);
        public bool Equals(ResetElectronicKeyResponse other)
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

        public void MergeFrom(ResetElectronicKeyResponse other)
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
    /// The metadata message for [`ResetElectronicKey`][salto.nebula.electronickey.v1.ElectronicKeyService.ResetElectronicKey]
    /// </summary>
    public sealed partial class ResetElectronicKeyMetadata : IMessage<ResetElectronicKeyMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetElectronicKeyMetadata> _parser = new(() => new ResetElectronicKeyMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetElectronicKeyMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetElectronicKeyMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetElectronicKeyMetadata(ResetElectronicKeyMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetElectronicKeyMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetElectronicKeyMetadata);
        public bool Equals(ResetElectronicKeyMetadata other)
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

        public void MergeFrom(ResetElectronicKeyMetadata other)
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
    /// The request message for [`GenerateAuthorizationToken`][salto.nebula.electronickey.v1.ElectronicKeyService.GenerateAuthorizationToken]
    /// </summary>
    public sealed partial class GenerateAuthorizationTokenRequest : IMessage<GenerateAuthorizationTokenRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateAuthorizationTokenRequest> _parser = new(() => new GenerateAuthorizationTokenRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateAuthorizationTokenRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateAuthorizationTokenRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateAuthorizationTokenRequest(GenerateAuthorizationTokenRequest other) : this()
        {
            electronicKey_ = other.electronicKey_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 1;
        private string electronicKey_ = "";

        /// <summary>
        /// The resource name of the electronic key that the authorization token is
        /// generated for. For example:
        /// `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateAuthorizationTokenRequest);
        public bool Equals(GenerateAuthorizationTokenRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ElectronicKey != other.ElectronicKey) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ElectronicKey.Length != 0) hash ^= ElectronicKey.GetHashCode();
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
      if (ElectronicKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ElectronicKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ElectronicKey.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ElectronicKey.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateAuthorizationTokenRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ElectronicKey.Length != 0)
            {
                ElectronicKey = other.ElectronicKey;
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
            ElectronicKey = input.ReadString();
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
                            ElectronicKey = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateAuthorizationToken`][salto.nebula.electronickey.v1.ElectronicKeyService.GenerateAuthorizationToken]
    /// </summary>
    public sealed partial class GenerateAuthorizationTokenResponse : IMessage<GenerateAuthorizationTokenResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateAuthorizationTokenResponse> _parser = new(() => new GenerateAuthorizationTokenResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateAuthorizationTokenResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateAuthorizationTokenResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateAuthorizationTokenResponse(GenerateAuthorizationTokenResponse other) : this()
        {
            authorizationToken_ = other.authorizationToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenResponse Clone() => new(this);
        /// <summary>Field number for the "authorization_token" field.</summary>
        public const int AuthorizationTokenFieldNumber = 1;
        private ByteString authorizationToken_ = ByteString.Empty;

        /// <summary>
        /// Authorization token to be used for connecting to an electronic key.
        /// </summary>
        public ByteString AuthorizationToken
        {
            get { return authorizationToken_; }
            set
            {
                authorizationToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateAuthorizationTokenResponse);
        public bool Equals(GenerateAuthorizationTokenResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (AuthorizationToken != other.AuthorizationToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (AuthorizationToken.Length != 0) hash ^= AuthorizationToken.GetHashCode();
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
      if (AuthorizationToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(AuthorizationToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (AuthorizationToken.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(AuthorizationToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (AuthorizationToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeBytesSize(AuthorizationToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateAuthorizationTokenResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.AuthorizationToken.Length != 0)
            {
                AuthorizationToken = other.AuthorizationToken;
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
            AuthorizationToken = input.ReadBytes();
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
                            AuthorizationToken = input.ReadBytes();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.electronickey.v1.ElectronicKeyService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriRequest : IMessage<GenerateFirmwareDownloadUriRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriRequest> _parser = new(() => new GenerateFirmwareDownloadUriRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriRequest(GenerateFirmwareDownloadUriRequest other) : this()
        {
            electronicKey_ = other.electronicKey_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 1;
        private string electronicKey_ = "";

        /// <summary>
        /// The resource name of the electronickey to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/electronic-keys/main-key`.
        /// </summary>
        public string ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriRequest);
        public bool Equals(GenerateFirmwareDownloadUriRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ElectronicKey != other.ElectronicKey) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ElectronicKey.Length != 0) hash ^= ElectronicKey.GetHashCode();
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
      if (ElectronicKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ElectronicKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ElectronicKey.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ElectronicKey.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ElectronicKey.Length != 0)
            {
                ElectronicKey = other.ElectronicKey;
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
            ElectronicKey = input.ReadString();
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
                            ElectronicKey = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateFirmwareDownloadUri`][salto.nebula.electronickey.v1.ElectronicKeyService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriResponse : IMessage<GenerateFirmwareDownloadUriResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriResponse> _parser = new(() => new GenerateFirmwareDownloadUriResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriResponse(GenerateFirmwareDownloadUriResponse other) : this()
        {
            downloadUri_ = other.downloadUri_;
            digest_ = other.digest_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriResponse Clone() => new(this);
        /// <summary>Field number for the "download_uri" field.</summary>
        public const int DownloadUriFieldNumber = 1;
        private string downloadUri_ = "";

        /// <summary>
        /// The URI to download the firmware bundle. The URI will be valid for 15
        /// minutes.
        /// </summary>
        public string DownloadUri
        {
            get { return downloadUri_; }
            set
            {
                downloadUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "digest" field.</summary>
        public const int DigestFieldNumber = 2;
        private string digest_ = "";

        /// <summary>
        /// Digest of the file to be download. This can be used to cache the file and
        /// avoid downloading it multiple times.
        /// The digest has the following format: `&lt;algorithm>:&lt;digest>`.
        /// For example: `sha256:8ff2483f2fbaa6c8dfd4e3556dbde298eb5e342b5e46f84eabdccc8e1cbe2d5a`.
        /// </summary>
        public string Digest
        {
            get { return digest_; }
            set
            {
                digest_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriResponse);
        public bool Equals(GenerateFirmwareDownloadUriResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (DownloadUri != other.DownloadUri) return false;
            if (Digest != other.Digest) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (DownloadUri.Length != 0) hash ^= DownloadUri.GetHashCode();
            if (Digest.Length != 0) hash ^= Digest.GetHashCode();
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
      if (DownloadUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DownloadUri);
      }
      if (Digest.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Digest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (DownloadUri.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(DownloadUri);
            }
            if (Digest.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Digest);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (DownloadUri.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DownloadUri);
            }
            if (Digest.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Digest);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.DownloadUri.Length != 0)
            {
                DownloadUri = other.DownloadUri;
            }
            if (other.Digest.Length != 0)
            {
                Digest = other.Digest;
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
            DownloadUri = input.ReadString();
            break;
          }
          case 18: {
            Digest = input.ReadString();
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
                            DownloadUri = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Digest = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`GenerateFirmwareDownloadUri`][salto.nebula.electronickey.v1.ElectronicKeyService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriMetadata : IMessage<GenerateFirmwareDownloadUriMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriMetadata> _parser = new(() => new GenerateFirmwareDownloadUriMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriMetadata(GenerateFirmwareDownloadUriMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriMetadata);
        public bool Equals(GenerateFirmwareDownloadUriMetadata other)
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

        public void MergeFrom(GenerateFirmwareDownloadUriMetadata other)
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

    #endregion

}
