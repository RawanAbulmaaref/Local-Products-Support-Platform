using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Local_Products_Support_Platform.Models
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        [MaxLength(100)]
        public string? BuyerName { get; set; }
        [MaxLength(50)]
        public string? BuyerEmail { get; set; }
        [Required]
        [MaxLength(14)]
        public string BuyerPhone { get; set; } = string.Empty;
        public ICollection<Order>? Orders { get; set; }
    }
}
