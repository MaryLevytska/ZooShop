using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using ZooShop.Application.Models;
using ZooShop.Application.Services;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    class AnimalsViewModel : ObservableObject
    {
        private AnimalService _AnimalService;

        private List<Animal> _animal;
        public List<Animal> Data
        {
            get { return _animal; }
            set
            {
                _animal = value;
                OnPropertyChanged();
            }
        }

        public AnimalsViewModel(IServiceProvider serviceProvider)
        {
            _AnimalService = serviceProvider.GetService<AnimalService>();
        }

    }
}