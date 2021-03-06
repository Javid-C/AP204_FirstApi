using AP204_FirstAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP204_FirstAPI.Configurations.ProductConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(20).IsRequired();
            builder.Property(b => b.SoldPrice).HasColumnType("decimal(6,2)").IsRequired();
            builder.Property(b => b.CostPrice).HasColumnType("decimal(6,2)").IsRequired();
            builder.Property(b => b.DisplayStatus).HasDefaultValue(true);
        }
    }
}
