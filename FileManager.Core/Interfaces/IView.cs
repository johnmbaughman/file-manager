namespace FileManager.Core.Interfaces;

public interface IView<T>
{
    void InitializeComponent();

    T ViewModel { get; }
}