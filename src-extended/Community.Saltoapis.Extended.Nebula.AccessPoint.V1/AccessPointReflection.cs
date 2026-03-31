using Saltoapis.Nebula.AccessPoint.V1.Request;
using Saltoapis.Nebula.AccessPoint.V1.Response;

namespace Saltoapis.Nebula.AccessPoint.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/accesspoint/v1/access_point.proto</summary>
    public static partial class AccessPointReflection
    {
        /// <summary>File descriptor for salto/nebula/accesspoint/v1/access_point.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static AccessPointReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ci5zYWx0by9uZWJ1bGEvYWNjZXNzcG9pbnQvdjEvYWNjZXNzX3BvaW50LnBy",
                  "b3RvEhtzYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEaHmdvb2dsZS9wcm90",
                  "b2J1Zi9kdXJhdGlvbi5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
                  "b3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxokc2FsdG8v",
                  "bG9uZ3J1bm5pbmcvdjEvb3BlcmF0aW9uLnByb3RvGiRzYWx0by9uZWJ1bGEv",
                  "dHlwZS9vcGVuaW5nX21vZGUucHJvdG8ilQMKC0FjY2Vzc1BvaW50EgwKBG5h",
                  "bWUYASABKAkSFAoMZGlzcGxheV9uYW1lGAIgASgJEi8KBWZpeGVkGAMgASgO",
                  "Mh4uc2FsdG8ubmVidWxhLnR5cGUuT3BlbmluZ01vZGVIABISCghzY2hlZHVs",
                  "ZRgEIAEoCUgAEhUKCGNhbGVuZGFyGAUgASgJSAKIAQESHQoQY2FyZF9rZXlf",
                  "dXBkYXRlchgGIAEoCEgDiAEBEjcKD3VubG9ja19kdXJhdGlvbhgHIAEoCzIZ",
                  "Lmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbkgEiAEBEhEKCWxlZnRfb3BlbhgI",
                  "IAEoCBIZCg9lbGVjdHJvbmljX2xvY2sYCSABKAlIARIUCgpjb250cm9sbGVy",
                  "GAogASgJSAESGgoQaW50ZXJjb21fYWRhcHRvchgLIAEoCUgBQg4KDG9wZW5p",
                  "bmdfbW9kZUIICgZzb3VyY2VCCwoJX2NhbGVuZGFyQhMKEV9jYXJkX2tleV91",
                  "cGRhdGVyQhIKEF91bmxvY2tfZHVyYXRpb24inAEKGENyZWF0ZUFjY2Vzc1Bv",
                  "aW50UmVxdWVzdBIOCgZwYXJlbnQYASABKAkSHAoPYWNjZXNzX3BvaW50X2lk",
                  "GAIgASgJSACIAQESPgoMYWNjZXNzX3BvaW50GAMgASgLMiguc2FsdG8ubmVi",
                  "dWxhLmFjY2Vzc3BvaW50LnYxLkFjY2Vzc1BvaW50QhIKEF9hY2Nlc3NfcG9p",
                  "bnRfaWQiJQoVR2V0QWNjZXNzUG9pbnRSZXF1ZXN0EgwKBG5hbWUYASABKAki",
                  "cgoXTGlzdEFjY2Vzc1BvaW50c1JlcXVlc3QSDgoGcGFyZW50GAEgASgJEhEK",
                  "CXBhZ2Vfc2l6ZRgCIAEoBRISCgpwYWdlX3Rva2VuGAMgASgJEg4KBmZpbHRl",
                  "chgEIAEoCRIQCghvcmRlcl9ieRgFIAEoCSKIAQoYTGlzdEFjY2Vzc1BvaW50",
                  "c1Jlc3BvbnNlEj8KDWFjY2Vzc19wb2ludHMYASADKAsyKC5zYWx0by5uZWJ1",
                  "bGEuYWNjZXNzcG9pbnQudjEuQWNjZXNzUG9pbnQSFwoPbmV4dF9wYWdlX3Rv",
                  "a2VuGAIgASgJEhIKCnRvdGFsX3NpemUYAyABKAUiiwEKGFVwZGF0ZUFjY2Vz",
                  "c1BvaW50UmVxdWVzdBI+CgxhY2Nlc3NfcG9pbnQYASABKAsyKC5zYWx0by5u",
                  "ZWJ1bGEuYWNjZXNzcG9pbnQudjEuQWNjZXNzUG9pbnQSLwoLdXBkYXRlX21h",
                  "c2sYAiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIigKGERlbGV0",
                  "ZUFjY2Vzc1BvaW50UmVxdWVzdBIMCgRuYW1lGAEgASgJIigKGFVubG9ja0Fj",
                  "Y2Vzc1BvaW50UmVxdWVzdBIMCgRuYW1lGAEgASgJIhsKGVVubG9ja0FjY2Vz",
                  "c1BvaW50UmVzcG9uc2UiGwoZVW5sb2NrQWNjZXNzUG9pbnRNZXRhZGF0YSIm",
                  "ChZMb2NrQWNjZXNzUG9pbnRSZXF1ZXN0EgwKBG5hbWUYASABKAkiGQoXTG9j",
                  "a0FjY2Vzc1BvaW50UmVzcG9uc2UiGQoXTG9ja0FjY2Vzc1BvaW50TWV0YWRh",
                  "dGEyqwYKEkFjY2Vzc1BvaW50U2VydmljZRJ0ChFDcmVhdGVBY2Nlc3NQb2lu",
                  "dBI1LnNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludC52MS5DcmVhdGVBY2Nlc3NQ",
                  "b2ludFJlcXVlc3QaKC5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEuQWNj",
                  "ZXNzUG9pbnQSbgoOR2V0QWNjZXNzUG9pbnQSMi5zYWx0by5uZWJ1bGEuYWNj",
                  "ZXNzcG9pbnQudjEuR2V0QWNjZXNzUG9pbnRSZXF1ZXN0Giguc2FsdG8ubmVi",
                  "dWxhLmFjY2Vzc3BvaW50LnYxLkFjY2Vzc1BvaW50En8KEExpc3RBY2Nlc3NQ",
                  "b2ludHMSNC5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEuTGlzdEFjY2Vz",
                  "c1BvaW50c1JlcXVlc3QaNS5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEu",
                  "TGlzdEFjY2Vzc1BvaW50c1Jlc3BvbnNlEnQKEVVwZGF0ZUFjY2Vzc1BvaW50",
                  "EjUuc2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50LnYxLlVwZGF0ZUFjY2Vzc1Bv",
                  "aW50UmVxdWVzdBooLnNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludC52MS5BY2Nl",
                  "c3NQb2ludBJiChFEZWxldGVBY2Nlc3NQb2ludBI1LnNhbHRvLm5lYnVsYS5h",
                  "Y2Nlc3Nwb2ludC52MS5EZWxldGVBY2Nlc3NQb2ludFJlcXVlc3QaFi5nb29n",
                  "bGUucHJvdG9idWYuRW1wdHkSawoRVW5sb2NrQWNjZXNzUG9pbnQSNS5zYWx0",
                  "by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEuVW5sb2NrQWNjZXNzUG9pbnRSZXF1",
                  "ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uEmcKD0xvY2tB",
                  "Y2Nlc3NQb2ludBIzLnNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludC52MS5Mb2Nr",
                  "QWNjZXNzUG9pbnRSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3Bl",
                  "cmF0aW9uQvkBCiNjb20uc2FsdG9hcGlzLm5lYnVsYS5hY2Nlc3Nwb2ludC52",
                  "MUIQQWNjZXNzUG9pbnRQcm90b1ABWkxnaXRodWIuY29tL3NhbHRvYXBpcy1p",
                  "bnRlcm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL2FjY2Vzc3BvaW50L3YxO2Fj",
                  "Y2Vzc3BvaW50qgIfU2FsdG9hcGlzLk5lYnVsYS5BY2Nlc3NQb2ludC5WMcoC",
                  "H1NhbHRvYXBpc1xOZWJ1bGFcQWNjZXNzUG9pbnRcVjHiAitHUEJNZXRhZGF0",
                  "YVxTYWx0b2FwaXNcTmVidWxhXEFjY2Vzc1BvaW50XFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.OpeningModeReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(AccessPoint), AccessPoint.Parser, ["Name", "DisplayName", "Fixed", "Schedule", "Calendar", "CardKeyUpdater", "UnlockDuration", "LeftOpen", "ElectronicLock", "Controller", "IntercomAdaptor"], ["OpeningMode", "Source", "Calendar", "CardKeyUpdater", "UnlockDuration"], null, null, null),
            new(typeof(CreateAccessPointRequest), CreateAccessPointRequest.Parser, ["Parent", "AccessPointId", "AccessPoint"], ["AccessPointId"], null, null, null),
            new(typeof(GetAccessPointRequest), GetAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListAccessPointsRequest), ListAccessPointsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListAccessPointsResponse), ListAccessPointsResponse.Parser, ["AccessPoints", "NextPageToken", "TotalSize"], null, null, null, null),
            new(typeof(UpdateAccessPointRequest), UpdateAccessPointRequest.Parser, ["AccessPoint", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteAccessPointRequest), DeleteAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(UnlockAccessPointRequest), UnlockAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(UnlockAccessPointResponse), UnlockAccessPointResponse.Parser, null, null, null, null, null),
            new(typeof(UnlockAccessPointMetadata), UnlockAccessPointMetadata.Parser, null, null, null, null, null),
            new(typeof(LockAccessPointRequest), LockAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(LockAccessPointResponse), LockAccessPointResponse.Parser, null, null, null, null, null),
            new(typeof(LockAccessPointMetadata), LockAccessPointMetadata.Parser, null, null, null, null, null)
                ]));
        }
    }

}