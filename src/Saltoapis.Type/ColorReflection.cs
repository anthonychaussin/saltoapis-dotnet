namespace Saltoapis.Type
{

    /// <summary>Holder for reflection information generated from salto/type/color.proto</summary>

    /// <summary>
    /// Represents a color in the RGBA color space.
    /// By default, applications should assume the sRGB color space.
    ///
    /// When color equality needs to be decided, implementations, unless
    /// documented otherwise, treat two colors as equal if all their red,
    /// green, blue, and alpha values each differ by at most 1e-5.
    /// </summary>
    public static partial class ColorReflection
    {

        /// <summary>File descriptor for salto/type/color.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static ColorReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "ChZzYWx0by90eXBlL2NvbG9yLnByb3RvEgpzYWx0by50eXBlIk8KBUNvbG9y",
                  "EgsKA3JlZBgBIAEoAhINCgVncmVlbhgCIAEoAhIMCgRibHVlGAMgASgCEhIK",
                  "BWFscGhhGAQgASgCSACIAQFCCAoGX2FscGhhQp4BChJjb20uc2FsdG9hcGlz",
                  "LnR5cGVCCkNvbG9yUHJvdG9QAVo7Z2l0aHViLmNvbS9zYWx0b2FwaXMtaW50",
                  "ZXJuYWwvc2FsdG9hcGlzLWdvL3R5cGUvY29sb3I7Y29sb3KqAg5TYWx0b2Fw",
                  "aXMuVHlwZcoCDlNhbHRvYXBpc1xUeXBl4gIaR1BCTWV0YWRhdGFcU2FsdG9h",
                  "cGlzXFR5cGViBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Color), Color.Parser, ["Red", "Green", "Blue", "Alpha"], ["Alpha"], null, null, null)
                ]));
        }

    }
}
