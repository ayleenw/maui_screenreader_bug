namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ListViewPage), typeof(ListViewPage));
    }
}