﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ProductMap:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
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
            builder.Property(a => a.Note).HasMaxLength(1000).IsRequired(false);
            builder.Property(a => a.SerialNumber).IsRequired().HasMaxLength(70);
            builder.Property(a => a.ProductName).IsRequired().HasMaxLength(70);

            builder.HasOne(e => e.ProductSubGroup)
                .WithMany(et => et.Products)
                .HasForeignKey(e => e.ProductSubGroupId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Brand)
                .WithMany(et => et.Products)
                .HasForeignKey(e => e.BrandId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.ToTable("Product");

            builder.HasData(
                new Product
                {
                    Id = 1,
                    BrandId= 1,
                    ProductSubGroupId= 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    SerialNumber = "A12BO9930HT4",
                    ProductName = "Siemens Signia Motion 1PX"
                },
                new Product
                {
                    Id = 2,
                    IsActive = true,
                    BrandId = 1,
                    ProductSubGroupId = 1,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    SerialNumber = "A12BO9930HT3",
                    ProductName = "Jabra Signia"
                },
                new Product
                {
                    Id = 3,
                    IsActive = true,
                    BrandId = 1,
                    ProductSubGroupId = 1,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    SerialNumber = "A12BO9930HT2",
                    ProductName = "Apple Signia Motion 1PX"
                },
                new Product
                {
                    Id = 4,
                    IsActive = true,
                    BrandId = 1,
                    ProductSubGroupId = 1,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    SerialNumber = "A12BO9930HT1",
                    ProductName = "Samsung Signia Motion 1PX"
                }
            );
        }
    }
}
