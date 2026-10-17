using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Local_Products_Support_Platform.Data
{
    public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseSqlServer("server=.;Database=ProductPlatform;Trusted_Connection=True;trustservercertificate=true");
            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}