using ECommerceUI.Models;

namespace ECommerceUI.Services
{
    public class ShoppingCartService
    {
        public List<CartItem> Items { get; } = new List<CartItem>();

        public void AddToCart(Product product, int quantity = 1)
        {
            var existingItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveFromCart(Product product)
        {
            var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.Product.Price * i.Quantity);
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }
}
