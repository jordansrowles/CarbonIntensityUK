using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    /// <summary>
    ///     Represents the Regional ID schema
    /// </summary>
    [JsonObject("data")]
    public class RegionalIdIntensityResponse
    {
        /// <summary>
        ///     Region ID 1-17
        /// </summary>
        [JsonProperty("regionid")]
        public int Id { get; set; }

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
        ///     GB regions (regionid, dnoregion, shortname, intensity)
        /// </summary>
        [JsonProperty("data")]
        public IList<RegionData> RegionData { get; set; }
    }
    
}
