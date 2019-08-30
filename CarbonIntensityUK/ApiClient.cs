using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CarbonIntensityUK
{
    /// <summary>
    ///     Represents the API service, used to get raw JSON strings
    /// </summary>
    public static class ApiClient
    {
        /// <summary>
        ///     Gets a configured WebClient object, user agent Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)
        /// </summary>
        /// <returns>System.Net.WebClient</returns>
        static WebClient NewClient()
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            return client;
        }

        /// <summary>
        ///     Format DateTime object into ISO 8601 short date string
        /// </summary>
        /// <param name="dt">System.DateTime</param>
        /// <returns>yyyy-MM-dd string</returns>
        public static string FormatDate(DateTime dt) => dt.ToString("yyyy-MM-dd");

        /// <summary>
        ///     Format DateTime object to ISO 8601 datetime string
        /// </summary>
        /// <param name="dt">System.DateTime</param>
        /// <returns>yyyy-MM-ddThh:mmZ string</returns>
        public static string FormatDateTime(DateTime dt) => dt.ToString("yyyy-MM-ddThh:mmZ");


        /// <summary>
        ///     Download the json string from the api, asynchronously
        /// </summary>
        /// <param name="uri">The api URL</param>
        /// <returns>Json string</returns>
        public static async Task<string> QueryAsync(string uri)
        {
            using (var client = NewClient())
            {
                return await client.DownloadStringTaskAsync(uri);
            }
        }

        /// <summary> 
        ///     Converts json string to a dynamic object, not really used
        /// </summary>
        /// <param name="data">Json from the api</param>
        /// <returns>Dynamic object</returns>
        public static dynamic JsonToDynamic(string data)
        {
            JObject response = JObject.Parse(data);
            return JsonConvert.DeserializeObject<dynamic>(response["data"].ToString());
        }

        /// <summary>
        ///     Attempts to convert json into a proper object, must have the root element data
        /// </summary>
        /// <typeparam name="T">A reponse type. E.g. IntensityResponse</typeparam>
        /// <param name="data">Json string from the api</param>
        /// <returns>A response object of type T</returns>
        public static T AttemptConvert<T>(string data)
        {
            JObject response = JObject.Parse(data);
            return JsonConvert.DeserializeObject<T>(response["data"].ToString());
        }
    }
}
