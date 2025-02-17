using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class GenerationMixResponse
    {
        [JsonPropertyName("from")]
        public DateTimeOffset From { get; set; }

        [JsonPropertyName("to")]
        public DateTimeOffset To { get; set; }

        [JsonPropertyName("generationmix")]
        public IList<GenerationData> GenerationMix { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{From} - {To}\n");
            foreach (var i in GenerationMix)
                builder.Append($"{i.Fuel}\t{i.Percentage}%\n");
            return builder.ToString();
        }        
    }
}