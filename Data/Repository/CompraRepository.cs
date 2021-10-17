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
    public class CompraRepository : Repository<Compra>, ICompraRepository
    {
        public CompraRepository(ContextApiPires contextApiPires) : base(contextApiPires)
        {
        }

       

        public async Task<List<Compra>> ComprasPorCliente(int id)
        {
            var comprasPorCliente = await contextApiPires.Compras.Include(c => c.Cliente).Where(c => c.ClienteId == id).ToListAsync();
            if(comprasPorCliente == null)
            {
                return null;
            }
            return comprasPorCliente;
        }

        public async Task<List<CompraProduto>> ObterComprasInclude()
        {
            var comprasInclude = await contextApiPires.CompraProdutos.Include(c => c.Compra).Include(c => c.Produto).ToListAsync();
            if (comprasInclude == null)
            {
                return null;
            }
            return comprasInclude;
        
        }
    }
}
