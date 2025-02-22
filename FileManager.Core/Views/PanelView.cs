using FileManager.Core.Interfaces;
using FileManager.Core.Models;
using FileManager.Core.ViewModels;
using Terminal.Gui;

namespace FileManager.Core.Views;

public partial class PanelView<T> : SubView<T> where T : PanelViewModel
{
    public PanelView(T viewModel) : base(viewModel)
    {
        InitializeComponent();
        Initialized += async (_, _) => await ViewModel.Initialized().ConfigureAwait(false);
    }

    public override void Receive(Message message)
    {
        ViewModel.Path = "Path will be here";
        ViewModel.Status = "Loaded...";
        SetPathText();
        SetStatusText();
        Application.LayoutAndDraw();
    }

    private void SetStatusText()
    {
        _statusBox.Text = ViewModel.Status;
    }

    private void SetPathText()
    {
        _pathBox.Text = ViewModel.Path;
    }
}