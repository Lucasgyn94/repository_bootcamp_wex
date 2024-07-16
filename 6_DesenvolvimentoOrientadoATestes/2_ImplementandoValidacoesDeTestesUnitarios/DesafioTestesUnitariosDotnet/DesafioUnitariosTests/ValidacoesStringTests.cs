using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioUnitarios.Services;
using Xunit;

namespace DesafioUnitariosTests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new ValidacoesString();

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix() {
            // arrange
            var texto = "Matrix";
            var resultadoEsperado = 6;

            // act
            var resultado = _validacoes.RetornarQuantidadeCaractereres(texto);

            // assert
            Assert.Equal(resultadoEsperado, resultado); 
        }

        [Fact]
        public void DeveConterPalavraQualquerNoTexto() {
            // arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            // act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // arrange
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto() {
            // arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";

            // act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            //assert
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado() {
            // arrange
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado";
            
            // act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            // assert
            Assert.True(resultado);
        }
    }
}