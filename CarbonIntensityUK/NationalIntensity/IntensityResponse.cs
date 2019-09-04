using CarbonIntensityUK.Shared;
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

        /// <summary>
        ///     Pretty formats the object for user display
        /// </summary>
        /// <returns>Formatted string</returns>
        /// <example>
        ///     2018-01-20T12:00Z - 2018-01-20T12:30Z
        /// </example>
        public override string ToString()
        {
            return $"{From} - {To}";
        }
    }
}
