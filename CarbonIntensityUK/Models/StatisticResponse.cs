using System.Text.Json.Serialization;
using System;

namespace CarbonIntensityUK.Models
{
    public class StatisticResponse
    {
        [JsonPropertyName("from")]
        public DateTimeOffset From { get; set; }

        [JsonPropertyName("to")]
        public DateTimeOffset To { get; set; }

        [JsonPropertyName("intensity")]
        public Statistic Intensity { get; set; }        
    }
}