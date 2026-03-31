using Google.Protobuf.Reflection;
using Saltoapis.Nebula.Installation.V1.Request;
using Saltoapis.Nebula.Installation.V1.Response;

namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/installation/v1/encrypted_payload.proto</summary>
    public static partial class EncryptedPayloadReflection
    {

        /// <summary>File descriptor for salto/nebula/installation/v1/encrypted_payload.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static EncryptedPayloadReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjRzYWx0by9uZWJ1bGEvaW5zdGFsbGF0aW9uL3YxL2VuY3J5cHRlZF9wYXls",
                  "b2FkLnByb3RvEhxzYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxIlIKHklu",
                  "Z2VzdEVuY3J5cHRlZFBheWxvYWRzUmVxdWVzdBIUCgxpbnN0YWxsYXRpb24Y",
                  "ASABKAkSGgoSZW5jcnlwdGVkX3BheWxvYWRzGAIgAygMIiEKH0luZ2VzdEVu",
                  "Y3J5cHRlZFBheWxvYWRzUmVzcG9uc2UysgEKF0VuY3J5cHRlZFBheWxvYWRT",
                  "ZXJ2aWNlEpYBChdJbmdlc3RFbmNyeXB0ZWRQYXlsb2FkcxI8LnNhbHRvLm5l",
                  "YnVsYS5pbnN0YWxsYXRpb24udjEuSW5nZXN0RW5jcnlwdGVkUGF5bG9hZHNS",
                  "ZXF1ZXN0Gj0uc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5Jbmdlc3RF",
                  "bmNyeXB0ZWRQYXlsb2Fkc1Jlc3BvbnNlQoQCCiRjb20uc2FsdG9hcGlzLm5l",
                  "YnVsYS5pbnN0YWxsYXRpb24udjFCFUVuY3J5cHRlZFBheWxvYWRQcm90b1AB",
                  "Wk5naXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28v",
                  "bmVidWxhL2luc3RhbGxhdGlvbi92MTtpbnN0YWxsYXRpb26qAiBTYWx0b2Fw",
                  "aXMuTmVidWxhLkluc3RhbGxhdGlvbi5WMcoCIFNhbHRvYXBpc1xOZWJ1bGFc",
                  "SW5zdGFsbGF0aW9uXFYx4gIsR1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVs",
                  "YVxJbnN0YWxsYXRpb25cVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(IngestEncryptedPayloadsRequest), IngestEncryptedPayloadsRequest.Parser, ["Installation", "EncryptedPayloads"], null, null, null, null),
            new(typeof(IngestEncryptedPayloadsResponse), IngestEncryptedPayloadsResponse.Parser, null, null, null, null, null)
                ]));
        }

    }


}
