using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProgramsDtos
{
    public class SubProgramDto : DtoGetBase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SubProgram SubProgram{ get; set; }


    }
}
