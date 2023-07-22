﻿using System;
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
    public class AppointmentUpdateViewModel:AppointmentAddViewModel
    {
        [DisplayName("Yapıldı Mı?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsMade { get; set; }
        [Required]
        public int Id { get; set; }
    }
}
