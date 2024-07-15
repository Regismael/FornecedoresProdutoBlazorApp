namespace FornecedoresProdutoBlazorApp.Pages.Shared
{
    public class ProdutoToastService
    {
        public event Action<string> OnShow;
        public event Action OnHide;

        public void MostrarToast(string mensagem)
        {
            OnShow?.Invoke(mensagem);
        }

        public void FecharToast()
        {
            OnHide?.Invoke();
        }
    }
}
