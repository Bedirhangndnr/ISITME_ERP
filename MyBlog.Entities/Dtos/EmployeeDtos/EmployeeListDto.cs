using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.EmployeeDtos
{
    public class EmployeeListDto:DtoGetBase
    {
        public IList<Employee> Employees{ get; set; }
        public IList<EmployeeListWithRelatedTable> EmployeeListWithRelatedTables { get; set; } = null;

    }
}
