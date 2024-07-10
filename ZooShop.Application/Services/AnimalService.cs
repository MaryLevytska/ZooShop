using System.Text.Json;
using ZooShop.Application.Enums;
using ZooShop.Application.Models;
using ZooShop.Application.Services;

namespace ZooShop.Application.Services
{
    public class AnimalService
    {
        private const string FilePath = "animals.json";

        public void Add(Animal animal)
        {
            var collection = GetAll();
            if (collection.Any())
            {
                animal.Id = collection.Max(x => x.Id);
            }
            else
            {
                animal.Id = 1;
            }
            collection.Add(animal);
            var fileContent = JsonSerializer.Serialize(collection);
            File.WriteAllText(FilePath, fileContent);
        }

        public void Delete(uint id)
        {
            var collection = GetAll();
            collection = collection.Where(f => f.Id != id).ToList();
            var fileContent = JsonSerializer.Serialize(collection);
            File.WriteAllText(FilePath, fileContent);
        }

        public List<Animal> GetAll()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }

            var fileContent = File.ReadAllText(FilePath);
            if (fileContent.Length > 2)
            {
                return JsonSerializer.Deserialize<List<Animal>>(fileContent);
            }

            return new List<Animal>();
        }

        public Animal Get(uint id)
        {
            return GetAll().FirstOrDefault(f => f.Id == id);
        }

    }

}
