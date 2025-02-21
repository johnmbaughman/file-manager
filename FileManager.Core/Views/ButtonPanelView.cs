using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Interfaces;
using FileManager.Core.Models;
using FileManager.Core.ViewModels;

namespace FileManager.Core.Views;

public partial class ButtonPanelView: SubView, IRecipient<Message>
{
    public ButtonPanelView(IViewModel viewModel) : base(viewModel)
    {
        ViewModel = (ButtonPanelViewModel)base.ViewModel;
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public void Receive(Message message)
    {

    }

    public new ButtonPanelViewModel ViewModel { get; }
}