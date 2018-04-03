using Microsoft.AspNetCore.Mvc;
using BankU.Poc.Account.Api.Security;

namespace BankU.Poc.Account.Api.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // POST api/values
       [HttpPost]
        public string Post(string login)
        {

            // Implementar método para login no banco com usuário e senha


            // Implementação após sucesso no login
            var token = new JwtTokenBuilder()
				.AddSecurityKey(JwtSecurityKey.Create("a-password-very-big-to-be-good"))
				.AddSubject("Alan Batista")
				.AddIssuer("banku.com")
				.AddAudience("banku.com")

                // Adicionar as permissões
                .AddClaimRole("ADMIN")
                .AddClaimRole("CUSTOMER")

                .AddExpiry(1)
				.Build();

                return token.Value;

        } 

    }
}
