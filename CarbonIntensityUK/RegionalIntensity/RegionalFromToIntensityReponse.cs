using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    [JsonObject("data")]
    public class RegionalFromToIntensityReponse
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("regions")]
        public IList<Region> Regions { get; set; }
    }
    
}
