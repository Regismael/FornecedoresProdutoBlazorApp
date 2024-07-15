using FornecedoresProdutoBlazorApp.ViewModels.Fornecedor;

namespace FornecedoresProdutoBlazorApp.ViewModels.Produto
{
    public class ListarProdutosViewModel
    {
        public List<ConsultarProdutoViewModel> Produtos { get; set; } = new List<ConsultarProdutoViewModel>();
    }
}
