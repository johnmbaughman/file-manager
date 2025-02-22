using FileManager.Core.ViewModels;
using Terminal.Gui;

namespace FileManager.Core.Views;

public partial class FilePanelsView<T>
{
    public override void InitializeComponent()
    {
        var leftPanel = new PanelView<PanelViewModel>(new PanelViewModel())
        {
            X = 0,
            Y = 0,
            Width = Dim.Percent(50),
            Height = Dim.Fill(),
            Arrangement = ViewArrangement.Overlapped,
            BorderStyle = LineStyle.Single
        };
        Add(leftPanel);

        var rightPanel = new PanelView<PanelViewModel>(new PanelViewModel())
        {
            X = Pos.Right(leftPanel) - 1,
            Y = 0,
            Width = Dim.Fill(Frame.Width) + 1,
            Height = Dim.Fill(),
            Arrangement = ViewArrangement.Overlapped,
            BorderStyle = LineStyle.Single,
            Text = "Test"
        };
        Add(rightPanel);
    }
}