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
    public class AppointmentUpdateDto : AppointmentAddDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Randevu Yapıldı Mı?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool? IsMade { get; set; }
    }
}
