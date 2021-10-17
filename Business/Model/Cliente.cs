using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<Compra> Compras { get; set; } = new List<Compra>();
    }
}
