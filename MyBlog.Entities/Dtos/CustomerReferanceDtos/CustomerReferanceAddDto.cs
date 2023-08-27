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
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(11, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır. (0 ile birlikte)")] // +905555555555 // 13 characters
        [MinLength(11, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır. (0 ile birlikte)")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [DisplayName("Doğum Tarihi")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime BirthDate { get; set; } //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        [DisplayName("TC")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır. (0 ile birlikte)")]
        public string? TC { get; set; }
        [DisplayName("Kurum")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır. (0 ile birlikte)")]
        public string? FromWhere { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string? Description { get; set; }
        [DisplayName("Not")]
        public string? Note { get; set; } = ""; 

        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }=true;
        public int? CustomerReferanceTitleId { get; set; }
        public IList<CustomerReferanceTitle>? CustomerReferanceTitles { get; set; }
    }
}
