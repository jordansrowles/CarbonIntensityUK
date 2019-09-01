using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarbonIntensityUK.RegionalIntensity
{
    public class Region // for RegionalFromToIntensityReponse
    {
        [JsonProperty("regionid")]
        public int RegionId { get; set; }

        [JsonProperty("dnoregion")]
        public string DnoRegion { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("intensity")]
        public Intensity Intensity { get; set; }

        [JsonProperty("generationmix")]
        public IList<GenerationData> Generationmix { get; set; }
    }
    
}
