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

namespace MyBlog.Entities.Dtos.CustomerReferanceDtos
{
    public class CustomerReferanceAddDto:DtoGetBase
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string LastName { get; set; }
        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Phone { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string? Description { get; set; }
        [DisplayName("Not")]
        public string? Note { get; set; } = ""; 

        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }=true;
    }
}
