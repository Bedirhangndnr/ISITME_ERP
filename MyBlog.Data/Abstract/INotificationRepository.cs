using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.NotificationDtos;
using MyBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Abstract
{
    public interface INotificationRepository:IEntityRepository<Notification>
    {
        public Task<IList<NotificationListWithRelatedTable>> GetAllWithNamesAsync(Expression<Func<Notification, bool>> predicate = null, params Expression<Func<Notification, object>>[] includeProperties);
    }
}
