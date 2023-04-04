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
    public class EmployeeMap:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            builder.Property(u => u.FirstName).HasMaxLength(30);
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.Property(u => u.About).HasMaxLength(1000);
            builder.HasOne(e => e.EmployeeType)
                .WithMany(et => et.Employees)
                .HasForeignKey(e => e.EmployeeTypeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(
                new Employee
                {
                    Id = 1,
                    EmployeeTypeId = 1,
                    Picture = "/userImages/defaultUser.png",
                    FirstName = "Personel 1",
                    LastName = "User",
                    About = "Editor User of MyBlog",
                    Phone = "+905555555555",
                    IsActive = true,
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC = "45677891170",
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                },

                new Employee
                {
                    Id = 2,
                    EmployeeTypeId = 1,
                    Picture = "/userImages/defaultUser.png",
                    FirstName = "Ikinci Personel",
                    LastName = "User",
                    About = "Editor User of MyBlog",
                    Phone = "+905555555555",
                    IsActive = true,
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC = "45677891170",
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                },

                new Employee
                {
                    Id = 3,
                    EmployeeTypeId = 1,
                    Picture = "/userImages/defaultUser.png",
                    FirstName = "Ucuncu perosnel",
                    LastName = "User",
                    About = "Editor User of MyBlog",
                    Phone = "+905555555555",
                    IsActive = true,
                    Address = "Kocaeli Avclar Cadde 1000 Kat 2034 Daire 2",
                    TC = "45677891170",
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                }
           );
        }
    }
}
