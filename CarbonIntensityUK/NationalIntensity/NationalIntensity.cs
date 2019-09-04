using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Shared;

namespace CarbonIntensityUK
{
    /// <summary>
    ///     Represents the National Intensity controller of the API, api.carbonintensity.org.uk/intensity/
    /// </summary>
    public static class NationalIntensity
    {
        /// <summary>
        ///     Gets carbon intensity data for the current half hour of todays date
        ///     GET
        ///         /intensity/
        /// </summary>
        /// <returns>List of IntensityResponse objects</returns>
        public static async Task<List<IntensityResponse>> Get()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/intensity/");
            return ApiClient.AttemptConvert<List<IntensityResponse>>(json);
        }

        /// <summary>
        ///     Gets carbon intensity data for specific fuel types
        ///     GET
        ///         /intensity/factors
        /// </summary>
        /// <returns>List of Factor objects</returns>
        public static async Task<List<Factors>> Factors()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/intensity/factors");
            return ApiClient.AttemptConvert<List<Factors>>(json);
        }

        /// <summary>
        ///     Gets carbon intensity data for today
        ///     GET
        ///         /intensity/date
        /// </summary>
        /// <returns>List of IntensityResponse objects</returns>
        public static async Task<List<IntensityResponse>> GetToday()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/intensity/date");
            return ApiClient.AttemptConvert<List<IntensityResponse>>(json);
        }

        /// <summary>
        ///     Gets carbon intensity for a specific date
        ///     GET
        ///         /intensity/date/{date}
        /// </summary>
        /// <param name="date">DateTime object</param>
        /// <returns>List of IntensityResponse objects</returns>
        public static async Task <List<IntensityResponse>> Get(DateTime date)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/date/{ApiClient.FormatDate(date)}");
            return ApiClient.AttemptConvert<List<IntensityResponse>>(json);
        }

        /// <summary>
        ///     Get carbon intensity for a range between two datetimes
        ///     GET
        ///         /intensity/{start_date}/{end_date}
        /// </summary>
        /// <param name="start">Range start datetime</param>
        /// <param name="end">Range end datetime</param>
        /// <returns>List of IntensityResponse objects</returns>
        public static async Task<List<IntensityResponse>> Get(DateTime start, DateTime end)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/date/{ApiClient.FormatDateTime(start)}/{ApiClient.FormatDateTime(end)}");
            return ApiClient.AttemptConvert<List<IntensityResponse>>(json);
        }

        /// <summary>
        ///     Gets carbon intensity for a specific half hour period in a day
        ///     GET
        ///         /intensity/{date}/{period}
        /// </summary>
        /// <param name="date">DateTime object</param>
        /// <param name="period">Half hour period as integer, 1 - 48</param>
        /// <returns>List of IntensityResponse objects</returns>
        public static async Task<List<IntensityResponse>> Get(DateTime date, int period)
        {
            if (period > 48)
                throw new ArgumentOutOfRangeException("Argument period should be between 1 and 48.");
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/date/{ApiClient.FormatDate(date)}/{period}");
            return ApiClient.AttemptConvert<List<IntensityResponse>>(json);
        }

        /// <summary>
        ///     Gets carbon intensity data for a specific datetime
        ///     GET
        ///         /intensity/{date}
        /// </summary>
        /// <param name="date">DateTime object</param>
        /// <returns>List of IntensityResponse objects</returns>
        public static async Task<List<IntensityResponse>> GetByDateTime(DateTime date)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/{ApiClient.FormatDateTime(date)}");
            return ApiClient.AttemptConvert<List<IntensityResponse>>(json);
        }

        /// <summary>
        ///     Gets carbon intensity data with an option. Foward 24, 48 hours, or Back 24 hours
        ///     GET
        ///         /intensity/{date}/fw24h
        ///         /intensity/{date}/fw48h
        ///         /intensity/{date}/pt24h
        /// </summary>
        /// <param name="date">DateTime object</param>
        /// <param name="option">Option for setting the url</param>
        /// <returns>List of IntensityResponse objects</returns>
        public static async Task<List<IntensityResponse>> Get(DateTime date, IntensityUriOption option)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/intensity/date/{ApiClient.FormatDateTime(date)}/{option.ToString()}");
            return ApiClient.AttemptConvert<List<IntensityResponse>>(json);
        }

        
    }
}
