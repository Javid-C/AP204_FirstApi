using AP204_FirstAPI.Configurations.ProductConfigurations;
using AP204_FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AP204_FirstAPI.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
    }
}
