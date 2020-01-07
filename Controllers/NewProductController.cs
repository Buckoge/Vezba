using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exercise.Data;
using Exercise.Data.Entities;

namespace Vezba.Controllers
{
    
    public class NewProductController : Controller
    {
        
        private readonly ExerciseContext _vk;

        public NewProductController(ExerciseContext vk)
        {
            _vk = vk;
        }
        // GET: NoviArtikal
        public ActionResult Index()
        {
            return View();
        }

        // GET: NoviArtikal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoviArtikal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product ar)
        {
            
            {
                _vk.Add(ar);
                _vk.SaveChanges();
                ViewBag.poruka = "Novi artikal " + ar.Title + " je uspešno snimljen";
                return View();
            }
        }
                
    }
}