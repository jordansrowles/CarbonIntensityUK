using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarbonIntensityUK.NationalStatistics
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
    }
}
