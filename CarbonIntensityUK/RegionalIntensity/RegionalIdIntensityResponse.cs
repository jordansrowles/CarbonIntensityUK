using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    [JsonObject("data")]
    public class RegionalIdIntensityResponse
    {
        [JsonProperty("regionid")]
        public int Id { get; set; }

        [JsonProperty("dnoregion")]
        public string DnoRegion { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("data")]
        public IList<RegionData> RegionData { get; set; }
    }
    
}
