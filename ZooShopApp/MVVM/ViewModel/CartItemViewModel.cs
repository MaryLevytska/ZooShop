using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;
using System.Windows;
using ZooShop.Application.Models;
using ZooShop.Application.Services;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    internal class CartItemViewModel : ObservableObject
    {
        private AnimalService _animalService;

        public CartItem Data { get; set; }

        public Animal Animal { get; set; }

        public CartItemViewModel(Guid animalId, IServiceProvider serviceProvider)
        {
            _animalService = serviceProvider.GetRequiredService<AnimalService>();
            var cartVM = serviceProvider.GetRequiredService<CartViewModel>();
            Animal = _animalService.Get(animalId);
            Data = new CartItem // ВИТЯГУЄ дані про тваринку в кошик з сервісу
            {
                Price = Animal.Price,
                Quantity = 1,
            };

            AddQuantityCommand = new RelayCommand(f => //ДОДАЄ кількість товару
             {
                 Data.Quantity++;
                 OnPropertyChanged("Data");
                 cartVM.OnPropertyChanged("TotalPrice");

             });

            SubstrastQuantityCommand = new RelayCommand(f => //ВІДНІМАЄ кількість товару
            {
                Data.Quantity--;
                if (Data.Quantity <= 0)
                {
                    Data.Quantity = 1;
                }
                OnPropertyChanged("Data");
                cartVM.OnPropertyChanged("TotalPrice");


            });

            RemoveCommand = new RelayCommand(f =>//ВИДАЛЯЄ тваринку з кошика
             {
                 var cartVM = serviceProvider.GetRequiredService<CartViewModel>();
                 cartVM.RemoveAnimalByID(Animal.Id);
             });


        }


        public RelayCommand AddQuantityCommand { get; set; }
        public RelayCommand SubstrastQuantityCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
    }
}
