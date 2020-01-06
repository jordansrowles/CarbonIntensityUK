using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class IntensityResponse
    {
        [JsonPropertyName("from")]
        public string From { get; set; }
        
        [JsonPropertyName("to")]
        public string To { get; set; }
        
        [JsonPropertyName("intensity")]
        public Intensity Intensity { get; set; }

        public override string ToString()
        {
            return $"{From} - {To}";
        }
    }        

}