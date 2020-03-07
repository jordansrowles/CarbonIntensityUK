using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    /// <summary>
    ///     National carbon generation mix data
    /// </summary>
    public static class NationalGeneration
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/generation/";

        /// <summary>
        ///     Gets the current generation mix
        /// </summary>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.GenerationMixResponse"><c>GenerationMixResponse</c></see> objects</returns>
        public static async Task<GenerationMixResponse> Get() =>
            await ApiClient.GetAsObjects<GenerationMixResponse>(
                $"{_base}");

        /// <summary>
        ///     Gets the generation mix for 24 hours before specified datetime
        /// </summary>
        /// <param name="date">Specific datetime in ISO 8601 format</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.GenerationMixResponse"><c>GenerationMixResponse</c></see> objects</returns>
        public static async Task<List<GenerationMixResponse>> Get(DateTime date) =>
            await ApiClient.GetAsObjects<List<GenerationMixResponse>>(
                $"{_base}{date.ToISO8601()}/pt24h/");

        /// <summary>
        ///     Gets the generation mix between specified datetimes
        /// </summary>
        /// <param name="start">Start of datetime range in ISO 8601 format</param>
        /// <param name="end">End of datetime range in ISO 8601 format</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.GenerationMixResponse"><c>GenerationMixResponse</c></see> objects</returns>
        public static async Task<List<GenerationMixResponse>> Get(DateTime start, DateTime end) =>
            await ApiClient.GetAsObjects<List<GenerationMixResponse>>(
                $"{_base}{start.ToISO8601()}/{end.ToISO8601()}");
    }
}