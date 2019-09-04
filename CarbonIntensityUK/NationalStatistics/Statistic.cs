using Newtonsoft.Json;

namespace CarbonIntensityUK.NationalStatistics
{
    /// <summary>
    ///     Represents a data response object
    /// </summary>
    public class Statistic
    {
        /// <summary>
        ///     The maximum Carbon Intensity for the datetime range in units gCO2/kWh. 
        ///     Future periods use forecast data. Past data uses actual data.
        /// </summary>
        [JsonProperty("max")]
        public int? Max { get; set; }

        /// <summary>
        ///     The average Carbon Intensity for the datetime range in units gCO2/kWh.
        ///     Future periods use forecast data. Past data uses actual data.
        /// </summary>
        [JsonProperty("average")]
        public int? Average { get; set; }

        /// <summary>
        ///     The maximum Carbon Intensity for the datetime range in units gCO2/kWh. 
        ///     Future periods use forecast data. Past data uses actual data
        /// </summary>
        [JsonProperty("min")]
        public int? Min { get; set; }

        /// <summary>
        ///     The index is a measure of the Carbon Intensity represented on a scale 
        ///     between 'very low', 'low', 'moderate', 'high', 'very high'.
        /// </summary>
        [JsonProperty("index")]
        public string Index { get; set; }
    }
}
