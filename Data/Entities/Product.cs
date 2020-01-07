using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise.Data.Entities
{
    public class Product
    {
        
        public int Id { get; set; }        
        public string Category { get; set; }        
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}