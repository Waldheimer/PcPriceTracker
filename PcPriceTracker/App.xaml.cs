using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PcPriceTracker.DB;
using System.Windows;
using PcPriceTracker.HostBuilder;
using PcPriceTracker.ViewModels;

namespace PcPriceTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        IHost host;
        private readonly IConfiguration configuration;

        public App()
        {
            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            host = Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<MainWindowViewModel>()
                });
                services.AddDbContext<AppDbContext>(opt =>
                {
                    opt.UseNpgsql(configuration.GetConnectionString("postgres"));
                });
            })
            .RegisterViews()
            .RegisterViewModels()
            .RegisterManagers()
            .RegisterServices()
            .RegisterFactoryFunctions()
            .Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            host.StartAsync();

            MainWindow = host.Services.GetRequiredService<MainWindow>();

            MainWindow.Show();



            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            host.StopAsync();
            base.OnExit(e);
        }
    }

}
