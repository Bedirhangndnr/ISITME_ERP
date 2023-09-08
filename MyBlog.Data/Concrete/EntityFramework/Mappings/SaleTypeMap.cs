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
    public class SaleTypeMap:IEntityTypeConfiguration<SaleType>
    {
        public void Configure(EntityTypeBuilder<SaleType> builder)
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
            builder.ToTable("SaleTypes");

            builder.HasData(
                new SaleType
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    Title = "Nakit",
                },
                new SaleType
                {
                    Id = 2,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    Title = "Kart",
                },
                new SaleType
                {
                    Id = 3,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    Title = "Çek",
                },
                new SaleType
                {
                    Id = 4,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    Title = "Senet",
                }
            );
        }
    }
}

