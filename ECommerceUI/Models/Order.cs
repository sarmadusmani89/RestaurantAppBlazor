namespace ECommerceUI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public List<CartItem> Items { get; set; } = new();
    }
}
