using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Persistence.Contexts.Configurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.QuantityInPackage).IsRequired();
            builder.Property(p => p.UnitOfMeasurement).IsRequired();

            base.Configure(builder);
        }
    }
}