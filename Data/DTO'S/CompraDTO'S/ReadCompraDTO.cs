using Business.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DTO_S.CompraDTO_S
{
    public class ReadCompraDTO
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public List<CompraProduto> Produtos { get; set; } = new List<CompraProduto>();
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
