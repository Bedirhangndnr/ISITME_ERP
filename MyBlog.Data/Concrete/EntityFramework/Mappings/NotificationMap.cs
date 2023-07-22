using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class NotificationMap:IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
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
            builder.Property(a => a.Description).HasMaxLength(500);
            builder.Property(a => a.Title).HasMaxLength(50);
            builder.ToTable("Notifications");
            builder.HasOne(e => e.Customer)
                    .WithMany(et => et.Notifications)
                    .HasForeignKey(e => e.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(e => e.User)
                     .WithMany(u => u.Notifications)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);
            builder.Property(e => e.UserId).HasDefaultValue(-1);
            builder.HasData(
                new Notification
                {
                    Id = 1,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "TEST",
                    Title = "Title",
                    UserId = 1,
                    CustomerId = 1,
                    IsRead = false,
                    NotificationType = NotificationMessageService.GetType(NotificationTypes.Reminder),
                    TargetDate= DateTime.Now.AddDays(3),
                },
                new Notification
                {
                    Id = 2,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "Doğum günü yaklaşmakta.",
                    Title = "Doğum Günü!",
                    UserId = 2,
                    CustomerId = 2,
                    IsRead = false,
                    NotificationType = NotificationMessageService.GetType(NotificationTypes.Reminder),
                    TargetDate = DateTime.Now.AddDays(2),
                },
                new Notification
                {
                    Id = 3,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Description = "Aylık cihaz bakımı için konuşulacak",
                    Title = "Cihaz Bakımı!",
                    UserId = 2,
                    CustomerId = 3,
                    IsRead = false,
                    NotificationType = NotificationMessageService.GetType(NotificationTypes.Reminder),
                    TargetDate = DateTime.Now.AddDays(1),
                }
            );
        }
    }
}

