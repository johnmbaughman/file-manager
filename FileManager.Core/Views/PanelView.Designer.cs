using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Interfaces;
using Terminal.Gui;

namespace FileManager.Core.Views;

public partial class PanelView 
{
    public sealed override void InitializeComponent()
    {
        var pathBox = new TextField()
        {
            Enabled = false,
            X = -1,
            Y = -1,
            Width = Dim.Fill() + 1,
            Text = "Path will be here",
            BorderStyle = LineStyle.Heavy,
            Arrangement = ViewArrangement.Overlapped
        };
        Add(pathBox);
        
        var statusBox = new TextField()
        {
            Enabled = false,
            X =- 1,
            Y = Pos.AnchorEnd() +1 ,
            Width = Dim.Fill() + 1,
            Text = "Status will be here",
            BorderStyle = LineStyle.Heavy,
            Arrangement = ViewArrangement.Overlapped
        };

        // TODO: Table view for files
        var filesList = new ListView()
        {
            X = -1,
            Y = Pos.Bottom(pathBox) - 1,
            Width = Dim.Fill() + 1,
            Height = Dim.Fill(statusBox.Frame.Height - 1),
            BorderStyle = LineStyle.Single,
            Source = new ListWrapper<string>(ViewModel.Files),
            Arrangement = ViewArrangement.Overlapped
        };
        Add(filesList);
        Add(statusBox);
    }
}