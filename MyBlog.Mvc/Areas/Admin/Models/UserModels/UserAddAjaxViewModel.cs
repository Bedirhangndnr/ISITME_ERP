using MyBlog.Entities.Dtos.UserDtos;

namespace MyBlog.Mvc.Areas.Admin.Models.UserModels
{
    public class UserAddAjaxViewModel
    {
        public UserAddDto UserAddDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string UserAddPartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
