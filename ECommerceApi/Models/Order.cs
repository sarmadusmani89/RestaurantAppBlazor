namespace ECommerceApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<OrderItem> Items { get; set; } = new();
        public decimal TotalAmount { get; set; }
    }
}
