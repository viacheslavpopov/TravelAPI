using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient
{
    public class Program
    {
        public static void Main()
        {
            var apiCallTask = ApiHelper.ApiCall; // ("[YOUR-API-KEY-HERE]"); // Add back into end of line w/ tokenization
            var result = apiCallTask.Result;
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Console.WriteLine(jsonResponse["results"]);
        }
    }
    public class ApiHelper
    {
        public static async Task<string> ApiCall(string apiKey)
        {
            RestClient = new RestClient("https://api.nytimes.com/svc/topstories/v2");
        }
    }
}