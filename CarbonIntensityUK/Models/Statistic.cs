using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class Statistic
    {
        [JsonProperty("max")]
        public int? Max { get; set; }

        [JsonProperty("average")]
        public int? Average { get; set; }

        [JsonProperty("min")]
        public int? Min { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        public override string ToString() => $"{Index} ({Min}, {Max}. {Average})";
    }
}