using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vezba.Data;
using Vezba.Data.Entities;

namespace Vezba.Controllers
{
    
    public class ArtikliController : ControllerBase
    {
        private readonly ILogger<ArtikliController> _logger;
        private readonly IExerciseRepository _repository;

        public ArtikliController(IExerciseRepository repository, ILogger<ArtikliController> logger)
        {
            _repository = repository;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Artikal>> Get()
        {
             return Ok(_repository.GetAllProducts());          
            
        }
    }
}