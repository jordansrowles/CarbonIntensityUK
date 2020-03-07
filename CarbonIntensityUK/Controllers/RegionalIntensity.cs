using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    /// <summary>
    ///     Gets regional intensity data
    /// </summary>
    public static class RegionalIntensity
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/regional/";

        /// <summary>
        ///     Gets the current carbon intensity for GB regions
        /// </summary>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalFromToIntensityResponse"><c>RegionalFromToIntensityResponse</c></see> objects</returns>
        public static async Task<List<RegionalFromToIntensityResponse>> Get() =>
            await ApiClient.GetAsObjects<List<RegionalFromToIntensityResponse>>(
                $"{_base}");

        /// <summary>
        ///     Gets the current carbon intensity for specified outward postcode
        /// </summary>
        /// <param name="postcode">Outward postcode</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalIDIntensityResponse"><c>RegionalIDIntensityResponse</c></see> objects</returns>
        public static async Task<List<RegionalIDIntensityResponse>> Get(string postcode) =>
            await ApiClient.GetAsObjects<List<RegionalIDIntensityResponse>>(
                $"{_base}postcode/{postcode}");

        /// <summary>
        ///     Gets carbon intensity for specified country in GB
        /// </summary>
        /// <param name="country">A specified <see cref="CarbonIntensityUK.Models.Country"><c>Country</c></see></param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalFromToIntensityResponse"><c>RegionalFromToIntensityResponse</c></see> objects</returns>
        public static async Task<List<RegionalFromToIntensityResponse>> Get(Country country) =>
            await ApiClient.GetAsObjects <List<RegionalFromToIntensityResponse>>(
                $"{_base}{country.ToString().ToLower()}");

        /// <summary>
        ///     Gets carbon intensity for specified region
        /// </summary>
        /// <param name="region">A specified <see cref="CarbonIntensityUK.Models.RegionIDs"><c>Region ID</c></see></param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalIDIntensityResponse"><c>RegionalIDIntensityResponse</c></see> objects</returns>
        public static async Task<List<RegionalIDIntensityResponse>> Get(RegionIDs region) =>
            await ApiClient.GetAsObjects<List<RegionalIDIntensityResponse>>(
                $"{_base}regionid/{(int)region}");
        
        /// <summary>
        ///     Gets carbon intensity for specified datetime for GB regions
        /// </summary>
        /// <param name="option">A <see cref="IntensityUriOption"><c>IntensityURIOption</c></see></param>
        /// <param name="from">Specified from datetime in ISO 8601 format</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalFromToIntensityResponse"><c>RegionalFromToIntensityResponse</c></see> objects</returns>
        public static async Task<List<RegionalFromToIntensityResponse>> Get(IntensityUriOption option, DateTime from) =>
            await ApiClient.GetAsObjects<List<RegionalFromToIntensityResponse>>(
                $"{_base}intensity/{from.ToISO8601()}/{option.ToString().ToLower()}");
        
        /// <summary>
        ///     Gets carbon intensity for a forecast and specific datetime for a specified outward postcode
        /// </summary>
        /// <param name="option">A <see cref="IntensityUriOption"><c>IntensityURIOption</c></see></param>
        /// <param name="from">Specified from datetime in ISO 8601 format</param>
        /// <param name="postcode">Outward postcode</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalIDIntensityResponse"><c>RegionalIDIntensityResponse</c></see> objects</returns>
        public static async Task<RegionalIDIntensityResponse> Get(IntensityUriOption option, DateTime from, string postcode) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{option.ToString().ToLower()}/postcode/{postcode}");

        /// <summary>
        ///     Gets carbon intensity for a forecast and specific datetime for a specified Region ID
        /// </summary>
        /// <param name="option">A <see cref="IntensityUriOption"><c>IntensityURIOption</c></see></param>
        /// <param name="from">Specified from datetime in ISO 8601 format</param>
        /// <param name="region">A specified <see cref="CarbonIntensityUK.Models.RegionIDs"><c>Region ID</c></see></param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalIDIntensityResponse"><c>RegionalIDIntensityResponse</c></see> objects</returns>
        public static async Task<RegionalIDIntensityResponse> Get(IntensityUriOption option, DateTime from,
            RegionIDs region) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{option.ToString().ToLower()}/regionid/{(int)region}");

        /// <summary>
        ///     Gets carbon intensity between specified datetimes for GB regions
        /// </summary>
        /// <param name="from">Start datetime range in ISO 8601 format</param>
        /// <param name="to">End datetime range in ISO 8601 format</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalFromToIntensityResponse"><c>RegionalFromToIntensityResponse</c></see> objects</returns>
        public static async Task<List<RegionalFromToIntensityResponse>> Get(DateTime from, DateTime to) =>
            await ApiClient.GetAsObjects<List<RegionalFromToIntensityResponse>>(
                $"{_base}intensity/{from.ToISO8601()}/{to.ToISO8601()}");

        /// <summary>
        ///     Gets carbon intensity between specified datetimes for specified outward postcode
        /// </summary>
        /// <param name="from">Start datetime range in ISO 8601 format</param>
        /// <param name="to">End datetime range in ISO 8601 format</param>
        /// <param name="postcode">Outward postcode</param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalIDIntensityResponse"><c>RegionalIDIntensityResponse</c></see> objects</returns>
        public static async Task<RegionalIDIntensityResponse> Get(DateTime from, DateTime to, string postcode) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{to.ToISO8601()}/postcode/{postcode}");

        /// <summary>
        ///     Gets carbon intensity between specified datetimes for specified region
        /// </summary>
        /// <param name="from">Start datetime range in ISO 8601 format</param>
        /// <param name="to">End datetime range in ISO 8601 format</param>
        /// <param name="region">A specified <see cref="CarbonIntensityUK.Models.RegionIDs"><c>Region ID</c></see></param>
        /// <returns>List of <see cref="CarbonIntensityUK.Models.RegionalIDIntensityResponse"><c>RegionalIDIntensityResponse</c></see> objects</returns>
        public static async Task<RegionalIDIntensityResponse> Get(DateTime from, DateTime to, RegionIDs region) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{to.ToISO8601()}/regionid/{(int)region}");
    }
}