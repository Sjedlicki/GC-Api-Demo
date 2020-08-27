using System.Threading.Tasks;
using MockAssessment7DonutApi.Models;

namespace MockAssessment7DonutApi.Services
{
    public interface IGrandCircusService
    {
        Task<GrandCircus> GetAll();
    }
}
