namespace FornecedoresProdutoBlazorApp.ViewModels.Produto
{
    public class EditarProdutoViewModel
    {
        public Guid IdProduto { get; set; }
        public string? NomeProduto { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public bool Ativo { get; set; }
        public Guid? IdFornecedor { get; set; }

        public string? NomeFornecedor { get; set; }
    }
}
