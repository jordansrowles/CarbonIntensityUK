using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class Region
    {
        [JsonPropertyName("regionid")]
        public int RegionId { get; set; }

        [JsonPropertyName("dnoregion")]
        public string DnoRegion { get; set; }

        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("intensity")]
        public Intensity Intensity { get; set; }

        [JsonPropertyName("generationmix")]
        public IList<GenerationData> Generationmix { get; set; }        
    }
}