using Google.Protobuf.Reflection;

namespace Saltoapis.Nebula.Type
{

    /// <summary>Holder for reflection information generated from salto/nebula/type/device_type.proto</summary>
    public static partial class DeviceTypeReflection
    {

        #region Descriptor
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
        #endregion

    }
    #region Enums
    /// <summary>
    /// Represents the device types.
    /// </summary>
    public enum DeviceType
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        [OriginalName("DEVICE_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Electronic lock
        /// </summary>
        [OriginalName("ELECTRONIC_LOCK")] ElectronicLock = 1,
        /// <summary>
        /// Gateway
        /// </summary>
        [OriginalName("GATEWAY")] Gateway = 2,
        /// <summary>
        /// Extender
        /// </summary>
        [OriginalName("EXTENDER")] Extender = 3,
        /// <summary>
        /// Encoder
        /// </summary>
        [OriginalName("ENCODER")] Encoder = 4,
        /// <summary>
        /// Controller
        /// </summary>
        [OriginalName("CONTROLLER")] Controller = 5,
        /// <summary>
        /// Intercom Adaptor
        /// </summary>
        [OriginalName("INTERCOM_ADAPTOR")] IntercomAdaptor = 6,
        /// <summary>
        /// Electronic key
        /// </summary>
        [OriginalName("ELECTRONIC_KEY")] ElectronicKey = 7,
    }

    #endregion

}
