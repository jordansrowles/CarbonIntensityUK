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
        Fw24H,
        
        /// <summary>
        ///     Forward 48 hours
        /// </summary>
        Fw48H,
        
        /// <summary>
        ///     Past 24 hours
        /// </summary>
        Pt24H
    }
}