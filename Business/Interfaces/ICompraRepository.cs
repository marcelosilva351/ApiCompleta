using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICompraRepository : IRepository<Compra>
    {
        Task<List<Compra>> ComprasPorCliente(int id);
        Task<List<CompraProduto>> AdicionarCompra();
        Task<List<CompraProduto>> ObterComprasInclude();

    }
}
