using Microsoft.EntityFrameworkCore;
using ZooShop.Core.Models;
using ZooShop.Data;

namespace ZooShop.Application.Services
{
    public class AnimalService
    {
        private AnimalsContext _animalsContext;
        public AnimalService(AnimalsContext animalsContext)
        {
            _animalsContext = animalsContext;
        }

        public void Add(Animal animal)
        {
            _animalsContext.Animals.Add(animal);
            _animalsContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _animalsContext.Animals.Where(f => f.Id == id).ExecuteDelete();
            _animalsContext.SaveChanges();
        }

        public List<Animal> GetAll()
        {
            return _animalsContext.Animals.ToList();
        }

        public Animal Get(Guid id)
        {
            return _animalsContext.Animals.FirstOrDefault(f => f.Id == id);

        }

        public void UpgradePrice(Guid id)
        {
            var animal = Get(id);
            if (animal != null)
            {
                animal.Price += 100;
                _animalsContext.SaveChanges();
            }
        }
    }
}
