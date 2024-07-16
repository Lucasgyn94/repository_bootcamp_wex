using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioUnitarios.Services
{
    public class ValidacoesString
    {
         public int RetornarQuantidadeCaractereres(string texto) {
            int quantidadeCaracteres = texto.Length;
            return quantidadeCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado) {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado) {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
  
    }
}