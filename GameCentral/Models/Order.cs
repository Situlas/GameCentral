using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer customer { get; set; }

        public Order(int id, Customer customer)
        {
            Id = id;
            this.customer = customer;
        }
    }
}
