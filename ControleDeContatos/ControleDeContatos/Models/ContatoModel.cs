using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe seu nome")]
        [StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
        public string Nome { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Informe o Email")]
        [EmailAddress(ErrorMessage ="O e-mail informado não é válido")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Informe o Telefone")]
        [Phone(ErrorMessage ="Telefone inválido")]
        public string Telefone { get; set; }

        //[Required(ErrorMessage = "Informe o nome da mãe ou n/d")]
        public string? NomeMae { get; set; }
    }
}
