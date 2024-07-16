using System;
using NewTalents.Models;
using Xunit;

namespace NewTalentsTest;

public class CalcudoraTest
{
    private Calculadora calculadora;

    private Calculadora construirClasse() {
        string data = "05/11/2023";
        Calculadora calculadora = new Calculadora(data);
        return calculadora;
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 2, 4)]
    public void TesteSomar(int n1, int n2, int resultado)
    {
        calculadora = construirClasse();
        // action
        int resultadoCalculado = calculadora.Somar(n1, n2);
        // assert
        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(4, 2, 2)]
    public void TesteSubtrair(int n1, int n2, int resultado)
    {
        calculadora = construirClasse();

        // action
        int resultadoCalculado = calculadora.Subtrair(n1, n2);
        // assert
        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    public void TesteMultiplicar(int n1, int n2, int resultado)
    {
        calculadora = construirClasse();

        // action
        int resultadoCalculado = calculadora.Multiplicar(n1, n2);
        // assert
        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(4, 2, 2)]
    public void TesteDividir(int n1, int n2, int resultado)
    {
        calculadora = construirClasse();

        // action
        int resultadoCalculado = calculadora.Dividir(n1, n2);
        // assert
        Assert.Equal(resultado, resultadoCalculado);
    }

    [Fact]
    public void TesteDivizaoPorZero() {
        calculadora = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico() {
        calculadora = construirClasse();

        
        // arrange
        calculadora.Somar(2, 2);
        calculadora.Somar(4, 2);
        calculadora.Somar(3, 9);
        calculadora.Somar(4, 4);
        var qtdEsperada = 3;
        //action
        var lista = calculadora.historico();

        //assert
        Assert.NotEmpty(lista);
        Assert.Equal(qtdEsperada, lista.Count);

    }
}