using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class IntensityResponse
    {
        [JsonProperty("from")]
        public string From { get; set; }
        
        [JsonProperty("to")]
        public string To { get; set; }
        
        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        public override string ToString()
        {
            return $"{From} - {To}";
        }
    }        

}