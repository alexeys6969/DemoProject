using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DemoProject.Classes;

namespace DemoProject;

public partial class Registration : UserControl
{
    public Registration()
    {
        InitializeComponent();
    }

    private void ToAuthorise(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        NavigationService.NavigateTo(new Authorisation());
    }
}