using Microsoft.EntityFrameworkCore;
using Local_Products_Support_Platform.Models; 

namespace Local_Products_Support_Platform.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Seller>().HasData(
                new Seller
                {
                    SellerId= 1,
                    SellerName = "Rawan Abulmaaref",
                    SellerEmail = "rawan.abulmaaref@gmail.com",
                    SellerPhone = "01156959836",
                    SellerAddress = "Luxor,Armant"
                });

            builder.Entity<Buyer>().HasData(
                new Buyer
                {
                    BuyerId = 1,
                    BuyerName = "Rawan",
                    BuyerEmail = "rawan.99@gmail.com",
                    BuyerPhone = "01198765432"
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Handmade Palm Basket",
                    Price = 150.00m,
                    SellerId = 1
                });

            builder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    Orderdate = new DateTime(2026, 10, 18),
                    Orderstatus = "Pending",
                    Totalprice = 300.00m,
                    BuyerId  = 1
                });

            builder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    OrderItemId = 1,
                    OrderId = 1,
                    Quantity = 2,
                    UnitPrice = 150.00m,
                    ProductId = 1
                });
        }

    }

   
}
