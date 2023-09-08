using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Concrete
{
    public class User:IdentityUser<int>
    {
        public string Picture { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public string About { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Link { get; set; }
        public string Institution { get; set; }

    }
}
