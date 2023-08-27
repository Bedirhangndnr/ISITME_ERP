using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.MessageToDeveloperDtos
{
    public class MessageToDeveloperAddDto : DtoGetBase
    {
        [DisplayName("Başlık")]
        [MaxLength(50, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public string? Title { get; set; }
        [DisplayName("Mesaj")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(2, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string Message { get; set; }
        [DisplayName("Okundu mu?")]
        public bool? IsRead { get; set; } = false;
        [DisplayName("Aşama")]
        public int Progress { get; set; }
        [DisplayName("Teslim Tarihi")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime? EstimatedCompletionDate { get; set; }

    }
}
