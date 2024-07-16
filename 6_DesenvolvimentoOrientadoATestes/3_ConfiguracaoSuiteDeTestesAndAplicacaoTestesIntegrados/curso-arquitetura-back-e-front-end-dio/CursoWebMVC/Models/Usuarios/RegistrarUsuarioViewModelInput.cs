using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebMVC.Models.Usuarios
{
    public class RegistrarUsuarioViewModelInput
    {
        [Required(ErrorMessage = "O login é obrigatório")]
        public string login {get; set; }

        [Required(ErrorMessage = "O e-email é obrigatório")]
        [EmailAddress(ErrorMessage = "O e-mail é inválido")]
        public string Email {get; set;}

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha {get; set;}
    }
}