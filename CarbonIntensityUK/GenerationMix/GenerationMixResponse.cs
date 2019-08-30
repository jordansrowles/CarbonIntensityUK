using CarbonIntensityUK.Shared;
using Newtonsoft.Json;

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
        public GenerationData GenerationMix { get; set; }
    }
}
