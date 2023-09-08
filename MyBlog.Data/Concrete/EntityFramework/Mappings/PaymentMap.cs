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
            builder.Property(p => p.AmountPaid).HasColumnType("decimal(18,4)");
            builder.HasOne(p => p.AssociatedInstitutions)
    .WithMany()
    .HasForeignKey(p => p.AssociatedInstitutionsId)
    .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PaymentType)
    .WithMany()
    .HasForeignKey(p => p.PaymentTypeId)
    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Customer)
    .WithMany()
    .HasForeignKey(p => p.CustomerId)
    .IsRequired() // Bu satırı ekleyin
    .OnDelete(DeleteBehavior.Restrict); // OnDelete(DeleteBehavior.Cascade) olarak değiştirdim

            builder.HasOne(p => p.Employee)
    .WithMany()
    .HasForeignKey(p => p.EmployeeId)
    .IsRequired() // Bu satırı ekleyin
    .OnDelete(DeleteBehavior.Restrict); // OnDelete(DeleteBehavior.Cascade) olarak değiştirdim
            builder.HasData(
                new Payment
                {
                    Id = 1,
                    IsActive = true,
                    PaymentTypeId=1,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    AssociatedInstitutionsId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1,
                },
                new Payment
                {
                    Id = 2,
                    PaymentTypeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    AssociatedInstitutionsId = 1,
                    EmployeeId = 1,
                    CustomerId = 1,
                    AmountPaid = 1,
                },
                new Payment
                {
                    Id = 3,
                    IsActive = true,
                    PaymentTypeId = 1,  
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    AssociatedInstitutionsId = 2,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                },
                new Payment
                {
                    Id = 4,
                    IsActive = true,
                    PaymentTypeId = 1,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    AssociatedInstitutionsId = 2,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId=1
                },
                new Payment
                {
                    Id = 5,
                    IsActive = true,
                    IsDeleted = false,
                    PaymentTypeId= 1,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    AssociatedInstitutionsId = 3,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                },
                new Payment
                {
                    Id = 6,
                    IsActive = true,
                    IsDeleted = false,
                    PaymentTypeId= 1,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    AssociatedInstitutionsId = 3,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                },
                new Payment
                {
                    Id = 7, 
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    PaymentTypeId = 1,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    AssociatedInstitutionsId =3,
                    CustomerId = 1,
                    AmountPaid = 1,
                    EmployeeId = 1
                }
            );
        }
    }
}

