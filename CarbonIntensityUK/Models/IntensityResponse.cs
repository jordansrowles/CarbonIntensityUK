using Newtonsoft.Json;
using System;

namespace CarbonIntensityUK.Models
{
    public class IntensityResponse
    {
        [JsonProperty("from")]
        public DateTimeOffset From { get; set; }
        
        [JsonProperty("to")]
        public DateTimeOffset To { get; set; }
        
        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        public override string ToString()
        {
            return $"{From} - {To}";
        }
    }        

}