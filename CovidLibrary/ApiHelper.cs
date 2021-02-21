using System;
using System.Net.Http;

namespace CovidApi
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeApiClient()
        {
            ApiClient = new HttpClient
            {
                // GET /cases?country=France
                BaseAddress = new Uri("https://covid-api.mmediagroup.fr/v1")
            };
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
