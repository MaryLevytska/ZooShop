using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    internal class CartViewModel : ObservableObject
    {
        private IServiceProvider _serviceProvider;

        private List<CartItemViewModel> _items = new List<CartItemViewModel>();
        public List<CartItemViewModel> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged();
                OnPropertyChanged("TotalPrice");
            }
        }
        public double TotalPrice => Items.Sum(f => f.Data.TotalPrice); 
        public int TotalQuantity => Items.Sum(f => (int)f.Data.Quantity); 

        public CartViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            OrderCommand = new RelayCommand(f =>
            {
               var orderVM = serviceProvider.GetService<BuyViewModel>();
               var mainVM = serviceProvider.GetService<MainViewModel>();
                mainVM.CurrentView = orderVM;

            });
        }

        public RelayCommand OrderCommand { get; init; }

        public void AddAnimalById(Guid id)
        {
            Items.Add(new CartItemViewModel(id, _serviceProvider));
            OnPropertyChanged("TotalPrice");
        }
        public void RemoveAnimalByID(Guid id)
        {
            Items = Items.Where(f => f.Animal.Id != id).ToList();
        }
    }
}
