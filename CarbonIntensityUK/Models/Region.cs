using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class Region
    {
        [JsonPropertyName("regionid")]
        public int RegionId
        {
            get => RegionId;
            set
            {
                if (value < 0 || value > 17)
                    throw new ArgumentOutOfRangeException("RegionId", "Value cannot be negative, nor larger than 17.");
            }
        }

        [JsonPropertyName("dnoregion")]
        public string DnoRegion { get; set; }

        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("intensity")]
        public Intensity Intensity { get; set; }

        [JsonPropertyName("generationmix")]
        public IList<GenerationData> Generationmix { get; set; }        
    }
}