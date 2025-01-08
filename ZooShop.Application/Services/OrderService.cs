using Microsoft.Extensions.DependencyInjection;
using Proc.Application.Services.Conversations.Cosmos.MessageFilters;
using ZooShop.Application.Models;

namespace ZooShop.Application.Services
{
    public class OrderService
    {
        private LiteDbCrudService _db;
        public OrderService(IServiceProvider serviceProvider)
        {
            _db = serviceProvider.GetRequiredService<LiteDbCrudService>();
        }

        public void Add(Order order)
        {
            _db.Add(order);
        }

        public void Delete(Guid id)
        {
            _db.Delete<Order>(id);
        }

        public List<Order> GetAll()
        {
            return _db.GetAll<Order>();
        }

        public Order Get(Guid id)
        {
            return _db.Get<Order>(id);

        }

    }

}

