using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Consts;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ProgramMap:IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
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
            builder.ToTable("Programs");

            builder.HasData(
                new Program
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.EmployeeProgramRead,
                    ModuleId = 5
                },
                new Program
                {
                    Id = 2,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name = AuthorizeDefinitionConstants.UserModuleRead,
                    ModuleId = 5
                },
                new Program
                {
                    Id = 3,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.StockModuleRead,
                    ModuleId= 7
                },
                new Program
                {
                    Id = 4,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.CustomerReferanceModuleRead,
                    ModuleId=6
                },
                new Program
                {
                    Id = 5,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.AppointmentModuleRead,
                    ModuleId=1
                },
                new Program
                {
                    Id = 6,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.NotificationModuleRead,
                    ModuleId = 1
                },
                new Program
                {
                    Id =7,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.PaymentProgramRead,
                    ModuleId=3
                },
                new Program
                {
                    Id =8,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.CustomerProgramRead,
                    ModuleId=2
                },
                new Program
                {
                    Id =9,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.BrandModuleRead,
                    ModuleId=7
                },
                new Program
                {
                    Id =10,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.SaleModuleRead,
                    ModuleId=3
                },
                new Program
                {
                    Id =11,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.ProductProgramRead,
                    ModuleId=7
                },
                new Program
                {
                    Id =12,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Name= AuthorizeDefinitionConstants.RoleModuleRead,
                    ModuleId=5
                }
            );
        }
    }
}

