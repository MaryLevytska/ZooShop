﻿using Microsoft.Extensions.DependencyInjection;
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
    class AnimalViewModel : ObservableObject
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

        public AnimalViewModel(IServiceProvider serviceProvider)
        {
            _AnimalService = serviceProvider.GetService<AnimalService>();
        }

        internal void SetAnimal(Guid id)
        {
            Data = _AnimalService.Get(id); //Зберігає дані
        }
    }
}