using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZooShop.Core.Models;
using ZooShop.Data;

namespace ZooShop.Application.Services
{
    public class OrderService
    {
        private AnimalsContext _animalsContext;
        public OrderService(AnimalsContext animalsContext)
        {
            _animalsContext = animalsContext;
        }

        public void Add(Order order)
        {
            _animalsContext.Orders.Add(order);
            _animalsContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _animalsContext.Orders.Where(f => f.Id == id).ExecuteDelete();
            _animalsContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _animalsContext.Orders.ToList();
        }

        public Order Get(Guid id)
        {
            return _animalsContext.Orders.FirstOrDefault(f => f.Id == id);

        }

    }

}

