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
    public class AppointmentMap : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
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
            builder.Property(a => a.Date).IsRequired();
            builder.HasOne(e => e.Employee)
                 .WithMany(et => et.Appointments)
                 .HasForeignKey(e => e.EmployeeId)
                 .OnDelete(DeleteBehavior.SetNull);
            builder.Property(a => a.Date).IsRequired();
            builder.HasOne(e => e.AppointmentType)
                 .WithMany(et => et.Appointments)
                 .HasForeignKey(e => e.AppointmentTypeId)
                 .OnDelete(DeleteBehavior.SetNull);
            builder.Property(a => a.Date).IsRequired();
            builder.HasOne(e => e.Customer)
                 .WithMany(et => et.Appointments)
                 .HasForeignKey(e => e.CustomerId)
                 .OnDelete(DeleteBehavior.SetNull);
            //builder.HasOne<Employee>(c => c.Employee).WithMany(a => a.Appointments).HasForeignKey(c => c.EmployeeId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Appointments");

            builder.HasData(
                new Appointment
                {
                    Id = 1,
                    Description = "Test Açıklama2",
                    CustomerId = 1,
                    EmployeeId = 1,
                    AppointmentTypeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    Date = new DateTime(1998, 04, 30),

                },
                new Appointment
                {
                    Id = 2,
                    CustomerId = 2,
                    EmployeeId = 1,

                    AppointmentTypeId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    Description = "Test Açıklama",
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    Date = new DateTime(1998, 04, 30),

                },
                new Appointment
                {
                    Id = 3,
                    CustomerId = 3,
                    AppointmentTypeId = 1,
                    EmployeeId = 1,
                    IsActive = true,
                    Description = "Test Açıklama3",
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    Date = new DateTime(1998, 04, 30),

                }
            );
        }
    }
}
