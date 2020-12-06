using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace WFAplikacija.Tools
{
    // ASP.NET project (CentralniServer) should be opened (Debug > Start Without Debugging) prior to the WF app.

    /// <summary>
    /// A raw REST request class.
    /// Not intended for direct use. Instead, make new classes
    /// which use its raw request methods (GET, POST, UPDATE, DELETE).
    /// </summary>
    public class RESTManager
    {
        /// <summary>
        /// CentralniServer's URL (set it in its properties).
        /// TODO: Make a class whi
        /// </summary>
        private static readonly string serverUrl = @"https://localhost:5001/";

        /// <summary>
        /// GET request method.
        /// </summary>
        /// <param name="url">URL of the request.</param>
        /// <param name="callbackFunction">Function that is executed after the request.</param>
        public static async void Get(string url, Action<string> callbackFunction, Action onError = null)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var obj = await client.GetStringAsync(url);
                    callbackFunction(obj);
                }
                catch
                {
                    if (onError != null)
                        onError();
                }
            }
        }

        public static async void Post(string url, dynamic obj, Action<string> callbackFunction, Action onError = null)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync(url, data);
                    string result = response.Content.ReadAsStringAsync().Result;
                    callbackFunction(result);
                }
                catch
                {
                    if (onError != null)
                        onError();
                }
            }
        }

    }
}
