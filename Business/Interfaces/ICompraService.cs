using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICompraService
    {
        Task AdicionarCompra(Compra compra);
        Task<List<CompraProduto>> ObterCompras();
        Task<List<Compra>> ObterComprasPorCliente(int id);
    }
}
