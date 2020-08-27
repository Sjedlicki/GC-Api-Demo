using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7DonutApi.Services;

namespace MockAssessment7DonutApi.Controllers
{
    public class GrandCircusController : Controller
    {
        private readonly IGrandCircusService _grandCircusService;

        public GrandCircusController(IGrandCircusService grandCircusService)
        {
            _grandCircusService = grandCircusService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _grandCircusService.GetAll());
        }
    }
}
