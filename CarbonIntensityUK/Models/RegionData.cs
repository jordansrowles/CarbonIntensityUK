using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class RegionData
    {
        [JsonPropertyName("from")]
        public DateTimeOffset From { get; set; }

        [JsonPropertyName("to")]
        public DateTimeOffset To { get; set; }

        [JsonPropertyName("intensity")]
        public Intensity Intensity { get; set; }

        [JsonPropertyName("generationmix")]
        public IList<GenerationData> GenerationMix { get; set; }        
    }
}