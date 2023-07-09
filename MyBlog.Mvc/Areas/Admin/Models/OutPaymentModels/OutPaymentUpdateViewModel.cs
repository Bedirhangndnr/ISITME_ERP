using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class OutPaymentUpdateViewModel:OutPaymentAddViewModel
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
