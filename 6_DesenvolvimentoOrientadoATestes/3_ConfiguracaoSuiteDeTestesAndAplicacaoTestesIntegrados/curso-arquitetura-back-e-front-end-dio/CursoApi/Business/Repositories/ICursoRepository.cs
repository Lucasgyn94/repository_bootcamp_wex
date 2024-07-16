using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoApi.Business.Entities;

namespace CursoApi.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
        void Commit();
        IList<Curso> ObterPorUsuario(int codigoUsuario);
        
    }
}