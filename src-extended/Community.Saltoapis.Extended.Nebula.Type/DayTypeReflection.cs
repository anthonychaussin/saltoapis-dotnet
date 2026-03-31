namespace Saltoapis.Nebula.Type
{
    /// <summary>Holder for reflection information generated from salto/nebula/type/day_type.proto</summary>
    public static partial class DayTypeReflection
    {
        /// <summary>File descriptor for salto/nebula/type/day_type.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static DayTypeReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiBzYWx0by9uZWJ1bGEvdHlwZS9kYXlfdHlwZS5wcm90bxIRc2FsdG8ubmVi",
                  "dWxhLnR5cGUqWgoHRGF5VHlwZRIYChREQVlfVFlQRV9VTlNQRUNJRklFRBAA",
                  "EgoKBk5PUk1BTBABEgsKB0hPTElEQVkQAhINCglTUEVDSUFMXzEQAxINCglT",
                  "UEVDSUFMXzIQBELHAQoZY29tLnNhbHRvYXBpcy5uZWJ1bGEudHlwZUIMRGF5",
                  "VHlwZVByb3RvUAFaRmdpdGh1Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3Nh",
                  "bHRvYXBpcy1nby9uZWJ1bGEvdHlwZS9kYXl0eXBlO2RheXR5cGWqAhVTYWx0",
                  "b2FwaXMuTmVidWxhLlR5cGXKAhVTYWx0b2FwaXNcTmVidWxhXFR5cGXiAiFH",
                  "UEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXFR5cGViBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo([typeof(DayType),], null, null));
        }
    }

}