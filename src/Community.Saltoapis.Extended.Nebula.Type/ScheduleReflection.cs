namespace Saltoapis.Nebula.Type
{
    /// <summary>Holder for reflection information generated from salto/nebula/type/schedule.proto</summary>
    public static partial class ScheduleReflection
    {

        /// <summary>File descriptor for salto/nebula/type/schedule.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static ScheduleReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiBzYWx0by9uZWJ1bGEvdHlwZS9zY2hlZHVsZS5wcm90bxIRc2FsdG8ubmVi",
                  "dWxhLnR5cGUaIHNhbHRvL25lYnVsYS90eXBlL2RheV90eXBlLnByb3RvGhxz",
                  "YWx0by90eXBlL2RheV9vZl93ZWVrLnByb3RvGhxzYWx0by90eXBlL3RpbWVf",
                  "b2ZfZGF5LnByb3RvIu4BCghTY2hlZHVsZRItCgRkYXlzGAEgAygLMh8uc2Fs",
                  "dG8ubmVidWxhLnR5cGUuU2NoZWR1bGUuRGF5EikKCnN0YXJ0X3RpbWUYAiAB",
                  "KAsyFS5zYWx0by50eXBlLlRpbWVPZkRheRInCghlbmRfdGltZRgDIAEoCzIV",
                  "LnNhbHRvLnR5cGUuVGltZU9mRGF5Gl8KA0RheRIsCghkYXlfdHlwZRgBIAEo",
                  "DjIaLnNhbHRvLm5lYnVsYS50eXBlLkRheVR5cGUSKgoLZGF5X29mX3dlZWsY",
                  "AiABKA4yFS5zYWx0by50eXBlLkRheU9mV2Vla0LKAQoZY29tLnNhbHRvYXBp",
                  "cy5uZWJ1bGEudHlwZUINU2NoZWR1bGVQcm90b1ABWkhnaXRodWIuY29tL3Nh",
                  "bHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL3R5cGUvc2No",
                  "ZWR1bGU7c2NoZWR1bGWqAhVTYWx0b2FwaXMuTmVidWxhLlR5cGXKAhVTYWx0",
                  "b2FwaXNcTmVidWxhXFR5cGXiAiFHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVi",
                  "dWxhXFR5cGViBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [DayTypeReflection.Descriptor, Saltoapis.Type.DayOfWeekReflection.Descriptor, Saltoapis.Type.TimeOfDayReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Schedule), Schedule.Parser, ["Days", "StartTime", "EndTime"], null, null, null, [new(typeof(Schedule.Types.Day), Schedule.Types.Day.Parser, ["DayType", "DayOfWeek"], null, null, null, null)])
                ]));
        }

    }


}
