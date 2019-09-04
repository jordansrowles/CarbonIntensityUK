using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    /// <summary>
    ///     Represents a region of the UK
    ///     Is used by RegionalFromToIntensityReponse
    /// </summary>
    public class Region 
    {
        /// <summary>
        ///     Region ID 1-17
        /// </summary>
        [JsonProperty("regionid")]
        public int RegionId { get; set; }

        /// <summary>
        ///     Name of Distribution Network Operator (DNO) in region
        /// </summary>
        [JsonProperty("dnoregion")]
        public string DnoRegion { get; set; }

        /// <summary>
        ///     Name of region
        /// </summary>
        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        /// <summary>
        ///     Outward postcode i.e. RG10
        /// </summary>
        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        ///     Carbon Intensity data (forecast, actual, index)
        /// </summary>
        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        /// <summary>
        ///     Fuel types
        /// </summary>
        [JsonProperty("generationmix")]
        public IList<GenerationData> Generationmix { get; set; }
    }
    
}
