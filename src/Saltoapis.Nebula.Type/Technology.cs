using Google.Protobuf.Reflection;

namespace Saltoapis.Nebula.Type
{

    /// <summary>Holder for reflection information generated from salto/nebula/type/technology.proto</summary>
    public static partial class TechnologyReflection
    {

        #region Descriptor
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
        #endregion

    }
    #region Enums
    /// <summary>
    /// Specifies the technology used by the app to open an access point.
    /// </summary>
    public enum AppKeyTechnology
    {
        /// <summary>
        /// Unspecified or unknown technology.
        /// </summary>
        [OriginalName("APP_KEY_TECHNOLOGY_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Access via Bluetooth Low Energy (BLE).
        /// The app communicates directly with the access point over Bluetooth Low
        /// Energy to open it.
        /// </summary>
        [OriginalName("BLE")] Ble = 1,
        /// <summary>
        /// Access via Host Card Emulation (HCE).
        /// The phone's role is CARD EMULATOR. It emulates a virtual key card
        /// for the access point's reader to scan.
        /// </summary>
        [OriginalName("NFC_HCE")] NfcHce = 2,
        /// <summary>
        /// Access via NFC Reader Mode.
        /// The phone's role is READER. It actively reads/writes to the
        /// access point's passive NFC tag to authenticate and open it.
        /// </summary>
        [OriginalName("NFC_READER")] NfcReader = 3,
    }

    #endregion

}
