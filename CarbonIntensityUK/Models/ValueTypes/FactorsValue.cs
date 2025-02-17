using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models.ValueTypes
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public record struct FactorsValue(
    int? Biomass,
    int? Coal,
    [property: JsonPropertyName("Dutch Imports")] int? DutchImports,
    [property: JsonPropertyName("French Imports")] int? FrenchImports,
    [property: JsonPropertyName("Irish Imports")] int? IrishImports,
    [property: JsonPropertyName("Gas (Combined Cycle)")] int? GasCombinedCycle,
    [property: JsonPropertyName("Gas (Open Cycle)")] int? GasOpenCycle,
    int? Hydro,
    int? Nuclear,
    int? Oil,
    int? Other,
    [property: JsonPropertyName("Pumped Storage")] int? PumpedStorage,
    int? Solar,
    int? Wind
)
    {

        private string GetDebuggerDisplay() => JsonSerializer.Serialize<FactorsValue>(this);
    }
}
