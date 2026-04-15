using KeramikShop.API.Models.Enums;

namespace KeramikShop.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public ProductState Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public List<ProductImage> Images { get; set; } = null!;
    }
}
