using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankU.Poc.Customer.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET api/customer
        [HttpGet]
        [Authorize(Roles = "ADMIN")]
        public string Get()
        {
            return  "Você tem acesso de cliente";
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        [Authorize(Roles = "CUSTOMER")]
        public string Get(int id)
        {
            return "Você tem acesso de administrador";
        }

    }
}
