using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace struttura;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Debug.WriteLine("Clicked the button");

        if (sender is Button buttonCharacter)
        {
            DisplayInput.Text = buttonCharacter.Content?.ToString();
            DisplayInput.FontStyle = Avalonia.Media.FontStyle.Normal;
        }
    }

    protected override void OnResized(WindowResizedEventArgs e)
    {
        base.OnResized(e);

        var b = Bounds;
        if (b.Width > b.Height)
            Width = b.Height / 1.6;
    }

}
