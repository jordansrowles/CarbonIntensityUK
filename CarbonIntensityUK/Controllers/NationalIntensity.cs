using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    public static class NationalIntensity
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/intensity/";
        
        public static async Task<List<IntensityResponse>> Get() =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>(_base);
        
        public static async Task<List<Factors>> Factors() =>
            await ApiClient.GetAsObjects<List<Factors>>($"{_base}factors");

        public static async Task<List<IntensityResponse>> GetToday() =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>($"{_base}date");

        public static async Task<List<IntensityResponse>> Get(DateTime date) =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>($"{_base}{date.ToSimpleDate()}");

        public static async Task<List<IntensityResponse>> Get(DateTime start, DateTime end) =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>(
                $"{_base}{start.ToISO8601()}/{end.ToISO8601()}");

        public static async Task<List<IntensityResponse>> Get(DateTime date, int period)
        {
            if (period > 48 || period < 1)
                throw new ArgumentOutOfRangeException(nameof(period), message: "Value period must be between 1 and 48.");
            return await ApiClient.GetAsObjects<List<IntensityResponse>>(
                $"{_base}date/{date.ToSimpleDate()}/{period}");
        }

        public static async Task<List<IntensityResponse>> GetByDateTime(DateTime date) =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>(
                $"{_base}{date.ToISO8601()}");

        public static async Task<List<IntensityResponse>> Get(DateTime date, IntensityURIOption option) =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>(
                $"{_base}{date.ToISO8601()}/{option.ToString()}");
    }
}