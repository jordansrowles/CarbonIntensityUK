using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarbonIntensityUK.GenerationMix
{
    /// <summary>
    ///     Generation Mix for the GB power system.
    /// </summary>
    public static class NationalGeneration
    {
        /// <summary>
        ///     Get generation mix for current half hour
        /// </summary>
        /// <returns>GenerationMix schema</returns>
        public static async Task<GenerationMixResponse> Get()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/generation/");
            return ApiClient.AttemptConvert<GenerationMixResponse>(json);
        }

        /// <summary>
        ///     Get generation mix for the past 24 hours
        /// </summary>
        /// <param name="start">Get past 24 hour from this time</param>
        /// <returns>GenerationMix schema</returns>
        public static async Task<List<GenerationMixResponse>> GetPast24Hour(DateTime start)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/generation/{ApiClient.FormatDateTime(start)}/pt24h/");
            return ApiClient.AttemptConvert<List<GenerationMixResponse>>(json);
        }

        /// <summary>
        ///     Get generation mix between from and to datetimes
        /// </summary>
        /// <param name="start">Start of date range</param>
        /// <param name="end">End of date range</param>
        /// <returns>GenerationMix schema</returns>
        public static async Task<List<GenerationMixResponse>> Get(DateTime start, DateTime end)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/generation/{ApiClient.FormatDateTime(start)}/{ApiClient.FormatDateTime(end)}/");
            return ApiClient.AttemptConvert<List<GenerationMixResponse>>(json);
        }
    }
}
