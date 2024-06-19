using MealDBAssignment.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace MealDBAssignment.HTTPClient
{
    public class GetHTTPResponse<T> : IHTTPClient<T>
    {
        T data;
        public async Task<T> GetResponseFromAPI(string URLString)
        {

            using (HttpClient httpClient = new HttpClient())
            {

                try
                {
                    var response = await httpClient.GetAsync(URLString);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        data = JsonConvert.DeserializeObject<T>(content);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return data;
        }

    }
}
