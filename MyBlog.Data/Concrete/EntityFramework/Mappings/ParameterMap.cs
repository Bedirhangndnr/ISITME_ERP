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
    public class ParameterMap:IEntityTypeConfiguration<Parameter>
    {
        public void Configure(EntityTypeBuilder<Parameter> builder)
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
            builder.Property(a => a.ParamCode).HasMaxLength(50);
            builder.Property(a => a.ParamDescription).HasMaxLength(50);
            builder.Property(a => a.ParamValue).HasMaxLength(50);
            builder.Property(a => a.ParamValue1).HasMaxLength(50);
            builder.Property(a => a.ParamValue2).HasMaxLength(50);
            builder.Property(a => a.ParamValue3).HasMaxLength(50);
            builder.Property(a => a.ParamValue4).HasMaxLength(50);
            builder.Property(a => a.ParamValue5).HasMaxLength(50);
            builder.Property(a => a.ParamValue6).HasMaxLength(50);
            builder.ToTable("Parameter");


            builder.HasData(
              new Parameter
              {
                  Id = 1,
                  ParamCode = "SGKTutari",
                  ParamType = "Tutar Tipi 1",
                  ParamValue = "1000"  // TUTAR
              }
          );

        }
    }
}
