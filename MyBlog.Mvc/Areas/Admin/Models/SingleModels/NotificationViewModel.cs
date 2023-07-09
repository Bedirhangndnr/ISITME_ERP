using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class NotificationViewModel
    {
        public IList<NotificationListWithRelatedTable> notificationListWithRelatedTables { get; set; }
    }
}
