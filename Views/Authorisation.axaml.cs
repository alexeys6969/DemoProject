using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DemoProject.Classes;

namespace DemoProject;

public partial class Authorisation : UserControl
{
    public Authorisation()
    {
        InitializeComponent();
    }

    private void ToRegistration(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        NavigationService.NavigateTo(new Registration());
    }
}