using Terminal.Gui;

namespace FileManager.Core.Interfaces;

public abstract class SubView(IViewModel viewModel) : View, IView
{
    public abstract void InitializeComponent();

    public IViewModel ViewModel { get; } = viewModel;
}