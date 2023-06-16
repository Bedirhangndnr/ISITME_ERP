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

namespace MyBlog.Entities.Dtos.PaymentDtos
{
    public class PaymentAddDto : DtoGetBase
    {
        [DisplayName("Ödeme Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int PaymentTypeId { get; set; }
        //public PaymentType PaymentType { get; set; }


        [DisplayName("ÖDeme Alt Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int AssociatedInstitutionsId { get; set; }
        public AssociatedInstitution AssociatedInstitutions { get; set; }


        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [DisplayName("Personel")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int EmployeeId { get; set; }
        public Customer Employee { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public string? Description { get; set; }
        [DisplayName("Ödenen Tutar")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? AmountPaid { get; set; }
    }
}
