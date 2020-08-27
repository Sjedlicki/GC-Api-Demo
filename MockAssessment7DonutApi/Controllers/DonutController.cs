using Microsoft.AspNetCore.Mvc;
using MockAssessment7DonutApi.Services;
using System.Threading.Tasks;

namespace MockAssessment7DonutApi.Controllers
{
    public class DonutController : Controller
    {
        private readonly IDonutService _donutService;

        public DonutController(IDonutService donutService)
        {
            _donutService = donutService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _donutService.GetAllDonuts());
        }

        public async Task<IActionResult> Search(int id)
        {
            return View(await _donutService.GetDonutById(id));
        }
    }
}
