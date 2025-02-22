using FileManager.Core.Interfaces;
using FileManager.Core.Models;
using FileManager.Core.ViewModels;

namespace FileManager.Core.Views;

public partial class MainView<T> : WindowView<T> where T : MainViewModel
{
    public MainView(T viewModel) : base(viewModel)
    {
        
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public override void Receive(Message message)
    {

    }
}