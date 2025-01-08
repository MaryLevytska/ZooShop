using ZooShop.Application.Enums;

namespace ZooShop.Application.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string? UserName { get; set; }
        public string UserEmail { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }
        public double Price { get; set; }
        public OrderState State { get; set; } = OrderState.New;
        public PaymentState PaymentState { get; set; } = PaymentState.NotPayed;

        public List<CartItem> Items { get; set; } = new List<CartItem>();

    }
}
