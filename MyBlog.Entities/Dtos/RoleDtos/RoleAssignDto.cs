using MyBlog.Entities.Dtos.ProgramsDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.RoleDtos
{
    public class RoleAssignDto
    {
        public int RoleId { get; set; }
        [DisplayName("Rol Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public string RoleName { get; set; }
        [DisplayName("Rol Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public string RoleDefinition { get; set; }
        public bool HasRole { get; set; }
        public int AccessLevel { get; set; }

    }
}
