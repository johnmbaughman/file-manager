using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Interfaces;
using FileManager.Core.ViewModels;

namespace FileManager.Core.Views;

public partial class MainView : WindowView, IRecipient<Message>
{
    public MainView(MainViewModel viewModel) : base(viewModel)
    {
        WeakReferenceMessenger.Default.Register(this);
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public void Receive(Message message)
    {

    }
}

public class Message
{
    public MessageType Type { get; set; }

    public object? Value { get; set; }
}

public enum MessageType {
    MainViewLoaded
}