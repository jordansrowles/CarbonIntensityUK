using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    /// <summary>
    ///     Gets carbon intensity data for the whole of the UK region. Offers factors of
    ///     carbon emissions, querying by date, for range and period.
    /// </summary>
    public static class NationalIntensity
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/intensity/";
        
        /// <summary>
        ///     Gets current carbon intensity
        /// </summary>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.IntensityResponse"><c>IntensityResponse</c></see> objects</returns>
        public static async Task<List<IntensityResponse>> Get() =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>(_base);
        
        /// <summary>
        ///     Gets carbon intensity for specified fuel types
        /// </summary>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.Factors"><c>Factors</c></see> objects</returns>
        public static async Task<List<Factors>> Factors() =>
            await ApiClient.GetAsObjects<List<Factors>>($"{_base}factors");

        /// <summary>
        ///     Gets carbon intensity for today
        /// </summary>
        /// <returns></returns>
        public static async Task<List<IntensityResponse>> GetToday() =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>($"{_base}date");

        /// <summary>
        ///     Gets carbon intensity for a specified date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static async Task<List<IntensityResponse>> Get(DateTime date) =>
            await ApiClient.GetAsObjects<List<IntensityResponse>>($"{_base}{date.ToSimpleDate()}");

        /// <summary>
        ///     Gets carbon intensity between specified datetimes
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
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