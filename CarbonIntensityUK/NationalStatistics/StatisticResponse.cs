﻿using Newtonsoft.Json;

namespace CarbonIntensityUK.NationalStatistics
{
    [JsonObject("data")]
    public class StatisticResponse
    {
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("intensity")]
        public Statistic Intensity { get; set; }
    }
}
