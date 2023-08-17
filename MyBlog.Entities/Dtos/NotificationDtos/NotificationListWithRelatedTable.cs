using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.AppointmentDtos
{
    public class NotificationListWithRelatedTable: DtoGetBase
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public int? CustomerId { get; set; }
        public string? UserName { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsRead { get; set; }
        public string NotificaitonType { get; set; }

    }
}
