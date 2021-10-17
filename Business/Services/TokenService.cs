using balta1.Models;
using Business.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace balta1.Services
{
    public static class TokenService
    {
        public static string GenerateToken(Usuario User)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var secretKey = "milk23080920232ksd";
            var key = Encoding.ASCII.GetBytes(secretKey);
            var TokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[]
               {
                   new Claim(ClaimTypes.Name, User.Email.ToString()),
                   new Claim(ClaimTypes.Role, User.Role.ToString())
               }),
              Expires = DateTime.UtcNow.AddHours(2),
              SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(TokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
