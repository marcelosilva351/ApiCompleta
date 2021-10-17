using Business.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DTO_S.CompraDTO_S
{
    public class CreateCompraDTO
    {
        public int Id { get; set; }
        [Required]
        public double Valor { get; set; }
        public List<CompraProduto> Produtos { get; set; } = new List<CompraProduto>();
        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
