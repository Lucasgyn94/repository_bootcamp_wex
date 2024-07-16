using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoWebMVC.Models.Cursos;
using Refit;

namespace CursoWebMVC.Services
{
    public interface ICursoService
    {
        [Post("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<CadastrarCursoViewModelOutput> Registrar(CadastrarCursoViewModelInput CadastrarCursoViewModelInput);

        [Get("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<IList<ListarCursoViewModelOutput>> Obter();
        
    }
}