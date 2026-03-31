using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.DigitalKey.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/digitalkey/v1/digital_key.proto</summary>
    public static partial class DigitalKeyReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/digitalkey/v1/digital_key.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static DigitalKeyReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CixzYWx0by9uZWJ1bGEvZGlnaXRhbGtleS92MS9kaWdpdGFsX2tleS5wcm90",
                  "bxIac2FsdG8ubmVidWxhLmRpZ2l0YWxrZXkudjEaH2dvb2dsZS9wcm90b2J1",
                  "Zi90aW1lc3RhbXAucHJvdG8aJHNhbHRvL2xvbmdydW5uaW5nL3YxL29wZXJh",
                  "dGlvbi5wcm90bxoic2FsdG8vbmVidWxhL3R5cGUvdGVjaG5vbG9neS5wcm90",
                  "bxoWc2FsdG8vdHlwZS9jb2xvci5wcm90byL2CAoKRGlnaXRhbEtleRIMCgRu",
                  "YW1lGAEgASgJEkAKB2FwcF9rZXkYAiABKAsyLS5zYWx0by5uZWJ1bGEuZGln",
                  "aXRhbGtleS52MS5EaWdpdGFsS2V5LkFwcEtleUgAEkYKCndhbGxldF9rZXkY",
                  "AyABKAsyMC5zYWx0by5uZWJ1bGEuZGlnaXRhbGtleS52MS5EaWdpdGFsS2V5",
                  "LldhbGxldEtleUgAGnYKCE1ldGFkYXRhEg0KBXRpdGxlGAEgASgJEhAKCHN1",
                  "YnRpdGxlGAIgASgJEhEKCXBob3RvX3VyaRgDIAEoCRIPCgdhZGRyZXNzGAQg",
                  "ASgJEiUKCnRleHRfY29sb3IYBSABKAsyES5zYWx0by50eXBlLkNvbG9yGv8D",
                  "CgZBcHBLZXkSQQoIbWV0YWRhdGEYASABKAsyLy5zYWx0by5uZWJ1bGEuZGln",
                  "aXRhbGtleS52MS5EaWdpdGFsS2V5Lk1ldGFkYXRhEgwKBGRhdGEYAiABKAwS",
                  "FAoMaW5zdGFsbGF0aW9uGAUgASgJEhEKBHVuaXQYBiABKAlIAIgBARIXCg9p",
                  "bnN0YWxsYXRpb25faWQYAyABKAkSFAoHdW5pdF9pZBgEIAEoCUgBiAEBEjsK",
                  "F2FjY2Vzc19wb2ludHNfc3luY190aW1lGAcgASgLMhouZ29vZ2xlLnByb3Rv",
                  "YnVmLlRpbWVzdGFtcBJlChhhY2Nlc3NfcG9pbnRzX3N5bmNfc3RhdGUYCCAB",
                  "KA4yQy5zYWx0by5uZWJ1bGEuZGlnaXRhbGtleS52MS5EaWdpdGFsS2V5LkFw",
                  "cEtleS5BY2Nlc3NQb2ludHNTeW5jU3RhdGUikgEKFUFjY2Vzc1BvaW50c1N5",
                  "bmNTdGF0ZRIoCiRBQ0NFU1NfUE9JTlRTX1NZTkNfU1RBVEVfVU5TUEVDSUZJ",
                  "RUQQABIPCgtJTlZBTElEQVRFRBADEgsKB1NZTkNJTkcQARIKCgZTWU5DRUQQ",
                  "AhIRCg1OT1RfU1VQUE9SVEVEEAQSEgoOTElNSVRfRVhDRUVERUQQBUIHCgVf",
                  "dW5pdEIKCghfdW5pdF9pZBrNAgoJV2FsbGV0S2V5EkEKCG1ldGFkYXRhGAEg",
                  "ASgLMi8uc2FsdG8ubmVidWxhLmRpZ2l0YWxrZXkudjEuRGlnaXRhbEtleS5N",
                  "ZXRhZGF0YRJaChBoeWRyYV9jcmVkZW50aWFsGAIgASgLMkAuc2FsdG8ubmVi",
                  "dWxhLmRpZ2l0YWxrZXkudjEuRGlnaXRhbEtleS5XYWxsZXRLZXkuSHlkcmFD",
                  "cmVkZW50aWFsGqABCg9IeWRyYUNyZWRlbnRpYWwSFQoNY3JlZGVudGlhbF9p",
                  "ZBgBIAEoCRIbChNzaGFyaW5nX2luc3RhbmNlX2lkGAIgASgJEhQKDGFjY291",
                  "bnRfaGFzaBgDIAEoCRITCgt0ZW1wbGF0ZV9pZBgEIAEoCRIYChByZWx5aW5n",
                  "X3BhcnR5X2lkGAUgASgJEhQKDHJlZmVyZW5jZV9pZBgGIAEoCUIGCgR0eXBl",
                  "IiQKFEdldERpZ2l0YWxLZXlSZXF1ZXN0EgwKBG5hbWUYASABKAkiYQoWTGlz",
                  "dERpZ2l0YWxLZXlzUmVxdWVzdBIRCglwYWdlX3NpemUYASABKAUSEgoKcGFn",
                  "ZV90b2tlbhgCIAEoCRIOCgZmaWx0ZXIYAyABKAkSEAoIb3JkZXJfYnkYBCAB",
                  "KAkicAoXTGlzdERpZ2l0YWxLZXlzUmVzcG9uc2USPAoMZGlnaXRhbF9rZXlz",
                  "GAEgAygLMiYuc2FsdG8ubmVidWxhLmRpZ2l0YWxrZXkudjEuRGlnaXRhbEtl",
                  "eRIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAkikwEKFURpZ2l0YWxLZXlBY2Nl",
                  "c3NQb2ludBIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRIR",
                  "CglkZXZpY2VfaWQYAyABKAkSQwoWc3VwcG9ydGVkX3RlY2hub2xvZ2llcxgE",
                  "IAMoDjIjLnNhbHRvLm5lYnVsYS50eXBlLkFwcEtleVRlY2hub2xvZ3kiLwof",
                  "R2V0RGlnaXRhbEtleUFjY2Vzc1BvaW50UmVxdWVzdBIMCgRuYW1lGAEgASgJ",
                  "ImoKIUxpc3REaWdpdGFsS2V5QWNjZXNzUG9pbnRzUmVxdWVzdBIOCgZwYXJl",
                  "bnQYASABKAkSDgoGZmlsdGVyGAIgASgJEhEKCXBhZ2Vfc2l6ZRgDIAEoBRIS",
                  "CgpwYWdlX3Rva2VuGAQgASgJIpMBCiJMaXN0RGlnaXRhbEtleUFjY2Vzc1Bv",
                  "aW50c1Jlc3BvbnNlElQKGWRpZ2l0YWxfa2V5X2FjY2Vzc19wb2ludHMYASAD",
                  "KAsyMS5zYWx0by5uZWJ1bGEuZGlnaXRhbGtleS52MS5EaWdpdGFsS2V5QWNj",
                  "ZXNzUG9pbnQSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJIjEKIVN5bmNEaWdp",
                  "dGFsS2V5QWNjZXNzUG9pbnRzUmVxdWVzdBIMCgRuYW1lGAEgASgJIiQKIlN5",
                  "bmNEaWdpdGFsS2V5QWNjZXNzUG9pbnRzUmVzcG9uc2UiJAoiU3luY0RpZ2l0",
                  "YWxLZXlBY2Nlc3NQb2ludHNNZXRhZGF0YSIyCiJVbmxvY2tEaWdpdGFsS2V5",
                  "QWNjZXNzUG9pbnRSZXF1ZXN0EgwKBG5hbWUYASABKAkiJQojVW5sb2NrRGln",
                  "aXRhbEtleUFjY2Vzc1BvaW50UmVzcG9uc2UiJQojVW5sb2NrRGlnaXRhbEtl",
                  "eUFjY2Vzc1BvaW50TWV0YWRhdGEyowYKEURpZ2l0YWxLZXlTZXJ2aWNlEmkK",
                  "DUdldERpZ2l0YWxLZXkSMC5zYWx0by5uZWJ1bGEuZGlnaXRhbGtleS52MS5H",
                  "ZXREaWdpdGFsS2V5UmVxdWVzdBomLnNhbHRvLm5lYnVsYS5kaWdpdGFsa2V5",
                  "LnYxLkRpZ2l0YWxLZXkSegoPTGlzdERpZ2l0YWxLZXlzEjIuc2FsdG8ubmVi",
                  "dWxhLmRpZ2l0YWxrZXkudjEuTGlzdERpZ2l0YWxLZXlzUmVxdWVzdBozLnNh",
                  "bHRvLm5lYnVsYS5kaWdpdGFsa2V5LnYxLkxpc3REaWdpdGFsS2V5c1Jlc3Bv",
                  "bnNlEooBChhHZXREaWdpdGFsS2V5QWNjZXNzUG9pbnQSOy5zYWx0by5uZWJ1",
                  "bGEuZGlnaXRhbGtleS52MS5HZXREaWdpdGFsS2V5QWNjZXNzUG9pbnRSZXF1",
                  "ZXN0GjEuc2FsdG8ubmVidWxhLmRpZ2l0YWxrZXkudjEuRGlnaXRhbEtleUFj",
                  "Y2Vzc1BvaW50EpsBChpMaXN0RGlnaXRhbEtleUFjY2Vzc1BvaW50cxI9LnNh",
                  "bHRvLm5lYnVsYS5kaWdpdGFsa2V5LnYxLkxpc3REaWdpdGFsS2V5QWNjZXNz",
                  "UG9pbnRzUmVxdWVzdBo+LnNhbHRvLm5lYnVsYS5kaWdpdGFsa2V5LnYxLkxp",
                  "c3REaWdpdGFsS2V5QWNjZXNzUG9pbnRzUmVzcG9uc2USfAoaU3luY0RpZ2l0",
                  "YWxLZXlBY2Nlc3NQb2ludHMSPS5zYWx0by5uZWJ1bGEuZGlnaXRhbGtleS52",
                  "MS5TeW5jRGlnaXRhbEtleUFjY2Vzc1BvaW50c1JlcXVlc3QaHy5zYWx0by5s",
                  "b25ncnVubmluZy52MS5PcGVyYXRpb24SfgobVW5sb2NrRGlnaXRhbEtleUFj",
                  "Y2Vzc1BvaW50Ej4uc2FsdG8ubmVidWxhLmRpZ2l0YWxrZXkudjEuVW5sb2Nr",
                  "RGlnaXRhbEtleUFjY2Vzc1BvaW50UmVxdWVzdBofLnNhbHRvLmxvbmdydW5u",
                  "aW5nLnYxLk9wZXJhdGlvbkLyAQoiY29tLnNhbHRvYXBpcy5uZWJ1bGEuZGln",
                  "aXRhbGtleS52MUIPRGlnaXRhbEtleVByb3RvUAFaSmdpdGh1Yi5jb20vc2Fs",
                  "dG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby9uZWJ1bGEvZGlnaXRhbGtl",
                  "eS92MTtkaWdpdGFsa2V5qgIeU2FsdG9hcGlzLk5lYnVsYS5EaWdpdGFsS2V5",
                  "LlYxygIeU2FsdG9hcGlzXE5lYnVsYVxEaWdpdGFsS2V5XFYx4gIqR1BCTWV0",
                  "YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxEaWdpdGFsS2V5XFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.TechnologyReflection.Descriptor, Saltoapis.Type.ColorReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(DigitalKey), DigitalKey.Parser, ["Name", "AppKey", "WalletKey"], ["Type"], null, null, [ new(typeof(DigitalKey.Types.Metadata), DigitalKey.Types.Metadata.Parser, ["Title", "Subtitle", "PhotoUri", "Address", "TextColor"], null, null, null, null),
            new(typeof(DigitalKey.Types.AppKey), DigitalKey.Types.AppKey.Parser, ["Metadata", "Data", "Installation", "Unit", "InstallationId", "UnitId", "AccessPointsSyncTime", "AccessPointsSyncState"], ["Unit", "UnitId"], [typeof(DigitalKey.Types.AppKey.Types.AccessPointsSyncState)], null, null),
            new(typeof(DigitalKey.Types.WalletKey), DigitalKey.Types.WalletKey.Parser, ["Metadata", "HydraCredential"], null, null, null, [new(typeof(DigitalKey.Types.WalletKey.Types.HydraCredential), DigitalKey.Types.WalletKey.Types.HydraCredential.Parser, ["CredentialId", "SharingInstanceId", "AccountHash", "TemplateId", "RelyingPartyId", "ReferenceId"], null, null, null, null)])]),
            new(typeof(GetDigitalKeyRequest), GetDigitalKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListDigitalKeysRequest), ListDigitalKeysRequest.Parser, ["PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListDigitalKeysResponse), ListDigitalKeysResponse.Parser, ["DigitalKeys", "NextPageToken"], null, null, null, null),
            new(typeof(DigitalKeyAccessPoint), DigitalKeyAccessPoint.Parser, ["Name", "DisplayName", "DeviceId", "SupportedTechnologies"], null, null, null, null),
            new(typeof(GetDigitalKeyAccessPointRequest), GetDigitalKeyAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListDigitalKeyAccessPointsRequest), ListDigitalKeyAccessPointsRequest.Parser, ["Parent", "Filter", "PageSize", "PageToken"], null, null, null, null),
            new(typeof(ListDigitalKeyAccessPointsResponse), ListDigitalKeyAccessPointsResponse.Parser, ["DigitalKeyAccessPoints", "NextPageToken"], null, null, null, null),
            new(typeof(SyncDigitalKeyAccessPointsRequest), SyncDigitalKeyAccessPointsRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(SyncDigitalKeyAccessPointsResponse), SyncDigitalKeyAccessPointsResponse.Parser, null, null, null, null, null),
            new(typeof(SyncDigitalKeyAccessPointsMetadata), SyncDigitalKeyAccessPointsMetadata.Parser, null, null, null, null, null),
            new(typeof(UnlockDigitalKeyAccessPointRequest), UnlockDigitalKeyAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(UnlockDigitalKeyAccessPointResponse), UnlockDigitalKeyAccessPointResponse.Parser, null, null, null, null, null),
            new(typeof(UnlockDigitalKeyAccessPointMetadata), UnlockDigitalKeyAccessPointMetadata.Parser, null, null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (!Equals(AppKey, other.AppKey)) return false;
            if (!Equals(WalletKey, other.WalletKey)) return false;
            if (TypeCase != other.TypeCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (typeCase_ == TypeOneofCase.AppKey) hash ^= AppKey.GetHashCode();
            if (typeCase_ == TypeOneofCase.WalletKey) hash ^= WalletKey.GetHashCode();
            hash ^= (int)typeCase_;
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
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (typeCase_ == TypeOneofCase.AppKey)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            }
            if (typeCase_ == TypeOneofCase.WalletKey)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DigitalKey other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            switch (other.TypeCase)
            {
                case TypeOneofCase.AppKey:
                    if (AppKey == null)
                    {
                        AppKey = new Types.AppKey();
                    }
                    AppKey.MergeFrom(other.AppKey);
                    break;
                case TypeOneofCase.WalletKey:
                    if (WalletKey == null)
                    {
                        WalletKey = new Types.WalletKey();
                    }
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
                            if (typeCase_ == TypeOneofCase.AppKey)
                            {
                                subBuilder.MergeFrom(AppKey);
                            }
                            input.ReadMessage(subBuilder);
                            AppKey = subBuilder;
                            break;
                        }
                    case 26:
                        {
                            Types.WalletKey subBuilder = new();
                            if (typeCase_ == TypeOneofCase.WalletKey)
                            {
                                subBuilder.MergeFrom(WalletKey);
                            }
                            input.ReadMessage(subBuilder);
                            WalletKey = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
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
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (Title != other.Title) return false;
                    if (Subtitle != other.Subtitle) return false;
                    if (PhotoUri != other.PhotoUri) return false;
                    if (Address != other.Address) return false;
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
                    if (Title.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Title);
                    }
                    if (Subtitle.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Subtitle);
                    }
                    if (PhotoUri.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(PhotoUri);
                    }
                    if (Address.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Address);
                    }
                    if (textColor_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(TextColor);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(Metadata other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.Title.Length != 0)
                    {
                        Title = other.Title;
                    }
                    if (other.Subtitle.Length != 0)
                    {
                        Subtitle = other.Subtitle;
                    }
                    if (other.PhotoUri.Length != 0)
                    {
                        PhotoUri = other.PhotoUri;
                    }
                    if (other.Address.Length != 0)
                    {
                        Address = other.Address;
                    }
                    if (other.textColor_ != null)
                    {
                        if (textColor_ == null)
                        {
                            TextColor = new Saltoapis.Type.Color();
                        }
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
                                    if (textColor_ == null)
                                    {
                                        TextColor = new Saltoapis.Type.Color();
                                    }
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
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (!Equals(Metadata, other.Metadata)) return false;
                    if (Data != other.Data) return false;
                    if (Installation != other.Installation) return false;
                    if (Unit != other.Unit) return false;
                    if (InstallationId != other.InstallationId) return false;
                    if (UnitId != other.UnitId) return false;
                    if (!Equals(AccessPointsSyncTime, other.AccessPointsSyncTime)) return false;
                    if (AccessPointsSyncState != other.AccessPointsSyncState) return false;
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
                    if (metadata_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(Metadata);
                    }
                    if (Data.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeBytesSize(Data);
                    }
                    if (Installation.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Installation);
                    }
                    if (HasUnit)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Unit);
                    }
                    if (InstallationId.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(InstallationId);
                    }
                    if (HasUnitId)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(UnitId);
                    }
                    if (accessPointsSyncTime_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointsSyncTime);
                    }
                    if (AccessPointsSyncState != Types.AccessPointsSyncState.Unspecified)
                    {
                        size += 1 + CodedOutputStream.ComputeEnumSize((int)AccessPointsSyncState);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(AppKey other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.metadata_ != null)
                    {
                        if (metadata_ == null)
                        {
                            Metadata = new Metadata();
                        }
                        Metadata.MergeFrom(other.Metadata);
                    }
                    if (other.Data.Length != 0)
                    {
                        Data = other.Data;
                    }
                    if (other.Installation.Length != 0)
                    {
                        Installation = other.Installation;
                    }
                    if (other.HasUnit)
                    {
                        Unit = other.Unit;
                    }
                    if (other.InstallationId.Length != 0)
                    {
                        InstallationId = other.InstallationId;
                    }
                    if (other.HasUnitId)
                    {
                        UnitId = other.UnitId;
                    }
                    if (other.accessPointsSyncTime_ != null)
                    {
                        if (accessPointsSyncTime_ == null)
                        {
                            AccessPointsSyncTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                        }
                        AccessPointsSyncTime.MergeFrom(other.AccessPointsSyncTime);
                    }
                    if (other.AccessPointsSyncState != Types.AccessPointsSyncState.Unspecified)
                    {
                        AccessPointsSyncState = other.AccessPointsSyncState;
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
                                    if (metadata_ == null)
                                    {
                                        Metadata = new Metadata();
                                    }
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
                                    if (accessPointsSyncTime_ == null)
                                    {
                                        AccessPointsSyncTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                                    }
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

                #region Nested types
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
                #endregion

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
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (!Equals(Metadata, other.Metadata)) return false;
                    if (!Equals(HydraCredential, other.HydraCredential)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (metadata_ != null) hash ^= Metadata.GetHashCode();
                    if (hydraCredential_ != null) hash ^= HydraCredential.GetHashCode();
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
                    if (metadata_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(Metadata);
                    }
                    if (hydraCredential_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(HydraCredential);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(WalletKey other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.metadata_ != null)
                    {
                        if (metadata_ == null)
                        {
                            Metadata = new Metadata();
                        }
                        Metadata.MergeFrom(other.Metadata);
                    }
                    if (other.hydraCredential_ != null)
                    {
                        if (hydraCredential_ == null)
                        {
                            HydraCredential = new Types.HydraCredential();
                        }
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
                                    if (metadata_ == null)
                                    {
                                        Metadata = new Metadata();
                                    }
                                    input.ReadMessage(Metadata);
                                    break;
                                }
                            case 18:
                                {
                                    if (hydraCredential_ == null)
                                    {
                                        HydraCredential = new Types.HydraCredential();
                                    }
                                    input.ReadMessage(HydraCredential);
                                    break;
                                }
                        }
                    }
                }
#endif

                #region Nested types
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
                            if (other is null)
                            {
                                return false;
                            }
                            if (ReferenceEquals(other, this))
                            {
                                return true;
                            }
                            if (CredentialId != other.CredentialId) return false;
                            if (SharingInstanceId != other.SharingInstanceId) return false;
                            if (AccountHash != other.AccountHash) return false;
                            if (TemplateId != other.TemplateId) return false;
                            if (RelyingPartyId != other.RelyingPartyId) return false;
                            if (ReferenceId != other.ReferenceId) return false;
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
                            if (CredentialId.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(CredentialId);
                            }
                            if (SharingInstanceId.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(SharingInstanceId);
                            }
                            if (AccountHash.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(AccountHash);
                            }
                            if (TemplateId.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(TemplateId);
                            }
                            if (RelyingPartyId.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(RelyingPartyId);
                            }
                            if (ReferenceId.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(ReferenceId);
                            }
                            if (_unknownFields != null)
                            {
                                size += _unknownFields.CalculateSize();
                            }
                            return size;
                        }

                        public void MergeFrom(HydraCredential other)
                        {
                            if (other == null)
                            {
                                return;
                            }
                            if (other.CredentialId.Length != 0)
                            {
                                CredentialId = other.CredentialId;
                            }
                            if (other.SharingInstanceId.Length != 0)
                            {
                                SharingInstanceId = other.SharingInstanceId;
                            }
                            if (other.AccountHash.Length != 0)
                            {
                                AccountHash = other.AccountHash;
                            }
                            if (other.TemplateId.Length != 0)
                            {
                                TemplateId = other.TemplateId;
                            }
                            if (other.RelyingPartyId.Length != 0)
                            {
                                RelyingPartyId = other.RelyingPartyId;
                            }
                            if (other.ReferenceId.Length != 0)
                            {
                                ReferenceId = other.ReferenceId;
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
                #endregion

            }

        }
        #endregion

    }

    /// <summary>
    /// The request message for [`GetDigitalKey`][salto.nebula.digitalkey.v1.DigitalKeyService.GetDigitalKey]
    /// </summary>
    public sealed partial class GetDigitalKeyRequest : IMessage<GetDigitalKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetDigitalKeyRequest> _parser = new(() => new GetDigitalKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetDigitalKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetDigitalKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetDigitalKeyRequest(GetDigitalKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetDigitalKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested digital key resource. For example:
        /// `digital-keys/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetDigitalKeyRequest);
        public bool Equals(GetDigitalKeyRequest other)
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

        public void MergeFrom(GetDigitalKeyRequest other)
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
    /// The request message for [`ListDigitalKeys`][salto.nebula.digitalkey.v1.DigitalKeyService.ListDigitalKeys]
    /// </summary>
    public sealed partial class ListDigitalKeysRequest : IMessage<ListDigitalKeysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDigitalKeysRequest> _parser = new(() => new ListDigitalKeysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDigitalKeysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDigitalKeysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDigitalKeysRequest(ListDigitalKeysRequest other) : this()
        {
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDigitalKeysRequest Clone() => new(this);
        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 1;
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
        public const int PageTokenFieldNumber = 2;
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
        public const int FilterFieldNumber = 3;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which digital keys to return.
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
        public const int OrderByFieldNumber = 4;
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

        public override bool Equals(object other) => Equals(other as ListDigitalKeysRequest);
        public bool Equals(ListDigitalKeysRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            if (OrderBy != other.OrderBy) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (PageSize != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(34);
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
            if (PageSize != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Filter);
            }
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(OrderBy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
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

        public void MergeFrom(ListDigitalKeysRequest other)
        {
            if (other == null)
            {
                return;
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
          case 8: {
            PageSize = input.ReadInt32();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
          case 26: {
            Filter = input.ReadString();
            break;
          }
          case 34: {
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
                    case 8:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 18:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 34:
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
    /// The response message for [`ListDigitalKeys`][salto.nebula.digitalkey.v1.DigitalKeyService.ListDigitalKeys]
    /// </summary>
    public sealed partial class ListDigitalKeysResponse : IMessage<ListDigitalKeysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDigitalKeysResponse> _parser = new(() => new ListDigitalKeysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDigitalKeysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDigitalKeysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDigitalKeysResponse(ListDigitalKeysResponse other) : this()
        {
            digitalKeys_ = other.digitalKeys_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDigitalKeysResponse Clone() => new(this);
        /// <summary>Field number for the "digital_keys" field.</summary>
        public const int DigitalKeysFieldNumber = 1;
        private static readonly FieldCodec<DigitalKey> _repeated_digitalKeys_codec
            = FieldCodec.ForMessage(10, DigitalKey.Parser);
        private readonly RepeatedField<DigitalKey> digitalKeys_ = [];

        /// <summary>
        /// The field name should match the noun `digital_keys` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<DigitalKey> DigitalKeys
        {
            get { return digitalKeys_; }
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

        public override bool Equals(object other) => Equals(other as ListDigitalKeysResponse);
        public bool Equals(ListDigitalKeysResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!digitalKeys_.Equals(other.digitalKeys_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= digitalKeys_.GetHashCode();
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
      digitalKeys_.WriteTo(output, _repeated_digitalKeys_codec);
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
            digitalKeys_.WriteTo(ref output, _repeated_digitalKeys_codec);
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
            size += digitalKeys_.CalculateSize(_repeated_digitalKeys_codec);
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

        public void MergeFrom(ListDigitalKeysResponse other)
        {
            if (other == null)
            {
                return;
            }
            digitalKeys_.Add(other.digitalKeys_);
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
            digitalKeys_.AddEntriesFrom(input, _repeated_digitalKeys_codec);
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
                            digitalKeys_.AddEntriesFrom(ref input, _repeated_digitalKeys_codec);
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
    /// The digital key's access point association
    /// </summary>
    public sealed partial class DigitalKeyAccessPoint : IMessage<DigitalKeyAccessPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DigitalKeyAccessPoint> _parser = new(() => new DigitalKeyAccessPoint());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DigitalKeyAccessPoint> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DigitalKeyAccessPoint()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DigitalKeyAccessPoint(DigitalKeyAccessPoint other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            supportedTechnologies_ = other.supportedTechnologies_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DigitalKeyAccessPoint Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        ///  Resource name of the access point. It must have the format
        /// `digital-keys/{digital-key}/access-points/*`. For example:
        /// `digital-keys/baker-street-key/access-points/baker-street-entrance`.
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
        /// Display name of the access point.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 3;
        private string deviceId_ = "";

        /// <summary>
        /// The device which gives coverage to the access point.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "supported_technologies" field.</summary>
        public const int SupportedTechnologiesFieldNumber = 4;
        private static readonly FieldCodec<Type.AppKeyTechnology> _repeated_supportedTechnologies_codec
            = FieldCodec.ForEnum(34, x => (int)x, x => (Type.AppKeyTechnology)x);
        private readonly RepeatedField<Type.AppKeyTechnology> supportedTechnologies_ = [];

        /// <summary>
        /// Supported technologies used by the app to open an access point.
        /// </summary>
        public RepeatedField<Type.AppKeyTechnology> SupportedTechnologies
        {
            get { return supportedTechnologies_; }
        }

        public override bool Equals(object other) => Equals(other as DigitalKeyAccessPoint);
        public bool Equals(DigitalKeyAccessPoint other)
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
            if (DeviceId != other.DeviceId) return false;
            if (!supportedTechnologies_.Equals(other.supportedTechnologies_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
            hash ^= supportedTechnologies_.GetHashCode();
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
      if (DeviceId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DeviceId);
      }
      supportedTechnologies_.WriteTo(output, _repeated_supportedTechnologies_codec);
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
            if (DeviceId.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DeviceId);
            }
            supportedTechnologies_.WriteTo(ref output, _repeated_supportedTechnologies_codec);
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
            if (DeviceId.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            size += supportedTechnologies_.CalculateSize(_repeated_supportedTechnologies_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DigitalKeyAccessPoint other)
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
            if (other.DeviceId.Length != 0)
            {
                DeviceId = other.DeviceId;
            }
            supportedTechnologies_.Add(other.supportedTechnologies_);
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
            DeviceId = input.ReadString();
            break;
          }
          case 34:
          case 32: {
            supportedTechnologies_.AddEntriesFrom(input, _repeated_supportedTechnologies_codec);
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
                            DeviceId = input.ReadString();
                            break;
                        }
                    case 34:
                    case 32:
                        {
                            supportedTechnologies_.AddEntriesFrom(ref input, _repeated_supportedTechnologies_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetDigitalKeyAccessPoint`][salto.nebula.digitalkey.v1.DigitalKeyService.GetDigitalKeyAccessPoint]
    /// </summary>
    public sealed partial class GetDigitalKeyAccessPointRequest : IMessage<GetDigitalKeyAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetDigitalKeyAccessPointRequest> _parser = new(() => new GetDigitalKeyAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetDigitalKeyAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetDigitalKeyAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetDigitalKeyAccessPointRequest(GetDigitalKeyAccessPointRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetDigitalKeyAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested access point resource. For example:
        /// `digital-keys/baker-street-key/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetDigitalKeyAccessPointRequest);
        public bool Equals(GetDigitalKeyAccessPointRequest other)
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

        public void MergeFrom(GetDigitalKeyAccessPointRequest other)
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
    /// The request message for [`ListDigitalKeyAccessPoints`][salto.nebula.digitalkey.v1.DigitalKeyService.ListDigitalKeyAccessPoints]
    /// </summary>
    public sealed partial class ListDigitalKeyAccessPointsRequest : IMessage<ListDigitalKeyAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDigitalKeyAccessPointsRequest> _parser = new(() => new ListDigitalKeyAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDigitalKeyAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDigitalKeyAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDigitalKeyAccessPointsRequest(ListDigitalKeyAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            filter_ = other.filter_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDigitalKeyAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example, `digital-keys/baker-street-key`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 2;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which access points to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 3;
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
        public const int PageTokenFieldNumber = 4;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
        /// Note: this field is not being used in the current implementation. It is being ignored.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListDigitalKeyAccessPointsRequest);
        public bool Equals(ListDigitalKeyAccessPointsRequest other)
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
            if (Filter != other.Filter) return false;
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
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
      if (Filter.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Filter);
      }
      if (PageSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PageToken);
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
            if (Filter.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Filter);
            }
            if (PageSize != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(PageToken);
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
            if (Filter.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            }
            if (PageSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            }
            if (PageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListDigitalKeyAccessPointsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.Filter.Length != 0)
            {
                Filter = other.Filter;
            }
            if (other.PageSize != 0)
            {
                PageSize = other.PageSize;
            }
            if (other.PageToken.Length != 0)
            {
                PageToken = other.PageToken;
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
            Filter = input.ReadString();
            break;
          }
          case 24: {
            PageSize = input.ReadInt32();
            break;
          }
          case 34: {
            PageToken = input.ReadString();
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
                            Filter = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 34:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListDigitalKeyAccessPoints`][salto.nebula.digitalkey.v1.DigitalKeyService.ListDigitalKeyAccessPoints]
    /// </summary>
    public sealed partial class ListDigitalKeyAccessPointsResponse : IMessage<ListDigitalKeyAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDigitalKeyAccessPointsResponse> _parser = new(() => new ListDigitalKeyAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDigitalKeyAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDigitalKeyAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDigitalKeyAccessPointsResponse(ListDigitalKeyAccessPointsResponse other) : this()
        {
            digitalKeyAccessPoints_ = other.digitalKeyAccessPoints_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDigitalKeyAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "digital_key_access_points" field.</summary>
        public const int DigitalKeyAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<DigitalKeyAccessPoint> _repeated_digitalKeyAccessPoints_codec
            = FieldCodec.ForMessage(10, DigitalKeyAccessPoint.Parser);
        private readonly RepeatedField<DigitalKeyAccessPoint> digitalKeyAccessPoints_ = [];

        /// <summary>
        /// The field name should match the noun `digital_key_access_points` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<DigitalKeyAccessPoint> DigitalKeyAccessPoints
        {
            get { return digitalKeyAccessPoints_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// Note: this field is not being used in the current implementation. It always returns an empty string.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListDigitalKeyAccessPointsResponse);
        public bool Equals(ListDigitalKeyAccessPointsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!digitalKeyAccessPoints_.Equals(other.digitalKeyAccessPoints_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= digitalKeyAccessPoints_.GetHashCode();
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
      digitalKeyAccessPoints_.WriteTo(output, _repeated_digitalKeyAccessPoints_codec);
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
            digitalKeyAccessPoints_.WriteTo(ref output, _repeated_digitalKeyAccessPoints_codec);
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
            size += digitalKeyAccessPoints_.CalculateSize(_repeated_digitalKeyAccessPoints_codec);
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

        public void MergeFrom(ListDigitalKeyAccessPointsResponse other)
        {
            if (other == null)
            {
                return;
            }
            digitalKeyAccessPoints_.Add(other.digitalKeyAccessPoints_);
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
            digitalKeyAccessPoints_.AddEntriesFrom(input, _repeated_digitalKeyAccessPoints_codec);
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
                            digitalKeyAccessPoints_.AddEntriesFrom(ref input, _repeated_digitalKeyAccessPoints_codec);
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
    /// The request message for [`SyncDigitalKeyAccessPoints`][salto.nebula.digitalkey.v1.DigitalKeyService.SyncDigitalKeyAccessPointsRequest]
    /// </summary>
    public sealed partial class SyncDigitalKeyAccessPointsRequest : IMessage<SyncDigitalKeyAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<SyncDigitalKeyAccessPointsRequest> _parser = new(() => new SyncDigitalKeyAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<SyncDigitalKeyAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public SyncDigitalKeyAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public SyncDigitalKeyAccessPointsRequest(SyncDigitalKeyAccessPointsRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public SyncDigitalKeyAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested digital key resource to compute its access points. For example:
        /// `digital-keys/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as SyncDigitalKeyAccessPointsRequest);
        public bool Equals(SyncDigitalKeyAccessPointsRequest other)
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

        public void MergeFrom(SyncDigitalKeyAccessPointsRequest other)
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
    /// The empty response message for [`SyncDigitalKeyAccessPoints`][salto.nebula.digitalkey.v1.DigitalKeyService.SyncDigitalKeyAccessPoints]
    /// </summary>
    public sealed partial class SyncDigitalKeyAccessPointsResponse : IMessage<SyncDigitalKeyAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<SyncDigitalKeyAccessPointsResponse> _parser = new(() => new SyncDigitalKeyAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<SyncDigitalKeyAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public SyncDigitalKeyAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public SyncDigitalKeyAccessPointsResponse(SyncDigitalKeyAccessPointsResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public SyncDigitalKeyAccessPointsResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as SyncDigitalKeyAccessPointsResponse);
        public bool Equals(SyncDigitalKeyAccessPointsResponse other)
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

        public void MergeFrom(SyncDigitalKeyAccessPointsResponse other)
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
    /// The empty metadata message for [`SyncDigitalKeyAccessPoints`][salto.nebula.digitalkey.v1.DigitalKeyService.SyncDigitalKeyAccessPoints]
    /// </summary>
    public sealed partial class SyncDigitalKeyAccessPointsMetadata : IMessage<SyncDigitalKeyAccessPointsMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<SyncDigitalKeyAccessPointsMetadata> _parser = new(() => new SyncDigitalKeyAccessPointsMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<SyncDigitalKeyAccessPointsMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public SyncDigitalKeyAccessPointsMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public SyncDigitalKeyAccessPointsMetadata(SyncDigitalKeyAccessPointsMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public SyncDigitalKeyAccessPointsMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as SyncDigitalKeyAccessPointsMetadata);
        public bool Equals(SyncDigitalKeyAccessPointsMetadata other)
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

        public void MergeFrom(SyncDigitalKeyAccessPointsMetadata other)
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
    /// The request message for [`UnlockDigitalKeyAccessPoint`][salto.nebula.digitalkey.v1.DigitalKeyService.UnlockDigitalKeyAccessPoint]
    /// </summary>
    public sealed partial class UnlockDigitalKeyAccessPointRequest : IMessage<UnlockDigitalKeyAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnlockDigitalKeyAccessPointRequest> _parser = new(() => new UnlockDigitalKeyAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnlockDigitalKeyAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnlockDigitalKeyAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnlockDigitalKeyAccessPointRequest(UnlockDigitalKeyAccessPointRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnlockDigitalKeyAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the access point to be unlocked. For example:
        /// `digital-keys/baker-street-key/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UnlockDigitalKeyAccessPointRequest);
        public bool Equals(UnlockDigitalKeyAccessPointRequest other)
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

        public void MergeFrom(UnlockDigitalKeyAccessPointRequest other)
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
    /// The empty response message for [`UnlockAccessPoint`][salto.nebula.digitalkey.v1.DigitalKeyService.UnlockDigitalKeyAccessPoint]
    /// </summary>
    public sealed partial class UnlockDigitalKeyAccessPointResponse : IMessage<UnlockDigitalKeyAccessPointResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnlockDigitalKeyAccessPointResponse> _parser = new(() => new UnlockDigitalKeyAccessPointResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnlockDigitalKeyAccessPointResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnlockDigitalKeyAccessPointResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnlockDigitalKeyAccessPointResponse(UnlockDigitalKeyAccessPointResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnlockDigitalKeyAccessPointResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnlockDigitalKeyAccessPointResponse);
        public bool Equals(UnlockDigitalKeyAccessPointResponse other)
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

        public void MergeFrom(UnlockDigitalKeyAccessPointResponse other)
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
    /// The metadata message for [`UnlockAccessPoint`][salto.nebula.digitalkey.v1.DigitalKeyService.UnlockDigitalKeyAccessPoint]
    /// </summary>
    public sealed partial class UnlockDigitalKeyAccessPointMetadata : IMessage<UnlockDigitalKeyAccessPointMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnlockDigitalKeyAccessPointMetadata> _parser = new(() => new UnlockDigitalKeyAccessPointMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnlockDigitalKeyAccessPointMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DigitalKeyReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnlockDigitalKeyAccessPointMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnlockDigitalKeyAccessPointMetadata(UnlockDigitalKeyAccessPointMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnlockDigitalKeyAccessPointMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnlockDigitalKeyAccessPointMetadata);
        public bool Equals(UnlockDigitalKeyAccessPointMetadata other)
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

        public void MergeFrom(UnlockDigitalKeyAccessPointMetadata other)
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
