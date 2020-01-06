using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class RegionalIDIntensityResponse
    {
        [JsonPropertyName("regionid")]
        public int Id { get; set; }

        [JsonPropertyName("dnoregion")]
        public string DnoRegion { get; set; }

        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("data")]
        public IList<RegionData> RegionData { get; set; }        
    }
}