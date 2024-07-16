using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoApi.Business.Entities;

namespace CursoApi.Business.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();
        Task<Usuario> ObterUsuarioAsync(string login);
    }
}