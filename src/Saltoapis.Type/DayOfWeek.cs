namespace Saltoapis.Type
{

    /// <summary>Holder for reflection information generated from salto/type/day_of_week.proto</summary>
    public static partial class DayOfWeekReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/type/day_of_week.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static DayOfWeekReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "ChxzYWx0by90eXBlL2RheV9vZl93ZWVrLnByb3RvEgpzYWx0by50eXBlKoQB",
                  "CglEYXlPZldlZWsSGwoXREFZX09GX1dFRUtfVU5TUEVDSUZJRUQQABIKCgZN",
                  "T05EQVkQARILCgdUVUVTREFZEAISDQoJV0VETkVTREFZEAMSDAoIVEhVUlNE",
                  "QVkQBBIKCgZGUklEQVkQBRIMCghTQVRVUkRBWRAGEgoKBlNVTkRBWRAHQqoB",
                  "ChJjb20uc2FsdG9hcGlzLnR5cGVCDkRheU9mV2Vla1Byb3RvUAFaQ2dpdGh1",
                  "Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby90eXBlL2Rh",
                  "eW9md2VlaztkYXlvZndlZWuqAg5TYWx0b2FwaXMuVHlwZcoCDlNhbHRvYXBp",
                  "c1xUeXBl4gIaR1BCTWV0YWRhdGFcU2FsdG9hcGlzXFR5cGViBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo([typeof(DayOfWeek),], null, null));
        }
        #endregion

    }
    #region Enums
    /// <summary>
    /// Represents a day of week.
    /// </summary>
    public enum DayOfWeek
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        [OriginalName("DAY_OF_WEEK_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Monday
        /// </summary>
        [OriginalName("MONDAY")] Monday = 1,
        /// <summary>
        /// Tuesday
        /// </summary>
        [OriginalName("TUESDAY")] Tuesday = 2,
        /// <summary>
        /// Wednesday
        /// </summary>
        [OriginalName("WEDNESDAY")] Wednesday = 3,
        /// <summary>
        /// Thursday
        /// </summary>
        [OriginalName("THURSDAY")] Thursday = 4,
        /// <summary>
        /// Friday
        /// </summary>
        [OriginalName("FRIDAY")] Friday = 5,
        /// <summary>
        /// Saturday
        /// </summary>
        [OriginalName("SATURDAY")] Saturday = 6,
        /// <summary>
        /// Sunday
        /// </summary>
        [OriginalName("SUNDAY")] Sunday = 7,
    }

    #endregion

}
