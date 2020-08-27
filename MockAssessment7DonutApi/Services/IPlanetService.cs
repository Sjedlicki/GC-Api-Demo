using MockAssessment7DonutApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Services
{
    public interface IPlanetService
    {
        Task<IEnumerable<Planet>> GetAll();
    }
}
