using CommunityToolkit.Labs.WinUI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml; 

namespace Omms.Client.Views;

public sealed partial class SettingsPage : Page
{
    public SettingsPage()
    {
        this.InitializeComponent();
    }

    private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var comboBox = sender as ComboBox;
        var target = (string)comboBox.SelectedValue;

        foreach (var item in PreferenceExpander.Items.Cast<SettingsCard>())
            item.Visibility = target.Equals(item.Tag) ? Visibility.Visible : Visibility.Collapsed;
    }
}
