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
            builder.HasIndex(a => a.SerialNumber)
    .IsUnique();
            builder.Property(a => a.ProductName).IsRequired().HasMaxLength(70);
            builder.Property(a => a.IsMultiple).IsRequired();

            builder.HasOne(e => e.ProductSubGroup)
                .WithMany(et => et.Products)
                .HasForeignKey(e => e.ProductSubGroupId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Model)
                .WithMany(et => et.Products)
                .HasForeignKey(e => e.ModelId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.ToTable("Product");

            //builder.HasData(
            //    new Product
            //    {
            //        Id = 1,
            //        Price = 100,
            //        Quantity = 10,
            //        ModelId= 1,
            //        IsSold=false,
            //        ProductSubGroupId= 1,
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "Test Verisi",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "Test Verisi",
            //        ModifiedDate = DateTime.Now,
            //        Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
            //        SerialNumber = "A12BO9930HT4",
            //        ProductName = "Siemens Signia Motion 1PX",
            //        IsMultiple = false,
            //    }
            //    ,
            //    new Product
            //    {
            //        Id = 2,
            //        Quantity = 10,
            //        IsActive = true,
            //        Price = 100,
            //        IsSold = false,
            //        SubModelId = 1,
            //        ProductSubGroupId = 1,
            //        IsDeleted = false,
            //        CreatedByName = "Test Verisi",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "Test Verisi",
            //        ModifiedDate = DateTime.Now,
            //        Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
            //        SerialNumber = "A12BO9930HT3",
            //        ProductName = "Jabra Signia",
            //        IsMultiple = false
            //    }
              
            //);
        }
    }
}
