using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Compra
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public List<CompraProduto> Produtos { get; set; } = new List<CompraProduto>();
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
