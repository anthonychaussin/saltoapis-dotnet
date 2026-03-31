using Google.Protobuf.Reflection;
using Saltoapis.Nebula.Destination.V1.Request;
using Saltoapis.Nebula.Destination.V1.Response;

namespace Saltoapis.Nebula.Destination.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/destination/v1/destination.proto</summary>
    public static partial class DestinationReflection
    {

        /// <summary>File descriptor for salto/nebula/destination/v1/destination.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static DestinationReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ci1zYWx0by9uZWJ1bGEvZGVzdGluYXRpb24vdjEvZGVzdGluYXRpb24ucHJv",
                  "dG8SG3NhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MRobZ29vZ2xlL3Byb3Rv",
                  "YnVmL2VtcHR5LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5w",
                  "cm90byIxCgtEZXN0aW5hdGlvbhIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlf",
                  "bmFtZRgCIAEoCSKZAQoYQ3JlYXRlRGVzdGluYXRpb25SZXF1ZXN0Eg4KBnBh",
                  "cmVudBgBIAEoCRIbCg5kZXN0aW5hdGlvbl9pZBgCIAEoCUgAiAEBEj0KC2Rl",
                  "c3RpbmF0aW9uGAMgASgLMiguc2FsdG8ubmVidWxhLmRlc3RpbmF0aW9uLnYx",
                  "LkRlc3RpbmF0aW9uQhEKD19kZXN0aW5hdGlvbl9pZCIlChVHZXREZXN0aW5h",
                  "dGlvblJlcXVlc3QSDAoEbmFtZRgBIAEoCSI8ChtCYXRjaEdldERlc3RpbmF0",
                  "aW9uc1JlcXVlc3QSDgoGcGFyZW50GAEgASgJEg0KBW5hbWVzGAIgAygJIl4K",
                  "HEJhdGNoR2V0RGVzdGluYXRpb25zUmVzcG9uc2USPgoMZGVzdGluYXRpb25z",
                  "GAEgAygLMiguc2FsdG8ubmVidWxhLmRlc3RpbmF0aW9uLnYxLkRlc3RpbmF0",
                  "aW9uIooBChhVcGRhdGVEZXN0aW5hdGlvblJlcXVlc3QSPQoLZGVzdGluYXRp",
                  "b24YASABKAsyKC5zYWx0by5uZWJ1bGEuZGVzdGluYXRpb24udjEuRGVzdGlu",
                  "YXRpb24SLwoLdXBkYXRlX21hc2sYAiABKAsyGi5nb29nbGUucHJvdG9idWYu",
                  "RmllbGRNYXNrInIKF0xpc3REZXN0aW5hdGlvbnNSZXF1ZXN0Eg4KBnBhcmVu",
                  "dBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tlbhgDIAEo",
                  "CRIOCgZmaWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkYBSABKAkicwoYTGlzdERl",
                  "c3RpbmF0aW9uc1Jlc3BvbnNlEj4KDGRlc3RpbmF0aW9ucxgBIAMoCzIoLnNh",
                  "bHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MS5EZXN0aW5hdGlvbhIXCg9uZXh0",
                  "X3BhZ2VfdG9rZW4YAiABKAkiKAoYRGVsZXRlRGVzdGluYXRpb25SZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAky4wUKEkRlc3RpbmF0aW9uU2VydmljZRJ0ChFDcmVh",
                  "dGVEZXN0aW5hdGlvbhI1LnNhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MS5D",
                  "cmVhdGVEZXN0aW5hdGlvblJlcXVlc3QaKC5zYWx0by5uZWJ1bGEuZGVzdGlu",
                  "YXRpb24udjEuRGVzdGluYXRpb24SbgoOR2V0RGVzdGluYXRpb24SMi5zYWx0",
                  "by5uZWJ1bGEuZGVzdGluYXRpb24udjEuR2V0RGVzdGluYXRpb25SZXF1ZXN0",
                  "Giguc2FsdG8ubmVidWxhLmRlc3RpbmF0aW9uLnYxLkRlc3RpbmF0aW9uEosB",
                  "ChRCYXRjaEdldERlc3RpbmF0aW9ucxI4LnNhbHRvLm5lYnVsYS5kZXN0aW5h",
                  "dGlvbi52MS5CYXRjaEdldERlc3RpbmF0aW9uc1JlcXVlc3QaOS5zYWx0by5u",
                  "ZWJ1bGEuZGVzdGluYXRpb24udjEuQmF0Y2hHZXREZXN0aW5hdGlvbnNSZXNw",
                  "b25zZRJ0ChFVcGRhdGVEZXN0aW5hdGlvbhI1LnNhbHRvLm5lYnVsYS5kZXN0",
                  "aW5hdGlvbi52MS5VcGRhdGVEZXN0aW5hdGlvblJlcXVlc3QaKC5zYWx0by5u",
                  "ZWJ1bGEuZGVzdGluYXRpb24udjEuRGVzdGluYXRpb24SfwoQTGlzdERlc3Rp",
                  "bmF0aW9ucxI0LnNhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MS5MaXN0RGVz",
                  "dGluYXRpb25zUmVxdWVzdBo1LnNhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52",
                  "MS5MaXN0RGVzdGluYXRpb25zUmVzcG9uc2USYgoRRGVsZXRlRGVzdGluYXRp",
                  "b24SNS5zYWx0by5uZWJ1bGEuZGVzdGluYXRpb24udjEuRGVsZXRlRGVzdGlu",
                  "YXRpb25SZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5QvkBCiNjb20u",
                  "c2FsdG9hcGlzLm5lYnVsYS5kZXN0aW5hdGlvbi52MUIQRGVzdGluYXRpb25Q",
                  "cm90b1ABWkxnaXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2Fw",
                  "aXMtZ28vbmVidWxhL2Rlc3RpbmF0aW9uL3YxO2Rlc3RpbmF0aW9uqgIfU2Fs",
                  "dG9hcGlzLk5lYnVsYS5EZXN0aW5hdGlvbi5WMcoCH1NhbHRvYXBpc1xOZWJ1",
                  "bGFcRGVzdGluYXRpb25cVjHiAitHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVi",
                  "dWxhXERlc3RpbmF0aW9uXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Destination), Destination.Parser, ["Name", "DisplayName"], null, null, null, null),
            new(typeof(CreateDestinationRequest), CreateDestinationRequest.Parser, ["Parent", "DestinationId", "Destination"], ["DestinationId"], null, null, null),
            new(typeof(GetDestinationRequest), GetDestinationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BatchGetDestinationsRequest), BatchGetDestinationsRequest.Parser, ["Parent", "Names"], null, null, null, null),
            new(typeof(BatchGetDestinationsResponse), BatchGetDestinationsResponse.Parser, ["Destinations"], null, null, null, null),
            new(typeof(UpdateDestinationRequest), UpdateDestinationRequest.Parser, ["Destination", "UpdateMask"], null, null, null, null),
            new(typeof(ListDestinationsRequest), ListDestinationsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListDestinationsResponse), ListDestinationsResponse.Parser, ["Destinations", "NextPageToken"], null, null, null, null),
            new(typeof(DeleteDestinationRequest), DeleteDestinationRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }

    }


}
