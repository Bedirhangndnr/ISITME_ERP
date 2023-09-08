using System;
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
    public class CustomerMap:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
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
            builder.Property(a => a.FirstName).HasMaxLength(50);
            builder.Property(a => a.LastName).HasMaxLength(50);
            builder.Property(a => a.About).HasMaxLength(500);
            builder.Property(a => a.Picture).HasMaxLength(200);
            builder.Property(a => a.Address).HasMaxLength(300);
            builder.HasOne(e => e.CustomerReferance)
                .WithMany(et => et.Customers)
                .HasForeignKey(e => e.CustomerReferanceId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(e => e.CustomerType)
                .WithMany(et => et.Customers)
                .HasForeignKey(e => e.CustomerTypeId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(e => e.Employee)
                .WithMany(et => et.Customers)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.ToTable("Customers");

            builder.HasData(
                new Customer
                {
                    Id = 1,
                    CustomerReferanceId = 1,
                    CustomerTypeId = 1,
                    EmployeeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                    About = "Yazılımcı, 20 yaşında",
                    FirstName = "Bedirhan",
                    LastName = "Gündöner",
                    Picture = "/userImages/defaultUser.png",
                    Email="hasta1@gmail.com",
                    Phone="05050102249",
                    Address="Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC = "45677891170",
                    HospitalOfReport="Kadıköy Hastanesi",
                    BirthDate= DateTime.Now.AddDays(4)
                    
                },
                new Customer
                {
                    Id = 2,
                    CustomerReferanceId = 1,
                    CustomerTypeId = 2,
                    EmployeeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                    About = "Yazılımcı, 20 yaşında",
                    FirstName = "Bedirhan",
                    LastName = "Gündöner",
                    Picture = "/userImages/defaultUser.png",
                    Email = "hasta2@gmail.com",
                    Phone = "05050102249",
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC="45677891170",
                    HospitalOfReport = "Kadıköy Hastanesi",
                    BirthDate = DateTime.Now.AddDays(5)
                },
                new Customer
                {
                    CustomerReferanceId = 2,
                    CustomerTypeId = 3,
                    Id = 3,
                    EmployeeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                    About = "Yazılımcı, 20 yaşında",
                    FirstName = "Bedirhan",
                    LastName = "Gündöner",
                    Picture = "/userImages/defaultUser.png",
                    Email = "hasta3@gmail.com",
                    Phone = "05050102249",
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC="45677891170",
                    HospitalOfReport = "Kadıköy Hastanesi",
                    BirthDate= DateTime.Now.AddDays(6)

                },
                new Customer
                {
                    CustomerReferanceId = 2,
                    CustomerTypeId = 3,
                    Id = 4,
                    EmployeeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                    About = "Yazılımcı, 20 yaşında",
                    FirstName = "Bedirhan",
                    LastName = "Gündöner",
                    Picture = "/userImages/defaultUser.png",
                    Email = "hasta3@gmail.com",
                    Phone = "05050102249",
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC="45677891170",
                    HospitalOfReport = "Kadıköy Hastanesi",
                    BirthDate= DateTime.Now.AddDays(7)

                },
                new Customer
                {
                    CustomerReferanceId = 2,
                    CustomerTypeId = 3,
                    Id = 5,
                    EmployeeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                    About = "Yazılımcı, 20 yaşında",
                    FirstName = "Bedirhan",
                    LastName = "Gündöner",
                    Picture = "/userImages/defaultUser.png",
                    Email = "hasta3@gmail.com",
                    Phone = "05050102249",
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC="45677891170",
                    HospitalOfReport = "Kadıköy Hastanesi",
                    BirthDate= DateTime.Now.AddDays(8)

                },
                new Customer
                {
                    CustomerReferanceId = 2,
                    CustomerTypeId = 3,
                    Id = 6,
                    EmployeeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                    About = "Yazılımcı, 20 yaşında",
                    FirstName = "Bedirhan",
                    LastName = "Gündöner",
                    Picture = "/userImages/defaultUser.png",
                    Email = "hasta3@gmail.com",
                    Phone = "05050102249",
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC = "45677891170",
                    HospitalOfReport = "Kadıköy Hastanesi",
                    BirthDate= DateTime.Now.AddDays(9)

                },
                new Customer
                {
                    CustomerReferanceId = 2,
                    CustomerTypeId = 3,
                    Id = 7,
                    EmployeeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "TEST",
                    About = "Yazılımcı, 20 yaşında",
                    FirstName = "Bedirhan",
                    LastName = "Gündöner",
                    Picture = "/userImages/defaultUser.png",
                    Email = "hasta3@gmail.com",
                    Phone = "05050102249",
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC="45677891170",
                    HospitalOfReport = "Kadıköy Hastanesi",
                    BirthDate= DateTime.Now.AddDays(10)
                }
            );
        }
    }
}
