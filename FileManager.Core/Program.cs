using FileManager.Core.ViewModels;
using FileManager.Core.Views;
using Microsoft.Extensions.DependencyInjection;
using Terminal.Gui;

namespace FileManager.Core;

public static class Program
{
    public static IServiceProvider? Services { get; private set; }


    private static void Main(string[] args)
    {
        Services = ConfigureServices();
        Application.Init();
        Application.Run(Services.GetRequiredService<MainView>());
        Application.Top?.Dispose();
        Application.Shutdown();
    }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<MainView>();
        services.AddTransient<MainViewModel>();
        return services.BuildServiceProvider();
    }
}