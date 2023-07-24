using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Omms.Client.Views;

public sealed partial class ConnectDialog : ContentDialog
{
    public ConnectDialog()
    {
        this.InitializeComponent();
    }

    private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
    {
        TeachingTip.IsOpen = true;
    }
}
