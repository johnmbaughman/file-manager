using FileManager.Core.Interfaces;
using FileManager.Core.Models;
using FileManager.Core.ViewModels;

namespace FileManager.Core.Views;

public partial class FilePanelsView<T>: SubView<T> where T : FilePanelsViewModel
{
    public FilePanelsView(T viewModel) : base(viewModel)
    {
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public override void Receive(Message message)
    {

    }
}