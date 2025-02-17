using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class Intensity
    {
        [JsonPropertyName("forecast")]
        public int? Forecast { get; set; }

        [JsonPropertyName("actual")]
        public int? Actual { get; set; }

        [JsonPropertyName("index")]
        public string Index { get; set; }
    }
}
