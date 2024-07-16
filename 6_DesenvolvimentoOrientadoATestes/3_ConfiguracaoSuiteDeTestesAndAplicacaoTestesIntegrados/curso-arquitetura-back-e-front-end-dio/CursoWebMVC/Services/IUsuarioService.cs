using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoWebMVC.Models.Usuarios;
using Refit;

namespace CursoWebMVC.Services
{
    public interface IUsuarioService
    {
         [Post("/api/v1/usuario/registrar")]
        Task<RegistrarUsuarioViewModelInput> Registrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput);

        [Post("/api/v1/usuario/logar")]
        Task<LoginViewModelOutput> Logar(LoginViewModelInput loginViewModelInput);
        
    }
}