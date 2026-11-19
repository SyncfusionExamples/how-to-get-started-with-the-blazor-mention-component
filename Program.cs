using BlazorApp__Mention;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTI2MTkzQDMyMzAyZTM0MmUzMGJtVXF6WGZNclhnakc2TnlaQnV6WkIvZmVsSzFyT1B3UGxwaGhEbXhRR2M9");

await builder.Build().RunAsync();
