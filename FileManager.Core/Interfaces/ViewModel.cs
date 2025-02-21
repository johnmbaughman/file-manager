using CommunityToolkit.Mvvm.ComponentModel;

namespace FileManager.Core.Interfaces;

public abstract class ViewModel : ObservableObject, IViewModel
{
    public abstract Task Initialized();
}