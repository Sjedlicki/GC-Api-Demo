using MockAssessment7DonutApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly HttpClient _client;

        public PlanetService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Planet>> GetAll()
        {
            var response = await _client.GetAsync("planets.json");

            var jsonData = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<Planet>>(jsonData);

            return result;
        }
    }
}
