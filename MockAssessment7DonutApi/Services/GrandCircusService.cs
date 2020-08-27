using MockAssessment7DonutApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Services
{
    public class GrandCircusService : IGrandCircusService
    {
        private readonly HttpClient _client;

        public GrandCircusService(HttpClient client)
        {
            _client = client;
        }

        public async Task<GrandCircus> GetAll()
        {
            var response = await _client.GetAsync("grand-circus.json");

            var jsonData = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<GrandCircus>(jsonData);

            return result;
        }
    }
}
