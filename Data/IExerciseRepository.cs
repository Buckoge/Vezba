using System.Collections.Generic;
using Exercise.Data.Entities;

namespace Exercise.Data
{
    public interface IExerciseRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}