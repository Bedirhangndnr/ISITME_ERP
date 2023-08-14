using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class OutPaymentDetailAddViewModel
    {
        [DisplayName("Ödenen Tutar")]
        public decimal AmountPaid { get; set; }

        [Required(ErrorMessage = "Ödeme kaydı kimlik numarası gereklidir.")]
        public int OutPaymentId { get; set; }
        public IList<OutPayment> OutPayments { get; set; }

        [Required(ErrorMessage = "Personel kimlik numarası gereklidir.")]
        public int EmployeeId { get; set; }
        public IList<Employee> Employees { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public string? Description { get; set; }
    }
}
