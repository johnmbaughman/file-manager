using FileManager.Core.Interfaces;
using FileManager.Core.Models;
using FileManager.Core.ViewModels;

namespace FileManager.Core.Views;

public partial class ButtonPanelView<T> : SubView<T> where T: ButtonPanelViewModel
{
    public ButtonPanelView(T viewModel) : base(viewModel)
    {
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public override void Receive(Message message)
    {

    }
}