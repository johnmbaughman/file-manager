namespace FileManager.Core.Interfaces;

public interface IView
{
    void InitializeComponent();

    IViewModel ViewModel { get; }
}