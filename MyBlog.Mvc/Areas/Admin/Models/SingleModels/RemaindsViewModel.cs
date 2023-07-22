using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class RemaindsViewModel
    {
        public IList<Customer> Customers { get; set; }
    }
}
