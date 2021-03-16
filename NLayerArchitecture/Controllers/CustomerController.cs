using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerArchitecure.Core.Abstractions.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerArchitecture.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerOperations customerOperations;
        public CustomerController(ICustomerOperations customer)
        {
            customerOperations = customer;
        }
        [HttpGet]
        public IActionResult Get31()
        {
            var res=customerOperations.GetCustomer31();
            return Ok(res);
        }
        

    }
}
