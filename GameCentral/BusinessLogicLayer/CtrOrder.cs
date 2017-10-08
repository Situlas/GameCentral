using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    class CtrOrder : IController<Order>
    {
        DBOrder dbOrder = new DBOrder();

        public void Create(Order entity)
        {
            dbOrder.Create(enity);
        }

        public void Delete(int id)
        {
            dbOrder.Delete(id);
        }

        public Order Get(int id)
        {
            return dbOrder.Get(id);
        }

        public List<Order> GetAll()
        {
            return dbOrder.GetAll();
        }

        public void Update(Order entity)
        {
            dbOrder.Update(entity);
        }
    }
}
