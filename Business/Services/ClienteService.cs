using Business.Interfaces;
using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task AdicionarCliente(Cliente cliente)
        {
            try
            {
                 await _clienteRepository.Create(cliente);
            }
            catch (Exception)
            {
                throw;
            }


        }

        public async Task<Cliente> ObterCliente(int id)
        {
            var cliente = await _clienteRepository.GetById(id);
            if (cliente == null)
            {
                return null;
            }
            return cliente;
        }

        public async Task<List<Cliente>> ObterClientes()
        {
            var clientes = await _clienteRepository.Get();
            if (clientes == null)
            {
                return null;
            }
            return clientes;
        }
    }
}
