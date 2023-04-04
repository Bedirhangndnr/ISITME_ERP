using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Dtos.UserDtos;

namespace MyBlog.Mvc.Areas.Admin.Models.UserModels
{
    public class UserRoleAssignAjaxViewModel
    {
        //hata alırsak assgndto, ssgnpartialdönülebilir.
        public UserRoleAssignDto UserRoleAssignDto { get; set; }
        public string RoleAssignPartial { get; set; }
        //userdto işlem başarılıysa dönülecek
        public UserDto UserDto { get; set; }
    }
}
