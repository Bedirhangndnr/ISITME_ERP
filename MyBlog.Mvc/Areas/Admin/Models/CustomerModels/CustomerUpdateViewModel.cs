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

namespace MyBlog.Mvc.Areas.Admin.Models.CustomerModels
{
    public class CustomerUpdateViewModel: ModelGetBase
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string FirstName { get; set; }
        [DisplayName("SoyAd")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(25, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string LastName { get; set; }
        [DisplayName("Not")]
        public string? Note { get; set; } = "";
        [DisplayName("Randevu Notu")]
        public string? AppointmentNote { get; set; } = "";
        [DisplayName("Hakkında")]
        public string? About { get; set; } = "";
        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        [MinLength(11, ErrorMessage = "{0} alanı {1} karakter olmalıdır.")]
        public string Phone { get; set; }
        [DisplayName("E-Posta")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Email { get; set; }

        [DisplayName("Raporun Çıktığı Hastane")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string? HospitalOfReport { get; set; }
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

        [DisplayName("Hasta tipi")]
        //[Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int? CustomerTypeId { get; set; }
        public IList<CustomerType>? CustomerTypes { get; set; }
        [DisplayName("Hasta Referansı")]
        //[Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int? CustomerReferanceId { get; set; }
        public IList<CustomerReferance>? CustomerReferances { get; set; }
        [DisplayName("Randevu Tarihi")]
        public DateTime? AppointmentDate { get; set; }
        [DisplayName("Randevu Saati")]
        public DateTime? AppointmentTime { get; set; }
        [DisplayName("Resim")]
        //[Required(ErrorMessage = "Lütfen, bir {0} seçiniz.")]
        [DataType(DataType.Upload)]
        public IFormFile? PictureFile { get; set; }
        public string? Picture { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public bool IsActive { get; set; }

        [DisplayName("Silinsin Mi?")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public bool IsDeleted { get; set; }
        [Required]
        public int Id { get; set; }
        [DisplayName("İlgilenen Kişi")]
        public int? EmployeeId { get; set; }
        public IList<Employee>? Employees { get; set; }
    }
}
