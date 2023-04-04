using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class NotificationViewModel
    {
        public IList<Entities.Concrete.Notification> Notifications { get; set; }
    }
}
