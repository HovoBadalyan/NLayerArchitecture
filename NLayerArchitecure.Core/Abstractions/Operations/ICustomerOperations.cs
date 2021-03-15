using NLayerArchitecure.Core.BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArchitecure.Core.Abstractions.Operations
{
    public interface ICustomerOperations
    {
        IEnumerable<Customer31> GetCustomer31();
    }
}
