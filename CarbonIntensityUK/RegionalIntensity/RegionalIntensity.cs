using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Shared;

namespace CarbonIntensityUK.RegionalIntensity
{
    public static class RegionalIntensity
    {
        /// <summary>
        ///     GET
        ///         /regional
        /// </summary>
        /// <returns>RegionalFromTo schema</returns>
        public static async Task<List<RegionalFromToIntensityReponse>> Get()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/regional");
            return ApiClient.AttemptConvert<List<RegionalFromToIntensityReponse>>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/postcode/{postcode}
        /// </summary>
        /// <param name="postcode">Outward code only</param>
        /// <returns>RegionalId schema</returns>
        public static async Task<List<RegionalIdIntensityResponse>> Get(string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/postcode/{postcode}");
            return ApiClient.AttemptConvert<List<RegionalIdIntensityResponse>>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/england
        ///         /regional/scotland
        ///         /regional/wales
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static async Task<List<RegionalFromToIntensityReponse>> Get(Country country)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/{country.ToString().ToLower()}");
            return ApiClient.AttemptConvert<List<RegionalFromToIntensityReponse>>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/regionid/{regionid}
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public static async Task<List<RegionalIdIntensityResponse>> Get(RegionId regionId)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/regionid/{(int)regionId}");
            return ApiClient.AttemptConvert<List<RegionalIdIntensityResponse>>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/intensity/{from}/fw24h/
        ///         /regional/intensity/{from}/fw48h/
        ///         /regional/intensity/{from}/pt24h/
        /// </summary>
        /// <param name="option">Forecast option</param>
        /// <param name="from">ISO 8601 string</param>
        /// <returns>RegionalFromTo schema</returns>
        public static async Task<List<RegionalFromToIntensityReponse>> Get(IntensityUriOption option, DateTime from)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/intensity/{ApiClient.FormatDateTime(from)}/{option.ToString().ToLower()}");
            return ApiClient.AttemptConvert<List<RegionalFromToIntensityReponse>>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/intensity/{from}/fw24h/postcode/{postcode}
        ///         /regional/intensity/{from}/fw48h/postcode/{postcode}
        ///         /regional/intensity/{from}/pt24h/postcode/{postcode}
        /// </summary>
        /// <param name="option">Forecast option</param>
        /// <param name="from">ISO 8601 string</param>
        /// <param name="postcode">Outward code only</param>
        /// <returns>RegionalId schema</returns>
        public static async Task<RegionalIdIntensityResponse> Get(IntensityUriOption option, DateTime from, string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/intensity/{ApiClient.FormatDateTime(from)}/{option.ToString()}/postcode/{postcode}");
            return ApiClient.AttemptConvert<RegionalIdIntensityResponse>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/intensity/{from}/fw24h/regionid/{regionid}
        ///         /regional/intensity/{from}/fw48h/regionid/{regionid}
        ///         /regional/intensity/{from}/pt24h/regionid/{regionid}
        /// </summary>
        /// <param name="option">Forecast option</param>
        /// <param name="from">ISO 8601 string</param>
        /// <param name="region">Region ID</param>
        /// <returns>RegionalId schema</returns>
        public static async Task<RegionalIdIntensityResponse> Get(IntensityUriOption option, DateTime from, RegionId region)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/intensity/{ApiClient.FormatDateTime(from)}/{option.ToString()}/regionid/{(int)region}");
            return ApiClient.AttemptConvert<RegionalIdIntensityResponse>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/intensity/{from}/{to}
        /// </summary>
        /// <param name="from">ISO 8601 string</param>
        /// <param name="to">ISO 8601 string</param>
        /// <returns>RegionalFromTo schema</returns>
        public static async Task<List<RegionalFromToIntensityReponse>> Get(DateTime from, DateTime to)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/intensity/{ApiClient.FormatDateTime(from)}/{ApiClient.FormatDateTime(to)}");
            return ApiClient.AttemptConvert<List<RegionalFromToIntensityReponse>>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/intensity/{from}/{to}/postcode/{postcode}
        /// </summary>
        /// <param name="from">ISO 8601 string</param>
        /// <param name="to">ISO 8601 string</param>
        /// <param name="postcode">Outward postcode only</param>
        /// <returns>RegionalId schema</returns>
        public static async Task<RegionalIdIntensityResponse> Get(DateTime from, DateTime to, string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/intensity/{ApiClient.FormatDateTime(from)}/{ApiClient.FormatDateTime(to)}/postcode/{postcode}");
            return ApiClient.AttemptConvert<RegionalIdIntensityResponse>(json);
        }

        /// <summary>
        ///     GET
        ///         /regional/intensity/{from}/{to}/regionid/{regionid}
        /// </summary>
        /// <param name="from">ISO 8601 string</param>
        /// <param name="to">ISO 8601 string</param>
        /// <param name="regionId">Region ID</param>
        /// <returns>RegionalId schema</returns>
        public static async Task<RegionalIdIntensityResponse> Get(DateTime from, DateTime to, RegionId regionId)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/intensity/{ApiClient.FormatDateTime(from)}/{ApiClient.FormatDateTime(to)}/regionid/{(int)regionId}");
            return ApiClient.AttemptConvert<RegionalIdIntensityResponse>(json);
        }

    }
    
}
