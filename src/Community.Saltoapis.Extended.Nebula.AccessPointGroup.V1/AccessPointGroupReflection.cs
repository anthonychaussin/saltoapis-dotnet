using Saltoapis.Nebula.AccessPointGroup.V1.Request;
using Saltoapis.Nebula.AccessPointGroup.V1.Response;

namespace Saltoapis.Nebula.AccessPointGroup.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/accesspointgroup/v1/access_point_group.proto</summary>
    public static partial class AccessPointGroupReflection
    {

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

    }


}
