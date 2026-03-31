using Saltoapis.Nebula.Calendar.V1.Request;
using Saltoapis.Nebula.Calendar.V1.Response;

namespace Saltoapis.Nebula.Calendar.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/calendar/v1/calendar.proto</summary>
    public static partial class CalendarReflection
    {
        /// <summary>File descriptor for salto/nebula/calendar/v1/calendar.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static CalendarReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CidzYWx0by9uZWJ1bGEvY2FsZW5kYXIvdjEvY2FsZW5kYXIucHJvdG8SGHNh",
                  "bHRvLm5lYnVsYS5jYWxlbmRhci52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5",
                  "LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxogc2Fs",
                  "dG8vbmVidWxhL3R5cGUvZGF5X3R5cGUucHJvdG8aFXNhbHRvL3R5cGUvZGF0",
                  "ZS5wcm90byIuCghDYWxlbmRhchIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlf",
                  "bmFtZRgCIAEoCSKNAQoFRXZlbnQSDAoEbmFtZRgBIAEoCRIsCghkYXlfdHlw",
                  "ZRgCIAEoDjIaLnNhbHRvLm5lYnVsYS50eXBlLkRheVR5cGUSJAoKc3RhcnRf",
                  "ZGF0ZRgDIAEoCzIQLnNhbHRvLnR5cGUuRGF0ZRIiCghlbmRfZGF0ZRgEIAEo",
                  "CzIQLnNhbHRvLnR5cGUuRGF0ZSKHAQoVQ3JlYXRlQ2FsZW5kYXJSZXF1ZXN0",
                  "Eg4KBnBhcmVudBgBIAEoCRIYCgtjYWxlbmRhcl9pZBgCIAEoCUgAiAEBEjQK",
                  "CGNhbGVuZGFyGAMgASgLMiIuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYxLkNh",
                  "bGVuZGFyQg4KDF9jYWxlbmRhcl9pZCIiChJHZXRDYWxlbmRhclJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCSJvChRMaXN0Q2FsZW5kYXJzUmVxdWVzdBIOCgZwYXJl",
                  "bnQYASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyAB",
                  "KAkSDgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJImcKFUxpc3RD",
                  "YWxlbmRhcnNSZXNwb25zZRI1CgljYWxlbmRhcnMYASADKAsyIi5zYWx0by5u",
                  "ZWJ1bGEuY2FsZW5kYXIudjEuQ2FsZW5kYXISFwoPbmV4dF9wYWdlX3Rva2Vu",
                  "GAIgASgJIn4KFVVwZGF0ZUNhbGVuZGFyUmVxdWVzdBI0CghjYWxlbmRhchgB",
                  "IAEoCzIiLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5DYWxlbmRhchIvCgt1",
                  "cGRhdGVfbWFzaxgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2si",
                  "JQoVRGVsZXRlQ2FsZW5kYXJSZXF1ZXN0EgwKBG5hbWUYASABKAkieAoSQ3Jl",
                  "YXRlRXZlbnRSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIVCghldmVudF9pZBgC",
                  "IAEoCUgAiAEBEi4KBWV2ZW50GAMgASgLMh8uc2FsdG8ubmVidWxhLmNhbGVu",
                  "ZGFyLnYxLkV2ZW50QgsKCV9ldmVudF9pZCIfCg9HZXRFdmVudFJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCSJsChFMaXN0RXZlbnRzUmVxdWVzdBIOCgZwYXJlbnQY",
                  "ASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkS",
                  "DgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIl4KEkxpc3RFdmVu",
                  "dHNSZXNwb25zZRIvCgZldmVudHMYASADKAsyHy5zYWx0by5uZWJ1bGEuY2Fs",
                  "ZW5kYXIudjEuRXZlbnQSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJInUKElVw",
                  "ZGF0ZUV2ZW50UmVxdWVzdBIuCgVldmVudBgBIAEoCzIfLnNhbHRvLm5lYnVs",
                  "YS5jYWxlbmRhci52MS5FdmVudBIvCgt1cGRhdGVfbWFzaxgCIAEoCzIaLmdv",
                  "b2dsZS5wcm90b2J1Zi5GaWVsZE1hc2siIgoSRGVsZXRlRXZlbnRSZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAky3wcKD0NhbGVuZGFyU2VydmljZRJlCg5DcmVhdGVD",
                  "YWxlbmRhchIvLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5DcmVhdGVDYWxl",
                  "bmRhclJlcXVlc3QaIi5zYWx0by5uZWJ1bGEuY2FsZW5kYXIudjEuQ2FsZW5k",
                  "YXISXwoLR2V0Q2FsZW5kYXISLC5zYWx0by5uZWJ1bGEuY2FsZW5kYXIudjEu",
                  "R2V0Q2FsZW5kYXJSZXF1ZXN0GiIuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "LkNhbGVuZGFyEnAKDUxpc3RDYWxlbmRhcnMSLi5zYWx0by5uZWJ1bGEuY2Fs",
                  "ZW5kYXIudjEuTGlzdENhbGVuZGFyc1JlcXVlc3QaLy5zYWx0by5uZWJ1bGEu",
                  "Y2FsZW5kYXIudjEuTGlzdENhbGVuZGFyc1Jlc3BvbnNlEmUKDlVwZGF0ZUNh",
                  "bGVuZGFyEi8uc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYxLlVwZGF0ZUNhbGVu",
                  "ZGFyUmVxdWVzdBoiLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5DYWxlbmRh",
                  "chJZCg5EZWxldGVDYWxlbmRhchIvLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52",
                  "MS5EZWxldGVDYWxlbmRhclJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1w",
                  "dHkSXAoLQ3JlYXRlRXZlbnQSLC5zYWx0by5uZWJ1bGEuY2FsZW5kYXIudjEu",
                  "Q3JlYXRlRXZlbnRSZXF1ZXN0Gh8uc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "LkV2ZW50ElYKCEdldEV2ZW50Eikuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "LkdldEV2ZW50UmVxdWVzdBofLnNhbHRvLm5lYnVsYS5jYWxlbmRhci52MS5F",
                  "dmVudBJnCgpMaXN0RXZlbnRzEisuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "Lkxpc3RFdmVudHNSZXF1ZXN0Giwuc2FsdG8ubmVidWxhLmNhbGVuZGFyLnYx",
                  "Lkxpc3RFdmVudHNSZXNwb25zZRJcCgtVcGRhdGVFdmVudBIsLnNhbHRvLm5l",
                  "YnVsYS5jYWxlbmRhci52MS5VcGRhdGVFdmVudFJlcXVlc3QaHy5zYWx0by5u",
                  "ZWJ1bGEuY2FsZW5kYXIudjEuRXZlbnQSUwoLRGVsZXRlRXZlbnQSLC5zYWx0",
                  "by5uZWJ1bGEuY2FsZW5kYXIudjEuRGVsZXRlRXZlbnRSZXF1ZXN0GhYuZ29v",
                  "Z2xlLnByb3RvYnVmLkVtcHR5QuQBCiBjb20uc2FsdG9hcGlzLm5lYnVsYS5j",
                  "YWxlbmRhci52MUINQ2FsZW5kYXJQcm90b1ABWkZnaXRodWIuY29tL3NhbHRv",
                  "YXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL2NhbGVuZGFyL3Yx",
                  "O2NhbGVuZGFyqgIcU2FsdG9hcGlzLk5lYnVsYS5DYWxlbmRhci5WMcoCHFNh",
                  "bHRvYXBpc1xOZWJ1bGFcQ2FsZW5kYXJcVjHiAihHUEJNZXRhZGF0YVxTYWx0",
                  "b2FwaXNcTmVidWxhXENhbGVuZGFyXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Type.DayTypeReflection.Descriptor, Saltoapis.Type.DateReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Calendar), Calendar.Parser, ["Name", "DisplayName"], null, null, null, null),
            new(typeof(Event), Event.Parser, ["Name", "DayType", "StartDate", "EndDate"], null, null, null, null),
            new(typeof(CreateCalendarRequest), CreateCalendarRequest.Parser, ["Parent", "CalendarId", "Calendar"], ["CalendarId"], null, null, null),
            new(typeof(GetCalendarRequest), GetCalendarRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListCalendarsRequest), ListCalendarsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListCalendarsResponse), ListCalendarsResponse.Parser, ["Calendars", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateCalendarRequest), UpdateCalendarRequest.Parser, ["Calendar", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteCalendarRequest), DeleteCalendarRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CreateEventRequest), CreateEventRequest.Parser, ["Parent", "EventId", "Event"], ["EventId"], null, null, null),
            new(typeof(GetEventRequest), GetEventRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListEventsRequest), ListEventsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListEventsResponse), ListEventsResponse.Parser, ["Events", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateEventRequest), UpdateEventRequest.Parser, ["Event", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteEventRequest), DeleteEventRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
    }

}