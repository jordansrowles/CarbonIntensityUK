using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class GenerationMixResponse
    {
        [JsonProperty("from")]
        public DateTimeOffset From { get; set; }

        [JsonProperty("to")]
        public DateTimeOffset To { get; set; }

        [JsonProperty("generationmix")]
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