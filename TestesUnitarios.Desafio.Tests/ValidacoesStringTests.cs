using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class TestesValidacoesString
    {
        private ValidacoesString _validacoes = new ValidacoesString();

        [Fact]
        public void DeveriaRetornar6ParaQuantidadeDeCaracteresDaPalavraMatrix()
        {
            // Arrange
            var texto = "Matrix";
            var resultadoEsperado = 6;

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveriaConterAPalavraQualquerNoTexto()
        {
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            // Act
            var contemTexto = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.True(contemTexto);
        }

        [Fact]
        public void NaoDeveriaConterAPalavraTesteNoTexto()
        {
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveriaTerminarComAPalavraProcurada()
        {
            // Arrange
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado";

            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            // Assert
            Assert.True(resultado);
        }
    }
}
