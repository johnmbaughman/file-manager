using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Interfaces;
using FileManager.Core.Models;
using FileManager.Core.ViewModels;

namespace FileManager.Core.Views;

public partial class FilePanelsView: SubView, IRecipient<Message>
{
    public FilePanelsView(IViewModel viewModel) : base(viewModel)
    {
        ViewModel = (FilePanelsViewModel)base.ViewModel;
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public void Receive(Message message)
    {

    }

    public new FilePanelsViewModel ViewModel { get; }
}