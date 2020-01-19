using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    public static class NationalStatistics
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/intensity/stats/";

        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end) =>
            await ApiClient.GetAsObjects<List<StatisticResponse>>(
                $"{_base}{start.ToISO8601()}/{end.ToISO8601()}");

        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end, int block)
        {
            if (block > 31 || block < 1)
                throw new ArgumentOutOfRangeException(nameof(block), message: "Value block must be between 1 and 31.");
            return await ApiClient.GetAsObjects<List<StatisticResponse>>(
                $"{_base}{start.ToISO8601()}/{end.ToISO8601()}/{block}");
        }
    }
}