using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CtrCustomer : IController<Customer>
    {
        private DBCustomer dbCustomer = new DBCustomer();

        public void Create(Customer entity)
        {
            dbCustomer.Create(entity);
        }

        public void Delete(int id)
        {
            dbCustomer.Delete(id);
        }

        public Customer Get(int id)
        {
            return dbCustomer.Get(id);
        }

        public List<Customer> GetAll()
        {
            return dbCustomer.GetAll();
        }

        public void Update(Customer entity)
        {
            dbCustomer.Update(entity);
        }
    }
}
