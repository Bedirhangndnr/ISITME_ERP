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
    public class PaymentAddViewModel : ModelGetBase
    {
        [DisplayName("Ödeme Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? PaymentTypeId { get; set; }
        public IList<PaymentType>? PaymentTypes { get; set; }

        [DisplayName("Ödeme Alt Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? AssociatedInstitutionsId { get; set; }
        [DisplayName("İlişkili Kurum")]
        public IList<AssociatedInstitution>? AssociatedInstitutions { get; set; }

        [DisplayName("Hasta tipi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int? CustomerId { get; set; }
        [DisplayName("Hasta")]
        public IList<Customer>? Customers { get; set; }
        [DisplayName("İlgilenen Kişi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")] 
        public int EmployeeId { get; set; }
        [DisplayName("İlgili Personel")]
        public IList<Employee>? Employees { get; set; }
        [DisplayName("Açıklama")]
        public string? Description { get; set; }
        [PaymentAmount]
        [DisplayName("Ödeme Tutarı")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? AmountPaid { get; set; }
    }
}
