using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vezba.Data;
using Vezba.Models;

namespace Vezba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVezbaRepository _kontekst;

        public HomeController(ILogger<HomeController> logger, IVezbaRepository kontekst)
        {
            _logger = logger;
            _kontekst = kontekst;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //test
            return View();
        }

        public IActionResult Kontakt()
        {
            ViewBag.Poruka = "samo cepaj";
            return View();
        }

        [HttpPost]
        public IActionResult Kontakt(string poruka)
        {
            ViewBag.Poruka = "Hvala, stigla je poruka";
            return View();
        }

        public IActionResult Artikli()
        {
            var results = _kontekst.GetAllProducts();

            return View(results);
        }
        public IActionResult Create()
        {
            // var Artikli = _kontekst.Artikli
            //   .OrderBy(a => a.Naziv)
            //   .ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
