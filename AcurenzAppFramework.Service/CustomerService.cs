using AcurenzAppFramework.Data;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWorkForService _unitOfWork;

        public CustomerService(IUnitOfWorkForService unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public CustomerAddress Create(CustomerAddress customerAddress)
        {
            customerAddress.ObjectState = ObjectState.Added;
            _unitOfWork.Repository<CustomerAddress>().Insert(customerAddress);
            return customerAddress;
        }

        public void Delete(string id)
        {
            _unitOfWork.Repository<CustomerAddress>().Delete(id);
        }

        public Customer GetCustomer(long customerNumber)
        {
            return _unitOfWork.Repository<Customer>().Query().Get().FirstOrDefault(x => x.CustomerNumber == customerNumber);
        }

        public CustomerAddress GetCustomerAddress(string customerAddressID)
        {
            return _unitOfWork.Repository<CustomerAddress>().Find(customerAddressID);            
        }

        public IEnumerable<CustomerAddress> GetAll()
        {
            return _unitOfWork.Repository<CustomerAddress>().Query().Get();
        }

        public IEnumerable<CustomerAddressType> GetAllCustomerAddressTypes()
        {
            return _unitOfWork.Repository<CustomerAddressType>().Query().Get();
        }

        public async Task<IEnumerable<CustomerAddress>> GetAllAsync()
        {
            return await _unitOfWork.Repository<CustomerAddress>().Query().GetAsync();            
        }

        public void Update(CustomerAddress customerAddress)
        {
            customerAddress.ObjectState = ObjectState.Modified;
            _unitOfWork.Repository<CustomerAddress>().Update(customerAddress);
        }

        public CustomerAddress Add(CustomerAddress customerAddress)
        {
            _unitOfWork.Repository<CustomerAddress>().Insert(customerAddress);
            return customerAddress;
        }

        public void Dispose()
        {
        }
    }
}
