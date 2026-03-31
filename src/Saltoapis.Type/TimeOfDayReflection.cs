namespace Saltoapis.Type
{

    /// <summary>Holder for reflection information generated from salto/type/time_of_day.proto
    /// Represents a time of day. The date and time zone are either not significant
    /// or are specified elsewhere. An API may chose to allow leap seconds. Related
    /// types are [`salto.type.Date`][salto.type.Date] and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public static partial class TimeOfDayReflection
    {

        /// <summary>File descriptor for salto/type/time_of_day.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static TimeOfDayReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "ChxzYWx0by90eXBlL3RpbWVfb2ZfZGF5LnByb3RvEgpzYWx0by50eXBlIksK",
                  "CVRpbWVPZkRheRINCgVob3VycxgBIAEoBRIPCgdtaW51dGVzGAIgASgFEg8K",
                  "B3NlY29uZHMYAyABKAUSDQoFbmFub3MYBCABKAVCqgEKEmNvbS5zYWx0b2Fw",
                  "aXMudHlwZUIOVGltZU9mRGF5UHJvdG9QAVpDZ2l0aHViLmNvbS9zYWx0b2Fw",
                  "aXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL3R5cGUvdGltZW9mZGF5O3RpbWVv",
                  "ZmRheaoCDlNhbHRvYXBpcy5UeXBlygIOU2FsdG9hcGlzXFR5cGXiAhpHUEJN",
                  "ZXRhZGF0YVxTYWx0b2FwaXNcVHlwZWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(TimeOfDay), TimeOfDay.Parser, ["Hours", "Minutes", "Seconds", "Nanos"], null, null, null, null)
                ]));
        }
    }
}