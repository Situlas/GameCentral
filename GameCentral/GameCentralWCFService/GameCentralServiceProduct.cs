using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using BusinessLogicLayer;

namespace GameCentralWCFService
{
    public class GameCentralServiceProduct : IGameCentralServiceProduct
    {
        private CtrProduct ctrProduct = new CtrProduct();

        public void Create(Product product)
        {
            ctrProduct.Create(product);
        }

        public void Delete(int id)
        {
            ctrProduct.Delete(id);
        }

        public Product Get(int id)
        {
            return ctrProduct.Get(id);
        }

        public List<Product> GetAll()
        {
            return ctrProduct.GetAll();
        }

        public void Update(Product product)
        {
            ctrProduct.Update(product);
        }
    }
}
