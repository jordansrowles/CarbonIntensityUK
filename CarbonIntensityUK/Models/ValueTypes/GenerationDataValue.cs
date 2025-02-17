using System.Diagnostics;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models.ValueTypes
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public record struct GenerationDataValue(
        [property: JsonPropertyName("fuel")] string Fuel,
        [property: JsonPropertyName("perc")] double? Percentage
    )
    {
        public override readonly string ToString() => $"{Fuel} ({Percentage}%)";
        private string GetDebuggerDisplay() => ToString();
    }
}
