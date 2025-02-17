using System;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class IntensityResponse
    {
        [JsonPropertyName("from")]
        public DateTimeOffset From { get; set; }
        
        [JsonPropertyName("to")]
        public DateTimeOffset To { get; set; }
        
        [JsonPropertyName("intensity")]
        public Intensity Intensity { get; set; }

        public override string ToString()
        {
            return $"{From} - {To}";
        }
    }        

}