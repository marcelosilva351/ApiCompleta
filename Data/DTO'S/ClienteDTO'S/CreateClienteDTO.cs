using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DTO_S.ClienteDTO_S
{
    public class CreateClienteDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(12)]
        public string Cpf { get; set; }
    }
}
