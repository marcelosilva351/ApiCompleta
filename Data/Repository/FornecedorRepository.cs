using Business.Interfaces;
using Business.Model;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ContextApiPires contextApiPires) : base(contextApiPires)
        {
        }

        

        public async Task<Fornecedor> ObterFornecedorEndereco(int id)
        {
            var fornecedorEndereco = await contextApiPires.Fornecedores.Include(e => e.Endereco).FirstOrDefaultAsync();
            return fornecedorEndereco;
        }

        public async Task<List<Fornecedor>> ObterFornecedorProdutosEndereco()
        {
            var fornecedorProdutosEndereco = await contextApiPires.Fornecedores.Include(e => e.Endereco).Include(p => p.Produtos).ToListAsync();
            return fornecedorProdutosEndereco;
        }
    }
}
