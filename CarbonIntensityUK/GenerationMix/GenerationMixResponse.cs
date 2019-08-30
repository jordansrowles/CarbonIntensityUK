using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace CarbonIntensityUK.GenerationMix
{
    [JsonObject("data")]
    public class GenerationMixResponse
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

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
