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
    public class AppointmentTypeMap : IEntityTypeConfiguration<AppointmentType>
    {
        public void Configure(EntityTypeBuilder<AppointmentType> builder)
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
            builder.Property(a => a.Description).IsRequired(false);
            builder.Property(a => a.Note).HasMaxLength(1000).IsRequired(false);
            builder.ToTable("AppointmentTypes");

            builder.HasData(
                new AppointmentType
                {
                    Id = 1,
                    Title = "Test",
                    Description = "Test",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                },
                new AppointmentType
                {
                    Id = 2,
                    Title = "Test",
                    Description = "Test",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",

                }
            );
        }
    }
}
