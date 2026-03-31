using Saltoapis.Nebula.Event.V1.Request;
using Saltoapis.Nebula.Event.V1.Response;

namespace Saltoapis.Nebula.Event.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/event/v1/event.proto</summary>
    public static partial class EventReflection
    {
        /// <summary>File descriptor for salto/nebula/event/v1/event.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static EventReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiFzYWx0by9uZWJ1bGEvZXZlbnQvdjEvZXZlbnQucHJvdG8SFXNhbHRvLm5l",
                  "YnVsYS5ldmVudC52MRocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxof",
                  "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byK9AQoFRXZlbnQSDAoE",
                  "bmFtZRgBIAEoCRIMCgR0eXBlGAIgASgJEhAKCHJlc291cmNlGAMgASgJEi8K",
                  "C2NyZWF0ZV90aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
                  "cBIuCgpvY2N1cl90aW1lGAUgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
                  "dGFtcBIlCgRkYXRhGAYgASgLMhcuZ29vZ2xlLnByb3RvYnVmLlN0cnVjdCIf",
                  "Cg9HZXRFdmVudFJlcXVlc3QSDAoEbmFtZRgBIAEoCSJsChFMaXN0RXZlbnRz",
                  "UmVxdWVzdBIOCgZwYXJlbnQYASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIK",
                  "CnBhZ2VfdG9rZW4YAyABKAkSDgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5",
                  "GAUgASgJIlsKEkxpc3RFdmVudHNSZXNwb25zZRIsCgZldmVudHMYASADKAsy",
                  "HC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuRXZlbnQSFwoPbmV4dF9wYWdlX3Rv",
                  "a2VuGAIgASgJMsMBCgxFdmVudFNlcnZpY2USUAoIR2V0RXZlbnQSJi5zYWx0",
                  "by5uZWJ1bGEuZXZlbnQudjEuR2V0RXZlbnRSZXF1ZXN0Ghwuc2FsdG8ubmVi",
                  "dWxhLmV2ZW50LnYxLkV2ZW50EmEKCkxpc3RFdmVudHMSKC5zYWx0by5uZWJ1",
                  "bGEuZXZlbnQudjEuTGlzdEV2ZW50c1JlcXVlc3QaKS5zYWx0by5uZWJ1bGEu",
                  "ZXZlbnQudjEuTGlzdEV2ZW50c1Jlc3BvbnNlQs8BCh1jb20uc2FsdG9hcGlz",
                  "Lm5lYnVsYS5ldmVudC52MUIKRXZlbnRQcm90b1ABWkBnaXRodWIuY29tL3Nh",
                  "bHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL2V2ZW50L3Yx",
                  "O2V2ZW50qgIZU2FsdG9hcGlzLk5lYnVsYS5FdmVudC5WMcoCGVNhbHRvYXBp",
                  "c1xOZWJ1bGFcRXZlbnRcVjHiAiVHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVi",
                  "dWxhXEV2ZW50XFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Event), Event.Parser, ["Name", "Type", "Resource", "CreateTime", "OccurTime", "Data"], null, null, null, null),
            new(typeof(GetEventRequest), GetEventRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListEventsRequest), ListEventsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListEventsResponse), ListEventsResponse.Parser, ["Events", "NextPageToken"], null, null, null, null)
                ]));
        }
    }

}