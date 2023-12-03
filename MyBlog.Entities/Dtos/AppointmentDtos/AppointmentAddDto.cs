using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.AppointmentDtos
{
    public class AppointmentAddDto : DtoGetBase
    {
        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        [DisplayName("Kayıtsız Hasta Adı")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(2, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string? NewCustomerName { get; set; }
        [DisplayName("Personel")]
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Date { get; set; }
        [DisplayName("Randevu Tipi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public AppointmentType? AppointmentType { get; set; }
        public int? AppointmentTypeId { get; set; }

        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string? Description { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [MaxLength(35, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(2, ErrorMessage = "{0} {1} Karakterden Küçük Olmamalıdır")]
        public string? Title { get; set; }







    }
}
