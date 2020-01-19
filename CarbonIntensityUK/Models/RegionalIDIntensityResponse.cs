using System.Collections.Generic;
using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class RegionalIDIntensityResponse
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