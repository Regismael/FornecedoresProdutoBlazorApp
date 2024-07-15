using FornecedoresProdutoBlazorApp;
using FornecedoresProdutoBlazorApp.Pages.Shared;
using FornecedoresProdutoBlazorApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<FornecedorService>();
builder.Services.AddScoped<ProdutoService>();
builder.Services.AddScoped<ProdutoToastService>();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


await builder.Build().RunAsync();
