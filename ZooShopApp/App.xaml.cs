using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using System.Windows.Input;
using ZooShop.Application.Services;
using ZooShop.Data;
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
            _serviceCollection.AddTransient<AnimalDetailsViewModel>();
            _serviceCollection.AddSingleton<AnimalsViewModel>();
            _serviceCollection.AddSingleton<CartItemViewModel>();
            _serviceCollection.AddSingleton<CartViewModel>();
            _serviceCollection.AddSingleton<HomeViewModel>();
            _serviceCollection.AddSingleton<MainViewModel>();
            _serviceCollection.AddSingleton<BuyViewModel>();
            _serviceCollection.AddDbContext<AnimalsContext>();

            _serviceCollection.AddSingleton<LiteDbCrudService>();
            _serviceCollection.AddSingleton<AnimalService>();
            _serviceCollection.AddSingleton<OrderService>();

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

