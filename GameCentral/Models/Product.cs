using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public int Sold { get; set; }

        public Product(int id, string name, double price, string description, int stock, int sold)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Stock = stock;
            this.Sold = sold;
        }
    }
}
