using Terminal.Gui;

namespace FileManager.Core.Views;

public partial class MainView
{
    private View mainContainer;
    private MenuBar menuBar;
    private FrameView topContainer;

    public sealed override void InitializeComponent()
    {
        menuBar = new MenuBar();
        //menuBar.Visible = false;
        menuBar.Menus = new MenuBarItem[] {
            new MenuBarItem("_File", new MenuItem[]
            {
                new MenuItem("_Quit", "", () => { Application.RequestStop(); }),
                //TODO: Fill in the remaining menu items
                new MenuItem("_Settings", "", () => {  })
            }) };
        Add(menuBar);

        View listLeft = new()
        {
            X = 0,
            Y = Pos.Bottom(menuBar),
            Width = Dim.Percent(50),
            Height = Dim.Fill(),
            Title = "List 1",
            BorderStyle = LineStyle.Rounded,
            Text = "Here's something to display"
        };

        View listRight = new()
        {
            X = Pos.Right(listLeft),
            Y = Pos.Bottom(menuBar),
            Width = Dim.Fill(),
            Height = Dim.Fill(),
            Title = "List 2",
            BorderStyle = LineStyle.Rounded
        };
        Add(listLeft);
        Add(listRight);

        //FrameView testFrame1 = new()
        //{
        //    Title = "_1 Frame",
        //    X = Pos.Absolute(0),
        //    Width = Dim.Fill(),
        //    Height = Dim.Fill()
        //};
        //FrameView testFrame2 = new()
        //{
        //    Title = "_2 Frame",
        //    X = testFrame1.X = Pos.Right(testFrame1),
        //    Width = Dim.Fill(),
        //    Height = Dim.Fill()
        //};
        //Add(testFrame1);
        //Add(testFrame2);

        //View view = new()
        //{
        //    Title = "_1 View",
        //    X = 0,
        //    Width = Dim.Fill(),
        //    Height = Dim.Fill()
        //};
        //testFrame1.Add(view);

        //topContainer = new FrameView();
        //topContainer.X = 0;
        //topContainer.Y = 1; // Offset by 1 due to the menu bar
        //topContainer.Width = Dim.Fill();
        //topContainer.Height = Dim.Fill() - 1; // Account for the menu bar
        //topContainer.Title = " File Manager-Core";
        //Add(topContainer);

        //mainContainer = new View();
        //mainContainer.X = 0;
        //mainContainer.Y = 1; // Offset by 1 due to the menu bar
        //mainContainer.Width = Dim.Fill();
        //mainContainer.Height = Dim.Fill() - 1;
    }
}