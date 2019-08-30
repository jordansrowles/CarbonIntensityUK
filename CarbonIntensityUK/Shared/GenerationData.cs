using Newtonsoft.Json;

namespace CarbonIntensityUK.Shared
{
    public class GenerationData
    {
        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("perc")]
        public double? Percentage { get; set; }
    }
}
