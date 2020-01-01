using Newtonsoft.Json;
using Stylelabs.MQA.WebApiTesting.Entities;
using System.Net.Http;

namespace Stylelabs.MQA.WebApiTesting.Tests
{
    public static class ApiResponse
    {
        public static RootObject GetResponse(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var rawResponse = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result.ToString();
                var deserializedResponse = JsonConvert.DeserializeObject<RootObject>(rawResponse);

                return deserializedResponse;
            }
        }
    }
}