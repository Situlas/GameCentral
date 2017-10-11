using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GameCentralWCFService
{
    [ServiceContract]
    public interface IGameCentralServiceProduct
    {
        /// <summary>
        /// Product Operation Contracts
        /// </summary>
        [OperationContract]
        void Create(Product product);
        [OperationContract]
        void Delete(int id);
        [OperationContract]
        Product Get(int id);
        [OperationContract]
        List<Product> GetAll();
        [OperationContract]
        void Update(Product product);
    }
}
