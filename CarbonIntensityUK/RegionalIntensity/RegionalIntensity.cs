using CarbonIntensityUK.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarbonIntensityUK.RegionalIntensity
{
    public static class RegionalIntensity
    {
        public static async Task<List<RegionalFromToIntensityReponse>> Get()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/regional");
            return ApiClient.AttemptConvert<List<RegionalFromToIntensityReponse>>(json);
        }

        public static async Task<List<RegionalIdIntensityResponse>> Get(string postcode)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/postcode/{postcode}");
            return ApiClient.AttemptConvert<List<RegionalIdIntensityResponse>>(json);
        }

        public static async Task<List<RegionalFromToIntensityReponse>> Get(Country country)
        {
            var json = await ApiClient.QueryAsync($"https://api.carbonintensity.org.uk/regional/{country.ToString().ToLower()}");
            return ApiClient.AttemptConvert<List<RegionalFromToIntensityReponse>>(json);
        }
    }
    
}
