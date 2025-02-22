using Terminal.Gui;

namespace FileManager.Core.Views;

public partial class ButtonPanelView<T>
{
    public sealed override void InitializeComponent()
    {
        // TODO: Get button configuration from JSON
        string[] buttonNames = new string[]
        {
            "F1 Info",
            "F2 MkFile",
            "F3 MkDir",
            "F4 Attributes",
            "F5 Copy",
            "F6 Move",
            "F7 Search",
            "F8 Delete",
            "F9 Disks",
            "F10 Rename",
            "F11 Options"
        };

        Button lastButton = null;
        foreach (var buttonName in buttonNames)
        {
            lastButton = CreateDefaultButton(buttonName, lastButton);
            lastButton.Accepting += (s, e) =>
            {
                MessageBox.Query(string.Empty, $"Clicked {buttonName}", "_OK");
            };
            Add(lastButton);
        }
    }

    private Button CreateDefaultButton(string buttonText, Button lastButton)
    {
        return new Button()
        {
            X = lastButton is null ? 1 : Pos.Right(lastButton) + 1,
            Y = 0,
            Text = buttonText,
            ShadowStyle = ShadowStyle.None,
            NoDecorations = true
        };
    }
}