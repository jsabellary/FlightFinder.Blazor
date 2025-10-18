using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FlightFinder.Blazor;
using FlightFinder.Blazor.Services;

// Top-level statements for Blazor WebAssembly in .NET 8
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Root component mounting point matches #app in wwwroot/index.html
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<Microsoft.AspNetCore.Components.Web.HeadOutlet>("head::after");
//
// Register HttpClient for DI with base address from configuration
builder.Services.AddScoped(sp => 
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var apiBaseUrl = configuration["ApiBaseUrl"] ?? builder.HostEnvironment.BaseAddress;
    return new HttpClient { BaseAddress = new Uri(apiBaseUrl) };
});

// Register services - Changed from Singleton to Scoped to match HttpClient lifetime
builder.Services.AddScoped<AppState>();

await builder.Build().RunAsync();
