using Business.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DTO_S.FornecedorDTO
{
    public class CreateFornecedorDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(14)]

        public string Documento { get; set; }
        public string TipoFornecedor { get; set; }
        public bool Ativo { get; set; }
        public Endereco Endereco { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
