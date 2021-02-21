using CovidApi.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidApi
{
    public class CovidSiteProcessor
    {
        public static async Task<DataModel> LoadContextData(string context = "Germany")
        {
            string url = $"https://covid-api.mmediagroup.fr/v1/cases?country={ context }";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    DataResultModel dataModel = await response.Content.ReadAsAsync<DataResultModel>();

                    return dataModel.All;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}