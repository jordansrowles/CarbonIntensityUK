using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    /// <summary>
    ///     Represents a data response object
    /// </summary>
    [JsonObject("data")]
    public class RegionalFromToIntensityReponse
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
        ///     DateTime in ISO 8601 format
        /// </summary>
        [JsonProperty("regions")]
        public IList<Region> Regions { get; set; }
    }
    
}
