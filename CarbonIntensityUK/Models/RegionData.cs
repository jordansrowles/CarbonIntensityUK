using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class RegionData
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("intensity")]
        public Intensity Intensity { get; set; }

        [JsonPropertyName("generationmix")]
        public IList<GenerationData> GenerationMix { get; set; }        
    }
}