using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ParameterDtos
{
    public class ParameterListDto : DtoGetBase
    {
        public IList<Parameter> Parameters { get; set; }
    }
}
