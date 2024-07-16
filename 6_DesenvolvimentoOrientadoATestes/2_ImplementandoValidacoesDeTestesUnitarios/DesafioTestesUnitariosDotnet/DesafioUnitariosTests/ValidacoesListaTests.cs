using System.Collections.Generic;
using DesafioUnitarios.Services;
using Xunit;

namespace DesafioUnitariosTests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> {5, -1, -8, 9};
        var resultadoEsperado = new List<int> {5, 9};

        // act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

    }

    [Fact]
    public void DeveConterONumero9NaLista() {
        // arrange
        var lista = new List<int> {5, -1, -8, 9};
        var numeroProcurado = 9;

        // act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroProcurado);

        // assert
        Assert.True(resultado);
    }
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2() {
        // ARRANGE
        var lista = new List<int> {5, 7, 8, 9};
        var resultadoEsperado = new List<int> {10, 14, 16, 18};
        // act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista() {
        // Arrange
        var lista = new List<int> {5, -1, -8, 9};
        var resultadoEsperado = 9;
        // act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // assert
        Assert.Equal(resultadoEsperado, resultado);

    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista() {
        // arrange
        var lista = new List<int> {5, -1, -8, 9};
        var resultadoEsperado = -8;
        
        // act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    
}