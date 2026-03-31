namespace Saltoapis.Nebula.Type
{
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


}
