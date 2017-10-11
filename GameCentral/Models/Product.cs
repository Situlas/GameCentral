using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int Sold { get; set; }

        public Product(int id, string name, double price, string description, int stock, int sold)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Stock = stock;
            Sold = sold;
        }
    }
}
