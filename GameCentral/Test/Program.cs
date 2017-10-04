using BusinessLogicLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            CtrProduct ctr = new CtrProduct();
            
            Product product = new Product(1, "test", 100000, "Et eller andet", 10, 0);

            ctr.Create(product);

            CtrCustomer CtrCustomer = new CtrCustomer();

            Customer customer = new Customer(1, 1321465, "Lars", "Petersen", "Aalborg", 9000, "LarsPetersen@Gmail.com", 123123, true);

            CtrCustomer.Create(customer);
        }
    }
}
