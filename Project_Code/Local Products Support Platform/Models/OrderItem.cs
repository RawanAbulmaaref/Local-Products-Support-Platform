using System.ComponentModel.DataAnnotations.Schema;

namespace Local_Products_Support_Platform.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(OrderId))]
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
