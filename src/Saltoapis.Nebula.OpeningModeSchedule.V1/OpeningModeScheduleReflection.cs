using Google.Protobuf.Reflection;
using Saltoapis.Nebula.OpeningModeSchedule.V1.Request;
using Saltoapis.Nebula.OpeningModeSchedule.V1.Response;

namespace Saltoapis.Nebula.OpeningModeSchedule.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/openingmodeschedule/v1/opening_mode_schedule.proto</summary>
    public static partial class OpeningModeScheduleReflection
    {

        /// <summary>File descriptor for salto/nebula/openingmodeschedule/v1/opening_mode_schedule.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static OpeningModeScheduleReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Cj9zYWx0by9uZWJ1bGEvb3BlbmluZ21vZGVzY2hlZHVsZS92MS9vcGVuaW5n",
                  "X21vZGVfc2NoZWR1bGUucHJvdG8SI3NhbHRvLm5lYnVsYS5vcGVuaW5nbW9k",
                  "ZXNjaGVkdWxlLnYxGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aIGdv",
                  "b2dsZS9wcm90b2J1Zi9maWVsZF9tYXNrLnByb3RvGiBzYWx0by9uZWJ1bGEv",
                  "dHlwZS9kYXlfdHlwZS5wcm90bxokc2FsdG8vbmVidWxhL3R5cGUvb3Blbmlu",
                  "Z19tb2RlLnByb3RvGhxzYWx0by90eXBlL2RheV9vZl93ZWVrLnByb3RvGhxz",
                  "YWx0by90eXBlL3RpbWVfb2ZfZGF5LnByb3RvIswDChNPcGVuaW5nTW9kZVNj",
                  "aGVkdWxlEgwKBG5hbWUYASABKAkSFAoMZGlzcGxheV9uYW1lGAIgASgJEkoK",
                  "BGRheXMYAyADKAsyPC5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVs",
                  "ZS52MS5PcGVuaW5nTW9kZVNjaGVkdWxlLkRheRrEAgoDRGF5EiwKCGRheV90",
                  "eXBlGAEgASgOMhouc2FsdG8ubmVidWxhLnR5cGUuRGF5VHlwZRIqCgtkYXlf",
                  "b2Zfd2VlaxgCIAEoDjIVLnNhbHRvLnR5cGUuRGF5T2ZXZWVrElAKBXNsb3Rz",
                  "GAMgAygLMkEuc2FsdG8ubmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEu",
                  "T3BlbmluZ01vZGVTY2hlZHVsZS5EYXkuU2xvdBqQAQoEU2xvdBI0CgxvcGVu",
                  "aW5nX21vZGUYASABKA4yHi5zYWx0by5uZWJ1bGEudHlwZS5PcGVuaW5nTW9k",
                  "ZRIpCgpzdGFydF90aW1lGAIgASgLMhUuc2FsdG8udHlwZS5UaW1lT2ZEYXkS",
                  "JwoIZW5kX3RpbWUYAyABKAsyFS5zYWx0by50eXBlLlRpbWVPZkRheSKtAQog",
                  "Q3JlYXRlT3BlbmluZ01vZGVTY2hlZHVsZVJlcXVlc3QSDgoGcGFyZW50GAEg",
                  "ASgJEiAKGG9wZW5pbmdfbW9kZV9zY2hlZHVsZV9pZBgCIAEoCRJXChVvcGVu",
                  "aW5nX21vZGVfc2NoZWR1bGUYAyABKAsyOC5zYWx0by5uZWJ1bGEub3Blbmlu",
                  "Z21vZGVzY2hlZHVsZS52MS5PcGVuaW5nTW9kZVNjaGVkdWxlIi0KHUdldE9w",
                  "ZW5pbmdNb2RlU2NoZWR1bGVSZXF1ZXN0EgwKBG5hbWUYASABKAkiegofTGlz",
                  "dE9wZW5pbmdNb2RlU2NoZWR1bGVzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkS",
                  "EQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmls",
                  "dGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIpUBCiBMaXN0T3BlbmluZ01v",
                  "ZGVTY2hlZHVsZXNSZXNwb25zZRJYChZvcGVuaW5nX21vZGVfc2NoZWR1bGVz",
                  "GAEgAygLMjguc2FsdG8ubmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEu",
                  "T3BlbmluZ01vZGVTY2hlZHVsZRIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAki",
                  "rAEKIFVwZGF0ZU9wZW5pbmdNb2RlU2NoZWR1bGVSZXF1ZXN0ElcKFW9wZW5p",
                  "bmdfbW9kZV9zY2hlZHVsZRgBIAEoCzI4LnNhbHRvLm5lYnVsYS5vcGVuaW5n",
                  "bW9kZXNjaGVkdWxlLnYxLk9wZW5pbmdNb2RlU2NoZWR1bGUSLwoLdXBkYXRl",
                  "X21hc2sYAiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIjAKIERl",
                  "bGV0ZU9wZW5pbmdNb2RlU2NoZWR1bGVSZXF1ZXN0EgwKBG5hbWUYASABKAky",
                  "mQYKGk9wZW5pbmdNb2RlU2NoZWR1bGVTZXJ2aWNlEpwBChlDcmVhdGVPcGVu",
                  "aW5nTW9kZVNjaGVkdWxlEkUuc2FsdG8ubmVidWxhLm9wZW5pbmdtb2Rlc2No",
                  "ZWR1bGUudjEuQ3JlYXRlT3BlbmluZ01vZGVTY2hlZHVsZVJlcXVlc3QaOC5z",
                  "YWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVsZS52MS5PcGVuaW5nTW9k",
                  "ZVNjaGVkdWxlEpYBChZHZXRPcGVuaW5nTW9kZVNjaGVkdWxlEkIuc2FsdG8u",
                  "bmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEuR2V0T3BlbmluZ01vZGVT",
                  "Y2hlZHVsZVJlcXVlc3QaOC5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hl",
                  "ZHVsZS52MS5PcGVuaW5nTW9kZVNjaGVkdWxlEqcBChhMaXN0T3BlbmluZ01v",
                  "ZGVTY2hlZHVsZXMSRC5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVs",
                  "ZS52MS5MaXN0T3BlbmluZ01vZGVTY2hlZHVsZXNSZXF1ZXN0GkUuc2FsdG8u",
                  "bmVidWxhLm9wZW5pbmdtb2Rlc2NoZWR1bGUudjEuTGlzdE9wZW5pbmdNb2Rl",
                  "U2NoZWR1bGVzUmVzcG9uc2USnAEKGVVwZGF0ZU9wZW5pbmdNb2RlU2NoZWR1",
                  "bGUSRS5zYWx0by5uZWJ1bGEub3BlbmluZ21vZGVzY2hlZHVsZS52MS5VcGRh",
                  "dGVPcGVuaW5nTW9kZVNjaGVkdWxlUmVxdWVzdBo4LnNhbHRvLm5lYnVsYS5v",
                  "cGVuaW5nbW9kZXNjaGVkdWxlLnYxLk9wZW5pbmdNb2RlU2NoZWR1bGUSegoZ",
                  "RGVsZXRlT3BlbmluZ01vZGVTY2hlZHVsZRJFLnNhbHRvLm5lYnVsYS5vcGVu",
                  "aW5nbW9kZXNjaGVkdWxlLnYxLkRlbGV0ZU9wZW5pbmdNb2RlU2NoZWR1bGVS",
                  "ZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5QrECCitjb20uc2FsdG9h",
                  "cGlzLm5lYnVsYS5vcGVuaW5nbW9kZXNjaGVkdWxlLnYxQhhPcGVuaW5nTW9k",
                  "ZVNjaGVkdWxlUHJvdG9QAVpcZ2l0aHViLmNvbS9zYWx0b2FwaXMtaW50ZXJu",
                  "YWwvc2FsdG9hcGlzLWdvL25lYnVsYS9vcGVuaW5nbW9kZXNjaGVkdWxlL3Yx",
                  "O29wZW5pbmdtb2Rlc2NoZWR1bGWqAidTYWx0b2FwaXMuTmVidWxhLk9wZW5p",
                  "bmdNb2RlU2NoZWR1bGUuVjHKAidTYWx0b2FwaXNcTmVidWxhXE9wZW5pbmdN",
                  "b2RlU2NoZWR1bGVcVjHiAjNHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxh",
                  "XE9wZW5pbmdNb2RlU2NoZWR1bGVcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Type.DayTypeReflection.Descriptor, Type.OpeningModeReflection.Descriptor, Saltoapis.Type.DayOfWeekReflection.Descriptor, Saltoapis.Type.TimeOfDayReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(OpeningModeSchedule), OpeningModeSchedule.Parser, ["Name", "DisplayName", "Days"], null, null, null, [new(typeof(OpeningModeSchedule.Types.Day), OpeningModeSchedule.Types.Day.Parser, ["DayType", "DayOfWeek", "Slots"], null, null, null, [new(typeof(OpeningModeSchedule.Types.Day.Types.Slot), OpeningModeSchedule.Types.Day.Types.Slot.Parser, ["OpeningMode", "StartTime", "EndTime"], null, null, null, null)])]),
            new(typeof(CreateOpeningModeScheduleRequest), CreateOpeningModeScheduleRequest.Parser, ["Parent", "OpeningModeScheduleId", "OpeningModeSchedule"], null, null, null, null),
            new(typeof(GetOpeningModeScheduleRequest), GetOpeningModeScheduleRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListOpeningModeSchedulesRequest), ListOpeningModeSchedulesRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListOpeningModeSchedulesResponse), ListOpeningModeSchedulesResponse.Parser, ["OpeningModeSchedules", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateOpeningModeScheduleRequest), UpdateOpeningModeScheduleRequest.Parser, ["OpeningModeSchedule", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteOpeningModeScheduleRequest), DeleteOpeningModeScheduleRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }

    }


}
