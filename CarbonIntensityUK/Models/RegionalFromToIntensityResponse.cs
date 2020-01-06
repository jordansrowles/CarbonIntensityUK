using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class RegionalFromToIntensityResponse
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("regions")]
        public IList<Region> Regions { get; set; }
    }
}