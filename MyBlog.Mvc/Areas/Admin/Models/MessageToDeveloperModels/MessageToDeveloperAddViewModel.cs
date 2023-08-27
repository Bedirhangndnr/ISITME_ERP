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
    public class MessageToDeveloperAddViewModel
    {
        [DisplayName("Başlık")]
        [MaxLength(30, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public string? Title { get; set; }
        [DisplayName("Mesaj")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(2, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string Message { get; set; }
        [DisplayName("Okundu mu?")]
        public bool? IsRead { get; set; } = false;
        [DisplayName("Aşama")]
        [MaxLength(2, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public int Progress { get; set; }
        [DisplayName("Teslim Tarihi")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime? EstimatedCompletionDate { get; set; }
    }
}
