using Business.Interfaces;
using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class FornecedorService : IFornecedorService
    {

        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }


        public async Task AdicionarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                await _fornecedorRepository.Create(fornecedor);
            }
            catch (Exception)
            {

                throw;
            }
               

        }

        public async Task<Fornecedor> ObterFornecedor(int id)
        {
            var fornecedor = await _fornecedorRepository.GetById(id);
            if(fornecedor == null)
            {
                return null;
            }
            return fornecedor;
        }

        public async Task<List<Fornecedor>> ObterFornecedores()
        {
            var fornecedores = await _fornecedorRepository.Get();
            if(fornecedores == null)
            {
                return null;
            }
            return fornecedores;
        }


        public async Task AtualiarFornecedor(Fornecedor fornecedorUpdate)
        {
            var fornecedor = await _fornecedorRepository.GetById(fornecedorUpdate.Id);
            if (fornecedor == null)
            {
                return;
            }
            try
            {

            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel atualizar o fornecedor");
            }
        }

        public async Task RemoverFornecedor(Fornecedor fornecedorRemove)
        {
            var fornecedor = _fornecedorRepository.GetById(fornecedorRemove.Id);
            if(fornecedor == null)
            {
                return;
            }
            try
            {
                await _fornecedorRepository.Delete(fornecedorRemove);

            }
            catch (Exception)
            {

                throw new Exception("Banco de dados falhou");
            }

        }

        public async Task<Fornecedor> ObterFornecedorEndereco(int id)
        {
            var fornecedorPorEndereco = await _fornecedorRepository.ObterFornecedorEndereco(id);
            if(fornecedorPorEndereco.Endereco == null)
            {
                return null;
            }
            return fornecedorPorEndereco;
        }

        public async Task<List<Fornecedor>> ObterFornecedoresProdutosEndereco()
        {
            var fornecedoresProdutosEndereco = await _fornecedorRepository.ObterFornecedorProdutosEndereco();
            if(fornecedoresProdutosEndereco == null)
            {
                return null;
            }
            return fornecedoresProdutosEndereco;

        }

        public async Task AdicionarEndereco(int id, Endereco enderecoADD)
        {
            var fornecedor = await _fornecedorRepository.GetById(id);
            var endereco = enderecoADD;
            fornecedor.Endereco = endereco;
            await _fornecedorRepository.Update(fornecedor);
        }
    }
}
