using Vezba.Data.Entities;

namespace Vezba.Data.Entities
{
    public class PoručeniArtikal

    {
        public int Id { get; set; }
        public Artikal Artikal { get; set; }
        public int Količina { get; set; }
        public decimal Cena { get; set; }
        public Račun Račun { get; set; }
    }
}