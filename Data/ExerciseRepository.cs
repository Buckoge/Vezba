using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Exercise.Data.Entities;
using Exercise.Data;

namespace Exercise.Data
{
    public class ExerciseRepository : IExerciseRepository
    {
        public readonly ExerciseContext _ctx;
        private readonly ILogger<ExerciseRepository> _logger;

        public ExerciseRepository(ExerciseContext ctx, ILogger<ExerciseRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {

                _logger.LogInformation("GetAllProducts was called");

                return _ctx.Products
                        .OrderBy(p => p.Title)
                        .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all products: {ex}");
                return null;
            }
        }


    }

   
}