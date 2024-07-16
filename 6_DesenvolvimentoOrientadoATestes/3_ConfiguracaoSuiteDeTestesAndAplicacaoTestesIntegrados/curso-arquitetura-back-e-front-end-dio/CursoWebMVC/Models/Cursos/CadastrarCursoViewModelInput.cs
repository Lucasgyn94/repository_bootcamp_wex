using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace CursoWebMVC.Models.Cursos
{
    public class CadastrarCursoViewModelInput
    {
        [Required(ErrorMessage = "O nome do cursosr é obrigatório")]
        public string Nome {get; set;}

        [Required(ErrorMessage = "A descrição do cursor é obrigatória")]
        public string Descricao {get; set;}
        
    }
}