using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private CalculadoraImplementacao _calculadora;

    public CalculadoraTestes() {
        _calculadora = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15() 
    {
        // Arrange
        int n1 = 5;
        int n2 = 10;

        // Act
        int resultado = _calculadora.Somar(n1, n2);
        int resultadoEsperado = 15;

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
     [Fact]
    public void DeveSomar10com10ERetornar20() 
    {
        // Arrange
        int n1 = 10;
        int n2 = 10;

        // Act
        int resultado = _calculadora.Somar(n1, n2);
        int resultadoEsperado = 20;
        
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro() {
        // Arrange
        int numero = 4;

        // Act
        bool resultado = _calculadora.EhPar(numero);
        // Assert
        Assert.True(resultado);

    }

    // VERIFICAR VÁRIOS NÚMEROS UTILIZANDO THEORY
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerficarSeOsNumerosSaoParesEhRetornarVerdadeiro(int numero) {
        // Act
        bool resultado = _calculadora.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    // RECEBENDO LISTA COMO PARAMETRO
    [Theory]
    [InlineData(new int[] {2, 4})]
    [InlineData(new int[] {6, 8, 10})]
    public void DeveVerficarSeOsNumerosListasSaoParesEhRetornarVerdadeiro(int[] numeros) {
        // Assert
        Assert.All(numeros, numero => Assert.True(_calculadora.EhPar(numero)));
    }


}