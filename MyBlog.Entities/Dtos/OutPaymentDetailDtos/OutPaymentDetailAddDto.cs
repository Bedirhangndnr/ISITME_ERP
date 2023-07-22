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

namespace MyBlog.Entities.Dtos.OutPaymentDetailDtos
{
    public class OutPaymentDetailAddDto : DtoGetBase
    {
        [DisplayName("Ödenen Tutar")]
        public decimal AmountPaid { get; set; }

        [Required(ErrorMessage = "Ödeme kaydı kimlik numarası gereklidir.")]
        public int OutPaymentId { get; set; }
        public IList<OutPayment> OutPayments { get; set; }


        [Required(ErrorMessage = "Çalışan kimlik numarası gereklidir.")]
        public int EmployeeId { get; set; }
        public IList<Employee> Employees { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public string? Description { get; set; }

    }
}
