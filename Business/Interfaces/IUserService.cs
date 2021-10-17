using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserService
    {
        Task CadastrarUsuario(Usuario usuario);
        string Login(Usuario usuario);

    }
}
