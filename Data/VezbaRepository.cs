using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vezba.Data.Entities;

namespace Vezba.Data
{
    public class VezbaRepository : IVezbaRepository
    {
        public readonly VezbaKontekst _vk;
        private readonly ILogger<VezbaRepository> _logger;

        public VezbaRepository(VezbaKontekst vk, ILogger<VezbaRepository> logger)
        {
            _vk = vk;
            _logger = logger;
        }

        public IEnumerable<Artikal> GetAllProducts()
        {
            try
            {

                _logger.LogInformation("GetAllProducts was called");

                return _vk.Artikli
                        .OrderBy(p => p.Naziv)
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