using Microsoft.AspNetCore.Mvc;

namespace BankU.Poc.Account.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "api login";
        }
    }
}
