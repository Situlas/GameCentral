using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Models;
using BusinessLogicLayer;

namespace GameCentralWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GameCentralServiceCustomer : IGameCentralServiceCustomer
    {
        private CtrCustomer ctrCustomer = new CtrCustomer();
        public void Create(Customer customer)
        {
            ctrCustomer.Create(customer);
        }

        public void Delete(int id)
        {
            ctrCustomer.Delete(id);
        }

        public Customer Get(int id)
        {
            return ctrCustomer.Get(id);
        }

        public List<Customer> GetAll()
        {
            return ctrCustomer.GetAll();
        }

        public void Update(Customer customer)
        {
            ctrCustomer.Update(customer);
        }
    }
}
