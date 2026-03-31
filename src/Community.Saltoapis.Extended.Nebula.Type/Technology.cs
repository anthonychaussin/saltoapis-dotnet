namespace Saltoapis.Nebula.Type
{
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


}
