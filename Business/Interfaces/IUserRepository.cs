using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserRepository : IRepository<Usuario>
    {

        string GerarToken(Usuario usuario);
    }
}
