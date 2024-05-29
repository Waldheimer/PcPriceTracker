﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfBoilerplate.ViewModels;

namespace WpfBoilerplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //  IHost for DependencyInjection
        IHost host;

        //  *****************************************************************************
        //  App-Constructor to Setup the DI-Host and register MainWindow and its ViewModel
        //  *****************************************************************************
        public App()
        {
            host = Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton<MainWindow>(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<MainWindowViewModel>()
                });
            }).Build();
        }

        //  *****************************************************************************
        //  Start the DI-Host, Create and Show the MainWindow when the Application starts
        //  *****************************************************************************
        protected override void OnStartup(StartupEventArgs e)
        {
            host.StartAsync();

            MainWindow = host.Services.GetRequiredService<MainWindow>();

            MainWindow.Show();

            base.OnStartup(e);
        }

        //  *****************************************************************************
        //  Stop the DI-Host when the Application closes
        //  *****************************************************************************
        protected override void OnExit(ExitEventArgs e)
        {
            host.StopAsync();
            base.OnExit(e);
        }
    }

}
