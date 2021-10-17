using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Model
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string TipoFornecedor { get; set; }
        public bool Ativo { get; set; }
        public Endereco Endereco { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        
    }
}
