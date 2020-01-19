using System.Collections.Generic;
using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class RegionData
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        [JsonProperty("generationmix")]
        public IList<GenerationData> GenerationMix { get; set; }        
    }
}