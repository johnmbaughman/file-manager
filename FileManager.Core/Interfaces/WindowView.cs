using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Models;
using Terminal.Gui;

namespace FileManager.Core.Interfaces;

public abstract class WindowView<T> : Window, IView<T>, IRecipient<Message> where T : ViewModel
{
    protected WindowView(T viewModel)
    {
        WeakReferenceMessenger.Default.Register(this);
        ViewModel = viewModel;
    }

    public abstract void InitializeComponent();

    public T ViewModel { get; }

    public abstract void Receive(Message message);
}