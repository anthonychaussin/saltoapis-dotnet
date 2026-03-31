using Saltoapis.Longrunning.V1.Request;
using Saltoapis.Longrunning.V1.Response;

namespace Saltoapis.Longrunning.V1
{
    /// <summary>Holder for reflection information generated from salto/longrunning/v1/operation.proto</summary>
    public static partial class OperationReflection
    {

        /// <summary>File descriptor for salto/longrunning/v1/operation.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static OperationReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiRzYWx0by9sb25ncnVubmluZy92MS9vcGVyYXRpb24ucHJvdG8SFHNhbHRv",
                  "LmxvbmdydW5uaW5nLnYxGhlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvGhtn",
                  "b29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aF2dvb2dsZS9ycGMvc3RhdHVz",
                  "LnByb3RvIqgBCglPcGVyYXRpb24SDAoEbmFtZRgBIAEoCRImCghtZXRhZGF0",
                  "YRgCIAEoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnkSDAoEZG9uZRgDIAEoCBIj",
                  "CgVlcnJvchgEIAEoCzISLmdvb2dsZS5ycGMuU3RhdHVzSAASKAoIcmVzcG9u",
                  "c2UYBSABKAsyFC5nb29nbGUucHJvdG9idWYuQW55SABCCAoGcmVzdWx0IiMK",
                  "E0dldE9wZXJhdGlvblJlcXVlc3QSDAoEbmFtZRgBIAEoCSJOChVMaXN0T3Bl",
                  "cmF0aW9uc1JlcXVlc3QSEQoJcGFnZV9zaXplGAEgASgFEhIKCnBhZ2VfdG9r",
                  "ZW4YAiABKAkSDgoGZmlsdGVyGAMgASgJImYKFkxpc3RPcGVyYXRpb25zUmVz",
                  "cG9uc2USMwoKb3BlcmF0aW9ucxgBIAMoCzIfLnNhbHRvLmxvbmdydW5uaW5n",
                  "LnYxLk9wZXJhdGlvbhIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAkiJgoWRGVs",
                  "ZXRlT3BlcmF0aW9uUmVxdWVzdBIMCgRuYW1lGAEgASgJIiYKFkNhbmNlbE9w",
                  "ZXJhdGlvblJlcXVlc3QSDAoEbmFtZRgBIAEoCTKNAwoQT3BlcmF0aW9uU2Vy",
                  "dmljZRJaCgxHZXRPcGVyYXRpb24SKS5zYWx0by5sb25ncnVubmluZy52MS5H",
                  "ZXRPcGVyYXRpb25SZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3Bl",
                  "cmF0aW9uEmsKDkxpc3RPcGVyYXRpb25zEisuc2FsdG8ubG9uZ3J1bm5pbmcu",
                  "djEuTGlzdE9wZXJhdGlvbnNSZXF1ZXN0Giwuc2FsdG8ubG9uZ3J1bm5pbmcu",
                  "djEuTGlzdE9wZXJhdGlvbnNSZXNwb25zZRJXCg9EZWxldGVPcGVyYXRpb24S",
                  "LC5zYWx0by5sb25ncnVubmluZy52MS5EZWxldGVPcGVyYXRpb25SZXF1ZXN0",
                  "GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ElcKD0NhbmNlbE9wZXJhdGlvbhIs",
                  "LnNhbHRvLmxvbmdydW5uaW5nLnYxLkNhbmNlbE9wZXJhdGlvblJlcXVlc3Qa",
                  "Fi5nb29nbGUucHJvdG9idWYuRW1wdHlC1AEKHGNvbS5zYWx0b2FwaXMubG9u",
                  "Z3J1bm5pbmcudjFCDk9wZXJhdGlvblByb3RvUAFaRWdpdGh1Yi5jb20vc2Fs",
                  "dG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby9sb25ncnVubmluZy92MTts",
                  "b25ncnVubmluZ6oCGFNhbHRvYXBpcy5Mb25ncnVubmluZy5WMcoCGFNhbHRv",
                  "YXBpc1xMb25ncnVubmluZ1xWMeICJEdQQk1ldGFkYXRhXFNhbHRvYXBpc1xM",
                  "b25ncnVubmluZ1xWMWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Rpc.StatusReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Operation), Operation.Parser, ["Name", "Metadata", "Done", "Error", "Response"], ["Result"], null, null, null),
            new(typeof(GetOperationRequest), GetOperationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListOperationsRequest), ListOperationsRequest.Parser, ["PageSize", "PageToken", "Filter"], null, null, null, null),
            new(typeof(ListOperationsResponse), ListOperationsResponse.Parser, ["Operations", "NextPageToken"], null, null, null, null),
            new(typeof(DeleteOperationRequest), DeleteOperationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CancelOperationRequest), CancelOperationRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }

    }
}