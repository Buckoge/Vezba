using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vezba.Data;
using Vezba.Data.Entities;

namespace Vezba.Controllers
{
    
    public class NoviArtikalController : Controller
    {
        
        private readonly ExerciseContext _vk;

        public NoviArtikalController(ExerciseContext vk)
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
        public ActionResult Create(Artikal ar)
        {
            
            {
                _vk.Add(ar);
                _vk.SaveChanges();
                ViewBag.poruka = "Novi artikal " + ar.Naziv + " je uspešno snimljen";
                return View();
            }
        }
                
    }
}