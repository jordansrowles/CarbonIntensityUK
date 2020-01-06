using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class StatisticResponse
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("intensity")]
        public Statistic Intensity { get; set; }        
    }
}