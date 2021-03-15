using NLayerArchitecure.Core.Abstractions.Operations;
using NLayerArchitecure.Core.Abstractions.Repositories;
using NLayerArchitecure.Core.BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArchitecure.BLL.Operations
{
    public class CustomerOperations : ICustomerOperations
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerOperations(ICustomerRepository customer)
        {
            customerRepository = customer;
        }

        public IEnumerable<Customer31> GetCustomer31()
        {
           return customerRepository.GetCustomer31();
        }
    }
}
