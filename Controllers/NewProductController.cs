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
        // GET: NewItem
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewItem/Create
        public ActionResult Create()
        {

            return View();
        }               

        // POST: NewItem/Create
        [HttpPost]
        public ActionResult Create(Product it)
        {
            
            {
                _vk.Add(it);
                _vk.SaveChanges();
                ViewBag.Message = "New Item " + it.Title + " is saved successfully ";                
                return View();
            }
        }
                
    }
}