using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShop.Core.Models;
using ZooShop.Application.Services;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    class AnimalDetailsViewModel : ObservableObject
    {
        private AnimalService _AnimalService;

        private Animal _animal;
        public Animal Data
        {
            get { return _animal; }
            set
            {
                _animal = value;
                OnPropertyChanged();
            }
        }

        public AnimalDetailsViewModel(IServiceProvider serviceProvider)
        {
            _AnimalService = serviceProvider.GetService<AnimalService>();


        }

        public AnimalDetailsViewModel(Animal animal ,IServiceProvider serviceProvider)
        {
            _AnimalService = serviceProvider.GetService<AnimalService>();
            Data=animal;//звідки беруться ДАНІ
            DiscoveryCommand = new RelayCommand(f =>
            {
                var mainViewModel = serviceProvider.GetRequiredService<MainViewModel>();
                mainViewModel.CurrentView = this;
            });

            AddAnimalToCartById = new RelayCommand(f =>
            {
                var cartViewModel = serviceProvider.GetRequiredService<CartViewModel>();
                cartViewModel.AddAnimalById(Guid.Parse(f.ToString()));//ДОДАЄ тваринку в кошик

                var mainViewModel = serviceProvider.GetRequiredService<MainViewModel>();
                mainViewModel.CurrentView = cartViewModel;//ПЕРЕМИКАЄ між вікнами 
            });
        }

        public RelayCommand DiscoveryCommand { get; set; } //функція"КЛІКАННЯ"тобто перемикання
        public RelayCommand AddAnimalToCartById { get; set; }
    }
}