using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vezba.Data.Entities;

namespace Vezba.Data
{
    public interface IVezbaRepository
    {
        IEnumerable<Artikal> GetAllProducts();
    }
}