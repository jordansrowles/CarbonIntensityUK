using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class GenerationData
    {
        [JsonProperty("fuel")]
        public string Fuel { get; set; }
        
        [JsonProperty("perc")]
        public double? Percentage { get; set; }
    }
}