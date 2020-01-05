using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vezba.Data.Entities
{
    public class Račun
    {
        public int Id { get; set; }
        public DateTime DatumPoručivanja { get; set; }
        public string BrojRačuna { get; set; }
        public ICollection<PoručeniArtikal> Items { get; set; }
    }
}
