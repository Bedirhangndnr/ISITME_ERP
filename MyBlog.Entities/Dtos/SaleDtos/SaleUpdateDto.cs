using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.SaleDtos
{
    public class SaleUpdateDto : SaleAddDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Olmamalıdır...")]
        public bool IsActive { get; set; }
    }
}
