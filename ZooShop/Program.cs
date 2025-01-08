// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Proc.Application.Services.Conversations.Cosmos.MessageFilters;
using ZooShop.Application.Services;
using ZooShop.ConsoleApp.Helpers;
using ZooShop.Data.Data;

Console.WriteLine("Zoo Shop");
Console.WriteLine();

var _serviceCollection = new ServiceCollection();

_serviceCollection.AddSingleton<AnimalService>();
_serviceCollection.AddSingleton<LiteDbCrudService>();

var _serviceProvider = _serviceCollection.BuildServiceProvider();
var menuHelper = new MenuHelper(_serviceProvider);
while (true)
{
    menuHelper.Main();
}


//var animalservice = _serviceProvider.GetRequiredService<AnimalService>();
//var seeds = AnimalSeeds.GetInitialData();
//foreach (var seed in seeds)
//{
//    animalservice.Add(seed);
//}
