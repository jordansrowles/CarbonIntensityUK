using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class GenerationData
    {
        [JsonPropertyName("fuel")]
        public string Fuel { get; set; }
        
        [JsonPropertyName("perc")]
        public double? Percentage { get; set; }
    }
}