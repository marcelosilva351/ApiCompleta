using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model
{
    public  class Produto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Descricao { get; set; }
        [Required]
        [MaxLength(100)]
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<CompraProduto> Compras { get; set; } = new List<CompraProduto>();
    }
}
