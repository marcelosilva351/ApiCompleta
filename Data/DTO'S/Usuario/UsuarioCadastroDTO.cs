using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DTO_S.Usuario
{
    public class UsuarioCadastroDTO
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(40)]
        [MinLength(6)]
        public string Senha { get; set; }
        [Compare("Senha")]
        public string ComfirmacaoSenha { get; set; }
        public string Role { get; set; }
    }
}
