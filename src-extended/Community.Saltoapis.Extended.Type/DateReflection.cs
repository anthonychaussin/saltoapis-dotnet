namespace Saltoapis.Type
{
    /// <summary>Holder for reflection information generated from salto/type/date.proto</summary>
    /// <summary>
    /// Represents a whole calendar date, for example: date of birth. The time of day
    /// and time zone are either specified elsewhere or are not significant. The date
    /// is relative to the Proleptic Gregorian Calendar. The day may be 0 to
    /// represent a year and month where the day is not significant, for example:
    /// credit card expiration date. The year may be 0 to represent a month and day
    /// independent of year, for example: anniversary date. Related types are
    /// [`salto.type.TimeOfDay`][salto.type.TimeOfDay] and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public static partial class DateReflection
    {
        /// <summary>File descriptor for salto/type/date.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static DateReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "ChVzYWx0by90eXBlL2RhdGUucHJvdG8SCnNhbHRvLnR5cGUiMAoERGF0ZRIM",
                  "CgR5ZWFyGAEgASgFEg0KBW1vbnRoGAIgASgFEgsKA2RheRgDIAEoBUKbAQoS",
                  "Y29tLnNhbHRvYXBpcy50eXBlQglEYXRlUHJvdG9QAVo5Z2l0aHViLmNvbS9z",
                  "YWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL3R5cGUvZGF0ZTtkYXRl",
                  "qgIOU2FsdG9hcGlzLlR5cGXKAg5TYWx0b2FwaXNcVHlwZeICGkdQQk1ldGFk",
                  "YXRhXFNhbHRvYXBpc1xUeXBlYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Date), Date.Parser, ["Year", "Month", "Day"], null, null, null, null)
                ]));
        }
    }
}