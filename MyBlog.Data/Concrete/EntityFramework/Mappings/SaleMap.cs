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
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
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
            // SaleType ile ilişki
            builder.HasOne(s => s.SaleType)
                   .WithMany(st => st.Sales)
                   .HasForeignKey(s => s.SaleTypeId)
                   .OnDelete(DeleteBehavior.SetNull)
                   .IsRequired(false); // Bu satırı ekleyin
            ;

            // SaleStatus ile ilişki
            builder.HasOne(s => s.SaleStatus)
                   .WithMany(ss => ss.Sales)
                   .HasForeignKey(s => s.SaleStatusId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Customer ile ilişki
            builder.HasOne(s => s.Customer)
                   .WithMany(c => c.Sales)
                   .HasForeignKey(s => s.CustomerId);

            // Product ile ilişki
            builder.HasOne(s => s.Product)
                   .WithOne(p => p.Sale)
                   .HasForeignKey<Sale>(s => s.ProductId)
                   .OnDelete(DeleteBehavior.SetNull)
                   .IsRequired(false); // Bu satırı ekleyin

            // Employee ile ilişki
            builder.HasOne(s => s.Employee)
                   .WithMany(e => e.Sales)
                   .HasForeignKey(s => s.EmployeeId)
                   .OnDelete(DeleteBehavior.SetNull);
            builder.ToTable("Sales");

            //builder.HasData(
            //    new Sale
            //    {
            //        Id = 1,
            //        IsActive = true,
            //        IsDeleted = false,
            //        AmountOfSgk = 10,
            //        CreatedByName = "Test Verisi",
            //        IsInvoiceDue = false,
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "Test Verisi",
            //        ModifiedDate = DateTime.Now,
            //        Amount = 500,
            //        SaleTypeId = 1,
            //        SaleStatusId = 1,
            //        CustomerId = 1,
            //        ProductId = 1,
            //        EmployeeId = 1,
            //    }
            //    //, new Sale
            //    //{
            //    //    Id = 2,
            //    //    ProductId = 2,
            //    //    IsActive = true,
            //    //    AmountOfSgk = 10,
            //    //    IsDeleted = false,
            //    //    CreatedByName = "Test Verisi",
            //    //    IsInvoiceDue = false,
            //    //    CreatedDate = DateTime.Now,
            //    //    ModifiedByName = "Test Verisi",
            //    //    ModifiedDate = DateTime.Now,
            //    //    Amount = 200,
            //    //    SaleTypeId = 1,
            //    //    SaleStatusId = 1,
            //    //    CustomerId = 1,
            //    //    EmployeeId = 2,
            //    //}, new Sale
            //    //{
            //    //    Id = 3,
            //    //    ProductId = 3,
            //    //    IsActive = true,
            //    //    IsInvoiceDue = false,
            //    //    AmountOfSgk = 10,
            //    //    IsDeleted = false,
            //    //    CreatedByName = "Test Verisi",
            //    //    CreatedDate = DateTime.Now,
            //    //    ModifiedByName = "Test Verisi",
            //    //    ModifiedDate = DateTime.Now,
            //    //    Amount = 500,
            //    //    SaleTypeId = 1,
            //    //    SaleStatusId = 1,
            //    //    CustomerId = 1,
            //    //    EmployeeId = 2,
            //    //}
            //);
        }
    }
}

