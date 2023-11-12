using System;
using Xunit;
using SeuNamespaceDoProjetoConsole.Services; // Substitua pelo namespace real

namespace SeuNamespaceDoProjetoTestes.Services // Substitua pelo namespace real
{
    public class ValidacoesStringTests
    {
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            var validacoesString = new ValidacoesString();
            var texto = "Matrix";

            // Act
            var resultado = validacoesString.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            // Arrange
            var validacoesString = new ValidacoesString();
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            // Act
            var resultado = validacoesString.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            // Arrange
            var validacoesString = new ValidacoesString();
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";

            // Act
            var resultado = validacoesString.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            // Arrange
            var validacoesString = new ValidacoesString();
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado";

            // Act
            var resultado = validacoesString.TextoTerminaCom(texto, textoProcurado);

            // Assert
            Assert.True(resultado);
        }
    }
}
