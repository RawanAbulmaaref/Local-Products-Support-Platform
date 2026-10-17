using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Local_Products_Support_Platform.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Totalprice { get; set; }

        public DateTime Orderdate { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(10)]
        public string Orderstatus { get; set; } = string.Empty;
        [ForeignKey(nameof(BuyerId))]
        public int BuyerId { get; set; }

        public Buyer? Buyer { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
