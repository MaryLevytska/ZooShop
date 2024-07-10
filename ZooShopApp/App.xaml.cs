using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using ZooShopApp.MVVM.ViewModel;

namespace ZooShopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            var _serviceCollection = new ServiceCollection();
            _serviceCollection.AddSingleton<MainViewModel>();
            _serviceCollection.AddSingleton<HomeViewModel>();
            _serviceCollection.AddSingleton<AnimalViewModel>();
            _serviceCollection.AddSingleton<AnimalsViewModel>();

            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWin = new MainWindow();
            mainWin.DataContext = _serviceProvider.GetRequiredService<MainViewModel>();
            mainWin.Show();

            base.OnStartup(e);
        }
    }
}

