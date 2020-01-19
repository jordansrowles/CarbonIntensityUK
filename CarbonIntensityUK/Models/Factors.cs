using Newtonsoft.Json;

namespace CarbonIntensityUK.Models
{
    public class Factors
    {
        public int? Biomass { get; set; }
        public int? Coal { get; set; }
        [JsonProperty("Dutch Imports")]
        public int? DutchImports { get; set; }
        [JsonProperty("French Imports")]
        public int? FrenchImports { get; set; }
        [JsonProperty("Irish Imports")]
        public int? IrishImports { get; set; }
        [JsonProperty("Gas (Combined Cycle)")]
        public int? GasCombinedCycle { get; set; }
        [JsonProperty("Gas (Open Cycle)")]
        public int? GasOpenCycle { get; set; }
        public int? Hydro { get; set; }
        public int? Nuclear { get; set; }
        public int? Oil { get; set; }
        public int? Other { get; set; }
        [JsonProperty("Pumped Storage")]
        public int? PumpedStorage { get; set; }
        public int? Solar { get; set; }
        public int? Wind { get; set; }        
    }
}