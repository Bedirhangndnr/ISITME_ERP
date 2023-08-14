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
    public class AppointmentAddViewModel : ModelGetBase
    {
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string? Description { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [MaxLength(35, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(2, ErrorMessage = "{0} {1} Karakterden Küçük Olmamalıdır")]
        public string? Title { get; set; }
        [DisplayName("Tarih")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public DateTime Date { get; set; }
        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? CustomerID { get; set; }
        public IList<Customer>? Customers { get; set; }
        [Display(Name = "Personellar")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int EmployeeId { get; set; }
        public IList<Employee> Employees { get; set; }    
        [DisplayName("Randevu Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int AppointmentTypeId { get; set; }
        public IList<AppointmentType> AppointmentTypes { get; set; }
    }
}
