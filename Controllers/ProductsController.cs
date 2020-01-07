using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exercise.Data;
using Exercise.Data.Entities;

namespace Exercisev.Controllers
{
    
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IExerciseRepository _repository;

        public ProductsController(IExerciseRepository repository, ILogger<ProductsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Product>> Get()
        {
            try
            {
                return Ok(_repository.GetAllProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get products: { ex }");
                return BadRequest("Failed to get products:");
            }
        }
    }
}