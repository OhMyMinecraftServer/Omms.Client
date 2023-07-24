using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Omms.Client.Services;
using Omms.Client.Views;
using WinUIEx;

namespace Omms.Client;

public sealed partial class MainWindow : WindowEx
{
    private readonly SettingsService _settingsService = App.GetService<SettingsService>();

    public static XamlRoot XamlRoot { get; private set; }

    public MainWindow()
    {
        AppWindow.Title = "Omms.Client";
        AppWindow.TitleBar.ExtendsContentIntoTitleBar = true;
        AppWindow.TitleBar.ButtonBackgroundColor = Colors.Transparent;
        AppWindow.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        AppWindow.TitleBar.ButtonForegroundColor = App.Current.RequestedTheme == ApplicationTheme.Light
            ? Colors.Black : Colors.White;

        (MinWidth, MinHeight) = (516, 328);
        (Width, Height) = (_settingsService.AppWindowWidth, _settingsService.AppWindowHeight);

        SystemBackdrop = new MicaBackdrop();

        this.InitializeComponent();
    }

    private void Frame_Loaded(object sender, RoutedEventArgs e)
    {
        XamlRoot = contentFrame.XamlRoot;
        contentFrame.Navigate(typeof(ShellPage));
    }
}
