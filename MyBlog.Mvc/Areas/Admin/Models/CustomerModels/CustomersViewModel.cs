using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.CustomerDtos;

namespace MyBlog.Mvc.Areas.Admin.Models.CustomerModels
{
    // Şu an Kullanılmıyor.
    public class CustomersViewModel
    {
        public string CustomerTypeName { get; set; }
        public CustomerListDto CustomerListDto { get; set; }
    }

}
