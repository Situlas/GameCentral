using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CtrSaleLineItem : IController<SaleLineItem>
    {
        DBSaleLineItem dbSaleLineItem = new DBSaleLineItem();

        public void Create(SaleLineItem entity)
        {
            dbSaleLineItem.Create(entity);
        }

        public void Delete(int id)
        {
            dbSaleLineItem.Delete(id);
        }

        public SaleLineItem Get(int id)
        {
            return dbSaleLineItem.Get(id);
        }

        public List<SaleLineItem> GetAll()
        {
            return dbSaleLineItem.GetAll();
        }

        public void Update(SaleLineItem entity)
        {
            dbSaleLineItem.Update(entity);
        }
    }
}
