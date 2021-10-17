using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DTO_S.EnderecoDTO
{
    public class EnderecoDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Logradouro { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string Numero { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Complemento { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Cep { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Bairro { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Estado { get; set; }
        [Required]
        
        public int FornecedorId { get; set; }
     
    }
}
