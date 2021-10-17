using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
    }
}
