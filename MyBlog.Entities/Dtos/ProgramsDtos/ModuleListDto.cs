using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProgramsDtos
{
    public class ModuleListDto : DtoGetBase
    {
        public List<Module> Modules { get; set; }

    }
}
