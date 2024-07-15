namespace FornecedoresProdutoBlazorApp.ViewModels.Produto
{
    public class CadastrarProdutoViewModel
    {
        public string? NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Guid IdFornecedor { get; set; }
       public string NomeFornecedor { get; set; }
    }
}
