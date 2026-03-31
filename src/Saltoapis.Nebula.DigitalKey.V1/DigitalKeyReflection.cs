using Google.Protobuf.Reflection;
using Saltoapis.Nebula.DigitalKey.V1.Request;
using Saltoapis.Nebula.DigitalKey.V1.Response;

namespace Saltoapis.Nebula.DigitalKey.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/digitalkey/v1/digital_key.proto</summary>
    public static partial class DigitalKeyReflection
    {

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

    }


}
