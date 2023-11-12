# Testes Unitários para Projeto Console .NET

Este projeto é parte de um desafio da Digital Innovation One para a trilha .NET, onde o objetivo é implementar testes unitários para as classes de um sistema existente. O sistema possui duas classes principais, `ValidacoesLista` e `ValidacoesString`, que contêm métodos responsáveis por diversas validações envolvendo listas e strings, respectivamente.

## Estrutura do Projeto

- **Projeto Console (`Desafio.Console`):**
  - `ValidacoesLista`: Classe responsável por realizar validações envolvendo listas.
  - `ValidacoesString`: Classe responsável por realizar validações envolvendo strings.

- **Projeto de Testes (`Desafio.Testes`):**
  - `ValidacoesListaTests`: Classe de testes para a classe `ValidacoesLista`.
  - `ValidacoesStringTests`: Classe de testes para a classe `ValidacoesString`.

## Funcionalidades Testadas

### ValidacoesLista

1. **DeveRemoverNumerosNegativosDeUmaLista:**
   - Verifica se a lista resultante contém apenas números positivos.

2. **DeveConterONumero9NaLista:**
   - Verifica se um número específico está presente na lista.

3. **NaoDeveConterONumero10NaLista:**
   - Verifica se um número específico está ausente na lista.

4. **DeveMultiplicarOsElementosDaListaPor2:**
   - Verifica se a lista resultante contém elementos multiplicados corretamente.

5. **DeveRetornar9ComoMaiorNumeroDaLista:**
   - Verifica se o método retorna corretamente o maior número da lista.

6. **DeveRetornarOitoNegativoComoMenorNumeroDaList:**
   - Verifica se o método retorna corretamente o menor número da lista.

### ValidacoesString

1. **DeveRetornar6QuantidadeCaracteresDaPalavraMatrix:**
   - Verifica se o método retorna corretamente a quantidade de caracteres em uma palavra.

2. **DeveContemAPalavraQualquerNoTexto:**
   - Verifica se o método retorna corretamente se uma palavra está contida em um texto.

3. **NaoDeveConterAPalavraTesteNoTexto:**
   - Verifica se o método retorna corretamente se uma palavra não está contida em um texto.

4. **TextoDeveTerminarComAPalavraProcurado:**
   - Verifica se o método retorna corretamente se um texto termina com uma palavra específica.

## Como Executar os Testes

1. Clone o repositório.
2. Abra o projeto no Visual Studio ou no seu ambiente de desenvolvimento preferido.
3. Execute os testes unitários usando o [xUnit](https://xunit.net/).

## Observações

Certifique-se de ajustar os namespaces e referências do projeto conforme a estrutura real do seu projeto. Estes testes fornecem uma cobertura inicial para garantir a qualidade do código e rastreabilidade das funcionalidades implementadas. Contribuições são bem-vindas para expandir e melhorar a cobertura de testes.

---

**Desenvolvido por Gabriel Ferreira | Digital Innovation One - Trilha .NET**

