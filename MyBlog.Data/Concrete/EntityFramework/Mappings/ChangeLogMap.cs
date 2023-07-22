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
    public class ChangeLogMap:IEntityTypeConfiguration<ChangeLog>
    {
        public void Configure(EntityTypeBuilder<ChangeLog> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.ToTable("ChangeLogs");

            builder.HasData(
                new ChangeLog
                {
                    Id = 1,
                    Action="act Manuel"
                }
            );
        }
    }
}

