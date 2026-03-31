namespace Saltoapis.Type
{
    /// <summary>Holder for reflection information generated from salto/type/day_of_week.proto</summary>
    public static partial class DayOfWeekReflection
    {

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

    }


}
