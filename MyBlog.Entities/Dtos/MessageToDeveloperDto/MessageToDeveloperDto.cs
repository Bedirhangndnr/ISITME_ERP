using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.MessageToDeveloperDtos
{
    public class MessageToDeveloperDto : DtoGetBase
    {
        public MessageToDeveloper MessageToDeveloper { get; set; }
    }
}
