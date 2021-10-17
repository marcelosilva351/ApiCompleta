using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IFornecedorService
    {
        Task AdicionarFornecedor(Fornecedor fornecedor);
        Task<Fornecedor> ObterFornecedor(int id);
        Task<List<Fornecedor>> ObterFornecedores();
        Task AtualiarFornecedor(Fornecedor fornecedorUpdate);
        Task RemoverFornecedor(Fornecedor fornecedorRemove);
        Task<Fornecedor> ObterFornecedorEndereco(int id);
        Task<List<Fornecedor>> ObterFornecedoresProdutosEndereco();
        Task AdicionarEndereco(int id, Endereco enderecoAdd);
    }
}
