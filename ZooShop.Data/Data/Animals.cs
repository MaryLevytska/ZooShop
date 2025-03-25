using ZooShop.Core.Enums;
using ZooShop.Core.Models;

namespace ZooShop.Data.Data
{
    public static class AnimalSeeds
    {
        public static List<ZooShop.Core.Models.Animal> GetInitialData()
        {
            var cat = new Mammals
            {
                Weight = 500,
                Height = 10,
                BloodTypes = BloodTypes.WarmBlooded,
                Cover = Cover.Wool,
                Age = Age.NewBorn,
                Breed = Breed.KaoMani,
                Img = "Images/KaoMani.jpg",

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
                Breed = Breed.Husky,
                Weight = 10000,
                Height = 40,
                BloodTypes = BloodTypes.WarmBlooded,
                Cover =     Cover.Wool,
                Age = Age.GrowingUp,
                Img = "Images/Husky.jpg",

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
                Breed = Breed.Axolotl,
                Weight = 300,
                Height = 30,
                BloodTypes = BloodTypes.ColdBlooded,
                Cover = Cover.Skin,
                Age = Age.Maturity,
                Img = "Images/axo.jpg",

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
                Breed = Breed.RaykaAmericanFrog,
                Weight = 100,
                Height = 8,
                BloodTypes = BloodTypes.ColdBlooded,
                Cover = Cover.SkinWithSlime,
                Age = Age.Maturity,
                Img = "Images/frog.jpg",

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
                Breed = Breed.Eagle,
                Weight = 700,
                Height = 50,
                BloodTypes = BloodTypes.WarmBlooded,
                Cover = Cover.Feather,
                Age = Age.Maturity,
                Img = "Images/Eagle.jpg",

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

            return new List<ZooShop.Core.Models.Animal> { cat, dog, axolotl, frog, bird, };
        }
    };
}

