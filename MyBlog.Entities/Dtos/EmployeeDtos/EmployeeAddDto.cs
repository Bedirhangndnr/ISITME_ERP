using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.EmployeeDtos
{
    public class EmployeeAddDto : DtoGetBase
    {
        public string Picture { get; set; }
        [DisplayName("Çalışan Kategorisi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
        [DisplayName("Hakkında")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1}'den büyük olamaz.")]
        public string? About { get; set; }
        [DisplayName("Ad")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1}'den büyük olamaz.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1}'den küçük olamaz.")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1}'den büyük olamaz.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1}'den küçük olamaz.")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public string LastName { get; set; }
        [DisplayName("E-posta")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1}'den büyük olamaz.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1}'den küçük olamaz.")]
        public string? Email { get; set; }
        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(15, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(8, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Phone { get; set; }
        [DisplayName("TC")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        [MinLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        public string TC { get; set; }
        [DisplayName("Address")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        [MaxLength(300, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Address { get; set; }
        [DisplayName("Not")]
        public string? Note { get; set; } = "";
    }
}
