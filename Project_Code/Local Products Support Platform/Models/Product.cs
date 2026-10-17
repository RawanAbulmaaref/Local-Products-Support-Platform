using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Local_Products_Support_Platform.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [ForeignKey(nameof(SellerId))]
        public int SellerId { get; set; }
        public Seller? Seller { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
