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
        [DisplayName("Ödenen Tutar")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int AmountPaid { get; set; } = 0;
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
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
    }
}
