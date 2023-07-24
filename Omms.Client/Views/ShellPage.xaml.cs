using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using Windows.Graphics;

namespace Omms.Client.Views;

public sealed partial class ShellPage : Page
{
    public ShellPage()
    {
        this.InitializeComponent();
    }

    private async void Page_Loaded(object sender, RoutedEventArgs e)
    {
        RefreshDragArea();

        await new ConnectDialog()
        {
            XamlRoot = MainWindow.XamlRoot
        }.ShowAsync();
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
            case "Terminal":
                contentFrame.Navigate(typeof(TerminalPage));
                break;
            default:
                break;
        }
    }

    private void NavigationView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        => contentFrame.GoBack();

    private void RefreshDragArea()
    {
        var scaleAdjustment = XamlRoot.RasterizationScale;
        var height = (int)(48 * scaleAdjustment);

        var leftWidth = (Column1.ActualWidth - AutoSuggestBox.ActualWidth) / 2;
        var dragRects = new List<RectInt32>
        {
            new RectInt32
            {
                X = (int)(48 * scaleAdjustment),
                Y = 0,
                Width = (int)(10 * scaleAdjustment),
                Height = height
            },

            new RectInt32
            {
                X = (int)((48 + Column0.ActualWidth - 10) * scaleAdjustment),
                Y = 0,
                Width = (int)((leftWidth + 10) * scaleAdjustment),
                Height = height
            },

            new RectInt32
            {
                X = (int)((48 + Column0.ActualWidth + Column1.ActualWidth - leftWidth) * scaleAdjustment),
                Y = 0,
                Width = (int)(leftWidth * scaleAdjustment),
                Height = height
            },

            new RectInt32
            {
                X = (int)((48 + Column0.ActualWidth + Column1.ActualWidth) * scaleAdjustment),
                Y = 0,
                Width = (int)(Column2.ActualWidth * scaleAdjustment),
                Height = height
            }
        };

        App.MainWindow.AppWindow.TitleBar.SetDragRectangles(dragRects.ToArray());
    }

    private void Page_SizeChanged(object sender, SizeChangedEventArgs e) => RefreshDragArea();
}
