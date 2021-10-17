using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IClienteService
    {
        Task AdicionarCliente(Cliente cliente);
        Task<Cliente> ObterCliente(int id);
        Task<List<Cliente>> ObterClientes();
    }
}
