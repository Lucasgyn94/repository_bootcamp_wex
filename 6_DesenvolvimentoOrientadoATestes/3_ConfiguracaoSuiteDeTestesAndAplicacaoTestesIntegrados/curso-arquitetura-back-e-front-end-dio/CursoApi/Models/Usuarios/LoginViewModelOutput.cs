using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoApi.Models.Usuarios
{
    public class LoginViewModelOutput
    {
        public string Token { get; set; }
        public UsuarioViewModelOutput Usuario { get; set; }
        
    }
}