using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using ZooShop.Application.Models;
using ZooShop.Application.Services;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    class AnimalsViewModel : ObservableObject
    {
        private AnimalService _AnimalService;

        private List<AnimalDetailsViewModel> _animals;
        public List<AnimalDetailsViewModel> Data
        {
            get { return _animals; }
            set
            {
                _animals = value;
                OnPropertyChanged();
            }
        }

        public AnimalsViewModel(IServiceProvider serviceProvider)
        {
            _AnimalService = serviceProvider.GetRequiredService<AnimalService>();
            Data = _AnimalService.GetAll()
                .Select(f=>new AnimalDetailsViewModel(f, serviceProvider))
                .ToList(); //ВИТЯГУЄ з сервісу список тварин

        }
    }
}