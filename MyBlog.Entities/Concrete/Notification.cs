using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Notification : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public int? UserId { get; set; }
        public User? User{ get; set; }
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public string NotificationType { get; set; }
        public DateTime? TargetDate { get; set;}
    }
}
