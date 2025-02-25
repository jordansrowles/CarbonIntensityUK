using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarbonIntensityUK 
{
    /// <summary>
    ///     Used to call the API
    ///     Declared internal
    /// </summary>
    internal static class ApiClient
    {
        public static string ToSimpleDate(this DateTime dt) => dt.ToString("yyyy-MM-dd");
        public static string ToISO8601(this DateTime dt) => dt.ToString("yyyy-MM-ddThh:mmZ");

        /// <summary>
        ///     Call the API to get the json string
        /// </summary>
        /// <param name="uri">The uri to call</param>
        /// <returns>Json string</returns>
        static async Task<string> AsyncQuery(string uri)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(uri);
        }

        /// <summary>
        ///     Uses AsyncQuery to get the json string and attempt to serialise with Json.Net with the root element 'data' (the default for this api)
        /// </summary>
        /// <param name="uri">The uri to call</param>
        /// <param name="rootElement">The root element name</param>
        /// <typeparam name="T">Generic type to convert to</typeparam>
        /// <returns>A new object of type T</returns>
        internal static async Task<T> GetAsObjects<T>(string uri, string rootElement = "data")
        {
            string jsonString = await AsyncQuery(uri);
            using var document = JsonDocument.Parse(jsonString);
            JsonElement root = document.RootElement.GetProperty(rootElement);
            return JsonSerializer.Deserialize<T>(root.ToString());
        }
    }
}