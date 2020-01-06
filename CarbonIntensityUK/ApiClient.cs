using System;
using System.Net;
using System.Threading.Tasks;

namespace CarbonIntensityUK 
{
    internal static class ApiClient
    {
        static WebClient New()
        {
            var client = new WebClient();
            client.Headers.Add("", "");
            return client;
        }

        public static string ToSimpleDate(this DateTime dt) => dt.ToString("yyyy-MM-dd");
        public static string ToISO8601(this DateTime dt) => dt.ToString("yyyy-MM-ddThh:mmZ");

        public static async Task<string> AsyncQuery(string uri)
        {
            using (var client = New())
                return await client.DownloadStringTaskAsync(uri);
        }

        public static T AttemptConvert<T>(string data)
        {
            /*
             * JObject response = JObject.Parse(data);
             * return JsonConvert.DeserializeObject<T>(response["data"].ToString());
             */
            throw new NotImplementedException();
        }
    }
}