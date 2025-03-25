// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using ZooShop.Application.Services;
using ZooShop.ConsoleApp.Helpers;
using ZooShop.Data;

Console.WriteLine("Zoo Shop");
Console.WriteLine();

var db = new AnimalsContext();
foreach (var item in db.Animals.Where(f => f.Price < 551))
{
    Console.WriteLine($"{item.Id} - {item.Description}- {item.Price}");
}

//db.Animals.Add(new Animal { Price = 500, Type=4, Description="new animal", Id=Guid.Empty });
//db.SaveChanges();

var a = db.Animals.FirstOrDefault(f => f.Id == Guid.Parse("3875a9a5-f8a1-45e2-2985-08dd37151c71"));
//a.Price = a.Price + 50;
if (a != null)
{
    db.Animals.Remove(a);
    db.SaveChanges();
}

return;

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
