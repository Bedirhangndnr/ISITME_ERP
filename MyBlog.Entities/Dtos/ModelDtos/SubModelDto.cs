using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ModelDtos
{
    public class SubModelDto : DtoGetBase
    {
        public SubModel SubModel { get; set; }
    }
}
