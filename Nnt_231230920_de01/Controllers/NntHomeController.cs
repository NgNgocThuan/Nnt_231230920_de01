using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nnt_231230920_de01.Models;

namespace Nnt_231230920_de01.Controllers
{
    public class NntHomeController : Controller
    {
        private readonly ILogger<NntHomeController> _logger;

        public NntHomeController(ILogger<NntHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NntIndex()
        {
            return View();
        }

        public IActionResult NntPrivacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult NntError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult NntContact()
        {
            return View();
        }
    }
}
