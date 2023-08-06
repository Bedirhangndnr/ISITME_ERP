using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfNotificationRepository : EfEntityRepositoryBase<Notification>, INotificationRepository
    {
        public EfNotificationRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<NotificationListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<Notification, bool>> predicate = null, params Expression<Func<Notification, object>>[] includeProperties)
        {
            IQueryable<Notification> query = _context.Set<Notification>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            List<NotificationListWithRelatedTable> notification = await query
                .Include(s => s.Customer)
                .Include(s => s.User)
                .Select(s => new NotificationListWithRelatedTable
                {
                    Id = s.Id,
                    CustomerId = s.Customer != null ? s.Customer.Id : null,
                    UserId = s.User != null ? s.User.Id : null,
                    CustomerName = s.Customer != null ? (s.Customer.FirstName + " " + s.Customer.LastName) : "Belirtilmemiş Ya Da Silinmiş.",
                    UserName = s.User != null ? (s.User.FirstName + " " + s.User.LastName) : "Belirtilmemiş Ya Da Silinmiş.",
                    Description = s.Description != null ? s.Description : "Belirtilmemiş Ya Da Silinmiş.",
                    CreatedDate = s.CreatedDate,
                    Title = s.Title,
                    IsRead= s.IsRead
                })
                .OrderByDescending(c => c.CreatedDate)
                .ToListAsync();

            return notification;
        }
    }
}
