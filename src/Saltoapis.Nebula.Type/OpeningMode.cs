using Google.Protobuf.Reflection;

namespace Saltoapis.Nebula.Type
{

    /// <summary>Holder for reflection information generated from salto/nebula/type/opening_mode.proto</summary>
    public static partial class OpeningModeReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/type/opening_mode.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static OpeningModeReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiRzYWx0by9uZWJ1bGEvdHlwZS9vcGVuaW5nX21vZGUucHJvdG8SEXNhbHRv",
                  "Lm5lYnVsYS50eXBlKlEKC09wZW5pbmdNb2RlEhwKGE9QRU5JTkdfTU9ERV9V",
                  "TlNQRUNJRklFRBAAEgoKBk9GRklDRRABEgoKBlRPR0dMRRACEgwKCEFVVE9M",
                  "T0NLEANC0wEKGWNvbS5zYWx0b2FwaXMubmVidWxhLnR5cGVCEE9wZW5pbmdN",
                  "b2RlUHJvdG9QAVpOZ2l0aHViLmNvbS9zYWx0b2FwaXMtaW50ZXJuYWwvc2Fs",
                  "dG9hcGlzLWdvL25lYnVsYS90eXBlL29wZW5pbmdtb2RlO29wZW5pbmdtb2Rl",
                  "qgIVU2FsdG9hcGlzLk5lYnVsYS5UeXBlygIVU2FsdG9hcGlzXE5lYnVsYVxU",
                  "eXBl4gIhR1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxUeXBlYgZwcm90",
                  "bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo([typeof(OpeningMode),], null, null));
        }
        #endregion

    }
    #region Enums
    /// <summary>
    /// Represents an opening mode.
    /// </summary>
    public enum OpeningMode
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        [OriginalName("OPENING_MODE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Office.
        /// </summary>
        [OriginalName("OFFICE")] Office = 1,
        /// <summary>
        /// Toggle.
        /// </summary>
        [OriginalName("TOGGLE")] Toggle = 2,
        /// <summary>
        /// Autolock.
        /// </summary>
        [OriginalName("AUTOLOCK")] Autolock = 3,
    }

    #endregion

}
