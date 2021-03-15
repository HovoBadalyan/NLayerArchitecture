using NLayerArchitecure.Core.BusinessModels;
using NLayerArchitecure.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArchitecure.Core.Abstractions.Repositories
{
    public interface ICustomerRepository:IRepositoryBase<Customer>
    {
        IEnumerable<Customer31> GetCustomer31();
    }
}
