namespace CarbonIntensityUK.Models
{
    /// <summary>
    ///     Used to determine the forecast type.
    ///     Previous 24 hours, or forecast 24 / 48 hour
    /// </summary>
    public enum IntensityUriOption
    {
        /// <summary>
        ///     Forward 24 hours
        /// </summary>
        fw24h,
        
        /// <summary>
        ///     Forward 48 hours
        /// </summary>
        fw48h,
        
        /// <summary>
        ///     Past 24 hours
        /// </summary>
        pt24h
    }
}