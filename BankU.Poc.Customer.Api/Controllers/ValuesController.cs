using Microsoft.AspNetCore.Mvc;

namespace BankU.Poc.Customer.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "api customer";
        }
    }
}
