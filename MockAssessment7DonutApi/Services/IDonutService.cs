using System.Collections.Generic;
using System.Threading.Tasks;
using MockAssessment7DonutApi.Models;

namespace MockAssessment7DonutApi.Services
{
    public interface IDonutService
    {
        Task<Donut> GetDonutById(int id);

        Task<IEnumerable<Donut>> GetAllDonuts();
    }
}
