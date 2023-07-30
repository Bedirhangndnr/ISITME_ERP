using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.CustomerReferanceTitleDtos
{
    public class CustomerReferanceTitleAddDto:DtoGetBase
    {
        [DisplayName("Ünvan")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Title { get; set; }

    }
}
