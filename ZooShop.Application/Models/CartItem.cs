using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop.Application.Models
{
    public class CartItem
    {
        public uint Id { get; set; }
        public uint AnimalId { get; set; }
        public uint Quantity { get; set; }
        public double Price { get; set; }
      //  public uint RemoveCommand {  get; set; }
        public double TotalPrice => Price * Quantity;
    }
}
