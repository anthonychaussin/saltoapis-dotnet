namespace Saltoapis.Nebula.Type
{
    /// <summary>
    /// Represents the day types.
    /// </summary>
    public enum DayType
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        [OriginalName("DAY_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Normal day
        /// </summary>
        [OriginalName("NORMAL")] Normal = 1,
        /// <summary>
        /// Holidays
        /// </summary>
        [OriginalName("HOLIDAY")] Holiday = 2,
        /// <summary>
        /// Special day type 1
        /// </summary>
        [OriginalName("SPECIAL_1")] Special1 = 3,
        /// <summary>
        /// Special day type 2
        /// </summary>
        [OriginalName("SPECIAL_2")] Special2 = 4,
    }

}