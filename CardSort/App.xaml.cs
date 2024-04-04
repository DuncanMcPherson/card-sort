using System.Windows;
using System.Windows.Controls;
using CardSort.services;
using Microsoft.Extensions.DependencyInjection;

namespace CardSort;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override async void OnStartup(StartupEventArgs e)
    {
        if (((App)Current).MainWindow?.Content is not Frame frame)
        {
            _serviceProvider ??= ConfigureServices();
            await _serviceProvider.GetRequiredService<IDbService>().ValidateDb();
        }
        base.OnStartup(e);
    }
}