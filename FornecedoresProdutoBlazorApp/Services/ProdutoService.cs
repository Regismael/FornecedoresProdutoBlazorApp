using FornecedoresProdutoBlazorApp.ViewModels.Fornecedor;
using FornecedoresProdutoBlazorApp.ViewModels.Produto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FornecedoresProdutoBlazorApp.Services
{
    public class ProdutoService
    {
        private readonly HttpClient _httpClient;

        public ProdutoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ConsultarProdutoViewModel>> BuscarProdutosAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<ConsultarProdutoViewModel>>("http://localhost:5120/api/Produtos/verificacaoTotal");
                return response ?? new List<ConsultarProdutoViewModel>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar produtos: {ex.Message}");
                return new List<ConsultarProdutoViewModel>();
            }
        }

        public async Task EditarProdutoAsync(EditarProdutoViewModel produto)
        {
            try
            {
                await _httpClient.PutAsJsonAsync("http://localhost:5120/api/Produtos/atualizar", produto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar produto: {ex.Message}");
            }
        }

        public async Task ExcluirProdutoAsync(Guid idProduto)
        {
            try
            {
                await _httpClient.PutAsync($"http://localhost:5120/api/Produtos/desativar/{idProduto}", null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir produto: {ex.Message}");
            }
        }

        public async Task<string?> BuscarNomeFornecedorAsync(Guid idFornecedor)
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"http://localhost:5120/api/Fornecedores/consultaPorId/{idFornecedor}");
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar nome do fornecedor: {ex.Message}");
                return null;
            }
        }

        public async Task CadastrarProdutoAsync(CadastrarProdutoViewModel produto)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("http://localhost:5120/api/Produtos/criar", produto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");
            }
        }

        public async Task<List<ListarFornecedoresViewModel>> BuscarFornecedoresAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<ListarFornecedoresViewModel>>("http://localhost:5120/api/Fornecedores/listar");
                return response ?? new List<ListarFornecedoresViewModel>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar fornecedores: {ex.Message}");
                return new List<ListarFornecedoresViewModel>();
            }
        }
    }
}
