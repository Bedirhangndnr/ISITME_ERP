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
    public class OutPaymentMap : IEntityTypeConfiguration<OutPayment>
    {
        public void Configure(EntityTypeBuilder<OutPayment> builder)
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
            builder.ToTable("OutPayments");
            builder.HasData(
                new OutPayment
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST desc 1 ",
                    AmountPaid = 0,
                    DebtAmount=15000,
                    DueDate = DateTime.Now.AddDays(4),
                    IsPaid = true,
                    PaidPlace="Ödemenin Yapılacağı yer",
                },
                new OutPayment
                {
                    Id = 2,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST desc 1 ",
                    AmountPaid = 0,
                    DebtAmount=10000,
                    DueDate = DateTime.Now.AddDays(4),
                    IsPaid = true,
                    PaidPlace = "Ödemenin Yapılacağı yer",
                }
                //new OutPayment
                //{
                //    Id = 3,
                //    IsActive = true,
                //    IsDeleted = false,
                //    CreatedByName = "InitialCreate",
                //    CreatedDate = DateTime.Now,
                //    ModifiedByName = "InitialCreate",
                //    ModifiedDate = DateTime.Now,
                //    Description = "TEST desc 1 ",
                //    AmountPaid = 1000,
                //    DebtAmount = 0,
                //    DueDate = DateTime.Now.AddDays(4),
                //    IsPaid = true,
                //    PaidPlace = "Ödemenin Yapılacağı yer",
                //},
                //new OutPayment
                //{
                //    Id = 4,
                //    IsActive = true,
                //    IsDeleted = false,
                //    CreatedByName = "InitialCreate",
                //    CreatedDate = DateTime.Now,
                //    ModifiedByName = "InitialCreate",
                //    ModifiedDate = DateTime.Now,
                //    Description = "TEST desc 1 ",
                //    AmountPaid = 1000,
                //    DebtAmount = 0,
                //    DueDate = DateTime.Now.AddDays(4),
                //    IsPaid = true,
                //    PaidPlace = "Ödemenin Yapılacağı yer",
                //},
                //new OutPayment
                //{
                //    Id = 5,
                //    IsActive = true,
                //    IsDeleted = false,
                //    CreatedByName = "InitialCreate",
                //    CreatedDate = DateTime.Now,
                //    ModifiedByName = "InitialCreate",
                //    ModifiedDate = DateTime.Now,
                //    Description = "TEST desc 1 ",
                //    AmountPaid = 1000,
                //    DebtAmount = 0,
                //    DueDate = DateTime.Now.AddDays(4),
                //    IsPaid = true,
                //    PaidPlace = "Ödemenin Yapılacağı yer",
                //},
                //new OutPayment
                //{
                //    Id = 6,
                //    IsActive = true,
                //    IsDeleted = false,
                //    CreatedByName = "InitialCreate",
                //    CreatedDate = DateTime.Now,
                //    ModifiedByName = "InitialCreate",
                //    ModifiedDate = DateTime.Now,
                //    Description = "TEST desc 1 ",
                //    AmountPaid = 1000,
                //    DebtAmount = 0,
                //    DueDate = DateTime.Now.AddDays(4),
                //    IsPaid = true,
                //    PaidPlace = "Ödemenin Yapılacağı yer",
                //},
                //new OutPayment
                //{
                //    Id = 7,
                //    IsActive = true,
                //    IsDeleted = false,
                //    CreatedByName = "InitialCreate",
                //    CreatedDate = DateTime.Now,
                //    ModifiedByName = "InitialCreate",
                //    ModifiedDate = DateTime.Now,
                //    Description = "TEST desc 1 ",
                //    AmountPaid = 1000,
                //    DebtAmount = 0,
                //    DueDate = DateTime.Now.AddDays(4),
                //    IsPaid = true,
                //    PaidPlace = "Ödemenin Yapılacağı yer",
                //}
            );
        }
    }
}

