using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ProductSubGroupMap:IEntityTypeConfiguration<ProductSubGroup>
    {
        public void Configure(EntityTypeBuilder<ProductSubGroup> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.Property(a => a.Description).HasMaxLength(500);
            builder.HasOne(e => e.ProductGroup)
                .WithMany(et => et.ProductSubGroups)
                .HasForeignKey(e => e.ProductGroupId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.ToTable("ProductSubGroups");

            builder.HasData(
                new ProductSubGroup
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "Ürün Alt Grubu Açıklaması",
                    Title = "Ürün Alt Grubu Başlığı",
                    ProductGroupId = 1,
                }
            );
        }
    }
}

