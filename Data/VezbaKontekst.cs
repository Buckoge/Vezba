using Vezba.Data.Entities;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace Vezba.Data
{
    public class VezbaKontekst : DbContext
    {
        public VezbaKontekst(DbContextOptions<VezbaKontekst> options) : base(options)
        {

        }

        public DbSet<Artikal> Artikli { get; set; }
        public DbSet<Račun> Računi { get; set; }

    }
}

