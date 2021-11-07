using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class RegionData
    {
        [JsonProperty("from")]
        public DateTimeOffset From { get; set; }

        [JsonProperty("to")]
        public DateTimeOffset To { get; set; }

        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        [JsonProperty("generationmix")]
        public IList<GenerationData> GenerationMix { get; set; }        
    }
}