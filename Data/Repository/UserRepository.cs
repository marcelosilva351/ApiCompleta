using balta1.Services;
using Business.Interfaces;
using Business.Model;
using Data.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    class UserRepository : Repository<Usuario>, IUserRepository
    {
        
        public UserRepository(ContextApiPires contextApiPires, UserManager<IdentityUser> usuario) : base(contextApiPires)
        {
        }

        public string Login(Usuario usuario)
        {
            var User = contextApiPires.Usuario.Where(u => u.Email == usuario.Email && u.Senha == u.Senha);
            if (User == null)
            {
                return null;
            }

            var token = TokenService.GenerateToken(usuario);
            return token;
           
        }

       
    }
}
