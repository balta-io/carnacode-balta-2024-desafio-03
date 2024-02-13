using Blazored.LocalStorage;
using IMC.Components;
using IMC.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddSingleton<IBmiService, BmiServiceInMemory>();
builder.Services.AddTransient<IBmiService, BmiServiceLocalstorage>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage(); // Adiciona o serviço Blazored.LocalStorage

await builder.Build().RunAsync();
