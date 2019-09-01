using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    public class RegionData // for RegionalIdIntensityReponse
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
