using System.Collections.ObjectModel;
using FileManager.Core.Interfaces;
using Terminal.Gui;

namespace FileManager.Core.ViewModels;

public partial class PanelViewModel : ViewModel
{
    public override async Task Initialized()
    {
        await LoadFiles();
    }

    public ObservableCollection<string> Files { get; set; } = [];

    public string Status { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;

    public async Task LoadFiles()
    {
        string[] filesList = ["File 1", "File 2"];
        foreach (var file in filesList)
        {
            Files.Add(file);
        }
    }
}