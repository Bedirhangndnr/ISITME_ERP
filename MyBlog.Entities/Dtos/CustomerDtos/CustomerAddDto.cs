using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.CustomerDtos
{
    public class CustomerAddDto:DtoGetBase
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MinLength(20, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string LastName { get; set; }
        [DisplayName("E-Posta")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Email { get; set; }
        [DisplayName("Not")]
        public string? Note { get; set; } = "";
        [DisplayName("Randevu Notu")]
        public string? AppointmentNote { get; set; } = "";
        [DisplayName("Hakkında")]
        public string? About { get; set; } = "";
        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Phone { get; set; }
        [DisplayName("Address")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        [MaxLength(300, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Address { get; set; }

        [DisplayName("Ödeme Tipi")]
        public int? PaymentId { get; set; }
        public Payment? Payments { get; set; }
        [DisplayName("Hasta tipi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int CustomerTypeId { get; set; }
        public CustomerType CustomerTypes { get; set; }
        [DisplayName("Hasta Referansı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int CustomerReferanceId { get; set; }
        public CustomerReferance CustomerReferances { get; set; }
        [DisplayName("Randevu Tarihi")]
        public DateTime? AppointmentDate { get; set; }
        [DisplayName("Randevu Saati")]
        public DateTime? AppointmentTime { get; set; }
        [DisplayName("Resim")]
        [DataType(DataType.Upload)]
        public IFormFile? PictureFile { get; set; }
        public string? Picture { get; set; }
        [DisplayName("Raporun Çıktığı Hastane")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string HospitalOfReport { get; set; }
        [DisplayName("TC")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        [MinLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        public string TC { get; set; }
    }
}
