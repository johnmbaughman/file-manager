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
        Application.Run(Services.GetRequiredService<MainView<MainViewModel>>());
        Application.Top?.Dispose();
        Application.Shutdown();
    }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<MainView<MainViewModel>>();
        services.AddTransient<MainViewModel>();
        services.AddTransient<FilePanelsView<FilePanelsViewModel>>();
        services.AddTransient<FilePanelsViewModel>();
        //services.AddKeyedTransient<PanelView>(PanelTypes.Left);
        //services.AddKeyedTransient<PanelView>(PanelTypes.Right);
        //services.AddKeyedTransient<PanelViewModel>(PanelTypes.Left);
        //services.AddKeyedTransient<PanelViewModel>(PanelTypes.Right);
        return services.BuildServiceProvider();
    }
}