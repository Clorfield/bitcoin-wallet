using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BitcoinWallet_beta1._0_.Helpers
{
    public class WebAPIHelper
    {
        HttpClient client = new HttpClient();

        // setup http client
        public void Run(string apiUrl)
        {
            client.BaseAddress = new Uri(apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // send GET request
        public async Task<T> GetAsync<T>(string path)
        {
            T product = default(T);
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<T>();
            }
            return product;
        }

        // send POST request
        public async Task<Uri> PostAsync<T>(T body, string path)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                path, body);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }
    }
}
