using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CtrProduct : IController<Product>
    {

        private DBProduct dbProduct = new DBProduct();
        public void Create(Product entity)
        {
            dbProduct.Create(entity);
        }

        public void Delete(int id)
        {
            dbProduct.Delete(id);
        }

        public Product Get(int id)
        {
            return dbProduct.Get(id);
        }

        public List<Product> GetAll()
        {
            return dbProduct.GetAll();
        }

        public void Update(Product entity)
        {
            dbProduct.Update(entity);
        }
    }
}
