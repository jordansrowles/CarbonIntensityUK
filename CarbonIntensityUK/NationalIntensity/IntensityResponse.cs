using Newtonsoft.Json;

namespace CarbonIntensityUK
{
    /// <summary>
    ///     Represents a data response object
    /// </summary>
    [JsonObject("data")]
    public class IntensityResponse
    {
        /// <summary>
        ///     DateTime in ISO 8601 format
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }
        /// <summary>
        ///     DateTime in ISO 8601 format
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        ///     Carbon intensity data
        /// </summary>
        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        public override string ToString()
        {
            return $"{From} - {To}";
        }
    }
}
