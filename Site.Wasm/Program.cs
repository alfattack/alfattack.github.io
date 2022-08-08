using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Site.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress);


static void ConfigureServices(IServiceCollection services, string baseAddress)
{
    services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
}