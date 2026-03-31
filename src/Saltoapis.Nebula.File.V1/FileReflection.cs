using Google.Protobuf.Reflection;
using Saltoapis.Nebula.File.V1.Request;

namespace Saltoapis.Nebula.File.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/file/v1/file.proto</summary>
    public static partial class FileReflection
    {

        /// <summary>File descriptor for salto/nebula/file/v1/file.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static FileReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ch9zYWx0by9uZWJ1bGEvZmlsZS92MS9maWxlLnByb3RvEhRzYWx0by5uZWJ1",
                  "bGEuZmlsZS52MSIoCgRGaWxlEgwKBG5hbWUYASABKAkSEgoKdXBsb2FkX3Vy",
                  "aRgCIAEoCSIjChFDcmVhdGVGaWxlUmVxdWVzdBIOCgZwYXJlbnQYASABKAky",
                  "YAoLRmlsZVNlcnZpY2USUQoKQ3JlYXRlRmlsZRInLnNhbHRvLm5lYnVsYS5m",
                  "aWxlLnYxLkNyZWF0ZUZpbGVSZXF1ZXN0Ghouc2FsdG8ubmVidWxhLmZpbGUu",
                  "djEuRmlsZULIAQocY29tLnNhbHRvYXBpcy5uZWJ1bGEuZmlsZS52MUIJRmls",
                  "ZVByb3RvUAFaPmdpdGh1Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRv",
                  "YXBpcy1nby9uZWJ1bGEvZmlsZS92MTtmaWxlqgIYU2FsdG9hcGlzLk5lYnVs",
                  "YS5GaWxlLlYxygIYU2FsdG9hcGlzXE5lYnVsYVxGaWxlXFYx4gIkR1BCTWV0",
                  "YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxGaWxlXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(File), File.Parser, ["Name", "UploadUri"], null, null, null, null),
            new(typeof(CreateFileRequest), CreateFileRequest.Parser, ["Parent"], null, null, null, null)
                ]));
        }

    }


}
