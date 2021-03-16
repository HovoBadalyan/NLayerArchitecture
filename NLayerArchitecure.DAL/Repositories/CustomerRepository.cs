using NLayerArchitecure.Core.Abstractions.Repositories;
using NLayerArchitecure.Core.BusinessModels;
using NLayerArchitecure.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NLayerArchitecure.DAL.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(NORTHWNDContext context)
                : base(context)
        {

        }
        public IEnumerable<Customer31> GetCustomer31()
        {
            var query = (from customer in Context.Customers
                         join order in Context.Orders on customer.CustomerId equals order.CustomerId
                         where order.CustomerId==null && order.EmployeeId==4
                         select new Customer31
                         {
                             CustomerId = customer.CustomerId,
                             id = order.CustomerId
                         }).ToList();
            return query;
        }
    }
}
