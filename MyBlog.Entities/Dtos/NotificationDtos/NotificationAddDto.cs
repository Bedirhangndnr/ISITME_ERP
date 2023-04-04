using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.NotificationDtos
{
    public class NotificationAddDto : DtoGetBase
    {
        public string? Note { get; set; }
        public bool? IsRead { get; set; }
        public string Description { get; set; }
        public string? Title { get; set; } 
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public string? NotificationType { get; set; }
        public DateTime? TargetDate { get; set; }
    }
}
