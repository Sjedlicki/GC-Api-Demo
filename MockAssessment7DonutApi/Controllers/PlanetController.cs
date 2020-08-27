using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7DonutApi.Services;

namespace MockAssessment7DonutApi.Controllers
{
    public class PlanetController : Controller
    {
        private readonly IPlanetService _planetService;

        public PlanetController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _planetService.GetAll());
        }
    }
}
