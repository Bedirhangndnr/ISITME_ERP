using MyBlog.Entities.Dtos.UserDtos;

namespace MyBlog.Mvc.Areas.Admin.Models.UserModels
{
    public class UserUpdateAjaxViewModel
    {
        public UserUpdateDto UserUpdateDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string UserUpdatePartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
