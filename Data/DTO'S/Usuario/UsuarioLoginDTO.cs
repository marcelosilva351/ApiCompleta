using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DTO_S.Usuario
{
    public class UsuarioLoginDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public string Role { get; set; }
    }
}
