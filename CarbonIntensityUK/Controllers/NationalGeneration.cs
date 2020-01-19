using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    public static class NationalGeneration
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/generation/";

        public static async Task<GenerationMixResponse> Get() =>
            await ApiClient.GetAsObjects<GenerationMixResponse>(
                $"{_base}");

        public static async Task<List<GenerationMixResponse>> Get(DateTime date) =>
            await ApiClient.GetAsObjects<List<GenerationMixResponse>>(
                $"{_base}{date.ToISO8601()}/pt24h/");

        public static async Task<List<GenerationMixResponse>> Get(DateTime start, DateTime end) =>
            await ApiClient.GetAsObjects<List<GenerationMixResponse>>(
                $"{_base}{start.ToISO8601()}/{end.ToISO8601()}");
    }
}