using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace CarbonIntensityUK.Models.ValueTypes
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public record struct GenerationMixResponseValue(
        [property: JsonPropertyName("from")] DateTimeOffset From,
        [property: JsonPropertyName("to")] DateTimeOffset To,
        [property: JsonPropertyName("generationmix")] IList<GenerationDataValue> GenerationMix
    )
    {
        public override readonly string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"{From} - {To}\n");
            foreach (var i in GenerationMix)
                builder.Append($"{i.Fuel}\t{i.Percentage}%\n");
            return builder.ToString();

        }

        private string GetDebuggerDisplay() => ToString();
    }
}
