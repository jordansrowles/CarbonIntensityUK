using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    /// <summary>
    ///     Gets national carbon intensity statistics
    /// </summary>
    public static class NationalStatistics
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/intensity/stats/";

        /// <summary>
        ///     Gets carbon intensity statistics for between specified datetimes
        /// </summary>
        /// <param name="start">Start of datetime in ISO 8601 format</param>
        /// <param name="end">End of datetime in ISO 8601 format</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.StatisticResponse"><c>StatisticResponse</c></see> objects</returns>
        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end) =>
            await ApiClient.GetAsObjects<List<StatisticResponse>>(
                $"{_base}{start.ToISO8601()}/{end.ToISO8601()}");
        
        /// <summary>
        ///     Gets carbon intensity statistics in blocks between specified datetimes
        /// </summary>
        /// <param name="start">Start of datetime in ISO 8601 format</param>
        /// <param name="end">End of datetime in ISO 8601 format</param>
        /// <param name="block">Block length in hours. A block length of 2 hours over a 24 hour period returns 12 items with the average, max, min for each 2 hr block.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">Value block must be between 1 and 31.</exception>
        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end, int block)
        {
            if (block > 31 || block < 1)
                throw new ArgumentOutOfRangeException(nameof(block), message: "Value block must be between 1 and 31.");
            return await ApiClient.GetAsObjects<List<StatisticResponse>>(
                $"{_base}{start.ToISO8601()}/{end.ToISO8601()}/{block}");
        }
    }
}