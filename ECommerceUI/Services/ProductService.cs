using ECommerceUI.Models;

namespace ECommerceUI.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 999.99m, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 2, Name = "Smartphone", Description = "Latest smartphone", Price = 699.99m, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 3, Name = "Headphones", Description = "Noise cancelling", Price = 199.99m, ImageUrl = "https://via.placeholder.com/150" }
        };
        }
    }
}
