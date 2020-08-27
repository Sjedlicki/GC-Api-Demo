using MockAssessment7DonutApi.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Services
{
    public class HallOfFameService : IHallOfFameService
    {
        private readonly HttpClient _client;

        public HallOfFameService(HttpClient client)
        {
            _client = client;
        }

        public async Task<HallOfFame> GetAll()
        {
            var response = await _client.GetAsync($"computer-science-hall-of-fame.json");

            var jsonData = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<HallOfFame>(jsonData);

            return result;
        }
    }
}
