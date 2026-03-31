namespace Saltoapis.Nebula.Type
{
    /// <summary>Holder for reflection information generated from salto/nebula/type/technology.proto</summary>
    public static partial class TechnologyReflection
    {

        /// <summary>File descriptor for salto/nebula/type/technology.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static TechnologyReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiJzYWx0by9uZWJ1bGEvdHlwZS90ZWNobm9sb2d5LnByb3RvEhFzYWx0by5u",
                  "ZWJ1bGEudHlwZSpcChBBcHBLZXlUZWNobm9sb2d5EiIKHkFQUF9LRVlfVEVD",
                  "SE5PTE9HWV9VTlNQRUNJRklFRBAAEgcKA0JMRRABEgsKB05GQ19IQ0UQAhIO",
                  "CgpORkNfUkVBREVSEANC0AEKGWNvbS5zYWx0b2FwaXMubmVidWxhLnR5cGVC",
                  "D1RlY2hub2xvZ3lQcm90b1ABWkxnaXRodWIuY29tL3NhbHRvYXBpcy1pbnRl",
                  "cm5hbC9zYWx0b2FwaXMtZ28vbmVidWxhL3R5cGUvdGVjaG5vbG9neTt0ZWNo",
                  "bm9sb2d5qgIVU2FsdG9hcGlzLk5lYnVsYS5UeXBlygIVU2FsdG9hcGlzXE5l",
                  "YnVsYVxUeXBl4gIhR1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxUeXBl",
                  "YgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo([typeof(AppKeyTechnology),], null, null));
        }

    }


}
