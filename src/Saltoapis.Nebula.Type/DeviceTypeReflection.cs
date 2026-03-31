using Google.Protobuf.Reflection;

namespace Saltoapis.Nebula.Type
{
    /// <summary>Holder for reflection information generated from salto/nebula/type/device_type.proto</summary>
    public static partial class DeviceTypeReflection
    {

        /// <summary>File descriptor for salto/nebula/type/device_type.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static DeviceTypeReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiNzYWx0by9uZWJ1bGEvdHlwZS9kZXZpY2VfdHlwZS5wcm90bxIRc2FsdG8u",
                  "bmVidWxhLnR5cGUqoAEKCkRldmljZVR5cGUSGwoXREVWSUNFX1RZUEVfVU5T",
                  "UEVDSUZJRUQQABITCg9FTEVDVFJPTklDX0xPQ0sQARILCgdHQVRFV0FZEAIS",
                  "DAoIRVhURU5ERVIQAxILCgdFTkNPREVSEAQSDgoKQ09OVFJPTExFUhAFEhQK",
                  "EElOVEVSQ09NX0FEQVBUT1IQBhISCg5FTEVDVFJPTklDX0tFWRAHQtABChlj",
                  "b20uc2FsdG9hcGlzLm5lYnVsYS50eXBlQg9EZXZpY2VUeXBlUHJvdG9QAVpM",
                  "Z2l0aHViLmNvbS9zYWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25l",
                  "YnVsYS90eXBlL2RldmljZXR5cGU7ZGV2aWNldHlwZaoCFVNhbHRvYXBpcy5O",
                  "ZWJ1bGEuVHlwZcoCFVNhbHRvYXBpc1xOZWJ1bGFcVHlwZeICIUdQQk1ldGFk",
                  "YXRhXFNhbHRvYXBpc1xOZWJ1bGFcVHlwZWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo([typeof(DeviceType),], null, null));
        }

    }


}
