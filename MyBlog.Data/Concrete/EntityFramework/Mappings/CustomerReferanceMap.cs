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
    public class CustomerReferanceMap:IEntityTypeConfiguration<CustomerReferance>
    {
        public void Configure(EntityTypeBuilder<CustomerReferance> builder)
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
            builder.Property(a => a.FirstName).HasMaxLength(50);
            builder.Property(a => a.LastName).HasMaxLength(50);
            builder.Property(a => a.Phone).HasMaxLength(20);
            builder.ToTable("CustomerReferances");
            builder.HasData(
                new CustomerReferance
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    FirstName = "Sema",
                    LastName = "Gündöner",
                    Phone = "+905050102249",
                    Description = "Description",
                },
                new CustomerReferance
                {
                    Id = 2,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Hastanın ihtiyaçları tespit edildi. Cihaz denenecek",
                    FirstName = "Sema",
                    LastName = "Gündöner",
                    Phone = "+905050102249",
                    Description = "Description",
                }
            );
        }
    }
}
