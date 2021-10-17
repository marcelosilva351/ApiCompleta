using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Model
{
    public class CompraProduto
    {
        [Key]
        public int CompraId { get; set; }
        public Compra Compra { get; set; }
        [Key]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
