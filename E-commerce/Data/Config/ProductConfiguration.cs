using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(180);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.StockPictureUrl).IsRequired();
            builder.HasOne(b => b.Brand).WithMany()
                .HasForeignKey(p => p.BrandId);
            builder.HasOne(b => b.Category).WithMany()
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
