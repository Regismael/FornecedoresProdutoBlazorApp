using FornecedoresProdutoBlazorApp.ViewModels.Fornecedor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FornecedoresProdutoBlazorApp.Services
{
    public class FornecedorService
    {
        private readonly HttpClient _httpClient;

        public FornecedorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ConsultarFornecedorViewModel>> BuscarFornecedoresAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<ConsultarFornecedorViewModel>>("http://localhost:5120/api/Fornecedores/consultaTotal");
                return response ?? new List<ConsultarFornecedorViewModel>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de requisição HTTP ao buscar fornecedores: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar fornecedores: {ex.Message}");
                throw;
            }
        }

        public async Task CadastrarFornecedorAsync(CadastrarFornecedorViewModel fornecedor)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("http://localhost:5120/api/Fornecedores/cadastrar", fornecedor);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de requisição HTTP ao cadastrar fornecedor: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar fornecedor: {ex.Message}");
                throw;
            }
        }

        public async Task EditarFornecedorAsync(ConsultarFornecedorViewModel fornecedor)
        {
            var response = await _httpClient.PutAsJsonAsync($"http://localhost:5120/api/Fornecedores/editar", fornecedor);
            response.EnsureSuccessStatusCode();
        }

        public async Task ExcluirFornecedorAsync(Guid id)
        {
            var response = await _httpClient.PutAsync($"http://localhost:5120/api/Fornecedores/desativar/{id}", null);
            response.EnsureSuccessStatusCode();
        }
    }
}
