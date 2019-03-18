using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarbonIntensityUK.NationalStatistics
{
    public static class NationalStatistics
    {
        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/stats/{ApiClient.FormatDateTime(start)}/{ApiClient.FormatDateTime(end)}");
            return ApiClient.AttemptConvert<List<StatisticResponse>>(json);
        }

        public static async Task<List<StatisticResponse>> Get(DateTime start, DateTime end, int block)
        {
            if (block > 31)
                throw new ArgumentOutOfRangeException("Block cannot be greater than 31");
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/stats/{ApiClient.FormatDateTime(start)}/{ApiClient.FormatDateTime(end)}");
            return ApiClient.AttemptConvert<List<StatisticResponse>>(json);
        }
    }
}
