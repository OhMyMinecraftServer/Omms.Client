using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls;

using NavigationViewItem = Microsoft.UI.Xaml.Controls.NavigationViewItem;
using NavigationView = Microsoft.UI.Xaml.Controls.NavigationView;
using NavigationViewItemInvokedEventArgs = Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs;
using Omms.Client.Views;

namespace Omms.Client;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        var SystemBar = CoreApplication.GetCurrentView().TitleBar;
        var applicationViewTitleBar = ApplicationView.GetForCurrentView().TitleBar;

        applicationViewTitleBar.ButtonBackgroundColor = Colors.Transparent;
        applicationViewTitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

        SystemBar.LayoutMetricsChanged += (sender, args) =>
        {
            AppTitleBar.Height = sender.Height;
            AppTitleBar.Margin = new Thickness(48, AppTitleBar.Margin.Top, sender.SystemOverlayRightInset, AppTitleBar.Margin.Bottom);
        };
        SystemBar.ExtendViewIntoTitleBar = true;

        AppTitleBar.Margin = new Thickness(48, AppTitleBar.Margin.Top, SystemBar.SystemOverlayRightInset, AppTitleBar.Margin.Bottom);
        Window.Current.SetTitleBar(AppTitleBar);

        new ConnectDialog().ShowAsync();
    }

    private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        switch (args.InvokedItem as string)
        {
            case "Dashboard":
                contentFrame.Navigate(typeof(DashboardPage));
            break;
            case "Settings":
                contentFrame.Navigate(typeof(SettingsPage));
                break;
            default:
                break;
        }
    }
}
