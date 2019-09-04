using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    /// <summary>
    ///     Represents a region of the UK
    ///     Is used by RegionalIdIntensityReponse
    /// </summary>
    public class RegionData
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
        ///     Carbon Intensity data (forecast, actual, index
        /// </summary>
        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        /// <summary>
        ///     Fuel types
        /// </summary>
        [JsonProperty("generationmix")]
        public IList<GenerationData> GenerationMix { get; set; }
    }
    
}
