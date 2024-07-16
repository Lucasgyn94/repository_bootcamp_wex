using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests() {
            _validacoes = new ValidacoesString();
        }
        
        [Fact]
        public void DeveContar3CaracteresEmOlaEretornar3() {
            // Arrange
            string texto = "Ola";
            // Act

            int resultado = _validacoes.ContarCaracteres(texto);
            int resultadoEsperado = 3;
            
            // Assert
            Assert.Equal(resultadoEsperado, resultado);

        }
    }
}