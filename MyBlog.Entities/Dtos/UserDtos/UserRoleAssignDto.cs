using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.RoleDtos;

namespace MyBlog.Entities.Dtos.UserDtos
{
    public class UserRoleAssignDto
    {
        public UserRoleAssignDto()
        {  // bunu constructor içinde initialie ettik çünkü bir Interface tipindeki
           // değişkene tek tek ekleme yapamayız, ancak hazır bir liste varsa atama yapabiliriz.
           // Ve biz buradaki listeye tek tek role ekleyeceğiz. Dolayısıyla önce başlatmamaız gerekti
            RoleAssignDtos = new List<RoleAssignDto>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public IList<RoleAssignDto> RoleAssignDtos { get; set; }
        //public IEnumerable<Module>? Modules { get; set; }
        //public IEnumerable<Program>?Programs { get; set; }
        //public IEnumerable<SubProgram>? SubPrograms { get; set; }


    }
}
