using MyBlog.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models.UserModels
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
