using CommunityToolkit.Mvvm.Messaging;
using FileManager.Core.Interfaces;
using Terminal.Gui;

namespace FileManager.Core.Views;

public partial class PanelView<T>
{
    private TextField _pathBox;
    private TextField _statusBox;

    public sealed override void InitializeComponent()
    {
        _pathBox = new TextField()
        {
            ReadOnly = true,
            X = -1,
            Y = -1,
            Width = Dim.Fill() + 1,
            BorderStyle = LineStyle.Heavy,
            Arrangement = ViewArrangement.Overlapped
        };
        Add(_pathBox);
        
        _statusBox = new TextField()
        {
            ReadOnly = true,
            X =- 1,
            Y = Pos.AnchorEnd() +1 ,
            Width = Dim.Fill() + 1,
            BorderStyle = LineStyle.Heavy,
            Arrangement = ViewArrangement.Overlapped
        };
        

        // TODO: Table view for files
        var filesList = new ListView()
        {
            X = -1,
            Y = Pos.Bottom(_pathBox) - 1,
            Width = Dim.Fill() + 1,
            Height = Dim.Fill(_statusBox.Frame.Height - 1),
            BorderStyle = LineStyle.Single,
            Source = new ListWrapper<string>(ViewModel.Files),
            Arrangement = ViewArrangement.Overlapped
        };
        Add(filesList);
        Add(_statusBox);
    }
}