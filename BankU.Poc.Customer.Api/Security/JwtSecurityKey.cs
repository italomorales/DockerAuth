using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace BankU.Poc.Customer.Api.Security
{
    public static class JwtSecurityKey
    {
        public static SymmetricSecurityKey Create(string secret)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
        }
    }
}
