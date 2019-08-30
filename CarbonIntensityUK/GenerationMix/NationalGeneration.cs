using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarbonIntensityUK.GenerationMix
{
    public static class NationalGeneration
    {
        public static async Task<GenerationMixResponse> Get()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/generation/");
            return ApiClient.AttemptConvert<GenerationMixResponse>(json);
        }

        public static async Task<List<GenerationMixResponse>> GetPast24Hour(DateTime start)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/generation/{ApiClient.FormatDateTime(start)}/pt24h/");
            return ApiClient.AttemptConvert<List<GenerationMixResponse>>(json);
        }

        public static async Task<List<GenerationMixResponse>> Get(DateTime start, DateTime end)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/generation/{ApiClient.FormatDateTime(start)}/{ApiClient.FormatDateTime(end)}/");
            return ApiClient.AttemptConvert<List<GenerationMixResponse>>(json);
        }
    }
}
