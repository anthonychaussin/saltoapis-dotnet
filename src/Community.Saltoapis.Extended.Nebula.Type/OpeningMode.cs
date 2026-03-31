namespace Saltoapis.Nebula.Type
{
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


}
