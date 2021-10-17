using Business.Interfaces;
using Business.Model;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ContextApiPires contextApiPires) : base(contextApiPires)
        {
        }

        public async Task<Produto> ObterProdutosForcenedor(int id)
        {
            var produtoIncludeFornecedor = await contextApiPires.produtos.Include(f => f.Fornecedor).FirstOrDefaultAsync(p => p.Id == id);
            return produtoIncludeFornecedor;
        }

        public async Task<List<Produto>> ObterProdutosFornecedor()
        {
            var produtosIncludeForncedor = await contextApiPires.produtos.Include(f => f.Fornecedor).ToListAsync();
            return produtosIncludeForncedor;
        }

        public async Task<List<Produto>> ObterProdutosPorFornecedor(int id)
        {
            var fornecedor = await contextApiPires.Fornecedores.FindAsync(id);
            if(fornecedor == null)
            {
                throw new Exception("Fornedor não existe no banco de dados");
            }
            var produtosDoFornecedor = await contextApiPires.produtos.Include(f => f.Fornecedor).Where(f => f.Id == id).ToListAsync();
            
            return produtosDoFornecedor;
        }
    }
}
