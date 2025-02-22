using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Models;
using Terminal.Gui;

namespace FileManager.Core.Interfaces;

public abstract class SubView<T> : View, IView<T>, IRecipient<Message> where T : ViewModel
{
    protected SubView(T viewModel)
    {
        WeakReferenceMessenger.Default.Register(this);
        ViewModel = viewModel;
    }

    public abstract void InitializeComponent();

    public T ViewModel { get; }

    public abstract void Receive(Message message);
}