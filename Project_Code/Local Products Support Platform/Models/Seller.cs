using System.ComponentModel.DataAnnotations;

namespace Local_Products_Support_Platform.Models
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        [MaxLength(100)]
        public string? SellerName { get; set; } = string.Empty;
        [MaxLength(50)]
        public string? SellerEmail { get; set; }
        [Required]
        [MaxLength(14)]
        public string SellerPhone { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string SellerAddress { get; set; } = string.Empty;
        public ICollection<Product>? Products { get; set; }
    }
}
