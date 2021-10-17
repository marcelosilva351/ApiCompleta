using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<Produto> ObterProdutosForcenedor(int id);
        Task<List<Produto>> ObterProdutosFornecedor();

        Task<List<Produto>> ObterProdutosPorFornecedor(int id);
    }
}
