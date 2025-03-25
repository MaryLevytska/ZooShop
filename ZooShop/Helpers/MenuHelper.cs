using Microsoft.Extensions.DependencyInjection;
using ZooShop.Core.Models;
using ZooShop.Application.Services;

namespace ZooShop.ConsoleApp.Helpers
{
    internal class MenuHelper
    {
        public MenuHelper(IServiceProvider serviceProvider)
        {
            AnimalService = serviceProvider.GetRequiredService<AnimalService>();
        }
        AnimalService AnimalService { get; set; }
        public  void Main()
        {

            Console.WriteLine("Select category and press enter");
            Console.WriteLine("1-Mammals");
            Console.WriteLine("2-Amphibia");
            Console.WriteLine("3-Birds");
            Console.WriteLine("4-All Animals");

            Console.Write("Category: ");
            var category = Console.ReadLine();


            List<Animal> animalCollecion = AnimalService.GetAll();
            if (category == "1")
            {
                animalCollecion = animalCollecion
                    .Where(a => a is Mammals)
                    .ToList();
            }

            else if (category == "2")
            {
                animalCollecion = animalCollecion
                    .Where(a => a is Amphibia)
                    .ToList();
            }
            else if (category == "3")
            {
                animalCollecion = animalCollecion
                .Where(a => a is Birds)
                .ToList();
            }
            else if (category == "*")
            {
                SecretFunction();
            }
            Console.WriteLine($"Animals found at this time: {animalCollecion.Count}");

            AnimalHelper.DisplayAnimals(animalCollecion);

            Console.WriteLine("\r\nIf you want to view animal  press - 1 ; \r\n Go back to catalog press - 2 ");
            var operation = CommonHelper.ReadPositiveNumber();
            if (operation == 1)
            {
                Console.WriteLine($"Provide ID of the animal");
                var animalID = CommonHelper.ReadGuid();
                var animal = AnimalService.Get(animalID);
                AnimalHelper.DisplayAnimal(animal);
                AnimalHelper.RequestToBuyAnimal(animal);
            }
            else
            {
                Console.Clear();
            }


            void SecretFunction()
            {
                if (!Auth()) return;

                Console.WriteLine("Hidden menu");
                Console.WriteLine("\r\n1 - Add new animal \r\n 2 - Delete \r\n3 - Hide all");

                var secretsofazoo = CommonHelper.ReadPositiveNumber();
                if (secretsofazoo == 1)
                {
                    Console.WriteLine("\r\nNew animal");
                    var animal = AnimalHelper.ReadAnimal();
                    AnimalService.Add(animal);
                }
                else if (secretsofazoo == 2)
                {
                    Console.Write("Animal Id: ");
                    var id = CommonHelper.ReadGuid();
                    AnimalService.Delete(id);
                }

                Console.ReadKey();
                Console.Clear();
            }

            static bool Auth()
            {
                var admin = Console.ReadLine();
                if (admin != "admin")
                {
                    Console.Clear();
                    return false;

                }
                Console.Write("Password: ");

                var password = Console.ReadLine();
                if (password != "Earth")
                {
                    Console.Clear();
                    return false;

                }

                return true;
            }
        }
    }
}
