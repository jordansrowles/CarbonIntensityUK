using Newtonsoft.Json;

namespace CarbonIntensityUK.NationalStatistics
{
    /// <summary>
    ///     Represents a data response object
    /// </summary>
    [JsonObject("data")]
    public class StatisticResponse
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
        ///     Statistic object
        /// </summary>
        [JsonProperty("intensity")]
        public Statistic Intensity { get; set; }
    }
}
