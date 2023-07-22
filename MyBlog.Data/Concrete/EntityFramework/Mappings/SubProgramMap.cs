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
    public class SubProgramMap:IEntityTypeConfiguration<SubProgram>
    {
        public void Configure(EntityTypeBuilder<SubProgram> builder)
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
            builder.ToTable("SubPrograms");

            builder.HasData(
                new SubProgram
                {
                    Id = 10,
                    Name = AuthorizeDefinitionConstants.UserCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 2
                },
                new SubProgram
                {
                    Id = 11,
                    Name = AuthorizeDefinitionConstants.UserRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 2
                },
                new SubProgram
                {
                    Id = 12,
                    Name = AuthorizeDefinitionConstants.UserUpdate,
 
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId= 2
                },
                new SubProgram
                {
                    Id = 13,
                    Name = AuthorizeDefinitionConstants.UserDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=2
                },
                new SubProgram
                {
                    Id = 14,
                    Name = AuthorizeDefinitionConstants.RoleRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=2
                },
                new SubProgram
                {
                    Id = 15,
                    Name = AuthorizeDefinitionConstants.RoleUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=2
                },
                new SubProgram
                {
                    Id = 16,
                    Name = AuthorizeDefinitionConstants.RoleDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=2
                },
                new SubProgram
                {
                    Id = 17,
                    Name = AuthorizeDefinitionConstants.RoleCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 2
                },
                new SubProgram
                {
                    Id = 37,
                    Name = AuthorizeDefinitionConstants.PaymentCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 38,
                    Name = AuthorizeDefinitionConstants.PaymentRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 39,
                    Name = AuthorizeDefinitionConstants.PaymentUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 40,
                    Name = AuthorizeDefinitionConstants.PaymentDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 41,
                    Name = AuthorizeDefinitionConstants.PaymentTypeCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 42,
                    Name = AuthorizeDefinitionConstants.PaymentTypeRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 43,
                    Name = AuthorizeDefinitionConstants.PaymentTypeUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 44,
                    Name = AuthorizeDefinitionConstants.PaymentTypeDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 45,
                    Name = AuthorizeDefinitionConstants.EmployeeCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 46,
                    Name = AuthorizeDefinitionConstants.EmployeeRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 47,
                    Name = AuthorizeDefinitionConstants.EmployeeUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 48,
                    Name = AuthorizeDefinitionConstants.EmployeeDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 49,
                    Name = AuthorizeDefinitionConstants.EmployeeTypeCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 50,
                    Name = AuthorizeDefinitionConstants.EmployeeTypeRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 51,
                    Name = AuthorizeDefinitionConstants.EmployeeTypeUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 52,
                    Name = AuthorizeDefinitionConstants.EmployeeTypeDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 1
                },
                new SubProgram
                {
                    Id = 53,
                    Name = AuthorizeDefinitionConstants.CustomerCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 54,
                    Name = AuthorizeDefinitionConstants.CustomerRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 55,
                    Name = AuthorizeDefinitionConstants.CustomerUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 56,
                    Name = AuthorizeDefinitionConstants.CustomerDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 57,
                    Name = AuthorizeDefinitionConstants.CustomerTypeCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 58,
                    Name = AuthorizeDefinitionConstants.CustomerTypeRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 59,
                    Name = AuthorizeDefinitionConstants.CustomerTypeUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 60,
                    Name = AuthorizeDefinitionConstants.CustomerTypeDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 8
                },
                new SubProgram
                {
                    Id = 61,
                    Name = AuthorizeDefinitionConstants.NotificationCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 6
                },
                new SubProgram
                {
                    Id = 62,
                    Name = AuthorizeDefinitionConstants.NotificationRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 6
                },
                new SubProgram
                {
                    Id = 63,
                    Name = AuthorizeDefinitionConstants.NotificationUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 6
                },
                new SubProgram
                {
                    Id = 64,
                    Name = AuthorizeDefinitionConstants.NotificationDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 6
                },
                new SubProgram
                {
                    Id = 65,
                    Name = AuthorizeDefinitionConstants.BrandCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 9
                },
                new SubProgram
                {
                    Id = 66,
                    Name = AuthorizeDefinitionConstants.BrandUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 9
                },
                new SubProgram
                {
                    Id = 67,
                    Name = AuthorizeDefinitionConstants.BrandDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 9
                },
                new SubProgram
                {
                    Id = 85,
                    Name = AuthorizeDefinitionConstants.BrandRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 9
                },
                new SubProgram
                {
                    Id = 68,
                    Name = AuthorizeDefinitionConstants.BrandDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 9
                },
                new SubProgram
                {
                    Id = 69,
                    Name = AuthorizeDefinitionConstants.SaleStatusCreate,

                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 10
                },
                new SubProgram
                {
                    Id = 70,
                    Name = AuthorizeDefinitionConstants.SaleStatusRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 10
                },
                new SubProgram
                {
                    Id = 71,
                    Name = AuthorizeDefinitionConstants.SaleStatusUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 10
                },
                new SubProgram
                {
                    Id = 72,
                    Name = AuthorizeDefinitionConstants.SaleStatusDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 10
                },
                new SubProgram
                {
                    Id = 73,
                    Name = AuthorizeDefinitionConstants.SaleTypeCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 10
                },
                new SubProgram
                {
                    Id = 74,
                    Name = AuthorizeDefinitionConstants.SaleTypeRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 10
                },
                new SubProgram
                {
                    Id = 75,
                    Name = AuthorizeDefinitionConstants.SaleTypeUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId =10
                },
                new SubProgram
                {
                    Id = 76,
                    Name = AuthorizeDefinitionConstants.SaleTypeDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 10
                },
                new SubProgram
                {
                    Id = 77,
                    Name = AuthorizeDefinitionConstants.ProductGroupCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 7
                },
                new SubProgram
                {
                    Id = 78,
                    Name = AuthorizeDefinitionConstants.ProductGroupRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 11
                },
                new SubProgram
                {
                    Id = 79,
                    Name = AuthorizeDefinitionConstants.ProductGroupUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 11
                },
                new SubProgram
                {
                    Id = 80,
                    Name = AuthorizeDefinitionConstants.ProductGroupDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 11
                },
                new SubProgram
                {
                    Id = 81,
                    Name = AuthorizeDefinitionConstants.ProductSubGroupCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 11
                },
                new SubProgram
                {
                    Id = 82,
                    Name = AuthorizeDefinitionConstants.ProductSubGroupRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 11
                },
                new SubProgram
                {
                    Id = 83,
                    Name = AuthorizeDefinitionConstants.ProductSubGroupUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 11
                },
                new SubProgram
                {
                    Id = 84,
                    Name = AuthorizeDefinitionConstants.ProductSubGroupDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 11
                },
                new SubProgram
                {
                    Id = 89,
                    Name = AuthorizeDefinitionConstants.AppointmentTypeCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=5
                },
                new SubProgram
                {
                    Id = 90,
                    Name = AuthorizeDefinitionConstants.AppointmentTypeRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=5
                },
                new SubProgram
                {
                    Id = 91,
                    Name = AuthorizeDefinitionConstants.AppointmentTypeUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=5
                },
                new SubProgram
                {
                    Id = 92,
                    Name = AuthorizeDefinitionConstants.AppointmentTypeDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=5
                },
                new SubProgram
                {
                    Id = 93,
                    Name = AuthorizeDefinitionConstants.SaleCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId= 10
                },
                new SubProgram
                {
                    Id = 94,
                    Name = AuthorizeDefinitionConstants.SaleRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId= 10
                },
                new SubProgram
                {
                    Id = 95,
                    Name = AuthorizeDefinitionConstants.SaleUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId= 10
                },
                new SubProgram
                {
                    Id = 96,
                    Name = AuthorizeDefinitionConstants.SaleDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=10
                },
                new SubProgram
                {
                    Id = 97,
                    Name = AuthorizeDefinitionConstants.ProductCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=11
                },
                new SubProgram
                {
                    Id = 98,
                    Name = AuthorizeDefinitionConstants.ProductRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=1
                },
                new SubProgram
                {
                    Id = 99,
                    Name = AuthorizeDefinitionConstants.ProductUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=11
                },
                new SubProgram
                {
                    Id = 100,
                    Name = AuthorizeDefinitionConstants.ProductDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=11
                },
                new SubProgram
                {
                    Id = 101,
                    Name = AuthorizeDefinitionConstants.AppointmentCreate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=5
                },
                new SubProgram
                {
                    Id = 102,
                    Name = AuthorizeDefinitionConstants.AppointmentRead,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=5
                },
                new SubProgram
                {
                    Id = 103,
                    Name = AuthorizeDefinitionConstants.AppointmentUpdate,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId=5
                },
                new SubProgram
                {
                    Id = 104,
                    Name = AuthorizeDefinitionConstants.AppointmentDelete,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ProgramId = 5
                }
                
                
            );;
        }
    }
}

