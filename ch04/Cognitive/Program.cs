using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cognitive
{
    class Program
    {
        private static async Task<string> PostAPI(string api, string key, string region, string textToTranslate)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Post, api);

            request.Headers.Add("Ocp-Apim-Subscription-Key", key);
            request.Headers.Add("Ocp-Apim-Subscription-Region", region);

            client.Timeout = TimeSpan.FromSeconds(5);

            var body = new[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Check this content at:https://docs.microsoft.com/en-us/azure/cognitive-services/translator/reference/v3-0-reference
        /// </summary>
        static async Task Main()
        {
            var host = "https://api.cognitive.microsofttranslator.com";
            var route = "/translate?api-version=3.0&to=es";
            var subscriptionKey = "[YOUR KEY HERE]";
            var region = "[YOUR REGION HERE]";
            if (subscriptionKey == "[YOUR KEY HERE]")
            {
                Console.WriteLine("Please, enter your key: ");
                subscriptionKey = Console.ReadLine();
            }
            if (region  == "[YOUR REGION HERE]")
            {
                Console.WriteLine("Please, enter your region: ");
                region = Console.ReadLine();
            }
            var translatedSentence = await PostAPI(host + route, subscriptionKey, region, "Hello World!");
            Console.WriteLine(translatedSentence);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
