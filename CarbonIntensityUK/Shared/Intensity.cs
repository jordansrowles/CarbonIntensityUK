using Newtonsoft.Json;

namespace CarbonIntensityUK.Shared
{
    /// <summary>
    ///     Represents an intensity schema object
    /// </summary>
    [JsonObject("intensity")]
    public class Intensity
    {
        /// <summary>
        ///     The forecast carbon intesity for the half hour in units gCO2/kWh
        /// </summary>
        [JsonProperty("forecast")]
        public int? Forecast { get; set; }

        /// <summary>
        ///     The estimated actual carbon intesity for the half hour in units gCO2/kWh
        /// </summary>
        [JsonProperty("actual")]
        public int? Actual { get; set; }

        /// <summary>
        ///     Scale representation between very low, low, moderate, high and very high
        /// </summary>
        [JsonProperty("index")]
        public string Index { get; set; }
    }
}
