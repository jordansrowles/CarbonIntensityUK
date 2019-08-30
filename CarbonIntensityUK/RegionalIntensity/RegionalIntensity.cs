using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarbonIntensityUK.RegionalIntensity
{
    public class Region
    {
        [JsonProperty("regionid")]
        public int Regionid { get; set; }

        [JsonProperty("dnoregion")]
        public string Dnoregion { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        [JsonProperty("generationmix")]
        public IList<GenerationData> Generationmix { get; set; }
    }

    [JsonObject("data")]
    public class RegionalIntensityReponse
    {

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("regions")]
        public IList<Region> Regions { get; set; }
    }

    public static class RegionalIntensity
    {
        public static async Task<List<RegionalIntensityReponse>> Get()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/regional");
            return ApiClient.AttemptConvert<List<RegionalIntensityReponse>>(json);
        }
    }
    
}
