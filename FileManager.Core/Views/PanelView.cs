using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Interfaces;
using FileManager.Core.Models;
using FileManager.Core.ViewModels;

namespace FileManager.Core.Views;

public partial class PanelView : SubView, IRecipient<Message>
{
    public PanelView(IViewModel viewModel) : base(viewModel)
    {
        ViewModel = (PanelViewModel)base.ViewModel;
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public void Receive(Message message)
    {

    }

    public new PanelViewModel ViewModel { get; }
}