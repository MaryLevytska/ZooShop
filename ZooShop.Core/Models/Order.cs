using ZooShop.Core.Enums;

namespace ZooShop.Core.Models
{
    public class Order
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string UserEmail { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }
        public double Price { get; set; }
        public OrderState State { get; set; } = OrderState.New;
        public PaymentState PaymentState { get; set; } = PaymentState.NotPayed;
        public Guid Id { get; set; }

        public string? UserName { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
