using ZooShop.Application.Enums;
using ZooShop.Application.Models;

namespace ZooShop.Data.Data
{
    public static class Animals
    {

        private static List<Animal> SetupInitialData()
        {
            var cat = new Mammals
            {
                Id = 1,
                Weight = 500,
                Height = 10,
                BloodTypes = BloodTypes.WarmBlooded,
                Cover = Cover.Wool,
                Age = Age.NewBorn,
                Breed = Breed.KaoMani,

                Functions = new[]
          {
                Function.Adaptation,
                Function.Assault,
                Function.Defense,
                Function.MovementAndMusculoskeletalSystem,
                Function.Breathing,
           },
                Price = 1500
            };

            var dog = new Mammals
            {
                Id = 2,
                Breed = Breed.Husky,
                Weight = 10000,
                Height = 40,
                BloodTypes = BloodTypes.WarmBlooded,
                Cover =     Cover.Wool,
                Age = Age.GrowingUp,
                Functions = new[]
                  {
                Function.Adaptation,
                Function.Assault,
                Function.Defense,
                Function.MovementAndMusculoskeletalSystem,
                Function.Breathing,

               },
                Price = 10000,
            };

            var axolotl = new Amphibia
            {
                Id = 3,
                Breed = Breed.Axolotl,
                Weight = 300,
                Height = 30,
                BloodTypes = BloodTypes.ColdBlooded,
                Cover = Cover.Skin,
                Age = Age.Maturity,
                Functions = new[]
               {
                Function.Adaptation,
                Function.Assault,
                Function.Defense,
                Function.MovementAndMusculoskeletalSystem,
                Function.Breathing,

            },
                Price = 500,
            };
            var frog = new Amphibia
            {
                Id = 4,
                Breed = Breed.Aha,
                Weight = 100,
                Height = 8,
                BloodTypes = BloodTypes.ColdBlooded,
                Cover = Cover.SkinWithSlime,
                Age = Age.Maturity,
                Functions = new[]
               {
                Function.Adaptation,
                Function.Assault,
                Function.Defense,
                Function.MovementAndMusculoskeletalSystem,
                Function.Breathing,

            },
                Price = 1000,
            };
            var bird = new Birds
            {
                Id = 5,
                Breed = Breed.Eagle,
                Weight = 700,
                Height = 50,
                BloodTypes = BloodTypes.WarmBlooded,
                Cover = Cover.Feather,
                Age = Age.Maturity,
                Functions = new[]
                {
                Function.Adaptation,
                Function.Assault,
                Function.Defense,
                Function.MovementAndMusculoskeletalSystem,
                Function.Breathing,

                },
                Price = 100000,
            };

            return new List<Animal> { cat, dog, axolotl, frog, bird, };
        }
    };
}

