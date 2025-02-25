using Microsoft.Extensions.DependencyInjection;
using Proc.Application.Services.Conversations.Cosmos.MessageFilters;
using System.Text.Json;
using ZooShop.Application.Enums;
using ZooShop.Application.Models;
using ZooShop.Application.Services;

namespace ZooShop.Application.Services
{
    public class AnimalService
    {
        private LiteDbCrudService _db;
        public AnimalService(IServiceProvider serviceProvider)
        {
            _db = serviceProvider.GetRequiredService<LiteDbCrudService>();
        }

        public void Add(Animal animal)
        {
            _db.Add(animal);
        }

        public void Delete(Guid id)
        {
            _db.Delete<Animal>(id);
        }

        public List<Animal> GetAll()
        {
            return _db.GetAll<Animal>();
        }

        public Animal Get(Guid id)
        {
           return _db.Get<Animal>(id);

        }

    }

}
