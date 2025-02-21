using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using FileManager.Core.Interfaces;

namespace FileManager.Core.ViewModels;

public class PanelViewModel : ViewModel
{
    public override async Task Initialized()
    {

    }

    public ObservableCollection<string> Files {get;set;} = ["File 1", "File 2"];
}