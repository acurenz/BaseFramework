using AcurenzAppFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Service
{
    public interface ICustomerService : IDisposable
    {
        CustomerAddress Create(CustomerAddress customerAddress);
        void Delete(string id);
        CustomerAddress GetCustomerAddress(string customerAddressID);
        IEnumerable<CustomerAddress> GetAll();
        Task<IEnumerable<CustomerAddress>> GetAllAsync();
        void Update(CustomerAddress customerAddress);
        CustomerAddress Add(CustomerAddress customerAddress);
        IEnumerable<CustomerAddressType> GetAllCustomerAddressTypes();
        Customer GetCustomer(long customerNumber);

    }
}
