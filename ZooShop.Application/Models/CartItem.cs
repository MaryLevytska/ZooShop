using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop.Application.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }

        public Guid AnimalId { get; set; }

        public Guid OrderId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
        public double TotalPrice => Price * Quantity;

        public virtual Animal Animal { get; set; } = null!;

        public virtual Order Order { get; set; } = null!;

    }
}
