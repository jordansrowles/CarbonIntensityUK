using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class Statistic
    {
        [JsonPropertyName("max")]
        public int? Max { get; set; }

        [JsonPropertyName("average")]
        public int? Average { get; set; }

        [JsonPropertyName("min")]
        public int? Min { get; set; }

        [JsonPropertyName("index")]
        public string Index { get; set; }

        public override string ToString() => $"{Index} ({Min}, {Max}. {Average})";
    }
}