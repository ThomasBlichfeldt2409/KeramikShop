using KeramikShop.API.Models.Enums;

namespace KeramikShop.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public OrderState Status { get; set; }
        public decimal TotalPrice { get; set; }

        public string FirstName { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string StreetName { get; set; } = null!;
        public string City { get; set; } = null!;
        public int PostalCode { get; set; }
        public int Phone { get; set; }
        public List<OrderItem> Items { get; set; } = null!;
    }
}
