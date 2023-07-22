using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProgramsDtos
{
    public class ProgramDto : DtoGetBase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<SubProgramDto> SubPrograms { get; set; }
        public Program Program{ get; set; }

    }
}
