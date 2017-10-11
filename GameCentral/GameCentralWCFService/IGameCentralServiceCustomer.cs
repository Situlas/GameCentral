using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameCentralWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGameCentralServiceCustomer
    {
        [OperationContract]
        void Create(Customer customer);
        [OperationContract]
        void Delete(int id);
        [OperationContract]
        Customer Get(int id);
        [OperationContract]
        List<Customer> GetAll();
        [OperationContract]
        void Update(Customer customer);
    }
}
