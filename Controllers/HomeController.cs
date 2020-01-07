using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exercise.Data;
using Exercise.Models;

namespace Vezba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExerciseRepository _kontekst;

        public HomeController(ILogger<HomeController> logger, IExerciseRepository kontekst)
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
            //test 6 development
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Poruka = "samo cepaj";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string poruka)
        {
            ViewBag.Poruka = "Hvala, stigla je poruka";
            return View();
        }

        public IActionResult Product()
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
