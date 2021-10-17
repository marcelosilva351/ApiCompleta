using System;
using System.Collections.Generic;
using System.Text;
using Business.Model;
namespace Data.DTO_S.ProdutoDTO
{
    public class ReadProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
