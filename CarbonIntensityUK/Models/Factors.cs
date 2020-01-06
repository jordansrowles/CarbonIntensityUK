using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models
{
    public class Factors
    {
        public int? Biomass { get; set; }
        public int? Coal { get; set; }
        [JsonPropertyName("Dutch Imports")]
        public int? DutchImports { get; set; }
        [JsonPropertyName("French Imports")]
        public int? FrenchImports { get; set; }
        [JsonPropertyName("Irish Imports")]
        public int? IrishImports { get; set; }
        [JsonPropertyName("Gas (Combined Cycle)")]
        public int? GasCombinedCycle { get; set; }
        [JsonPropertyName("Gas (Open Cycle)")]
        public int? GasOpenCycle { get; set; }
        public int? Hydro { get; set; }
        public int? Nuclear { get; set; }
        public int? Oil { get; set; }
        public int? Other { get; set; }
        [JsonPropertyName("Pumped Storage")]
        public int? PumpedStorage { get; set; }
        public int? Solar { get; set; }
        public int? Wind { get; set; }        
    }
}