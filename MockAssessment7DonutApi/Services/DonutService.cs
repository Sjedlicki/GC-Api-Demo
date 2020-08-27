using MockAssessment7DonutApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace MockAssessment7DonutApi.Services
{
    public class DonutService : IDonutService
    {
        private readonly HttpClient _client;

        public DonutService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Donut> GetDonutById(int id)
        {
            var response = await _client.GetAsync($"donuts/{id}.json");

            //var jsonData = await response.Content.ReadAsStringAsync();

            //var result = JsonConvert.DeserializeObject<Donut>(jsonData);

            // NUGET Package: Microsoft.AspNet.WebApi.Client
            var result = await response.Content.ReadAsAsync<Donut>();

            return result;
        }

        public async Task<IEnumerable<Donut>> GetAllDonuts()
        {
            var response = await _client.GetFromJsonAsync<DonutResponse>($"donuts.json");

            //var response = await _client.GetAsync($"donuts.json");

            //var jsonData = await response.Content.ReadAsStringAsync();

            //var result = JsonConvert.DeserializeObject<Donuts>(jsonData);

            return response.Results;
        }
    }
}
