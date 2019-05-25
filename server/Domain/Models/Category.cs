using System.Collections.Generic;

namespace Supermarket.API.Domain.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; }
    }
}
