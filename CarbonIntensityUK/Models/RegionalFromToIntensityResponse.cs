using System.Collections.Generic;
using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class RegionalFromToIntensityResponse
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("regions")]
        public IList<Region> Regions { get; set; }
    }
}