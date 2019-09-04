using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarbonIntensityUK.NationalStatistics
{
    /// <summary>
    ///     Represents the statistic controller of the API, api.carbonintensity.org.uk/intensity/stats/
    /// </summary>
    public static class NationalStatistics
    {
        /// <summary>
        ///     Get Carbon Intensity statistics between from and to datetime
        ///     GET
        ///         /intensity/stats/{from}/{to}
        /// </summary>
        /// <param name="start">Start of date range</param>
        /// <param name="end">End of date range</param>
        /// <returns>Statistic schema</returns>
        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/stats/{ApiClient.FormatDateTime(start)}/{ApiClient.FormatDateTime(end)}");
            return ApiClient.AttemptConvert<List<StatisticResponse>>(json);
        }

        /// <summary>
        ///     Get block average Carbon Intensity statistics between from and to datetime
        ///     GET
        ///         /intensity/stats/{from}/{to}/{block}
        /// </summary>
        /// <param name="start">Start of date range</param>
        /// <param name="end">End of date range</param>
        /// <param name="block">Block length in hours</param>
        /// <returns>Statistic schema</returns>
        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end, int block)
        {
            if (block > 31)
                throw new ArgumentOutOfRangeException("Block cannot be greater than 31");
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/stats/{ApiClient.FormatDateTime(start)}/{ApiClient.FormatDateTime(end)}");
            return ApiClient.AttemptConvert<List<StatisticResponse>>(json);
        }
    }
}
