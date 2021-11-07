using Newtonsoft.Json;
using System;

namespace CarbonIntensityUK.Models
{
    public class StatisticResponse
    {
        [JsonProperty("from")]
        public DateTimeOffset From { get; set; }

        [JsonProperty("to")]
        public DateTimeOffset To { get; set; }

        [JsonProperty("intensity")]
        public Statistic Intensity { get; set; }        
    }
}