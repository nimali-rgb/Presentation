using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleAppAssigment.Debugs;


IHost host = Host
    .CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddSingleton<IFileService, FileService>();
        services.AddSingleton<IProductService, ProductService>();

        services.AddTransient<ProductDialog>();
        services.AddTransient<MenuDialog>();
    })
    .Build();
    
var menu = host.Services.GetRequiredService<MenuDialog>();
menu.Run();