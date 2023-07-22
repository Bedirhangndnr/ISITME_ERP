using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.OutPaymentDetailDtos
{
    public class OutPaymentDetailUpdateDto : OutPaymentDetailAddDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Olmamalıdır...")]
        public bool IsActive { get; set; }
    }
}
