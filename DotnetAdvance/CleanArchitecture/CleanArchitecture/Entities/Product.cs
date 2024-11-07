using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchitecture.Entities;

namespace CleanArchitecture.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}