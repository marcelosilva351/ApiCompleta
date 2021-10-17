using AutoMapper;
using Business.Interfaces;
using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task AdicionarProduto(Produto produto)
        {
            if(ObterProduto(produto.Id) != null)
            {
               await _produtoRepository.Create(produto);
            }
            throw new InvalidOperationException("Produto já existe no banco de dados");
        }

        public async Task<Produto> ObterProduto(int id)
        {
            var produto = await _produtoRepository.GetById(id);
            return produto;
        }

        public async Task<List<Produto>> ObterProdutos()
        {
            return await _produtoRepository.Get();
        }

        public async Task AtualizarProduto(Produto produto)
        {
            var produtoAtualizar = _produtoRepository.GetById(produto.Id);
            if(produtoAtualizar == null)
            {
                throw new InvalidOperationException("Produto não existe no banco de dados");
            }
            await _produtoRepository.Update(produto);
        }

        public async Task RemoverProduto(Produto produto)
        {
            var produtoAtualizar = _produtoRepository.GetById(produto.Id);
            if (produtoAtualizar == null)
            {
                throw new InvalidOperationException("Produto não existe no banco de dados");
            }
            await _produtoRepository.Delete(produto);
        }

        public async Task<List<Produto>> ObterProdutosInclude()
        {
            var produtosInclude = await _produtoRepository.ObterProdutosFornecedor();
            return produtosInclude;
        }

        public async Task<Produto> ObterProdutoInclude(int id)
        {
            var produtosInclude = await _produtoRepository.ObterProdutosForcenedor(id);
            return produtosInclude;
        }

        public async Task<List<Produto>> ObterProdutosPorFornecedor(int id)
        {
            try
            {
               var produtosPorFornecedor = await _produtoRepository.ObterProdutosPorFornecedor(id);
               if(produtosPorFornecedor == null)
                {
                    return null;
                }
               return produtosPorFornecedor;
               
            
            }
            catch (Exception)
            {
                throw;
            }
        }




    }
}
