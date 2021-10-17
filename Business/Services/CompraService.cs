using Business.Interfaces;
using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _compraRepository;

        public CompraService(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        public async Task AdicionarCompra(Compra compra)
        {
            try
            {
                await _compraRepository.Create(compra);
            }
            catch (Exception)
            {
                throw;
            }
        }

        

        public async Task<List<CompraProduto>> ObterCompras()
        {
            var compras = await _compraRepository.ObterComprasInclude();
            if(compras == null)
            {
                return null;
            }
            return compras;
        }

        public async Task<List<Compra>> ObterComprasPorCliente(int id)
        {
            var comprasPorCliente = await _compraRepository.ComprasPorCliente(id);
            if(comprasPorCliente == null)
            {
                return null;
            }
            return comprasPorCliente;
        }
    }
