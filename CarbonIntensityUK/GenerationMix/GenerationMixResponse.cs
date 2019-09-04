using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace CarbonIntensityUK.GenerationMix
{
    /// <summary>
    ///     Represents a data response object
    /// </summary>
    [JsonObject("data")]
    public class GenerationMixResponse
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

        [JsonProperty("generationmix")]
        public IList<GenerationData> GenerationMix { get; set; }

        /// <summary>
        ///     Pretty formats the object for user display
        /// </summary>
        /// <returns>Formatted string</returns>
        /// <example>
        ///     2018-01-20T12:00Z - 2018-01-20T12:30Z
        ///     gas     43.6
        ///     coal    0.7
        ///     ...
        /// </example>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{From} - {To}\n");
            foreach (var i in GenerationMix)
                builder.Append($"{i.Fuel}\t{i.Percentage}%\n");
            return builder.ToString();
        }
    }
}
