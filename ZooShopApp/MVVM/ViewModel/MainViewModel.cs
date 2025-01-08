using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using ZooShop.Application.Enums;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public MainViewModel(IServiceProvider serviceProvider)
        {
            HomeVM = serviceProvider.GetRequiredService<HomeViewModel>();
            CurrentView = HomeVM;

            CategoryCommand = new RelayCommand(commandParam =>
            {
                var m = (Menu)uint.Parse(commandParam?.ToString());
                if(m == Menu.Cart)
                {
                    CurrentView = serviceProvider.GetRequiredService<CartViewModel>();
                }
                else
                {
                HomeVM.Category = m.ToString();
                CurrentView = HomeVM;
                }
            });
        }


        public HomeViewModel HomeVM { get; set; }
        public RelayCommand CategoryCommand { get; set; }
        public Visibility CartButtonVisibility { get; set; } = Visibility.Visible;

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();

                CartButtonVisibility= value is HomeViewModel
                    ? Visibility.Visible 
                    : Visibility.Hidden;
                OnPropertyChanged("CartButtonVisibility");
            }

        }

    }
}

