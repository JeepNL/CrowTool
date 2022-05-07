using Blazored.LocalStorage;
using CrowTool.StaticBlazorWasmClient;
using CrowTool.StaticBlazorWasmClient.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Fast.Components.FluentUI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddFluentUIComponents();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddSingleton<StateContainerService>();

await builder.Build().RunAsync();
