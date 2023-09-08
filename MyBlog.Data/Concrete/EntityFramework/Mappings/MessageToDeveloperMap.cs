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
    public class MessageToDeveloperMap:IEntityTypeConfiguration<MessageToDeveloper>
    {
        public void Configure(EntityTypeBuilder<MessageToDeveloper> builder)
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
            builder.Property(a => a.Message).HasMaxLength(500);

            builder.ToTable("MessageToDevelopers");
            int id = 0;

            builder.HasData(

            new MessageToDeveloper
                {
                Id = id = id + 1,
                IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Message = "TEST",
                    Title = "MessageToDeveloper Title Test",
                    EstimatedCompletionDate = DateTime.Now.AddDays(5),
                    IsRead=false,
                    Progress = 3
                },
            new MessageToDeveloper
                {
                Id = id = id + 1,
                IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Message = "TEST 2222222222222222",
                    Title = "MessageToDeveloper Title Test",
                    EstimatedCompletionDate = DateTime.Now.AddDays(5),
                    IsRead=false,
                    Progress = 1
                },
            new MessageToDeveloper
                {
                Id = id = id + 1,
                IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Test Verisi",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "Test Verisi",
                    ModifiedDate = DateTime.Now,
                    Message = "TEST 2222222222222222",
                    Title = "MessageToDeveloper Title Test",
                    EstimatedCompletionDate = DateTime.Now.AddDays(3),
                    IsRead=false,
                    Progress = 4
                }
            );
        }
    }
}

