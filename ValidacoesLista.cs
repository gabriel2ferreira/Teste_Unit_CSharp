using System;
using System.Collections.Generic;
using Xunit;
using SeuNamespaceDoProjetoConsole.Services; // Substitua pelo namespace real

namespace SeuNamespaceDoProjetoTestes.Services // Substitua pelo namespace real
{
    public class ValidacoesListaTests
    {
        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { -2, 3, -5, 7, 8 };

            // Act
            var resultado = validacoesLista.RemoverNumerosNegativos(lista);

            // Assert
            Assert.All(resultado, num => Assert.True(num > 0));
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { 4, 7, 9, 12 };

            // Act
            var resultado = validacoesLista.ListaContemDeterminadoNumero(lista, 9);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { 4, 7, 9, 12 };

            // Act
            var resultado = validacoesLista.ListaContemDeterminadoNumero(lista, 10);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { 2, 4, 6, 8 };

            // Act
            var resultado = validacoesLista.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.All(resultado, num => Assert.Equal(num * 2, num));
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { 4, 7, 9, 12 };

            // Act
            var resultado = validacoesLista.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
        {
            // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { -2, 3, -5, 8 };

            // Act
            var resultado = validacoesLista.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-5, resultado);
        }
    }
}
