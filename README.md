# FornecedoresProdutoBlazorApp

FornecedoresProdutoBlazorApp é o projeto front-end desenvolvido em Blazor para integrar com o projeto back-end "FornecedoresProdutoApp". Este projeto permite interagir com os dados de fornecedores e produtos de forma amigável e intuitiva.

## Tecnologias Utilizadas

- .NET 8
- Blazor
- HTTP Client para chamadas API

## Configuração

### Integração com o FornecedoresProdutoApp

Este projeto está configurado para se integrar com o projeto back-end "FornecedoresProdutoApp". Certifique-se de que a API do FornecedoresProdutoApp está em execução e acessível. 

### CORS

Para garantir que as requisições do Blazor possam acessar a API, o CORS está configurado no projeto "FornecedoresProdutoApp". Não se esqueça de verificar e configurar corretamente as políticas de CORS no arquivo `Program.cs` ou `Startup.cs` do projeto back-end.

## Estrutura do Projeto

- **Pages**: Contém as páginas Razor que compõem a interface do usuário.
- **Services**: Contém os serviços para fazer chamadas HTTP à API e manipular dados.
- **Shared**: Contém componentes compartilhados entre as páginas.

## Iniciando o Projeto

1. Clone o repositório.
2. Certifique-se de que o projeto "FornecedoresProdutoApp" está em execução.
3. Configure a URL da API no serviço HTTP em `Services/ProdutoService.cs` e `Services/FornecedorService.cs`:
   ```csharp
   private readonly HttpClient _httpClient;

   public ProdutoService(HttpClient httpClient)
   {
       _httpClient = httpClient;
       _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
   }
