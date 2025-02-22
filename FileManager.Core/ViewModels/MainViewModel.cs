using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Interfaces;
using FileManager.Core.Models;

namespace FileManager.Core.ViewModels;

public class MainViewModel : ViewModel
{
    public override async Task Initialized()
    {
        WeakReferenceMessenger.Default.Send<Message>(new Message());
    }
}