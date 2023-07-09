using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDtos;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.OutPaymentDtos
{
    public class OutPaymentUpdateDto : OutPaymentAddDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Olmamalıdır...")]
        public bool IsActive { get; set; }

        [DisplayName("Ödenen Toplam Tutar")]
        public decimal? TotalAmount { get; set; } = 0;

    }
}
