﻿using AppSettingsManagement;
using AppSettingsManagement.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using Omms.Client.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace Omms.Client;

public partial class App : Application
{
    private static Window m_window;

    public static MainWindow MainWindow => m_window as MainWindow;

    public static IServiceProvider Services { get; } = ConfigureServices();

    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        m_window = new MainWindow();
        m_window.Activate();
    }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        // Settings service
        services.AddSingleton<SettingsService>();
        services.AddSingleton<ISettingsStorage, WinRTSettingsStorage>();

        return services.BuildServiceProvider();
    }

    public static T GetService<T>() => Services.GetService<T>();
}
