using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class EmployeeAddViewModel : ModelGetBase
    {
        [DisplayName("Resim")]
        [DataType(DataType.Upload)]
        public IFormFile? PictureFile { get; set; }
        public string? Picture { get; set; }
        [DisplayName("Personel Kategorisi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int EmployeeTypeId { get; set; }
        [DisplayName("Personeller")]
        public IList<EmployeeType>? EmployeeTypes { get; set; }
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
        [EmailAddress]
        [DisplayName("E-posta")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1}'den büyük olamaz.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1}'den küçük olamaz.")]
        public string? Email { get; set; }
        [Phone]
        [DisplayName("Telefon Numarası")]
        //[MaxLength(15, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        //[MinLength(8, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Phone { get; set; }
        [DisplayName("TC")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        [MinLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        public string TC { get; set; }
        [DisplayName("Address")]
        [MaxLength(300, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string? Address { get; set; }
        [DisplayName("Not")]
        public string? Note { get; set; } = "";

        [DisplayName("Doğum Tarihi")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime BirthDate { get; set; }


        [DisplayName("Başlangıç Tarih")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime StartDate { get; set; }
    }
}
