using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using ZooShop.Core.Models;
using ZooShop.Application.Services;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    class BuyViewModel : ObservableObject
    {
        public BuyViewModel(IServiceProvider serviceProvider)
        {
            var cartVM = serviceProvider.GetRequiredService<CartViewModel>();

            CompleteOrderCommand = new RelayCommand(commandParam =>
            {
                var orderService = serviceProvider.GetRequiredService<OrderService>();
                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    Price = cartVM.TotalPrice,
                    CartItems = cartVM.Items.Select(f => f.Data).ToList(),
                    Address = Adress,
                    UserEmail = Email,
                    UserName = Name,
                };
                orderService.Add(order);
            });
        }

        private string _email;

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        private string _adress;

        public string Adress
        {
            get => _adress;
            set
            {
                if (_adress != value)
                {
                    _adress = value;
                    OnPropertyChanged(nameof(Adress));
                }
            }
        }
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public RelayCommand CompleteOrderCommand { get; set; }

    }
}
