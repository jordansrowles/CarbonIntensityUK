using Newtonsoft.Json;

namespace CarbonIntensityUK.Shared
{
    /// <summary>
    ///     Fuel types
    /// </summary>
    public class GenerationData
    {
        /// <summary>
        ///     Name of the fuel type
        /// </summary>
        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        /// <summary>
        ///     Generation output of fuel type as a percentage of total generation
        /// </summary>
        [JsonProperty("perc")]
        public double? Percentage { get; set; }
    }
}
