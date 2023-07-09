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
    public class OutPaymentDetailMap : IEntityTypeConfiguration<OutPaymentDetail>
    {
        public void Configure(EntityTypeBuilder<OutPaymentDetail> builder)
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
            builder.ToTable("OutPaymentDetails");
            builder.HasData(
                new OutPaymentDetail
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST desc 1 ",
                    EmployeeId = 1,
                    OutPaymentId= 1,
                    AmountPaid = 1000,
                },
                new OutPaymentDetail
                {
                    Id = 2,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST desc 1 ",
                    EmployeeId = 1,
                    OutPaymentId = 1,
                    AmountPaid = 2000,
                },
                new OutPaymentDetail
                {
                    Id = 3,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST desc 1 ",
                    EmployeeId = 1,
                    OutPaymentId = 1,
                    AmountPaid = 1500,
                },
                new OutPaymentDetail
                {
                    Id = 4,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST desc 1 ",
                    EmployeeId = 2,
                    OutPaymentId = 2,
                    AmountPaid = 2300,
                },
                new OutPaymentDetail
                {
                    Id = 5,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST desc 1 ",
                    EmployeeId = 2,
                    OutPaymentId = 2,
                    AmountPaid = 1450,
                }
            );
        }
    }
}

