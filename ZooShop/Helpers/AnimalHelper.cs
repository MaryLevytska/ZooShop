using ZooShop.Application.Enums;
using ZooShop.Application.Models;

namespace ZooShop.ConsoleApp.Helpers
{
    internal class AnimalHelper
    {

        public static void DisplayAnimals(List<Animal> animalCollecion)
        {
            foreach (var item in animalCollecion)
            {
                Console.WriteLine();
                Console.WriteLine($"Id: #{item.Id}");
                Console.WriteLine($"Breed: {item.Breed}");
                Console.WriteLine($"Age: {item.Age} "); 
                Console.WriteLine($"Height: {item.Height} ");
                Console.WriteLine($"Weight: {item.Weight} ");
                Console.WriteLine($"BloodTypes: {item.BloodTypes} ");
                Console.WriteLine($"Cover: {item.Cover}");
                Console.WriteLine($"Price: ${item.Price}");
                Console.WriteLine("-------------------------");
            }
        }
        public static void DisplayAnimal(Animal animal)
        {
            if (animal == null)
            {
                Console.WriteLine($"Animal not found. Please try again");
                return;
            }
            Console.WriteLine($"Breed: {animal.Breed}");
            Console.WriteLine($"Age: {animal.Age} ");
            Console.WriteLine($"Height: {animal.Height} ");
            Console.WriteLine($"Weight: {animal.Weight} ");
            Console.WriteLine($"BloodTypes: {animal.BloodTypes} ");
            Console.WriteLine($"Cover: {animal.Cover}");
            Console.WriteLine($"Price: ${animal.Price}");

            Console.Write($"Functions: ");
            for (int i = 0; i < animal.Functions.Length; i++)
            {
                Console.WriteLine($"{animal.Functions[i]} ");
            }
            Console.WriteLine();

            if (animal is Mammals)
            {
                Console.WriteLine($"Included with the animal:");
                var temp = ((Mammals)animal).HasAVaccination ? "yes" : "no";
                Console.WriteLine($"Vaccination: {temp}");

                temp = ((Mammals)animal).Trainable ? "yes" : "no";
                Console.WriteLine($"Trainable: {temp}");
            }
            else if (animal is Amphibia amphibia)
            {
                Console.WriteLine($"Included with the animal:");
                var temp = amphibia.HasMucus ? "yes" : "no";
                Console.WriteLine($"HasMucus : {temp}");

                temp = amphibia.HasVenom ? "yes" : "no";
                Console.WriteLine($"HasVenom: {temp}");
            }
        }

        public static void RequestToBuyAnimal(Animal animal)
        {
            if (animal == null)
            {
                Console.Clear();
                return;
            }
            Console.WriteLine($"\r\nDo you want to buy {animal.Id}?");
            Console.WriteLine("1 - To Buy \r\n2 - To go back");
            var operation = CommonHelper.ReadPositiveNumber();
            if (operation == 1)
            {
                Console.WriteLine($"Enter your email so our team will contact to you to complate the deal!");
                Console.Write("email : ");
                var email = Console.ReadLine();
                Console.WriteLine($"\r\nCondrations!!! You are the happy owner of this animal\r\n We will send you details to {email}");
                Console.WriteLine("_____________________________________________");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
            }
        }

        public static Animal ReadAnimal()
        {
            var animalCategory = CommonHelper.ReadEnumValue<CategoryAnimals>("Animal category:");

            var breed = CommonHelper.ReadEnumValue<Breed>("Breed:");

            var age = CommonHelper.ReadEnumValue<Age>("Age:");

            var height = CommonHelper.ReadPositiveNumber(500, "Height:");

            var weight = CommonHelper.ReadPositiveNumber(6000, "Weight:");

            var cover = CommonHelper.ReadEnumValue<Cover>("Cover:");

            var price = CommonHelper.ReadPositiveNumber(50000, "Price $:");

            if (animalCategory == CategoryAnimals.Mammal)
            {

                return new Mammals
                {
                    Breed = breed,
                    Age = age,
                    Height = height,
                    Weight = weight,
                    Cover = cover,
                    Trainable = CommonHelper.ReadBool("Is Trainable:"),
                    HasAVaccination = CommonHelper.ReadBool(" Has A Vaccination:"),
                    Price = price,
                };
            }

            if (animalCategory == CategoryAnimals.Amphibia)
            {

                return new Amphibia
                {
                    Breed = breed,
                    Age = age,
                    Height = height,
                    Weight = weight,
                    Cover = cover,
                    HasMucus = CommonHelper.ReadBool("Has Mucus:"),
                    HasVenom = CommonHelper.ReadBool("Has Venom:"),
                    Price = price,
                };
            }

            return new Birds
            {
                Breed = breed,
                Age = age,
                Height = height,
                Weight = weight,
                Cover = cover,
                Fly = CommonHelper.ReadBool("Fly:"),
                GoodEyesight = CommonHelper.ReadBool("Good Eyesight:"),
                Price = price,
            };
        }
    }
}
