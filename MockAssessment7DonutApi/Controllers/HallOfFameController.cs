using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7DonutApi.Services;

namespace MockAssessment7DonutApi.Controllers
{
    public class HallOfFameController : Controller
    {
        private readonly IHallOfFameService _hallOfFameService;

        public HallOfFameController(IHallOfFameService hallOfFameService)
        {
            _hallOfFameService = hallOfFameService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _hallOfFameService.GetAll());
        }
    }
}
