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
    public class OutPaymentAddViewModel : ModelGetBase
    {
        [DisplayName("Toplam Borç")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [PaymentAmount]
        public decimal DebtAmount { get; set; } = 0;
        [DisplayName("Ödenen Tutar")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [PaymentAmount]
        public decimal AmountPaid { get; set; } = 0;
        [DisplayName("Açıklama")]
        public string? Description { get; set; }
        [DisplayName("Ödendi Mi?")]
        public bool? IsPaid { get; set; }
        [DisplayName("Ödeme Yapılacak olan yer")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [MaxLength(100, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string PaidPlace { get; set; }
        [DisplayName("Son Ödeme Tarihi")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime DueDate { get; set; }

        public IList<OutPaymentDetail> OutPaymentDetails { get; set; }

    }
}
