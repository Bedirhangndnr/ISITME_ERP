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
    public class PaymentMap:IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
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
            builder.ToTable("Payments");
            builder.HasOne(e => e.PaymentType)
                .WithMany(et => et.Payments)
                .HasForeignKey(e => e.PaymentTypeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Customer)
                .WithMany(et => et.Payments)
                .HasForeignKey(e => e.CustomerId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.Employee)
                .WithMany(et => et.Payments)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasData(
                new Payment
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    PaymentTypeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1,
                },
                new Payment
                {
                    Id = 2,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    PaymentTypeId = 1,
                    EmployeeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                },
                new Payment
                {
                    Id = 3,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    PaymentTypeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                },
                new Payment
                {
                    Id = 4,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    PaymentTypeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId=1
                },
                new Payment
                {
                    Id = 5,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    PaymentTypeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                },
                new Payment
                {
                    Id = 6,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    PaymentTypeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                },
                new Payment
                {
                    Id = 7,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    PaymentTypeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                }
            );
        }
    }
}

