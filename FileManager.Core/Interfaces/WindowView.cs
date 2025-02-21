using Terminal.Gui;

namespace FileManager.Core.Interfaces;

public abstract class WindowView(IViewModel viewModel) : Window, IView
{
    public abstract void InitializeComponent();

    public IViewModel ViewModel { get; } = viewModel;
}