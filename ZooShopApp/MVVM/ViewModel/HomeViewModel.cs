using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShopApp.Core;

namespace ZooShopApp.MVVM.ViewModel
{
    class HomeViewModel : ObservableObject
    {
        public HomeViewModel(IServiceProvider serviceProvider)
        {
            DiscoveryCommand = new RelayCommand(f =>
            {
                var animalsViewModel = serviceProvider.GetRequiredService<AnimalsViewModel>();

                var mainViewModel = serviceProvider.GetRequiredService<MainViewModel>();
                mainViewModel.CurrentView = animalsViewModel;
            });
        }

        private string _category = "Home";

        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand DiscoveryCommand { get; set; }
    }
}
