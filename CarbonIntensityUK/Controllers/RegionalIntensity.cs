using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;

namespace CarbonIntensityUK.Controllers
{
    public static class RegionalIntensity
    {
        static readonly string _base = "https://api.carbonintensity.org.uk/regional/";

        public static async Task<List<RegionalFromToIntensityResponse>> Get() =>
            await ApiClient.GetAsObjects<List<RegionalFromToIntensityResponse>>(
                $"{_base}");

        public static async Task<List<RegionalIDIntensityResponse>> Get(string postcode) =>
            await ApiClient.GetAsObjects<List<RegionalIDIntensityResponse>>(
                $"{_base}postcode/{postcode}");

        public static async Task<List<RegionalFromToIntensityResponse>> Get(Country country) =>
            await ApiClient.GetAsObjects <List<RegionalFromToIntensityResponse>>(
                $"{_base}{country.ToString().ToLower()}");

        public static async Task<List<RegionalIDIntensityResponse>> Get(RegionIDs region) =>
            await ApiClient.GetAsObjects<List<RegionalIDIntensityResponse>>(
                $"{_base}regionid/{(int)region}");
        
        public static async Task<List<RegionalFromToIntensityResponse>> Get(IntensityURIOption option, DateTime from) =>
            await ApiClient.GetAsObjects<List<RegionalFromToIntensityResponse>>(
                $"{_base}intensity/{from.ToISO8601()}/{option.ToString().ToLower()}");
        
        public static async Task<RegionalIDIntensityResponse> Get(IntensityURIOption option, DateTime from, string postcode) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{option.ToString().ToLower()}/postcode/{postcode}");

        public static async Task<RegionalIDIntensityResponse> Get(IntensityURIOption option, DateTime from,
            RegionIDs region) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{option.ToString().ToLower()}/regionid/{(int)region}");

        public static async Task<List<RegionalFromToIntensityResponse>> Get(DateTime from, DateTime to) =>
            await ApiClient.GetAsObjects<List<RegionalFromToIntensityResponse>>(
                $"{_base}intensity/{from.ToISO8601()}/{to.ToISO8601()}");

        public static async Task<RegionalIDIntensityResponse> Get(DateTime from, DateTime to, string postcode) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{to.ToISO8601()}/postcode/{postcode}");

        public static async Task<RegionalIDIntensityResponse> Get(DateTime from, DateTime to, RegionIDs region) =>
            await ApiClient.GetAsObjects<RegionalIDIntensityResponse>(
                $"{_base}intensity/{from.ToISO8601()}/{to.ToISO8601()}/regionid/{(int)region}");
    }
}