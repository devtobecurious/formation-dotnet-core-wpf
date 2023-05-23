using HaryPotterWpf.Win.UI.Core.Services;
using HaryPotterWpf.Win.UI.Wookiees.ListWookiees;
using HaryPotterWpf.Win.UI.Wookiees.ListWookiees.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;

namespace HaryPotterWpf.Win.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder().
                      ConfigureServices((context, services) =>
                      {
                          services.AddSingleton<MainWindow>();
                          services.AddTransient<IWindowService, ListWookieesWindowService>();
                          services.AddTransient<ListWookies>();
                      }).Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var form = AppHost.Services.GetRequiredService<MainWindow>();
            form.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
        }
    }
}