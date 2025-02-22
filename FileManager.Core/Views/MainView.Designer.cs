using FileManager.Core.ViewModels;
using Terminal.Gui;

namespace FileManager.Core.Views;

public partial class MainView<T>
{
    public sealed override void InitializeComponent()
    {
        BorderStyle = LineStyle.None;

        var mainView = new FrameView()
        {
            X = 0,
            Y = 0,
            Width = Dim.Fill(),
            Height = Dim.Fill() - 1
        };
        Add(mainView);

        var titleLabel = new Label()
        {
            Title = "File Manager",
            X = -1,
            Y = -1,
            Width = Dim.Fill() + 1,
            Height = 3,
            TextAlignment = Alignment.Center,
            BorderStyle = LineStyle.Single,
            Arrangement = ViewArrangement.Overlapped
        };
        mainView.Add(titleLabel);

        mainView.Add(new FilePanelsView<FilePanelsViewModel>(new FilePanelsViewModel())
        {
            X = -1,
            Y = Pos.Bottom(titleLabel) - 1,
            Width = Dim.Fill() + 1,
            Height = Dim.Fill(mainView.Frame.Height - 1),
            Arrangement = ViewArrangement.Overlapped
        });

        Add(new ButtonPanelView<ButtonPanelViewModel>(new ButtonPanelViewModel())
        {
            Y = Pos.Bottom(mainView),
            Width = Dim.Fill(),
            Height = Dim.Auto(minimumContentDim: 3),
            Arrangement = ViewArrangement.Overlapped
        });
    }
}