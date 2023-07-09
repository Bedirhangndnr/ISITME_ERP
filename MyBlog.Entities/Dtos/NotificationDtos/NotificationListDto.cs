using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.NotificationDtos
{
    public class NotificationListDto:DtoGetBase
    {
        public IList<Notification> Notifications{ get; set; }
        public IList<NotificationListWithRelatedTable> NotificationListWithRelatedTables{ get; set; }

    }
}
