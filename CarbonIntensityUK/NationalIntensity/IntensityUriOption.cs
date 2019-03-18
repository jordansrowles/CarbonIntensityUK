namespace CarbonIntensityUK
{
    /// <summary>
    ///     Represents forecast options for NationalIntensity.Get(date, option)
    /// </summary>
    public enum IntensityUriOption
    {
        /// <summary>
        ///     24 hour carbon forecast
        /// </summary>
        fw24h,
        /// <summary>
        ///     48 hour carbon forecast
        /// </summary>
        fw48h,
        /// <summary>
        ///     Previous 24 hour carbon forecast
        /// </summary>
        pt24h
    }
}
